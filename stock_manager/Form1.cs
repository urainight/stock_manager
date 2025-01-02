using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manager
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool authen = warehousedb_user.LoginUser(usernametb.Text, passwordtb.Text);
            if (authen) 
            {
                var intro_form = new intro_form();
                this.Hide();
                intro_form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is not correct. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void signuplinklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signup_form = new register(null);
            this.Hide();
            signup_form.ShowDialog();
            this.Close();
        }

        private void passwordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordcheckbox.Checked == true)
            {
                passwordtb.PasswordChar = '\0';
            }
            else
            {
                passwordtb.PasswordChar = '*';
            }
        }
    }
}
