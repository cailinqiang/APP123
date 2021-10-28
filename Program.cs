using System;
using System.Windows.Forms;

namespace 数据库扩展
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            运行后台();
            运行前台();
        }

        private static void 运行前台()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 运行窗体());
        }

        private static void 运行后台()
        {
            MessageBox.Show("后台程序启动...", "后台");
        }
    }


}
