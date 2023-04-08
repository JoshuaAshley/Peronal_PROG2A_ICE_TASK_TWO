namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    partial class RentingPropertyDetails
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
            MontlyRent = new Label();
            tbMonthlyRent = new TextBox();
            EnterDetails = new Button();
            TitlePanel.SuspendLayout();
            InputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.ButtonFace;
            TitlePanel.BorderStyle = BorderStyle.FixedSingle;
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(-54, -2);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(909, 58);
            TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(192, 1);
            Title.Name = "Title";
            Title.Size = new Size(151, 54);
            Title.TabIndex = 0;
            Title.Text = "Details";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.FromArgb(204, 229, 255);
            InputPanel.BorderStyle = BorderStyle.FixedSingle;
            InputPanel.Controls.Add(MontlyRent);
            InputPanel.Controls.Add(tbMonthlyRent);
            InputPanel.Controls.Add(EnterDetails);
            InputPanel.Location = new Point(24, 77);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(390, 223);
            InputPanel.TabIndex = 2;
            // 
            // MontlyRent
            // 
            MontlyRent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MontlyRent.BackColor = Color.FromArgb(204, 229, 255);
            MontlyRent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MontlyRent.Location = new Point(45, 18);
            MontlyRent.Name = "MontlyRent";
            MontlyRent.Size = new Size(296, 36);
            MontlyRent.TabIndex = 12;
            MontlyRent.Text = "Monthly Rent Amount";
            MontlyRent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMonthlyRent
            // 
            tbMonthlyRent.BorderStyle = BorderStyle.FixedSingle;
            tbMonthlyRent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthlyRent.Location = new Point(45, 57);
            tbMonthlyRent.Name = "tbMonthlyRent";
            tbMonthlyRent.Size = new Size(303, 38);
            tbMonthlyRent.TabIndex = 11;
            // 
            // EnterDetails
            // 
            EnterDetails.BackColor = SystemColors.ButtonFace;
            EnterDetails.FlatAppearance.BorderColor = Color.Black;
            EnterDetails.FlatAppearance.MouseDownBackColor = Color.White;
            EnterDetails.FlatAppearance.MouseOverBackColor = Color.Silver;
            EnterDetails.FlatStyle = FlatStyle.Flat;
            EnterDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EnterDetails.Location = new Point(45, 113);
            EnterDetails.Name = "EnterDetails";
            EnterDetails.Size = new Size(303, 84);
            EnterDetails.TabIndex = 9;
            EnterDetails.Text = "Submit";
            EnterDetails.UseVisualStyleBackColor = false;
            EnterDetails.Click += EnterDetails_Click;
            // 
            // RentingPropertyDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 57, 87);
            ClientSize = new Size(438, 324);
            Controls.Add(InputPanel);
            Controls.Add(TitlePanel);
            MaximizeBox = false;
            Name = "RentingPropertyDetails";
            Text = "Renting Property Details";
            TitlePanel.ResumeLayout(false);
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Label Title;
        private Panel InputPanel;
        private Button EnterDetails;
        private TextBox tbMonthlyRent;
        private Label MontlyRent;
    }
}