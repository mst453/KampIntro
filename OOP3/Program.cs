using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager  ihtiyacKrediManager = new IhtiyacKrediManager();
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager  konutKrediManager = new KonutKrediManager();

            ILoggerService loggerService = new FileLoggerService();
            ILoggerService databaseloggerservice = new DataBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseloggerservice); //new DataBaseService()

            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
