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
    public partial class pop_up_edit_status : Form
    {

        public pop_up_edit_status(string date,
            string price,
            string diagnosis,
            string manipulation)
        {
            InitializeComponent();

            p_edit_status_textBox_date.Text = date;
            p_edit_status_textBox_price.Text = price;
            p_edit_status_textBox_diagnosis.Text = diagnosis;
            p_edit_status_textBox_manipulation.Text = manipulation;

        }

        private void p_edit_status_button_save_Click(object sender, EventArgs e)
        {

        }
    }
}
