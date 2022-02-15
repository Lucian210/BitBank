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
    public partial class Asset : Form
    {      
        //
        private readonly String a;
        String wg, ws;
        int cbal;

        public Asset(String x)
        {

            InitializeComponent();
            a = x;

            Computesum(a);
            fresh();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void fresh()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;//1 second
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ////
            Computesum(a);
            

        }

        public void Computesum(String a)
        {
            int goldval, silverval, currentg, currents, qg, qs;

            Con.Open();
            String Query = "SELECT * from assetTable Where Asname='Gold'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);

            gold.Text = ds.Tables[0].Rows[0]["Asprice"].ToString();
            currentg = int.Parse(gold.Text);


            String Query2 = "SELECT * from assetTable Where Asname='Silver'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
            var ds2 = new DataSet();
            sda2.Fill(ds2);

            silver.Text = ds2.Tables[0].Rows[0]["Asprice"].ToString();
            currents = int.Parse(silver.Text);

            ///

            String Query3 = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(Query3, Con);
            SqlCommandBuilder builder3 = new SqlCommandBuilder(sda3);
            var ds3 = new DataSet();
            sda3.Fill(ds3);
            guna2HtmlLabel10.Text = ds3.Tables[0].Rows[0]["Acgld"].ToString();
            qg = int.Parse(guna2HtmlLabel10.Text);

            guna2HtmlLabel3.Text = ds3.Tables[0].Rows[0]["Acslv"].ToString();
            qs = int.Parse(guna2HtmlLabel3.Text);

            goldval = qg * currentg;
            silverval = qs * currents;

            guna2HtmlLabel9.Text = goldval.ToString();
            guna2HtmlLabel4.Text = silverval.ToString();
            ///



            Con.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            bool first = false;
            int wants, wantprices, sprice;
            int hass, news;

            Con2.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con2);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dsg = new DataSet();
            sda.Fill(dsg);
            cbal = int.Parse(dsg.Tables[0].Rows[0]["Acbal"].ToString());
            hass = int.Parse(dsg.Tables[0].Rows[0]["Acslv"].ToString());
            ws = guna2TextBox2.Text;
            
            if (int.TryParse(guna2TextBox2.Text, out int value))
            {
                wants = int.Parse(ws);
                first = true;
            }
            else
            {
                wants = 0;
            }
            
            
            String Query2 = "SELECT * from assetTable Where Asname='Silver'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con2);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
            var dsg2 = new DataSet();
            sda2.Fill(dsg2);
            sprice = int.Parse(dsg2.Tables[0].Rows[0]["Asprice"].ToString());


            wantprices = wants * sprice;
            news = wants + hass;

            if (wantprices < cbal && wants > 0 && first == true)
            {
                int newsum = cbal - wantprices;
                SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP, Acslv=@DA where Acname = '" + a + "'", Con2);
                cmd.Parameters.AddWithValue("@UP", newsum);
                cmd.Parameters.AddWithValue("@DA", news);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
            Con2.Close();
        }

        private void buygld_Click(object sender, EventArgs e)
        {

            bool first = false;
            int wantg, wantpriceg, gprice;
            int hasg, newg;

            Con2.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con2);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dsg = new DataSet();
            sda.Fill(dsg);
            cbal = int.Parse(dsg.Tables[0].Rows[0]["Acbal"].ToString());
            hasg = int.Parse(dsg.Tables[0].Rows[0]["Acgld"].ToString()); //cat are
            wg = guna2TextBox1.Text;

            if (int.TryParse(guna2TextBox1.Text, out int value))
            {
                wantg = int.Parse(wg);
                first = true;
            }
            else
            {
                wantg = 0;
            }


            String Query2 = "SELECT * from assetTable Where Asname='Gold'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con2);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
            var dsg2 = new DataSet();
            sda2.Fill(dsg2);
            gprice = int.Parse(dsg2.Tables[0].Rows[0]["Asprice"].ToString()); //pretul la care vinde

            wantpriceg = wantg * gprice;
            newg = hasg - wantg;

            if (wantg <= hasg && wantg > 0 && first == true)
            {
                int newsum = cbal + wantpriceg;
                SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP, Acgld=@DA where Acname = '" + a + "'", Con2);
                cmd.Parameters.AddWithValue("@UP", newsum);
                cmd.Parameters.AddWithValue("@DA", newg);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
            Con2.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            bool first = false;

            int wants, wantprices, sprice;
            int hass, news;

            Con2.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con2);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dsg = new DataSet();
            sda.Fill(dsg);
            cbal = int.Parse(dsg.Tables[0].Rows[0]["Acbal"].ToString());
            hass = int.Parse(dsg.Tables[0].Rows[0]["Acslv"].ToString());
            ws = guna2TextBox2.Text;

            if (int.TryParse(guna2TextBox2.Text, out int value))
            {
                wants = int.Parse(ws);
                first = true;
            }
            else
            {
                wants = 0;
            }

            String Query2 = "SELECT * from assetTable Where Asname='Silver'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con2);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
            var dsg2 = new DataSet();
            sda2.Fill(dsg2);
            sprice = int.Parse(dsg2.Tables[0].Rows[0]["Asprice"].ToString());


            wantprices = wants * sprice;
            news = hass - wants;

            if (wants <= hass && wants > 0 && first == true)
            {
                int newsum = cbal + wantprices;
                SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP, Acslv=@DA where Acname = '" + a + "'", Con2);
                cmd.Parameters.AddWithValue("@UP", newsum);
                cmd.Parameters.AddWithValue("@DA", news);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
            Con2.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Asset_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void buyslv_Click(object sender, EventArgs e)
        {
            bool first = false;
            int wantg, wantpriceg, gprice;
            int hasg, newg;

            Con2.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con2);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dsg = new DataSet();
            sda.Fill(dsg);
            cbal = int.Parse(dsg.Tables[0].Rows[0]["Acbal"].ToString());
            hasg = int.Parse(dsg.Tables[0].Rows[0]["Acgld"].ToString());
            wg = guna2TextBox1.Text;

            if (int.TryParse(guna2TextBox1.Text, out int value))
            {
                wantg = int.Parse(wg);
                
                first = true;
            }
            else
            {
                wantg = 0;
            }
            

            String Query2 = "SELECT * from assetTable Where Asname='Gold'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con2);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(sda2);
            var dsg2 = new DataSet();
            sda2.Fill(dsg2);
            gprice = int.Parse(dsg2.Tables[0].Rows[0]["Asprice"].ToString());


            wantpriceg = wantg * gprice;
            newg = wantg + hasg;
            if (wantpriceg < cbal && wantg > 0 && first == true)
            {
                int newsum = cbal - wantpriceg;
                SqlCommand cmd = new SqlCommand("Update AccountTable set Acbal=@UP, Acgld=@DA where Acname = '" + a + "'", Con2);
                cmd.Parameters.AddWithValue("@UP", newsum);
                cmd.Parameters.AddWithValue("@DA", newg);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
            Con2.Close();
        }
    }
}
