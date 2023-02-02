using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logicalprograms
{
  public class StopWatch
    {
        public static void stopwatch1()
        {
            var watch = new System.Diagnostics.Stopwatch();  // var it have no value

            watch.Start(); // for start the watch

            watch.Stop(); // for end the watch





            Console.WriteLine("time taken : {0}", watch.Elapsed);
        }

    }
    public class StopManuallyTime
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int Hr = dateTime.Hour;
            int Min = dateTime.Minute;
            int Sec = dateTime.Second;
            int MilliSec = dateTime.Millisecond;
            Console.WriteLine("Press s to start");
            char start = Convert.ToChar(Console.ReadLine().ToLower());
            if (start.Equals('s'))
            {
                Console.WriteLine(MilliSec);
                Console.WriteLine("Press x to exit");
                char stop = Convert.ToChar(Console.ReadLine().ToLower());
                if (stop.Equals('x'))
                {
                    DateTime dateTime2 = DateTime.Now;
                    Console.WriteLine(dateTime2.Millisecond);
                    int exitHr = dateTime2.Hour;
                    int exitMin = dateTime2.Minute;
                    int exitSec = dateTime2.Second;
                    int exitMilliSec = dateTime2.Millisecond;
                    Console.WriteLine("StopWatch Details:- Hours:" + (exitHr - Hr) + " Minutes:" + (exitMin - Min) + " Seconds:" + (exitSec - Sec) + " MilliSeconds:" + (exitMilliSec - MilliSec));
                }
            }

        }
    }
}

        








