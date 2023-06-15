namespace MyFirstCSharp
{
    partial class Chap25_RecursiveFunction_T
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.btnMemoization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "리스트를 사용하여 확인하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "번째 피보나치 수열 값";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 116);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "입력한 숫자의 피보나치 수열의 값을 구하는 로직을 구현하세요\r\n\r\n* 피보나치 수열 : 0과 1로 시작하는 n 번째 피보나치 수는 바로 직전 두 " +
    "수의 합을 나타내는 수열\r\n";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(374, 170);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(209, 51);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "외부변수를 이용하여 확인하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(374, 227);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(209, 51);
            this.btnRecursive.TabIndex = 7;
            this.btnRecursive.Text = "재귀함수를 이용한 구현";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // btnMemoization
            // 
            this.btnMemoization.Location = new System.Drawing.Point(374, 284);
            this.btnMemoization.Name = "btnMemoization";
            this.btnMemoization.Size = new System.Drawing.Size(209, 51);
            this.btnMemoization.TabIndex = 7;
            this.btnMemoization.Text = "메모화 기법을 통한 재귀함수 구현";
            this.btnMemoization.UseVisualStyleBackColor = true;
            this.btnMemoization.Click += new System.EventHandler(this.btnMemoization_Click);
            // 
            // Chap25_RecursiveFunction_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMemoization);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Name = "Chap25_RecursiveFunction_T";
            this.Text = "Chap25_RecursiveFunction_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.Button btnMemoization;
    }
}