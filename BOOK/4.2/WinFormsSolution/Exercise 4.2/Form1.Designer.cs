
namespace Exercise_4._2
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
            this.NewAddButton = new System.Windows.Forms.Button();
            this.DeleteAdButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AdsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NewAddButton
            // 
            this.NewAddButton.Location = new System.Drawing.Point(12, 238);
            this.NewAddButton.Name = "NewAddButton";
            this.NewAddButton.Size = new System.Drawing.Size(75, 23);
            this.NewAddButton.TabIndex = 1;
            this.NewAddButton.Text = "New ad";
            this.NewAddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAdButton
            // 
            this.DeleteAdButton.Location = new System.Drawing.Point(162, 238);
            this.DeleteAdButton.Name = "DeleteAdButton";
            this.DeleteAdButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteAdButton.TabIndex = 2;
            this.DeleteAdButton.Text = "Delete ad";
            this.DeleteAdButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(309, 238);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export to txt";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(454, 238);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // AdsListBox
            // 
            this.AdsListBox.FormattingEnabled = true;
            this.AdsListBox.Location = new System.Drawing.Point(12, 13);
            this.AdsListBox.Name = "AdsListBox";
            this.AdsListBox.Size = new System.Drawing.Size(517, 212);
            this.AdsListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 276);
            this.Controls.Add(this.AdsListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.DeleteAdButton);
            this.Controls.Add(this.NewAddButton);
            this.Name = "Form1";
            this.Text = "Job ads";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewAddButton;
        private System.Windows.Forms.Button DeleteAdButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox AdsListBox;
    }
}

