using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenNewFormButton_Click(object sender, EventArgs e)
        {
            DataModel.Data = StartingTextBox.Text;

            DataTransferNewForm nf = new DataTransferNewForm();

            //show nf modal form, if cancel is clicked, or if ok is clicked, do stuff
            if (nf.ShowDialog() == DialogResult.Cancel)
            {
                StartingTextBox.Text = "On last form you selected cancel button!";
            }
            else
            {
                StartingTextBox.Text = DataModel.Data;
            }

            nf.Dispose();
        }
    }
}
