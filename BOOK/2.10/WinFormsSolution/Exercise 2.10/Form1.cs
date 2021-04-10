using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearModelClass()
        {
            RegistrationModel.Name = "";
            RegistrationModel.Surname = "";
            RegistrationModel.AcademicLevel = "";
            RegistrationModel.Hobbies = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //assign data to appropriate properties from data model class
            RegistrationModel.Name = NameTextBox.Text;
            RegistrationModel.Surname = SurnameTextBox.Text;
            foreach (RadioButton rb in AcademicGroupBox.Controls)
            {
                if (rb.Checked)
                {
                    RegistrationModel.AcademicLevel = rb.Text;
                }
            }

            foreach (CheckBox cb in HobbiesGroupBox.Controls)
            {
                if (cb.Checked)
                {
                    RegistrationModel.Hobbies += $"\t{cb.Text}\r\n";
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {RegistrationModel.Name}");
            sb.AppendLine($"Surname: {RegistrationModel.Surname}");
            sb.AppendLine($"Academic level: {RegistrationModel.AcademicLevel}");
            sb.AppendLine($"Hobbies: {RegistrationModel.Hobbies}");

            Confirmation c = new Confirmation();

            //if OK button is clicked, assign text, and clear data model class
            if (c.ShowDialog() == DialogResult.OK)
            {
                AcademicLevelsRichTextBox.Text = sb.ToString();
                ClearModelClass();

            }
            else
            {
                AcademicLevelsRichTextBox.Text = "Registration was cancelled!";
                ClearModelClass();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
