using System;
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation.forms
{
    public partial class button_search : UserControl
    {
        public button_search()
        {
            InitializeComponent();
            data_table_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void f_search_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void f_search_button_search_Click(object sender, EventArgs e)
        {
            //Clear Old Content
            data_table_patients.Rows.Clear();


            DBResult res = Storage.FindPatient(f_search_text_box.Text);

            foreach (DBRows row in res.rows)
            {
                data_table_patients.Rows.Add(row.fields[0],
                    row.fields[1], row.fields[2], row.fields[3]);
            }
        }

        private void data_table_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void f_search_button_open_Click(object sender, EventArgs e)
        {
            Logger.Write(Level.DEBUG, "SelectetRow: " +
                data_table_patients.SelectedCells[0].Value);
        }

        private void f_search_button_edit_Click(object sender, EventArgs e)
        {

        }

        private void f_search_button_delete_Click(object sender, EventArgs e)
        {

        }

        private void f_search_button_create_Click(object sender, EventArgs e)
        {

        }
    }
}
