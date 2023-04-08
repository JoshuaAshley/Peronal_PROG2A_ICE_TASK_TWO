// Import the DataValidation namespace, which contains the Validation Class used in this program
using DataValidation;
// Import the Finances namespace, which contains the HomeLoan and Rent classes used in this program
using Finances;

// Define the namespace and class for the Finance Application form
namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    public partial class FinanceApplication : Form
    {

        // Declare variables to store user input
        public int plan;
        public double monthlyGrossIncome;
        public double taxDeductions;
        public double otherExpenses;
        public double monthlyRentAmount;
        public double propertyAmount;
        public double totalDeposit;
        public double interest;
        public int numberMonths;

        // Create a Validation object to validate user input
        Validation validator;

        // Define the constructor for the FinanceApplication form
        public FinanceApplication()
        {
            // Initialize the form and center it on the screen
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Set the Buy or Rent combo box to the default value of "Buy"
            BuyOrRentCmb.SelectedIndex = 0;

            // Initialize the Validation object
            validator = new Validation();
        }

        // Returns the value of the monthlyGrossIncome field
        public double GetMonthlyGrossIncome()
        {
            return monthlyGrossIncome;
        }

        // Returns the value of the taxDeductions field
        public double GetTaxDeductions()
        {
            return taxDeductions;
        }

        // Returns the value of the otherExpenses field
        public double GetOtherExpenses()
        {
            return otherExpenses;
        }

        // Calculate the amount of money the user has left after all expenses are accounted for
        public double calculateAmountLeft()
        {

            // Start with the user's monthly gross income
            double totalAmount = monthlyGrossIncome;

            // Subtract the user's monthly tax deductions
            totalAmount = totalAmount - taxDeductions;

            // Subtract the user's other monthly expenses
            totalAmount = totalAmount - otherExpenses;

            // If the user chose to buy a property
            if (plan == 0)
            {
                // Create a new BuyingPropertyDetails object to get the user's property details
                BuyingPropertyDetails buyingPropertyDetails = new BuyingPropertyDetails();

                // Get the total property amount from the BuyingPropertyDetails form
                propertyAmount = buyingPropertyDetails.GetTotalPropertyAmount();

                // Get the total deposit amount from the BuyingPropertyDetails form
                totalDeposit = buyingPropertyDetails.GetTotalDeposit();

                // Get the interest rate from the BuyingPropertyDetails form
                interest = buyingPropertyDetails.GetInterest();

                // Get the number of months for the home loan from the BuyingPropertyDetails form
                numberMonths = buyingPropertyDetails.GetNumberMonths();

                // Create a new HomeLoan object with the user's property details
                HomeLoan homeloans = new HomeLoan(propertyAmount, totalDeposit, interest, numberMonths);

                // Calculate the monthly expense for the home loan
                double expense = homeloans.CalculateExpense();

                // Check if the calculated expense is greater than one third of the monthly gross income
                // Display a warning message to the user as there is a likely chance that their home loan approval will not be approved
                if (expense > (monthlyGrossIncome / 3))
                {
                    MessageBox.Show("Please note that the monthly home loan repayment is\n" +
                                    "greater than a third of your total monthly gross income.\n" +
                                    "There is a likely chance that your home loan approval will not be approved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Subtract the monthly expense from the total amount the user has left
                totalAmount = totalAmount - expense;
            }
            else // If the user chose to rent a property
            {
                // Create a new RentingPropertyDetails object to get the user's rental details
                RentingPropertyDetails rentingPropertyDetails = new RentingPropertyDetails();

                // Get the monthly rent amount from the RentingPropertyDetails form
                monthlyRentAmount = rentingPropertyDetails.GetMonthlyRentAmount();

                // Create a new Rent object with the user's monthly rent amount
                Rent rent = new Rent(monthlyRentAmount);

                // Calculate the monthly expense for rent
                double expense = rent.CalculateExpense();

                // Subtract the monthly expense from the total amount the user has left
                totalAmount = totalAmount - expense;
            }

            // Return the total amount the user has left after all expenses are accounted for
            return totalAmount;
        }

        private void EnterDetails_Click(object sender, EventArgs e)
        {
            // Enables the necessary panels and controls to allow the user to select a plan
            BuyOrRentPanel.Enabled = true;
            ChooseAPlan.Enabled = true;
            BuyOrRentCmb.Enabled = true;
            SubmitPlan.Enabled = true;

            // Validates the user input for monthly gross income, tax deductions, and other expenses
            if (validator.ValidateDoubleInput(tbMonthlyGrossIncome.Text))
            {
                monthlyGrossIncome = double.Parse(tbMonthlyGrossIncome.Text);

                if (validator.ValidateDoubleInput(tbMonthlyTaxDeductions.Text))
                {
                    taxDeductions = double.Parse(tbMonthlyTaxDeductions.Text);

                    if (validator.ValidateDoubleInput(tbMonthlyExpenses.Text))
                    {
                        otherExpenses = double.Parse(tbMonthlyExpenses.Text);

                        // Disables the input controls to prevent further editing of the values
                        tbMonthlyExpenses.Enabled = false;
                        tbMonthlyGrossIncome.Enabled = false;
                        tbMonthlyTaxDeductions.Enabled = false;
                        EnterDetails.Enabled = false;
                    }
                    else
                    {
                        // If the user input for other expenses is invalid, shows an error message and clears the control
                        MessageBox.Show("Invalid input for monthly expenses. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbMonthlyExpenses.Text = "";
                        tbMonthlyExpenses.Focus();
                    }
                }
                else
                {
                    // If the user input for tax deductions is invalid, shows an error message and clears the control
                    MessageBox.Show("Invalid input for monthly tax deductions. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMonthlyTaxDeductions.Text = "";
                    tbMonthlyTaxDeductions.Focus();
                }
            }
            else
            {
                // If the user input for monthly gross income is invalid, shows an error message and clears the control
                MessageBox.Show("Invalid input for monthly gross income. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMonthlyGrossIncome.Text = "";
                tbMonthlyGrossIncome.Focus();
            }
        }

        private void SubmitPlan_Click(object sender, EventArgs e)
        {
            // Enables the panel and controls to show plan details and allows the user to proceed to the next step
            PlanDetailsPanel.Enabled = true;
            plan = BuyOrRentCmb.SelectedIndex;
            if (plan == 0)
            {
                PlanDetails.Text = "Buy a Property Details";
                PlanDetails.Enabled = true;
            }
            else
            {
                PlanDetails.Text = "Rent a Property Details";
                PlanDetails.Enabled = true;
            }
            Proceed.Enabled = true;

            // Disables the Buy or Rent combobox and Submit Plan button to prevent further editing of the plan selection
            BuyOrRentCmb.Enabled = false;
            SubmitPlan.Enabled = false;
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            // Depending on the user's plan selection, opens a form to collect more details for either buying or renting a property
            if (plan == 0)
            {
                BuyingPropertyDetails buyingPropertyDetails = new BuyingPropertyDetails();
                buyingPropertyDetails.Show();
            }
            else
            {
                RentingPropertyDetails rentingPropertyDetails = new RentingPropertyDetails();
                rentingPropertyDetails.Show();
            }

            // Disables the Proceed button to prevent further navigation and enables the Calculate Total Left button and the final panel
            Proceed.Enabled = false;
            CalculateTotalLeft.Enabled = true;
            LastPanel.Enabled = true;
            AmountLeftTitle.Enabled = true;
        }

        private void CalculateTotalLeft_Click(object sender, EventArgs e)
        {
            // Call the calculateAmountLeft() method to determine the total amount left after expenses
            double totalLeft = calculateAmountLeft();

            // Format the totalLeft variable as a string with two decimal places
            string totalLeftString = totalLeft.ToString("N2");

            // Determining if the user is in debt or not
            if (totalLeft >= 0)
            {
                // Update the AmountLeftTitle label with the totalLeftString value, prefixed with "R"
                AmountLeftTitle.Text = "R" + totalLeftString;
            }
            else
            {
                totalLeftString = (-totalLeft).ToString("N2");
                // Update the AmountLeftTitle label with the totalLeftString value, prefixed with "R"
                AmountLeftTitle.Text = "R" + totalLeftString + " in debt";
            }
        }
    }
}