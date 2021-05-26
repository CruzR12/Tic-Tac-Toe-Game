namespace TicTacToe
{
    partial class Form1
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
            this.upperleft_btn = new System.Windows.Forms.Button();
            this.uppermid_btn = new System.Windows.Forms.Button();
            this.upperright_btn = new System.Windows.Forms.Button();
            this.midleft_btn = new System.Windows.Forms.Button();
            this.middle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperleft_btn
            // 
            this.upperleft_btn.Location = new System.Drawing.Point(31, 91);
            this.upperleft_btn.Name = "upperleft_btn";
            this.upperleft_btn.Size = new System.Drawing.Size(75, 75);
            this.upperleft_btn.TabIndex = 0;
            this.upperleft_btn.UseVisualStyleBackColor = true;
            // 
            // uppermid_btn
            // 
            this.uppermid_btn.Location = new System.Drawing.Point(128, 91);
            this.uppermid_btn.Name = "uppermid_btn";
            this.uppermid_btn.Size = new System.Drawing.Size(75, 75);
            this.uppermid_btn.TabIndex = 1;
            this.uppermid_btn.UseVisualStyleBackColor = true;
            // 
            // upperright_btn
            // 
            this.upperright_btn.Location = new System.Drawing.Point(225, 91);
            this.upperright_btn.Name = "upperright_btn";
            this.upperright_btn.Size = new System.Drawing.Size(75, 75);
            this.upperright_btn.TabIndex = 2;
            this.upperright_btn.UseVisualStyleBackColor = true;
            // 
            // midleft_btn
            // 
            this.midleft_btn.Location = new System.Drawing.Point(31, 187);
            this.midleft_btn.Name = "midleft_btn";
            this.midleft_btn.Size = new System.Drawing.Size(75, 75);
            this.midleft_btn.TabIndex = 3;
            this.midleft_btn.UseVisualStyleBackColor = true;
            // 
            // middle_btn
            // 
            this.middle_btn.Location = new System.Drawing.Point(128, 187);
            this.middle_btn.Name = "middle_btn";
            this.middle_btn.Size = new System.Drawing.Size(75, 75);
            this.middle_btn.TabIndex = 4;
            this.middle_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 373);
            this.Controls.Add(this.middle_btn);
            this.Controls.Add(this.midleft_btn);
            this.Controls.Add(this.upperright_btn);
            this.Controls.Add(this.uppermid_btn);
            this.Controls.Add(this.upperleft_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upperleft_btn;
        private System.Windows.Forms.Button uppermid_btn;
        private System.Windows.Forms.Button upperright_btn;
        private System.Windows.Forms.Button midleft_btn;
        private System.Windows.Forms.Button middle_btn;
    }
}

