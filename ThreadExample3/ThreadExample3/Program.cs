using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample3
{
    class Program
    {
        static int n = 10; //common resource
                           // why is this static??
                           // what is the difference between static variables and global variables??
        static void Main(string[] args)
        {
            //This program imp0lements multi threading
            //This program will demonstrate can access
            //a common resource

            Console.WriteLine("Main thread starting");
            ThreadStart ts1 = new ThreadStart(ThreadCode);
            Thread child1 = new Thread(ts1);
            child1.Name = "Child 1";

            ThreadStart ts2 = new ThreadStart(ThreadCode);
            Thread child2 = new Thread(ts2); // why not just use ts1?
            child2.Name = "Child 2";

            child1.Start();
            child2.Start();

            Console.WriteLine("The value of n is {0}", n);
            Console.ReadKey();
        }

        static void ThreadCode()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " running");
            n++;
        }
    }
}
