using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
