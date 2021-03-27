using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("You have chosen:\n");

            //traverse through every item inside groupbox
            foreach (CheckBox cb in MealsGroupBox.Controls)
            {
                //if checkbox is checked, append appropriate text to order collection
                if (cb.Checked)
                {
                    sb.Append($"{cb.Text}\n");
                }
            }

            OrderRichTextBox.Text = sb.ToString();
        }

        private void HideOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if hide order checkbox is checked, hide orders rich textbox automatically
            OrderRichTextBox.Visible = !HideOrderCheckBox.Checked;
        }
    }
}
