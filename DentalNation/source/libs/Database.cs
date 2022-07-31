using System;
using MySql.Data.MySqlClient;

using System.Collections.Generic;

namespace DentalNation.source.libs
{
    class DBRows
    {
        public List<string> fields;
        public DBRows()
        {
            fields = new List<string>();
        }
    }

    class DBError
    {
        public bool hasError;
        public string errorMsg;

        public DBError()
        {
            hasError = false;
            errorMsg = "";
        }
    }

    class DBResult
    {
        public List<DBRows> rows;
        public DBError error;
        public Int32 affecredRows;

        public DBResult()
        {
            rows = new List<DBRows>();
            error = new DBError();
            affecredRows = 0;
        }
    }

    internal class Database
    {
        public Database(string server, string uid, string pass)
        {
            string dbConf = "SERVER=" + server + ";UID=" + uid + ";PASSWORD=" + pass + ";";
            connection = new MySqlConnection(dbConf);
            command = connection.CreateCommand();
        }

        public void DbInit()
        {
            connection.Open();
            command.CommandText = "CREATE DATABASE IF NOT EXISTS `dental`;";
            command.ExecuteNonQuery();

            connection.ChangeDatabase("dental");

            if (CheckIsTableExist("patients") == 0)
            {
                Logger.Write(Level.ERROR, "Table 'patients' missing! Will be created...");
                command.CommandText = "CREATE TABLE patients (                    " +
                                      "             name  VARCHAR(96),            " +
                                      "             egn   VARCHAR(10) NOT NULL,   " +
                                      "             gsm   VARCHAR(14),            " +
                                      "             email VARCHAR(64),            " +
                                      "PRIMARY KEY(egn));                         ";

                command.ExecuteNonQuery();
            }

            if(CheckIsTableExist("status") == 0)
            {
                Logger.Write(Level.ERROR, "Table 'status' missing! Will be created...");
                command.CommandText = "CREATE TABLE status (                                    " +
                                      "             id           INT NOT NULL AUTO_INCREMENT,   " +
                                      "             egn          VARCHAR(10)  NOT NULL,         " +
                                      "             date         VARCHAR(12)  NULL,             " +
                                      "             diagnosis    VARCHAR(256) NULL,             " +
                                      "             manipulation VARCHAR(256) NULL,             " +
                                      "             notes        VARCHAR(512) NULL,             " +
                                      "             price        VARCHAR(10)  NULL,             " +
                                      "             PRIMARY KEY (id));                          ";

                command.ExecuteNonQuery();
            }

            if(CheckIsTableExist("teeth") == 0)
            {
                Logger.Write(Level.ERROR, "Table 'teeth' missing! Will be created...");
                command.CommandText = "CREATE TABLE teeth (                         " +
                                      "             egn    VARCHAR(10) NOT NULL,    " +
                                      "             z18    VARCHAR(5) NULL,         " +
                                      "             z17    VARCHAR(5) NULL,         " +
                                      "             z16    VARCHAR(5) NULL,         " +
                                      "             z15    VARCHAR(5) NULL,         " +
                                      "             z14    VARCHAR(5) NULL,         " +
                                      "             z13    VARCHAR(5) NULL,         " +
                                      "             z12    VARCHAR(5) NULL,         " +
                                      "             z11    VARCHAR(5) NULL,         " +
                                      "             z21    VARCHAR(5) NULL,         " +
                                      "             z22    VARCHAR(5) NULL,         " +
                                      "             z23    VARCHAR(5) NULL,         " +
                                      "             z24    VARCHAR(5) NULL,         " +
                                      "             z25    VARCHAR(5) NULL,         " +
                                      "             z26    VARCHAR(5) NULL,         " +
                                      "             z27    VARCHAR(5) NULL,         " +
                                      "             z28    VARCHAR(5) NULL,         " +
                                      "             z48    VARCHAR(5) NULL,         " +
                                      "             z47    VARCHAR(5) NULL,         " +
                                      "             z46    VARCHAR(5) NULL,         " +
                                      "             z45    VARCHAR(5) NULL,         " +
                                      "             z44    VARCHAR(5) NULL,         " +
                                      "             z43    VARCHAR(5) NULL,         " +
                                      "             z42    VARCHAR(5) NULL,         " +
                                      "             z41    VARCHAR(5) NULL,         " +
                                      "             z31    VARCHAR(5) NULL,         " +
                                      "             z32    VARCHAR(5) NULL,         " +
                                      "             z33    VARCHAR(5) NULL,         " +
                                      "             z34    VARCHAR(5) NULL,         " +
                                      "             z35    VARCHAR(5) NULL,         " +
                                      "             z36    VARCHAR(5) NULL,         " +
                                      "             z37    VARCHAR(5) NULL,         " +
                                      "             z38    VARCHAR(5) NULL,         " +
                                      "PRIMARY KEY (egn));                          ";

                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public DBResult Execute(string query)
        {
            DBResult dBResult = new DBResult();

            connection.Open();
            command.CommandText = query;
            
            try
            {
                dBResult.affecredRows = command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                dBResult.error.hasError = true;
                dBResult.error.errorMsg = ex.Message;
                Logger.Write(Level.ERROR, ex.Message);
            }
         
            connection.Close();
            return dBResult;
        }

        public DBResult Read(string query)
        {
            DBResult dBResult = new DBResult();

            connection.Open();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                DBRows row = new DBRows();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.fields.Add(reader[i].ToString());
                }
                dBResult.rows.Add(row);

                dBResult.affecredRows++;
            }

            connection.Close();
            return dBResult;
        }

        private int CheckIsTableExist(string table)
        {
            command.CommandText = "SELECT COUNT(*)                     " +
                                  "  FROM information_schema.tables    " +
                                  " WHERE table_schema = 'dental'      " +
                                  "   AND table_name = '" + table + "' ";

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int res = reader.GetInt32(0);
            reader.Close();

            return res;
        }


        private MySqlConnection connection;
        private MySqlCommand    command;
    }
}
