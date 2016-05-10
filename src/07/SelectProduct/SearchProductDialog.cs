using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SelectProduct
{
    public partial class SearchProductDialog : Form
    {
        private IList<Product> products;

        public SearchProductDialog()
        {
            InitializeComponent();

            products = Enumerable.Range(1, 500)
                .Select(n => new Product
                {
                    Code = $"{n:000000}",
                    Name = $"商品{n:000}",
                    MakerName = $"メーカー{(n % 5) +1}"
                })
                .ToArray();
        }

        private readonly string productCode;

        public SearchProductDialog(string productCode) : this()
        {
            this.productCode = productCode;
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            productCodeTextBox.Text = productCode;

            FilterProducts(productCodeTextBox.Text);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterProducts(productCodeTextBox.Text);
        }

        private void FilterProducts(string productCode)
        {
            var q = products.AsEnumerable();
            if (string.IsNullOrEmpty(productCode) == false)
            {
                q = q.Where(product => product.Code.Contains(productCode));
            }

            var filteredProducts = q.ToArray();

            productDataGridView.RowCount = 0;

            foreach (var product in filteredProducts)
            {
                var rowIndex = productDataGridView.Rows.Add();
                var row = productDataGridView.Rows[rowIndex];
                row.Cells[0].Value = product.Code;
                row.Cells[1].Value = product.Name;
                row.Cells[2].Value = product.MakerName;
            }
        }

        public Product SelectedProduct { get; private set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            var selectedProductCode = productDataGridView.CurrentRow?.Cells?[0]?.Value as string;

            if (string.IsNullOrEmpty(selectedProductCode))
            {
                return;
            }

            SelectedProduct = products.First(product => product.Code == selectedProductCode);
        }
    }
}
