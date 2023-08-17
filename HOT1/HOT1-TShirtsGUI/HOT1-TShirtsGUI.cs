using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT1_TShirtsGUI
{
    public partial class HOT1_TShirtsGUI : Form
    {
        public HOT1_TShirtsGUI()
        {
            InitializeComponent();
        }

        string name = "";
        string street = "";
        string city = "";
        string state = "";
        string zip = "";
        int quantity = 0;
        const decimal TSHIRT = 14.99m;
        const decimal TAXRATE = 0.08m;
        decimal total = 0m;
        decimal taxTotal = 0m;
        decimal grandTotal = 0m;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(txtQuantity.Text);
            total = quantity * TSHIRT;
            taxTotal = total * TAXRATE;
            grandTotal = total + taxTotal;

            txtSubtotal.Text = total.ToString("c");
            txtTax.Text = taxTotal.ToString("c");
            txtGrandTotal.Text = grandTotal.ToString("c");
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtQuantity.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtGrandTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
