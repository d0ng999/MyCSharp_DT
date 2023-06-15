namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblText.Location = new System.Drawing.Point(13, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(1125, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(17, 63);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(205, 70);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "OOO";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(228, 62);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(205, 70);
            this.btnIndex.TabIndex = 1;
            this.btnIndex.Text = "\"S/W\"의 위치를 찾고 메세지 박스로 표현(InLine)";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(439, 62);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(205, 70);
            this.btnLength.TabIndex = 1;
            this.btnLength.Text = "시작단어와 마지막 단어 각각 1자씩  메세지로 표현";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(17, 139);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(205, 70);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "타이틀 문자열의 앞, 뒤에 \"-DT-\" 문자열 삽입";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(228, 138);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(205, 70);
            this.btnLower.TabIndex = 1;
            this.btnLower.Text = "DIGITALTRAINING을 소문자로 변경";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(439, 138);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(205, 70);
            this.btnTrim.TabIndex = 1;
            this.btnTrim.Text = "타이틀의 문자열의 모든 공백 없애기";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(627, 73);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "원본 문자열 되돌리기";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 441);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblText);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnReset;
    }
}