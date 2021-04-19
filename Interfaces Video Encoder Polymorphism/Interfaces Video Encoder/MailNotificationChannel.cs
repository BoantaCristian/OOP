using System;

namespace Interfaces_Video_Encoder
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Senmding mail...");
        }
    }
}
