using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class IhtiyacKrediManager : IkrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İHTİYAÇ Kredisi Ödeme Planı Hesaplandı");
        }

        public void KrediIsmi()
        {
            Console.WriteLine("İHTİYAÇ KREDİSİ");
        }

        public void SureSoyle()
        {
            Console.WriteLine("SÜRE: 20 AY");
        }
    }
}
