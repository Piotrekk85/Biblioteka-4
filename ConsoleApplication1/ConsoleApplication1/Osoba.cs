
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba() { }

        public Osoba(string im, string naz)
        {

            this.imie = im;  //brak this
            this.nazwisko = naz; //brak this
            
        }
    }
}