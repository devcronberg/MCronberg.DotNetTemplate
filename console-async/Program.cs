using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace console_async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            System.Console.WriteLine("Start");
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
            });            
            System.Console.WriteLine("End");
        }
    }
}
