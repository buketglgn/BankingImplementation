using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class TasitKrediManager : IkrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("TAŞIT Kredisi Ödeme Planı Hesaplandı");
        }

        public void KrediIsmi()
        {
            Console.WriteLine("TAŞIT KREDİSİ");
        }

        public void SureSoyle()
        {
            Console.WriteLine("SÜRE: 50 AY");
        }
    }
}
