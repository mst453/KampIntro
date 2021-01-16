using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazilim gelistirme kursu";
            string kurs2 = "programlamaya baslangıc icin temel kurs";
            string kurs3 = "java";
            //array dizi
            string[] kurslar = new string[] { "yazilim gelistirme kursu", "programlamaya baslangıc icin temel kurs", "java","c++","C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
