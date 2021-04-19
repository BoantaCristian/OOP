using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow
    {
        private readonly List<IActivity> _activities;
        //private readonly List<IActivity> _activities = new List<IActivity>(); //and initailization is removed from ctor

        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.RunActivity();
            }
        }
    }
}
