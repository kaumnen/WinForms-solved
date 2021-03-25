using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();

            output.Append($"Name and Surname: {NameSurnameTextBox.Text}\r\n");
            output.Append($"Address: {AddressTextBox.Text}\r\n");
            output.Append($"Course: {CourseTextBox.Text}\r\n");
            output.Append($"Age: {AgeTextbox.Text}\r\n");

            OutputTextBox.Text = output.ToString();
        }
    }
}
