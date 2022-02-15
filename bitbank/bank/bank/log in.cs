using System;
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
    public partial class Form2 : Form
    {
        String x;
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }


        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(Role.SelectedIndex == -1 || Role.SelectedIndex == 2)
            {
                MessageBox.Show("Plese select your role!");
            }
            else if(Role.SelectedIndex == 0)
            {
                if(name.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTable where Adname='"+name.Text+"' and Adpass='"+pass.Text+"'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows[0][0].ToString() == "1")
                    {
                        AdminMenu obj = new AdminMenu();
                        obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong user or password");
                        name.Text = "";
                        pass.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (name.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTable where Username='" + name.Text + "' and Userpass='" + pass.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        x = name.Text;
                        SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from AccountTable where Acname='" + name.Text + "'", Con);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        if (dt1.Rows[0][0].ToString() != "1")
                        {
                            //MessageBox.Show(dt1.Rows[0][0].ToString());
                            menu obj = new menu(x);
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            Wit obj = new Wit(x);
                            obj.Show();
                            this.Hide();
                        }
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong user or password");
                        name.Text = "";
                        pass.Text = "";
                    }
                    Con.Close();
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
