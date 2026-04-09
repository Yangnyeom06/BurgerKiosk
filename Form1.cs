namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            rdoBurger1.Checked = false;
            rdoBurger2.Checked = false;
            rdoBurger3.Checked = false;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (rdoBurger1.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 : 5,000원");
            }
            else if (rdoBurger2.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 : 4,000원");
            }

            else if (rdoBurger3.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 : 3,000원");
            }

            if (chkOption1.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 : 3,500원");
            }
            if (chkOption2.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 : 2,500원");
            }
            if (chkOption3.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 : 1,500원");
            }
            if (chkOption4.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 : 500원");
            }
            lblTotalCost.Text = ($"총 금액 : {totalCost}원");
        }

        private void initBtn_Click(object sender, EventArgs e)
        {
            rdoBurger1.Checked = false;
            rdoBurger2.Checked = false;
            rdoBurger3.Checked = false;

            chkOption1.Checked = false;
            chkOption2.Checked = false;
            chkOption3.Checked = false;
            chkOption4.Checked = false;

            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = ($"총 금액 : {totalCost}원");
        }
    }
}
