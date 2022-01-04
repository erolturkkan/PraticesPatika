using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Kisi //kisi adında bir class olusturdum, burasi ozellik tutacak
    {
        private string isim;
        private string soyisim;
        private string telefonNumarasi;

        public Kisi(string isim, string soyisim, string telefonNumarasi)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.TelefonNumarasi = telefonNumarasi;
        }

        public string Isim 
        {
            get
            {
                return isim;
            }
            set => isim = value;
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }
    }
}
