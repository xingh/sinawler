using System;
using System.Collections.Generic;
using System.Text;
using Sina.Api;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Sinawler.Model;
using System.Data;
using System.Xml;

namespace Sinawler
{
    class UserRelationRobot : RobotBase
    {
        private UserQueue queueUserForUserInfoRobot;        //用户信息机器人使用的用户队列引用
        private UserQueue queueUserForUserRelationRobot;    //用户关系机器人使用的用户队列引用
        private UserQueue queueUserForUserTagRobot;         //用户标签机器人使用的用户队列引用
        private UserQueue queueUserForStatusRobot;          //微博机器人使用的用户队列引用
        private long lQueueBufferFirst = 0;   //用于记录获取的关注用户列表、粉丝用户列表的队头值
        private bool blnConfirmRelationship = false;

        public bool ConfirmRelationship
        {
            set { blnConfirmRelationship = value; }
        }

        public UserRelationRobot()
            : base(SysArgFor.USER_RELATION)
        {
            strLogFile = Application.StartupPath + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + "_userRelation.log";
            queueUserForUserInfoRobot = GlobalPool.UserQueueForUserInfoRobot;
            queueUserForUserRelationRobot = GlobalPool.UserQueueForUserRelationRobot;
            queueUserForUserTagRobot = GlobalPool.UserQueueForUserTagRobot;
            queueUserForStatusRobot = GlobalPool.UserQueueForStatusRobot;
        }

        /// <summary>
        /// 以指定的UserID为起点开始爬行
        /// </summary>
        /// <param name="lUid"></param>
        public void Start(long lStartUserID)
        {
            if (lStartUserID == 0) return;
            AdjustFreq();
            Log("The initial requesting interval is " + crawler.SleepTime.ToString() + "ms. " + api.ResetTimeInSeconds.ToString() + "s and " + api.RemainingHits.ToString() + " requests left this hour.");

            //将起始UserID入队
            queueUserForUserRelationRobot.Enqueue(lStartUserID);
            queueUserForUserInfoRobot.Enqueue(lStartUserID);
            queueUserForUserTagRobot.Enqueue(lStartUserID);
            queueUserForStatusRobot.Enqueue(lStartUserID);
            lCurrentID = lStartUserID;

            //对队列无限循环爬行，直至有操作暂停或停止
            while (true)
            {
                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(GlobalPool.SleepMsForThread);
                }

                //将队头取出
                lCurrentID = queueUserForUserRelationRobot.RollQueue();

                //日志
                Log("Recording current UserID：" + lCurrentID.ToString() + "...");
                SysArg.SetCurrentID(lCurrentID, SysArgFor.USER_RELATION);

                #region 用户关注列表
                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(GlobalPool.SleepMsForThread);
                }
                //日志                
                Log("Crawling the followings of User " + lCurrentID.ToString() + "...");
                //爬取当前用户的关注的用户ID，记录关系，加入队列
                LinkedList<long> lstBuffer = crawler.GetFriendsOf(lCurrentID, -1);
                //日志
                Log(lstBuffer.Count.ToString() + " followings crawled.");

                while (lstBuffer.Count > 0)
                {
                    if (blnAsyncCancelled) return;
                    while (blnSuspending)
                    {
                        if (blnAsyncCancelled) return;
                        Thread.Sleep(GlobalPool.SleepMsForThread);
                    }
                    lQueueBufferFirst = lstBuffer.First.Value;
                    bool blnRecordRelation = true;
                    if (blnConfirmRelationship)
                    {
                        //日志                
                        Log("Confirming the relationship between User " + lCurrentID.ToString() + " and User " + lQueueBufferFirst.ToString());
                        blnRecordRelation = crawler.RelationExistBetween(lCurrentID, lQueueBufferFirst);
                        if (blnRecordRelation)
                        {
                            //日志
                            Log("Relationship confirmed. Recording User " + lCurrentID.ToString() + " follows User " + lQueueBufferFirst.ToString() + "...");
                        }
                        else
                        {
                            //日志
                            Log("Relationship not exists. Recording invalid relationship...");
                            InvalidRelation ir = new InvalidRelation();
                            ir.source_user_id = lCurrentID;
                            ir.target_user_id = lQueueBufferFirst;
                            ir.Add();

                            Log("Recording invalid User " + lQueueBufferFirst.ToString() + "...");
                            InvalidUser iu = new InvalidUser();
                            iu.user_id = lQueueBufferFirst;
                            iu.Add();

                            //将该用户ID从各个队列中去掉
                            Log("Removing invalid User " + lQueueBufferFirst.ToString() + " from all queues...");
                            queueUserForUserInfoRobot.Remove(lQueueBufferFirst);
                            queueUserForUserRelationRobot.Remove(lQueueBufferFirst);
                            queueUserForUserTagRobot.Remove(lQueueBufferFirst);
                            queueUserForStatusRobot.Remove(lQueueBufferFirst);
                        }
                    }
                    else
                    {
                        //日志
                        Log("Recording User " + lCurrentID.ToString() + " follows User " + lQueueBufferFirst.ToString() + "...");
                    }
                    if (blnRecordRelation)
                    {
                        if (UserRelation.RelationshipExist(lCurrentID, lQueueBufferFirst))
                        {
                            //日志
                            Log("Relationship exists.");
                        }
                        else
                        {
                            UserRelation ur = new UserRelation();
                            ur.source_user_id = lCurrentID;
                            ur.target_user_id = lQueueBufferFirst;
                            ur.Add();
                        }

                        //加入队列
                        if (queueUserForUserRelationRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Relation Robot...");
                        if (GlobalPool.UserInfoRobotEnabled && queueUserForUserInfoRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Information Robot...");
                        if (GlobalPool.TagRobotEnabled && queueUserForUserTagRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Tag Robot...");
                        if (GlobalPool.StatusRobotEnabled && queueUserForStatusRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of Status Robot...");
                    }
                    //日志
                    AdjustFreq();
                    Log("Requesting interval is adjusted as " + crawler.SleepTime.ToString() + "ms." + api.ResetTimeInSeconds.ToString() + "s and " + api.RemainingHits.ToString() + " requests left this hour.");
                    lstBuffer.RemoveFirst();
                }
                #endregion
                #region 用户粉丝列表
                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(GlobalPool.SleepMsForThread);
                }
                //日志                
                Log("Crawling the followers of User " + lCurrentID.ToString() + "...");
                //爬取当前用户的粉丝的用户ID，记录关系，加入队列
                lstBuffer = crawler.GetFollowersOf(lCurrentID, -1);
                //日志
                Log(lstBuffer.Count.ToString() + " followers crawled.");

                while (lstBuffer.Count > 0)
                {
                    if (blnAsyncCancelled) return;
                    while (blnSuspending)
                    {
                        if (blnAsyncCancelled) return;
                        Thread.Sleep(GlobalPool.SleepMsForThread);
                    }
                    lQueueBufferFirst = lstBuffer.First.Value;
                    bool blnRecordRelation = true;
                    if (blnConfirmRelationship)
                    {
                        //日志                
                        Log("Confirming the relationship between User " + lQueueBufferFirst.ToString() + " and User " + lCurrentID.ToString());
                        blnRecordRelation = crawler.RelationExistBetween(lQueueBufferFirst, lCurrentID);
                        if (blnRecordRelation)
                        {
                            //日志
                            Log("Relationship confirmed. Recording User " + lQueueBufferFirst.ToString() + " follows User " + lCurrentID.ToString() + "...");
                        }
                        else
                        {
                            //日志
                            Log("Relationship not exists. Recording invalid relationship...");
                            InvalidRelation ir = new InvalidRelation();
                            ir.source_user_id = lQueueBufferFirst;
                            ir.target_user_id = lCurrentID;
                            ir.Add();

                            Log("Recording invalid User " + lQueueBufferFirst.ToString() + "...");
                            InvalidUser iu = new InvalidUser();
                            iu.user_id = lQueueBufferFirst;
                            iu.Add();

                            //将该用户ID从各个队列中去掉
                            Log("Removing invalid User " + lQueueBufferFirst.ToString() + " from all queues...");
                            queueUserForUserInfoRobot.Remove(lQueueBufferFirst);
                            queueUserForUserRelationRobot.Remove(lQueueBufferFirst);
                            queueUserForUserTagRobot.Remove(lQueueBufferFirst);
                            queueUserForStatusRobot.Remove(lQueueBufferFirst);
                        }
                    }
                    else
                    {
                        //日志
                        Log("Recording User " + lQueueBufferFirst.ToString() + " follows User " + lCurrentID.ToString() + "...");
                    }
                    if (blnRecordRelation)
                    {
                        if (UserRelation.RelationshipExist(lQueueBufferFirst, lCurrentID))
                        {
                            //日志
                            Log("Relationship exists.");
                        }
                        else
                        {
                            UserRelation ur = new UserRelation();
                            ur.source_user_id = lQueueBufferFirst;
                            ur.target_user_id = lCurrentID;
                            ur.Add();
                        }

                        //加入队列
                        if (queueUserForUserRelationRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Relation Robot...");
                        if (GlobalPool.UserInfoRobotEnabled && queueUserForUserInfoRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Information Robot...");
                        if (GlobalPool.TagRobotEnabled && queueUserForUserTagRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of User Tag Robot...");
                        if (GlobalPool.StatusRobotEnabled && queueUserForStatusRobot.Enqueue(lQueueBufferFirst))
                            //日志
                            Log("Adding User " + lQueueBufferFirst.ToString() + " to the user queue of Status Robot...");
                    }
                    //日志
                    AdjustFreq();
                    Log("Requesting interval is adjusted as " + crawler.SleepTime.ToString() + "ms." + api.ResetTimeInSeconds.ToString() + "s and " + api.RemainingHits.ToString() + " requests left this hour.");
                    lstBuffer.RemoveFirst();
                }
                #endregion
                //日志
                Log("Social grapgh of User " + lCurrentID.ToString() + " crawled.");
                //日志
                AdjustFreq();
                Log("Requesting interval is adjusted as " + crawler.SleepTime.ToString() + "ms." + api.ResetTimeInSeconds.ToString() + "s and " + api.RemainingHits.ToString() + " requests left this hour.");
            }
        }

        public override void Initialize()
        {
            //初始化相应变量
            blnAsyncCancelled = false;
            blnSuspending = false;
            crawler.StopCrawling = false;
            queueUserForUserRelationRobot.Initialize();
        }

        sealed protected override void AdjustFreq()
        {
            base.AdjustRealFreq();
            SetCrawlerFreq();
        }
    }
}
