using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._6
{
    public partial class DataTransferNewForm : Form
    {
        public DataTransferNewForm()
        {
            InitializeComponent();
        }

        private void DataTransferNewForm_Load(object sender, EventArgs e)
        {
            newFormDataTextBox.Text = DataModel.Data;
        }

        private void DataTransferNewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataModel.Data = newFormDataTextBox.Text;
        }
    }
}
