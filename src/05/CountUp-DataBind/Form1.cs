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

        private AppModel model = new AppModel(initialValue: 1);

        private void Form1_Load(object sender, EventArgs e)
        {
            appModelBindingSource.DataSource = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.CurrentValue++;
        }
    }
}
