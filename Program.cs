using System;

namespace SobrecargaDeMetodos
{
    class Program
    {
        public double prom(double cal1, double cal2)
        {
            double p = (cal1 + cal2) / 2;
            return p;
        }

        public double prom(double cal1, double cal2, double pextra)
        {
            double p = (cal1 + cal2) / 2 + pextra;
            return p;
        }

        static void Main(string[] args)
        {
            Program promedio = new Program();
            Console.WriteLine("El promedio del alumno es = " + promedio.prom(6, 7.5));
            Console.WriteLine("El promedio del alumno es = " + promedio.prom(5, 8,.6));
            Console.ReadKey();
        
        }
    }
}
