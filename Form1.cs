namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
            this.Shown += (s, e) =>
            {
                rdoBurger1.Checked = false;
                rdoBurger2.Checked = false;
                rdoBurger3.Checked = false;
            };

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (!rdoBurger1.Focused && !rdoBurger2.Focused && !rdoBurger3.Focused)
                {
                    rdoBurger1.Focus();
                    return true;
                }
            }

            if (keyData == Keys.Enter)
            {
                orderBtn.PerformClick();
                return true;
            }

            if (keyData == Keys.Back)
            {
                initBtn.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (
                !rdoBurger1.Checked &&
                !rdoBurger2.Checked &&
                !rdoBurger3.Checked &&
                !chkOption1.Checked &&
                !chkOption2.Checked &&
                !chkOption3.Checked &&
                !chkOption4.Checked
                )
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
                return;
            }
            lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");
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
            lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");
        }

        private void rdoBurger1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rdoBurger1.Checked = true;
                rdoBurger2.Checked = false;
                rdoBurger3.Checked = false;

            }
        }

        private void rdoBurger2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rdoBurger1.Checked = false;
                rdoBurger2.Checked = true;
                rdoBurger3.Checked = false;
            }
        }

        private void rdoBurger3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rdoBurger1.Checked = false;
                rdoBurger2.Checked = false;
                rdoBurger3.Checked = true;
            }
        }

        private void rdoBurger1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBurger1.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 : 5,000원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 5000;
                lstOrder.Items.Remove("햄버거 : 5,000원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }


        private void rdoBurger2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBurger2.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 : 4,000원");
    lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 4000;
                lstOrder.Items.Remove("불고기버거 : 4,000원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }

        private void rdoBurger3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBurger3.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 : 3,000원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 3000;
                lstOrder.Items.Remove("치킨버거 : 3,000원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }

        private void chkOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption1.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 : 3,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 3500;
                lstOrder.Items.Remove("감자튀김 : 3,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }

        private void chkOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption2.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 : 2,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 2500;
                lstOrder.Items.Remove("콜라 : 2,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }

        private void chkOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption3.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 : 1,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 1500;
                lstOrder.Items.Remove("치즈 추가 : 1,500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }

        private void chkOption4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption4.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 : 500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
            else
            {
                totalCost -= 500;
                lstOrder.Items.Remove("소스 추가 : 500원");
                lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");

            }
        }
    }
}
