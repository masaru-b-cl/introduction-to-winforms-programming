using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RegisterTask
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show(
                   "予期せぬエラーが発生しました。詳細はイベントログを確認して下さい。",
                   "BMI計算機",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Stop);

                EventLog.WriteEntry(
                    "Application",
                    e.Exception.ToString(),
                    System.Diagnostics.EventLogEntryType.Error
                    );

                Application.Exit();
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
