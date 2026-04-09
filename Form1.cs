namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            burgerRadioButton1.Checked = false;
            burgerRadioButton2.Checked = false;
            burgerRadioButton3.Checked = false;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            totalCostLbl.Text = ($"총 금액 : {totalCost}원");
        }

        private void burgerRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerRadioButton1.Checked)
            {
                totalCost += 5000;
            }
            else
            {
                totalCost -= 5000;
            }
        }

        private void burgerRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerRadioButton2.Checked)
            {
                totalCost += 4000;
            }
            else
            {
                totalCost -= 4000;
            }
        }

        private void burgerRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerRadioButton3.Checked)
            {
                totalCost += 3000;
            }
            else
            {
                totalCost -= 3000;
            }
        }

        private void optionCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (optionCheckBox1.Checked)
            {
                totalCost += 3500;
            }
        }

        private void optionCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (optionCheckBox2.Checked)
            {
                totalCost += 2500;
            }
        }

        private void optionCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (optionCheckBox3.Checked)
            {
                totalCost += 1500;
            }
        }

        private void optionCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (optionCheckBox4.Checked)
            {
                totalCost += 500;
            }
        }
    }
}
