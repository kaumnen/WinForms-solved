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
        public Form1()
        {
            InitializeComponent();
            sgm = new Stack<GuestModel>();
        }

        private void printGuests()
        {
            GuestsRichTextBox.AppendText($"{sgm.Pop().ToString()}");
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            AddGuest ag = new AddGuest();
            if (ag.ShowDialog() == DialogResult.OK)
            {
                sgm.Push(new GuestModel {});
                printGuests();
            }
        }
    }
}
