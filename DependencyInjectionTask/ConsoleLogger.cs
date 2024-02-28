﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTask
{
    public class ConsoleLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} - {message}");
        }
    }
}
