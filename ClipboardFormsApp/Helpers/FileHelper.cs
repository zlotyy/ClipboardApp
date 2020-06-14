using System;
using System.IO;
using System.Text;

namespace ClipboardFormsApp.Helpers
{
    public static class FileHelper
    {
        public static string[] MemoryTexts;

        public static bool LoadMemoryTexts()
        {
            try
            {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var filePath = $"{baseDir}Skroty.txt";

                MemoryTexts = File.ReadAllLines(filePath, Encoding.UTF8);
                return true;
            }
            catch (Exception)
            {
                // logger;
                return false;
            }
        }
    }
}
