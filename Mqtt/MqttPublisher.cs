using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Threading.Tasks;

namespace Mqtt
{
    public class MqttPublisher
    {
        private readonly IMqttClient _client;

        public bool IsConnected => _client.IsConnected;

        public MqttPublisher(string host, int port)
        {
            var factory = new MqttFactory();
            _client = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                //.WithClientId("PublisherClient")
                .WithTcpServer(host, port)
                .Build();

            _client.ConnectAsync(options).Wait(); // Uygulama başlarken bağlan
        }

        public async Task PublishAsync(string topic, string payload)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .Build();

            await _client.PublishAsync(message);
        }
    }
}
