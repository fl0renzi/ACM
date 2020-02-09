using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsTolog)
        {
            foreach (var item in itemsTolog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
