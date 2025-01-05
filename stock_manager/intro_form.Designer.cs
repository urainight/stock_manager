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
            this.findtb = new System.Windows.Forms.TextBox();
            this.dashboardgridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finfpicturebox = new System.Windows.Forms.PictureBox();
            this.Signoutbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.Dashboardbtn = new System.Windows.Forms.Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finfpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.labelwelcome);
            this.panel1.Controls.Add(this.Signoutbtn);
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
            // findtb
            // 
            this.findtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findtb.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findtb.Location = new System.Drawing.Point(493, 31);
            this.findtb.Name = "findtb";
            this.findtb.Size = new System.Drawing.Size(348, 34);
            this.findtb.TabIndex = 1;
            this.findtb.TextChanged += new System.EventHandler(this.findtb_TextChanged);
            // 
            // dashboardgridview
            // 
            this.dashboardgridview.AllowUserToAddRows = false;
            this.dashboardgridview.AllowUserToDeleteRows = false;
            this.dashboardgridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dashboardgridview.BackgroundColor = System.Drawing.Color.White;
            this.dashboardgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashboardgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dashboardgridview.Location = new System.Drawing.Point(247, 88);
            this.dashboardgridview.MultiSelect = false;
            this.dashboardgridview.Name = "dashboardgridview";
            this.dashboardgridview.ReadOnly = true;
            this.dashboardgridview.RowHeadersVisible = false;
            this.dashboardgridview.RowHeadersWidth = 51;
            this.dashboardgridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dashboardgridview.RowTemplate.Height = 24;
            this.dashboardgridview.ShowEditingIcon = false;
            this.dashboardgridview.Size = new System.Drawing.Size(662, 430);
            this.dashboardgridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Out of stock";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_id";
            this.Column1.HeaderText = "Product_id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_name";
            this.Column2.HeaderText = "Product_name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "unit";
            this.Column4.HeaderText = "Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "date";
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date_update";
            this.Column6.HeaderText = "Date_update";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // finfpicturebox
            // 
            this.finfpicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finfpicturebox.BackColor = System.Drawing.Color.LightCoral;
            this.finfpicturebox.BackgroundImage = global::stock_manager.Properties.Resources.magnifying_glass2;
            this.finfpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.finfpicturebox.Location = new System.Drawing.Point(841, 31);
            this.finfpicturebox.Name = "finfpicturebox";
            this.finfpicturebox.Size = new System.Drawing.Size(68, 34);
            this.finfpicturebox.TabIndex = 2;
            this.finfpicturebox.TabStop = false;
            // 
            // Signoutbtn
            // 
            this.Signoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Signoutbtn.AutoSize = true;
            this.Signoutbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Signoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.Signoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signoutbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signoutbtn.Image = global::stock_manager.Properties.Resources.logout__1_;
            this.Signoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signoutbtn.Location = new System.Drawing.Point(0, 435);
            this.Signoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signoutbtn.Name = "Signoutbtn";
            this.Signoutbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Signoutbtn.Size = new System.Drawing.Size(232, 84);
            this.Signoutbtn.TabIndex = 0;
            this.Signoutbtn.Text = "       Logout";
            this.Signoutbtn.UseVisualStyleBackColor = false;
            this.Signoutbtn.Click += new System.EventHandler(this.Signoutbtn_Click);
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
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardgridview);
            this.Controls.Add(this.finfpicturebox);
            this.Controls.Add(this.findtb);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "intro_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "intro_form";
            this.Shown += new System.EventHandler(this.intro_form_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finfpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboardbtn;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Label labelwelcome;
        private System.Windows.Forms.TextBox findtb;
        private System.Windows.Forms.PictureBox finfpicturebox;
        private System.Windows.Forms.DataGridView dashboardgridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Signoutbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}