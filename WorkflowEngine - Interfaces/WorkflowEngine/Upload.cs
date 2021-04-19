namespace WorkflowEngine
{
    public class Upload : IActivity
    {
        public bool Status { get { return Status; } set => Status = true; }

        public void RunActivity()
        {
            System.Console.WriteLine("Upload to cloud.");
        }
    }
}
