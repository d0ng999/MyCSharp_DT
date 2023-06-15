namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test_T
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNameChange = new System.Windows.Forms.Button();
            this.btnFindSW = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(8, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1186, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnNameChange
            // 
            this.btnNameChange.Location = new System.Drawing.Point(20, 63);
            this.btnNameChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(234, 43);
            this.btnNameChange.TabIndex = 1;
            this.btnNameChange.Text = "OOO -> 본인 이름으로 변경\r\n * 라벨 TEXT 에 직접 변경해서 표현";
            this.btnNameChange.UseVisualStyleBackColor = true;
            this.btnNameChange.Click += new System.EventHandler(this.btnNameChange_Click);
            // 
            // btnFindSW
            // 
            this.btnFindSW.Location = new System.Drawing.Point(295, 63);
            this.btnFindSW.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindSW.Name = "btnFindSW";
            this.btnFindSW.Size = new System.Drawing.Size(232, 43);
            this.btnFindSW.TabIndex = 2;
            this.btnFindSW.Text = "\"S/W\" 의 위치 찾고 메세지박스\r\n * 구현은 In Line 으로 ";
            this.btnFindSW.UseVisualStyleBackColor = true;
            this.btnFindSW.Click += new System.EventHandler(this.btnFindSW_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(20, 110);
            this.btnIndex.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(234, 43);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "시작 단어 와 마지막 단어 각각 1자씩\r\n메세지 로 표현";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(295, 110);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(232, 43);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "타이틀 문자열 의 앞, 뒤 에 \r\n\"-DT-\" 문자열 삽입\r\n * 라벨 TEXT 에 직접 표현";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(20, 157);
            this.btnLower.Margin = new System.Windows.Forms.Padding(2);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(234, 43);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "DIGITALTRANING 만 소문자로 변경\r\n * DIGITALTRANING 문자는 고정\r\n * 라벨 TEXT 에 직접 표현";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(295, 157);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(232, 43);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "타이틀의 문자열의 모든 공백 없애기\r\n * 라벨 TEXT 에 직접 표현";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Location = new System.Drawing.Point(20, 206);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(507, 50);
            this.btnRollBack.TabIndex = 7;
            this.btnRollBack.Text = "원본 문자열 되돌리기";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // Chap09_StringManage_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 300);
            this.Controls.Add(this.btnRollBack);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnFindSW);
            this.Controls.Add(this.btnNameChange);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chap09_StringManage_Test_T";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNameChange;
        private System.Windows.Forms.Button btnFindSW;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnRollBack;
    }
}