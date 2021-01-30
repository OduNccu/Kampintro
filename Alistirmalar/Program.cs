using System;

namespace Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Fonksiyonel Gelincik Çalışma Masası";
            urun1.UrunFiyati = 379.90;
            urun1.UrunİndirimOrani = 32;
            urun1.UrunİndirimliFiyati = 169.90;
            

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Tripod Lambader Krem Başlk Ceviz Ayak";
            urun2.UrunFiyati = 99.90;
            urun2.UrunİndirimOrani = 11;
            urun2.UrunİndirimliFiyati = 74.89;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Çift Kişlik Pamuk Yorgan Seti +2 Adet Yastık";
            urun3.UrunFiyati = 169.90;
            urun3.UrunİndirimOrani = 47;
            urun3.UrunİndirimliFiyati = 89.90;
            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length ; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + "\n Fiyat: " + urunler[i].UrunFiyati + "__%" + urunler[i].UrunİndirimOrani + "İndirim__İndirimli Fiyat: " + urunler[i].UrunİndirimliFiyati + "\n"); ;


            }

            Console.WriteLine("___________________________________________________");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi+"\n Fiyat: " + urun.UrunFiyati+"__%" + urun.UrunİndirimOrani +  "İndirim__İndirimli Fiyat: "+urun.UrunİndirimliFiyati + "\n" ); ;
            }
            Console.WriteLine("___________________________________________________");

            int j = 0;
            while (j<3)
            {
                Console.WriteLine(urunler[j].UrunAdi + "\n Fiyat: " + urunler[j].UrunFiyati + "__%" + urunler[j].UrunİndirimOrani + "İndirim__İndirimli Fiyat: " + urunler[j].UrunİndirimliFiyati + "\n"); ;
                j++;
            }
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public double UrunİndirimliFiyati { get; set; }
        public int UrunİndirimOrani { get; set; }
    }
}
