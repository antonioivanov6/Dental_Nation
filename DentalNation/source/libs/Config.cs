﻿using System.Collections.Generic;
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

        static public List<KeyValuePair<string, List<string>>> GetValues()
        {
            return config;
        }
    }
}