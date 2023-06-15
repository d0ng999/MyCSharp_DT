namespace MyFirstCSharp
{
    partial class Chap17_Array2
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
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(13, 83);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(775, 355);
            this.txtMatrix.TabIndex = 0;
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(13, 13);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(775, 64);
            this.btnMatrix.TabIndex = 1;
            this.btnMatrix.Text = "2차원 배열";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // Chap17_Array2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.txtMatrix);
            this.Name = "Chap17_Array2";
            this.Text = "2차원 배열";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Button btnMatrix;
    }
}