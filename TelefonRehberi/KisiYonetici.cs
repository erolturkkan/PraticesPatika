using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class KisiYonetici
    {
        List<Kisi> kisiler = new List<Kisi>();

        public KisiYonetici(List<Kisi> kisiler)
        {
            this.kisiler = new List<Kisi>();
        }

        public void kisiGoster(Kisi kisi)
        {
            Console.WriteLine("\nİsim             : {0}",kisi.Isim);
            Console.WriteLine("Soyisim          : {0}", kisi.Isim);
            Console.WriteLine("Telefon Numarası : {0}\n", kisi.Isim);
        }

        public void isimSoyisimAra(string sorgula)
        {
            Console.WriteLine();

            bool varMi = false;

            for (int i = 0; i < kisiler.Count; i++)
            {
                if (sorgula == kisiler[i].Isim || sorgula == kisiler[i].Soyisim)
                {
                    kisiGoster(kisiler[i]);
                    varMi = true;
                }
            }

            if (varMi == false)
            {
                Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lutfen bir secim yapınız.");
            }
        }

        public void telefonNumarasiAra(string sorgula)
        {
            Console.WriteLine();
            bool varMi = false;

            for (int i = 0; i < kisiler.Count; i++)
            {
                if (sorgula == kisiler[i].TelefonNumarasi)
                {
                    kisiGoster(kisiler[i]);
                    varMi = true;
                }
            }
            if (varMi == false)
            {
                Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lutfen bir secim yapınız.");
            }
        }

        public bool numaraVarMi(string sorgula, out int index)
        {
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (sorgula == kisiler[i].Isim || sorgula == kisiler[i].Soyisim)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }

        public void numaraSil(int index)
        {   
            Console.WriteLine("{} kisisi silindi.",kisiler[index]);
            kisiler.RemoveAt(index);            
        }

        public void numaraGuncelle(int index, string yeniNumara)
        {
            kisiler[index].TelefonNumarasi = yeniNumara;
            Console.WriteLine("Guncellendi.");
        }
        public void rehberiListele(int sıralamaDuzeni)
        {
            kisiler.Sort((u1, u2) => u1.Isim.CompareTo(u2.Isim));

            if (sıralamaDuzeni == 2)
            {
                kisiler.Reverse();
            }
            Console.WriteLine();

            for (int i = 0; i < kisiler.Count; i++)
            {
                kisiGoster(kisiler[i]);
            }
        }

        

    }
}
