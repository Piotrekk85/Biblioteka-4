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
       
        public Katalog(string dzialTem) //listaPozycji jest polem, więc nie musi być parametrem
        {
            this.dzialTematyczny = dzialTem;
            listaPozycji = new List<Pozycja>(); //nie taka składnia

        }

        public Katalog() { }

        public void DodajPozycje(Pozycja pozycja) //to nie jest dobra praktyka by pole w klasie było parametrem w metodzie
        {
            listaPozycji.Add(pozycja);
        }

        //metoda na dodanie ksiązki z parametrami
        public void DodajPozycje(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            listaPozycji.Add(new Ksiazka(imie, nazwisko, tytul, id, wydawnictwo, rokWydania, liczbaStron));
        }

        //metoda na dodanie czasopisma z parametrami
        public void DodajPozycje(int numer, string tytuł, int id, string wydawnictwo, int rokWydania)
        {
            listaPozycji.Add(new Czasopismo(numer, tytuł, id, wydawnictwo, rokWydania));
        }

        //metoda wyszukiwania po tytule (teoretycznie możemy otrzymac kilka rzeczy więc wracamy listę)
        public void WyszukajPoTytule(string tytuł)
        {
            List<Pozycja> wysz = listaPozycji.FindAll(x => x.PobierzTytul() == tytuł);
            foreach (var element in wysz)
            {
                element.WypiszInfo();
                for (int i = 0; i < 55; i++) Console.Write("*");
                Console.WriteLine("*");
            }
        }


        //emtoda wyszukiwania po id, tu wynik mamy jeden po id zwykle jest unikalne
        public void WyszukajPoId(int id)
        {
            Pozycja wyszuk = listaPozycji.Find(x => x.PobierzId() == id);
            wyszuk.WypiszInfo();
        }

        public void WypiszWszystko()
        {
            foreach (var element in listaPozycji)
            {
                element.WypiszInfo();
                for (int i = 0; i < 55; i++) Console.Write("*");
                Console.WriteLine("*");
            }
        }

        //public  void WypiszInfo() to zbędne
        //{
        //    Console.WriteLine("Dzial: "+dzialTematyczny);
        
        
        //}
    }
}
