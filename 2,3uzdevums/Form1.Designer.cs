namespace _2_3uzdevums
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
            this.labDatums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDatums
            // 
            this.labDatums.AutoSize = true;
            this.labDatums.Location = new System.Drawing.Point(29, 95);
            this.labDatums.Name = "labDatums";
            this.labDatums.Size = new System.Drawing.Size(35, 13);
            this.labDatums.TabIndex = 0;
            this.labDatums.Text = "label1";
            this.labDatums.Click += new System.EventHandler(this.labDatums_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labDatums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDatums;
    }
}

