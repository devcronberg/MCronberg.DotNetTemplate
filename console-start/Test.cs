using System;

// Fjern advarsler omkring ubenyttede variabler mv
#pragma warning disable IDE0059 
#pragma warning disable CS0219 
#pragma warning disable CS0169 


namespace Company.ConsoleApplication1
{
    public class VariablerFlowMetoder
    {
        public void Test() {
            Variabler();
            Flow();
            MetodeVoidUdenArgumenter();
            MetodeVoidMedArgumenter(1,"");

            int a = MetodeUdenArgumenter();

            int b = MetodeMedArgumenter(1, 1);
        }

        public void MetodeVoidUdenArgumenter()
        {
        }

        public void MetodeVoidMedArgumenter(int a, string b)
        {
        }
        public int MetodeUdenArgumenter()
        {
            return 1;
        }

        public int MetodeMedArgumenter(int a, int b)
        {
            return a+b;
        }

        public void Variabler()
        {

            // Heltal

            int a = 0;

            // Kommatal
            double b = 0.0;

            // Sand / Falsk
            bool c = true;

            // Dato og tid
            DateTime d = new DateTime(2020, 5, 1);  // dato
            DateTime e = DateTime.Now;              // system tid

        }

        public void Flow()
        {
            int a = 1;
            int b = 2;


            // Hvis...
            if (a < b)
            {
                // kode
            }

            if (a < b)
            {
                // kode
            }
            else
            {
                // kode
            }

            // Hvis...
            switch (a)
            {
                case 1:
                    // kode
                    break;

                case 2:
                    // kode
                    break;

                default:
                    // kode
                    break;
            }

            // Løkker
            for (int i = 0; i < 5; i++)
            {
                // kode
            }

            int c = 10;
            do
            {
                c--;
            } while (c>0);

            int d = 0;
            while (d<10)
            {
                d++;
            }

        }

    }

    public class SimpelKlasse {

        // Felter
        private int a;
        public int b;

        // Fuld egenskab
        private int c;
        public int C {
            get { return c; }
            set { c = value; }
        }

        // Automatisk egenskab
        public int D { get; set; }

        public void Metode1() { 
        
        }
        public int Metode2() {
            return 1;
        }
        public int Metode3(int a, int b) {
            return 1 + 1;
        }
    }
}
#pragma warning restore IDE0059 
#pragma warning restore CS0219 
#pragma warning restore CS0169 