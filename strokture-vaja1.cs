using System;
using System.Collections;

namespace vaja
{
    class Program
    {
        //Ustvari netipizirano zbirko in vanjo vnesi 1000 naključnih decimalnih števil z dvema decimalkama do velikosti 1000. 
        // Napiši metodo, ki najde in izpiše največje število.
        // Napiši metodo, ki sešteje vse decimalke.
        static void Main(string[] args)
        {
            ArrayList števila = new ArrayList();
            Random r = new Random();

            for(int i = 0;i<1000;i++)
            {
                double d = r.Next(0, 1000) + Math.Round(r.NextDouble(), 2);
                    števila.Add(d);
            }
            foreach( object item in števila)
            {
               Console.WriteLine(item);
            }
        }
        static void NajvečjeŠtevilo(ArrayList števila)
        {
            double max = 0;
            for(int i =0;i< števila.Count;i++)
            {
                if ((double)števila[i] > max)
                {
                    max = (double)števila[1];
                    Console.WriteLine(max);
                }
            }
        }
    }
}
