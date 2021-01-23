using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri1.Id = 1;
            musteri1.Name = "Engin";
            musteri1.SurName = "Demirog";
            musteri1.TcNo = "123456789";
            musteri1.CustemerNo = "20";

            musteri2.Id = 2;
            musteri2.CustemerNo = "5432";
            musteri2.CompanyName = "codlama.io";
            musteri2.VergiNo = "4536";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customermanager = new CustomerManager();

            customermanager.Add(musteri1);
            customermanager.Add(musteri2);
            customermanager.Add(musteri3);
            customermanager.Add(musteri4);
        }
    }
}
