
using DentalNation.forms;

namespace DentalNation.source
{
    internal class UIController
    {
        static public void Init(
            form_dashboard form_Dashboard,
            button_search form_Search,
            form_patient_preview form_Patient_Preview)
        {
            _form_Dashboard       = form_Dashboard;
            _form_Search          = form_Search;
            _form_Patient_Preview = form_Patient_Preview;
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

        static private form_dashboard       _form_Dashboard;
        static private button_search          _form_Search;
        static private form_patient_preview _form_Patient_Preview;
    }
}
