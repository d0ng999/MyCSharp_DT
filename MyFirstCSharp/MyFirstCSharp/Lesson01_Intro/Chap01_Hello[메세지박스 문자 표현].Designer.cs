﻿namespace MyFirstCSharp
{
    partial class Chap01_Hello
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(12, 12);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(213, 69);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "안녕하세요 메세지 표현하기";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "반갑습니다";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "자기소개";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "이름나타내기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Chap01_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHello);
            this.Name = "Chap01_Hello";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Chap01_Hello_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

