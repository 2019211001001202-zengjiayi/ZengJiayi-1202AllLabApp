namespace LabAss2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(164, 103);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(100, 25);
            this.textNumber1.TabIndex = 0;
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(300, 103);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(100, 25);
            this.textNumber2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 25);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(355, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 25);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(300, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 25);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(164, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 25);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

