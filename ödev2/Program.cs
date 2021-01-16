using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            product1.Kategori = "Bilgisayar";
            product1.UrunAdi = "Lenovo";
            product1.Fiyati = 6500;
            product1.Miktar = 100;

            product2.Kategori = "Tablet";
            product2.UrunAdi = "Apple";
            product2.Fiyati = 3700;
            product2.Miktar = 23;

            product3.Kategori = "Telefon";
            product3.UrunAdi = "Samsung";
            product3.Fiyati = 4500;
            product3.Miktar = 525;


            Product[] products = new Product[] { product1, product2, product3 };


            Console.WriteLine("-----foreach kısmı-----");
            foreach (var product in products)
            {
                
                Console.WriteLine("ürün adi : "+product.UrunAdi+" "+ product.Kategori+" "+ product.Fiyati+" "+ product.Miktar);
            }
            Console.WriteLine("-----for kısmı-----");
            for (int i = 0; i < products.Length; i++)
            {
                
                Console.WriteLine(products[i].UrunAdi+" "+ products[i].Kategori+" "+ products[i].Miktar+" "+ products[i].Fiyati);
            }
            Console.WriteLine("-----while kısmı-----");
            int a = 0;
            while ( a!= products.Length)
            {
                Console.WriteLine(products[a].UrunAdi + " " + products[a].Kategori + " " + products[a].Miktar + " " + products[a].Fiyati);
                a++;
            }

        }
    }



    class Product
    {
        public string Kategori { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyati { get; set; }
        public int Miktar { get; set; }
      

    }
}
