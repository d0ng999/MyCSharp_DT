namespace MyFirstCSharp
{
    partial class Chap22_Method01_Test_T
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
            this.btnTenM = new System.Windows.Forms.Button();
            this.btnFM = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTenM
            // 
            this.btnTenM.Location = new System.Drawing.Point(252, 163);
            this.btnTenM.Name = "btnTenM";
            this.btnTenM.Size = new System.Drawing.Size(112, 90);
            this.btnTenM.TabIndex = 9;
            this.btnTenM.Text = "10의 배수 표현";
            this.btnTenM.UseVisualStyleBackColor = true;
            this.btnTenM.Click += new System.EventHandler(this.btnTenM_Click);
            // 
            // btnFM
            // 
            this.btnFM.Location = new System.Drawing.Point(134, 163);
            this.btnFM.Name = "btnFM";
            this.btnFM.Size = new System.Drawing.Size(112, 90);
            this.btnFM.TabIndex = 10;
            this.btnFM.Text = "5의 배수 표현";
            this.btnFM.UseVisualStyleBackColor = true;
            this.btnFM.Click += new System.EventHandler(this.btnFM_Click);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(16, 163);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(112, 90);
            this.btnTM.TabIndex = 11;
            this.btnTM.Text = "2의 배수 표현";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(198, 125);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(70, 21);
            this.txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(102, 125);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(70, 21);
            this.txtStart.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "입력받을 범위";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "반복문을 (For, while)  한 번만 코딩하여 (소스내에서 반복문이 한번만 보이도록)\r\n범위안의 수 중 2, 5, 10의 배수의 합을 각 버" +
    "튼 클릭으로 메세지 박스로 표현하기\r\n  * 텍스트 박스의 문자는 숫자만 입력\r\n  * 음수는 입력받을 수 없다.\r\n";
            // 
            // Chap22_Method01_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTenM);
            this.Controls.Add(this.btnFM);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Method01_Test_T";
            this.Text = "Chap22_Method01_Test_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTenM;
        private System.Windows.Forms.Button btnFM;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}