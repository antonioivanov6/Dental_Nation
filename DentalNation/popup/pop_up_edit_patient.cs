using System;
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation.popup
{
    public partial class pop_up_edit_patient : Form
    {
        public pop_up_edit_patient(string name,
            string egn,
            string gsm,
            string email)
        {
            InitializeComponent();

            p_edit_patient_textBox_name.Text = name;
            p_edit_patient_textBox_egn.Text = egn;
            p_edit_patient_textBox_gsm.Text = gsm;
            p_edit_patient_textBox_email.Text = email;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UIController.RestoreMainFocus();
        }

        private void p_edit_patient_button_save_Click(object sender, EventArgs e)
        {
            DBResult res = Storage.EditPatient(
                p_edit_patient_textBox_name.Text,
                p_edit_patient_textBox_egn.Text,
                p_edit_patient_textBox_gsm.Text,
                p_edit_patient_textBox_email.Text);

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
    }
}
