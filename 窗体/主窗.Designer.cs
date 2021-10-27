
namespace 数据库扩展
{
    partial class 运行窗体
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.分割 = new System.Windows.Forms.SplitContainer();
            this.表单 = new System.Windows.Forms.DataGridView();
            this.导航 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.分割)).BeginInit();
            this.分割.Panel1.SuspendLayout();
            this.分割.Panel2.SuspendLayout();
            this.分割.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.表单)).BeginInit();
            this.SuspendLayout();
            // 
            // 分割
            // 
            this.分割.Dock = System.Windows.Forms.DockStyle.Fill;
            this.分割.Location = new System.Drawing.Point(0, 0);
            this.分割.Name = "分割";
            // 
            // 分割.Panel1
            // 
            this.分割.Panel1.Controls.Add(this.导航);
            // 
            // 分割.Panel2
            // 
            this.分割.Panel2.Controls.Add(this.表单);
            this.分割.Size = new System.Drawing.Size(1262, 906);
            this.分割.SplitterDistance = 420;
            this.分割.TabIndex = 0;
            // 
            // 表单
            // 
            this.表单.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.表单.Dock = System.Windows.Forms.DockStyle.Fill;
            this.表单.Location = new System.Drawing.Point(0, 0);
            this.表单.Name = "表单";
            this.表单.RowHeadersWidth = 62;
            this.表单.RowTemplate.Height = 32;
            this.表单.Size = new System.Drawing.Size(838, 906);
            this.表单.TabIndex = 0;
            // 
            // 导航
            // 
            this.导航.Dock = System.Windows.Forms.DockStyle.Fill;
            this.导航.Location = new System.Drawing.Point(0, 0);
            this.导航.Name = "导航";
            this.导航.Size = new System.Drawing.Size(420, 906);
            this.导航.TabIndex = 0;
            // 
            // 主窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 906);
            this.Controls.Add(this.分割);
            this.Name = "主窗";
            this.Text = "数据库管理";
            this.分割.Panel1.ResumeLayout(false);
            this.分割.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.分割)).EndInit();
            this.分割.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.表单)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer 分割;
        private System.Windows.Forms.DataGridView 表单;
        private System.Windows.Forms.TreeView 导航;
    }
}

