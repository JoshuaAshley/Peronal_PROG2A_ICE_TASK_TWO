// Import the DataValidation namespace, which contains the Validation Class used in this program
using DataValidation;

namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    // This class is responsible for getting the details of a property that the user wants to buy
    public partial class BuyingPropertyDetails : Form
    {
        // Fields to hold the property details
        private static double _totalPropertyAmount;
        private static double _totalDeposit;
        private static double _interest;
        private static int _numberMonths;

        // Validation object to validate user input
        Validation validator;

        // Constructor to initialize the form
        public BuyingPropertyDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            NoMonthsCmb.SelectedIndex = 0;
            validator = new Validation();
        }

        // Getter method for total property amount
        public double GetTotalPropertyAmount()
        {
            return _totalPropertyAmount;
        }

        // Getter method for total deposit
        public double GetTotalDeposit()
        {
            return _totalDeposit;
        }

        // Getter method for interest rate
        public double GetInterest()
        {
            return _interest;
        }

        // Getter method for number of months for repayment
        public int GetNumberMonths()
        {
            return _numberMonths;
        }

        // Event handler for the button click to enter property details
        private void EnterDetails_Click(object sender, EventArgs e)
        {
            // Validate the input for total property price
            if (validator.ValidateDoubleInput(tbPropertyTotalPrice.Text))
            {
                _totalPropertyAmount = double.Parse(tbPropertyTotalPrice.Text);

                // Validate the input for total deposit
                if (validator.ValidateDoubleInput(tbTotalDeposit.Text))
                {
                    _totalDeposit = double.Parse(tbTotalDeposit.Text);

                    // Validate the input for interest rate
                    if (validator.ValidateDoubleInput(tbInterestRate.Text))
                    {
                        _interest = double.Parse(tbInterestRate.Text);
                        _numberMonths = int.Parse(NoMonthsCmb.SelectedItem.ToString());
                        FinanceApplication financeApplication = new FinanceApplication();
                        this.Close();
                    }
                    else
                    {
                        // Display an error message if the input for interest rate is invalid
                        MessageBox.Show("Invalid input for interest rate. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbInterestRate.Text = "";
                        tbInterestRate.Focus();
                    }
                }
                else
                {
                    // Display an error message if the input for total deposit is invalid
                    MessageBox.Show("Invalid input for total deposit. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbTotalDeposit.Text = "";
                    tbTotalDeposit.Focus();
                }
            }
            else
            {
                // Display an error message if the input for total property price is invalid
                MessageBox.Show("Invalid input for total property price. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPropertyTotalPrice.Text = "";
                tbPropertyTotalPrice.Focus();
            }
        }
    }
}
