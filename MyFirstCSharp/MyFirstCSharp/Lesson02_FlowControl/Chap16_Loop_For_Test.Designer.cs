namespace MyFirstCSharp
{
    partial class Chap16_Loop_For_Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvenResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOddResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력받은 범위의 수 중\r\n짝수의 합과 홀수의 합을 구하여 메세지 박스로 표현\r\n짝수합 : ??? // 홀수합 : ???\r\n\r\n범위안에 있는 모든 " +
    "짝수와 홀수의 정보를 텍스트박스에 표현\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력 값 : ";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(79, 155);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 21);
            this.txtStart.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "~";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(205, 155);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 21);
            this.txtEnd.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(79, 183);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(226, 53);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "짝수 홀수 합 표현하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "범위안의 짝수";
            // 
            // txtEvenResult
            // 
            this.txtEvenResult.Location = new System.Drawing.Point(18, 264);
            this.txtEvenResult.Name = "txtEvenResult";
            this.txtEvenResult.Size = new System.Drawing.Size(531, 21);
            this.txtEvenResult.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "범위안의 홀수";
            // 
            // txtOddResult
            // 
            this.txtOddResult.Location = new System.Drawing.Point(18, 312);
            this.txtOddResult.Name = "txtOddResult";
            this.txtOddResult.Size = new System.Drawing.Size(531, 21);
            this.txtOddResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "* 입력 범위는 숫자만 입력 가능\r\n* 시작 숫자가 종료 숫자보다 크거나 같을 수 없다\r\n* Validation 체크의 결과를 메세지 박스로 표현" +
    "";
            // 
            // Chap16_Loop_For_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtOddResult);
            this.Controls.Add(this.txtEvenResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap16_Loop_For_Test";
            this.Text = "짝수 홀수 합 표현하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEvenResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOddResult;
        private System.Windows.Forms.Label label6;
    }
}