﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int Id); //literówka
        void WypiszWszystko();
    }
}
