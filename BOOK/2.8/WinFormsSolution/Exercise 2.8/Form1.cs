using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            openFileDialog1.InitialDirectory = @"C:\Temp";
            saveFileDialog1.InitialDirectory = @"C:\Temp";
            TextRichTextBox.Font = new Font("Calibri", 11);
        }

        private void ChangeFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string newFolder = folderBrowserDialog1.SelectedPath;
                openFileDialog1.InitialDirectory = newFolder;
                saveFileDialog1.InitialDirectory = newFolder;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "rtf files|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (TextRichTextBox.Text != "")
                {
                    TextRichTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    TextRichTextBox.Clear();
                    MessageBox.Show("Text has been saved!");
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "rtf files|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextRichTextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (TextRichTextBox.SelectedText.Length > 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextRichTextBox.SelectionColor = colorDialog1.Color;
                }
            }
            else
            {
                MessageBox.Show("You have to select a text in order to change its color!");
            }
            
        }
    }
}
