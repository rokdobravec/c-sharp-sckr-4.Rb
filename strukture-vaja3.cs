using System;

namespace vaja3
{
    class Program
    {
        struct Komplex
        {
            public double Y, X, Zabs, Fi;
            public Komplex(double x, double y)
            {
                X = x;
                Y = y;
                Zabs = 0;
                Fi = 0;
            }
        }
        static void Main(string[] args)
        {
            var rnd = new Random();
            Komplex Z = new Komplex(rnd.Next(100) / 10.0, rnd.Next(100) / 10.0);

            Console.WriteLine("Z = {0} + i{1}", Z.X, Z.Y);

            Z.Zabs = Math.Sqrt(Math.Pow(Z.X, 2) + Math.Pow(Z.Y, 2));
            Z.Fi = Math.Atan(Z.Y/Z.X) * 180/Math.PI;
            Z.Zabs = Math.Round(Z.Zabs, 1);
            Z.Fi = Math.Round(Z.Fi, 1);
            Console.WriteLine("Z = {0} * EXP(I{1})", Z.Zabs, Z.Fi);

        }
    }
}
