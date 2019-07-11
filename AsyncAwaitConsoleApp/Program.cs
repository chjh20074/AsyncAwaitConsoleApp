using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            RunFunc();
            //RunFuncAsync();
            Console.WriteLine("D");
            Console.ReadKey();
        }

        static void RunFunc()
        {
            Console.WriteLine("B");
            Wait5Seconds();
            Console.WriteLine("C");
        }

        static async Task RunFuncAsync()
        {
            Console.WriteLine("B");
            await Wait5SecondsAsync();
            Console.WriteLine("C");
        }

        static void Wait5Seconds()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Run");
        }


        static async Task Wait5SecondsAsync()
        {
            await Task.Run(() =>
            {
                Wait5Seconds();
            });
        }
    }
}
