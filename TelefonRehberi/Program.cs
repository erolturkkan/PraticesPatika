using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("Erol", "Turkkan", "0555 555 55 55"));
            kisiler.Add(new Kisi("Bunyamin", "Barricade", "0543 345 34 34"));
            kisiler.Add(new Kisi("Marshell", "Reis", "0789 789 78 78"));

            KisiYonetici kisiYonetici = new KisiYonetici(kisiler);
            while (true)
            {
                Console.WriteLine("\n\n  Lutfen yapmak istediginiz islemi seciniz :) ");
                Console.WriteLine("  *******************************************");
                Console.WriteLine("  (1) Yeni Numara Kaydetmek");
                Console.WriteLine("  (2) Varolan Numarayi Silmek");
                Console.WriteLine("  (3) Varolan Numarayi Guncelleme");
                Console.WriteLine("  (4) Rehberi Listelemek");
                Console.WriteLine("  (5) Rehberde Arama Yapmak﻿");
                Console.WriteLine("  (6) Uygulamayi Kapat\n");

                try
                {
                    Console.Write("  Lutfen yapmak istediginiz islemi seciniz : ");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim <1 || secim > 6)
                    {
                        Console.WriteLine("Hatalı secim, 1 ile 6 arası secim yapmalisiniz.");
                        continue;
                    }
                    else if (secim == 6)
                    {
                        break;
                    }

                    Console.Clear();

                    if (secim == 1)
                    {
                        Console.Write(" Lutfen isim giriniz : ");
                        string isim = Console.ReadLine();
                        Console.Write(" Lutfen soyisim giriniz : ");
                        string soyisim = Console.ReadLine();
                        Console.Write(" Lutfen telefon no giriniz : ");
                        string telefonNumarasi = Console.ReadLine();
                        Kisi kayitedilecek = new Kisi(isim, soyisim, telefonNumarasi);

                        kisiler.Add(kayitedilecek);

                        Console.WriteLine("Kayit islemi gerceklestirildi.");
                        break;
                    }else if (secim == 2)
                    {
                        while (true)
                        {
                            Console.Write("  Lutfen numarasini silmek istediginiz kisinin adini ya da soyadini giriniz : ");
                            string sorgula = Console.ReadLine();
                            int index = -1;

                            if (kisiYonetici.numaraVarMi(sorgula, out index))
                            {
                                Console.WriteLine(sorgula + " degerinizle eslesen kayit silinmek uzere, onayliyor musunuz? (y/n) ");
                                Console.Write("Seciminiz : ");
                                string secimOnayi = Console.ReadLine();

                                if (secimOnayi == "y" ||  secimOnayi == "Y")
                                {
                                    kisiYonetici.numaraSil(index);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi. Lutfen islem seciniz.");
                                Console.WriteLine(" *Islemi sonlandirmak icin: (1)");
                                Console.WriteLine(" *Yeniden denemek icin: (2)");

                                Console.Write("Seçiminiz:");
                                int yeniSecim = Convert.ToInt32(Console.ReadLine());
                                if (yeniSecim == 1)
                                {
                                    break;
                                }
                            }

                        }
                        break;

                    }
                    else if (secim == 3)
                    {
                        while (true)
                        {
                            Console.Write("Lutfen numarasini guncellemek istediginiz kisinin adini ya da soyadini giriniz : ");
                            string sorgula = Console.ReadLine();
                            int index = -1;

                            if (kisiYonetici.numaraVarMi(sorgula, out index))
                            {
                                Console.Write(sorgula + " degerinizle eslesen kaydi güncellemek icin yeni numara giriniz : ");
                                string yeniNumara = Console.ReadLine();

                                kisiYonetici.numaraGuncelle(index, yeniNumara);

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi. Lütfen islem seciniz.");
                                Console.WriteLine(" *Guncellemeyi sonlandırmak icin : (1)");
                                Console.WriteLine(" *Yeniden denemek icin : (2)");

                                Console.Write("Seciminiz : ");
                                int yeniSecim = Convert.ToInt32(Console.ReadLine());
                                if (yeniSecim == 1)
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    else if (secim == 4)
                    {
                        Console.WriteLine("Hangi duzende siralamak istediginizi seciniz.");
                        Console.WriteLine(" *A-Z icin: (1)");
                        Console.WriteLine(" *Z-A icin: (2)");
                        Console.Write("Seciminiz:");
                        int siralamaSecimi = Convert.ToInt16(Console.ReadLine());

                        if (siralamaSecimi == 2)
                        {
                            kisiYonetici.rehberiListele(siralamaSecimi);
                        }
                        else
                        {
                            kisiYonetici.rehberiListele(siralamaSecimi);
                        }

                        break;
                    }
                    else if (secim == 5)
                    {
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                        Console.WriteLine(" *İsim veya soyisime göre arama yapmak için: (1)");
                        Console.WriteLine(" *Telefon numarasına göre arama yapmak için: (2)");

                        Console.Write("Seçiminiz:");
                        int yeniSecim = Convert.ToInt16(Console.ReadLine());

                        if (yeniSecim == 1)
                        {
                            Console.Write("İsim veya soyisim giriniz:");
                            string arananAdVeyaSoyad = Console.ReadLine();
                            kisiYonetici.isimSoyisimAra(arananAdVeyaSoyad);
                        }
                        else
                        {
                            Console.Write("Telefon giriniz:");
                            string arananTelefonNumarasi = Console.ReadLine();
                            kisiYonetici.telefonNumarasiAra(arananTelefonNumarasi);
                        }

                        break;
                    }

                Console.WriteLine("\n Yeni islem icin bir tusa basiniz.");
                Console.ReadKey();
                Console.Clear();
                }
                
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata tespit edildi.");
                    Console.WriteLine(e.Message.ToString());
                    break;
                }


            }

            Console.ReadLine();
        }
    }
}
