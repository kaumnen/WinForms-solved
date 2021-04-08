using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            Font newFont;
            Font oldFont;

            oldFont = TextRichTextBox.SelectionFont;

            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }

            //setting new font and focus on text area
            TextRichTextBox.SelectionFont = newFont;
            TextRichTextBox.Focus();
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            Font newFont;
            Font oldFont;

            oldFont = TextRichTextBox.SelectionFont;

            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }

            //setting new font and focus on text area
            TextRichTextBox.SelectionFont = newFont;
            TextRichTextBox.Focus();
        }
    }
}
