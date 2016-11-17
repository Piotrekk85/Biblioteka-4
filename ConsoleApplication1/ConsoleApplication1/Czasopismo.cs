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
            numer = num;


        }



        public override void WypiszInfo() 
        {
            Console.WriteLine("Numer: "+numer);
        
        
        
        }
    }
}
