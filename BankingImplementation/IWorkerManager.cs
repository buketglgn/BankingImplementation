using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    interface IWorkerManager
    { //bankada çalışanlar için 
        void GetSalary();
        void YillikIzin();
        void PozisyonBelirt(); //stajyer, müdür, hizmetli, memur

    }
}
