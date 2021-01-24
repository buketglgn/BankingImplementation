using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class BasvuruManager
    {
        public void TekKrediBasvurusuYap(IkrediManager kredi,List<ILoggerService> loggerServices)
        {
            Console.WriteLine("SEÇİLEN KREDİ: ");
            kredi.KrediIsmi();
            kredi.SureSoyle();
            kredi.Hesapla();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
            
        }

        public void BirdenFazlaKrediBasvurusuYap(List<IkrediManager> secilenKrediler, ILoggerService loggerService)
        {
            foreach (var secilenKredi in secilenKrediler)
            {
                Console.Write("SEÇİLEN KREDİLER  ");secilenKredi.KrediIsmi();
                secilenKredi.SureSoyle();
                secilenKredi.Hesapla();
                
                
            }
            loggerService.Log();
        }
    }
}
