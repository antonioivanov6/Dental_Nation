
using DentalNation.forms;
using DentalNation.popup;
using System.Windows.Forms;

namespace DentalNation.source
{
    internal class UIController
    {
        static public void Init(
            form_main form_Main,
            form_dashboard form_Dashboard,
            form_search form_Search,
            form_patient_preview form_Patient_Preview)
        {
            //Forms
            _form_Main = form_Main;
            _form_Dashboard = form_Dashboard;
            _form_Search = form_Search;
            _form_Patient_Preview = form_Patient_Preview;
        }

        static public void RestoreMainFocus()
        {
            _form_Main.Enabled = true;
        }

        static public void ShowDashboard()
        {
            //Close others
            _form_Search.Hide();
            _form_Patient_Preview.Hide();
            //Show
            _form_Dashboard.Show();
            _form_Dashboard.BringToFront();
        }

        static public void ShowSearch()
        {
            //Close others
            _form_Dashboard.Hide();
            _form_Patient_Preview.Hide();
            //Show
            _form_Search.Show();
            _form_Search.BringToFront();
        }

        static public void ShowPatientPreview()
        {
            //Close others
            _form_Dashboard.Hide();
            _form_Search.Hide();
            //Show
            _form_Patient_Preview.Show();
            _form_Patient_Preview.BringToFront();
        }

        static public void ShowPopUpCreatePatient()
        {
            pop_up_create_patient popUp = new pop_up_create_patient();
            _form_Main.Enabled = false;
            popUp.Show();
            //popUp.StartPosition = FormStartPosition.CenterParent;
        }

        static public void ShowPopUpEditPatient(string name,
            string egn,
            string gsm,
            string email)
        {
            pop_up_edit_patient popUp = new pop_up_edit_patient(name, egn, gsm, email);
            _form_Main.Enabled = false;
            popUp.Show();
        }

        //Forms
        static private form_main _form_Main;
        static private form_dashboard _form_Dashboard;
        static private form_search _form_Search;
        static private form_patient_preview _form_Patient_Preview;
    }
}
