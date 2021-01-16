using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Name convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("sepete eklendi : "+urun.Adi);


        }
        public void Ekle2(string UrunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("sepete2 eklendi : " + UrunAdi);
        }
    }
}
