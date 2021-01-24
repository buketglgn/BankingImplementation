using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class StajyerManager : IWorkerManager
    {
        
        public void GetSalary()
        {
            Console.WriteLine("STAJYER maasi hesaplanacak");
        }

        public void PozisyonBelirt()
        {
            Console.WriteLine("STAJYER");
        }

        public void YillikIzin()
        {
            Console.WriteLine("STAJYER  izni hesaplanacak");
        }
    }
}
