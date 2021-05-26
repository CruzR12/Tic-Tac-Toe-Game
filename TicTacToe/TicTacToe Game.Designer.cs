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
            this.midright_btn = new System.Windows.Forms.Button();
            this.lowerleft_btn = new System.Windows.Forms.Button();
            this.lowermid_btn = new System.Windows.Forms.Button();
            this.lowerright_btn = new System.Windows.Forms.Button();
            this.p1_score = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperleft_btn
            // 
            this.upperleft_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.upperleft_btn.Location = new System.Drawing.Point(31, 91);
            this.upperleft_btn.Name = "upperleft_btn";
            this.upperleft_btn.Size = new System.Drawing.Size(75, 75);
            this.upperleft_btn.TabIndex = 0;
            this.upperleft_btn.UseVisualStyleBackColor = true;
            this.upperleft_btn.Click += new System.EventHandler(this.upperleft_btn_Click);
            // 
            // uppermid_btn
            // 
            this.uppermid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.uppermid_btn.Location = new System.Drawing.Point(128, 91);
            this.uppermid_btn.Name = "uppermid_btn";
            this.uppermid_btn.Size = new System.Drawing.Size(75, 75);
            this.uppermid_btn.TabIndex = 1;
            this.uppermid_btn.UseVisualStyleBackColor = true;
            this.uppermid_btn.Click += new System.EventHandler(this.uppermid_btn_Click);
            // 
            // upperright_btn
            // 
            this.upperright_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.upperright_btn.Location = new System.Drawing.Point(225, 91);
            this.upperright_btn.Name = "upperright_btn";
            this.upperright_btn.Size = new System.Drawing.Size(75, 75);
            this.upperright_btn.TabIndex = 2;
            this.upperright_btn.UseVisualStyleBackColor = true;
            this.upperright_btn.Click += new System.EventHandler(this.upperright_btn_Click);
            // 
            // midleft_btn
            // 
            this.midleft_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.midleft_btn.Location = new System.Drawing.Point(31, 187);
            this.midleft_btn.Name = "midleft_btn";
            this.midleft_btn.Size = new System.Drawing.Size(75, 75);
            this.midleft_btn.TabIndex = 3;
            this.midleft_btn.UseVisualStyleBackColor = true;
            this.midleft_btn.Click += new System.EventHandler(this.midleft_btn_Click);
            // 
            // middle_btn
            // 
            this.middle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.middle_btn.Location = new System.Drawing.Point(128, 187);
            this.middle_btn.Name = "middle_btn";
            this.middle_btn.Size = new System.Drawing.Size(75, 75);
            this.middle_btn.TabIndex = 4;
            this.middle_btn.UseVisualStyleBackColor = true;
            this.middle_btn.Click += new System.EventHandler(this.middle_btn_Click);
            // 
            // midright_btn
            // 
            this.midright_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.midright_btn.Location = new System.Drawing.Point(225, 187);
            this.midright_btn.Name = "midright_btn";
            this.midright_btn.Size = new System.Drawing.Size(75, 75);
            this.midright_btn.TabIndex = 5;
            this.midright_btn.UseVisualStyleBackColor = true;
            this.midright_btn.Click += new System.EventHandler(this.midright_btn_Click);
            // 
            // lowerleft_btn
            // 
            this.lowerleft_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lowerleft_btn.Location = new System.Drawing.Point(31, 282);
            this.lowerleft_btn.Name = "lowerleft_btn";
            this.lowerleft_btn.Size = new System.Drawing.Size(75, 75);
            this.lowerleft_btn.TabIndex = 6;
            this.lowerleft_btn.UseVisualStyleBackColor = true;
            this.lowerleft_btn.Click += new System.EventHandler(this.lowerleft_btn_Click);
            // 
            // lowermid_btn
            // 
            this.lowermid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lowermid_btn.Location = new System.Drawing.Point(128, 282);
            this.lowermid_btn.Name = "lowermid_btn";
            this.lowermid_btn.Size = new System.Drawing.Size(75, 75);
            this.lowermid_btn.TabIndex = 7;
            this.lowermid_btn.UseVisualStyleBackColor = true;
            this.lowermid_btn.Click += new System.EventHandler(this.lowermid_btn_Click);
            // 
            // lowerright_btn
            // 
            this.lowerright_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lowerright_btn.Location = new System.Drawing.Point(225, 282);
            this.lowerright_btn.Name = "lowerright_btn";
            this.lowerright_btn.Size = new System.Drawing.Size(75, 75);
            this.lowerright_btn.TabIndex = 8;
            this.lowerright_btn.UseVisualStyleBackColor = true;
            this.lowerright_btn.Click += new System.EventHandler(this.lowerright_btn_Click);
            // 
            // p1_score
            // 
            this.p1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.p1_score.Location = new System.Drawing.Point(31, 41);
            this.p1_score.Multiline = true;
            this.p1_score.Name = "p1_score";
            this.p1_score.ReadOnly = true;
            this.p1_score.Size = new System.Drawing.Size(75, 31);
            this.p1_score.TabIndex = 9;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(128, 395);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 430);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.lowerright_btn);
            this.Controls.Add(this.lowermid_btn);
            this.Controls.Add(this.lowerleft_btn);
            this.Controls.Add(this.midright_btn);
            this.Controls.Add(this.middle_btn);
            this.Controls.Add(this.midleft_btn);
            this.Controls.Add(this.upperright_btn);
            this.Controls.Add(this.uppermid_btn);
            this.Controls.Add(this.upperleft_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upperleft_btn;
        private System.Windows.Forms.Button uppermid_btn;
        private System.Windows.Forms.Button upperright_btn;
        private System.Windows.Forms.Button midleft_btn;
        private System.Windows.Forms.Button middle_btn;
        private System.Windows.Forms.Button midright_btn;
        private System.Windows.Forms.Button lowerleft_btn;
        private System.Windows.Forms.Button lowermid_btn;
        private System.Windows.Forms.Button lowerright_btn;
        private System.Windows.Forms.TextBox p1_score;
        private System.Windows.Forms.Button reset_btn;
    }
}

