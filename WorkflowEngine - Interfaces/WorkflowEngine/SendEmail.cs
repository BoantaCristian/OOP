namespace WorkflowEngine
{
    public class SendEmail : IActivity
    {
        public bool Status { get { return Status; } set => Status = true; }

        public void RunActivity()
        {
            System.Console.WriteLine("Email sent.");
        }
    }
}
