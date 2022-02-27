﻿using System;
using System.IO;
using Serilog;
using Serilog.Events;

namespace DatabaseJobs.Shared.Loggers
{
    public class LoggerConfig
    {

        public static void Register()
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs\\");

            Log.Logger = new LoggerConfiguration()
                //.WriteTo.Console()
                .WriteTo.File(logFilePath, LogEventLevel.Error, rollingInterval: RollingInterval.Day)
                .CreateLogger();

        }

    }
}
