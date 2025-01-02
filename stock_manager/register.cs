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
        private readonly register _parent;
       
        public register(register parent)
        {
            InitializeComponent();
            _parent = parent;
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
                User std = new User(Usernametxt.Text.Trim(), Emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
                warehousedb_user.AddUser(std);
                Clear();
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
    }
}
