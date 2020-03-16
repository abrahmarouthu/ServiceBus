
namespace RfidCheckout.Config
{
    public class AccountDetails
    {
        //ToDo: Enter a valid Serivce Bus connection string
        public static string ConnectionString = "Endpoint=sb://ashwintest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9QDdwVLnZ6RyYfcj67WPeFafg+Qlc1rjly1gNNJ7aSA=";
        public static string QueueName = "rfidcheckout";
    }
}