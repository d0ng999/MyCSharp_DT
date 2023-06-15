namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_02_T
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
            this.btnResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(15, 118);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(361, 47);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "중복 미허용 합 20쌍 구하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 105);
            this.label1.TabIndex = 3;
            this.label1.Text = "2차원 배열에 나열된 정수 중\r\n2개의 데이터를 추출하여 합한 값이 20이 되는 쌍을 모두 구하시오\r\n\r\n{{ 1, 4, 6, 9, 10, 12," +
    " 16 },\r\n{ 2, 7, 11, 13, 14, 15, 16, 18 }}\r\n\r\n* 중복되는 데이터 쌍을 허용하지 않음";
            // 
            // Chap20_MiddleTest_02_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_02_T";
            this.Text = "Chap20_MiddleTest_02_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label1;
    }
}