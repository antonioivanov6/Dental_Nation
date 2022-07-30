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
            writer = new StreamWriter(fileName);
            writer.AutoFlush = true;
        }

        static public void Write(Level lvl, String message)
        {
            DateTime now = DateTime.Now;

            writer.WriteLine("[" 
                + now.ToShortDateString() + " "
                + now.ToLongTimeString() + ":" 
                + now.Millisecond + "][" 
                + lvl.ToString() + "] " 
                + message);
        }

        static private StreamWriter writer;
    }
}
