namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_04
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
            this.btnFindResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 문자열에 포함된 수를 정수 배열로 만들고,\r\n낮은 수부터 중복되는 첫번째 값과\r\n세번째 값을 메세지 박스로 나타내세요.\r\n\r\n* 배열을 생성" +
    "할 때에 아래 lblTitle의 내용을 받아서 배열로 만들것";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(14, 125);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{1, 2, 13, 15, 17, 23, 8, 15, 8, 19, 3, 8, 13}";
            // 
            // btnFindResult
            // 
            this.btnFindResult.Location = new System.Drawing.Point(16, 161);
            this.btnFindResult.Name = "btnFindResult";
            this.btnFindResult.Size = new System.Drawing.Size(450, 42);
            this.btnFindResult.TabIndex = 2;
            this.btnFindResult.Text = "중복값 찾기";
            this.btnFindResult.UseVisualStyleBackColor = true;
            this.btnFindResult.Click += new System.EventHandler(this.btnFindResult_Click);
            // 
            // Chap20_MiddleTest_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnFindResult);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_04";
            this.Text = "중복값 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFindResult;
    }
}