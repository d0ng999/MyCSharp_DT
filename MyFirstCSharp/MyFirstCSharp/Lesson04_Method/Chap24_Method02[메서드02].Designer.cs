namespace MyFirstCSharp
{
    partial class Chap24_Method02
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
            this.btnref = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnOverLoading = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnGenericMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnref
            // 
            this.btnref.Location = new System.Drawing.Point(13, 13);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(124, 99);
            this.btnref.TabIndex = 0;
            this.btnref.Text = "ref";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(143, 13);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(124, 99);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(273, 13);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(124, 99);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(403, 13);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(124, 99);
            this.btnTryParse.TabIndex = 0;
            this.btnTryParse.Text = "TryParse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnOverLoading
            // 
            this.btnOverLoading.Location = new System.Drawing.Point(273, 118);
            this.btnOverLoading.Name = "btnOverLoading";
            this.btnOverLoading.Size = new System.Drawing.Size(254, 99);
            this.btnOverLoading.TabIndex = 1;
            this.btnOverLoading.Text = "OverLoading";
            this.btnOverLoading.UseVisualStyleBackColor = true;
            this.btnOverLoading.Click += new System.EventHandler(this.btnOverLoading_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(12, 118);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(124, 99);
            this.btnParams.TabIndex = 0;
            this.btnParams.Text = "Params";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnGenericMethod
            // 
            this.btnGenericMethod.Location = new System.Drawing.Point(142, 118);
            this.btnGenericMethod.Name = "btnGenericMethod";
            this.btnGenericMethod.Size = new System.Drawing.Size(124, 99);
            this.btnGenericMethod.TabIndex = 0;
            this.btnGenericMethod.Text = "Generic Method";
            this.btnGenericMethod.UseVisualStyleBackColor = true;
            this.btnGenericMethod.Click += new System.EventHandler(this.btnGenericMethod_Click);
            // 
            // Chap24_Method02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOverLoading);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnGenericMethod);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnref);
            this.Name = "Chap24_Method02";
            this.Text = "메서드";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.Button btnOverLoading;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnGenericMethod;
    }
}