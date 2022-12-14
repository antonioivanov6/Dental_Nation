using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation.popup
{
    public partial class pop_up_edit_status : Form
    {

        string egn;
        string id;

        public pop_up_edit_status(string egn,
            string id,
            string date,
            string price,
            string diagnosis,
            string manipulation)
        {
            InitializeComponent();

            this.egn = egn;
            this.id = id;

            p_edit_status_textBox_date.Text = date;
            p_edit_status_textBox_price.Text = price;
            p_edit_status_textBox_diagnosis.Text = diagnosis;
            p_edit_status_textBox_manipulation.Text = manipulation;

            p_edit_status_textBox_date.TabIndex = 0;
            p_edit_status_textBox_price.TabIndex = 1;
            p_edit_status_textBox_diagnosis.TabIndex = 2;
            p_edit_status_textBox_manipulation.TabIndex = 3;
            p_edit_status_button_save.TabIndex = 4;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UIController.RestoreMainFocus();
        }

        private void p_edit_status_button_save_Click(object sender, EventArgs e)
        {
            DBResult res = Storage.EditStatus(egn,
                id,
                p_edit_status_textBox_date.Text,
                p_edit_status_textBox_diagnosis.Text,
                p_edit_status_textBox_manipulation.Text,
                p_edit_status_textBox_price.Text);

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
