namespace stock_manager
{
    partial class intro_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelwelcome = new System.Windows.Forms.Label();
            this.Productbtn = new System.Windows.Forms.Button();
            this.Dashboardbtn = new System.Windows.Forms.Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.labelwelcome);
            this.panel1.Controls.Add(this.Productbtn);
            this.panel1.Controls.Add(this.Dashboardbtn);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 530);
            this.panel1.TabIndex = 0;
            // 
            // labelwelcome
            // 
            this.labelwelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelwelcome.AutoSize = true;
            this.labelwelcome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwelcome.Location = new System.Drawing.Point(33, 144);
            this.labelwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwelcome.Name = "labelwelcome";
            this.labelwelcome.Size = new System.Drawing.Size(161, 28);
            this.labelwelcome.TabIndex = 1;
            this.labelwelcome.Text = "Welcome User";
            // 
            // Productbtn
            // 
            this.Productbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Productbtn.AutoSize = true;
            this.Productbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Productbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Image = global::stock_manager.Properties.Resources.delivery_box1;
            this.Productbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productbtn.Location = new System.Drawing.Point(0, 302);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Productbtn.Size = new System.Drawing.Size(232, 84);
            this.Productbtn.TabIndex = 0;
            this.Productbtn.Text = "       Product";
            this.Productbtn.UseVisualStyleBackColor = false;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dashboardbtn.AutoSize = true;
            this.Dashboardbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Dashboardbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.Dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.Image = global::stock_manager.Properties.Resources.dashboard31;
            this.Dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.Location = new System.Drawing.Point(0, 194);
            this.Dashboardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Dashboardbtn.Size = new System.Drawing.Size(232, 84);
            this.Dashboardbtn.TabIndex = 0;
            this.Dashboardbtn.Text = "       Dashboard";
            this.Dashboardbtn.UseVisualStyleBackColor = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUser.Image = global::stock_manager.Properties.Resources.user__1_1;
            this.pictureUser.Location = new System.Drawing.Point(0, 31);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(232, 108);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // intro_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "intro_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "intro_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboardbtn;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Label labelwelcome;
    }
}