using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manager
{
    public partial class intro_form : Form
    {
        public intro_form()
        {
            InitializeComponent();
            Dashboardbtn.Enabled = false;
        }
        private void Productbtn_Click(object sender, EventArgs e)
        {
            var product_form = new product_form();
            this.Hide();
            product_form.ShowDialog();
            this.Close();
        }
        public void Display()
        {
            string querry = "SELECT product_id, product_name, quantity, unit, date, date_update FROM warehouse_stock.products WHERE quantity <= 50";
            warehouse_productdb.DisplayAndSearchProduct(querry, dashboardgridview);
        }
        private void findtb_TextChanged(object sender, EventArgs e)
        {
            string querry = "SELECT product_id, product_name, quantity, unit, date, date_update FROM warehouse_stock.products WHERE quantity <= 50 AND product_name LIKE '%" + findtb.Text + "%'";
            warehouse_productdb.DisplayAndSearchProduct(querry, dashboardgridview);
        }
        private void intro_form_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            var login_form = new Loginform();
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }
    }
}
