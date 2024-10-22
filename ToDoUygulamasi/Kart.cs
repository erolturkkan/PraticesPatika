﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulamasi
{
    internal class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyuluk Boyut { get; set; }

        public enum Buyuluk
        {
            XS,
            S,
            M,
            L,
            XL
        }

        public Kart(string baslik, string icerik, string atananKisi, Buyuluk boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Boyut = boyut;
        }

    }
}
