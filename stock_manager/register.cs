using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manager
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Usernametxt.Text = Emailtxt.Text = Passwordtxt.Text = String.Empty;
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void signupbtn_Click(object sender, EventArgs e)
        {
            if(signupbtn.Text == "Sign up")
            {
                if (Usernametxt.TextLength < 1 | Emailtxt.TextLength < 1 | Passwordtxt.TextLength < 1)
                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    User std = new User(Usernametxt.Text.Trim(), Emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
                    warehousedb_user.AddUser(std);
                    Clear();
                }
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            var signin_form = new Loginform();
            this.Hide();
            signin_form.ShowDialog();
            this.Close();
        }
        private void hidebtn_Click(object sender, EventArgs e)
        {
            if (Passwordtxt.PasswordChar == '\0')
            {
                showbtn.BringToFront();
                Passwordtxt.PasswordChar = '●';
            }
        }
        private void showbtn_Click_1(object sender, EventArgs e)
        {
            if (Passwordtxt.PasswordChar == '●')
            {
                hidebtn.BringToFront();
                Passwordtxt.PasswordChar = '\0';
            }
        }
        private void register_Shown(object sender, EventArgs e)
        {
            Usernametxt.Focus();
        }
        private void Usernametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Emailtxt.Focus();
            }
        }
        private void Emailtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Passwordtxt.Focus();
            }
        }
        private void Passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signupbtn.PerformClick();
            }
        }
    }
}
