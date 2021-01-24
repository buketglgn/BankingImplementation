using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class MudurManager : IWorkerManager
    {
        public void GetSalary()
        {
            Console.WriteLine("MÜDÜR maaşı hesaplanacak");
        }

        public void PozisyonBelirt()
        {
            Console.WriteLine("MÜDÜR");
        }

        public void YillikIzin()
        {
            Console.WriteLine("STAJYER izni hesaplanacak");
        }
    }
}
