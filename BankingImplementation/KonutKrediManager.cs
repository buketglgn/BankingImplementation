using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class KonutKrediManager : IkrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("KONUT Kredisi Ödeme Planı Hesaplandı");
        }

        public void KrediIsmi()
        {
            Console.WriteLine("KONUT KREDİSİ");
        }

        public void SureSoyle()
        {
            Console.WriteLine("SÜRE: 100 AY");
        }
    }
}
