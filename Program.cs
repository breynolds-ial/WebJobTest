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
            while (true)
            {
                Console.WriteLine($"Hello World! It is {DateTime.Now}");
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
