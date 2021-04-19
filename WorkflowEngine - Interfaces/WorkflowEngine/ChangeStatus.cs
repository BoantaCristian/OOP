namespace WorkflowEngine
{
    public class ChangeStatus : IActivity
    {
        public bool Status { get { return Status; } set => Status = true; }

        public void RunActivity()
        {
            System.Console.WriteLine("Workflow finished.");
        }
    }
}
