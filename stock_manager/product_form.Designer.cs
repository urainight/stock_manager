namespace stock_manager
{
    partial class product_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelwelcome = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.Dashboardbtn = new System.Windows.Forms.Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.ProductgridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Addbtn = new System.Windows.Forms.Button();
            this.findtxt = new System.Windows.Forms.TextBox();
            this.findpicturebox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.labelwelcome);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.Productbtn);
            this.panel1.Controls.Add(this.Dashboardbtn);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 549);
            this.panel1.TabIndex = 1;
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
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.AutoSize = true;
            this.logoutbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Image = global::stock_manager.Properties.Resources.logout__1_1;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(0, 454);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.logoutbtn.Size = new System.Drawing.Size(232, 84);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "       Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Productbtn.AutoSize = true;
            this.Productbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Productbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Image = global::stock_manager.Properties.Resources.delivery_box;
            this.Productbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productbtn.Location = new System.Drawing.Point(0, 302);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Productbtn.Size = new System.Drawing.Size(232, 84);
            this.Productbtn.TabIndex = 0;
            this.Productbtn.Text = "       Product";
            this.Productbtn.UseVisualStyleBackColor = false;
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dashboardbtn.AutoSize = true;
            this.Dashboardbtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Dashboardbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.Dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.Image = global::stock_manager.Properties.Resources.dashboard3;
            this.Dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.Location = new System.Drawing.Point(0, 194);
            this.Dashboardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Dashboardbtn.Size = new System.Drawing.Size(232, 84);
            this.Dashboardbtn.TabIndex = 0;
            this.Dashboardbtn.Text = "       Dashboard";
            this.Dashboardbtn.UseVisualStyleBackColor = false;
            this.Dashboardbtn.Click += new System.EventHandler(this.Dashboardbtn_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUser.Image = global::stock_manager.Properties.Resources.user__1_;
            this.pictureUser.Location = new System.Drawing.Point(0, 31);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(232, 108);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // ProductgridView
            // 
            this.ProductgridView.AllowUserToAddRows = false;
            this.ProductgridView.AllowUserToDeleteRows = false;
            this.ProductgridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductgridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductgridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductgridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductgridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5});
            this.ProductgridView.Location = new System.Drawing.Point(249, 91);
            this.ProductgridView.MultiSelect = false;
            this.ProductgridView.Name = "ProductgridView";
            this.ProductgridView.ReadOnly = true;
            this.ProductgridView.RowHeadersVisible = false;
            this.ProductgridView.RowHeadersWidth = 51;
            this.ProductgridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductgridView.RowTemplate.Height = 24;
            this.ProductgridView.ShowEditingIcon = false;
            this.ProductgridView.Size = new System.Drawing.Size(779, 446);
            this.ProductgridView.TabIndex = 0;
            this.ProductgridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductgridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_id";
            this.Column1.FillWeight = 95.37016F;
            this.Column1.HeaderText = "Product_id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_name";
            this.Column2.FillWeight = 111.2299F;
            this.Column2.HeaderText = "Product_name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantity";
            this.Column3.FillWeight = 95.37016F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "unit";
            this.Column6.FillWeight = 95.37016F;
            this.Column6.HeaderText = "Unit";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "date";
            this.Column7.FillWeight = 95.37016F;
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "date_update";
            this.Column8.FillWeight = 116.5487F;
            this.Column8.HeaderText = "Date_update";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.FillWeight = 95.37016F;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "Edit";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.FillWeight = 95.37016F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Delete";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbtn.BackColor = System.Drawing.Color.LightCoral;
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Addbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(919, 26);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 44);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // findtxt
            // 
            this.findtxt.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findtxt.Location = new System.Drawing.Point(249, 31);
            this.findtxt.Name = "findtxt";
            this.findtxt.Size = new System.Drawing.Size(302, 34);
            this.findtxt.TabIndex = 4;
            this.findtxt.TextChanged += new System.EventHandler(this.findtxt_TextChanged);
            // 
            // findpicturebox
            // 
            this.findpicturebox.BackColor = System.Drawing.Color.Coral;
            this.findpicturebox.BackgroundImage = global::stock_manager.Properties.Resources.magnifying_glass1;
            this.findpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.findpicturebox.Location = new System.Drawing.Point(551, 31);
            this.findpicturebox.Name = "findpicturebox";
            this.findpicturebox.Size = new System.Drawing.Size(62, 34);
            this.findpicturebox.TabIndex = 3;
            this.findpicturebox.TabStop = false;
            // 
            // product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1040, 549);
            this.Controls.Add(this.findtxt);
            this.Controls.Add(this.findpicturebox);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ProductgridView);
            this.Controls.Add(this.panel1);
            this.Name = "product_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product_form";
            this.Shown += new System.EventHandler(this.product_form_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelwelcome;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Button Dashboardbtn;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.DataGridView ProductgridView;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox findpicturebox;
        private System.Windows.Forms.TextBox findtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button logoutbtn;
    }
}