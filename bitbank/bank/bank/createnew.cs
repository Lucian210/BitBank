using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class createnew : Form
    {
        private readonly String a;
        public createnew(String x)
        {
            InitializeComponent();
            a = x;
        }

        private void create_Click(object sender, EventArgs e)
        {
            menu obj = new menu(a);
            obj.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
