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
    public partial class Edit : Form
    {
        private readonly String a;
        public Edit(String x)
        {
            InitializeComponent();
            a = x;
            DisplayAcc();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayAcc()
        {
            Con.Open();
            String Query = "select * from AccountTable where Acname = '" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            name.Text = a;
            Acphone.Text = ds.Tables[0].Rows[0]["Acphone"].ToString();
            Acadress.Text = ds.Tables[0].Rows[0]["Acadress"].ToString();
            Acincome.Text = ds.Tables[0].Rows[0]["Acinc"].ToString();
            Acocup.Text = ds.Tables[0].Rows[0]["Acocup"].ToString();
            Con.Close();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Acphone.Text == "" || Acadress.Text == "" || Acocup.Text == "" || Acincome.Text == "")
            {
                MessageBox.Show("No modifications done");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTable set Acphone=@AP,Acadress=@AA,Acocup=@AO,Acinc=@AI where Acname = '" + a + "'", Con);
                cmd.Parameters.AddWithValue("@AP", Acphone.Text);
                cmd.Parameters.AddWithValue("@AA", Acadress.Text);
                cmd.Parameters.AddWithValue("@AO", Acocup.Text);
                cmd.Parameters.AddWithValue("@AI", Acincome.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Update UsersTable set Userphone=@AP,Useradress=@AA where Username = '" + a + "'", Con);
                cmd2.Parameters.AddWithValue("@AP", Acphone.Text);
                cmd2.Parameters.AddWithValue("@AA", Acadress.Text);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Account Updated!");
                this.Hide();
                
                Con.Close();
                DisplayAcc();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
