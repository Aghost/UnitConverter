using System;
using static System.Console;
using System.Collections.Generic;

namespace MeterConverter.Domain
{
    public class Logger {
        private string LogName;

        public Logger(string LogName) {
            this.LogName = LogName;
            WriteLine($"{LogName} logging started!");
        }

        public void Log(string msg) {
            WriteLine($"{LogName}: {msg}");
        }
    }
}
