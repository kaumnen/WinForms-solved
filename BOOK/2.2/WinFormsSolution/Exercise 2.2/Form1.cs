using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //changes color and saves it to hardcoded location
        private void SaveButton_Click(object sender, EventArgs e)
        {
            ContentRichTextBox.SelectionBackColor = Color.Red;
            ContentRichTextBox.ForeColor = Color.Green;

            ContentRichTextBox.SaveFile(@"C:\Users\{-your username here-]\Desktop\test.rtf", RichTextBoxStreamType.RichText);
        }

        //loads file from hardcoded location
        private void LoadButton_Click(object sender, EventArgs e)
        {
            ContentRichTextBox.LoadFile(@"C:\Users\{-your username here-]}\Desktop\test.rtf");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ContentRichTextBox.Clear();
        }
    }
}
