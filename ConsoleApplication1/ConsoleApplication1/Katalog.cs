using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        public List<Pozycja> listaPozycji;
       
        public Katalog(string dzialTem,List<Pozycja> listPoz)
        {
            dzialTematyczny = dzialTem;
            listaPozycji = listPoz;

        }
        public void  DodajPozycje(string dzial,List<Pozycja> pozycja) 
        {
            dzialTematyczny = dzial;
            listaPozycji = pozycja;        
        }
       public void WyszukajPoTytule(string tytul)
        {

            tytul = Console.ReadLine();
           

        
        }
       public void WyszukajPold(int Id)
        {
            Id = Convert.ToInt32(Console.ReadLine());
        
        }
       public void WypiszWszystko()
        {
        
        
        }
        public  void WypiszInfo() 
        {
            Console.WriteLine("Dzial: "+dzialTematyczny);
        
        
        }
    }
}
