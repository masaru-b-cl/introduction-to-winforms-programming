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

namespace VariousControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック！");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5)
            {
                MessageBox.Show("入力文字数が5文字を超えました");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("チェック" + (checkBox1.Checked ? "オン" : "オフ"));
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                MessageBox.Show(rb.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.SelectedItem));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(comboBox1.SelectedItem));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add(new MyListItem("前背景色設定", "01"));
            listBox2.Items.Add(new MyListItem("項目２", "02"));
            listBox2.Items.Add(new MyListItem("項目３", "03"));

            listBox3.Items.Add(new MyListItem("複数選択可能", "01"));
            listBox3.Items.Add(new MyListItem("項目２", "02"));
            listBox3.Items.Add(new MyListItem("項目３", "03"));

            comboBox2.Items.Add(new MyListItem("前背景色設定", "01"));
            comboBox2.Items.Add(new MyListItem("項目２", "02"));
            comboBox2.Items.Add(new MyListItem("項目３", "03"));

            comboBox3.Items.Add(new MyListItem("テキスト入力不可", "01"));
            comboBox3.Items.Add(new MyListItem("項目２", "02"));
            comboBox3.Items.Add(new MyListItem("項目３", "03"));

            {
                // 行追加
                dataGridView1.Rows.Add();
                // 編集対象行取得
                var row = dataGridView1.Rows[0];
                // 行データ設定
                row.Cells[0].Value = "00001";
                row.Cells[1].Value = "鈴木 一郎";
                row.Cells[2].Value = "男";
                row.Cells[3].Value = new DateTime(2016, 4, 1);
                row.Cells[4].Value = false;
            }
            {
                // 行追加
                dataGridView1.Rows.Add();
                // 編集対象行取得
                var row = dataGridView1.Rows[1];
                // 行データ設定
                row.Cells[0].Value = "00002";
                row.Cells[1].Value = "佐藤 花子";
                row.Cells[2].Value = "女";
                row.Cells[3].Value = new DateTime(2013, 10, 1);
                row.Cells[4].Value = true;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
            {
                // 削除ボタン以外は処理終了
                return;
            }

            // 削除ボタンを押した行データを取得
            var row = dataGridView1.Rows[e.RowIndex];
            var employee = new
            {
                Id = row.Cells[0].Value as string,
                Name = row.Cells[1].Value as string,
                Gender = row.Cells[2].Value as string,
                HireDate = (DateTime)row.Cells[3].Value,
                Suspended = (bool)row.Cells[4].Value
            };

            var result = MessageBox.Show($@"このデータを削除してもよいですか？
社員コード: {employee.Id}
氏名 : {employee.Name}
性別 : {employee.Gender}
入社日 : {employee.HireDate:yyyy/MM/dd}
勤務状況 : {(employee.Suspended ? "休職中" : "通常勤務")}",
                "削除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }

    class MyListItem
    {
        public string Text { get; }
        public string Value { get; }

        public MyListItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}:{Text}";
        }
    }
}
