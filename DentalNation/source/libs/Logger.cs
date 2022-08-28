using System.IO;
using System;

namespace DentalNation.source.libs
{
    enum Level
    {
        DEBUG,
        ERROR
    }

    internal class Logger
    {
        static public void Init(String fileName)
        {
            string pth = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            writer = new StreamWriter(pth + "\\" + fileName);
            writer.AutoFlush = true;
        }

        static public void Write(Level lvl, String message)
        {
            DateTime now = DateTime.Now;

            writer.WriteLine("[" 
                + now.ToShortDateString() + " "
                + now.ToLongTimeString() + "][" 
                + lvl.ToString() + "] " 
                + message);
        }

        static private StreamWriter writer;
    }
}
