using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            Font newFont;
            Font oldFont;

            oldFont = TextRichTextBox.SelectionFont;

            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }

            //setting new font and focus on text area
            TextRichTextBox.SelectionFont = newFont;
            TextRichTextBox.Focus();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            if (TextRichTextBox.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                TextRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }

            TextRichTextBox.Focus();
        }

        private void SizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }

            else if (e.KeyChar == 13)
            {
                TextBox txt = (TextBox)sender;

                if (txt.Text.Length > 0)
                {
                    ChangeFontSize(txt.Text);
                }

                e.Handled = true;
                TextRichTextBox.Focus();
            }
        }

        private void ChangeFontSize(string textSize)
        {
            float newSize = Convert.ToSingle(textSize);

            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = TextRichTextBox.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            TextRichTextBox.SelectionFont = newFont;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextRichTextBox.LoadFile(@"../../Test.rtf");
                MessageBox.Show("The file has been loaded!");
            }
            catch (System.IO.FileNotFoundException fnfe)
            {
                MessageBox.Show("File has not been saved yet!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextRichTextBox.SaveFile(@"../../Test.rtf", RichTextBoxStreamType.RichText);
                MessageBox.Show("The file has been saved!");
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
        }
    }
}
