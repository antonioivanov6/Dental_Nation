using System;
using MySql.Data.MySqlClient;

namespace DentalNation.source.libs
{
    internal class Database
    {
        static private MySqlConnection conn;

        static public void Init(String connectionStr)
        {
            conn = new MySqlConnection(connectionStr);
            MySqlCommand cmd = conn.CreateCommand();
            
            conn.Open();
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `dental`;";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
