using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
           // ihtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //iki şekilde olur
            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();
            BasvuruManager basvuruManager = new BasvuruManager();
            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileBaseLoggerService = new FilebaseLoggerService();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, fileBaseLoggerService);
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }

    }
}
