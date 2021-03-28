using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PlaneRadioButton.Checked = true;
        }

        private void WriteToTextBox(RadioButton rb)
        {
            ChoiceTextBox.Text = $"You have chosen {rb.Text} transportation type!";
        }

        //make one universal event for all radio buttons
        private void TransportationRadioButtonClickedUniversal_CheckedChanged(object sender, EventArgs e)
        {
            //depending on sender change ChoiceTextBox's text
            WriteToTextBox((RadioButton)sender);
        }
    }
}
