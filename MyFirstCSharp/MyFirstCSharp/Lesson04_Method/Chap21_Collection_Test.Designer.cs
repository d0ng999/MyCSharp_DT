namespace MyFirstCSharp
{
    partial class Chap21_Collection_Test
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnDicForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 문자열에서 중복되지 않는 문자 중 \r\n왼쪽에서 가장 첫 문자를 메세지박스로 나타내기\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(17, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCLD/EML/BAMDC/";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(17, 99);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(356, 52);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "자유 코딩";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(17, 157);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(356, 52);
            this.btnLastIndexOf.TabIndex = 2;
            this.btnLastIndexOf.Text = "LastIndexOf 방식";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnDicForeach
            // 
            this.btnDicForeach.Location = new System.Drawing.Point(17, 215);
            this.btnDicForeach.Name = "btnDicForeach";
            this.btnDicForeach.Size = new System.Drawing.Size(356, 52);
            this.btnDicForeach.TabIndex = 2;
            this.btnDicForeach.Text = "Dictionary 와 Foreach사용";
            this.btnDicForeach.UseVisualStyleBackColor = true;
            this.btnDicForeach.Click += new System.EventHandler(this.btnDicForeach_Click);
            // 
            // Chap21_Collection_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDicForeach);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "Chap21_Collection_Test";
            this.Text = "Collection을 이용한 중복찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnDicForeach;
    }
}