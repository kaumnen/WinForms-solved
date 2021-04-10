
namespace Exercise_2._10
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
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AcademicGroupBox = new System.Windows.Forms.GroupBox();
            this.PhDRadioButton = new System.Windows.Forms.RadioButton();
            this.MagisterRadioButton = new System.Windows.Forms.RadioButton();
            this.FacultyRadioButton = new System.Windows.Forms.RadioButton();
            this.CollegeRadioButton = new System.Windows.Forms.RadioButton();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.ElementaryRadioButton = new System.Windows.Forms.RadioButton();
            this.HobbiesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesCheckBox = new System.Windows.Forms.CheckBox();
            this.HangoutsCheckBox = new System.Windows.Forms.CheckBox();
            this.BooksCheckBox = new System.Windows.Forms.CheckBox();
            this.SportCheckBox = new System.Windows.Forms.CheckBox();
            this.SeeAllAcademicLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AcademicLevelsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DropButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AcademicGroupBox.SuspendLayout();
            this.HobbiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(98, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(98, 67);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // AcademicGroupBox
            // 
            this.AcademicGroupBox.Controls.Add(this.PhDRadioButton);
            this.AcademicGroupBox.Controls.Add(this.MagisterRadioButton);
            this.AcademicGroupBox.Controls.Add(this.FacultyRadioButton);
            this.AcademicGroupBox.Controls.Add(this.CollegeRadioButton);
            this.AcademicGroupBox.Controls.Add(this.HighRadioButton);
            this.AcademicGroupBox.Controls.Add(this.ElementaryRadioButton);
            this.AcademicGroupBox.Location = new System.Drawing.Point(40, 113);
            this.AcademicGroupBox.Name = "AcademicGroupBox";
            this.AcademicGroupBox.Size = new System.Drawing.Size(148, 164);
            this.AcademicGroupBox.TabIndex = 4;
            this.AcademicGroupBox.TabStop = false;
            this.AcademicGroupBox.Text = "Academic level";
            // 
            // PhDRadioButton
            // 
            this.PhDRadioButton.AutoSize = true;
            this.PhDRadioButton.Location = new System.Drawing.Point(7, 136);
            this.PhDRadioButton.Name = "PhDRadioButton";
            this.PhDRadioButton.Size = new System.Drawing.Size(52, 17);
            this.PhDRadioButton.TabIndex = 5;
            this.PhDRadioButton.TabStop = true;
            this.PhDRadioButton.Text = "Ph.D.";
            this.PhDRadioButton.UseVisualStyleBackColor = true;
            // 
            // MagisterRadioButton
            // 
            this.MagisterRadioButton.AutoSize = true;
            this.MagisterRadioButton.Location = new System.Drawing.Point(7, 113);
            this.MagisterRadioButton.Name = "MagisterRadioButton";
            this.MagisterRadioButton.Size = new System.Drawing.Size(65, 17);
            this.MagisterRadioButton.TabIndex = 4;
            this.MagisterRadioButton.TabStop = true;
            this.MagisterRadioButton.Text = "Magister";
            this.MagisterRadioButton.UseVisualStyleBackColor = true;
            // 
            // FacultyRadioButton
            // 
            this.FacultyRadioButton.AutoSize = true;
            this.FacultyRadioButton.Location = new System.Drawing.Point(7, 90);
            this.FacultyRadioButton.Name = "FacultyRadioButton";
            this.FacultyRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FacultyRadioButton.TabIndex = 3;
            this.FacultyRadioButton.TabStop = true;
            this.FacultyRadioButton.Text = "Faculty";
            this.FacultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // CollegeRadioButton
            // 
            this.CollegeRadioButton.AutoSize = true;
            this.CollegeRadioButton.Location = new System.Drawing.Point(7, 67);
            this.CollegeRadioButton.Name = "CollegeRadioButton";
            this.CollegeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.CollegeRadioButton.TabIndex = 2;
            this.CollegeRadioButton.TabStop = true;
            this.CollegeRadioButton.Text = "College";
            this.CollegeRadioButton.UseVisualStyleBackColor = true;
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(7, 43);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(81, 17);
            this.HighRadioButton.TabIndex = 1;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High school";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // ElementaryRadioButton
            // 
            this.ElementaryRadioButton.AutoSize = true;
            this.ElementaryRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ElementaryRadioButton.Name = "ElementaryRadioButton";
            this.ElementaryRadioButton.Size = new System.Drawing.Size(111, 17);
            this.ElementaryRadioButton.TabIndex = 0;
            this.ElementaryRadioButton.TabStop = true;
            this.ElementaryRadioButton.Text = "Elementary school";
            this.ElementaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // HobbiesGroupBox
            // 
            this.HobbiesGroupBox.Controls.Add(this.MoviesCheckBox);
            this.HobbiesGroupBox.Controls.Add(this.HangoutsCheckBox);
            this.HobbiesGroupBox.Controls.Add(this.BooksCheckBox);
            this.HobbiesGroupBox.Controls.Add(this.SportCheckBox);
            this.HobbiesGroupBox.Location = new System.Drawing.Point(253, 113);
            this.HobbiesGroupBox.Name = "HobbiesGroupBox";
            this.HobbiesGroupBox.Size = new System.Drawing.Size(123, 107);
            this.HobbiesGroupBox.TabIndex = 5;
            this.HobbiesGroupBox.TabStop = false;
            this.HobbiesGroupBox.Text = "Hobies";
            // 
            // MoviesCheckBox
            // 
            this.MoviesCheckBox.AutoSize = true;
            this.MoviesCheckBox.Location = new System.Drawing.Point(7, 90);
            this.MoviesCheckBox.Name = "MoviesCheckBox";
            this.MoviesCheckBox.Size = new System.Drawing.Size(60, 17);
            this.MoviesCheckBox.TabIndex = 3;
            this.MoviesCheckBox.Text = "Movies";
            this.MoviesCheckBox.UseVisualStyleBackColor = true;
            // 
            // HangoutsCheckBox
            // 
            this.HangoutsCheckBox.AutoSize = true;
            this.HangoutsCheckBox.Location = new System.Drawing.Point(7, 67);
            this.HangoutsCheckBox.Name = "HangoutsCheckBox";
            this.HangoutsCheckBox.Size = new System.Drawing.Size(75, 17);
            this.HangoutsCheckBox.TabIndex = 2;
            this.HangoutsCheckBox.Text = "Hang outs";
            this.HangoutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // BooksCheckBox
            // 
            this.BooksCheckBox.AutoSize = true;
            this.BooksCheckBox.Location = new System.Drawing.Point(7, 44);
            this.BooksCheckBox.Name = "BooksCheckBox";
            this.BooksCheckBox.Size = new System.Drawing.Size(56, 17);
            this.BooksCheckBox.TabIndex = 1;
            this.BooksCheckBox.Text = "Books";
            this.BooksCheckBox.UseVisualStyleBackColor = true;
            // 
            // SportCheckBox
            // 
            this.SportCheckBox.AutoSize = true;
            this.SportCheckBox.Location = new System.Drawing.Point(7, 20);
            this.SportCheckBox.Name = "SportCheckBox";
            this.SportCheckBox.Size = new System.Drawing.Size(51, 17);
            this.SportCheckBox.TabIndex = 0;
            this.SportCheckBox.Text = "Sport";
            this.SportCheckBox.UseVisualStyleBackColor = true;
            // 
            // SeeAllAcademicLinkLabel
            // 
            this.SeeAllAcademicLinkLabel.AutoSize = true;
            this.SeeAllAcademicLinkLabel.Location = new System.Drawing.Point(37, 304);
            this.SeeAllAcademicLinkLabel.Name = "SeeAllAcademicLinkLabel";
            this.SeeAllAcademicLinkLabel.Size = new System.Drawing.Size(118, 13);
            this.SeeAllAcademicLinkLabel.TabIndex = 6;
            this.SeeAllAcademicLinkLabel.TabStop = true;
            this.SeeAllAcademicLinkLabel.Text = "See all academic levels";
            // 
            // AcademicLevelsRichTextBox
            // 
            this.AcademicLevelsRichTextBox.Location = new System.Drawing.Point(40, 337);
            this.AcademicLevelsRichTextBox.Name = "AcademicLevelsRichTextBox";
            this.AcademicLevelsRichTextBox.Size = new System.Drawing.Size(558, 173);
            this.AcademicLevelsRichTextBox.TabIndex = 7;
            this.AcademicLevelsRichTextBox.Text = "";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(470, 31);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(470, 83);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(75, 23);
            this.DropButton.TabIndex = 9;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(470, 294);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 532);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AcademicLevelsRichTextBox);
            this.Controls.Add(this.SeeAllAcademicLinkLabel);
            this.Controls.Add(this.HobbiesGroupBox);
            this.Controls.Add(this.AcademicGroupBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration";
            this.AcademicGroupBox.ResumeLayout(false);
            this.AcademicGroupBox.PerformLayout();
            this.HobbiesGroupBox.ResumeLayout(false);
            this.HobbiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.GroupBox AcademicGroupBox;
        private System.Windows.Forms.RadioButton PhDRadioButton;
        private System.Windows.Forms.RadioButton MagisterRadioButton;
        private System.Windows.Forms.RadioButton FacultyRadioButton;
        private System.Windows.Forms.RadioButton CollegeRadioButton;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton ElementaryRadioButton;
        private System.Windows.Forms.GroupBox HobbiesGroupBox;
        private System.Windows.Forms.CheckBox MoviesCheckBox;
        private System.Windows.Forms.CheckBox HangoutsCheckBox;
        private System.Windows.Forms.CheckBox BooksCheckBox;
        private System.Windows.Forms.CheckBox SportCheckBox;
        private System.Windows.Forms.LinkLabel SeeAllAcademicLinkLabel;
        private System.Windows.Forms.RichTextBox AcademicLevelsRichTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button DropButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

