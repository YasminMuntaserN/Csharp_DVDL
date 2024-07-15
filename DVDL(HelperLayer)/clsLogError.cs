﻿using System;
using System.Configuration;
using System.Diagnostics;

namespace DVDL_HelperLayer_
{
    public class clsLogError
    {
        /// <summary>
        ///   This Method For Loging Try Catch Exception From Data Access For This Project
        public static void LogError(Exception ex)
        {
            string sourceName = "DVDLProject"; 

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            string errorMessage = $"Exception occurred in: {ex.Source}\n" +
                $"Exception Message: {ex.Message}\n" +
                $"Exception Type: {ex.GetType().Name}\n" +
                $"Stack Trace: {ex.StackTrace}\n" +
                $"Error Location: {ex.TargetSite.Name}\n";

            EventLog.WriteEntry(sourceName, errorMessage, EventLogEntryType.Error);
        }

    }
}
