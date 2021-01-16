using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product kitaplar = new Product();
            Product kitaplar1 = new Product();

            kitaplar.Isim = "Od";
            kitaplar.Tur = "Roman";
            kitaplar.Yazar = "iskender pala";

            kitaplar1.Isim = "iz";
            kitaplar1.Tur = "Psikolojik";
            kitaplar1.Yazar = "Canan Tan";

            Product[] books = new Product[] { kitaplar, kitaplar1 };
            //for each kısmı

            foreach (var dizi in books)
            {
                Console.WriteLine(" " + dizi.Isim + " " + dizi.Tur + " " + dizi.Yazar);
            }
            //for bölümü

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(" " + books[i].Isim + " " + books[i].Tur + " " + books[i].Yazar);
            }

            int j = 0;
            while (j != books.Length)
            {
                Console.WriteLine(" " + books[j].Isim + " " + books[j].Tur + " " + books[j].Yazar);
                j++;
            }
        }

        class Product
        {
            public string Isim { get; set; }
            public string Tur { get; set; }
            public string Yazar { get; set; }

        }

    }
}
