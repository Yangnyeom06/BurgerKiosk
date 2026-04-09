namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            rdoBurger1 = new RadioButton();
            groupBox1 = new GroupBox();
            burgerPictureBox3 = new PictureBox();
            burgerPictureBox2 = new PictureBox();
            burgerPictureBox1 = new PictureBox();
            rdoBurger3 = new RadioButton();
            rdoBurger2 = new RadioButton();
            groupBox2 = new GroupBox();
            chkOption4 = new CheckBox();
            chkOption3 = new CheckBox();
            chkOption2 = new CheckBox();
            chkOption1 = new CheckBox();
            groupBox3 = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            orderBtn = new Button();
            initBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 17F, FontStyle.Bold);
            lblAppName.Location = new Point(39, 23);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(269, 62);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdoBurger1
            // 
            rdoBurger1.AutoSize = true;
            rdoBurger1.Font = new Font("맑은 고딕", 10F);
            rdoBurger1.Location = new Point(13, 59);
            rdoBurger1.Name = "rdoBurger1";
            rdoBurger1.Size = new Size(82, 27);
            rdoBurger1.TabIndex = 0;
            rdoBurger1.Text = "햄버거";
            rdoBurger1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(burgerPictureBox3);
            groupBox1.Controls.Add(burgerPictureBox2);
            groupBox1.Controls.Add(burgerPictureBox1);
            groupBox1.Controls.Add(rdoBurger3);
            groupBox1.Controls.Add(rdoBurger2);
            groupBox1.Controls.Add(rdoBurger1);
            groupBox1.Font = new Font("맑은 고딕", 12F);
            groupBox1.Location = new Point(39, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // burgerPictureBox3
            // 
            burgerPictureBox3.Image = Properties.Resources.burger3;
            burgerPictureBox3.Location = new Point(128, 226);
            burgerPictureBox3.Name = "burgerPictureBox3";
            burgerPictureBox3.Size = new Size(91, 77);
            burgerPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            burgerPictureBox3.TabIndex = 6;
            burgerPictureBox3.TabStop = false;
            // 
            // burgerPictureBox2
            // 
            burgerPictureBox2.Image = Properties.Resources.burger2;
            burgerPictureBox2.Location = new Point(128, 133);
            burgerPictureBox2.Name = "burgerPictureBox2";
            burgerPictureBox2.Size = new Size(91, 77);
            burgerPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            burgerPictureBox2.TabIndex = 5;
            burgerPictureBox2.TabStop = false;
            // 
            // burgerPictureBox1
            // 
            burgerPictureBox1.Image = Properties.Resources.burger1;
            burgerPictureBox1.Location = new Point(128, 40);
            burgerPictureBox1.Name = "burgerPictureBox1";
            burgerPictureBox1.Size = new Size(91, 77);
            burgerPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            burgerPictureBox1.TabIndex = 4;
            burgerPictureBox1.TabStop = false;
            // 
            // rdoBurger3
            // 
            rdoBurger3.AutoSize = true;
            rdoBurger3.Font = new Font("맑은 고딕", 10F);
            rdoBurger3.Location = new Point(13, 241);
            rdoBurger3.Name = "rdoBurger3";
            rdoBurger3.Size = new Size(99, 27);
            rdoBurger3.TabIndex = 2;
            rdoBurger3.Text = "치킨버거";
            rdoBurger3.UseVisualStyleBackColor = true;
            // 
            // rdoBurger2
            // 
            rdoBurger2.AutoSize = true;
            rdoBurger2.Font = new Font("맑은 고딕", 10F);
            rdoBurger2.Location = new Point(13, 153);
            rdoBurger2.Name = "rdoBurger2";
            rdoBurger2.Size = new Size(116, 27);
            rdoBurger2.TabIndex = 1;
            rdoBurger2.Text = "불고기버거";
            rdoBurger2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkOption4);
            groupBox2.Controls.Add(chkOption3);
            groupBox2.Controls.Add(chkOption2);
            groupBox2.Controls.Add(chkOption1);
            groupBox2.Font = new Font("맑은 고딕", 12F);
            groupBox2.Location = new Point(318, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 222);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // chkOption4
            // 
            chkOption4.AutoSize = true;
            chkOption4.Location = new Point(21, 175);
            chkOption4.Name = "chkOption4";
            chkOption4.Size = new Size(121, 32);
            chkOption4.TabIndex = 3;
            chkOption4.TabStop = false;
            chkOption4.Text = "소스 추가";
            chkOption4.UseVisualStyleBackColor = true;
            // 
            // chkOption3
            // 
            chkOption3.AutoSize = true;
            chkOption3.Location = new Point(21, 132);
            chkOption3.Name = "chkOption3";
            chkOption3.Size = new Size(121, 32);
            chkOption3.TabIndex = 2;
            chkOption3.TabStop = false;
            chkOption3.Text = "치즈 추가";
            chkOption3.UseVisualStyleBackColor = true;
            // 
            // chkOption2
            // 
            chkOption2.AutoSize = true;
            chkOption2.Location = new Point(21, 88);
            chkOption2.Name = "chkOption2";
            chkOption2.Size = new Size(74, 32);
            chkOption2.TabIndex = 1;
            chkOption2.TabStop = false;
            chkOption2.Text = "콜라";
            chkOption2.UseVisualStyleBackColor = true;
            // 
            // chkOption1
            // 
            chkOption1.AutoSize = true;
            chkOption1.Location = new Point(21, 43);
            chkOption1.Name = "chkOption1";
            chkOption1.Size = new Size(114, 32);
            chkOption1.TabIndex = 0;
            chkOption1.TabStop = false;
            chkOption1.Text = "감자튀김";
            chkOption1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalCost);
            groupBox3.Controls.Add(lstOrder);
            groupBox3.Font = new Font("맑은 고딕", 12F);
            groupBox3.Location = new Point(526, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 261);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(18, 212);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(209, 40);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            lblTotalCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(17, 39);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(209, 172);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // orderBtn
            // 
            orderBtn.BackColor = Color.Green;
            orderBtn.ForeColor = SystemColors.Control;
            orderBtn.Location = new Point(526, 384);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(113, 54);
            orderBtn.TabIndex = 3;
            orderBtn.TabStop = false;
            orderBtn.Text = "주문하기";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += orderBtn_Click;
            // 
            // initBtn
            // 
            initBtn.BackColor = Color.Red;
            initBtn.ForeColor = SystemColors.Control;
            initBtn.Location = new Point(655, 384);
            initBtn.Name = "initBtn";
            initBtn.Size = new Size(115, 54);
            initBtn.TabIndex = 7;
            initBtn.TabStop = false;
            initBtn.Text = "초기화";
            initBtn.UseVisualStyleBackColor = false;
            initBtn.Click += initBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(initBtn);
            Controls.Add(orderBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)burgerPictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoBurger1;
        private GroupBox groupBox1;
        private RadioButton rdoBurger3;
        private RadioButton rdoBurger2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private PictureBox burgerPictureBox3;
        private PictureBox burgerPictureBox2;
        private PictureBox burgerPictureBox1;
        private CheckBox chkOption4;
        private CheckBox chkOption3;
        private CheckBox chkOption2;
        private CheckBox chkOption1;
        private Button orderBtn;
        private Button initBtn;
    }
}
