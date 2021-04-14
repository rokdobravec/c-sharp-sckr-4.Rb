using System;

namespace strokture_tabele_vaja1
{
    class Program
    {
        struct Dijak
        {
            public int id;
            public string ime;
            public Dijak(int ID, string Ime) // konstruktor
            {
                id = ID;
                ime = Ime;
            }
        }
        static void Main(string[] args)
        {

            Dijak[] dijaki = new Dijak[10];  // ustvarimo 10 polj v struct dijak tabeli

            // dijaki[0].id = 1;               // vnos enega imena v izbran index v struct dijak tabeli
            // dijaki[0].ime = "Rok";


            for(int i =0; i<dijaki.Length;i++)  // zanka za vpis imen v struct dijak tabeli
            {
                dijaki[0].id = i+1;
                dijaki[0].ime = Console.ReadLine();

                dijaki[i] = new Dijak(i + 1, Console.ReadLine());    // vpis s konstruktorjem
            }




        }
    }
}
