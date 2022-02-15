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
    public partial class Addmoney : Form
    {
        private readonly String a;
        String suma;
        int ver;
        int newsum;
        int getsum;
        bool ok;


        public Addmoney(String x)
        {
            InitializeComponent();
            a = x;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Addmoney_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ok = false;
            Con.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);
            suma = ds.Tables[0].Rows[0]["Acbal"].ToString();
            ver = int.Parse(suma);
            //MessageBox.Show(ver.ToString());
            if(int.TryParse(sum.Text, out int value))
            {
                getsum = int.Parse(sum.Text);
                ok = true;
            }
            else
            {
               // MessageBox.Show("Trebuie introduse cifre!");
            }
            
            //MessageBox.Show(getsum.ToString());
            newsum = ver + getsum;
            //MessageBox.Show(newsum.ToString());
            Con.Close();

            if (getsum > 0 && ok == true && getsum > 0)
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTable where Username='" + a + "' and Userpass='" + pass.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP where Acname = '" + a + "'", Con);
                    cmd.Parameters.AddWithValue("@UP", newsum);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("parola incorecta");
                }

                Con.Close();
            }
            else
            {
                if (ok == true)
                {
                    MessageBox.Show("Suma introdusa trebuie sa fie pozitiva!");
                }
                else
                {
                    MessageBox.Show("Trebuie introduse cifre!");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
