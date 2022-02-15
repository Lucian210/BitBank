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

    public partial class menu : Form
    {
        String a;
        public menu(String x)
        {
            InitializeComponent();
            autocomplete(x);
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void autocomplete(String a)
        {
      
            Con.Open();
            String Query = "SELECT * from UsersTable Where Username='" + a + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);
            Acname.Text = ds.Tables[0].Rows[0]["Username"].ToString();
            Acphone.Text = ds.Tables[0].Rows[0]["Userphone"].ToString();
            Acadress.Text = ds.Tables[0].Rows[0]["Useradress"].ToString();
            Con.Close();           
        }

        private void Reset()
        {
            Acname.Text = "";
            Acphone.Text = "";
            Acadress.Text = "";
            Acgender.SelectedIndex = -1;
            Acocupation.Text = "";
            Acincome.Text = "";
            Aceducation.SelectedIndex = -1;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Acgender.SelectedIndex == -1 || Acocupation.Text == "" || Aceducation.SelectedIndex == -1 || Acincome.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AccountTable(Acname,Acphone,Acadress,Acgen,Acocup,Aceduc,Acinc,Acbal,Acgld,Acslv) Values (@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB,@AGL,@ASV)", Con);
                    cmd.Parameters.AddWithValue("@AN", Acname.Text);
                    cmd.Parameters.AddWithValue("@AP", Acphone.Text);
                    cmd.Parameters.AddWithValue("@AA", Acadress.Text);
                    cmd.Parameters.AddWithValue("@AG", Acgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", Acocupation.Text);
                    cmd.Parameters.AddWithValue("@AE", Aceducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", Acincome.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.Parameters.AddWithValue("@AGL", 0);
                    cmd.Parameters.AddWithValue("@ASV", 0);
                    cmd.ExecuteNonQuery();
                    a = Acname.Text;
                    MessageBox.Show("Account Created!");
                    Con.Close();
                    Reset();

                    Wit obj = new Wit(a);
                    obj.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Acname_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
