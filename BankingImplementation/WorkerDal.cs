using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class WorkerDal
    {
        //çalışanlar için ekleme silme güncelleme gibi işlemleri yapılacak
        List<IWorkerManager> workers = new List<IWorkerManager>();
        public void Add(IWorkerManager workerManager)
        {
            workers.Add(workerManager);
        }

        public void Delete(IWorkerManager worker)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Equals(worker))
                {
                    workers.RemoveAt(i);
                }
                
            }
            
        }

        public void ShowWorkers()
        {
            foreach (var item in workers)
            {
                item.PozisyonBelirt();
                item.GetSalary();
            }
        }
    }
}
