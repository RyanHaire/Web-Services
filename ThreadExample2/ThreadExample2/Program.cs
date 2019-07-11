using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create a childthread,
            //Step 1: create a delegate object, passing 
            //a callback method as a parameter.
            //The callback method contains the 
            //code you want executed when the child runs

            //Step 2: A new thread object is created and the 
            // deligate object is used to intialize the thread object

            //Step 3: The start method on the thread object causes the thread to run
            Random rnd = new Random();
            int NUM = rnd.Next(250,1000);

            MyThread threadObj = new MyThread();
            ThreadStart deliobj = new ThreadStart(threadObj.ThreadCode); // Step 1
            Thread childThread = new Thread(deliobj); // Step 2
            Console.WriteLine("This is the main thread");
            childThread.Start(); // Step 3

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("This is a thread {0}", i);
                Thread.Sleep(NUM); // makes a thread sleep/pause for 500ms
            }
            Console.ReadKey();

            // ThreadStart => delegate that defines a callback method
            // that contains the code to be executed when a thread runs
        }

    }

    public class MyThread
    {
        // Thread methods cannot take parameters
        // we can send data to thread methods using lambda expressions
        public void ThreadCode()
        {
            Random rnd = new Random();
            int NUM = rnd.Next(250, 10000);

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("This is a child thread {0}", i);
                Thread.Sleep(NUM); // makes a thread sleep/pause for 500ms
            }
        }
    }
}
