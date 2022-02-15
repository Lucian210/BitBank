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
    public partial class send : Form
    {
        private readonly String a;
        String suma;
        String sumarec;
        String Recieve;
        int ver;
        int ver2;
        int newsum;
        int newsumrec;
        int getsum;
        bool ok;
        bool exist;

        public send(String x)
        {
            InitializeComponent();
            a = x;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ok = false;
            exist = false;
            Con.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);
            suma = ds.Tables[0].Rows[0]["Acbal"].ToString();
            ver = int.Parse(suma);
            //MessageBox.Show(ver.ToString());
            if (int.TryParse(sum.Text, out int value))
            {
                getsum = int.Parse(sum.Text);
                ok = true;
            }
            else
            {
                //MessageBox.Show("Trebuie introduse cifre!");
            }

            //MessageBox.Show(ok.ToString());
            newsum = ver - getsum;
            //MessageBox.Show(newsum.ToString());

            //get sum of reciever only if reciever exists in database
            Recieve = rec.Text;
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from AccountTable where Acname='" + Recieve + "'", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            if (dt3 != null && dt3.Rows.Count > 0 && Recieve != a)
            {

                
                exist = true;
                String Queryre = "SELECT * from AccountTable Where Acname='" + Recieve + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(Queryre, Con);
                SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
                var ds2 = new DataSet();
                sda2.Fill(ds2);
                sumarec = ds2.Tables[0].Rows[0]["Acbal"].ToString();
                ver2 = int.Parse(sumarec);

                //MessageBox.Show(sumarec);
                //MessageBox.Show(getsum.ToString());
            }
            else
            {

            }
            Con.Close();

            newsumrec = ver2 + getsum;
            


            if (newsum >= 0 && ok == true && getsum > 0 && exist == true)
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTable where Username='" + a + "' and Userpass='" + pass.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1") //daca userul care trimite scrie parola corect
                {
                    SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP where Acname = '" + a + "'", Con);
                    cmd.Parameters.AddWithValue("@UP", newsum);
                    cmd.ExecuteNonQuery(); 

                    SqlCommand cmd2 = new SqlCommand("Update AccountTable set Acbal=@UP where Acname = '" + Recieve + "'", Con);
                    cmd2.Parameters.AddWithValue("@UP", newsumrec);
                    cmd2.ExecuteNonQuery();


                    SqlCommand cmd3 = new SqlCommand("Insert into SendTable(Fr,T,Quantity) Values (@FR,@T,@QU)", Con);
                    cmd3.Parameters.AddWithValue("@FR", a);
                    cmd3.Parameters.AddWithValue("@T", Recieve);
                    cmd3.Parameters.AddWithValue("@QU", getsum);
                    cmd3.ExecuteNonQuery();
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
                if (exist == false)
                {
                    MessageBox.Show("User inexistent");
                }
                else if (ok == true)
                {
                    MessageBox.Show("Suma introdusa trebuie sa fie pozitiva!");
                }
                else
                {
                    MessageBox.Show("Trebuie introduse cifre!");
                }
            }
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
