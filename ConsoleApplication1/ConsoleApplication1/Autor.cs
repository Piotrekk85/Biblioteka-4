using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor() { }


        public Autor(string nar)//czy to jest tu potrzebne?
        {
            this.narodowosc = nar;//brak this


        }

        //konstruktor parametryczny, fajnie gdyby ten konstruktor nie ustawiał tylko samą narodowosc
        public Autor(string imie, string nazwisko, string narodowosc)
            : base(imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        //konstruktor z 2 parametrami (bez narodowosci) 
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}