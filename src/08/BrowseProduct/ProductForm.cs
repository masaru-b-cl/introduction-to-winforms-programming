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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public Product Product
        {
            set
            {
                productCodeTextBox.Text = value.Code;
                productNameTextBox.Text = value.Name;
                makerNameTextBox.Text = value.MakerName;
            }
        }
    }
}
