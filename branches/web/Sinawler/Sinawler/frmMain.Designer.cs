﻿namespace Sinawler
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartByLast = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.lblVerified = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblStatusesCount = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblFriendsCount = new System.Windows.Forms.Label();
            this.lblFollowersCount = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnStartBySearch = new System.Windows.Forms.Button();
            this.lblSearchUserID = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSearchOnline = new System.Windows.Forms.Button();
            this.btnSearchOffLine = new System.Windows.Forms.Button();
            this.grpSearchCondition = new System.Windows.Forms.GroupBox();
            this.grpCurrentUser = new System.Windows.Forms.GroupBox();
            this.lblCVerified = new System.Windows.Forms.Label();
            this.lblCFollowing = new System.Windows.Forms.Label();
            this.lblCStatusesCount = new System.Windows.Forms.Label();
            this.lblCCreatedAt = new System.Windows.Forms.Label();
            this.lblCFriendsCount = new System.Windows.Forms.Label();
            this.lblCFollowersCount = new System.Windows.Forms.Label();
            this.lblCGender = new System.Windows.Forms.Label();
            this.lblCLocation = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCUserID = new System.Windows.Forms.Label();
            this.btnStartByCurrent = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnPauseContinue = new System.Windows.Forms.Button();
            this.gpSetting = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpDBSettings = new System.Windows.Forms.GroupBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.drplstDBType = new System.Windows.Forms.ComboBox();
            this.txtDBPwd = new System.Windows.Forms.TextBox();
            this.txtDBUserName = new System.Windows.Forms.TextBox();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.lblDBType = new System.Windows.Forms.Label();
            this.lblDBUserName = new System.Windows.Forms.Label();
            this.lblDBServer = new System.Windows.Forms.Label();
            this.lblDBPwd = new System.Windows.Forms.Label();
            this.grpQueueLength = new System.Windows.Forms.GroupBox();
            this.lblQueueLength = new System.Windows.Forms.Label();
            this.tbQueueLength = new System.Windows.Forms.TrackBar();
            this.numQueueLength = new System.Windows.Forms.NumericUpDown();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserInfoTitle = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblCommentQueueInfo = new System.Windows.Forms.Label();
            this.lblStatusQueueInfo = new System.Windows.Forms.Label();
            this.lblUserTagQueueInfo = new System.Windows.Forms.Label();
            this.lblUserRelationQueueInfo = new System.Windows.Forms.Label();
            this.lblUserInfoQueueInfo = new System.Windows.Forms.Label();
            this.lblCommentMessage = new System.Windows.Forms.Label();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.lblUserTagMessage = new System.Windows.Forms.Label();
            this.lblUserRelationMessage = new System.Windows.Forms.Label();
            this.lblUserTagTitle = new System.Windows.Forms.Label();
            this.lblUserInfoMessage = new System.Windows.Forms.Label();
            this.lblUserRelationTitle = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.grpUserInfo.SuspendLayout();
            this.grpSearchCondition.SuspendLayout();
            this.grpCurrentUser.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.gpSetting.SuspendLayout();
            this.grpDBSettings.SuspendLayout();
            this.grpQueueLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQueueLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQueueLength)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartByLast
            // 
            this.btnStartByLast.Location = new System.Drawing.Point(467, 18);
            this.btnStartByLast.Name = "btnStartByLast";
            this.btnStartByLast.Size = new System.Drawing.Size(225, 30);
            this.btnStartByLast.TabIndex = 19;
            this.btnStartByLast.Text = "以上次中止的用户为起点开始爬行";
            this.btnStartByLast.UseVisualStyleBackColor = true;
            this.btnStartByLast.Click += new System.EventHandler(this.btnStartByLast_Click);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.lblVerified);
            this.grpUserInfo.Controls.Add(this.lblFollowing);
            this.grpUserInfo.Controls.Add(this.lblStatusesCount);
            this.grpUserInfo.Controls.Add(this.lblCreatedAt);
            this.grpUserInfo.Controls.Add(this.lblFriendsCount);
            this.grpUserInfo.Controls.Add(this.lblFollowersCount);
            this.grpUserInfo.Controls.Add(this.lblGender);
            this.grpUserInfo.Controls.Add(this.lblLocation);
            this.grpUserInfo.Controls.Add(this.lblName);
            this.grpUserInfo.Controls.Add(this.lblUserID);
            this.grpUserInfo.Location = new System.Drawing.Point(11, 81);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(806, 63);
            this.grpUserInfo.TabIndex = 1;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "搜索结果";
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.lblVerified.Location = new System.Drawing.Point(430, 21);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(113, 12);
            this.lblVerified.TabIndex = 9;
            this.lblVerified.Text = "是否微博认证用户：";
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Location = new System.Drawing.Point(593, 21);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(185, 12);
            this.lblFollowing.TabIndex = 8;
            this.lblFollowing.Text = "当前登录帐号是否关注他（她）：";
            // 
            // lblStatusesCount
            // 
            this.lblStatusesCount.AutoSize = true;
            this.lblStatusesCount.Location = new System.Drawing.Point(430, 41);
            this.lblStatusesCount.Name = "lblStatusesCount";
            this.lblStatusesCount.Size = new System.Drawing.Size(77, 12);
            this.lblStatusesCount.TabIndex = 7;
            this.lblStatusesCount.Text = "已发微博数：";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(593, 41);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(89, 12);
            this.lblCreatedAt.TabIndex = 6;
            this.lblCreatedAt.Text = "帐号创建时间：";
            // 
            // lblFriendsCount
            // 
            this.lblFriendsCount.AutoSize = true;
            this.lblFriendsCount.Location = new System.Drawing.Point(302, 41);
            this.lblFriendsCount.Name = "lblFriendsCount";
            this.lblFriendsCount.Size = new System.Drawing.Size(65, 12);
            this.lblFriendsCount.TabIndex = 5;
            this.lblFriendsCount.Text = "关注人数：";
            // 
            // lblFollowersCount
            // 
            this.lblFollowersCount.AutoSize = true;
            this.lblFollowersCount.Location = new System.Drawing.Point(154, 41);
            this.lblFollowersCount.Name = "lblFollowersCount";
            this.lblFollowersCount.Size = new System.Drawing.Size(65, 12);
            this.lblFollowersCount.TabIndex = 4;
            this.lblFollowersCount.Text = "粉丝人数：";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(326, 21);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "性别：";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 41);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(53, 12);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "所在地：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(154, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "用户昵称：";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(9, 21);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(53, 12);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "用户ID：";
            // 
            // btnStartBySearch
            // 
            this.btnStartBySearch.Location = new System.Drawing.Point(237, 18);
            this.btnStartBySearch.Name = "btnStartBySearch";
            this.btnStartBySearch.Size = new System.Drawing.Size(225, 30);
            this.btnStartBySearch.TabIndex = 18;
            this.btnStartBySearch.Text = "以搜索结果用户为起点开始爬行";
            this.btnStartBySearch.UseVisualStyleBackColor = true;
            this.btnStartBySearch.Click += new System.EventHandler(this.btnStartBySearch_Click);
            // 
            // lblSearchUserID
            // 
            this.lblSearchUserID.AutoSize = true;
            this.lblSearchUserID.Location = new System.Drawing.Point(13, 25);
            this.lblSearchUserID.Name = "lblSearchUserID";
            this.lblSearchUserID.Size = new System.Drawing.Size(53, 12);
            this.lblSearchUserID.TabIndex = 2;
            this.lblSearchUserID.Text = "用户ID：";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(233, 25);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(65, 12);
            this.lblSearchName.TabIndex = 3;
            this.lblSearchName.Text = "用户昵称：";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Location = new System.Drawing.Point(64, 20);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(155, 21);
            this.txtUserID.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(295, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // btnSearchOnline
            // 
            this.btnSearchOnline.Location = new System.Drawing.Point(485, 18);
            this.btnSearchOnline.Name = "btnSearchOnline";
            this.btnSearchOnline.Size = new System.Drawing.Size(148, 23);
            this.btnSearchOnline.TabIndex = 2;
            this.btnSearchOnline.Text = "在新浪微博中搜索用户";
            this.btnSearchOnline.UseVisualStyleBackColor = true;
            this.btnSearchOnline.Click += new System.EventHandler(this.btnSearchOnline_Click);
            // 
            // btnSearchOffLine
            // 
            this.btnSearchOffLine.Location = new System.Drawing.Point(645, 18);
            this.btnSearchOffLine.Name = "btnSearchOffLine";
            this.btnSearchOffLine.Size = new System.Drawing.Size(148, 23);
            this.btnSearchOffLine.TabIndex = 3;
            this.btnSearchOffLine.Text = "在数据库中搜索用户";
            this.btnSearchOffLine.UseVisualStyleBackColor = true;
            this.btnSearchOffLine.Click += new System.EventHandler(this.btnSearchOffLine_Click);
            // 
            // grpSearchCondition
            // 
            this.grpSearchCondition.Controls.Add(this.btnSearchOffLine);
            this.grpSearchCondition.Controls.Add(this.btnSearchOnline);
            this.grpSearchCondition.Controls.Add(this.txtUserID);
            this.grpSearchCondition.Controls.Add(this.txtUserName);
            this.grpSearchCondition.Controls.Add(this.lblSearchUserID);
            this.grpSearchCondition.Controls.Add(this.lblSearchName);
            this.grpSearchCondition.Location = new System.Drawing.Point(11, 20);
            this.grpSearchCondition.Name = "grpSearchCondition";
            this.grpSearchCondition.Size = new System.Drawing.Size(806, 56);
            this.grpSearchCondition.TabIndex = 8;
            this.grpSearchCondition.TabStop = false;
            this.grpSearchCondition.Text = "搜索条件";
            // 
            // grpCurrentUser
            // 
            this.grpCurrentUser.Controls.Add(this.lblCVerified);
            this.grpCurrentUser.Controls.Add(this.lblCFollowing);
            this.grpCurrentUser.Controls.Add(this.lblCStatusesCount);
            this.grpCurrentUser.Controls.Add(this.lblCCreatedAt);
            this.grpCurrentUser.Controls.Add(this.lblCFriendsCount);
            this.grpCurrentUser.Controls.Add(this.lblCFollowersCount);
            this.grpCurrentUser.Controls.Add(this.lblCGender);
            this.grpCurrentUser.Controls.Add(this.lblCLocation);
            this.grpCurrentUser.Controls.Add(this.lblCName);
            this.grpCurrentUser.Controls.Add(this.lblCUserID);
            this.grpCurrentUser.Location = new System.Drawing.Point(4, 12);
            this.grpCurrentUser.Name = "grpCurrentUser";
            this.grpCurrentUser.Size = new System.Drawing.Size(827, 61);
            this.grpCurrentUser.TabIndex = 9;
            this.grpCurrentUser.TabStop = false;
            this.grpCurrentUser.Text = "当前登录帐号信息";
            // 
            // lblCVerified
            // 
            this.lblCVerified.AutoSize = true;
            this.lblCVerified.Location = new System.Drawing.Point(430, 21);
            this.lblCVerified.Name = "lblCVerified";
            this.lblCVerified.Size = new System.Drawing.Size(113, 12);
            this.lblCVerified.TabIndex = 9;
            this.lblCVerified.Text = "是否微博认证用户：";
            // 
            // lblCFollowing
            // 
            this.lblCFollowing.AutoSize = true;
            this.lblCFollowing.Location = new System.Drawing.Point(593, 21);
            this.lblCFollowing.Name = "lblCFollowing";
            this.lblCFollowing.Size = new System.Drawing.Size(185, 12);
            this.lblCFollowing.TabIndex = 8;
            this.lblCFollowing.Text = "当前登录帐号是否关注他（她）：";
            // 
            // lblCStatusesCount
            // 
            this.lblCStatusesCount.AutoSize = true;
            this.lblCStatusesCount.Location = new System.Drawing.Point(430, 41);
            this.lblCStatusesCount.Name = "lblCStatusesCount";
            this.lblCStatusesCount.Size = new System.Drawing.Size(77, 12);
            this.lblCStatusesCount.TabIndex = 7;
            this.lblCStatusesCount.Text = "已发微博数：";
            // 
            // lblCCreatedAt
            // 
            this.lblCCreatedAt.AutoSize = true;
            this.lblCCreatedAt.Location = new System.Drawing.Point(593, 41);
            this.lblCCreatedAt.Name = "lblCCreatedAt";
            this.lblCCreatedAt.Size = new System.Drawing.Size(89, 12);
            this.lblCCreatedAt.TabIndex = 6;
            this.lblCCreatedAt.Text = "帐号创建时间：";
            // 
            // lblCFriendsCount
            // 
            this.lblCFriendsCount.AutoSize = true;
            this.lblCFriendsCount.Location = new System.Drawing.Point(302, 41);
            this.lblCFriendsCount.Name = "lblCFriendsCount";
            this.lblCFriendsCount.Size = new System.Drawing.Size(65, 12);
            this.lblCFriendsCount.TabIndex = 5;
            this.lblCFriendsCount.Text = "关注人数：";
            // 
            // lblCFollowersCount
            // 
            this.lblCFollowersCount.AutoSize = true;
            this.lblCFollowersCount.Location = new System.Drawing.Point(154, 41);
            this.lblCFollowersCount.Name = "lblCFollowersCount";
            this.lblCFollowersCount.Size = new System.Drawing.Size(65, 12);
            this.lblCFollowersCount.TabIndex = 4;
            this.lblCFollowersCount.Text = "粉丝人数：";
            // 
            // lblCGender
            // 
            this.lblCGender.AutoSize = true;
            this.lblCGender.Location = new System.Drawing.Point(325, 21);
            this.lblCGender.Name = "lblCGender";
            this.lblCGender.Size = new System.Drawing.Size(41, 12);
            this.lblCGender.TabIndex = 3;
            this.lblCGender.Text = "性别：";
            // 
            // lblCLocation
            // 
            this.lblCLocation.AutoSize = true;
            this.lblCLocation.Location = new System.Drawing.Point(9, 41);
            this.lblCLocation.Name = "lblCLocation";
            this.lblCLocation.Size = new System.Drawing.Size(53, 12);
            this.lblCLocation.TabIndex = 2;
            this.lblCLocation.Text = "所在地：";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(154, 21);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(65, 12);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "用户昵称：";
            // 
            // lblCUserID
            // 
            this.lblCUserID.AutoSize = true;
            this.lblCUserID.Location = new System.Drawing.Point(9, 21);
            this.lblCUserID.Name = "lblCUserID";
            this.lblCUserID.Size = new System.Drawing.Size(53, 12);
            this.lblCUserID.TabIndex = 0;
            this.lblCUserID.Text = "用户ID：";
            // 
            // btnStartByCurrent
            // 
            this.btnStartByCurrent.Location = new System.Drawing.Point(6, 18);
            this.btnStartByCurrent.Name = "btnStartByCurrent";
            this.btnStartByCurrent.Size = new System.Drawing.Size(225, 30);
            this.btnStartByCurrent.TabIndex = 17;
            this.btnStartByCurrent.Text = "以当前登录帐号为起点开始爬行";
            this.btnStartByCurrent.UseVisualStyleBackColor = true;
            this.btnStartByCurrent.Click += new System.EventHandler(this.btnStartByCurrent_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.grpSearchCondition);
            this.grpSearch.Controls.Add(this.grpUserInfo);
            this.grpSearch.Location = new System.Drawing.Point(4, 76);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(827, 151);
            this.grpSearch.TabIndex = 10;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "搜索用户";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(453, 678);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "退出程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnPauseContinue);
            this.grpControl.Controls.Add(this.btnStartByCurrent);
            this.grpControl.Controls.Add(this.btnStartBySearch);
            this.grpControl.Controls.Add(this.btnStartByLast);
            this.grpControl.Location = new System.Drawing.Point(5, 407);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(827, 61);
            this.grpControl.TabIndex = 14;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "爬虫控制";
            // 
            // btnPauseContinue
            // 
            this.btnPauseContinue.Enabled = false;
            this.btnPauseContinue.Location = new System.Drawing.Point(699, 18);
            this.btnPauseContinue.Name = "btnPauseContinue";
            this.btnPauseContinue.Size = new System.Drawing.Size(120, 30);
            this.btnPauseContinue.TabIndex = 20;
            this.btnPauseContinue.Text = "暂停/继续";
            this.btnPauseContinue.UseVisualStyleBackColor = true;
            this.btnPauseContinue.Click += new System.EventHandler(this.btnPauseContinue_Click);
            // 
            // gpSetting
            // 
            this.gpSetting.Controls.Add(this.btnLoad);
            this.gpSetting.Controls.Add(this.grpDBSettings);
            this.gpSetting.Controls.Add(this.grpQueueLength);
            this.gpSetting.Controls.Add(this.btnDefault);
            this.gpSetting.Controls.Add(this.btnSave);
            this.gpSetting.Location = new System.Drawing.Point(5, 232);
            this.gpSetting.Name = "gpSetting";
            this.gpSetting.Size = new System.Drawing.Size(826, 170);
            this.gpSetting.TabIndex = 15;
            this.gpSetting.TabStop = false;
            this.gpSetting.Text = "设置（改变设置后请点击“保存”）";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(741, 111);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "加载最新值";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpDBSettings
            // 
            this.grpDBSettings.Controls.Add(this.txtDBName);
            this.grpDBSettings.Controls.Add(this.lblDBName);
            this.grpDBSettings.Controls.Add(this.drplstDBType);
            this.grpDBSettings.Controls.Add(this.txtDBPwd);
            this.grpDBSettings.Controls.Add(this.txtDBUserName);
            this.grpDBSettings.Controls.Add(this.txtDBServer);
            this.grpDBSettings.Controls.Add(this.lblDBType);
            this.grpDBSettings.Controls.Add(this.lblDBUserName);
            this.grpDBSettings.Controls.Add(this.lblDBServer);
            this.grpDBSettings.Controls.Add(this.lblDBPwd);
            this.grpDBSettings.Location = new System.Drawing.Point(10, 85);
            this.grpDBSettings.Name = "grpDBSettings";
            this.grpDBSettings.Size = new System.Drawing.Size(725, 78);
            this.grpDBSettings.TabIndex = 13;
            this.grpDBSettings.TabStop = false;
            this.grpDBSettings.Text = "数据库设置";
            // 
            // txtDBName
            // 
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBName.Location = new System.Drawing.Point(562, 46);
            this.txtDBName.MaxLength = 30;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(143, 21);
            this.txtDBName.TabIndex = 10;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(502, 53);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(65, 12);
            this.lblDBName.TabIndex = 14;
            this.lblDBName.Text = "数据库名：";
            this.lblDBName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drplstDBType
            // 
            this.drplstDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drplstDBType.FormattingEnabled = true;
            this.drplstDBType.Items.AddRange(new object[] {
            "SQL Server",
            "Oracle"});
            this.drplstDBType.Location = new System.Drawing.Point(101, 16);
            this.drplstDBType.Name = "drplstDBType";
            this.drplstDBType.Size = new System.Drawing.Size(121, 20);
            this.drplstDBType.TabIndex = 6;
            // 
            // txtDBPwd
            // 
            this.txtDBPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBPwd.Location = new System.Drawing.Point(326, 47);
            this.txtDBPwd.MaxLength = 50;
            this.txtDBPwd.Name = "txtDBPwd";
            this.txtDBPwd.PasswordChar = '*';
            this.txtDBPwd.Size = new System.Drawing.Size(145, 21);
            this.txtDBPwd.TabIndex = 9;
            // 
            // txtDBUserName
            // 
            this.txtDBUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBUserName.Location = new System.Drawing.Point(100, 47);
            this.txtDBUserName.MaxLength = 20;
            this.txtDBUserName.Name = "txtDBUserName";
            this.txtDBUserName.Size = new System.Drawing.Size(123, 21);
            this.txtDBUserName.TabIndex = 8;
            // 
            // txtDBServer
            // 
            this.txtDBServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBServer.Location = new System.Drawing.Point(438, 16);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(145, 21);
            this.txtDBServer.TabIndex = 7;
            // 
            // lblDBType
            // 
            this.lblDBType.AutoSize = true;
            this.lblDBType.Location = new System.Drawing.Point(27, 20);
            this.lblDBType.Name = "lblDBType";
            this.lblDBType.Size = new System.Drawing.Size(77, 12);
            this.lblDBType.TabIndex = 12;
            this.lblDBType.Text = "数据库类型：";
            // 
            // lblDBUserName
            // 
            this.lblDBUserName.AutoSize = true;
            this.lblDBUserName.Location = new System.Drawing.Point(15, 53);
            this.lblDBUserName.Name = "lblDBUserName";
            this.lblDBUserName.Size = new System.Drawing.Size(89, 12);
            this.lblDBUserName.TabIndex = 7;
            this.lblDBUserName.Text = "数据库用户名：";
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Location = new System.Drawing.Point(350, 20);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(89, 12);
            this.lblDBServer.TabIndex = 6;
            this.lblDBServer.Text = "数据库服务器：";
            // 
            // lblDBPwd
            // 
            this.lblDBPwd.AutoSize = true;
            this.lblDBPwd.Location = new System.Drawing.Point(252, 53);
            this.lblDBPwd.Name = "lblDBPwd";
            this.lblDBPwd.Size = new System.Drawing.Size(77, 12);
            this.lblDBPwd.TabIndex = 8;
            this.lblDBPwd.Text = "数据库密码：";
            // 
            // grpQueueLength
            // 
            this.grpQueueLength.Controls.Add(this.lblQueueLength);
            this.grpQueueLength.Controls.Add(this.tbQueueLength);
            this.grpQueueLength.Controls.Add(this.numQueueLength);
            this.grpQueueLength.Location = new System.Drawing.Point(10, 20);
            this.grpQueueLength.Name = "grpQueueLength";
            this.grpQueueLength.Size = new System.Drawing.Size(725, 61);
            this.grpQueueLength.TabIndex = 12;
            this.grpQueueLength.TabStop = false;
            this.grpQueueLength.Text = "队列长度";
            // 
            // lblQueueLength
            // 
            this.lblQueueLength.AutoSize = true;
            this.lblQueueLength.Location = new System.Drawing.Point(8, 26);
            this.lblQueueLength.Name = "lblQueueLength";
            this.lblQueueLength.Size = new System.Drawing.Size(281, 12);
            this.lblQueueLength.TabIndex = 0;
            this.lblQueueLength.Text = "内存队列长度（较大值提高性能，但占内存较多）：";
            // 
            // tbQueueLength
            // 
            this.tbQueueLength.LargeChange = 100;
            this.tbQueueLength.Location = new System.Drawing.Point(284, 16);
            this.tbQueueLength.Maximum = 100000;
            this.tbQueueLength.Minimum = 1;
            this.tbQueueLength.Name = "tbQueueLength";
            this.tbQueueLength.Size = new System.Drawing.Size(367, 42);
            this.tbQueueLength.SmallChange = 100;
            this.tbQueueLength.TabIndex = 4;
            this.tbQueueLength.TickFrequency = 1000;
            this.tbQueueLength.Value = 5000;
            this.tbQueueLength.ValueChanged += new System.EventHandler(this.tbQueueLength_ValueChanged);
            // 
            // numQueueLength
            // 
            this.numQueueLength.Location = new System.Drawing.Point(652, 22);
            this.numQueueLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQueueLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQueueLength.Name = "numQueueLength";
            this.numQueueLength.Size = new System.Drawing.Size(62, 21);
            this.numQueueLength.TabIndex = 5;
            this.numQueueLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQueueLength.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numQueueLength.ValueChanged += new System.EventHandler(this.numQueueLength_ValueChanged);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(741, 82);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "加载默认值";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(741, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserInfoTitle
            // 
            this.lblUserInfoTitle.AutoSize = true;
            this.lblUserInfoTitle.Location = new System.Drawing.Point(11, 20);
            this.lblUserInfoTitle.Name = "lblUserInfoTitle";
            this.lblUserInfoTitle.Size = new System.Drawing.Size(125, 12);
            this.lblUserInfoTitle.TabIndex = 16;
            this.lblUserInfoTitle.Text = "用户信息机器人状态：";
            this.lblUserInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblCommentQueueInfo);
            this.grpStatus.Controls.Add(this.lblStatusQueueInfo);
            this.grpStatus.Controls.Add(this.lblUserTagQueueInfo);
            this.grpStatus.Controls.Add(this.lblUserRelationQueueInfo);
            this.grpStatus.Controls.Add(this.lblUserInfoQueueInfo);
            this.grpStatus.Controls.Add(this.lblCommentMessage);
            this.grpStatus.Controls.Add(this.lblCommentTitle);
            this.grpStatus.Controls.Add(this.lblStatusMessage);
            this.grpStatus.Controls.Add(this.lblUserTagMessage);
            this.grpStatus.Controls.Add(this.lblUserRelationMessage);
            this.grpStatus.Controls.Add(this.lblUserTagTitle);
            this.grpStatus.Controls.Add(this.lblUserInfoMessage);
            this.grpStatus.Controls.Add(this.lblUserRelationTitle);
            this.grpStatus.Controls.Add(this.lblStatusTitle);
            this.grpStatus.Controls.Add(this.lblUserInfoTitle);
            this.grpStatus.Location = new System.Drawing.Point(5, 471);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(827, 186);
            this.grpStatus.TabIndex = 17;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "爬虫状态（详细内容见日志文件）";
            // 
            // lblCommentQueueInfo
            // 
            this.lblCommentQueueInfo.AutoSize = true;
            this.lblCommentQueueInfo.Location = new System.Drawing.Point(11, 166);
            this.lblCommentQueueInfo.Name = "lblCommentQueueInfo";
            this.lblCommentQueueInfo.Size = new System.Drawing.Size(341, 12);
            this.lblCommentQueueInfo.TabIndex = 24;
            this.lblCommentQueueInfo.Text = "评论机器人的内存队列中有0条微博，数据库队列中有0条微博。";
            // 
            // lblStatusQueueInfo
            // 
            this.lblStatusQueueInfo.AutoSize = true;
            this.lblStatusQueueInfo.Location = new System.Drawing.Point(11, 150);
            this.lblStatusQueueInfo.Name = "lblStatusQueueInfo";
            this.lblStatusQueueInfo.Size = new System.Drawing.Size(341, 12);
            this.lblStatusQueueInfo.TabIndex = 23;
            this.lblStatusQueueInfo.Text = "微博机器人的内存队列中有0个用户，数据库队列中有0个用户。";
            // 
            // lblUserTagQueueInfo
            // 
            this.lblUserTagQueueInfo.AutoSize = true;
            this.lblUserTagQueueInfo.Location = new System.Drawing.Point(11, 134);
            this.lblUserTagQueueInfo.Name = "lblUserTagQueueInfo";
            this.lblUserTagQueueInfo.Size = new System.Drawing.Size(365, 12);
            this.lblUserTagQueueInfo.TabIndex = 22;
            this.lblUserTagQueueInfo.Text = "用户标签机器人的内存队列中有0个用户，数据库队列中有0个用户。";
            // 
            // lblUserRelationQueueInfo
            // 
            this.lblUserRelationQueueInfo.AutoSize = true;
            this.lblUserRelationQueueInfo.Location = new System.Drawing.Point(11, 118);
            this.lblUserRelationQueueInfo.Name = "lblUserRelationQueueInfo";
            this.lblUserRelationQueueInfo.Size = new System.Drawing.Size(365, 12);
            this.lblUserRelationQueueInfo.TabIndex = 22;
            this.lblUserRelationQueueInfo.Text = "用户关系机器人的内存队列中有0个用户，数据库队列中有0个用户。";
            // 
            // lblUserInfoQueueInfo
            // 
            this.lblUserInfoQueueInfo.AutoSize = true;
            this.lblUserInfoQueueInfo.Location = new System.Drawing.Point(11, 102);
            this.lblUserInfoQueueInfo.Name = "lblUserInfoQueueInfo";
            this.lblUserInfoQueueInfo.Size = new System.Drawing.Size(365, 12);
            this.lblUserInfoQueueInfo.TabIndex = 22;
            this.lblUserInfoQueueInfo.Text = "用户信息机器人的内存队列中有0个用户，数据库队列中有0个用户。";
            // 
            // lblCommentMessage
            // 
            this.lblCommentMessage.AutoSize = true;
            this.lblCommentMessage.Location = new System.Drawing.Point(130, 84);
            this.lblCommentMessage.Name = "lblCommentMessage";
            this.lblCommentMessage.Size = new System.Drawing.Size(41, 12);
            this.lblCommentMessage.TabIndex = 21;
            this.lblCommentMessage.Text = "停止。";
            this.lblCommentMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Location = new System.Drawing.Point(35, 84);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(101, 12);
            this.lblCommentTitle.TabIndex = 20;
            this.lblCommentTitle.Text = "评论机器人状态：";
            this.lblCommentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Location = new System.Drawing.Point(130, 68);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(41, 12);
            this.lblStatusMessage.TabIndex = 17;
            this.lblStatusMessage.Text = "停止。";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserTagMessage
            // 
            this.lblUserTagMessage.AutoSize = true;
            this.lblUserTagMessage.Location = new System.Drawing.Point(130, 52);
            this.lblUserTagMessage.Name = "lblUserTagMessage";
            this.lblUserTagMessage.Size = new System.Drawing.Size(41, 12);
            this.lblUserTagMessage.TabIndex = 17;
            this.lblUserTagMessage.Text = "停止。";
            this.lblUserTagMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserRelationMessage
            // 
            this.lblUserRelationMessage.AutoSize = true;
            this.lblUserRelationMessage.Location = new System.Drawing.Point(130, 36);
            this.lblUserRelationMessage.Name = "lblUserRelationMessage";
            this.lblUserRelationMessage.Size = new System.Drawing.Size(41, 12);
            this.lblUserRelationMessage.TabIndex = 17;
            this.lblUserRelationMessage.Text = "停止。";
            this.lblUserRelationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserTagTitle
            // 
            this.lblUserTagTitle.AutoSize = true;
            this.lblUserTagTitle.Location = new System.Drawing.Point(11, 52);
            this.lblUserTagTitle.Name = "lblUserTagTitle";
            this.lblUserTagTitle.Size = new System.Drawing.Size(125, 12);
            this.lblUserTagTitle.TabIndex = 16;
            this.lblUserTagTitle.Text = "用户标签机器人状态：";
            this.lblUserTagTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserInfoMessage
            // 
            this.lblUserInfoMessage.AutoSize = true;
            this.lblUserInfoMessage.Location = new System.Drawing.Point(130, 20);
            this.lblUserInfoMessage.Name = "lblUserInfoMessage";
            this.lblUserInfoMessage.Size = new System.Drawing.Size(41, 12);
            this.lblUserInfoMessage.TabIndex = 17;
            this.lblUserInfoMessage.Text = "停止。";
            this.lblUserInfoMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserRelationTitle
            // 
            this.lblUserRelationTitle.AutoSize = true;
            this.lblUserRelationTitle.Location = new System.Drawing.Point(11, 36);
            this.lblUserRelationTitle.Name = "lblUserRelationTitle";
            this.lblUserRelationTitle.Size = new System.Drawing.Size(125, 12);
            this.lblUserRelationTitle.TabIndex = 16;
            this.lblUserRelationTitle.Text = "用户关系机器人状态：";
            this.lblUserRelationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(35, 68);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(101, 12);
            this.lblStatusTitle.TabIndex = 16;
            this.lblStatusTitle.Text = "微博机器人状态：";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(212, 678);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(170, 23);
            this.btnPost.TabIndex = 21;
            this.btnPost.Text = "发一条微博帮忙推广：）3Q";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 716);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.gpSetting);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpCurrentUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新浪微博爬虫";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpSearchCondition.ResumeLayout(false);
            this.grpSearchCondition.PerformLayout();
            this.grpCurrentUser.ResumeLayout(false);
            this.grpCurrentUser.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.gpSetting.ResumeLayout(false);
            this.grpDBSettings.ResumeLayout(false);
            this.grpDBSettings.PerformLayout();
            this.grpQueueLength.ResumeLayout(false);
            this.grpQueueLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQueueLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQueueLength)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartByLast;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblStatusesCount;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblFriendsCount;
        private System.Windows.Forms.Label lblFollowersCount;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.Button btnStartBySearch;
        private System.Windows.Forms.Label lblSearchUserID;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSearchOnline;
        private System.Windows.Forms.Button btnSearchOffLine;
        private System.Windows.Forms.GroupBox grpSearchCondition;
        private System.Windows.Forms.GroupBox grpCurrentUser;
        private System.Windows.Forms.Button btnStartByCurrent;
        private System.Windows.Forms.Label lblCVerified;
        private System.Windows.Forms.Label lblCFollowing;
        private System.Windows.Forms.Label lblCStatusesCount;
        private System.Windows.Forms.Label lblCCreatedAt;
        private System.Windows.Forms.Label lblCFriendsCount;
        private System.Windows.Forms.Label lblCFollowersCount;
        private System.Windows.Forms.Label lblCGender;
        private System.Windows.Forms.Label lblCLocation;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCUserID;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.GroupBox gpSetting;
        private System.Windows.Forms.Label lblQueueLength;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserInfoTitle;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblUserInfoMessage;
        private System.Windows.Forms.TrackBar tbQueueLength;
        private System.Windows.Forms.Label lblDBServer;
        private System.Windows.Forms.NumericUpDown numQueueLength;
        private System.Windows.Forms.TextBox txtDBPwd;
        private System.Windows.Forms.TextBox txtDBUserName;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Label lblDBPwd;
        private System.Windows.Forms.Label lblDBUserName;
        private System.Windows.Forms.GroupBox grpQueueLength;
        private System.Windows.Forms.GroupBox grpDBSettings;
        private System.Windows.Forms.ComboBox drplstDBType;
        private System.Windows.Forms.Label lblDBType;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPauseContinue;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblCommentMessage;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.Label lblCommentQueueInfo;
        private System.Windows.Forms.Label lblStatusQueueInfo;
        private System.Windows.Forms.Label lblUserInfoQueueInfo;
        private System.Windows.Forms.Label lblUserRelationMessage;
        private System.Windows.Forms.Label lblUserRelationTitle;
        private System.Windows.Forms.Label lblUserRelationQueueInfo;
        private System.Windows.Forms.Label lblUserTagQueueInfo;
        private System.Windows.Forms.Label lblUserTagMessage;
        private System.Windows.Forms.Label lblUserTagTitle;
    }
}
