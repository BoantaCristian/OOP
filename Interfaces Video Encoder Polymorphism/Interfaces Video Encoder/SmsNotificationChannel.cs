namespace Interfaces_Video_Encoder
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending sms...");
        }
    }
}
