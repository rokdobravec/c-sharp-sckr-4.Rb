using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{
    //ustverimo class CAtlet
    class CAtlet
    {
        //Podatki možni v classu
        string ime, priimek, drzava;
        char spol;
        DateTime datum_rojstva;
        //konstruktor
        public CAtlet(string ime, string p,string d,char s,DateTime dr)
        {
            this.ime = ime;
            priimek = p;
            drzava = d;
            spol = s;
            datum_rojstva = dr;
        }
        //bralno pisalne lastnosti
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }
        public string Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }
        public char Spol
        {
            get { return spol; }
            set { spol = value; }
        }
        public DateTime Datum_rojstva
        {
            get { return datum_rojstva; }
            set { datum_rojstva= value; }
        }
    }
    //dedujemo razred CAtlet in izpeljemo razred Tek100
    class Tek100 : CAtlet
    {
        TimeSpan cas;
        //konstruktor
        public Tek100(string ime, string p, string d, char s, DateTime dr, TimeSpan c)
            : base(ime, p, d, s, dr)
        {
            cas = c;
        }
        //property
        public TimeSpan Cas
        {
            get { return cas; } 


            set { cas = value; }
        }
    }
}
