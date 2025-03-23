using MQTTnet;
using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMQTT.VM;

namespace WinFormMQTT
{
    internal class MyMQClient : IDisposable
    {

        public event Action<string>? RecvDataEvent;
        public event Action<bool>? OnlineChangedEvent;

        private IMqttClient mqttClient;
        public MyMQClient()
        {
            var mqttFactory = new MqttClientFactory();
            mqttClient = mqttFactory.CreateMqttClient();
            mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync;
            mqttClient.DisconnectedAsync += MqttClient_DisconnectedAsync;
            mqttClient.ConnectedAsync += MqttClient_ConnectedAsync;
        }

        private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            OnlineChangedEvent?.Invoke(true);
            return Task.CompletedTask;
        }

        private Task MqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            OnlineChangedEvent?.Invoke(false);
            return Task.CompletedTask;
        }

        private Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            string appMessage = System.Text.ASCIIEncoding.Default.GetString(arg.ApplicationMessage.Payload);
            string Topic = arg.ApplicationMessage.Topic;
            RecvDataEvent?.Invoke(Topic + "=>  " + appMessage);
            return Task.CompletedTask;
        }

        public async Task<bool> Conn(ConnParam param)
        {
            if (param.SSL == false)
            {
                return await Conn_NoSSL(param);
            }
            else
            {
                return await Conn_UserName(param);
            }
        }

        public async Task<bool> Conn_UserName(ConnParam param)
        {
            MqttClientOptionsBuilder builder = new MqttClientOptionsBuilder()
                .WithClientId(param.ClientID)
                .WithTcpServer(param.URL, param.Port)
                .WithProtocolVersion(MQTTnet.Formatter.MqttProtocolVersion.V500)
                .WithKeepAlivePeriod(new TimeSpan(0, 0, param.KeepAlivePeriod))
                .WithTimeout(new TimeSpan(0, 0, 10))
                .WithTlsOptions(o => o.WithCertificateValidationHandler(_ => param.SSL))
                .WithCleanStart();

            if (string.IsNullOrWhiteSpace(param.UserName) == false)
            {
                builder.WithCredentials(param.UserName, param.Password);
            }

            var options = builder.Build();
            var response = await mqttClient.ConnectAsync(options, CancellationToken.None);
            return response.ResultCode == MqttClientConnectResultCode.Success;
        }

        public async Task<bool> Conn_NoSSL(ConnParam param)
        {
            MqttClientOptionsBuilder builder = new MqttClientOptionsBuilder()
                .WithTcpServer(param.URL, param.Port)
                .WithProtocolVersion(MQTTnet.Formatter.MqttProtocolVersion.V500)
                .WithKeepAlivePeriod(new TimeSpan(0, 0, param.KeepAlivePeriod))
                .WithTimeout(new TimeSpan(0, 0, 10))
                .WithCleanStart();
            var options = builder.Build();

            var response = await mqttClient.ConnectAsync(options, CancellationToken.None);
            return response.ResultCode == MqttClientConnectResultCode.Success;
        }

        public async Task DisConn()
        {
            var mqttFactory = new MqttClientFactory();

            // Send a clean disconnect to the server by calling _DisconnectAsync_. Without this the TCP connection
            // gets dropped and the server will handle this as a non clean disconnect (see MQTT spec for details).
            var options = mqttFactory.CreateClientDisconnectOptionsBuilder().Build();
            await mqttClient.DisconnectAsync(options, CancellationToken.None);
            return;
        }

        public async void Subscribe(string topic)
        {
            var mqttFactory = new MqttClientFactory();
            var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder().WithTopicFilter(topic).Build();
            await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);
        }

        public async void Publish(string topic, string payload)
        {
            var mqttFactory = new MqttClientFactory();

            var applicationMessage = new MqttApplicationMessageBuilder()
                 .WithTopic(topic)
                 .WithPayload(payload)
                 .Build();
            await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);
        }



        #region " Dispose "

        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    mqttClient.Dispose();
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        ~MyMQClient()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}
