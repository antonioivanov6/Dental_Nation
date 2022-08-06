
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation.popup
{
    public partial class pop_up_create_patient : Form
    {
        public pop_up_create_patient()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UIController.RestoreMainFocus();
        }

        private void p_create_patient_button_save_Click(object sender, System.EventArgs e)
        {
            DBResult res = Storage.InsertNewPatient(
                p_create_patient_textBox_name.Text,
                p_create_patient_textBox_egn.Text,
                p_create_patient_textBox_gsm.Text,
                p_create_patient_textBox_email.Text);

            if (!res.error.hasError)
            {
                UIController.RestoreMainFocus();
                Close();
            }
            else
            {
                Logger.Write(Level.ERROR, res.error.errorMsg);
                MessageBox.Show(res.error.errorMsg);
            }
        }

        private void p_create_patient_button_save_and_work_Click(object sender, System.EventArgs e)
        {
            string name = p_create_patient_textBox_name.Text;
            string egn = p_create_patient_textBox_egn.Text;
            string gsm = p_create_patient_textBox_gsm.Text;
            string email = p_create_patient_textBox_email.Text;

            DBResult res = Storage.InsertNewPatient(name, egn, gsm, email);

            if (!res.error.hasError)
            {
                UIController.RestoreMainFocus();
                UIController.ShowPatientPreview(name, egn, gsm, email);
                Close();
            }
            else
            {
                Logger.Write(Level.ERROR, res.error.errorMsg);
                MessageBox.Show(res.error.errorMsg);
            }
        }
    }
}
