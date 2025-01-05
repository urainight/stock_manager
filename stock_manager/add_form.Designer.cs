namespace stock_manager
{
    partial class add_form
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
            this.IDlb = new System.Windows.Forms.Label();
            this.Productlb = new System.Windows.Forms.Label();
            this.Idtb = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Unittb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlb.Location = new System.Drawing.Point(5, 108);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(140, 33);
            this.IDlb.TabIndex = 0;
            this.IDlb.Text = "Product id";
            // 
            // Productlb
            // 
            this.Productlb.AutoSize = true;
            this.Productlb.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlb.Location = new System.Drawing.Point(193, 19);
            this.Productlb.Name = "Productlb";
            this.Productlb.Size = new System.Drawing.Size(252, 51);
            this.Productlb.TabIndex = 0;
            this.Productlb.Text = "Add Product";
            // 
            // Idtb
            // 
            this.Idtb.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtb.Location = new System.Drawing.Point(237, 107);
            this.Idtb.Name = "Idtb";
            this.Idtb.Size = new System.Drawing.Size(366, 34);
            this.Idtb.TabIndex = 1;
            this.Idtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Idtb_KeyDown);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(342, 367);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(157, 45);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product quantity";
            // 
            // quantitytb
            // 
            this.quantitytb.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytb.Location = new System.Drawing.Point(237, 242);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(366, 34);
            this.quantitytb.TabIndex = 1;
            this.quantitytb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantitytb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product name";
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.Location = new System.Drawing.Point(237, 174);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(366, 34);
            this.nametb.TabIndex = 1;
            this.nametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametb_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity unit";
            // 
            // Unittb
            // 
            this.Unittb.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unittb.Location = new System.Drawing.Point(237, 308);
            this.Unittb.Name = "Unittb";
            this.Unittb.Size = new System.Drawing.Size(366, 34);
            this.Unittb.TabIndex = 1;
            this.Unittb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unittb_KeyDown);
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(639, 424);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Unittb);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Idtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productlb);
            this.Controls.Add(this.IDlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.add_form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label Productlb;
        private System.Windows.Forms.TextBox Idtb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Unittb;
    }
}