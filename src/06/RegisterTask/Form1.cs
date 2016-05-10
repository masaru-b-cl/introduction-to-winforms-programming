using System;
using System.IO;
using System.Windows.Forms;

namespace RegisterTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();

            SetInitialFocus();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // エラーチェック
            var isValid = ValidateForm();

            if (isValid == false)
            {
                // 業務エラーあり
                return;
            }

            // 登録処理実行

            Stream stream = null;
            try
            {
                // 添付ファイルオープン
                stream = File.Open(attachmentFilePathTextBox.Text, FileMode.Open);
            }
            catch(FileNotFoundException)
            {
                ShowErrorMessage($@"添付ファイル{attachmentFilePathTextBox.Text}がありません。
存在するファイルパスを入力してください。");
                return;
            }
            finally
            {
                // 添付ファイルクローズ
                stream?.Close();
            }

/* using構文を使ったケース
            try
            {
                // 添付ファイルオープン
                using (var stream = File.Open(attachmentFilePathTextBox.Text, FileMode.Open))
                {
                    // 登録処理
                }
            }
            catch (FileNotFoundException)
            {
                ShowErrorMessage($@"添付ファイル{attachmentFilePathTextBox.Text}がありません。
存在するファイルパスを入力してください。");
                return;
            }
*/

            MessageBox.Show("タスクを登録しました。");

            ClearForm();

            SetInitialFocus();
        }

        private void ClearForm()
        {
            taskNameTextBox.Clear();
            dueFromTextBox.Clear();
            dueToTextBox.Clear();
            attachmentFilePathTextBox.Clear();

            CrearErrors();
        }

        private void CrearErrors()
        {
            errorProvider.SetError(taskNameTextBox, null);
            errorProvider.SetError(dueFromTextBox, null);
            errorProvider.SetError(dueToTextBox, null);
            errorProvider.SetError(attachmentFilePathTextBox, null);
        }

        private void SetInitialFocus()
        {
            taskNameTextBox.Focus();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateForm()
        {
            CrearErrors();

            // ■項目エラーチェック
            
            // □項目単体チェック
            var hasItemError = false;

            // タスク名
            if (string.IsNullOrEmpty(taskNameTextBox.Text))
            {
                errorProvider.SetError(taskNameTextBox, "タスク名を入力してください。");
                hasItemError = true;
            }

            // 期間開始日
            DateTime? dueFrom;
            var dueFromIsValid = TryParseDate(dueFromTextBox.Text, out dueFrom);
            if (dueFromIsValid == false)
            {
                errorProvider.SetError(dueFromTextBox, "期間開始日に日付を入力してください。");
                hasItemError = true;
            }

            // 期間終了日
            DateTime? dueTo;
            var dueToIsValid = TryParseDate(dueToTextBox.Text, out dueTo);
            if (dueToIsValid == false)
            {
                errorProvider.SetError(dueToTextBox, "期間終了日に日付を入力してください。");
                hasItemError = true;
            }

            // □項目組合せチェック
            // 期間
            if (dueFrom.HasValue && dueTo.HasValue)
            {
                // 開始、終了日とも入力あり
                if (dueTo.Value < dueFrom.Value)
                {
                    // 終了日が開始日より前
                    ShowErrorMessage("期間終了日には開始日以降の日付を入力してください。");
                    hasItemError = true;
                }
            }
            else
            {
                if (dueFromIsValid && dueToIsValid &&
                    (dueFrom.HasValue || dueTo.HasValue))
                {
                    // 開始、終了日の一方のみ入力あり
                    ShowErrorMessage("期間を入力する場合、開始日と終了日の両方を入力してください。");
                    hasItemError = true;
                }
            }

            if (hasItemError)
            {
                // 項目チェックエラーあり
                return false;
            }

            // ■突き合わせチェック
            if (string.IsNullOrEmpty(attachmentFilePathTextBox.Text) == false &&
                File.Exists(attachmentFilePathTextBox.Text) == false)
            {
                // 開始、終了日の一方のみ入力あり
                ShowErrorMessage($@"添付ファイル{attachmentFilePathTextBox.Text}がありません。
存在するファイルパスを入力してください。");
                return false;
            }

            return true;
        }

        private static bool TryParseDate(string value, out DateTime? result)
        {
            if (string.IsNullOrEmpty(value))
            {
                result = null;
                return true;
            }

            DateTime date;
            var formats = new[] { "yyyy/M/d", "yy/M/d", "M/d" };
            var isDate = DateTime.TryParseExact(
                value,
                formats,
                null,
                System.Globalization.DateTimeStyles.None,
                out date);

            if (isDate)
            {
                result = date;
            }
            else
            {
                result = null;
            }

            return isDate;
        }
    }
}
