﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bank
{
    public partial class CreateAcc2 : Form
    {
        String x2;
        private readonly String a;

        public CreateAcc2(String x)
        {
            InitializeComponent();
            guna2ProgressBar1.Value = 25;
            a = x;
        }
      

        private void Acname_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");


        //submit
        private void submit_Click_1(object sender, EventArgs e)
        {
            if (Acname.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update UsersTable set Userpass=@UP where Username = '" + a + "'", Con);
                    cmd.Parameters.AddWithValue("@UP", Acname.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    x2 = a;
                    CreateAcc3 obj3 = new CreateAcc3(x2);
                    obj3.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CreateAcc2_Load(object sender, EventArgs e)
        {

        }
    }
}
