namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    partial class BuyingPropertyDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitlePanel = new Panel();
            Title = new Label();
            InputPanel = new Panel();
            NoMonthsCmb = new ComboBox();
            EnterDetails = new Button();
            NoMonths = new Label();
            InterestRate = new Label();
            tbInterestRate = new TextBox();
            TotalDeposit = new Label();
            tbTotalDeposit = new TextBox();
            PropertyTotalPrice = new Label();
            tbPropertyTotalPrice = new TextBox();
            TitlePanel.SuspendLayout();
            InputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.ButtonFace;
            TitlePanel.BorderStyle = BorderStyle.FixedSingle;
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(-37, -1);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(905, 58);
            TitlePanel.TabIndex = 2;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(134, -2);
            Title.Name = "Title";
            Title.Size = new Size(238, 58);
            Title.TabIndex = 0;
            Title.Text = "Details";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.FromArgb(204, 229, 255);
            InputPanel.BorderStyle = BorderStyle.FixedSingle;
            InputPanel.Controls.Add(NoMonthsCmb);
            InputPanel.Controls.Add(EnterDetails);
            InputPanel.Controls.Add(NoMonths);
            InputPanel.Controls.Add(InterestRate);
            InputPanel.Controls.Add(tbInterestRate);
            InputPanel.Controls.Add(TotalDeposit);
            InputPanel.Controls.Add(tbTotalDeposit);
            InputPanel.Controls.Add(PropertyTotalPrice);
            InputPanel.Controls.Add(tbPropertyTotalPrice);
            InputPanel.Location = new Point(24, 77);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(390, 463);
            InputPanel.TabIndex = 3;
            // 
            // NoMonthsCmb
            // 
            NoMonthsCmb.FlatStyle = FlatStyle.Flat;
            NoMonthsCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NoMonthsCmb.FormattingEnabled = true;
            NoMonthsCmb.Items.AddRange(new object[] { "240", "300", "360" });
            NoMonthsCmb.Location = new Point(43, 295);
            NoMonthsCmb.Name = "NoMonthsCmb";
            NoMonthsCmb.Size = new Size(303, 39);
            NoMonthsCmb.TabIndex = 23;
            // 
            // EnterDetails
            // 
            EnterDetails.BackColor = SystemColors.ButtonFace;
            EnterDetails.FlatAppearance.BorderColor = Color.Black;
            EnterDetails.FlatAppearance.MouseDownBackColor = Color.White;
            EnterDetails.FlatAppearance.MouseOverBackColor = Color.Silver;
            EnterDetails.FlatStyle = FlatStyle.Flat;
            EnterDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EnterDetails.Location = new Point(43, 354);
            EnterDetails.Name = "EnterDetails";
            EnterDetails.Size = new Size(303, 84);
            EnterDetails.TabIndex = 22;
            EnterDetails.Text = "Submit";
            EnterDetails.UseVisualStyleBackColor = false;
            EnterDetails.Click += EnterDetails_Click;
            // 
            // NoMonths
            // 
            NoMonths.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NoMonths.BackColor = Color.FromArgb(204, 229, 255);
            NoMonths.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NoMonths.Location = new Point(43, 256);
            NoMonths.Name = "NoMonths";
            NoMonths.Size = new Size(296, 36);
            NoMonths.TabIndex = 21;
            NoMonths.Text = "Number Of Months";
            NoMonths.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InterestRate
            // 
            InterestRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InterestRate.BackColor = Color.FromArgb(204, 229, 255);
            InterestRate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            InterestRate.Location = new Point(43, 176);
            InterestRate.Name = "InterestRate";
            InterestRate.Size = new Size(296, 36);
            InterestRate.TabIndex = 19;
            InterestRate.Text = "Interest Rate";
            InterestRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbInterestRate
            // 
            tbInterestRate.BorderStyle = BorderStyle.FixedSingle;
            tbInterestRate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbInterestRate.Location = new Point(43, 215);
            tbInterestRate.Name = "tbInterestRate";
            tbInterestRate.Size = new Size(303, 38);
            tbInterestRate.TabIndex = 18;
            // 
            // TotalDeposit
            // 
            TotalDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TotalDeposit.BackColor = Color.FromArgb(204, 229, 255);
            TotalDeposit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotalDeposit.Location = new Point(43, 96);
            TotalDeposit.Name = "TotalDeposit";
            TotalDeposit.Size = new Size(296, 36);
            TotalDeposit.TabIndex = 17;
            TotalDeposit.Text = "Total Deposit";
            TotalDeposit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbTotalDeposit
            // 
            tbTotalDeposit.BorderStyle = BorderStyle.FixedSingle;
            tbTotalDeposit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbTotalDeposit.Location = new Point(43, 135);
            tbTotalDeposit.Name = "tbTotalDeposit";
            tbTotalDeposit.Size = new Size(303, 38);
            tbTotalDeposit.TabIndex = 16;
            // 
            // PropertyTotalPrice
            // 
            PropertyTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PropertyTotalPrice.BackColor = Color.FromArgb(204, 229, 255);
            PropertyTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PropertyTotalPrice.Location = new Point(43, 16);
            PropertyTotalPrice.Name = "PropertyTotalPrice";
            PropertyTotalPrice.Size = new Size(296, 36);
            PropertyTotalPrice.TabIndex = 15;
            PropertyTotalPrice.Text = "Property Total Price";
            PropertyTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPropertyTotalPrice
            // 
            tbPropertyTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            tbPropertyTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbPropertyTotalPrice.Location = new Point(43, 55);
            tbPropertyTotalPrice.Name = "tbPropertyTotalPrice";
            tbPropertyTotalPrice.Size = new Size(303, 38);
            tbPropertyTotalPrice.TabIndex = 13;
            // 
            // BuyingPropertyDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 57, 87);
            ClientSize = new Size(438, 560);
            Controls.Add(InputPanel);
            Controls.Add(TitlePanel);
            MaximizeBox = false;
            Name = "BuyingPropertyDetails";
            Text = "Buying Property Details";
            TitlePanel.ResumeLayout(false);
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private Panel InputPanel;
        private TextBox tbPropertyTotalPrice;
        private Label NoMonths;
        private Label InterestRate;
        private TextBox tbInterestRate;
        private Label TotalDeposit;
        private TextBox tbTotalDeposit;
        private Label PropertyTotalPrice;
        private Button EnterDetails;
        private ComboBox NoMonthsCmb;
    }
}