using System;

namespace vaja2
{
    class Program
    {
        struct Tocka
        {
            public int X;
            public int Y;
        }
        static void Main(string[] args)
        {
            Tocka T1;
            Tocka T2 = new Tocka();

            Console.WriteLine("Vnesi X tocke T1: ");
            T1.X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesi Y tocke T1: ");
            T1.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesi X tocke T2: ");
            T2.X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesi Y tocke T2: ");
            T2.Y = Convert.ToInt32(Console.ReadLine());

            Double d = Razdalja(T1, T2);
            Console.WriteLine("Razdalja med točkama je : {0}", d);

        }
        static double Razdalja(Tocka T1, Tocka T2)
        {
            double d = Math.Sqrt(Math.Pow(T1.X - T2.X, 2) + Math.Pow(T1.Y - T2.Y, 2));
            return d;


        }
    }
}
