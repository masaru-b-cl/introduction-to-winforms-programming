namespace RegisterTask
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dueFromTextBox = new System.Windows.Forms.TextBox();
            this.dueToTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attachmentFilePathTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "タスク名";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(15, 28);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(325, 19);
            this.taskNameTextBox.TabIndex = 0;
            this.taskNameTextBox.Text = "○○を行う";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "期間";
            // 
            // dueFromTextBox
            // 
            this.dueFromTextBox.Location = new System.Drawing.Point(14, 79);
            this.dueFromTextBox.Name = "dueFromTextBox";
            this.dueFromTextBox.Size = new System.Drawing.Size(78, 19);
            this.dueFromTextBox.TabIndex = 1;
            this.dueFromTextBox.Text = "yyyy/MM/dd";
            // 
            // dueToTextBox
            // 
            this.dueToTextBox.Location = new System.Drawing.Point(121, 79);
            this.dueToTextBox.Name = "dueToTextBox";
            this.dueToTextBox.Size = new System.Drawing.Size(78, 19);
            this.dueToTextBox.TabIndex = 2;
            this.dueToTextBox.Text = "yyyy/MM/dd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "→";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "添付ファイルパス";
            // 
            // attachmentFilePathTextBox
            // 
            this.attachmentFilePathTextBox.Location = new System.Drawing.Point(15, 131);
            this.attachmentFilePathTextBox.Name = "attachmentFilePathTextBox";
            this.attachmentFilePathTextBox.Size = new System.Drawing.Size(325, 19);
            this.attachmentFilePathTextBox.TabIndex = 3;
            this.attachmentFilePathTextBox.Text = "C:\\path\\to\\attachmentFile.txt";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(15, 179);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "登録";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 320);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dueToTextBox);
            this.Controls.Add(this.dueFromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attachmentFilePathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "タスク登録";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dueFromTextBox;
        private System.Windows.Forms.TextBox dueToTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox attachmentFilePathTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

