namespace MyFirstCSharp
{
    partial class Chap17_MatrixText
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
            this.btnMatrix = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2, 4 배열을 만들고\r\n\r\n1행과 2행을 바꾸어 새로운 배열에 담아 \r\n\r\n배열의 결과를 텍스트 박스에 표현하시오!\r\n\r\n[ 1, 2, " +
    "3, 4      = >    [5, 6, 7, 8\r\n  5, 6, 7, 8 ]              1, 2, 3, 4 ]";
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(14, 119);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(227, 50);
            this.btnMatrix.TabIndex = 1;
            this.btnMatrix.Text = "행과 열 바꾸기";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(14, 175);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(227, 140);
            this.txtMatrix.TabIndex = 2;
            // 
            // Chap17_MatrixText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 331);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_MatrixText";
            this.Text = "배열 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.TextBox txtMatrix;
    }
}