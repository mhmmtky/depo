using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne yapmak istiyorsunuz?"); Console.WriteLine("1-) Ürün Ekle"); Console.WriteLine("2-) Satış");
            int karar = Convert.ToInt32(Console.ReadLine());
            List<string> urunIsmi = new List<string>();
            List<int> birimFiyat = new List<int>();

            urunIsmi.Add("Bisküvi");
            birimFiyat.Add(15);
            while (true)
            {
                if (karar == 1)
                {
                    Console.WriteLine("Varolan bir ürün mü girmek istersiniz, yoksa yeni bir ürün mü oluşturmak istersiniz? 1-) Varolan, 2-) Yeni");
                    int karar2 = Convert.ToInt32(Console.ReadLine());
                    if (karar2 == 1)
                    {
                        Console.WriteLine("Ürün adını giriniz:");
                        string urunAdi = Console.ReadLine();

                        int deger = urunIsmi.IndexOf(urunAdi);


                        if (deger >= 0)
                        {
                            Console.WriteLine("Ürün: " + urunAdi + " " + "Fiyatı: " + birimFiyat[deger]);
                        }


                    }
                    else if (karar2 == 2)
                    {
                        Console.WriteLine("Ürün adını giriniz: ");
                        string urunAdi = Console.ReadLine();
                        Console.WriteLine("Ürünün birim fiyatını giriniz: ");
                        int birFiyat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        urunIsmi.Add(urunAdi);
                        birimFiyat.Add(birFiyat);
                        Console.WriteLine("Ürünler eklendi yeni bir ürün eklemek istermisiniz? E - H");
                        string karar3 = Console.ReadLine();
                        if (karar3 == "E") { Console.WriteLine(); }
                        else if (karar3 == "H")
                        {
                            Console.Write("Ürün Adı: "); foreach (string i in urunIsmi) { Console.Write(i + " "); }
                            Console.WriteLine(); Console.Write("Birim Fiyatı Sırasıyla: "); foreach (int i in birimFiyat) { Console.Write(i + " "); }
                            Console.WriteLine();

                        }

                    }
                    else { Console.WriteLine("Geçerli bir değer giremediniz!"); }
                }
                else if (karar == 2)
                {
                    Console.WriteLine("Satışı yapılacak ürünü girin: ");
                    string satis = Console.ReadLine();
                    int deger = urunIsmi.IndexOf(satis);

                    if (deger >= 0)
                    {
                        Console.WriteLine("ürün: " + satis + " Fiyatı: " + birimFiyat[deger]);
                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz?");
                        string karar3 = Console.ReadLine();
                        if (karar3 == "E") { }
                        else if (karar3 == "H") { break; }
                        else { Console.WriteLine("Geçerli bir değer giremediniz."); }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir değer giremediniz!");
                    }

                }
                else
                {
                    Console.WriteLine("Geçerli bir değer giremediniz!");
                }
            }
            Console.ReadKey();

        }
    }
}

