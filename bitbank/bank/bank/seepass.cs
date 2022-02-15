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
    public partial class seepass : Form, IObserver
    {
        public seepass()
        {
            InitializeComponent();
        }

        void IObserver.Update(String c)
        {
            SetTxt(c);
        }
        private void SetTxt(String c)
        {
            label.Text = c;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
