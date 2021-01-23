using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //methot injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //basvuru bilgisi degerlendirme

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); //tüm basvuruları konu kredisi haline getirdik dogru bişey degildir.

            krediManager.Hesapla(); // dogrusu budur tüm kredi refranslarına ulasıyoruz.
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
