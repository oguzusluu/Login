﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_Pass.Text;
            con = new SqlConnection("Data Source=DESKTOP-FL2FF7V;Initial Catalog=Game;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select*From GamePersonel where Username='" + txt_user.Text + "'and Password='" + txt_Pass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(txt_user.Text + "Welcome");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
