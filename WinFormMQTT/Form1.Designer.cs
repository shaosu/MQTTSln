namespace WinFormMQTT;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btn_Conn = new Button();
        sp_Root = new SplitContainer();
        uc_OnlineStatus = new WinFormMQTT.Controls.uc_OnlineStatus();
        btn_DisConn = new Button();
        uc_ClientID = new WinFormMQTT.Controls.uc_LabValueUnit();
        chk_SSL = new CheckBox();
        uc_Port = new WinFormMQTT.Controls.uc_LabValueUnit();
        uc_URL = new WinFormMQTT.Controls.uc_LabValueUnit();
        uc_Passwd = new WinFormMQTT.Controls.uc_LabValueUnit();
        uc_UserName = new WinFormMQTT.Controls.uc_LabValueUnit();
        sp_Content = new SplitContainer();
        txt_Data = new RichTextBox();
        btn_BuildPayload = new Button();
        txt_PublishTopic = new TextBox();
        list_Subscribe = new ListBox();
        btn_Send = new Button();
        txt_PublishPayload = new TextBox();
        txt_SubscribeTopic = new TextBox();
        btn_Subscribe = new Button();
        ((System.ComponentModel.ISupportInitialize)sp_Root).BeginInit();
        sp_Root.Panel1.SuspendLayout();
        sp_Root.Panel2.SuspendLayout();
        sp_Root.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)sp_Content).BeginInit();
        sp_Content.Panel1.SuspendLayout();
        sp_Content.Panel2.SuspendLayout();
        sp_Content.SuspendLayout();
        SuspendLayout();
        // 
        // btn_Conn
        // 
        btn_Conn.Location = new Point(3, 3);
        btn_Conn.Name = "btn_Conn";
        btn_Conn.Size = new Size(102, 34);
        btn_Conn.TabIndex = 0;
        btn_Conn.Text = "连接";
        btn_Conn.UseVisualStyleBackColor = true;
        btn_Conn.Click += btn_Conn_Click;
        // 
        // sp_Root
        // 
        sp_Root.Dock = DockStyle.Fill;
        sp_Root.FixedPanel = FixedPanel.Panel1;
        sp_Root.IsSplitterFixed = true;
        sp_Root.Location = new Point(0, 0);
        sp_Root.Name = "sp_Root";
        sp_Root.Orientation = Orientation.Horizontal;
        // 
        // sp_Root.Panel1
        // 
        sp_Root.Panel1.Controls.Add(uc_OnlineStatus);
        sp_Root.Panel1.Controls.Add(btn_DisConn);
        sp_Root.Panel1.Controls.Add(uc_ClientID);
        sp_Root.Panel1.Controls.Add(chk_SSL);
        sp_Root.Panel1.Controls.Add(uc_Port);
        sp_Root.Panel1.Controls.Add(uc_URL);
        sp_Root.Panel1.Controls.Add(uc_Passwd);
        sp_Root.Panel1.Controls.Add(uc_UserName);
        sp_Root.Panel1.Controls.Add(btn_Conn);
        // 
        // sp_Root.Panel2
        // 
        sp_Root.Panel2.Controls.Add(sp_Content);
        sp_Root.Size = new Size(800, 450);
        sp_Root.SplitterDistance = 111;
        sp_Root.TabIndex = 1;
        // 
        // uc_OnlineStatus
        // 
        uc_OnlineStatus.Location = new Point(125, 55);
        uc_OnlineStatus.Name = "uc_OnlineStatus";
        uc_OnlineStatus.OffLineTitle = "离线";
        uc_OnlineStatus.Online = false;
        uc_OnlineStatus.OnlineTitle = "在线";
        uc_OnlineStatus.Size = new Size(47, 21);
        uc_OnlineStatus.TabIndex = 9;
        uc_OnlineStatus.Text = "uc_OnlineStatus1";
        // 
        // btn_DisConn
        // 
        btn_DisConn.Location = new Point(3, 38);
        btn_DisConn.Name = "btn_DisConn";
        btn_DisConn.Size = new Size(102, 38);
        btn_DisConn.TabIndex = 7;
        btn_DisConn.Text = "断开";
        btn_DisConn.UseVisualStyleBackColor = true;
        btn_DisConn.Click += btn_DisConn_Click;
        // 
        // uc_ClientID
        // 
        uc_ClientID.AutoSize = true;
        uc_ClientID.Location = new Point(366, 38);
        uc_ClientID.Name = "uc_ClientID";
        uc_ClientID.Size = new Size(265, 29);
        uc_ClientID.TabIndex = 6;
        uc_ClientID.Title = "ClientID";
        uc_ClientID.Unit = "";
        uc_ClientID.Value = "WinForm_213123123213";
        uc_ClientID.DoubleClick += uc_ClientID_DoubleClick;
        // 
        // chk_SSL
        // 
        chk_SSL.AutoSize = true;
        chk_SSL.Checked = true;
        chk_SSL.CheckState = CheckState.Checked;
        chk_SSL.Location = new Point(730, 12);
        chk_SSL.Name = "chk_SSL";
        chk_SSL.Size = new Size(47, 21);
        chk_SSL.TabIndex = 5;
        chk_SSL.Text = "SSL";
        chk_SSL.UseVisualStyleBackColor = true;
        // 
        // uc_Port
        // 
        uc_Port.AutoSize = true;
        uc_Port.Location = new Point(635, 8);
        uc_Port.Name = "uc_Port";
        uc_Port.Size = new Size(100, 29);
        uc_Port.TabIndex = 4;
        uc_Port.Title = "端口";
        uc_Port.Unit = "";
        uc_Port.Value = "8883";
        // 
        // uc_URL
        // 
        uc_URL.AutoSize = true;
        uc_URL.Location = new Point(356, 8);
        uc_URL.Name = "uc_URL";
        uc_URL.Size = new Size(283, 29);
        uc_URL.TabIndex = 3;
        uc_URL.Title = "地址:";
        uc_URL.Unit = "";
        uc_URL.Value = "";
        // 
        // uc_Passwd
        // 
        uc_Passwd.AutoSize = true;
        uc_Passwd.Location = new Point(233, 8);
        uc_Passwd.Name = "uc_Passwd";
        uc_Passwd.Size = new Size(131, 29);
        uc_Passwd.TabIndex = 2;
        uc_Passwd.Title = "密码:";
        uc_Passwd.Unit = "";
        uc_Passwd.Value = "";
        // 
        // uc_UserName
        // 
        uc_UserName.AutoSize = true;
        uc_UserName.Location = new Point(125, 8);
        uc_UserName.Name = "uc_UserName";
        uc_UserName.Size = new Size(115, 29);
        uc_UserName.TabIndex = 1;
        uc_UserName.Title = "用户名:";
        uc_UserName.Unit = "";
        uc_UserName.Value = "su";
        // 
        // sp_Content
        // 
        sp_Content.Dock = DockStyle.Fill;
        sp_Content.FixedPanel = FixedPanel.Panel2;
        sp_Content.IsSplitterFixed = true;
        sp_Content.Location = new Point(0, 0);
        sp_Content.Name = "sp_Content";
        // 
        // sp_Content.Panel1
        // 
        sp_Content.Panel1.Controls.Add(txt_Data);
        // 
        // sp_Content.Panel2
        // 
        sp_Content.Panel2.Controls.Add(btn_BuildPayload);
        sp_Content.Panel2.Controls.Add(txt_PublishTopic);
        sp_Content.Panel2.Controls.Add(list_Subscribe);
        sp_Content.Panel2.Controls.Add(btn_Send);
        sp_Content.Panel2.Controls.Add(txt_PublishPayload);
        sp_Content.Panel2.Controls.Add(txt_SubscribeTopic);
        sp_Content.Panel2.Controls.Add(btn_Subscribe);
        sp_Content.Size = new Size(800, 335);
        sp_Content.SplitterDistance = 568;
        sp_Content.TabIndex = 0;
        // 
        // txt_Data
        // 
        txt_Data.Dock = DockStyle.Fill;
        txt_Data.Location = new Point(0, 0);
        txt_Data.Name = "txt_Data";
        txt_Data.Size = new Size(568, 335);
        txt_Data.TabIndex = 0;
        txt_Data.Text = "";
        // 
        // btn_BuildPayload
        // 
        btn_BuildPayload.Location = new Point(132, 305);
        btn_BuildPayload.Name = "btn_BuildPayload";
        btn_BuildPayload.Size = new Size(76, 26);
        btn_BuildPayload.TabIndex = 6;
        btn_BuildPayload.Text = "随机AAA";
        btn_BuildPayload.UseVisualStyleBackColor = true;
        btn_BuildPayload.Click += btn_BuildPayload_Click;
        // 
        // txt_PublishTopic
        // 
        txt_PublishTopic.Location = new Point(11, 162);
        txt_PublishTopic.Name = "txt_PublishTopic";
        txt_PublishTopic.Size = new Size(205, 23);
        txt_PublishTopic.TabIndex = 5;
        txt_PublishTopic.Text = "testtopic/1";
        // 
        // list_Subscribe
        // 
        list_Subscribe.FormattingEnabled = true;
        list_Subscribe.ItemHeight = 17;
        list_Subscribe.Location = new Point(11, 70);
        list_Subscribe.Name = "list_Subscribe";
        list_Subscribe.Size = new Size(204, 72);
        list_Subscribe.TabIndex = 4;
        // 
        // btn_Send
        // 
        btn_Send.Location = new Point(11, 304);
        btn_Send.Name = "btn_Send";
        btn_Send.Size = new Size(117, 28);
        btn_Send.TabIndex = 3;
        btn_Send.Text = "发送";
        btn_Send.UseVisualStyleBackColor = true;
        btn_Send.Click += btn_Send_Click;
        // 
        // txt_PublishPayload
        // 
        txt_PublishPayload.Location = new Point(8, 192);
        txt_PublishPayload.Multiline = true;
        txt_PublishPayload.Name = "txt_PublishPayload";
        txt_PublishPayload.Size = new Size(208, 106);
        txt_PublishPayload.TabIndex = 2;
        // 
        // txt_SubscribeTopic
        // 
        txt_SubscribeTopic.Location = new Point(7, 3);
        txt_SubscribeTopic.Name = "txt_SubscribeTopic";
        txt_SubscribeTopic.Size = new Size(218, 23);
        txt_SubscribeTopic.TabIndex = 1;
        txt_SubscribeTopic.Text = "testtopic/1";
        // 
        // btn_Subscribe
        // 
        btn_Subscribe.Location = new Point(8, 32);
        btn_Subscribe.Name = "btn_Subscribe";
        btn_Subscribe.Size = new Size(89, 29);
        btn_Subscribe.TabIndex = 0;
        btn_Subscribe.Text = "订阅";
        btn_Subscribe.UseVisualStyleBackColor = true;
        btn_Subscribe.Click += btn_Subscribe_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(sp_Root);
        Name = "Form1";
        Text = "MQTTV5测试";
        sp_Root.Panel1.ResumeLayout(false);
        sp_Root.Panel1.PerformLayout();
        sp_Root.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)sp_Root).EndInit();
        sp_Root.ResumeLayout(false);
        sp_Content.Panel1.ResumeLayout(false);
        sp_Content.Panel2.ResumeLayout(false);
        sp_Content.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)sp_Content).EndInit();
        sp_Content.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button btn_Conn;
    private SplitContainer sp_Root;
    private SplitContainer sp_Content;
    private RichTextBox txt_Data;
    private Button btn_Send;
    private TextBox txt_PublishPayload;
    private TextBox txt_SubscribeTopic;
    private Button btn_Subscribe;
    private ListBox list_Subscribe;
    private Controls.uc_LabValueUnit uc_UserName;
    private Controls.uc_LabValueUnit uc_Passwd;
    private Controls.uc_LabValueUnit uc_URL;
    private Controls.uc_LabValueUnit uc_Port;
    private CheckBox chk_SSL;
    private Controls.uc_LabValueUnit uc_ClientID;
    private Button btn_DisConn;
    private TextBox txt_PublishTopic;
    private Button btn_BuildPayload;
    private Controls.uc_OnlineStatus uc_OnlineStatus;
}
