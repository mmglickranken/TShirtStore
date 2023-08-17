using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT1_ConverterGUI
{
    public partial class HOT1ConverterGUI : Form
    {
        public HOT1ConverterGUI()
        {
            InitializeComponent();
        }

        const decimal CM_PER_IN = 2.54m;
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            decimal numInput = Convert.ToDecimal(input);
            string output = (numInput *  CM_PER_IN).ToString();

            txtCalculation.Text = $"{input} inches is {output} centimeters";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculation.Text = "";
            txtInput.Text = "";
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
