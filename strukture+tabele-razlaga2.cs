using System;

namespace strokturre_tabele
{
    class Program
    {
        struct Dijak
        {
            public int id;
            public string ime;
            public int[] ocene;    // tabela kot polje strukture
        }
        static void Main(string[] args)
        {
            Dijak dijak = new Dijak();
            dijak.ime = "Rok";

            dijak.ocene = new int[5];        // določimo velikost tabele
            for(int i = 0; i<dijak.ocene[i]; i++)
            {
                dijak.ocene[i] = 5;
            }
        }
    }
}
