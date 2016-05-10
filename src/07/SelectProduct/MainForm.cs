using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectProduct
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            using (var searchProductDialog = new SearchProductDialog(productCode: productCodeTextBox.Text))
            {
                var result = searchProductDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var selectedProduct = searchProductDialog.SelectedProduct;

                    productCodeTextBox.Text = selectedProduct.Code;
                    productNameTextBox.Text = selectedProduct.Name;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productCodeTextBox.Clear();
            productNameTextBox.Clear();
        }
    }
}
