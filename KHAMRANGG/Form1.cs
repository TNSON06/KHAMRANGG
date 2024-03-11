using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHAMRANGG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double TT()
        {
            double s = 0;
            if(cBCV.Checked)
            
                s += 100;
            if (cBTT.Checked)
                s += 1200;
            if (cBCHR.Checked)
                s += 200;
            if (cBBTR.SelectedIndex >=0)
            {
                int sr  = Convert.ToInt32(cBBTR.SelectedItem.ToString());
                s += sr * 80;
            }
            return s;
        }
        private void buttonTT_Click(object sender, EventArgs e)
        {
            if(textName.Text == "")
            {
                MessageBox.Show("Nhap ten di cu");
            }    
            else
            {
                tBTotal.Text = TT().ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
