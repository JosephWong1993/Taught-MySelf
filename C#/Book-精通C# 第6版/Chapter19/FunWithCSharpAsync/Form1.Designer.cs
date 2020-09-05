namespace FunWithCSharpAsync
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVoidMethodCall = new System.Windows.Forms.Button();
            this.btnMutliAwaits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(30, 60);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(120, 23);
            this.btnCallMethod.TabIndex = 0;
            this.btnCallMethod.Text = "btnCallMethod";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btnVoidMethodCall
            // 
            this.btnVoidMethodCall.Location = new System.Drawing.Point(30, 90);
            this.btnVoidMethodCall.Name = "btnVoidMethodCall";
            this.btnVoidMethodCall.Size = new System.Drawing.Size(120, 23);
            this.btnVoidMethodCall.TabIndex = 2;
            this.btnVoidMethodCall.Text = "btnVoidMethodCall";
            this.btnVoidMethodCall.UseVisualStyleBackColor = true;
            this.btnVoidMethodCall.Click += new System.EventHandler(this.btnVoidMethodCall_Click);
            // 
            // btnMutliAwaits
            // 
            this.btnMutliAwaits.Location = new System.Drawing.Point(30, 120);
            this.btnMutliAwaits.Name = "btnMutliAwaits";
            this.btnMutliAwaits.Size = new System.Drawing.Size(120, 23);
            this.btnMutliAwaits.TabIndex = 3;
            this.btnMutliAwaits.Text = "button1";
            this.btnMutliAwaits.UseVisualStyleBackColor = true;
            this.btnMutliAwaits.Click += new System.EventHandler(this.btnMutliAwaits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMutliAwaits);
            this.Controls.Add(this.btnVoidMethodCall);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCallMethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVoidMethodCall;
        private System.Windows.Forms.Button btnMutliAwaits;
    }
}

