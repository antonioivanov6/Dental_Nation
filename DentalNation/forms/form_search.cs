using System;
using System.Windows.Forms;

using DentalNation.source;
using DentalNation.source.libs;

namespace DentalNation.forms
{
    public partial class form_search : UserControl
    {
        public form_search()
        {
            InitializeComponent();
            data_table_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void f_search_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void f_search_button_search_Click(object sender, EventArgs e)
        {
            refreshTable(f_search_text_box.Text);
        }

        private void f_search_button_open_Click(object sender, EventArgs e)
        {
            try
            {
                string name = data_table_patients.SelectedCells[0].Value.ToString();
                string egn = data_table_patients.SelectedCells[1].Value.ToString();
                string gsm = data_table_patients.SelectedCells[2].Value.ToString();
                string email = data_table_patients.SelectedCells[3].Value.ToString();

                UIController.ShowPatientPreview(name, egn, gsm, email);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f_search_button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = data_table_patients.SelectedCells[0].Value.ToString();
                string egn = data_table_patients.SelectedCells[1].Value.ToString();
                string gsm = data_table_patients.SelectedCells[2].Value.ToString();
                string email = data_table_patients.SelectedCells[3].Value.ToString();

                UIController.ShowPopUpEditPatient(name, egn, gsm, email);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f_search_button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string egn = data_table_patients.SelectedCells[1].Value.ToString();
                DBResult res = Storage.DeletePatient(egn);
                refreshTable(f_search_text_box.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f_search_button_create_Click(object sender, EventArgs e)
        {
            
            UIController.ShowPopUpCreatePatient();
        }

        public void refreshTable(string search)
        {
            //Clear Old Content
            data_table_patients.Rows.Clear();


            DBResult res = Storage.FindPatient(search);

            foreach (DBRows row in res.rows)
            {
                data_table_patients.Rows.Add(row.fields[0],
                    row.fields[1], row.fields[2], row.fields[3]);
            }

            data_table_patients.ClearSelection();
        }

        private void data_table_patients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //test
            try
            {
                string name = data_table_patients.SelectedCells[0].Value.ToString();
                string egn = data_table_patients.SelectedCells[1].Value.ToString();
                string gsm = data_table_patients.SelectedCells[2].Value.ToString();
                string email = data_table_patients.SelectedCells[3].Value.ToString();

                UIController.ShowPatientPreview(name, egn, gsm, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
