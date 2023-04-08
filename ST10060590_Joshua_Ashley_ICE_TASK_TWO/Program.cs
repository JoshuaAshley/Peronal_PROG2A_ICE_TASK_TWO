// This is the entry point of the application.
// It initializes the application configuration and runs the FinanceApplication.
namespace ST10060590_Joshua_Ashley_ICE_TASK_TWO
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FinanceApplication());
        }
    }
}

// This is an abstract class for Expenses.
// It contains an abstract method to calculate the expense.
namespace Finances
{
    public abstract class Expenses
    {
        public Expenses()
        {
            // Constructor
        }

        public abstract double CalculateExpense();
    }

    // This is a concrete class for Rent expenses.
    // It takes a monthlyAmount in the constructor and calculates the expense using the overridden CalculateExpense method.
    public class Rent : Expenses
    {
        private double _monthlyAmount;

        public Rent(double monthlyAmount) : base()
        {
            _monthlyAmount = monthlyAmount;
        }

        public override double CalculateExpense()
        {
            return _monthlyAmount;
        }
    }

    // This is a concrete class for HomeLoan expenses.
    // It takes totalPropertyPrice, totalDeposit, interest and numberMonths in the constructor and calculates the expense using the overridden CalculateExpense method.
    public class HomeLoan : Expenses
    {
        private double _totalPropertyPrice;
        private double _totalDeposit;
        private double _interest;
        private int _numberMonths;

        public HomeLoan(double totalPropertyPrice, double totalDeposit, double interest, int numberMonths) : base()
        {
            _totalPropertyPrice = totalPropertyPrice;
            _totalDeposit = totalDeposit;
            _interest = interest;
            _numberMonths = numberMonths;
        }

        public override double CalculateExpense()
        {
            _interest = _interest / 100;
            double principal = _totalPropertyPrice - _totalDeposit;
            double monthlyInterestRate = _interest / 12;
            double payment = (principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, _numberMonths)) / (Math.Pow(1 + monthlyInterestRate, _numberMonths) - 1);
            return payment;
        }
    }
}

// This is a class for data validation.
// It contains methods to validate integer and double inputs.
namespace DataValidation
{
    public class Validation
    {
        public bool ValidateIntInput(string input)
        {
            if (input == null)
            {
                return false;
            }
            int result;
            return int.TryParse(input, out result);
        }

        public bool ValidateDoubleInput(string input)
        {
            if (input == null)
            {
                return false;
            }
            double result;
            return double.TryParse(input, out result);
        }
    }
}
