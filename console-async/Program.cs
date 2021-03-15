using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Company.ConsoleApplication1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
            });            
            Console.WriteLine("End");
        }
    }
}
