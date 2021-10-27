using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库扩展
{
    public partial class 登录窗体 : Form
    {
        public 登录窗体()
        {
            InitializeComponent();
        }

        private void 登录按钮_Click(object sender, EventArgs e)
        {
            if(验证信息())
            {
                打开主窗();
            }
            else
            {
                Close();
            }
        }

        private bool 验证信息()
        {
            //代码验证
            return true;
        }

        private void 打开主窗()
        {
            var form = new 运行窗体();
            form.Show();
            this.Hide();
        }
    }
}
