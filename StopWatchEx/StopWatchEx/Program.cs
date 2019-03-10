using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            var key= ConsoleKey.D8;
            Console.WriteLine("Press 1 to start , 2 to stop, 3 to exit");

            do
            {
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    if (stopWatch.Start() == new TimeSpan(0, 0, 0))
                        stopWatch.Start();
                    else
                        throw new InvalidOperationException("You can't start watch twice!");
                }
                else if (key == ConsoleKey.D2)
                {
                    if(stopWatch.Start() == new TimeSpan(0, 0, 0))
                        Console.WriteLine("You must start watch first!");
                    else
                    {
                        stopWatch.Stop();
                        stopWatch.Start(new TimeSpan(0, 0, 0));
                    }
                }
                else if (key == ConsoleKey.D3)
                    stopWatch.ShowTime();
            } while (key != ConsoleKey.D3);
        }
    }
}
