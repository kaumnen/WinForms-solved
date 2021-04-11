
namespace Exercise_4._1
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
            this.GuestsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestsRichTextBox
            // 
            this.GuestsRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.GuestsRichTextBox.Name = "GuestsRichTextBox";
            this.GuestsRichTextBox.Size = new System.Drawing.Size(481, 217);
            this.GuestsRichTextBox.TabIndex = 0;
            this.GuestsRichTextBox.Text = "";
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(12, 235);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(75, 23);
            this.AddGuestButton.TabIndex = 1;
            this.AddGuestButton.Text = "Add guest";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(142, 235);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(75, 23);
            this.RejectButton.TabIndex = 2;
            this.RejectButton.Text = "Reject guest";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(275, 235);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export to txt";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(418, 235);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 269);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.GuestsRichTextBox);
            this.Name = "Form1";
            this.Text = "Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox GuestsRichTextBox;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

