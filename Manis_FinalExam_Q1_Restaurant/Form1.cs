using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manis_FinalExam_Q1_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dishListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sideListBox.Visible = true;
            for (int x = 0; x < dishListBox.Items.Count; ++x)
                if (dishListBox.GetSelected(x))
                    outPutLabel.Text = dishListBox.Items[x].ToString();
        }

        private void sideListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertListBox.Visible = true;
            for (int x = 0; x < sideListBox.Items.Count; ++x)
                if (sideListBox.GetSelected(x))
                    outPutLabel.Text += " with " + sideListBox.Items[x].ToString();
           
        }

        private void dessertListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < dessertListBox.Items.Count; ++x)
                if (dessertListBox.GetSelected(x))
                    outPutLabel.Text += " and " + dessertListBox.Items[x].ToString() + " for dessert ";
            sideListBox.Visible = false;
            dessertListBox.Visible = false;
        }
    }
}
