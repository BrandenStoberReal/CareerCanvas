using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class ThreadingUtils
    {
        /// <summary>
        /// List of threads that are currently running.
        /// </summary>
        public static List<Thread> RunningThreads = new List<Thread>();

        /// <summary>
        /// Executes a given action on a separate thread.
        /// </summary>
        /// <param name="action">The action to be executed.</param>
        public static void ExecuteOnNewThread(Action action)
        {
            Thread thread = new Thread(() =>
            {
                RunningThreads.Add(Thread.CurrentThread);
                action();
                RunningThreads.Remove(Thread.CurrentThread);
            });
            thread.Start();
        }

        /// <summary>
        /// Waits for a specific thread to complete.
        /// </summary>
        /// <param name="thread"></param>
        public static void WaitForThreadToComplete(Thread thread)
        {
            thread.Join();
        }
    }
}