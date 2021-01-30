using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safeyt - tip güvenliği
            //Do not repeat yourself - Kendidini tekrarlama
            //değer tutucu, alias
            string katagoriButonu = "Kategoriler";
            int kullaniciSayisi = 320000;
            double faizOrani = 1.45;
            bool uyeGirisi = false;

            Console.WriteLine(katagoriButonu);

            if (uyeGirisi==true)
            {
                Console.WriteLine("Kullanıcı profil ayarları");

            }
            else
            {
                Console.WriteLine("Giriş Yapın");
            }
        }
    }
}
