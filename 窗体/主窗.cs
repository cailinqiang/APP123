using System;
using System.Windows.Forms;
using 数据库扩展.类库;

namespace 数据库扩展
{
    public partial class 运行窗体 : Form
    {
        public 运行窗体()
        {
            InitializeComponent();
            执行任务4();
        }

        private void 执行任务4()
        {
            var 连接串= 数源.生成连接串(数源种类.OleDb,"Microsoft.Jet.Oledb.4.0",null,@"c:\MyData\Workgroup.mdb","cailin","123456");
            var 类别 = 数源.命令器(数源种类.MySql)?.ToString();
            MessageBox.Show(类别, "OleDbConnection");
        }

        private void 执行任务3()
        {
            var builder = new System.Data.OleDb.OleDbConnectionStringBuilder
            {
                //ConnectionString=$"Provider = Microsoft.ACE.OLEDB.12.0 ; Data source =c:\\Workgroup.mdb;Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'",

                Provider = "Microsoft.Jet.Oledb.4.0",
                DataSource = @"c:\MyData\Workgroup.mdb",
                ["Password"] = "123456",
                ["User Id"] = 123+345,//进行计算后的值 即468
                ["Extended Properties"]="Excel 8.0; HDR=Yes; IMEX=1",
                //["User Id"] = "Admin;NewValue=Bad",
            };
            MessageBox.Show(builder.ConnectionString, "OleDbConnection");
        }

        private void 执行任务2()
        {
            var builder = new System.Data.Common.DbConnectionStringBuilder
            {
                ConnectionString=$"Provider = Microsoft.ACE.OLEDB.12.0 ; Data source =c:\\Workgroup.mdb;Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'",

                ["Provider"] = "Microsoft.Jet.Oledb.4.0",
                ["DataSource"] = @"c:\MyData\Workgroup.mdb",
                ["Password"] = "123456",
                ["User Id"] = 123+345,//进行计算后的值 即468
                //["User Id"] = "Admin;NewValue=Bad",
                ["Jet OLEDB:Database Locking Mode"] = 1
            };
            MessageBox.Show(builder.ConnectionString, "Test");

        }

        private void 执行任务1()
        {
            System.Data.DataTable table = System.Data.Common.DbProviderFactories.GetFactoryClasses();
            表单.DataSource = table;
        }
    }
}
