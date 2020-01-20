using System;
using System.IO;

namespace PhoenixPointModLoader
{
    internal static class Logger
    {
        internal static string LogPath { get; set; }

        internal static void Log(string message, params object[] formatObjects)
        {
            if (string.IsNullOrEmpty(LogPath)) return;
            using (var logWriter = File.AppendText(LogPath))
            {
                logWriter.WriteLine(DateTime.Now.ToLongTimeString() + " - " + message, formatObjects);
            }
        }
    }
}
