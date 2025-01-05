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
    public partial class add_form : Form
    {
        private readonly product_form _parent;
        public string id, name, quantity, unit;
        public add_form(product_form parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void add_form_Shown(object sender, EventArgs e)
        {
            Idtb.Focus();
        }

        private void Idtb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                nametb.Focus();
            }
        }

        private void nametb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                quantitytb.Focus();
            }
        }

        private void quantitytb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Unittb.Focus();
            }
        }

        private void Unittb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Addbtn.PerformClick();
            }
        }

        public void UpdateInfo()
        {
            Productlb.Text = "Update Product";
            Addbtn.Text = "Update";
            Idtb.Text = id;
            nametb.Text = name;
            quantitytb.Text = quantity;
            Unittb.Text = unit;
        }
        public void Clear()
        {
            Idtb.Text = nametb.Text = quantitytb.Text = Unittb.Text = String.Empty;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(Addbtn.Text == "Add")
            {
                if (Idtb.TextLength < 1 | nametb.TextLength < 1 | quantitytb.TextLength < 1 | Unittb.TextLength < 1)
                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product std = new Product(int.Parse(Idtb.Text.Trim()), nametb.Text.Trim(), int.Parse(quantitytb.Text.Trim()), Unittb.Text.Trim());
                    warehouse_productdb.AddProduct(std);
                    Clear();
                }
            }
            if(Addbtn.Text == "Update")
            {
                if (Idtb.TextLength < 1 | nametb.TextLength < 1 | quantitytb.TextLength < 1 | Unittb.TextLength < 1)
                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product std = new Product(int.Parse(Idtb.Text.Trim()), nametb.Text.Trim(), int.Parse(quantitytb.Text.Trim()), Unittb.Text.Trim());
                    warehouse_productdb.EditProduct(std, int.Parse(Idtb.Text.Trim()));
                    Clear();
                }
            }
            _parent.Display();
        }
    }
}
