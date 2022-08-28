using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DentalNation.source.libs
{
    internal class Config
    {
        static private List<KeyValuePair<string, List<string>>> config;

        static public void Init(string FileName)
        {
            config = new List<KeyValuePair<string, List<string>>>();

            string[] lines = File.ReadAllLines(FileName);

            Logger.Write(Level.DEBUG, "Readed lines from config file: " + lines.Length);

            foreach (string line in lines)
            {
                if (line.Length == 0)
                {
                    continue;
                }

                if (line.First() == '[' && line.Last() == ']')
                {
                    var newLine = line.Substring(1, line.Length - 2);
                    var values = new List<string>();
                    var key = new KeyValuePair<string, List<string>>(newLine, values);
                    config.Add(key);
                }
                else
                {
                    config.Last().Value.Add(line);
                }
            }
        }

        static public List<string> GetValues()
        {
            List<string> categories = new List<string>();

            foreach (KeyValuePair<string, List<string>> key in config)
            {
                categories.Add(key.Key);
            }

            return categories;
        }

        static public List<string> GetMaterials(string category)
        {
            foreach(KeyValuePair<string, List<string>> key in config)
            {
                if(key.Key == category)
                {
                    return key.Value;
                }
            }

            return new List<string>();
        }
    }
}
