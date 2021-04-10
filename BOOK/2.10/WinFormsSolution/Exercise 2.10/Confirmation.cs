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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {RegistrationModel.Name}");
            sb.AppendLine($"Surname: {RegistrationModel.Surname}");
            sb.AppendLine($"Academic level: {RegistrationModel.AcademicLevel}");
            sb.AppendLine($"Hobbies: {RegistrationModel.Hobbies}");

            DataRichTextBox.Text = sb.ToString();
        }
    }
}
