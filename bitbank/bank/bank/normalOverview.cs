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
    
    public partial class Wit : Form
    {
        private readonly String a;
        bool deleted = false;
        bool r;

        public Wit(String x)
        {
            InitializeComponent();
            a = x;
            Computesum(a);

            fresh();
            Fresh2();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        //
        private bool Create()
        {
            Random rng = new Random();
            bool randomBool = rng.Next(0, 2) > 0;
            return randomBool;
        }

        private void Fresh2()
        {
            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 3000;//5 second
            timer2.Tick += new System.EventHandler(timer2_Tick);
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Randomstuff();
        }

        //


        public void Randomstuff()
        {
            String gp, sp;
            double goldprice, silverprice;
            r = Create();
            Con2.Open();



            //taking from database
            String Query = "SELECT * from assetTable Where Asname='Gold'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con2);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);
            gp = ds.Tables[0].Rows[0]["Asprice"].ToString();
            goldprice = double.Parse(gp);

            String Query2 = "SELECT * from assetTable Where Asname='Silver'";
            SqlDataAdapter sda2 = new SqlDataAdapter(Query2, Con2);
            SqlCommandBuilder builde2 = new SqlCommandBuilder(sda2);
            var ds2 = new DataSet();
            sda2.Fill(ds2);
            sp = ds2.Tables[0].Rows[0]["Asprice"].ToString();
            silverprice = double.Parse(sp);
            



            if (r == true)
            {
                goldprice += 0.03 * goldprice;
                silverprice += 0.03 * silverprice;

                SqlCommand cmd = new SqlCommand("Update assetTable set Asprice=@UP1 where Asname = 'Gold'", Con2);
                cmd.Parameters.AddWithValue("@UP1", goldprice);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Update assetTable set Asprice=@UP2 where Asname = 'Silver'", Con2);
                cmd2.Parameters.AddWithValue("@UP2", silverprice);
                cmd2.ExecuteNonQuery();
            }
            else if (r == false)
            {
                goldprice -= 0.01 * goldprice;
                silverprice -= 0.01 * silverprice;

                SqlCommand cmd3 = new SqlCommand("Update assetTable set Asprice=@UP3 where Asname = 'Gold'", Con2);
                cmd3.Parameters.AddWithValue("@UP3", goldprice);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd4 = new SqlCommand("Update assetTable set Asprice=@UP4 where Asname = 'Silver'", Con2);
                cmd4.Parameters.AddWithValue("@UP4", silverprice);
                cmd4.ExecuteNonQuery();
            }

            Con2.Close();
        }


        private void fresh()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;//1 second
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                Computesum(a);
            }
            else
            {
                return;
            }

        }

        //

       
        public void Computesum(String a)
        {
            Con.Open();
            String Query = "SELECT * from AccountTable Where Acname='" + a + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);
            sum.Text = ds.Tables[0].Rows[0]["Acbal"].ToString();
            Con.Close();
        }

        private void normalOverview_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Addmoney obj4 = new Addmoney(a);
            obj4.Show();
            
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            withdraw obj5 = new withdraw(a);
            obj5.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            send obj6 = new send(a);
            obj6.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(sum.Text) == 0)
            {
                deleted = true;
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM AccountTable WHERE Acname = '" + a + "'", Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                createnew obj = new createnew(a);
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nu puteti sterge contul daca inca are bani in el");
            }
            //this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit(a);
            Edit.Show();
           
        }

        private void sum_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Asset As = new Asset(a);
            As.Show();
            
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
