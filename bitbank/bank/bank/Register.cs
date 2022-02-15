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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            DisplayAcc();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayAcc()
        {
            Con.Open();
            String Query = "select * from AccountTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Acdatagrid.DataSource = ds.Tables[0];
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

        //submit
        private void submit_Click(object sender, EventArgs e)
        {
            if(Acname.Text == "" || Acphone.Text == "" || Acadress.Text == "" || Acgender.SelectedIndex == -1 || Acocupation.Text == "" || Aceducation.SelectedIndex == -1 || Acincome.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AccountTable(Acname,Acphone,Acadress,Acgen,Acocup,Aceduc,Acinc,Acbal) Values (@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", Acname.Text);
                    cmd.Parameters.AddWithValue("@AP", Acphone.Text);
                    cmd.Parameters.AddWithValue("@AA", Acadress.Text);
                    cmd.Parameters.AddWithValue("@AG", Acgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", Acocupation.Text);
                    cmd.Parameters.AddWithValue("@AE", Aceducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", Acincome.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!");
                    Con.Close();
                    Reset();
                    DisplayAcc(); 
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                   
                }
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        //edit

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Acname.Text == "" || Acphone.Text == "" || Acadress.Text == "" || Acgender.SelectedIndex == -1 || Acocupation.Text == "" || Aceducation.SelectedIndex == -1 || Acincome.Text == "")
            {
                MessageBox.Show("Select an account and modify it");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTable set Acname=@AN,Acphone=@AP,Acadress=@AA,Acgen=@AG,Acocup=@AO,Aceduc=@AE,Acinc=@AI where Acnum = @AcKey", Con);
                    cmd.Parameters.AddWithValue("@AN", Acname.Text);
                    cmd.Parameters.AddWithValue("@AP", Acphone.Text);
                    cmd.Parameters.AddWithValue("@AA", Acadress.Text);
                    cmd.Parameters.AddWithValue("@AG", Acgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", Acocupation.Text);
                    cmd.Parameters.AddWithValue("@AE", Aceducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", Acincome.Text);
                    cmd.Parameters.AddWithValue("@AcKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!");
                    Con.Close();
                    Reset();
                    DisplayAcc();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //delete
        private void cancel_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select an account");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTable where Acnum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AcKey", key);
                    cmd.ExecuteNonQuery();               
                    MessageBox.Show("Account Deleted!");
                    Con.Close();
                    Reset();
                    DisplayAcc();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
  
                }
            }
        }

        int key = 0;
        private void Acdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Acname.Text = Acdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            Acphone.Text = Acdatagrid.SelectedRows[0].Cells[2].Value.ToString();
            Acadress.Text = Acdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            Acgender.SelectedItem = Acdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            Acocupation.Text = Acdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            Aceducation.SelectedItem = Acdatagrid.SelectedRows[0].Cells[6].Value.ToString();
            Acincome.Text = Acdatagrid.SelectedRows[0].Cells[7].Value.ToString();

            if(Acname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Acdatagrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

    }
}
