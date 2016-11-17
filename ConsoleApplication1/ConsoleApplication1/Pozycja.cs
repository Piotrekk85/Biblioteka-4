using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja() { }
        public Pozycja(string tyt, int Id, string wyd, int rok)
        {
            tytul = tyt;
            id = Id;
            wydawnictwo = wyd;
            rokWydania = rok;


        }
        abstract public void WypiszInfo();

    }
}