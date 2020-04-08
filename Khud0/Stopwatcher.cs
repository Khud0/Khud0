using System;
using System.Diagnostics;

namespace Khud0
{
    namespace Utility
    {
        public static class Stopwatcher
        {
            private static Stopwatch stopwatch = default;

            public static void Start()
            {
                if (stopwatch == default) 
                {
                    stopwatch = Stopwatch.StartNew();
                } else stopwatch.Restart();
            }

            public static void Stop()
            {
                if (stopwatch == default) { Console.WriteLine("Stopwatch hadn't been started before you tried to stop it."); return; }
            
                stopwatch.Stop();
                Console.WriteLine($"Elapsed time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

                stopwatch = default;
            }
        }
    }
}
