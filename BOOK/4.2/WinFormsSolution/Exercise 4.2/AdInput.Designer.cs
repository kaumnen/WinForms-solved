
namespace Exercise_4._2
{
    partial class AdInput
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
            this.label2 = new System.Windows.Forms.Label();
            this.AcademicGroupBox = new System.Windows.Forms.GroupBox();
            this.PrimaryRadioButton = new System.Windows.Forms.RadioButton();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.CollegeRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.YOENumeric = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcademicGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YOENumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOE:";
            // 
            // AcademicGroupBox
            // 
            this.AcademicGroupBox.Controls.Add(this.CollegeRadioButton);
            this.AcademicGroupBox.Controls.Add(this.HighRadioButton);
            this.AcademicGroupBox.Controls.Add(this.PrimaryRadioButton);
            this.AcademicGroupBox.Location = new System.Drawing.Point(15, 64);
            this.AcademicGroupBox.Name = "AcademicGroupBox";
            this.AcademicGroupBox.Size = new System.Drawing.Size(103, 103);
            this.AcademicGroupBox.TabIndex = 2;
            this.AcademicGroupBox.TabStop = false;
            this.AcademicGroupBox.Text = "Academic level";
            // 
            // PrimaryRadioButton
            // 
            this.PrimaryRadioButton.AutoSize = true;
            this.PrimaryRadioButton.Location = new System.Drawing.Point(7, 20);
            this.PrimaryRadioButton.Name = "PrimaryRadioButton";
            this.PrimaryRadioButton.Size = new System.Drawing.Size(59, 17);
            this.PrimaryRadioButton.TabIndex = 0;
            this.PrimaryRadioButton.TabStop = true;
            this.PrimaryRadioButton.Text = "Primary";
            this.PrimaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(7, 44);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HighRadioButton.TabIndex = 1;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // CollegeRadioButton
            // 
            this.CollegeRadioButton.AutoSize = true;
            this.CollegeRadioButton.Location = new System.Drawing.Point(7, 68);
            this.CollegeRadioButton.Name = "CollegeRadioButton";
            this.CollegeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.CollegeRadioButton.TabIndex = 2;
            this.CollegeRadioButton.TabStop = true;
            this.CollegeRadioButton.Text = "College";
            this.CollegeRadioButton.UseVisualStyleBackColor = true;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(69, 25);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 3;
            // 
            // YOENumeric
            // 
            this.YOENumeric.Location = new System.Drawing.Point(60, 177);
            this.YOENumeric.Name = "YOENumeric";
            this.YOENumeric.Size = new System.Drawing.Size(52, 20);
            this.YOENumeric.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(15, 223);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(145, 222);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AdInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 256);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.YOENumeric);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.AcademicGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdInput";
            this.Text = "Ad input";
            this.AcademicGroupBox.ResumeLayout(false);
            this.AcademicGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YOENumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AcademicGroupBox;
        private System.Windows.Forms.RadioButton CollegeRadioButton;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton PrimaryRadioButton;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.NumericUpDown YOENumeric;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}