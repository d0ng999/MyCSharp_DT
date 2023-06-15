namespace MyFirstCSharp
{
    partial class Chap22_Method
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
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnPaAr = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultPaRa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArrayArg = new System.Windows.Forms.Button();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnAryReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(11, 56);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(132, 59);
            this.btnMethodCall.TabIndex = 0;
            this.btnMethodCall.Text = "메서드 호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnPaAr
            // 
            this.btnPaAr.Location = new System.Drawing.Point(158, 56);
            this.btnPaAr.Name = "btnPaAr";
            this.btnPaAr.Size = new System.Drawing.Size(132, 59);
            this.btnPaAr.TabIndex = 0;
            this.btnPaAr.Text = "인수 인자";
            this.btnPaAr.UseVisualStyleBackColor = true;
            this.btnPaAr.Click += new System.EventHandler(this.btnPaAr_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(10, 121);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(132, 59);
            this.btnVoidReturn.TabIndex = 0;
            this.btnVoidReturn.Text = "Void Return";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(64, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 21);
            this.txtTitle.TabIndex = 2;
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(158, 121);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(132, 59);
            this.btnStringReturn.TabIndex = 0;
            this.btnStringReturn.Text = "String Return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(10, 186);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(132, 59);
            this.btnIntReturn.TabIndex = 0;
            this.btnIntReturn.Text = "Int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultPaRa
            // 
            this.btnDefaultPaRa.Location = new System.Drawing.Point(158, 186);
            this.btnDefaultPaRa.Name = "btnDefaultPaRa";
            this.btnDefaultPaRa.Size = new System.Drawing.Size(132, 59);
            this.btnDefaultPaRa.TabIndex = 0;
            this.btnDefaultPaRa.Text = "Default Parameter";
            this.btnDefaultPaRa.UseVisualStyleBackColor = true;
            this.btnDefaultPaRa.Click += new System.EventHandler(this.btnDefaultPaRa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAryReturn);
            this.groupBox1.Controls.Add(this.btnArrayArg);
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(297, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클래스를 인수로 전달하는 경우";
            // 
            // btnArrayArg
            // 
            this.btnArrayArg.Location = new System.Drawing.Point(7, 66);
            this.btnArrayArg.Name = "btnArrayArg";
            this.btnArrayArg.Size = new System.Drawing.Size(133, 58);
            this.btnArrayArg.TabIndex = 2;
            this.btnArrayArg.Text = "Array Argument";
            this.btnArrayArg.UseVisualStyleBackColor = true;
            this.btnArrayArg.Click += new System.EventHandler(this.btnArrayArg_Click);
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(147, 21);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(141, 38);
            this.btnCatch2.TabIndex = 1;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(7, 21);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(133, 38);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나 잡아봐라";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnAryReturn
            // 
            this.btnAryReturn.Location = new System.Drawing.Point(147, 66);
            this.btnAryReturn.Name = "btnAryReturn";
            this.btnAryReturn.Size = new System.Drawing.Size(141, 58);
            this.btnAryReturn.TabIndex = 3;
            this.btnAryReturn.Text = "ArrayReturn";
            this.btnAryReturn.UseVisualStyleBackColor = true;
            this.btnAryReturn.Click += new System.EventHandler(this.btnAryReturn_Click);
            // 
            // Chap22_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPaAr);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.btnDefaultPaRa);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnMethodCall);
            this.Name = "Chap22_Method";
            this.Text = "Method";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethodCall;
        private System.Windows.Forms.Button btnPaAr;
        private System.Windows.Forms.Button btnVoidReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnStringReturn;
        private System.Windows.Forms.Button btnIntReturn;
        private System.Windows.Forms.Button btnDefaultPaRa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCatch2;
        private System.Windows.Forms.Button btnCatch1;
        private System.Windows.Forms.Button btnArrayArg;
        private System.Windows.Forms.Button btnAryReturn;
    }
}