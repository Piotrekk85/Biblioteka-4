using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Ksiazka:Pozycja
    {
        private int LiczbaStron;
        public Autor narodowosc;

        public override void WypiszInfo()
        { 
            Console.WriteLine("Liczba stron: "+LiczbaStron);
            Console.WriteLine("Narodowosc: " + narodowosc); 
        
        
        
        
        }
    }
}
