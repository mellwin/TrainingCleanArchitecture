using System;
using System.IO;

namespace InspectionPipesJournal.DAL
{
    public class Logging
    {
        private const string logFilePath = "..\\LogFile.txt";
        public void Info(string exception)
        {
            try
            {
                string text = $"{DateTime.Now} {exception}\n";
                File.AppendAllText(logFilePath, text);
            }
            catch { } //Не критический функционал
        }
    }
}