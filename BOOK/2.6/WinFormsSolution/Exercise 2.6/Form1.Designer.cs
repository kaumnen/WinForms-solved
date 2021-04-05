
namespace Exercise_2._6
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
            this.StartingTextBox = new System.Windows.Forms.TextBox();
            this.OpenNewFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartingTextBox
            // 
            this.StartingTextBox.Location = new System.Drawing.Point(40, 59);
            this.StartingTextBox.Name = "StartingTextBox";
            this.StartingTextBox.Size = new System.Drawing.Size(331, 20);
            this.StartingTextBox.TabIndex = 0;
            // 
            // OpenNewFormButton
            // 
            this.OpenNewFormButton.Location = new System.Drawing.Point(149, 106);
            this.OpenNewFormButton.Name = "OpenNewFormButton";
            this.OpenNewFormButton.Size = new System.Drawing.Size(98, 23);
            this.OpenNewFormButton.TabIndex = 1;
            this.OpenNewFormButton.Text = "Open new form";
            this.OpenNewFormButton.UseVisualStyleBackColor = true;
            this.OpenNewFormButton.Click += new System.EventHandler(this.OpenNewFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 172);
            this.Controls.Add(this.OpenNewFormButton);
            this.Controls.Add(this.StartingTextBox);
            this.Name = "Form1";
            this.Text = "Data transfer - starting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartingTextBox;
        private System.Windows.Forms.Button OpenNewFormButton;
    }
}

