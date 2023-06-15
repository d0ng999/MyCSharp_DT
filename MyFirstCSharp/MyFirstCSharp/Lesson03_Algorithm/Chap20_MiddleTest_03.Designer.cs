namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap20_MiddleTest_03));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeRandom = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnMakeRandom
            // 
            this.btnMakeRandom.Location = new System.Drawing.Point(13, 89);
            this.btnMakeRandom.Name = "btnMakeRandom";
            this.btnMakeRandom.Size = new System.Drawing.Size(504, 65);
            this.btnMakeRandom.TabIndex = 1;
            this.btnMakeRandom.Text = "난수 생성";
            this.btnMakeRandom.UseVisualStyleBackColor = true;
            this.btnMakeRandom.Click += new System.EventHandler(this.btnMakeRandom_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(15, 161);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(165, 21);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.Text = "0";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(186, 161);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(171, 21);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.Text = "0";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(363, 161);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(154, 21);
            this.txtNum3.TabIndex = 2;
            this.txtNum3.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 188);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(505, 65);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "세 수의 난수를 모두 받았을 경우, 순차적으로 첫번째 텍스트 박스에서 부터 난수를 표현한다.";
            // 
            // Chap20_MiddleTest_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnMakeRandom);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_03";
            this.Text = "난수 생성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeRandom;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label2;
    }
}