using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Start = DateTime.Now;
            while (true)
            {
                Console.WriteLine($@"Hello World! It is {DateTime.Now}. I have been running for {(DateTime.Now-Start):hh\hmm\mss\s}");
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
