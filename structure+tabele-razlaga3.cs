using System;

namespace strukture_tabela3
{
    class Program
    {
        struct Dijak
        {
            public int id;
            public string ime;
            public int[] ocene;
        }
        static void Main(string[] args)
        {
            Dijak[] dijaki = new Dijak[10];
            
            for(int i=0;i<dijak.Length;i++)
            {
                dijaki[i].id = i + 1;
                dijaki[i].ime = Console.ReadLine();
                dijaki[i].ocene = new int[5];
                for(int k=0; k<dijaki[i].ocene.Length;k++)
                {
                    dijaki[i].ocene[k] = 5;
                }
            }
        }
    }
}
