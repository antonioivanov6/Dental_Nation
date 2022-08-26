using DentalNation.source;
using DentalNation.source.libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalNation.popup
{
    public partial class pop_up_create_status : Form
    {
        private string egn;

        public pop_up_create_status(string egn)
        {
            InitializeComponent();
            this.egn = egn;
        }

        private void p_create_status_button_save_Click(object sender, EventArgs e)
        {
            DBResult res = Storage.CreateNewStatus(
                egn,
                p_create_status_textBox_date.Text,
                p_create_status_textBox_diagnosis.Text,
                p_create_status_textBox_manipulation.Text,
                p_create_status_textBox_price.Text);

            if (!res.error.hasError)
            {
                UIController.RefreshStatusAndNotes();
                UIController.RestoreMainFocus();
                Close();
            }
            else
            {
                Logger.Write(Level.ERROR, "Err: " + res.error.errorMsg);
                MessageBox.Show("Err: " + res.error.errorMsg);
            }
        }
    }
}
