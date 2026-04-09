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
            titleLbl = new Label();
            burgerRadioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            burgerPictureBox3 = new PictureBox();
            burgerPictureBox2 = new PictureBox();
            burgerPictureBox1 = new PictureBox();
            burgerRadioButton3 = new RadioButton();
            burgerRadioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            optionCheckBox4 = new CheckBox();
            optionCheckBox3 = new CheckBox();
            optionCheckBox2 = new CheckBox();
            optionCheckBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            totalCostLbl = new Label();
            orderListBox = new ListBox();
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
            // titleLbl
            // 
            titleLbl.Font = new Font("맑은 고딕", 17F, FontStyle.Bold);
            titleLbl.Location = new Point(39, 23);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(269, 62);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "버거 주문 키오스크";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // burgerRadioButton1
            // 
            burgerRadioButton1.AutoSize = true;
            burgerRadioButton1.Font = new Font("맑은 고딕", 10F);
            burgerRadioButton1.Location = new Point(13, 59);
            burgerRadioButton1.Name = "burgerRadioButton1";
            burgerRadioButton1.Size = new Size(82, 27);
            burgerRadioButton1.TabIndex = 1;
            burgerRadioButton1.Text = "햄버거";
            burgerRadioButton1.UseVisualStyleBackColor = true;
            burgerRadioButton1.CheckedChanged += burgerRadioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(burgerPictureBox3);
            groupBox1.Controls.Add(burgerPictureBox2);
            groupBox1.Controls.Add(burgerPictureBox1);
            groupBox1.Controls.Add(burgerRadioButton3);
            groupBox1.Controls.Add(burgerRadioButton2);
            groupBox1.Controls.Add(burgerRadioButton1);
            groupBox1.Font = new Font("맑은 고딕", 12F);
            groupBox1.Location = new Point(39, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 328);
            groupBox1.TabIndex = 2;
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
            // burgerRadioButton3
            // 
            burgerRadioButton3.AutoSize = true;
            burgerRadioButton3.Font = new Font("맑은 고딕", 10F);
            burgerRadioButton3.Location = new Point(13, 241);
            burgerRadioButton3.Name = "burgerRadioButton3";
            burgerRadioButton3.Size = new Size(99, 27);
            burgerRadioButton3.TabIndex = 3;
            burgerRadioButton3.Text = "치킨버거";
            burgerRadioButton3.UseVisualStyleBackColor = true;
            burgerRadioButton3.CheckedChanged += burgerRadioButton3_CheckedChanged;
            // 
            // burgerRadioButton2
            // 
            burgerRadioButton2.AutoSize = true;
            burgerRadioButton2.Font = new Font("맑은 고딕", 10F);
            burgerRadioButton2.Location = new Point(13, 153);
            burgerRadioButton2.Name = "burgerRadioButton2";
            burgerRadioButton2.Size = new Size(116, 27);
            burgerRadioButton2.TabIndex = 2;
            burgerRadioButton2.Text = "불고기버거";
            burgerRadioButton2.UseVisualStyleBackColor = true;
            burgerRadioButton2.CheckedChanged += burgerRadioButton2_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optionCheckBox4);
            groupBox2.Controls.Add(optionCheckBox3);
            groupBox2.Controls.Add(optionCheckBox2);
            groupBox2.Controls.Add(optionCheckBox1);
            groupBox2.Font = new Font("맑은 고딕", 12F);
            groupBox2.Location = new Point(318, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 222);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // optionCheckBox4
            // 
            optionCheckBox4.AutoSize = true;
            optionCheckBox4.Location = new Point(21, 174);
            optionCheckBox4.Name = "optionCheckBox4";
            optionCheckBox4.Size = new Size(121, 32);
            optionCheckBox4.TabIndex = 3;
            optionCheckBox4.Text = "소스 추가";
            optionCheckBox4.UseVisualStyleBackColor = true;
            optionCheckBox4.CheckedChanged += optionCheckBox4_CheckedChanged;
            // 
            // optionCheckBox3
            // 
            optionCheckBox3.AutoSize = true;
            optionCheckBox3.Location = new Point(21, 132);
            optionCheckBox3.Name = "optionCheckBox3";
            optionCheckBox3.Size = new Size(121, 32);
            optionCheckBox3.TabIndex = 2;
            optionCheckBox3.Text = "치즈 추가";
            optionCheckBox3.UseVisualStyleBackColor = true;
            optionCheckBox3.CheckedChanged += optionCheckBox3_CheckedChanged;
            // 
            // optionCheckBox2
            // 
            optionCheckBox2.AutoSize = true;
            optionCheckBox2.Location = new Point(21, 88);
            optionCheckBox2.Name = "optionCheckBox2";
            optionCheckBox2.Size = new Size(74, 32);
            optionCheckBox2.TabIndex = 1;
            optionCheckBox2.Text = "콜라";
            optionCheckBox2.UseVisualStyleBackColor = true;
            optionCheckBox2.CheckedChanged += optionCheckBox2_CheckedChanged;
            // 
            // optionCheckBox1
            // 
            optionCheckBox1.AutoSize = true;
            optionCheckBox1.Location = new Point(21, 43);
            optionCheckBox1.Name = "optionCheckBox1";
            optionCheckBox1.Size = new Size(114, 32);
            optionCheckBox1.TabIndex = 0;
            optionCheckBox1.Text = "감자튀김";
            optionCheckBox1.UseVisualStyleBackColor = true;
            optionCheckBox1.CheckedChanged += optionCheckBox1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(totalCostLbl);
            groupBox3.Controls.Add(orderListBox);
            groupBox3.Font = new Font("맑은 고딕", 12F);
            groupBox3.Location = new Point(526, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 261);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // totalCostLbl
            // 
            totalCostLbl.Location = new Point(18, 212);
            totalCostLbl.Name = "totalCostLbl";
            totalCostLbl.Size = new Size(161, 40);
            totalCostLbl.TabIndex = 1;
            totalCostLbl.Text = "총 금액 : 0원";
            totalCostLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.Location = new Point(18, 40);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(209, 172);
            orderListBox.TabIndex = 0;
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(526, 384);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(113, 54);
            orderBtn.TabIndex = 6;
            orderBtn.Text = "주문하기";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // initBtn
            // 
            initBtn.Location = new Point(655, 384);
            initBtn.Name = "initBtn";
            initBtn.Size = new Size(115, 54);
            initBtn.TabIndex = 7;
            initBtn.Text = "초기화";
            initBtn.UseVisualStyleBackColor = true;
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
            Controls.Add(titleLbl);
            Name = "Form1";
            Text = "Form1";
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

        private Label titleLbl;
        private RadioButton burgerRadioButton1;
        private GroupBox groupBox1;
        private RadioButton burgerRadioButton3;
        private RadioButton burgerRadioButton2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label totalCostLbl;
        private ListBox orderListBox;
        private PictureBox burgerPictureBox3;
        private PictureBox burgerPictureBox2;
        private PictureBox burgerPictureBox1;
        private CheckBox optionCheckBox4;
        private CheckBox optionCheckBox3;
        private CheckBox optionCheckBox2;
        private CheckBox optionCheckBox1;
        private Button orderBtn;
        private Button initBtn;
    }
}
