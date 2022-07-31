using System;
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();

            Logger.Init("DentalNation.log");

            Storage.Init("localhost", "admin", "4444");

            UIController.Init(form_dashboard, form_search, form_patient_preview);
            UIController.ShowDashboard();
        }


        private void button_dashboard_Click(object sender, EventArgs e)
        {
            UIController.ShowDashboard();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            UIController.ShowSearch();
        }

        private void button_patient_preview_Click(object sender, EventArgs e)
        {
            UIController.ShowPatientPreview();
        }
    }
}
