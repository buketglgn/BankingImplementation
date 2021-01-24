using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class MemurManager : IWorkerManager
    {
        public void GetSalary()
        {
            Console.WriteLine("MEMUR maaşı hesaplanacak");
        }

        public void PozisyonBelirt()
        {
            Console.WriteLine("MEMUR");
        }

        public void YillikIzin()
        {
            Console.WriteLine("MEMUR izni hesaplanacak..");
        }
    }
}
