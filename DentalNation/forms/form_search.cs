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

/*                for (int i = 0; i < data_table_patients.Columns.Count; i++)
                {
                    data_table_patients.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }*/
            }
        }

        private void data_table_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
