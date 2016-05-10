namespace SelectProduct
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品コード";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(35, 46);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(54, 19);
            this.productCodeTextBox.TabIndex = 0;
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(95, 44);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductButton.TabIndex = 1;
            this.searchProductButton.Text = "商品検索";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(35, 93);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.productNameTextBox.TabIndex = 2;
            this.productNameTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品名";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

