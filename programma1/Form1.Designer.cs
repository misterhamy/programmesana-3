namespace programma1
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
            this.butBalts = new System.Windows.Forms.Button();
            this.butMelns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butBalts
            // 
            this.butBalts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butBalts.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butBalts.Location = new System.Drawing.Point(180, 241);
            this.butBalts.Name = "butBalts";
            this.butBalts.Size = new System.Drawing.Size(106, 48);
            this.butBalts.TabIndex = 0;
            this.butBalts.Text = "Balts";
            this.butBalts.UseVisualStyleBackColor = false;
            this.butBalts.Click += new System.EventHandler(this.butBalts_Click);
            // 
            // butMelns
            // 
            this.butMelns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butMelns.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butMelns.Location = new System.Drawing.Point(359, 241);
            this.butMelns.Name = "butMelns";
            this.butMelns.Size = new System.Drawing.Size(106, 48);
            this.butMelns.TabIndex = 1;
            this.butMelns.Text = "Melns";
            this.butMelns.UseVisualStyleBackColor = false;
            this.butMelns.Click += new System.EventHandler(this.butMelns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 427);
            this.Controls.Add(this.butMelns);
            this.Controls.Add(this.butBalts);
            this.Name = "Form1";
            this.Text = "melns";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBalts;
        private System.Windows.Forms.Button butMelns;
    }
}

