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

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UIController.RestoreMainFocus();
        }

        private void p_edit_status_button_save_Click(object sender, EventArgs e)
        {
            Storage.EditStatus(egn,
                id,
                p_edit_status_textBox_date.Text,
                p_edit_status_textBox_diagnosis.Text,
                p_edit_status_textBox_manipulation.Text,
                p_edit_status_textBox_price.Text);
        }
    }
}
