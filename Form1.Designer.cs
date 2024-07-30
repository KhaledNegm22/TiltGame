
namespace WindowsFormsApp1
{
    partial class Game
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
            this.Next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.boardInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Asset_1;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.Cursor = System.Windows.Forms.Cursors.Default;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(647, 388);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(131, 67);
            this.Next.TabIndex = 0;
            this.Next.Tag = "NextButton";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseEnter += new System.EventHandler(this.Next_MouseEnter);
            this.Next.MouseLeave += new System.EventHandler(this.Next_MouseLeave);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.previous.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Asset_2;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.Cursor = System.Windows.Forms.Cursors.Default;
            this.previous.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(12, 388);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(140, 67);
            this.previous.TabIndex = 1;
            this.previous.Tag = "PreviousButton";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Visible = false;
            this.previous.Click += new System.EventHandler(this.previos_Click);
            this.previous.MouseEnter += new System.EventHandler(this.previous_MouseEnter);
            this.previous.MouseLeave += new System.EventHandler(this.previous_MouseLeave);
            // 
            // boardInfo
            // 
            this.boardInfo.Location = new System.Drawing.Point(647, 24);
            this.boardInfo.Multiline = true;
            this.boardInfo.Name = "boardInfo";
            this.boardInfo.Size = new System.Drawing.Size(131, 358);
            this.boardInfo.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.boardInfo);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.Next);
            this.MaximumSize = new System.Drawing.Size(808, 514);
            this.MinimumSize = new System.Drawing.Size(808, 514);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox boardInfo;
    }
}

