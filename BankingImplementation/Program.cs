using System;
using System.Collections.Generic;

namespace BankingImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Buket";
            musteri1.SoyAdi = "Gülgün";
            musteri1.TcNo = "123456789";
            musteri1.Id = 1;
            musteri1.MusteriNo = "111";

            GercekMusteri musteri2 = new GercekMusteri();
            musteri2.Adi = "Bertan";
            musteri2.SoyAdi = "Taner";
            musteri2.TcNo = "987654321";
            musteri2.Id = 2;
            musteri2.MusteriNo = "222";

            GercekMusteri musteri3 = new GercekMusteri();
            musteri3.Adi = "ceylin";
            musteri3.SoyAdi = "Gülgün";
            musteri3.TcNo = "34587220";
            musteri3.Id = 3;
            musteri3.MusteriNo = "333";

            TuzelMusteri musteri4 = new TuzelMusteri();
            musteri4.SirketAdi = "İnstagram";
            musteri4.VergiNo = "0000000";
            musteri4.Id = 4;
            musteri4.MusteriNo = "444";

            TuzelMusteri musteri5 = new TuzelMusteri();
            musteri5.SirketAdi = "Kodlama.io";
            musteri5.VergiNo = "999999";
            musteri5.Id = 5;
            musteri5.MusteriNo ="555";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Addrealcustomer(musteri1);
            musteriManager.Addrealcustomer(musteri2);
            musteriManager.Addrealcustomer(musteri3);

            musteriManager.AddTuzelCustomer(musteri4);
            musteriManager.AddTuzelCustomer(musteri5);

            musteriManager.ShowRealCustomers();
            musteriManager.ShowTuzelCustomers();

            Console.WriteLine("REAL musteri 2 siliniyor...");
            Console.WriteLine("TUZEL musteri 5 siliniyor...");

            musteriManager.DeleteRealCustomer(musteri2);
            musteriManager.DeleteTuzelCustomer(musteri5);

            musteriManager.ShowRealCustomers();
            musteriManager.ShowTuzelCustomers();


            IkrediManager konutKrediManager = new KonutKrediManager();
            IkrediManager tasitKrediManager = new TasitKrediManager();
            IkrediManager esnafKrediManager = new EsnafKrediManager();
            IkrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<IkrediManager> krediler = new List<IkrediManager> { konutKrediManager, tasitKrediManager, esnafKrediManager, ihtiyacKrediManager };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.TekKrediBasvurusuYap(tasitKrediManager,new List<ILoggerService> { smsLoggerService, databaseLoggerService });

            basvuruManager.BirdenFazlaKrediBasvurusuYap(new List<IkrediManager> { konutKrediManager, ihtiyacKrediManager }, fileLoggerService);
        }
    }
}
