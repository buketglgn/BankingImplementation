using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("VERİTABANINA LOGLANDI..");
        }
    }
}
