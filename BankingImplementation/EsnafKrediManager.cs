using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class EsnafKrediManager : IkrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("ESNAF Kredisi Ödeme Planı Hesaplandı");
        }

        public void KrediIsmi()
        {
            Console.WriteLine("ESNAF KREDİSİ");
        }

        public void SureSoyle()
        {
            Console.WriteLine("SÜRE: 60 AY");
        }
    }
}
