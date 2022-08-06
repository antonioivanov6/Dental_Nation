using System;
using System.Collections.Generic;
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

            string[] items = new string[keyValuePairs.Count];
            keyValuePairs.Values.CopyTo(items, 0);

            comboBox_z18.Items.AddRange(items);
            comboBox_z17.Items.AddRange(items);
            comboBox_z16.Items.AddRange(items);
            comboBox_z15.Items.AddRange(items);
            comboBox_z14.Items.AddRange(items);
            comboBox_z13.Items.AddRange(items);
            comboBox_z12.Items.AddRange(items);
            comboBox_z11.Items.AddRange(items);
        }

        private void form_patient_preview_Load(object sender, EventArgs e)
        {

        }
    }
}
