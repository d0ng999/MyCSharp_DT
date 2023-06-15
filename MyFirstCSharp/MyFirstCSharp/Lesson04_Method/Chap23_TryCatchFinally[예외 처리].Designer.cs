namespace MyFirstCSharp
{
    partial class Chap23_TryCatchFinally
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
            this.btnSystemError = new System.Windows.Forms.Button();
            this.btnTryCatch = new System.Windows.Forms.Button();
            this.btnMethodException = new System.Windows.Forms.Button();
            this.btnException = new System.Windows.Forms.Button();
            this.btnFinally = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSystemError
            // 
            this.btnSystemError.Location = new System.Drawing.Point(12, 12);
            this.btnSystemError.Name = "btnSystemError";
            this.btnSystemError.Size = new System.Drawing.Size(134, 124);
            this.btnSystemError.TabIndex = 0;
            this.btnSystemError.Text = "시스템 오류 발생";
            this.btnSystemError.UseVisualStyleBackColor = true;
            this.btnSystemError.Click += new System.EventHandler(this.btnSystemError_Click);
            // 
            // btnTryCatch
            // 
            this.btnTryCatch.Location = new System.Drawing.Point(152, 12);
            this.btnTryCatch.Name = "btnTryCatch";
            this.btnTryCatch.Size = new System.Drawing.Size(134, 124);
            this.btnTryCatch.TabIndex = 0;
            this.btnTryCatch.Text = "예외 처리";
            this.btnTryCatch.UseVisualStyleBackColor = true;
            this.btnTryCatch.Click += new System.EventHandler(this.btnTryCatch_Click);
            // 
            // btnMethodException
            // 
            this.btnMethodException.Location = new System.Drawing.Point(292, 12);
            this.btnMethodException.Name = "btnMethodException";
            this.btnMethodException.Size = new System.Drawing.Size(134, 124);
            this.btnMethodException.TabIndex = 0;
            this.btnMethodException.Text = "메서드의 예외 처리";
            this.btnMethodException.UseVisualStyleBackColor = true;
            this.btnMethodException.Click += new System.EventHandler(this.btnMethodException_Click);
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(432, 12);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(134, 124);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "Exception";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // btnFinally
            // 
            this.btnFinally.Location = new System.Drawing.Point(572, 12);
            this.btnFinally.Name = "btnFinally";
            this.btnFinally.Size = new System.Drawing.Size(134, 124);
            this.btnFinally.TabIndex = 0;
            this.btnFinally.Text = "Finally";
            this.btnFinally.UseVisualStyleBackColor = true;
            this.btnFinally.Click += new System.EventHandler(this.btnFinally_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(12, 142);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(134, 124);
            this.btnThrow.TabIndex = 0;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // Chap23_TryCatchFinally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinally);
            this.Controls.Add(this.btnException);
            this.Controls.Add(this.btnMethodException);
            this.Controls.Add(this.btnTryCatch);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnSystemError);
            this.Name = "Chap23_TryCatchFinally";
            this.Text = "Chap23_TryCatchFinally";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemError;
        private System.Windows.Forms.Button btnTryCatch;
        private System.Windows.Forms.Button btnMethodException;
        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.Button btnFinally;
        private System.Windows.Forms.Button btnThrow;
    }
}