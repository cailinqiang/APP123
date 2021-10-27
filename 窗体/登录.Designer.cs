
namespace 数据库扩展
{
    partial class 登录窗体
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.平台标签 = new System.Windows.Forms.Label();
            this.平台 = new System.Windows.Forms.ComboBox();
            this.项目标签 = new System.Windows.Forms.Label();
            this.项目 = new System.Windows.Forms.ComboBox();
            this.用户标签 = new System.Windows.Forms.Label();
            this.用户 = new System.Windows.Forms.ComboBox();
            this.密码标签 = new System.Windows.Forms.Label();
            this.密码 = new System.Windows.Forms.TextBox();
            this.登录按钮 = new System.Windows.Forms.Button();
            this.退出按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 平台标签
            // 
            this.平台标签.AutoSize = true;
            this.平台标签.Location = new System.Drawing.Point(69, 98);
            this.平台标签.Name = "平台标签";
            this.平台标签.Size = new System.Drawing.Size(82, 24);
            this.平台标签.TabIndex = 0;
            this.平台标签.Text = "平台名称";
            // 
            // 平台
            // 
            this.平台.FormattingEnabled = true;
            this.平台.Location = new System.Drawing.Point(183, 95);
            this.平台.Name = "平台";
            this.平台.Size = new System.Drawing.Size(541, 32);
            this.平台.TabIndex = 1;
            // 
            // 项目标签
            // 
            this.项目标签.AutoSize = true;
            this.项目标签.Location = new System.Drawing.Point(69, 165);
            this.项目标签.Name = "项目标签";
            this.项目标签.Size = new System.Drawing.Size(82, 24);
            this.项目标签.TabIndex = 0;
            this.项目标签.Text = "项目名称";
            // 
            // 项目
            // 
            this.项目.FormattingEnabled = true;
            this.项目.Location = new System.Drawing.Point(183, 162);
            this.项目.Name = "项目";
            this.项目.Size = new System.Drawing.Size(541, 32);
            this.项目.TabIndex = 1;
            // 
            // 用户标签
            // 
            this.用户标签.AutoSize = true;
            this.用户标签.Location = new System.Drawing.Point(69, 226);
            this.用户标签.Name = "用户标签";
            this.用户标签.Size = new System.Drawing.Size(82, 24);
            this.用户标签.TabIndex = 0;
            this.用户标签.Text = "用户名称";
            // 
            // 用户
            // 
            this.用户.FormattingEnabled = true;
            this.用户.Location = new System.Drawing.Point(183, 223);
            this.用户.Name = "用户";
            this.用户.Size = new System.Drawing.Size(541, 32);
            this.用户.TabIndex = 1;
            // 
            // 密码标签
            // 
            this.密码标签.AutoSize = true;
            this.密码标签.Location = new System.Drawing.Point(69, 285);
            this.密码标签.Name = "密码标签";
            this.密码标签.Size = new System.Drawing.Size(82, 24);
            this.密码标签.TabIndex = 0;
            this.密码标签.Text = "登录密码";
            // 
            // 密码
            // 
            this.密码.Location = new System.Drawing.Point(183, 279);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(541, 30);
            this.密码.TabIndex = 2;
            // 
            // 登录按钮
            // 
            this.登录按钮.Location = new System.Drawing.Point(450, 392);
            this.登录按钮.Name = "登录按钮";
            this.登录按钮.Size = new System.Drawing.Size(112, 34);
            this.登录按钮.TabIndex = 3;
            this.登录按钮.Text = "登录";
            this.登录按钮.UseVisualStyleBackColor = true;
            this.登录按钮.Click += new System.EventHandler(this.登录按钮_Click);
            // 
            // 退出按钮
            // 
            this.退出按钮.Location = new System.Drawing.Point(612, 392);
            this.退出按钮.Name = "退出按钮";
            this.退出按钮.Size = new System.Drawing.Size(112, 34);
            this.退出按钮.TabIndex = 3;
            this.退出按钮.Text = "退出";
            this.退出按钮.UseVisualStyleBackColor = true;
            // 
            // 登录窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.退出按钮);
            this.Controls.Add(this.登录按钮);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.用户);
            this.Controls.Add(this.密码标签);
            this.Controls.Add(this.用户标签);
            this.Controls.Add(this.项目);
            this.Controls.Add(this.项目标签);
            this.Controls.Add(this.平台);
            this.Controls.Add(this.平台标签);
            this.Name = "登录窗体";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 平台标签;
        private System.Windows.Forms.ComboBox 平台;
        private System.Windows.Forms.Label 项目标签;
        private System.Windows.Forms.ComboBox 项目;
        private System.Windows.Forms.Label 用户标签;
        private System.Windows.Forms.ComboBox 用户;
        private System.Windows.Forms.Label 密码标签;
        private System.Windows.Forms.TextBox 密码;
        private System.Windows.Forms.Button 登录按钮;
        private System.Windows.Forms.Button 退出按钮;
    }
}