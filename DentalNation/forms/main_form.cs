﻿using System;
using System.Windows.Forms;

using DentalNation.source.libs;

namespace DentalNation
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();

            Logger.Init("DentalNation.log");

            String dbConf = "SERVER=localhost;DATABASE=test_db;UID=root;PASSWORD=;";
            Database.Init(dbConf);

            Logger.Write(Level.DEBUG, "try!");
        }

        
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Logger.Write(Level.DEBUG, "Clicked on dashboard");

            form_search.Hide();
            
            form_dashboard.Show();
            form_dashboard.BringToFront();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Logger.Write(Level.DEBUG, "Clicked on search");

            form_dashboard.Hide();

            form_search.Show();
            form_search.BringToFront();
        }
    }
}
