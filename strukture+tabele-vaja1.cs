using System;

namespace struct_tab_vaja1
{
    class Program
    {
        struct Vozovnica
        {
            public string relacija;
            public int km;
            public double cena;
            public const double cenakm = 0.15;
        }
        static void Main(string[] args)
        {
            Vozovnica[] vozovnice = new Vozovnica[6];


        }
        static void Vnos(Vozovnica[] vozovnice)
        {
            for(int i=0;i<vozovnice.Length;i++)
            {
                Console.Write("Vnesi relacija (kraj1-kraj2):");
                vozovnice[i].relacija = Console.ReadLine();

                Console.Write("Vnesi razdaljo krajev(km):");
                vozovnice[i].km = Convert.ToInt32(Console.ReadLine());
                vozovnice[i].cena = vozovnice[i].km * Vozovnica.cenakm;


                Console.WriteLine("Cena vozovnice je {0} €", vozovnice[i].cena);
            }


        }
        static void NaključniIzbor(Vozovnica[] vozovnice)
        {
            var rnd = new Random();

            Console.WriteLine(vozovnice[rnd.Next(7)]);
        }
    }
}
