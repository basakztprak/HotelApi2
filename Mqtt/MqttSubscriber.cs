using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Mqtt
{
    public class MqttSubscriber
    {
        private readonly IMqttClient _client;

        public MqttSubscriber(string host, int port)
        {
            var factory = new MqttFactory();
            _client = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                //.WithClientId("SubscriberClient")
                .WithTcpServer(host, port)
                .Build();

            _client.ConnectAsync(options).Wait(); // Uygulama başlarken bağlan

            _client.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine($"Received a new message on topic: {e.ApplicationMessage.Topic}");
                Console.WriteLine($"Message: {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
            });
        }

        public async Task SubscribeAsync(string topic)
        {
            await _client.SubscribeAsync(new MqttTopicFilterBuilder()
                .WithTopic(topic)
                .Build());
        }
    }
}
