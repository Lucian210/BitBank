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
    public partial class CreateAcc : Form
    {
        String ad = "admin";
        String x;
        public CreateAcc()
        {
            InitializeComponent();
            guna2ProgressBar1.Value =0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");


        //submit
        private void submit_Click(object sender, EventArgs e)
        {

            if (Acname.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
             Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTable where Username='" + Acname.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0" && Acname.Text.ToUpper() != ad.ToUpper())
                {
                    SqlCommand cmd = new SqlCommand("Insert into UsersTable(Username) Values (@UP)", Con);
                    cmd.Parameters.AddWithValue("@UP", Acname.Text);
                    cmd.ExecuteNonQuery();
                     Con.Close();
                     x = Acname.Text;
                     CreateAcc2 obj2 = new CreateAcc2(x);
                    obj2.Show();
                    this.Hide();
                }
                else
                {
                     MessageBox.Show("Username already exists. Please use another one!");
                }
             Con.Close();

            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Acname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
