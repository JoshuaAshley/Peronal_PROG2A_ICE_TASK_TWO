namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    partial class FinanceApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceApplication));
            TitlePanel = new Panel();
            TitleIcon = new PictureBox();
            Title = new Label();
            InputPanel = new Panel();
            InputsTitle = new Label();
            EnterDetails = new Button();
            tbMonthlyExpenses = new TextBox();
            MonthlyExpenses = new Label();
            tbMonthlyTaxDeductions = new TextBox();
            MonthlyTaxDeductions = new Label();
            tbMonthlyGrossIncome = new TextBox();
            MonthlyGrossIncome = new Label();
            BuyOrRentPanel = new Panel();
            ChooseAPlan = new Label();
            SubmitPlan = new Button();
            BuyOrRentCmb = new ComboBox();
            PlanDetailsPanel = new Panel();
            Proceed = new Button();
            PlanDetails = new Label();
            LastPanel = new Panel();
            AmountLeftTitle = new Label();
            CalculateTotalLeft = new Button();
            button1 = new Button();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitleIcon).BeginInit();
            InputPanel.SuspendLayout();
            BuyOrRentPanel.SuspendLayout();
            PlanDetailsPanel.SuspendLayout();
            LastPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.ButtonFace;
            TitlePanel.BorderStyle = BorderStyle.FixedSingle;
            TitlePanel.Controls.Add(TitleIcon);
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(-8, -5);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(909, 72);
            TitlePanel.TabIndex = 0;
            // 
            // TitleIcon
            // 
            TitleIcon.BackColor = SystemColors.ButtonFace;
            TitleIcon.Image = (Image)resources.GetObject("TitleIcon.Image");
            TitleIcon.Location = new Point(73, 7);
            TitleIcon.Name = "TitleIcon";
            TitleIcon.Size = new Size(60, 62);
            TitleIcon.TabIndex = 1;
            TitleIcon.TabStop = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(73, 0);
            Title.Name = "Title";
            Title.Size = new Size(831, 70);
            Title.TabIndex = 0;
            Title.Text = "Welcome to your Personal Finance App";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.FromArgb(204, 229, 255);
            InputPanel.BorderStyle = BorderStyle.FixedSingle;
            InputPanel.Controls.Add(InputsTitle);
            InputPanel.Controls.Add(EnterDetails);
            InputPanel.Controls.Add(tbMonthlyExpenses);
            InputPanel.Controls.Add(MonthlyExpenses);
            InputPanel.Controls.Add(tbMonthlyTaxDeductions);
            InputPanel.Controls.Add(MonthlyTaxDeductions);
            InputPanel.Controls.Add(tbMonthlyGrossIncome);
            InputPanel.Controls.Add(MonthlyGrossIncome);
            InputPanel.Location = new Point(27, 93);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(339, 423);
            InputPanel.TabIndex = 1;
            // 
            // InputsTitle
            // 
            InputsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputsTitle.BackColor = SystemColors.ButtonFace;
            InputsTitle.BorderStyle = BorderStyle.FixedSingle;
            InputsTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InputsTitle.Location = new Point(3, -1);
            InputsTitle.Name = "InputsTitle";
            InputsTitle.Size = new Size(331, 56);
            InputsTitle.TabIndex = 1;
            InputsTitle.Text = "Details";
            InputsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EnterDetails
            // 
            EnterDetails.BackColor = SystemColors.ButtonFace;
            EnterDetails.FlatAppearance.BorderColor = Color.Black;
            EnterDetails.FlatAppearance.MouseDownBackColor = Color.White;
            EnterDetails.FlatAppearance.MouseOverBackColor = Color.Silver;
            EnterDetails.FlatStyle = FlatStyle.Flat;
            EnterDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EnterDetails.Location = new Point(18, 315);
            EnterDetails.Name = "EnterDetails";
            EnterDetails.Size = new Size(300, 84);
            EnterDetails.TabIndex = 8;
            EnterDetails.Text = "Submit";
            EnterDetails.UseVisualStyleBackColor = false;
            EnterDetails.Click += EnterDetails_Click;
            // 
            // tbMonthlyExpenses
            // 
            tbMonthlyExpenses.BorderStyle = BorderStyle.FixedSingle;
            tbMonthlyExpenses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthlyExpenses.Location = new Point(15, 254);
            tbMonthlyExpenses.Name = "tbMonthlyExpenses";
            tbMonthlyExpenses.Size = new Size(303, 38);
            tbMonthlyExpenses.TabIndex = 7;
            // 
            // MonthlyExpenses
            // 
            MonthlyExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MonthlyExpenses.BackColor = Color.FromArgb(204, 229, 255);
            MonthlyExpenses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MonthlyExpenses.Location = new Point(15, 215);
            MonthlyExpenses.Name = "MonthlyExpenses";
            MonthlyExpenses.Size = new Size(296, 36);
            MonthlyExpenses.TabIndex = 6;
            MonthlyExpenses.Text = "Monthly Expenses (Other)";
            MonthlyExpenses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMonthlyTaxDeductions
            // 
            tbMonthlyTaxDeductions.BorderStyle = BorderStyle.FixedSingle;
            tbMonthlyTaxDeductions.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthlyTaxDeductions.Location = new Point(15, 174);
            tbMonthlyTaxDeductions.Name = "tbMonthlyTaxDeductions";
            tbMonthlyTaxDeductions.Size = new Size(303, 38);
            tbMonthlyTaxDeductions.TabIndex = 5;
            // 
            // MonthlyTaxDeductions
            // 
            MonthlyTaxDeductions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MonthlyTaxDeductions.BackColor = Color.FromArgb(204, 229, 255);
            MonthlyTaxDeductions.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MonthlyTaxDeductions.Location = new Point(15, 135);
            MonthlyTaxDeductions.Name = "MonthlyTaxDeductions";
            MonthlyTaxDeductions.Size = new Size(296, 36);
            MonthlyTaxDeductions.TabIndex = 4;
            MonthlyTaxDeductions.Text = "Monthly Tax Deductions";
            MonthlyTaxDeductions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMonthlyGrossIncome
            // 
            tbMonthlyGrossIncome.BorderStyle = BorderStyle.FixedSingle;
            tbMonthlyGrossIncome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthlyGrossIncome.Location = new Point(15, 94);
            tbMonthlyGrossIncome.Name = "tbMonthlyGrossIncome";
            tbMonthlyGrossIncome.Size = new Size(303, 38);
            tbMonthlyGrossIncome.TabIndex = 3;
            // 
            // MonthlyGrossIncome
            // 
            MonthlyGrossIncome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MonthlyGrossIncome.BackColor = Color.FromArgb(204, 229, 255);
            MonthlyGrossIncome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MonthlyGrossIncome.Location = new Point(15, 55);
            MonthlyGrossIncome.Name = "MonthlyGrossIncome";
            MonthlyGrossIncome.Size = new Size(296, 36);
            MonthlyGrossIncome.TabIndex = 2;
            MonthlyGrossIncome.Text = "Monthly Gross Income";
            MonthlyGrossIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BuyOrRentPanel
            // 
            BuyOrRentPanel.BackColor = Color.FromArgb(204, 229, 255);
            BuyOrRentPanel.BorderStyle = BorderStyle.FixedSingle;
            BuyOrRentPanel.Controls.Add(ChooseAPlan);
            BuyOrRentPanel.Controls.Add(SubmitPlan);
            BuyOrRentPanel.Controls.Add(BuyOrRentCmb);
            BuyOrRentPanel.Enabled = false;
            BuyOrRentPanel.Location = new Point(391, 93);
            BuyOrRentPanel.Name = "BuyOrRentPanel";
            BuyOrRentPanel.Size = new Size(478, 189);
            BuyOrRentPanel.TabIndex = 3;
            // 
            // ChooseAPlan
            // 
            ChooseAPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChooseAPlan.BackColor = SystemColors.ButtonFace;
            ChooseAPlan.BorderStyle = BorderStyle.FixedSingle;
            ChooseAPlan.Enabled = false;
            ChooseAPlan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ChooseAPlan.Location = new Point(3, -1);
            ChooseAPlan.Name = "ChooseAPlan";
            ChooseAPlan.Size = new Size(470, 56);
            ChooseAPlan.TabIndex = 2;
            ChooseAPlan.Text = "Choose a Plan";
            ChooseAPlan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitPlan
            // 
            SubmitPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitPlan.BackColor = SystemColors.ButtonFace;
            SubmitPlan.Enabled = false;
            SubmitPlan.FlatAppearance.BorderColor = Color.Black;
            SubmitPlan.FlatAppearance.MouseDownBackColor = Color.White;
            SubmitPlan.FlatAppearance.MouseOverBackColor = Color.Silver;
            SubmitPlan.FlatStyle = FlatStyle.Flat;
            SubmitPlan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitPlan.Location = new Point(22, 124);
            SubmitPlan.Name = "SubmitPlan";
            SubmitPlan.Size = new Size(426, 52);
            SubmitPlan.TabIndex = 9;
            SubmitPlan.Text = "Submit";
            SubmitPlan.UseVisualStyleBackColor = false;
            SubmitPlan.Click += SubmitPlan_Click;
            // 
            // BuyOrRentCmb
            // 
            BuyOrRentCmb.BackColor = SystemColors.Window;
            BuyOrRentCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            BuyOrRentCmb.Enabled = false;
            BuyOrRentCmb.FlatStyle = FlatStyle.Flat;
            BuyOrRentCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BuyOrRentCmb.FormattingEnabled = true;
            BuyOrRentCmb.Items.AddRange(new object[] { "Buying a property", "Renting a property" });
            BuyOrRentCmb.Location = new Point(22, 70);
            BuyOrRentCmb.Name = "BuyOrRentCmb";
            BuyOrRentCmb.Size = new Size(426, 39);
            BuyOrRentCmb.TabIndex = 0;
            // 
            // PlanDetailsPanel
            // 
            PlanDetailsPanel.BackColor = Color.FromArgb(204, 229, 255);
            PlanDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            PlanDetailsPanel.Controls.Add(Proceed);
            PlanDetailsPanel.Controls.Add(PlanDetails);
            PlanDetailsPanel.Enabled = false;
            PlanDetailsPanel.Location = new Point(391, 309);
            PlanDetailsPanel.Name = "PlanDetailsPanel";
            PlanDetailsPanel.Size = new Size(478, 207);
            PlanDetailsPanel.TabIndex = 4;
            // 
            // Proceed
            // 
            Proceed.BackColor = SystemColors.ButtonFace;
            Proceed.Enabled = false;
            Proceed.FlatAppearance.BorderColor = Color.Black;
            Proceed.FlatAppearance.MouseDownBackColor = Color.White;
            Proceed.FlatAppearance.MouseOverBackColor = Color.Silver;
            Proceed.FlatStyle = FlatStyle.Flat;
            Proceed.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Proceed.Location = new Point(22, 99);
            Proceed.Name = "Proceed";
            Proceed.Size = new Size(426, 63);
            Proceed.TabIndex = 9;
            Proceed.Text = "Proceed";
            Proceed.UseVisualStyleBackColor = false;
            Proceed.Click += Proceed_Click;
            // 
            // PlanDetails
            // 
            PlanDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlanDetails.BackColor = SystemColors.ButtonFace;
            PlanDetails.BorderStyle = BorderStyle.FixedSingle;
            PlanDetails.Enabled = false;
            PlanDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlanDetails.Location = new Point(3, 0);
            PlanDetails.Name = "PlanDetails";
            PlanDetails.Size = new Size(470, 56);
            PlanDetails.TabIndex = 3;
            PlanDetails.Text = "Text";
            PlanDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LastPanel
            // 
            LastPanel.BackColor = SystemColors.ButtonFace;
            LastPanel.BorderStyle = BorderStyle.FixedSingle;
            LastPanel.Controls.Add(AmountLeftTitle);
            LastPanel.Enabled = false;
            LastPanel.Location = new Point(391, 539);
            LastPanel.Name = "LastPanel";
            LastPanel.Size = new Size(478, 73);
            LastPanel.TabIndex = 0;
            // 
            // AmountLeftTitle
            // 
            AmountLeftTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountLeftTitle.Enabled = false;
            AmountLeftTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLeftTitle.Location = new Point(23, -1);
            AmountLeftTitle.Name = "AmountLeftTitle";
            AmountLeftTitle.Size = new Size(453, 72);
            AmountLeftTitle.TabIndex = 1;
            AmountLeftTitle.Text = "R";
            AmountLeftTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CalculateTotalLeft
            // 
            CalculateTotalLeft.BackColor = SystemColors.ButtonFace;
            CalculateTotalLeft.Enabled = false;
            CalculateTotalLeft.FlatAppearance.BorderColor = Color.Black;
            CalculateTotalLeft.FlatAppearance.MouseDownBackColor = Color.White;
            CalculateTotalLeft.FlatAppearance.MouseOverBackColor = Color.Silver;
            CalculateTotalLeft.FlatStyle = FlatStyle.Flat;
            CalculateTotalLeft.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateTotalLeft.Location = new Point(27, 539);
            CalculateTotalLeft.Name = "CalculateTotalLeft";
            CalculateTotalLeft.Size = new Size(339, 73);
            CalculateTotalLeft.TabIndex = 10;
            CalculateTotalLeft.Text = "Calculate Total Left";
            CalculateTotalLeft.UseVisualStyleBackColor = false;
            CalculateTotalLeft.Click += CalculateTotalLeft_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // FinanceApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 57, 87);
            ClientSize = new Size(894, 639);
            Controls.Add(CalculateTotalLeft);
            Controls.Add(LastPanel);
            Controls.Add(PlanDetailsPanel);
            Controls.Add(BuyOrRentPanel);
            Controls.Add(InputPanel);
            Controls.Add(TitlePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FinanceApplication";
            Text = "PERSONAL FINANCE APPLICATION";
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TitleIcon).EndInit();
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            BuyOrRentPanel.ResumeLayout(false);
            PlanDetailsPanel.ResumeLayout(false);
            LastPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private PictureBox TitleIcon;
        private Panel InputPanel;
        private Label InputsTitle;
        private Label MonthlyGrossIncome;
        private TextBox tbMonthlyGrossIncome;
        private TextBox tbMonthlyTaxDeductions;
        private Label MonthlyTaxDeductions;
        private Button EnterDetails;
        private TextBox tbMonthlyExpenses;
        private Label MonthlyExpenses;
        private Panel BuyOrRentPanel;
        private ComboBox BuyOrRentCmb;
        private Label ChooseAPlan;
        private Button SubmitPlan;
        private Panel PlanDetailsPanel;
        private Label PlanDetails;
        private Button Proceed;
        private Panel LastPanel;
        private Button button1;
        private Button CalculateTotalLeft;
        private Label AmountLeftTitle;
    }
}