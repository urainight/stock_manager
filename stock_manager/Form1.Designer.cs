namespace stock_manager
{
    partial class Loginform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.loginlb = new System.Windows.Forms.Label();
            this.contentlb = new System.Windows.Forms.Label();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.paswordlb = new System.Windows.Forms.Label();
            this.usernamlb = new System.Windows.Forms.Label();
            this.signuplinklb = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.Location = new System.Drawing.Point(567, 325);
            this.usernametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(297, 31);
            this.usernametb.TabIndex = 1;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.Location = new System.Drawing.Point(567, 372);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(297, 31);
            this.passwordtb.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.minimizebtn);
            this.panel1.Controls.Add(this.cancelbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 52);
            this.panel1.TabIndex = 4;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.White;
            this.minimizebtn.BackgroundImage = global::stock_manager.Properties.Resources.minimize_sign;
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Location = new System.Drawing.Point(787, 2);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(48, 48);
            this.minimizebtn.TabIndex = 5;
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.White;
            this.cancelbtn.BackgroundImage = global::stock_manager.Properties.Resources.cancel;
            this.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.cancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelbtn.Location = new System.Drawing.Point(840, 2);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(48, 48);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlb.Location = new System.Drawing.Point(597, 258);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(101, 38);
            this.loginlb.TabIndex = 2;
            this.loginlb.Text = "Login";
            // 
            // contentlb
            // 
            this.contentlb.AutoSize = true;
            this.contentlb.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentlb.Location = new System.Drawing.Point(18, 447);
            this.contentlb.Name = "contentlb";
            this.contentlb.Size = new System.Drawing.Size(356, 76);
            this.contentlb.TabIndex = 2;
            this.contentlb.Text = "Welcome to\r\nStock manager System";
            this.contentlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordcheckbox.Location = new System.Drawing.Point(567, 410);
            this.passwordcheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(190, 31);
            this.passwordcheckbox.TabIndex = 6;
            this.passwordcheckbox.Text = "Show password";
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::stock_manager.Properties.Resources.management;
            this.pictureBox2.Location = new System.Drawing.Point(423, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::stock_manager.Properties.Resources.inventory;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("loginbtn.Image")));
            this.loginbtn.Location = new System.Drawing.Point(655, 447);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(141, 55);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // paswordlb
            // 
            this.paswordlb.AutoSize = true;
            this.paswordlb.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswordlb.Image = ((System.Drawing.Image)(resources.GetObject("paswordlb.Image")));
            this.paswordlb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paswordlb.Location = new System.Drawing.Point(385, 370);
            this.paswordlb.Name = "paswordlb";
            this.paswordlb.Size = new System.Drawing.Size(155, 36);
            this.paswordlb.TabIndex = 2;
            this.paswordlb.Text = "    Pasword";
            this.paswordlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernamlb
            // 
            this.usernamlb.AutoSize = true;
            this.usernamlb.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamlb.Image = ((System.Drawing.Image)(resources.GetObject("usernamlb.Image")));
            this.usernamlb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernamlb.Location = new System.Drawing.Point(385, 324);
            this.usernamlb.Name = "usernamlb";
            this.usernamlb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernamlb.Size = new System.Drawing.Size(174, 36);
            this.usernamlb.TabIndex = 2;
            this.usernamlb.Text = "    Username";
            this.usernamlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // signuplinklb
            // 
            this.signuplinklb.AutoSize = true;
            this.signuplinklb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplinklb.Location = new System.Drawing.Point(579, 511);
            this.signuplinklb.Name = "signuplinklb";
            this.signuplinklb.Size = new System.Drawing.Size(269, 23);
            this.signuplinklb.TabIndex = 7;
            this.signuplinklb.TabStop = true;
            this.signuplinklb.Text = "Dont have an account? Sign up";
            this.signuplinklb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signuplinklb_LinkClicked);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(891, 551);
            this.Controls.Add(this.signuplinklb);
            this.Controls.Add(this.passwordcheckbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginlb);
            this.Controls.Add(this.contentlb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paswordlb);
            this.Controls.Add(this.usernamlb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label usernamlb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Label paswordlb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.Label contentlb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.LinkLabel signuplinklb;
    }
}

