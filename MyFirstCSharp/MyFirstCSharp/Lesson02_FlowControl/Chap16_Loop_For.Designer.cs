namespace MyFirstCSharp
{
    partial class Chap16_Loop_For
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
            if (disposing && (components != null))
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
            this.btnForSum = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGuGu = new System.Windows.Forms.TextBox();
            this.btnGuGu = new System.Windows.Forms.Button();
            this.btnImmutable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForSum
            // 
            this.btnForSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForSum.Location = new System.Drawing.Point(0, 0);
            this.btnForSum.Name = "btnForSum";
            this.btnForSum.Size = new System.Drawing.Size(650, 67);
            this.btnForSum.TabIndex = 0;
            this.btnForSum.Text = "1~100까지 더하기";
            this.btnForSum.UseVisualStyleBackColor = true;
            this.btnForSum.Click += new System.EventHandler(this.btnForSum_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 67);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(650, 59);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "배열 값 더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGuGu
            // 
            this.txtGuGu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGuGu.Location = new System.Drawing.Point(0, 126);
            this.txtGuGu.Multiline = true;
            this.txtGuGu.Name = "txtGuGu";
            this.txtGuGu.Size = new System.Drawing.Size(650, 211);
            this.txtGuGu.TabIndex = 2;
            // 
            // btnGuGu
            // 
            this.btnGuGu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuGu.Location = new System.Drawing.Point(0, 337);
            this.btnGuGu.Name = "btnGuGu";
            this.btnGuGu.Size = new System.Drawing.Size(650, 37);
            this.btnGuGu.TabIndex = 3;
            this.btnGuGu.Text = "구구단 표현하기";
            this.btnGuGu.UseVisualStyleBackColor = true;
            this.btnGuGu.Click += new System.EventHandler(this.btnGuGu_Click);
            // 
            // btnImmutable
            // 
            this.btnImmutable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImmutable.Location = new System.Drawing.Point(0, 374);
            this.btnImmutable.Name = "btnImmutable";
            this.btnImmutable.Size = new System.Drawing.Size(650, 43);
            this.btnImmutable.TabIndex = 4;
            this.btnImmutable.Text = "Immutable";
            this.btnImmutable.UseVisualStyleBackColor = true;
            this.btnImmutable.Click += new System.EventHandler(this.btnImmutable_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 601);
            this.Controls.Add(this.btnImmutable);
            this.Controls.Add(this.btnGuGu);
            this.Controls.Add(this.txtGuGu);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnForSum);
            this.Name = "Chap16_Loop_For";
            this.Text = "Chap16_Loop_For";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForSum;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.TextBox txtGuGu;
        private System.Windows.Forms.Button btnGuGu;
        private System.Windows.Forms.Button btnImmutable;
    }
}