using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty = new DinnerParty();

        public Form1()
        {
            InitializeComponent();
            dinnerParty.CalculateCostOfDecorations(true);
            dinnerParty.SetHealthyOption(false);
            DisplayDinnerCost();
        }

        public void DisplayDinnerCost()
        {
            dinnerParty.CalculateDinnerCost(numericUpDown1.Value);
            decimal TotalCost = dinnerParty.CalculateDinnerCost(numericUpDown1.Value);
            label1.Text = TotalCost.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateDinnerCost(numericUpDown1.Value);
            DisplayDinnerCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox1.Checked);
            DisplayDinnerCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox2.Checked);
            DisplayDinnerCost();
        }
    }
}
