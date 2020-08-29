using System;
using MCronberg;

namespace Company.ConsoleApplication1 {
    class Program {
        static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Her starter program");
                
                // Kode

                Console.WriteLine("Her slutter program");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der er sket en fejl {ex.Message}");                
            }
        }
    }
}