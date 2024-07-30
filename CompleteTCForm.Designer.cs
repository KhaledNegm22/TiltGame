namespace WindowsFormsApp1
{
    partial class CompleteTCForm
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
            this.CTCFText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CTCFText
            // 
            this.CTCFText.BackColor = System.Drawing.SystemColors.MenuText;
            this.CTCFText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CTCFText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCFText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CTCFText.Location = new System.Drawing.Point(12, 12);
            this.CTCFText.Multiline = true;
            this.CTCFText.Name = "CTCFText";
            this.CTCFText.Size = new System.Drawing.Size(776, 426);
            this.CTCFText.TabIndex = 0;
            this.CTCFText.Text = "Complete Test Ran";
            this.CTCFText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompleteTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CTCFText);
            this.Name = "CompleteTCForm";
            this.Text = "CompleteTCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CTCFText;
    }
}