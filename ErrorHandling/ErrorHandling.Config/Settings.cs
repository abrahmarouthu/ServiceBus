using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling.Config
{
    public static class Settings
    {
        //ToDo: Enter a valid Service Bus connection string
        public static string ConnectionString = "Endpoint=sb://ashwintest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9QDdwVLnZ6RyYfcj67WPeFafg+Qlc1rjly1gNNJ7aSA=";
        public static string QueuePath = "errorhandling";
        public static string ForwardingQueuePath = "errorhandlingforwarding";
    }
}
