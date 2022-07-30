namespace DentalNation
{
    partial class form_main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.form_search = new DentalNation.forms.form_search();
            this.form_dashboard = new DentalNation.forms.form_dashboard();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button_search);
            this.leftPanel.Controls.Add(this.button_dashboard);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(267, 695);
            this.leftPanel.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.Location = new System.Drawing.Point(59, 284);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(158, 35);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.RosyBrown;
            this.button_dashboard.Location = new System.Drawing.Point(59, 214);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(158, 35);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.UseVisualStyleBackColor = false;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // form_search
            // 
            this.form_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.form_search.Location = new System.Drawing.Point(274, 12);
            this.form_search.Name = "form_search";
            this.form_search.Size = new System.Drawing.Size(800, 671);
            this.form_search.TabIndex = 0;
            // 
            // form_dashboard
            // 
            this.form_dashboard.BackColor = System.Drawing.Color.RosyBrown;
            this.form_dashboard.Location = new System.Drawing.Point(274, 12);
            this.form_dashboard.Name = "form_dashboard";
            this.form_dashboard.Size = new System.Drawing.Size(800, 671);
            this.form_dashboard.TabIndex = 1;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1086, 695);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.form_dashboard);
            this.Controls.Add(this.form_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_main";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private forms.form_dashboard form_dashboard;
        private forms.form_search form_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_dashboard;
    }
}

