﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miny_sys
{
    public partial class login : Form
    {
        String strcon;

        String  a, b;




        private SqlConnection sqlconnection;
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblFroget_Click(object sender, EventArgs e)
        {

        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = passwordtext.Text;
            b = usernametext.Text;
            strcon = Properties.Settings.Default.Database;

            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-7KG67PO;Initial Catalog=MunicipalDatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + b + "' AND password='" + a + "'", sqlconnection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               
                this.Hide();
                dashboard form = new dashboard();
                form.Show();

            }
            else
                MessageBox.Show("Invalid username or password");
            passwordtext.Text = "";
            usernametext.Text = "";

        }

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Thread.Sleep(8000);





        }
    }
}
