// Import the DataValidation namespace, which contains the Validation Class used in this program
using DataValidation;

namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    // RentingPropertyDetails form class
    public partial class RentingPropertyDetails : Form
    {
        // private static field to hold monthly rent amount
        private static double _monthlyRentAmount;
        // instantiate a Validation object to validate input
        Validation validator;

        // RentingPropertyDetails class constructor
        public RentingPropertyDetails()
        {
            // initialize the form components
            InitializeComponent();
            // set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // initialize the Validation object
            validator = new Validation();
        }

        // Getter method to retrieve the monthly rent amount entered by the user
        public double GetMonthlyRentAmount()
        {
            return _monthlyRentAmount;
        }

        // Event handler for the Enter Details button click
        private void EnterDetails_Click(object sender, EventArgs e)
        {
            // Validate the user's input for the monthly rent amount
            if (validator.ValidateDoubleInput(tbMonthlyRent.Text))
            {
                // Parse the user's input and store it in the _monthlyRentAmount field
                _monthlyRentAmount = double.Parse(tbMonthlyRent.Text);
                // Create a new FinanceApplication form and close the current form
                FinanceApplication financeApplication = new FinanceApplication();
                this.Close();
            }
            else
            {
                // Display an error message if the user's input is invalid
                MessageBox.Show("Invalid input for monthly rent. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the text box and set focus to it for the user to enter valid input
                tbMonthlyRent.Text = "";
                tbMonthlyRent.Focus();
            }
        }
    }
}

