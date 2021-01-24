using System;
using System.Collections.Generic;
using System.Text;

namespace BankingImplementation
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("DOSYAYA LOGLANDI..");
        }
    }
}
