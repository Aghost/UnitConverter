using System;
using System.Collections.Generic;

namespace MeterConverter.Domain
{
    public class Logger {
        private string LogName;

        public Logger(string LogName) {
            this.LogName = LogName;
        }

        public void Log(string msg) {
            Console.WriteLine($"{LogName}: {msg}");
        }
    }
}
