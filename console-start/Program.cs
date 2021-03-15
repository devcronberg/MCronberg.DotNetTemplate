using System;
using MCronberg;

namespace Company.ConsoleApplication1 {
    class Program {
        static void Main(string[] args) 
        {

            // Se test.cs for eksempler på grundlæggende C#

            try
            {
                Console.WriteLine("Her starter program");

                // Kode
                // Eksempel på en metode i main
                Test();

                Console.WriteLine("Her slutter program");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der er sket en fejl {ex.Message}");                
            }
        }

        static void Test() {
            // Kode
            Console.WriteLine("I Test");
        }
    }
}