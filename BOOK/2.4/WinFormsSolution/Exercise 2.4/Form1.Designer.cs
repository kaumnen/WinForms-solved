
namespace Exercise_2._4
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
            this.TransportationTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.PerTransRadioButton = new System.Windows.Forms.RadioButton();
            this.BusRadioButton = new System.Windows.Forms.RadioButton();
            this.PlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.ChoiceTextBox = new System.Windows.Forms.TextBox();
            this.TransportationTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransportationTypeGroupBox
            // 
            this.TransportationTypeGroupBox.Controls.Add(this.PerTransRadioButton);
            this.TransportationTypeGroupBox.Controls.Add(this.BusRadioButton);
            this.TransportationTypeGroupBox.Controls.Add(this.PlaneRadioButton);
            this.TransportationTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TransportationTypeGroupBox.Name = "TransportationTypeGroupBox";
            this.TransportationTypeGroupBox.Size = new System.Drawing.Size(160, 113);
            this.TransportationTypeGroupBox.TabIndex = 0;
            this.TransportationTypeGroupBox.TabStop = false;
            this.TransportationTypeGroupBox.Text = "Transportation type";
            // 
            // PerTransRadioButton
            // 
            this.PerTransRadioButton.AutoSize = true;
            this.PerTransRadioButton.Location = new System.Drawing.Point(24, 81);
            this.PerTransRadioButton.Name = "PerTransRadioButton";
            this.PerTransRadioButton.Size = new System.Drawing.Size(114, 17);
            this.PerTransRadioButton.TabIndex = 2;
            this.PerTransRadioButton.TabStop = true;
            this.PerTransRadioButton.Text = "Personal Transport";
            this.PerTransRadioButton.UseVisualStyleBackColor = true;
            this.PerTransRadioButton.Click += new System.EventHandler(this.TransportationRadioButtonClickedUniversal_CheckedChanged);
            // 
            // BusRadioButton
            // 
            this.BusRadioButton.AutoSize = true;
            this.BusRadioButton.Location = new System.Drawing.Point(24, 57);
            this.BusRadioButton.Name = "BusRadioButton";
            this.BusRadioButton.Size = new System.Drawing.Size(43, 17);
            this.BusRadioButton.TabIndex = 1;
            this.BusRadioButton.TabStop = true;
            this.BusRadioButton.Text = "Bus";
            this.BusRadioButton.UseVisualStyleBackColor = true;
            this.BusRadioButton.Click += new System.EventHandler(this.TransportationRadioButtonClickedUniversal_CheckedChanged);
            // 
            // PlaneRadioButton
            // 
            this.PlaneRadioButton.AutoSize = true;
            this.PlaneRadioButton.Location = new System.Drawing.Point(24, 33);
            this.PlaneRadioButton.Name = "PlaneRadioButton";
            this.PlaneRadioButton.Size = new System.Drawing.Size(52, 17);
            this.PlaneRadioButton.TabIndex = 0;
            this.PlaneRadioButton.TabStop = true;
            this.PlaneRadioButton.Text = "Plane";
            this.PlaneRadioButton.UseVisualStyleBackColor = true;
            this.PlaneRadioButton.Click += new System.EventHandler(this.TransportationRadioButtonClickedUniversal_CheckedChanged);
            // 
            // ChoiceTextBox
            // 
            this.ChoiceTextBox.Location = new System.Drawing.Point(24, 150);
            this.ChoiceTextBox.Name = "ChoiceTextBox";
            this.ChoiceTextBox.Size = new System.Drawing.Size(296, 20);
            this.ChoiceTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 198);
            this.Controls.Add(this.ChoiceTextBox);
            this.Controls.Add(this.TransportationTypeGroupBox);
            this.Name = "Form1";
            this.Text = "Travel";
            this.TransportationTypeGroupBox.ResumeLayout(false);
            this.TransportationTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TransportationTypeGroupBox;
        private System.Windows.Forms.RadioButton PerTransRadioButton;
        private System.Windows.Forms.RadioButton BusRadioButton;
        private System.Windows.Forms.RadioButton PlaneRadioButton;
        private System.Windows.Forms.TextBox ChoiceTextBox;
    }
}

