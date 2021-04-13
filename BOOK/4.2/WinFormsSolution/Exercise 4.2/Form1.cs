using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private ArrayList Ads;
        private AdModel am;

        public Form1()
        {
            InitializeComponent();
            Ads = new ArrayList();
        }

        public void InputAds()
        {
            foreach (AdModel adModel in Ads)
            {
                AdsListBox.Items.Add(adModel);
            }
        }

        private void NewAddButton_Click(object sender, EventArgs e)
        {
            AdInput ai = new AdInput();

            if (ai.ShowDialog() == DialogResult.OK)
            {
                am = new AdModel(ai.Position, ai.YOE, ai.AcademicLevel);
                Ads.Add(am);
                AdsListBox.Items.Clear();
                InputAds();
            }
        }
    }
}
