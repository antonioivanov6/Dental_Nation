
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

        static public DBResult InsertNewTeeth(string egn)
        {
            string query = "INSERT INTO teeth(egn) VALUES('" + egn + "')";

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

        static public DBResult EditPatient(string oldEgn, string name, string egn, string gsm, string email)
        {
            string query = "UPDATE patients " +
                           "   SET name = '" + name + "', " +
                           "        egn = '" + egn + "', " +
                           "        gsm = '" + gsm + "', " +
                           "      email = '" + email + "' " +
                           "  WHERE egn = '" + oldEgn + "' ";

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
                return res;
            }

            query = "DELETE FROM status WHERE egn = '" + egn + "'";

            res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
                return res;
            }

            query = "DELETE FROM teeth WHERE egn = '" + egn + "'";

            res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
                return res;
            }

            return res;
        }

        static public DBResult UpdateTeeth(string egn, string teeth, string val)
        {
            string query = "UPDATE teeth SET " + teeth + " = '" + val + "' WHERE egn = '" + egn + "'";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult UpdateTeethEgn(string oldEgn, string newEgn)
        {
            string query = "UPDATE teeth SET egn = '" + newEgn + "' WHERE egn = '" + oldEgn + "' ";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult UpdateStatusEgn(string oldEgn, string newEgn)
        {
            string query = "UPDATE status SET egn = '" + newEgn + "' WHERE egn = '" + oldEgn + "' ";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult LoadTeethData(string egn)
        {
            string query = "SELECT * FROM teeth WHERE egn = '" + egn + "'";


            DBResult res = db.Read(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult LoadStatusAndNotes(string egn)
        {
            string query = "SELECT date, diagnosis, manipulation, price, notes, materials, id " +
                      "FROM status " +
                      "WHERE egn = '" + egn + "' ";

            DBResult res = db.Read(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult CreateNewStatus(string egn, string date, string diagnosis, string manipulation, string price)
        {
            string query = "INSERT INTO status (egn, date, diagnosis, manipulation, price) " +
                            "VALUES ('" + egn + "', '" + date + "', '" + diagnosis + "', '" + manipulation + "', '" + price + "')";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult EditStatus(string egn, string id, string date, string diagnosis, string manipulation, string price)
        {
            string query = "UPDATE status SET " +
                            "date = '" + date + "', " +
                            "diagnosis = '" + diagnosis + "', " +
                            "manipulation = '" + manipulation + "', " +
                            "price = '" + price + "' " +
                            "WHERE egn = '" + egn + "' " +
                            "AND id = " + id + "";

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult DeleteStatus(string id)
        {
            string query = "DELETE FROM status WHERE id = " + id;

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult UpdateStatusNote(string id, string note)
        {
            string query = "UPDATE status SET notes = '" + note + "' WHERE id = " + id;

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static public DBResult UpdateMaterials(string id, string materials)
        {
            string query = "UPDATE status SET materials = '" + materials + "' WHERE id = " + id;

            DBResult res = db.Execute(query);

            if (res.error.hasError)
            {
                Logger.Write(Level.DEBUG, "ErrorMsg: " + res.error.errorMsg);
            }

            return res;
        }

        static private Database db;
    }
}
