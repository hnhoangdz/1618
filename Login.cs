using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatAccount
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
            tbUsername.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("You must input full information");

            }
            else
            {
                if (tbUsername.Text != "admin" || tbPassword.Text != "123456")
                {
                    MessageBox.Show("You must input correct username and password");
                }
                else
                {
                    this.Hide();
                    var sp = new Shopping();
                    sp.Closed += (s, args) => this.Close();
                    sp.Show();
                }
            }
        }
    }
}
