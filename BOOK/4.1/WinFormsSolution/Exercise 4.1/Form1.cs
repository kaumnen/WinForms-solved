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

namespace Exercise_4._1
{
    public partial class Form1 : Form
    {
        readonly Stack<GuestModel> sgm;
        private GuestModel gm;

        public Form1()
        {
            InitializeComponent();
            sgm = new Stack<GuestModel>();
        }

        private void printGuests()
        {
            GuestsRichTextBox.Clear();
            foreach (GuestModel gm in sgm)
            {
                GuestsRichTextBox.AppendText($"{gm.ToString()}");
            }
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            AddGuest ag = new AddGuest();
            if (ag.ShowDialog() == DialogResult.OK)
            {
                sgm.Push(new GuestModel{Surname = ag.Surname, Meals = ag.Meals, Members = ag.Members});
                printGuests();
            }
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            sgm.Pop();
            printGuests();
            MessageBox.Show("Guests have left!", "Information");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Guest_list.txt");

            sw.WriteLine("Guest list:");

            foreach (GuestModel gm in sgm)
            {
                sw.Write(gm.ToString());
            }

            sw.Close();
            MessageBox.Show("File Guest_list.txt has been successfully saved!", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
