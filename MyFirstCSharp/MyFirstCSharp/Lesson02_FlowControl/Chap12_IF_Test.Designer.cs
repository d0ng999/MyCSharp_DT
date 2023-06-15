namespace MyFirstCSharp
{
    partial class Chap12_IF_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnTF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMulAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력받을 값";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(166, 13);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(201, 21);
            this.txtNum.TabIndex = 1;
            // 
            // btnTF
            // 
            this.btnTF.Location = new System.Drawing.Point(373, 12);
            this.btnTF.Name = "btnTF";
            this.btnTF.Size = new System.Drawing.Size(136, 76);
            this.btnTF.TabIndex = 2;
            this.btnTF.Text = "2 또는 5의 공배수인지 판단";
            this.btnTF.UseVisualStyleBackColor = true;
            this.btnTF.Click += new System.EventHandler(this.btnTF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "8의 배수일 경우 값과의 곱";
            // 
            // txtMulAdd
            // 
            this.txtMulAdd.Location = new System.Drawing.Point(166, 41);
            this.txtMulAdd.Name = "txtMulAdd";
            this.txtMulAdd.Size = new System.Drawing.Size(201, 21);
            this.txtMulAdd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(547, 120);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(166, 67);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(201, 21);
            this.txtCount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "버튼을 클릭한 횟수\r\n";
            // 
            // Chap12_IF_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTF);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtMulAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF_Test";
            this.Text = "분기문 IF 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnTF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMulAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label4;
    }
}