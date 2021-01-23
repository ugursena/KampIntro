using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //TasitKrediManager tasitKrediManager = new
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //KonutKrediManager konutKrediManager = new KonnutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<ILoggerService> loggers = new List<IloggerService> {new SmsLoggerService(), new FileLoggerService() };


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }

    internal class SmsLoggerService : IloggerService
    {
    }
}
