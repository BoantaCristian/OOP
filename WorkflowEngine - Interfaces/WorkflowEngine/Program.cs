using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var worckFlow = new Workflow();

            worckFlow.AddActivity(new Upload());
            worckFlow.AddActivity(new SendEmail());
            worckFlow.AddActivity(new Fetch());
            worckFlow.AddActivity(new ChangeStatus());

            worckFlow.Run();

            Console.Read();
        }
    }
}
