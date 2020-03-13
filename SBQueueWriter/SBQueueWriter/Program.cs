using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace SBQueueWriter
{
    class Program
    {
        static IQueueClient queueClient;
        public static async Task Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var sbconnstr = "Endpoint=sb://ashwintest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9QDdwVLnZ6RyYfcj67WPeFafg+Qlc1rjly1gNNJ7aSA=";
            var qname = "sbqueue";

            await Task.Run(() =>
            {
                queueClient = new QueueClient(sbconnstr, qname);
                var msgCount = 100000;

                try
                {
                    for (int i = 0; i < msgCount; i++)
                    {
                        string simpleJson = "{\"data\":\"" + i.ToString() + "\"}";
                        var sbMessage = new Message(Encoding.UTF8.GetBytes(simpleJson));
                        Console.WriteLine(simpleJson);

                        queueClient.SendAsync(sbMessage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + ", " + ex.StackTrace);
                }
                Console.ReadKey();
                queueClient.CloseAsync();
            });
        }
    }
}
