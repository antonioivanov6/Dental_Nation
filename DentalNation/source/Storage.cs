
using DentalNation.source.libs;

namespace DentalNation.source
{
    internal class Storage
    {
        static public void Init(string server, string uid, string pass)
        {
            db = new Database(server, uid, pass);
            db.DbInit();
        }

        static public DBResult InsertNewPatient(string name, string egn, string gsm, string email)
        {
            string query = "INSERT INTO patients (name, egn, gsm, email)" +
                           "VALUES ('" + name + "'," +
                           "        '" + egn +  "', " +
                           "        '" + gsm +  "', " +
                           "        '" + email + "'); ";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult FindPatient(string nameOrEgn)
        {
            string query = "SELECT name, egn, gsm, email " +
                           "  FROM patients " +  
                           " WHERE name LIKE '%" + nameOrEgn + "%' " +
                           "    OR egn LIKE '%" + nameOrEgn + "%';";

            DBResult res = db.Read(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult EditPatient(string name, string egn, string gsm, string email)
        {
            string query = "UPDATE patients " +
                           "   SET name = '" + name + "', " +
                           "        egn = '" + egn + "', " +
                           "        gsm = '" + gsm + "', " +
                           "      email = '" + email + "' " +
                           "  WHERE egn = '" + egn + "' ";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult DeletePatient(string egn)
        {
            string query = "DELETE FROM patients WHERE egn = '" + egn + "'";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public void InsertNewStatus()
        {

        }

        static private Database db;
    }
}
