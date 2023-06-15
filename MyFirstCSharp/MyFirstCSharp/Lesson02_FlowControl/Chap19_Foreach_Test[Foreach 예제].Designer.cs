namespace MyFirstCSharp
{
    partial class Chap19_Foreach_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "1     2     3     4\r\n5     6     7     8\r\n9     10   11   12\r\n\r\n\r\n위의 3, 4 배열을 만들고" +
    "\r\n Foreach 기능을 이용하여 데이터 추출 후\r\n텍스트 박스에 같은 배치로 표현하기\r\n";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(15, 155);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(333, 214);
            this.txtMatrix.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(15, 122);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(333, 27);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "2차원배열 foreach로 표현하기";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Chap19_Foreach_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Chap19_Foreach_Test";
            this.Text = "배열 표현하기 Foreach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Button btnRun;
    }
}