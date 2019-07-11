using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first thread that is executed in a process is called the main thread
            //The threads created using the Thread class are children threads

            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
            Console.WriteLine("The current thread is {0}", thread.Name);
            Console.ReadKey();


            //Using the CurrentThreadProperty of the Thread Class, you create a thread 
            //object that points at the currently running thread (the main thread
            //that is automatically created when running the programming.
            //The thread object is assigned the name Main Thread.
            //The name of the main thread is then displayed.


        }
    }
}
