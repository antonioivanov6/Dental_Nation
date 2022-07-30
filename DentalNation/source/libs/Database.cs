using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace DentalNation.source.libs
{
    internal class Database
    {
        static public void Init(String connectionStr)
        {
            MySqlConnection Conn = new MySqlConnection(connectionStr);
        }
    }
}
