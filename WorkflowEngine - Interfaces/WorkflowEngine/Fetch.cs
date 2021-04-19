namespace WorkflowEngine
{
    public class Fetch : IActivity
    {
        public bool Status { get { return Status; } set => Status = true; }

        public void RunActivity()
        {
            System.Console.WriteLine("Object fetched and server called.");
        }
    }
}
