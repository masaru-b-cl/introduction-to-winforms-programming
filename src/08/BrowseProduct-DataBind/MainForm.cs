using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowseProduct
{
    public partial class MainForm : Form
    {
        private IList<Product> products;

        public MainForm()
        {
            InitializeComponent();

            products = Enumerable.Range(1, 500)
               .Select(n => new Product
               {
                   Code = $"{n:000000}",
                   Name = $"商品{n:000}",
                   MakerName = $"メーカー{(n % 5) + 1}"
               })
               .ToArray();
        }

        private ProductForm productForm;

        private void MainForm_Load(object sender, EventArgs e)
        {
            productForm = new ProductForm(productBindingSource)
            {
                StartPosition = FormStartPosition.Manual,
                Left = this.Left + this.Width + 20,
                Top = this.Top
            };

            FilterProducts(productNameTextBox.Text);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            productForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            productForm?.Close();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterProducts(productNameTextBox.Text);
        }

        private void FilterProducts(string productName)
        {
            var q = products.AsEnumerable();
            if (string.IsNullOrEmpty(productName) == false)
            {
                q = q.Where(product => product.Name.Contains(productName));
            }

            var filteredProducts = q.ToArray();

            productBindingSource.DataSource = filteredProducts;
        }
    }
}
