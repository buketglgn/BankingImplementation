using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class MusteriManager
    {
        List<GercekMusteri> realCustomers = new List<GercekMusteri>();
        List<TuzelMusteri> tuzelCustomers = new List<TuzelMusteri>();
        public void Addrealcustomer (Musteri realmusteri)
        {
            realCustomers.Add((GercekMusteri)realmusteri);
        }
        public void AddTuzelCustomer(Musteri TuzelMusteri)
        {
            
            tuzelCustomers.Add((TuzelMusteri)TuzelMusteri);
        }

        public void ShowRealCustomers()
        {
            Console.WriteLine("GERÇEK MÜSTERİLER GÖSTERİLİYOR..");
            foreach (var customerx in realCustomers)
            {
                Console.WriteLine("MÜSTERİ ADI SOYADI: "+customerx.Adi+" "+customerx.SoyAdi);
                Console.WriteLine("MÜSTERİ NO: " + customerx.MusteriNo);
            }
        }

        public void DeleteRealCustomer(Musteri realMusteri)
        {
            for (int i = 0; i < realCustomers.Count; i++)
            {
                if (realCustomers[i].Equals(realMusteri))
                {
                    realCustomers.RemoveAt(i);
                }

            }
        }
        public void DeleteTuzelCustomer(Musteri tuzelCustomer)
        {
            for (int i = 0; i < tuzelCustomers.Count; i++)
            {
                if (tuzelCustomers[i].Equals(tuzelCustomer))
                {
                    tuzelCustomers.RemoveAt(i);
                }

            }
        }

        public void ShowTuzelCustomers()
        {
            Console.WriteLine("TUZEL MÜSTERİLER GÖSTERİLİYOR..");
            foreach (var customer in tuzelCustomers)
            {
                Console.WriteLine("ŞİRKET ADİ: "+customer.SirketAdi);
                Console.WriteLine("MUSTERİ NO: " + customer.MusteriNo);
            }
        }
    }
}
