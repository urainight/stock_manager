namespace stock_manager
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.usernamelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.emaillb = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordlb = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.hidebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(168, 158);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(464, 35);
            this.Usernametxt.TabIndex = 1;
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(163, 127);
            this.usernamelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(123, 28);
            this.usernamelb.TabIndex = 2;
            this.usernamelb.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.minimizebtn);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 4;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(56, 52);
            this.backbtn.TabIndex = 6;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizebtn.BackgroundImage")));
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Location = new System.Drawing.Point(680, 0);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(4);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(56, 52);
            this.minimizebtn.TabIndex = 6;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.BackgroundImage")));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(744, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(56, 52);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Emailtxt
            // 
            this.Emailtxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(168, 233);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(464, 35);
            this.Emailtxt.TabIndex = 1;
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillb.Location = new System.Drawing.Point(163, 202);
            this.emaillb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(78, 28);
            this.emaillb.TabIndex = 2;
            this.emaillb.Text = "Email:";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(168, 308);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '●';
            this.Passwordtxt.Size = new System.Drawing.Size(464, 35);
            this.Passwordtxt.TabIndex = 1;
            // 
            // passwordlb
            // 
            this.passwordlb.AutoSize = true;
            this.passwordlb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlb.Location = new System.Drawing.Point(163, 277);
            this.passwordlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlb.Name = "passwordlb";
            this.passwordlb.Size = new System.Drawing.Size(119, 28);
            this.passwordlb.TabIndex = 2;
            this.passwordlb.Text = "Password:";
            // 
            // signupbtn
            // 
            this.signupbtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(296, 370);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(4);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(209, 53);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // hidebtn
            // 
            this.hidebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidebtn.BackgroundImage")));
            this.hidebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hidebtn.Location = new System.Drawing.Point(597, 308);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(35, 35);
            this.hidebtn.TabIndex = 6;
            this.hidebtn.UseVisualStyleBackColor = true;
            this.hidebtn.Click += new System.EventHandler(this.hidebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showbtn.BackgroundImage")));
            this.showbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showbtn.Location = new System.Drawing.Point(597, 308);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(35, 35);
            this.showbtn.TabIndex = 7;
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click_1);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.hidebtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordlb);
            this.Controls.Add(this.emaillb);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Usernametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label emaillb;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label passwordlb;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button hidebtn;
        private System.Windows.Forms.Button showbtn;
    }
}