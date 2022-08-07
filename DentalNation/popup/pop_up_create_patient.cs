
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
            DBResult res1 = Storage.InsertNewPatient(
                p_create_patient_textBox_name.Text,
                p_create_patient_textBox_egn.Text,
                p_create_patient_textBox_gsm.Text,
                p_create_patient_textBox_email.Text);

            DBResult res2 = Storage.InsertNewTeeth(p_create_patient_textBox_egn.Text);

            if (!res1.error.hasError && !res2.error.hasError)
            {
                UIController.RestoreMainFocus();
                Close();
            }
            else
            {
                Logger.Write(Level.ERROR, "Err1: " + res1.error.errorMsg + " Err2: " + res2.error.errorMsg);
                MessageBox.Show("Err1: " + res1.error.errorMsg + " Err2: " + res2.error.errorMsg);
            }
        }

        private void p_create_patient_button_save_and_work_Click(object sender, System.EventArgs e)
        {
            string name = p_create_patient_textBox_name.Text;
            string egn = p_create_patient_textBox_egn.Text;
            string gsm = p_create_patient_textBox_gsm.Text;
            string email = p_create_patient_textBox_email.Text;

            DBResult res1 = Storage.InsertNewPatient(name, egn, gsm, email);

            DBResult res2 = Storage.InsertNewTeeth(p_create_patient_textBox_egn.Text);

            if (!res1.error.hasError && !res2.error.hasError)
            {
                UIController.RestoreMainFocus();
                Close();
            }
            else
            {
                Logger.Write(Level.ERROR, "Err1: " + res1.error.errorMsg + " Err2: " + res2.error.errorMsg);
                MessageBox.Show("Err1: " + res1.error.errorMsg + " Err2: " + res2.error.errorMsg);
            }
        }
    }
}
