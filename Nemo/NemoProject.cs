using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class NemoProject
    {
        public void NemoMethod()
        {
            string[] nemo = { "nemo" };
            string[] everyone = { "dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt", "darla", "hank" };

            string[] nemos = Enumerable.Repeat("nemo", 100000).ToArray();

            void findNemo(string[] array)
            {
                Stopwatch stopwatch = new Stopwatch();
                var t0 = DateTime.Now;
                stopwatch.Start();
                for (int i = 0; i < array.LongLength; i++)
                {
                    if (array[i] == "nemo")
                    {
                        Console.WriteLine("Found Nemo");
                    }

                }
                stopwatch.Stop();
                var t1 = DateTime.Now;
                Console.WriteLine($"In took {stopwatch.Elapsed} milliseconds");
                Console.WriteLine(t1 - t0);
            }
            findNemo(nemos);
        }
    }
}
