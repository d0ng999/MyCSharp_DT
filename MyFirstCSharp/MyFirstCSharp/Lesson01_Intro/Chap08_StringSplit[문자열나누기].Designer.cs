namespace MyFirstCSharp
{
    partial class Chap08_StringSplit
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
            this.lblKorea = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKorea
            // 
            this.lblKorea.AutoSize = true;
            this.lblKorea.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKorea.Location = new System.Drawing.Point(12, 9);
            this.lblKorea.Name = "lblKorea";
            this.lblKorea.Size = new System.Drawing.Size(255, 23);
            this.lblKorea.TabIndex = 1;
            this.lblKorea.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInterpolation);
            this.groupBox4.Location = new System.Drawing.Point(16, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 78);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "문자열 보간";
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(7, 21);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(187, 45);
            this.btnInterpolation.TabIndex = 1;
            this.btnInterpolation.Text = "$";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLength);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Location = new System.Drawing.Point(16, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length()";
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(7, 49);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(187, 45);
            this.btnLength.TabIndex = 1;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(7, 21);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(187, 21);
            this.txtLength.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSplit);
            this.groupBox2.Location = new System.Drawing.Point(16, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Split()";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(7, 21);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(187, 34);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubstring);
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Location = new System.Drawing.Point(16, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 109);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Substring()";
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(6, 69);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(187, 34);
            this.btnSubstring.TabIndex = 0;
            this.btnSubstring.Text = "SubString";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(7, 20);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(187, 21);
            this.txtIndex.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(7, 42);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(187, 21);
            this.txtCount.TabIndex = 0;
            // 
            // Chap08_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblKorea);
            this.Name = "Chap08_StringSplit";
            this.Text = "문자열 나누기";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorea;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtIndex;
    }
}