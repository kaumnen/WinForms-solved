
namespace Exercise_2._7
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
            this.label1 = new System.Windows.Forms.Label();
            this.NonModalButton = new System.Windows.Forms.Button();
            this.ModalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is starting form";
            // 
            // NonModalButton
            // 
            this.NonModalButton.Location = new System.Drawing.Point(66, 127);
            this.NonModalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NonModalButton.Name = "NonModalButton";
            this.NonModalButton.Size = new System.Drawing.Size(176, 35);
            this.NonModalButton.TabIndex = 1;
            this.NonModalButton.Text = "Go to Non-modal form";
            this.NonModalButton.UseVisualStyleBackColor = true;
            this.NonModalButton.Click += new System.EventHandler(this.NonModalButton_Click);
            // 
            // ModalButton
            // 
            this.ModalButton.Location = new System.Drawing.Point(66, 212);
            this.ModalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModalButton.Name = "ModalButton";
            this.ModalButton.Size = new System.Drawing.Size(176, 35);
            this.ModalButton.TabIndex = 2;
            this.ModalButton.Text = "Go to Modal form";
            this.ModalButton.UseVisualStyleBackColor = true;
            this.ModalButton.Click += new System.EventHandler(this.ModalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 296);
            this.Controls.Add(this.ModalButton);
            this.Controls.Add(this.NonModalButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Starting form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NonModalButton;
        private System.Windows.Forms.Button ModalButton;
    }
}

