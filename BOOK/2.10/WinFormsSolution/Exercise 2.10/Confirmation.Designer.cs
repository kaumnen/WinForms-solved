
namespace Exercise_2._10
{
    partial class Confirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // DataRichTextBox
            // 
            this.DataRichTextBox.Location = new System.Drawing.Point(12, 25);
            this.DataRichTextBox.Name = "DataRichTextBox";
            this.DataRichTextBox.Size = new System.Drawing.Size(308, 96);
            this.DataRichTextBox.TabIndex = 1;
            this.DataRichTextBox.Text = "";
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(12, 127);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveButton.TabIndex = 2;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(245, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 165);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.DataRichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DataRichTextBox;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}