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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 変更前 | label1.Text = "1";
            label1.Text = "現在値:1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 変更前 | var currentValue = int.Parse(label1.Text);
            var currentValue = int.Parse(label1.Text.Replace("現在値:", ""));

            currentValue++;

            // 変更前 | label1.Text = currentValue.ToString("");
            label1.Text = currentValue.ToString("現在値:0");
        }
    }
}
