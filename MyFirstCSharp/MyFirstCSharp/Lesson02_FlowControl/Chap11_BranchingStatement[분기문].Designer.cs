namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatement
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
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnInIf = new System.Windows.Forms.Button();
            this.btnElseIF = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnOrIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(13, 13);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(100, 21);
            this.txtBS.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(13, 41);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(100, 47);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(119, 41);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(100, 47);
            this.btnInIf.TabIndex = 1;
            this.btnInIf.Text = "In IF";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // btnElseIF
            // 
            this.btnElseIF.Location = new System.Drawing.Point(225, 41);
            this.btnElseIF.Name = "btnElseIF";
            this.btnElseIF.Size = new System.Drawing.Size(100, 47);
            this.btnElseIF.TabIndex = 1;
            this.btnElseIF.Text = "else If";
            this.btnElseIF.UseVisualStyleBackColor = true;
            this.btnElseIF.Click += new System.EventHandler(this.btnElseIF_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(331, 41);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(100, 47);
            this.btnAndIf.TabIndex = 1;
            this.btnAndIf.Text = "And If";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnOrIf
            // 
            this.btnOrIf.Location = new System.Drawing.Point(331, 94);
            this.btnOrIf.Name = "btnOrIf";
            this.btnOrIf.Size = new System.Drawing.Size(100, 47);
            this.btnOrIf.TabIndex = 1;
            this.btnOrIf.Text = "Or If";
            this.btnOrIf.UseVisualStyleBackColor = true;
            this.btnOrIf.Click += new System.EventHandler(this.btnOrIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(225, 94);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(100, 47);
            this.btnBoolIf.TabIndex = 1;
            this.btnBoolIf.Text = "BoolIf";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(13, 94);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(100, 46);
            this.btnPM.TabIndex = 2;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnOddEven
            // 
            this.btnOddEven.Location = new System.Drawing.Point(119, 94);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(100, 46);
            this.btnOddEven.TabIndex = 2;
            this.btnOddEven.Text = "홀수/짝수 판단";
            this.btnOddEven.UseVisualStyleBackColor = true;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(12, 146);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(100, 46);
            this.btnTernaryOperator.TabIndex = 2;
            this.btnTernaryOperator.Text = "삼항 연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // Chap11_BranchingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 202);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.btnElseIF);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.txtBS);
            this.Name = "Chap11_BranchingStatement";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnInIf;
        private System.Windows.Forms.Button btnElseIF;
        private System.Windows.Forms.Button btnAndIf;
        private System.Windows.Forms.Button btnOrIf;
        private System.Windows.Forms.Button btnBoolIf;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnTernaryOperator;
    }
}