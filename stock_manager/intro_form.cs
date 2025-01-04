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

    }
}
