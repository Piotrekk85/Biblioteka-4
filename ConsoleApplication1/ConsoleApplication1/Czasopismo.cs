using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Czasopismo:Pozycja
    {
        private int numer;

        public Czasopismo() { }
        public Czasopismo(int num)
        {
            this.numer = num;//znów brak this


        }

        //konstruktor parametryczny (lepiej użyc base)
        public Czasopismo(int numer, string tytuł, int id, string wydawnictwo, int rokWydania)
            : base(tytuł, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }


        public override void WypiszInfo() //za mało informacji we wnętrzu
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Numer: {0}", numer);
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
        }
    }
}
