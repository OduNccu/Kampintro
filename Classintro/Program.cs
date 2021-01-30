using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hamza Erdal";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre Erdal";
            kurs2.IzlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Melisa Erdal";
            kurs3.IzlenmeOrani = 95;
            // //(comment line)
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani{ get; set; }
        
    }
}
