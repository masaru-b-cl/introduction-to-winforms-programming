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

        public ProductForm(BindingSource productBindingSource) : this()
        {
            this.productBindingSource = productBindingSource;

            // データバインド設定
            // ※Bindingインスタンス作成時の引数は次の通り
            //   1. コントロールのバインド対象プロパティ名
            //   2. バインドするデータソースオブジェクト
            //   3. データオブジェクトのバインド対象プロパティ名
            //   4. 書式指定有無（trueならあり）
            productCodeTextBox.DataBindings.Add(
               new Binding("Text", productBindingSource, nameof(Product.Code), false));
            productNameTextBox.DataBindings.Add(
               new Binding("Text", productBindingSource, nameof(Product.Name), false));
            makerNameTextBox.DataBindings.Add(
               new Binding("Text", productBindingSource, nameof(Product.MakerName), false));
        }
    }
}
