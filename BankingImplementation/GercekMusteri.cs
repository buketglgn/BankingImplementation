using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class GercekMusteri :Musteri
    {
        private string _firstName;
        public String TcNo { get; set; }
        public string Adi {
            get { return "SAYIN " + _firstName;  }
            set { _firstName = value; }
        }
        public string SoyAdi { get; set; }

    }
}
