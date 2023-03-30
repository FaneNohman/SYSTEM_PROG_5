using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        private static object _lock = new object();
        static void Main(string[] args)
        {
            new Thread(MethodForNewThread).Start();
            new Thread(MethodForNewThread).Start();
        }
        private static void MethodForNewThread()
        {
            lock (_lock)
            {
                Thread.Sleep(10000);
            }
        }
    }
}
