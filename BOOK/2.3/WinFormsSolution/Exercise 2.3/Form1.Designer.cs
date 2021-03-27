
namespace Exercise_2._3
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
            this.BreakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.LunchCheckBox = new System.Windows.Forms.CheckBox();
            this.DinnerCheckBox = new System.Windows.Forms.CheckBox();
            this.HideOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.OrderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MealsGroupBox = new System.Windows.Forms.GroupBox();
            this.MealsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreakfastCheckBox
            // 
            this.BreakfastCheckBox.AutoSize = true;
            this.BreakfastCheckBox.Location = new System.Drawing.Point(6, 40);
            this.BreakfastCheckBox.Name = "BreakfastCheckBox";
            this.BreakfastCheckBox.Size = new System.Drawing.Size(71, 17);
            this.BreakfastCheckBox.TabIndex = 0;
            this.BreakfastCheckBox.Text = "Breakfast";
            this.BreakfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // LunchCheckBox
            // 
            this.LunchCheckBox.AutoSize = true;
            this.LunchCheckBox.Location = new System.Drawing.Point(6, 93);
            this.LunchCheckBox.Name = "LunchCheckBox";
            this.LunchCheckBox.Size = new System.Drawing.Size(56, 17);
            this.LunchCheckBox.TabIndex = 1;
            this.LunchCheckBox.Text = "Lunch";
            this.LunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // DinnerCheckBox
            // 
            this.DinnerCheckBox.AutoSize = true;
            this.DinnerCheckBox.Location = new System.Drawing.Point(6, 152);
            this.DinnerCheckBox.Name = "DinnerCheckBox";
            this.DinnerCheckBox.Size = new System.Drawing.Size(57, 17);
            this.DinnerCheckBox.TabIndex = 2;
            this.DinnerCheckBox.Text = "Dinner";
            this.DinnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // HideOrderCheckBox
            // 
            this.HideOrderCheckBox.AutoSize = true;
            this.HideOrderCheckBox.Location = new System.Drawing.Point(164, 250);
            this.HideOrderCheckBox.Name = "HideOrderCheckBox";
            this.HideOrderCheckBox.Size = new System.Drawing.Size(75, 17);
            this.HideOrderCheckBox.TabIndex = 3;
            this.HideOrderCheckBox.Text = "Hide order";
            this.HideOrderCheckBox.UseVisualStyleBackColor = true;
            this.HideOrderCheckBox.CheckedChanged += new System.EventHandler(this.HideOrderCheckBox_CheckedChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(26, 246);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OrderRichTextBox
            // 
            this.OrderRichTextBox.Location = new System.Drawing.Point(112, 12);
            this.OrderRichTextBox.Name = "OrderRichTextBox";
            this.OrderRichTextBox.Size = new System.Drawing.Size(219, 195);
            this.OrderRichTextBox.TabIndex = 5;
            this.OrderRichTextBox.Text = "";
            // 
            // MealsGroupBox
            // 
            this.MealsGroupBox.Controls.Add(this.BreakfastCheckBox);
            this.MealsGroupBox.Controls.Add(this.LunchCheckBox);
            this.MealsGroupBox.Controls.Add(this.DinnerCheckBox);
            this.MealsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MealsGroupBox.Name = "MealsGroupBox";
            this.MealsGroupBox.Size = new System.Drawing.Size(81, 195);
            this.MealsGroupBox.TabIndex = 6;
            this.MealsGroupBox.TabStop = false;
            this.MealsGroupBox.Text = "Meals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 285);
            this.Controls.Add(this.MealsGroupBox);
            this.Controls.Add(this.OrderRichTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.HideOrderCheckBox);
            this.Name = "Form1";
            this.Text = "ChechBox";
            this.MealsGroupBox.ResumeLayout(false);
            this.MealsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BreakfastCheckBox;
        private System.Windows.Forms.CheckBox LunchCheckBox;
        private System.Windows.Forms.CheckBox DinnerCheckBox;
        private System.Windows.Forms.CheckBox HideOrderCheckBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox OrderRichTextBox;
        private System.Windows.Forms.GroupBox MealsGroupBox;
    }
}

