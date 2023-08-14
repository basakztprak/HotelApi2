using MQTTnet.Client;
using System;

namespace Mqtt
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

            string host = "localhost"; // Config'den alınabilir
            int port = 1883; // Config'den alınabilir

            var publisher = new MqttPublisher(host, port);
            var subscriber = new MqttSubscriber(host, port);
            await subscriber.SubscribeAsync("reservation");
            Console.WriteLine("Subscribed to topic: reservation");
            Console.ReadKey();
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter message to publish (or 'exit' to close):");
            //    input = Console.ReadLine();

            //    if (input != "exit")
            //    {
            //        await publisher.PublishAsync("reservation", input);
            //    }

            //} while (input != "exit");
        }
    }
}
