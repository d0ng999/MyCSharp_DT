namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_01
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
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "1차원 배열에 나열된 정수 중\r\n2개의 데이터를 추출하여 합한 값이 16이 되는 쌍을 모두 구하시오\r\n\r\n{ 1, 4, 6, 9, 10, 12, " +
    "16 }\r\n\r\n* 중복되는 데이터 쌍을 허용한다.\r\n- (4와 12) , (12와 4)";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(13, 118);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(363, 45);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "16쌍 구하기";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // Chap20_MiddleTest_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_01";
            this.Text = "16이 되는 쌍구하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutput;
    }
}