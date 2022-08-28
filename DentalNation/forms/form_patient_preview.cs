using DentalNation.source;
using DentalNation.source.libs;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DentalNation.forms
{
    public partial class form_patient_preview : UserControl
    {
        Dictionary<string, string> keyValuePairs;

        private string egn;

        public form_patient_preview()
        {
            InitializeComponent();
            //data_table_status.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("0",  "");
            keyValuePairs.Add("1",  "C");
            keyValuePairs.Add("2",  "P");
            keyValuePairs.Add("3",  "G");
            keyValuePairs.Add("4",  "R");
            keyValuePairs.Add("5",  "O");
            keyValuePairs.Add("6",  "E");
            keyValuePairs.Add("7",  "K");
            keyValuePairs.Add("8",  "X");
            keyValuePairs.Add("9",  "S");
            keyValuePairs.Add("10", "F");
            keyValuePairs.Add("11", "I");
            keyValuePairs.Add("12", "D");
            keyValuePairs.Add("13", "1");
            keyValuePairs.Add("14", "2");
            keyValuePairs.Add("15", "3");

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

        public void showStatusAndNotes()
        {
            //Clear Old Content
            data_table_status.Rows.Clear();

            DBResult res = Storage.LoadStatusAndNotes(egn);

            foreach (DBRows row in res.rows)
            {
                data_table_status.Rows.Add(
                    row.fields[0], //date
                    row.fields[1], //diagnosis
                    row.fields[2], //manipulation
                    row.fields[3], //price
                    row.fields[4], //notes
                    row.fields[5], //materials
                    row.fields[6]  //id
                    );
            }

            data_table_status.ClearSelection();
        }

        private void data_table_status_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notes_text_box.Text = data_table_status.CurrentRow.Cells[4].Value.ToString();
            materials_text_box.Text = data_table_status.CurrentRow.Cells[5].Value.ToString();
        }

        public void loadPatinetInfo(string name,
            string egn,
            string gsm,
            string email)
        {
            this.egn = egn;

            f_preview_textBox_name.Text = name;
            f_preview_textBox_name.Enabled = false;

            f_preview_textBox_egn.Text = egn;
            f_preview_textBox_egn.Enabled = false;

            f_preview_textBox_gsm.Text = gsm;
            f_preview_textBox_gsm.Enabled = false;

            f_preview_textBox_email.Text = email;
            f_preview_textBox_email.Enabled = false;

            loadComboBox();
            showStatusAndNotes();
        }

        private void materials_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void notes_text_box_TextChanged(object sender, EventArgs e)
        {
            notes_button_save.Enabled = true;
        }

        private void loadComboBox()
        {
            DBResult res = Storage.LoadTeethData(egn);
            List<DBRows> row = res.rows;
            List<string> fields = row.First().fields;

            comboBox_z18.Text = fields[1];
            comboBox_z17.Text = fields[2];
            comboBox_z16.Text = fields[3];
            comboBox_z15.Text = fields[4];
            comboBox_z14.Text = fields[5];
            comboBox_z13.Text = fields[6];
            comboBox_z12.Text = fields[7];
            comboBox_z11.Text = fields[8];

            comboBox_z21.Text = fields[9];
            comboBox_z22.Text = fields[10];
            comboBox_z23.Text = fields[11];
            comboBox_z24.Text = fields[12];
            comboBox_z25.Text = fields[13];
            comboBox_z26.Text = fields[14];
            comboBox_z27.Text = fields[15];
            comboBox_z28.Text = fields[16];

            comboBox_z48.Text = fields[17];
            comboBox_z47.Text = fields[18];
            comboBox_z46.Text = fields[19];
            comboBox_z45.Text = fields[20];
            comboBox_z44.Text = fields[21];
            comboBox_z43.Text = fields[22];
            comboBox_z42.Text = fields[23];
            comboBox_z41.Text = fields[24];

            comboBox_z31.Text = fields[25];
            comboBox_z32.Text = fields[26];
            comboBox_z33.Text = fields[27];
            comboBox_z34.Text = fields[28];
            comboBox_z35.Text = fields[29];
            comboBox_z36.Text = fields[30];
            comboBox_z37.Text = fields[31];
            comboBox_z38.Text = fields[32];
        }

        private void comboBox_z18_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z18", keyValuePairs[comboBox_z18.SelectedIndex.ToString()]);
        }

        private void comboBox_z17_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z17", keyValuePairs[comboBox_z17.SelectedIndex.ToString()]);
        }

        private void comboBox_z16_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z16", keyValuePairs[comboBox_z16.SelectedIndex.ToString()]);
        }

        private void comboBox_z15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z15", keyValuePairs[comboBox_z15.SelectedIndex.ToString()]);
        }

        private void comboBox_z14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z14", keyValuePairs[comboBox_z14.SelectedIndex.ToString()]);
        }

        private void comboBox_z13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z13", keyValuePairs[comboBox_z13.SelectedIndex.ToString()]);
        }

        private void comboBox_z12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z12", keyValuePairs[comboBox_z12.SelectedIndex.ToString()]);
        }

        private void comboBox_z11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z11", keyValuePairs[comboBox_z11.SelectedIndex.ToString()]);
        }

        private void comboBox_z21_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z21", keyValuePairs[comboBox_z21.SelectedIndex.ToString()]);
        }

        private void comboBox_z22_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z22", keyValuePairs[comboBox_z22.SelectedIndex.ToString()]);
        }

        private void comboBox_z23_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z23", keyValuePairs[comboBox_z23.SelectedIndex.ToString()]);
        }

        private void comboBox_z24_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z24", keyValuePairs[comboBox_z24.SelectedIndex.ToString()]);
        }

        private void comboBox_z25_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z25", keyValuePairs[comboBox_z25.SelectedIndex.ToString()]);
        }

        private void comboBox_z26_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z26", keyValuePairs[comboBox_z26.SelectedIndex.ToString()]);
        }

        private void comboBox_z27_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z27", keyValuePairs[comboBox_z27.SelectedIndex.ToString()]);
        }

        private void comboBox_z28_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z28", keyValuePairs[comboBox_z28.SelectedIndex.ToString()]);
        }

        private void comboBox_z48_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z48", keyValuePairs[comboBox_z48.SelectedIndex.ToString()]);
        }

        private void comboBox_z47_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z47", keyValuePairs[comboBox_z47.SelectedIndex.ToString()]);
        }

        private void comboBox_z46_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z46", keyValuePairs[comboBox_z46.SelectedIndex.ToString()]);
        }

        private void comboBox_z45_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z45", keyValuePairs[comboBox_z45.SelectedIndex.ToString()]);
        }

        private void comboBox_z44_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z44", keyValuePairs[comboBox_z44.SelectedIndex.ToString()]);
        }

        private void comboBox_z43_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z43", keyValuePairs[comboBox_z43.SelectedIndex.ToString()]);
        }

        private void comboBox_z42_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z42", keyValuePairs[comboBox_z42.SelectedIndex.ToString()]);
        }

        private void comboBox_z41_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z41", keyValuePairs[comboBox_z41.SelectedIndex.ToString()]);
        }

        private void comboBox_z31_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z31", keyValuePairs[comboBox_z31.SelectedIndex.ToString()]);
        }

        private void comboBox_z32_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z32", keyValuePairs[comboBox_z32.SelectedIndex.ToString()]);
        }

        private void comboBox_z33_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z33", keyValuePairs[comboBox_z33.SelectedIndex.ToString()]);
        }

        private void comboBox_z34_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z34", keyValuePairs[comboBox_z34.SelectedIndex.ToString()]);
        }

        private void comboBox_z35_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z35", keyValuePairs[comboBox_z35.SelectedIndex.ToString()]);
        }

        private void comboBox_z36_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z36", keyValuePairs[comboBox_z36.SelectedIndex.ToString()]);
        }

        private void comboBox_z37_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z37", keyValuePairs[comboBox_z37.SelectedIndex.ToString()]);
        }

        private void comboBox_z38_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.UpdateTeeth(egn, "z38", keyValuePairs[comboBox_z38.SelectedIndex.ToString()]);
        }

        private void new_row_button_Click(object sender, EventArgs e)
        {
            UIController.ShowPopUpCreateStatus(egn);
        }

        private void edit_row_button_Click(object sender, EventArgs e)
        {
            
            string date         = data_table_status.CurrentRow.Cells[0].Value.ToString();
            string diagnosis    = data_table_status.CurrentRow.Cells[1].Value.ToString();
            string manipulation = data_table_status.CurrentRow.Cells[2].Value.ToString();
            string price        = data_table_status.CurrentRow.Cells[3].Value.ToString();
            string id           = data_table_status.CurrentRow.Cells[6].Value.ToString();

            UIController.ShowPopUpEditStatus(egn, id, date, price, diagnosis, manipulation);
        }

        private void delete_row_button_Click(object sender, EventArgs e)
        {
            Storage.DeleteStatus(data_table_status.CurrentRow.Cells[6].Value.ToString());
            showStatusAndNotes();
        }

        private void notes_button_save_Click(object sender, EventArgs e)
        {
            string id = data_table_status.CurrentRow.Cells[6].Value.ToString();
            //string newNote = data_table_status.CurrentRow.Cells[4].Value.ToString();

            string newNote = notes_text_box.Text.ToString();

            Logger.Write(Level.DEBUG, "ID: " + id);
            Logger.Write(Level.DEBUG, "New Note: " + newNote);

            Storage.UpdateStatusNote(id, newNote);

            notes_button_save.Enabled = false;

            showStatusAndNotes();
        }
    }
}
