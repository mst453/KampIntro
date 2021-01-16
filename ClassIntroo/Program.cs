using System;

namespace ClassIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursEgitmeni = "Engin";
            kurs1.kursKursAdi = "C#";
            kurs1.IzlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursEgitmeni = "Berkay";
            kurs2.kursKursAdi = "python";
            kurs2.IzlenmeOrani = 70;

            Console.WriteLine(kurs1.kursKursAdi + " " + kurs1.KursEgitmeni + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursKursAdi);
            }
        }
    }
    // class = struct bir nevi
    class Kurs
    {
        public string kursKursAdi { get; set; }

        public string KursEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
