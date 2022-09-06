
using DentalNation.forms;
using DentalNation.popup;
using System.Windows.Forms;

namespace DentalNation.source
{
    internal class UIController
    {
        static public void Init(
            form_main form_Main,
            form_search form_Search,
            form_patient_preview form_Patient_Preview)
        {
            //Forms
            _form_Main = form_Main;
            _form_Search = form_Search;
            _form_Patient_Preview = form_Patient_Preview;
        }

        static public void RestoreMainFocus()
        {
            _form_Main.Enabled = true;
        }

        static public void ShowSearch()
        {
            //Close others
            _form_Patient_Preview.Hide();
            //Show
            _form_Search.Show();
            _form_Search.BringToFront();

            _form_Search.refreshTable("");
        }

        static public void ShowPatientPreview(string name, string egn, string gsm, string email)
        {
            //Close others
            _form_Search.Hide();
            //Show
            _form_Patient_Preview.Show();
            _form_Patient_Preview.loadPatinetInfo(name, egn, gsm, email);
            _form_Patient_Preview.BringToFront();
        }

        static public void ShowPatientPreviewNoData()
        {
            //Close others
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

        static public void ShowPopUpCreateStatus(string egn)
        {
            pop_up_create_status popUp = new pop_up_create_status(egn);
            _form_Main.Enabled = false;
            popUp.Show();
        }

        static public void ShowPopUpEditStatus(string egn, string id, string date, 
            string price, string diagnosis, string manipulation)
        {
            pop_up_edit_status popUp = new pop_up_edit_status(egn, id, date, price, diagnosis, manipulation);
            _form_Main.Enabled = false;
            popUp.Show();
        }

        static public void RefreshStatusAndNotes()
        {
            _form_Patient_Preview.showStatusAndNotes();
        }

        //Forms
        static private form_main _form_Main;
        static private form_search _form_Search;
        static private form_patient_preview _form_Patient_Preview;
    }
}
