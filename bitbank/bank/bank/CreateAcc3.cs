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
    public partial class CreateAcc3 : Form
    {
        private readonly String a;
        String x3;

        public CreateAcc3(String x)
        {
            InitializeComponent();
            guna2ProgressBar1.Value = 50;
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
                    SqlCommand cmd = new SqlCommand("Update UsersTable set Userphone=@UPH where Username = '" + a + "'", Con);
                    cmd.Parameters.AddWithValue("@UPH", Acname.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    x3 = a;
                    CreateAcc4 obj4 = new CreateAcc4(x3);
                    obj4.Show();
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
