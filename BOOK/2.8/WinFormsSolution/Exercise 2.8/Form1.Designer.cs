
namespace Exercise_2._8
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
            this.TextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ChangeFolderButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // TextRichTextBox
            // 
            this.TextRichTextBox.Location = new System.Drawing.Point(16, 12);
            this.TextRichTextBox.Name = "TextRichTextBox";
            this.TextRichTextBox.Size = new System.Drawing.Size(420, 227);
            this.TextRichTextBox.TabIndex = 0;
            this.TextRichTextBox.Text = "";
            // 
            // ChangeFolderButton
            // 
            this.ChangeFolderButton.Location = new System.Drawing.Point(16, 245);
            this.ChangeFolderButton.Name = "ChangeFolderButton";
            this.ChangeFolderButton.Size = new System.Drawing.Size(96, 23);
            this.ChangeFolderButton.TabIndex = 1;
            this.ChangeFolderButton.Text = "Change Folder";
            this.ChangeFolderButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(118, 245);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(199, 245);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(280, 245);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 4;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(361, 245);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(75, 23);
            this.FontButton.TabIndex = 5;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ChangeFolderButton);
            this.Controls.Add(this.TextRichTextBox);
            this.Name = "Form1";
            this.Text = "Standard Windows dialogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextRichTextBox;
        private System.Windows.Forms.Button ChangeFolderButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

