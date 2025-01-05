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
    public partial class product_form : Form
    {
        add_form form;
        public product_form()
        {
            InitializeComponent();
            Productbtn.Enabled = false;
            form = new add_form(this);
        }
        public void Display()
        {
            string querry = "SELECT product_id, product_name, quantity, unit, date, date_update FROM warehouse_stock.products";
            warehouse_productdb.DisplayAndSearchProduct(querry, ProductgridView);
        }
        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            var intro_form = new intro_form();
            this.Hide();
            intro_form.ShowDialog();
            this.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }
        private void product_form_Shown(object sender, EventArgs e)
        {
            Display();
        }
        private void findtxt_TextChanged(object sender, EventArgs e)
        {
            string querry = "SELECT product_id, product_name, quantity, unit, date FROM warehouse_stock.products WHERE product_name LIKE '%" + findtxt.Text + "%'";
            warehouse_productdb.DisplayAndSearchProduct(querry, ProductgridView);
        }
        private void ProductgridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                form.Clear();
                form.id = ProductgridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = ProductgridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.quantity = ProductgridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.unit = ProductgridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int product_id = int.Parse(ProductgridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    warehouse_productdb.DeleteProduct(product_id);
                    Display();
                }
                return;
            }
        }
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            var login_form = new Loginform();
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }
    }
}
