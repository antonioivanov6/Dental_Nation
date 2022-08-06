namespace DentalNation.forms
{
    partial class form_search
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.f_search_text_box = new System.Windows.Forms.TextBox();
            this.f_search_button_search = new System.Windows.Forms.Button();
            this.data_table_patients = new System.Windows.Forms.DataGridView();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_egn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_search_button_open = new System.Windows.Forms.Button();
            this.f_search_button_edit = new System.Windows.Forms.Button();
            this.f_search_button_delete = new System.Windows.Forms.Button();
            this.f_search_button_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_table_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // f_search_text_box
            // 
            this.f_search_text_box.Location = new System.Drawing.Point(3, 29);
            this.f_search_text_box.Name = "f_search_text_box";
            this.f_search_text_box.Size = new System.Drawing.Size(257, 22);
            this.f_search_text_box.TabIndex = 0;
            this.f_search_text_box.TextChanged += new System.EventHandler(this.f_search_text_box_TextChanged);
            // 
            // f_search_button_search
            // 
            this.f_search_button_search.Location = new System.Drawing.Point(417, 29);
            this.f_search_button_search.Name = "f_search_button_search";
            this.f_search_button_search.Size = new System.Drawing.Size(173, 23);
            this.f_search_button_search.TabIndex = 1;
            this.f_search_button_search.Text = "Search";
            this.f_search_button_search.UseVisualStyleBackColor = true;
            this.f_search_button_search.Click += new System.EventHandler(this.f_search_button_search_Click);
            // 
            // data_table_patients
            // 
            this.data_table_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table_patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_name,
            this.p_egn,
            this.p_gsm,
            this.p_email});
            this.data_table_patients.Location = new System.Drawing.Point(3, 69);
            this.data_table_patients.Name = "data_table_patients";
            this.data_table_patients.RowHeadersWidth = 51;
            this.data_table_patients.Size = new System.Drawing.Size(587, 439);
            this.data_table_patients.TabIndex = 2;
            this.data_table_patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_table_patients_CellContentClick);
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_name.HeaderText = "Name";
            this.p_name.MinimumWidth = 6;
            this.p_name.Name = "p_name";
            this.p_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // p_egn
            // 
            this.p_egn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_egn.HeaderText = "EGN";
            this.p_egn.MinimumWidth = 6;
            this.p_egn.Name = "p_egn";
            // 
            // p_gsm
            // 
            this.p_gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_gsm.HeaderText = "GSM";
            this.p_gsm.MinimumWidth = 6;
            this.p_gsm.Name = "p_gsm";
            // 
            // p_email
            // 
            this.p_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_email.HeaderText = "Email";
            this.p_email.MinimumWidth = 6;
            this.p_email.Name = "p_email";
            // 
            // f_search_button_open
            // 
            this.f_search_button_open.Location = new System.Drawing.Point(3, 514);
            this.f_search_button_open.Name = "f_search_button_open";
            this.f_search_button_open.Size = new System.Drawing.Size(75, 23);
            this.f_search_button_open.TabIndex = 3;
            this.f_search_button_open.Text = "Open";
            this.f_search_button_open.UseVisualStyleBackColor = true;
            this.f_search_button_open.Click += new System.EventHandler(this.f_search_button_open_Click);
            // 
            // f_search_button_edit
            // 
            this.f_search_button_edit.Location = new System.Drawing.Point(333, 514);
            this.f_search_button_edit.Name = "f_search_button_edit";
            this.f_search_button_edit.Size = new System.Drawing.Size(75, 23);
            this.f_search_button_edit.TabIndex = 4;
            this.f_search_button_edit.Text = "Edit";
            this.f_search_button_edit.UseVisualStyleBackColor = true;
            this.f_search_button_edit.Click += new System.EventHandler(this.f_search_button_edit_Click);
            // 
            // f_search_button_delete
            // 
            this.f_search_button_delete.Location = new System.Drawing.Point(515, 514);
            this.f_search_button_delete.Name = "f_search_button_delete";
            this.f_search_button_delete.Size = new System.Drawing.Size(75, 23);
            this.f_search_button_delete.TabIndex = 5;
            this.f_search_button_delete.Text = "Delete";
            this.f_search_button_delete.UseVisualStyleBackColor = true;
            this.f_search_button_delete.Click += new System.EventHandler(this.f_search_button_delete_Click);
            // 
            // f_search_button_create
            // 
            this.f_search_button_create.Location = new System.Drawing.Point(151, 514);
            this.f_search_button_create.Name = "f_search_button_create";
            this.f_search_button_create.Size = new System.Drawing.Size(75, 23);
            this.f_search_button_create.TabIndex = 6;
            this.f_search_button_create.Text = "Create";
            this.f_search_button_create.UseVisualStyleBackColor = true;
            this.f_search_button_create.Click += new System.EventHandler(this.f_search_button_create_Click);
            // 
            // button_search
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.f_search_button_create);
            this.Controls.Add(this.f_search_button_delete);
            this.Controls.Add(this.f_search_button_edit);
            this.Controls.Add(this.f_search_button_open);
            this.Controls.Add(this.data_table_patients);
            this.Controls.Add(this.f_search_button_search);
            this.Controls.Add(this.f_search_text_box);
            this.Name = "button_search";
            this.Size = new System.Drawing.Size(822, 604);
            ((System.ComponentModel.ISupportInitialize)(this.data_table_patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f_search_text_box;
        private System.Windows.Forms.Button f_search_button_search;
        private System.Windows.Forms.DataGridView data_table_patients;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_egn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_email;
        private System.Windows.Forms.Button f_search_button_open;
        private System.Windows.Forms.Button f_search_button_edit;
        private System.Windows.Forms.Button f_search_button_delete;
        private System.Windows.Forms.Button f_search_button_create;
    }
}
