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
    public partial class CreateAcc4 : Form
    {
        private readonly String a;

        public CreateAcc4(String x)
        {
            InitializeComponent();
            guna2ProgressBar1.Value = 75;
            a = x;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void submit_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Update UsersTable set Useradress=@UPH  where Username = '" + a + "'", Con);
                    cmd.Parameters.AddWithValue("@UPH", Acname.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    CreateAccount5 obj5 = new CreateAccount5();
                    obj5.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
    }
}

