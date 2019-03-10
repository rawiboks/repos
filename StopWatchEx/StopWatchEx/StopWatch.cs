using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchEx
{
    class StopWatch
    {
        private TimeSpan startTime;
        private TimeSpan stopTime;

        public TimeSpan Start()
        {
            startTime = DateTime.Now.TimeOfDay;
            return startTime;
        }

        public void Start(TimeSpan time)
        {
            startTime = time;
        }

        public TimeSpan Stop()
        {
            stopTime = DateTime.Now.TimeOfDay;
            Console.WriteLine(stopTime - startTime);
            return stopTime;
        }

        public void ShowTime()
        {
            Console.WriteLine(stopTime-startTime);
        }
    }
}
