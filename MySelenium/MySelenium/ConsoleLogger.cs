using System;
using System.Collections.Generic;
using System.Text;

namespace MySelenium
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
