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
    public partial class adminpass : Form
    {
        public adminpass()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void change_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTable where Adname='admin' and Adpass='" + guna2TextBox2.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand cmd = new SqlCommand("Update AdminTable set Adpass=@UP where Adname = 'admin'", Con);
                cmd.Parameters.AddWithValue("@UP", guna2TextBox1.Text);
                cmd.ExecuteNonQuery();

                Form2 obj = new Form2();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("parola incorecta");
            }
            Con.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
