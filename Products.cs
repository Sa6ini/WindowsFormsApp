using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetov_2._0
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void button2_Click(object sender, EventArgs e)
        {

            var products = comboBox1.SelectedItem.ToString();
            var infoProduct = products
                              .Split(" ",
                               StringSplitOptions.RemoveEmptyEntries);
            string nameofproduct = infoProduct[0];
            double price = double.Parse(infoProduct[1].TrimEnd('$'));

            int num = int.Parse(numbers.Text);
            if (num <= 0)
            {
                MessageBox.Show("Number of products cannot be 0 or less", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total = 0;
        }
    }
}
