using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Sinawler.Model;
using System.Data;

namespace Sinawler
{
    class StatusRobot : RobotBase
    {
        private long lCurrentSID = 0;                       //currently processing status id

        //构造函数，需要传入相应的新浪微博API和主界面
        public StatusRobot()
            : base(SysArgFor.STATUS)
        {
            strLogFile = Application.StartupPath + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + "_status.log";
            queueUserForUserInfoRobot = GlobalPool.UserQueueForUserInfoRobot;
            queueUserForUserRelationRobot = GlobalPool.UserQueueForUserRelationRobot;
            queueUserForUserTagRobot = GlobalPool.UserQueueForUserTagRobot;
            queueUserForStatusRobot = GlobalPool.UserQueueForStatusRobot;
            queueStatus = GlobalPool.StatusQueue;
        }

        /// <summary>
        /// 处理并保存爬取的微博数据
        /// </summary>
        private void SaveStatus(Status status)
        {
            lCurrentSID = status.status_id;
            if (!Status.Exists(lCurrentSID))
            {
                //日志
                Log("Saving Status " + lCurrentSID.ToString() + " into database...");
                status.Add();
            }

            if (queueStatus.Enqueue(lCurrentSID))
                Log("Adding Status " + lCurrentSID.ToString() + " to status queue...");

            //若该微博有转发，将转发微博保存
            if (status.retweeted_status != null)
            {
                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(10);
                }

                //日志
                Log("Status " + status.retweeted_status.status_id.ToString() + " is retweeted by Status " + lCurrentSID.ToString() + ", saving it into database...");

                if (!Status.Exists(status.retweeted_status.status_id))
                {
                    status.retweeted_status.Add();

                    //日志
                    Log("Retweeted Status " + status.retweeted_status.status_id.ToString() + " saved.");
                }
                else
                {
                    //日志
                    Log("Retweeted Status " + status.retweeted_status.status_id.ToString() + " exists.");
                }

                if (queueStatus.Enqueue(status.retweeted_status.status_id))
                    Log("Adding retweeted Status " + status.retweeted_status.status_id.ToString() + " to status queue...");

                if (queueUserForUserRelationRobot.Enqueue(status.retweeted_status.user.user_id))
                    Log("Adding User " + status.retweeted_status.user.user_id.ToString() + " to the user queue of User Relation Robot...");
                if (GlobalPool.UserInfoRobotEnabled && queueUserForUserInfoRobot.Enqueue(status.retweeted_status.user.user_id))
                    Log("Adding User " + status.retweeted_status.user.user_id.ToString() + " to the user queue of User Information Robot...");
                if (GlobalPool.TagRobotEnabled && queueUserForUserTagRobot.Enqueue(status.retweeted_status.user.user_id))
                    Log("Adding User " + status.retweeted_status.user.user_id.ToString() + " to the user queue of User Tag Robot...");
                if (GlobalPool.StatusRobotEnabled && queueUserForStatusRobot.Enqueue(status.retweeted_status.user.user_id))
                    Log("Adding User " + status.retweeted_status.user.user_id.ToString() + " to the user queue of Status Robot...");
                if (!User.ExistInDB(status.retweeted_status.user.user_id))
                {
                    Log("Saving User " + status.retweeted_status.user.user_id.ToString() + " into database...");
                    status.retweeted_status.user.Add();
                }
            }
        }

        /// <summary>
        /// 开始爬取微博数据
        /// </summary>
        public void Start()
        {
            //获取上次中止处的用户ID并入队
            long lLastUID = SysArg.GetCurrentID(SysArgFor.STATUS);
            if (lLastUID > 0) queueUserForStatusRobot.Enqueue(lLastUID);
            while (queueUserForStatusRobot.Count == 0)
            {
                if (blnAsyncCancelled) return;
                Thread.Sleep(GlobalPool.SleepMsForThread);   //若队列为空，则等待
            }

            AdjustRealFreq();
            SetCrawlerFreq();
            Log("The initial requesting interval is " + crawler.SleepTime.ToString() + "ms. " + api.ResetTimeInSeconds.ToString() + "s, " + api.RemainingIPHits.ToString() + " IP hits and " + api.RemainingUserHits.ToString() + " user hits left this hour.");

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
                //lCurrentID = queueUserForStatusRobot.RollQueue();
                lCurrentID = queueUserForStatusRobot.FirstValue;

                //日志
                Log("Recording current UserID: " + lCurrentID.ToString() + "...");
                SysArg.SetCurrentID(lCurrentID, SysArgFor.STATUS);

                #region 用户微博信息
                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(GlobalPool.SleepMsForThread);
                }
                //日志
                Log("Getting the latest Status ID of User " + lCurrentID.ToString() + "...");
                //获取数据库中当前用户最新一条微博的ID
                long lCurrentSID = Status.GetLastStatusIDOf(lCurrentID);

                if (blnAsyncCancelled) return;
                while (blnSuspending)
                {
                    if (blnAsyncCancelled) return;
                    Thread.Sleep(GlobalPool.SleepMsForThread);
                }

                Status status;
                #region 后续微博
                //日志
                Log("Crawling statuses after Status " + lCurrentSID.ToString() + " of User " + lCurrentID.ToString() + "...");
                //爬取数据库中当前用户最新一条微博的ID之后的微博，存入数据库
                LinkedList<Status> lstStatus = crawler.GetStatusesOfSince(lCurrentID, lCurrentSID);
                if (lstStatus.Count>0 && lstStatus.First.Value.status_id > 0)
                {
                    //日志
                    Log(lstStatus.Count.ToString() + " statuses crawled.");
                    //日志
                    AdjustFreq();
                    SetCrawlerFreq();
                    Log("Requesting interval is adjusted as " + crawler.SleepTime.ToString() + "ms. " + api.ResetTimeInSeconds.ToString() + "s, " + api.RemainingIPHits.ToString() + " IP hits and " + api.RemainingUserHits.ToString() + " user hits left this hour.");

                    while (lstStatus.Count > 0)
                    {
                        if (blnAsyncCancelled) return;
                        while (blnSuspending)
                        {
                            if (blnAsyncCancelled) return;
                            Thread.Sleep(GlobalPool.SleepMsForThread);
                        }
                        status = lstStatus.First.Value;
                        SaveStatus(status);
                        lstStatus.RemoveFirst();
                    }
                    queueUserForStatusRobot.RollQueue();
                    //日志
                    Log("Statuses of User " + lCurrentID.ToString() + " crawled.");
                }
                else if (lstStatus.Count > 0 && lstStatus.First.Value.status_id == -1)
                {
                    lstStatus.Clear();
                    int iSleepSeconds = GlobalPool.GetAPI(SysArgFor.STATUS).ResetTimeInSeconds;
                    Log("Service is forbidden now. I will wait for " + iSleepSeconds.ToString() + "s to continue...");
                    for (int i = 0; i < iSleepSeconds; i++)
                    {
                        if (blnAsyncCancelled) return;
                        Thread.Sleep(1000);
                    }
                    continue;
                }
                else
                {
                    queueUserForStatusRobot.RollQueue();
                    //日志
                    Log("Statuses of User " + lCurrentID.ToString() + " crawled.");
                }
                #endregion
                #endregion
            }
        }

        public override void Initialize()
        {
            //初始化相应变量
            blnAsyncCancelled = false;
            blnSuspending = false;
            crawler.StopCrawling = false;
            queueUserForStatusRobot.Initialize();
        }
    }
}
