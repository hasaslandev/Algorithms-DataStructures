using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string[] nemo = { "nemo" };
        string[] everyone = { "dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt", "darla", "hank" };

        string[] nemos = Enumerable.Repeat("nemo", 100000).ToArray();

        void findNemo(string [] array)
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










        //Stopwatch stopwatch = new Stopwatch();
        //string[] everyone = { "dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt", "darla", "hank" };
        //string[] nemos = Enumerable.Repeat("nemo", 10000).ToArray();
        //stopwatch.Start();
        //for (int i = 0; i < nemos.Length; i++)
        //{
        //    if (nemos[i] == "nemo")
        //    {
        //        Console.WriteLine("I found Nemo!");
        //    }
        //}
        //stopwatch.Stop();
        //Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds");
    }
}