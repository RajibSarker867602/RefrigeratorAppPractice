using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        Refrigerator refrigerator = new Refrigerator();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (maxWeightTakeTextBox.Text == "")
            {
                MessageBox.Show("Please enter maximum weight!");
                return;
            }
            refrigerator.MaximumWeight =Convert.ToDouble(maxWeightTakeTextBox.Text);
            MessageBox.Show("Save successful.");
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (itemTextBox.Text == "")
            {
                MessageBox.Show("Please enter number of item!");
                return;
            }
            if (weightTextBox.Text == "")
            {
                MessageBox.Show("Please enter weight!");
                return;
            }
            double currentWeight = refrigerator.GetCurrentWight(Convert.ToInt32(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text));
            if (currentWeight == 0)
            {
                MessageBox.Show("Your given amount can’t be entered because it will be over flown.");
                return;
            }
            double remainingWeight = refrigerator.GetRemainingWeight();
            currentWeightTextBox.Text = currentWeight.ToString();
            remainingWeightTextBox.Text = remainingWeight.ToString();
        }
    }
}
