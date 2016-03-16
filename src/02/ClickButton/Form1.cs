using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ボタンをクリックしたら、ウィンドウタイトルを変える
            button1.Click += (sender, e) => this.Text = "Clicked!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello C# World!");
        }
    }
}
