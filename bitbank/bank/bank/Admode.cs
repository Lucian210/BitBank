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
    public partial class Admode : Form
    {
 
        /// </summary>
        private Counter counter;

        public Admode()
        {
            InitializeComponent();
            DisplayAcc();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayAcc()
        {

            String Query = "select * from AccountTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }


        private void Admode_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Acphone.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Acadress.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Acgender.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Acocup.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Aceducation.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Acincome.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            guna2TextBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Reset()
        {
            Acphone.Text = "";
            Acadress.Text = "";
            Acgender.SelectedIndex = -1;
            Acocup.Text = "";
            Acincome.Text = "";
            Aceducation.SelectedIndex = -1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String nume = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update AccountTable set Acphone=@AP,Acadress=@AA,Acgen=@AG,Acocup=@AO,Aceduc=@AE,Acinc=@AI where Acname = @AcKey", Con);
            cmd.Parameters.AddWithValue("@AP", Acphone.Text);
            cmd.Parameters.AddWithValue("@AA", Acadress.Text);
            cmd.Parameters.AddWithValue("@AG", Acgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@AO", Acocup.Text);
            cmd.Parameters.AddWithValue("@AE", Aceducation.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@AI", Acincome.Text);
            cmd.Parameters.AddWithValue("@AcKey", nume);
            cmd.ExecuteNonQuery();


            SqlCommand cmd2 = new SqlCommand("Update UsersTable set Userphone=@AP,Useradress=@AA where Username = @AcKey", Con);
            cmd2.Parameters.AddWithValue("@AP", Acphone.Text);
            cmd2.Parameters.AddWithValue("@AA", Acadress.Text);
            cmd2.Parameters.AddWithValue("@AcKey", nume);
            cmd2.ExecuteNonQuery();

            Reset();
            DisplayAcc();
            Con.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            trans obj = new trans();
            obj.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            String a = guna2TextBox1.Text;

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTable where Username='" + a + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                counter = new Counter();
                seepass obj = new seepass();
                obj.Show();
                counter.RegisterObserve(obj);
                counter.Increment(a);
            }
            else
            {
                MessageBox.Show("User inexistent");
            }
            Con.Close();
            
        }

        private void Acincome_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
