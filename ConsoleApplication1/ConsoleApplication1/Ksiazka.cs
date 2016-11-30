using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Ksiazka:Pozycja
    {
        private int liczbaStron; //nazwy zmiennych zgodnie z paradygmatem powinny byc od malej litery
        public Autor autor; //tu nie tak

        //konstruktor parametryczny (warto go uzupełnić by ustawiał autora, jako nowy obiekt)
        public Ksiazka(string imie, string nazwisko,string tytul, int id, string wydawnictwo, int rokWydania,int liczbaStron)
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie,nazwisko);
        }
        
        //konstruktor domyślny (warto dodać tworzenie pola autor jako obiektu Autor)
        public Ksiazka()
        {
            autor = new Autor();
        }

                
        //w klasie potomnej musimy przesłonić metodę abstrakcyjną i dodać implementację
        public override void WypiszInfo()
        {
            //za mało informacji we wnętrzu
            Console.WriteLine("Tytuł: {0}",tytul);
            Console.WriteLine("Autor: {0}",autor.PobierzAutora());
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
            Console.WriteLine("Liczba stron: {0}", liczbaStron);
        }
    }
}
