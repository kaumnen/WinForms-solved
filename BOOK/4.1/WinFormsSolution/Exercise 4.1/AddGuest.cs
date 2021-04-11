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
    public partial class AddGuest : Form
    {
        public string Surname { get; set; }
        public int Members { get; set; }
        public string Meals { get; set; }

        public AddGuest()
        {
            InitializeComponent();
        }

        internal static GuestModel gm = new GuestModel();

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Surname = SurnameTextBox.Text;
            Members = Convert.ToInt32(MembersComboBox.SelectedItem.ToString());
            Meals = "";
            foreach (CheckBox cb in MealsGroupBox.Controls)
            {
                if (cb.Checked)
                {
                    Meals += cb.Text + "\r\n";
                }
            }
        }
    }
}
