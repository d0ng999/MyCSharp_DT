namespace MyFirstCSharp
{
    partial class Chap30_Class_F
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
            this.btnClassCall = new System.Windows.Forms.Button();
            this.btnClass2 = new System.Windows.Forms.Button();
            this.btnFieldCall = new System.Windows.Forms.Button();
            this.btnFieldsCall2 = new System.Windows.Forms.Button();
            this.btnClassMethodCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassCall
            // 
            this.btnClassCall.Location = new System.Drawing.Point(13, 13);
            this.btnClassCall.Name = "btnClassCall";
            this.btnClassCall.Size = new System.Drawing.Size(199, 127);
            this.btnClassCall.TabIndex = 0;
            this.btnClassCall.Text = "클래스 객체 생성 및 호출";
            this.btnClassCall.UseVisualStyleBackColor = true;
            this.btnClassCall.Click += new System.EventHandler(this.btnClassCall_Click);
            // 
            // btnClass2
            // 
            this.btnClass2.Location = new System.Drawing.Point(218, 13);
            this.btnClass2.Name = "btnClass2";
            this.btnClass2.Size = new System.Drawing.Size(199, 127);
            this.btnClass2.TabIndex = 0;
            this.btnClass2.Text = "클래스 객체 생성 및 호출 2";
            this.btnClass2.UseVisualStyleBackColor = true;
            this.btnClass2.Click += new System.EventHandler(this.btnClass2_Click);
            // 
            // btnFieldCall
            // 
            this.btnFieldCall.Location = new System.Drawing.Point(423, 13);
            this.btnFieldCall.Name = "btnFieldCall";
            this.btnFieldCall.Size = new System.Drawing.Size(199, 127);
            this.btnFieldCall.TabIndex = 0;
            this.btnFieldCall.Text = "필드멤버 객체 전역변수 호출1";
            this.btnFieldCall.UseVisualStyleBackColor = true;
            this.btnFieldCall.Click += new System.EventHandler(this.btnFieldCall_Click);
            // 
            // btnFieldsCall2
            // 
            this.btnFieldsCall2.Location = new System.Drawing.Point(112, 146);
            this.btnFieldsCall2.Name = "btnFieldsCall2";
            this.btnFieldsCall2.Size = new System.Drawing.Size(199, 127);
            this.btnFieldsCall2.TabIndex = 0;
            this.btnFieldsCall2.Text = "필드멤버 객체 전역변수 호출2";
            this.btnFieldsCall2.UseVisualStyleBackColor = true;
            this.btnFieldsCall2.Click += new System.EventHandler(this.btnFieldsCall2_Click);
            // 
            // btnClassMethodCall
            // 
            this.btnClassMethodCall.Location = new System.Drawing.Point(317, 146);
            this.btnClassMethodCall.Name = "btnClassMethodCall";
            this.btnClassMethodCall.Size = new System.Drawing.Size(199, 127);
            this.btnClassMethodCall.TabIndex = 0;
            this.btnClassMethodCall.Text = "다른 클래스의 메서드 호출하기";
            this.btnClassMethodCall.UseVisualStyleBackColor = true;
            this.btnClassMethodCall.Click += new System.EventHandler(this.btnClassMethodCall_Click);
            // 
            // Chap30_Class_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClassMethodCall);
            this.Controls.Add(this.btnFieldsCall2);
            this.Controls.Add(this.btnFieldCall);
            this.Controls.Add(this.btnClass2);
            this.Controls.Add(this.btnClassCall);
            this.Name = "Chap30_Class_F";
            this.Text = "클래스";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassCall;
        private System.Windows.Forms.Button btnClass2;
        private System.Windows.Forms.Button btnFieldCall;
        private System.Windows.Forms.Button btnFieldsCall2;
        private System.Windows.Forms.Button btnClassMethodCall;
    }
}