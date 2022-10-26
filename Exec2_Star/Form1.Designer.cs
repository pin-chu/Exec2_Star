namespace Exec2_Star
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.showTextBox = new System.Windows.Forms.TextBox();
            this.calcbutton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showTextBox
            // 
            this.showTextBox.Location = new System.Drawing.Point(101, 167);
            this.showTextBox.Multiline = true;
            this.showTextBox.Name = "showTextBox";
            this.showTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.showTextBox.Size = new System.Drawing.Size(296, 258);
            this.showTextBox.TabIndex = 0;
            this.showTextBox.WordWrap = false;
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(322, 111);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(75, 23);
            this.calcbutton.TabIndex = 1;
            this.calcbutton.Text = "輸入";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(101, 111);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(149, 22);
            this.inputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 488);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.showTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showTextBox;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

