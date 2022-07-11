using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinForm
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtUserid.Text=="admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Success");
            }
            else
            {

                MessageBox.Show("Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserid.Clear();
            txtPassword.Clear();
        }
    }
}
