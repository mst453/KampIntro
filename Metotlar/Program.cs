using System;

namespace Metotlar
{
    class Program
    {
        // metotlar tekrar tekrar kullanılmayı saglayan kod bloglarıdır
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1 , urun2};
            //type-safe
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("-----------------methotlar-----------------");
            //instance
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle2(urun1.Adi,urun1.Aciklama,urun1.Fiyati);
            sepetmanager.Ekle2("elma", "çıtır", 15);




        }
    }
}
