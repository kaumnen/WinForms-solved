
namespace Exercise_4._1
{
    partial class AddGuest
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
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.MembersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MealsGroupBox = new System.Windows.Forms.GroupBox();
            this.BreakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.LunchCheckBox = new System.Windows.Forms.CheckBox();
            this.DinnerCheckBox = new System.Windows.Forms.CheckBox();
            this.MealsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(68, 10);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(171, 20);
            this.SurnameTextBox.TabIndex = 0;
            // 
            // MembersComboBox
            // 
            this.MembersComboBox.FormattingEnabled = true;
            this.MembersComboBox.Location = new System.Drawing.Point(99, 56);
            this.MembersComboBox.Name = "MembersComboBox";
            this.MembersComboBox.Size = new System.Drawing.Size(47, 21);
            this.MembersComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. of members";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(19, 237);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(164, 237);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // MealsGroupBox
            // 
            this.MealsGroupBox.Controls.Add(this.DinnerCheckBox);
            this.MealsGroupBox.Controls.Add(this.LunchCheckBox);
            this.MealsGroupBox.Controls.Add(this.BreakfastCheckBox);
            this.MealsGroupBox.Location = new System.Drawing.Point(12, 105);
            this.MealsGroupBox.Name = "MealsGroupBox";
            this.MealsGroupBox.Size = new System.Drawing.Size(88, 100);
            this.MealsGroupBox.TabIndex = 8;
            this.MealsGroupBox.TabStop = false;
            this.MealsGroupBox.Text = "Meals";
            // 
            // BreakfastCheckBox
            // 
            this.BreakfastCheckBox.AutoSize = true;
            this.BreakfastCheckBox.Location = new System.Drawing.Point(7, 20);
            this.BreakfastCheckBox.Name = "BreakfastCheckBox";
            this.BreakfastCheckBox.Size = new System.Drawing.Size(71, 17);
            this.BreakfastCheckBox.TabIndex = 0;
            this.BreakfastCheckBox.Text = "Breakfast";
            this.BreakfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // LunchCheckBox
            // 
            this.LunchCheckBox.AutoSize = true;
            this.LunchCheckBox.Location = new System.Drawing.Point(7, 44);
            this.LunchCheckBox.Name = "LunchCheckBox";
            this.LunchCheckBox.Size = new System.Drawing.Size(56, 17);
            this.LunchCheckBox.TabIndex = 1;
            this.LunchCheckBox.Text = "Lunch";
            this.LunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // DinnerCheckBox
            // 
            this.DinnerCheckBox.AutoSize = true;
            this.DinnerCheckBox.Location = new System.Drawing.Point(7, 68);
            this.DinnerCheckBox.Name = "DinnerCheckBox";
            this.DinnerCheckBox.Size = new System.Drawing.Size(57, 17);
            this.DinnerCheckBox.TabIndex = 2;
            this.DinnerCheckBox.Text = "Dinner";
            this.DinnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 283);
            this.Controls.Add(this.MealsGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MembersComboBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Name = "AddGuest";
            this.Text = "Add guest";
            this.MealsGroupBox.ResumeLayout(false);
            this.MealsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.ComboBox MembersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox MealsGroupBox;
        private System.Windows.Forms.CheckBox DinnerCheckBox;
        private System.Windows.Forms.CheckBox LunchCheckBox;
        private System.Windows.Forms.CheckBox BreakfastCheckBox;
    }
}