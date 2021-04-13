using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4._2
{
    public partial class AdInput : Form
    {
        public AdInput()
        {
            InitializeComponent();
        }

        public string Position { get; set; }
        public string AcademicLevel { get; set; }
        public int YOE { get; set; }

        public void PopulateProperties()
        {
            Position = PositionTextBox.Text;

            foreach (RadioButton rb in AcademicGroupBox.Controls)
            {
                if (rb.Checked)
                {
                    AcademicLevel = rb.Text;
                    break;
                }
            }

            YOE = Convert.ToInt16(YOENumeric.Text);
        }

        private void YOENumeric_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(YOENumeric.Text) > 40)
            {
                e.Cancel = true;
                numericErrorProvider.SetError(YOENumeric, "You can not have more than 40 YOE!");

                YOENumeric.Select(0, YOENumeric.Text.Length);
            }
            else
            {
                e.Cancel = false;
                numericErrorProvider.Clear();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            PopulateProperties();
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
