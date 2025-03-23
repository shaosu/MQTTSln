using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMQTT.Models;
using WinFormMQTT.VM;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormMQTT;

public partial class Form1 : Form
{
    ConnParam conn = new ConnParam();
    MyMQClient client = new MyMQClient();

    public Form1()
    {
        InitializeComponent();
        client.RecvDataEvent += Client_RecvDataEvent;
        client.OnlineChangedEvent += Client_OnlineChangedEvent;
        //Client_OnlineChangedEvent(false);
    }

    private void Client_OnlineChangedEvent(bool online)
    {
        if (this.InvokeRequired)
        {
            Action<bool> action = Client_OnlineChangedEvent;
            this.Invoke(action, online);
            return;
        }

        uc_OnlineStatus.Online = online;
        btn_Conn.Enabled = !online;
        btn_DisConn.Enabled = online;
        btn_Subscribe.Enabled = online;
        btn_Send.Enabled = online;
        AppendNewLine($"在线:{online}", Color.DarkGreen);
    }

    private void Client_RecvDataEvent(string item)
    {
        AppendNewLine(item);
    }


    private void AppendNewLine(string text)
    {
        AppendNewLine(text, Color.Red);
    }

    private void AppendNewLine(string text, Color color)
    {
        if (this.InvokeRequired)
        {
            Action<string, Color> action = AppendNewLine;
            this.Invoke(action, text, color);
            return;
        }

        text = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.f")} {text}{Environment.NewLine}";
        txt_Data.SelectionStart = txt_Data.TextLength; // 设置插入位置
        txt_Data.SelectionLength = 0; // 不选中任何文本
        txt_Data.SelectionColor = color; // 设置颜色
        txt_Data.AppendText(text); // 添加文本
        txt_Data.SelectionColor = txt_Data.ForeColor; // 重置颜色
    }

    private void uc_ClientID_DoubleClick(object sender, EventArgs e)
    {
        byte[] bytes = new byte[3];
        Random.Shared.NextBytes(bytes);
        string tmp = string.Join("", bytes);
        uc_ClientID.Value = $"WinForm_{tmp}";
    }

    private async void btn_Conn_Click(object sender, EventArgs e)
    {
        conn.UserName = uc_UserName.Value;
        conn.Password = uc_Passwd.Value;
        conn.ClientID = uc_ClientID.Value;
        conn.Port = int.Parse(uc_Port.Value);
        conn.SSL = chk_SSL.Checked;
        conn.URL = uc_URL.Value;
        list_Subscribe.Items.Clear();
        try
        {
            var online = await client.Conn(conn);
            uc_OnlineStatus.Online = online;
        }
        catch (Exception ex)
        {
            AppendNewLine(ex.Message);
        }
    }

    private async void btn_DisConn_Click(object sender, EventArgs e)
    {
        try
        {
            await client.DisConn();
            uc_OnlineStatus.Online = false;
        }
        catch (Exception ex)
        {
            AppendNewLine(ex.Message);
        }

    }

    private void btn_Subscribe_Click(object sender, EventArgs e)
    {
        try
        {
            client.Subscribe(txt_SubscribeTopic.Text);
            list_Subscribe.Items.Add(txt_SubscribeTopic.Text);
        }
        catch (Exception ex)
        {
            AppendNewLine(ex.Message);
        }
    }

    private void btn_Send_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txt_PublishTopic.Text)) return;
        if (string.IsNullOrWhiteSpace(txt_PublishPayload.Text)) return;

        client.Publish(txt_PublishTopic.Text, txt_PublishPayload.Text);
        AppendNewLine(txt_PublishTopic.Text + ":" + txt_PublishPayload.Text, Color.DarkGreen);
    }

    private void btn_BuildPayload_Click(object sender, EventArgs e)
    {
        Payload1 p1 = new Payload1
        {
            AAA = Random.Shared.Next(1, 1000)
        };
        txt_PublishPayload.Text = System.Text.Json.JsonSerializer.Serialize(p1);
    }

    private void txt_Data_DoubleClick(object sender, EventArgs e)
    {
        txt_Data.Clear();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (uc_OnlineStatus.Online)
        {
            e.Cancel = true;
            MessageBox.Show("请先断开连接");
        }
    }
}
