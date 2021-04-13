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
    }
}
