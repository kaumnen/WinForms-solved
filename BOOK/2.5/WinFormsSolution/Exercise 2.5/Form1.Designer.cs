
namespace Exercise_2._5
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
            this.NonModalFormButton = new System.Windows.Forms.Button();
            this.ModalFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is starting form";
            // 
            // NonModalFormButton
            // 
            this.NonModalFormButton.Location = new System.Drawing.Point(58, 102);
            this.NonModalFormButton.Name = "NonModalFormButton";
            this.NonModalFormButton.Size = new System.Drawing.Size(131, 23);
            this.NonModalFormButton.TabIndex = 1;
            this.NonModalFormButton.Text = "Go to non-modal form";
            this.NonModalFormButton.UseVisualStyleBackColor = true;
            this.NonModalFormButton.Click += new System.EventHandler(this.NonModalFormButton_Click);
            // 
            // ModalFormButton
            // 
            this.ModalFormButton.Location = new System.Drawing.Point(58, 152);
            this.ModalFormButton.Name = "ModalFormButton";
            this.ModalFormButton.Size = new System.Drawing.Size(131, 23);
            this.ModalFormButton.TabIndex = 2;
            this.ModalFormButton.Text = "Go to modal form";
            this.ModalFormButton.UseVisualStyleBackColor = true;
            this.ModalFormButton.Click += new System.EventHandler(this.ModalFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 204);
            this.Controls.Add(this.ModalFormButton);
            this.Controls.Add(this.NonModalFormButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Modal-NonModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NonModalFormButton;
        private System.Windows.Forms.Button ModalFormButton;
    }
}

