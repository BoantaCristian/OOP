namespace WorkflowEngine
{
    public interface IActivity
    {
        bool Status { get; set; }
        void RunActivity();
    }
}
