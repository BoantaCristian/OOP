using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch
    {
        private TimeSpan Span { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public void Start()
        {
            StartTime = DateTime.UtcNow;
        }
        public void Stop()
        {
            FinishTime = DateTime.UtcNow;
            Span = new TimeSpan(FinishTime.Hour - StartTime.Hour, FinishTime.Minute - StartTime.Minute, FinishTime.Second - StartTime.Second);
            Console.WriteLine(Span);
        }
    }
}
