using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DentalNation.forms
{
    public partial class form_patient_preview : UserControl
    {
        Dictionary<int, string> keyValuePairs;

        public form_patient_preview()
        {
            InitializeComponent();

            keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(0,  "");
            keyValuePairs.Add(1,  "C");
            keyValuePairs.Add(2,  "P");
            keyValuePairs.Add(3,  "G");
            keyValuePairs.Add(4,  "R");
            keyValuePairs.Add(5,  "O");
            keyValuePairs.Add(6,  "E");
            keyValuePairs.Add(7,  "K");
            keyValuePairs.Add(8,  "X");
            keyValuePairs.Add(9,  "S");
            keyValuePairs.Add(10, "F");
            keyValuePairs.Add(11, "I");
            keyValuePairs.Add(12, "D");
            keyValuePairs.Add(13, "1");
            keyValuePairs.Add(14, "2");
            keyValuePairs.Add(15, "3");

            string[] items = keyValuePairs.Values.ToArray();

            comboBox_z18.Items.AddRange(items);
            comboBox_z17.Items.AddRange(items);
            comboBox_z16.Items.AddRange(items);
            comboBox_z15.Items.AddRange(items);
            comboBox_z14.Items.AddRange(items);
            comboBox_z13.Items.AddRange(items);
            comboBox_z12.Items.AddRange(items);
            comboBox_z11.Items.AddRange(items);

            comboBox_z21.Items.AddRange(items);
            comboBox_z23.Items.AddRange(items);
            comboBox_z23.Items.AddRange(items);
            comboBox_z24.Items.AddRange(items);
            comboBox_z25.Items.AddRange(items);
            comboBox_z26.Items.AddRange(items);
            comboBox_z27.Items.AddRange(items);
            comboBox_z28.Items.AddRange(items);

            comboBox_z48.Items.AddRange(items);
            comboBox_z47.Items.AddRange(items);
            comboBox_z46.Items.AddRange(items);
            comboBox_z45.Items.AddRange(items);
            comboBox_z44.Items.AddRange(items);
            comboBox_z43.Items.AddRange(items);
            comboBox_z42.Items.AddRange(items);
            comboBox_z41.Items.AddRange(items);

            comboBox_z31.Items.AddRange(items);
            comboBox_z32.Items.AddRange(items);
            comboBox_z33.Items.AddRange(items);
            comboBox_z34.Items.AddRange(items);
            comboBox_z35.Items.AddRange(items);
            comboBox_z36.Items.AddRange(items);
            comboBox_z37.Items.AddRange(items);
            comboBox_z38.Items.AddRange(items);
        }

        public void loadPatinetInfo(string name,
            string egn,
            string gsm,
            string email)
        {

            f_preview_textBox_name.Text = name;
            f_preview_textBox_name.Enabled = false;

            f_preview_textBox_egn.Text = egn;
            f_preview_textBox_egn.Enabled = false;

            f_preview_textBox_gsm.Text = gsm;
            f_preview_textBox_gsm.Enabled = false;

            f_preview_textBox_email.Text = email;
            f_preview_textBox_email.Enabled = false;
        }

        private void loadComboBox()
        {

        }

        private void comboBox_z18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z26_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z48_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z47_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z46_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z45_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z44_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z43_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z42_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z41_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z32_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z33_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z34_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z35_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z37_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_z38_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
