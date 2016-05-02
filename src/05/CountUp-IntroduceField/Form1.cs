using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 現在値。
        /// </summary>
        private int currentValue = 1;

        /// <summary>
        /// フォームを描画します。
        /// </summary>
        private void RenderForm()
        {
            // 変更前 | label1.Text = currentValue.ToString();
            label1.Text = currentValue.ToString("現在値:0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentValue++;

            RenderForm();
        }
    }
}
