using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspyBankCredit
{
    public class Service
    {
        int maxAmountOfCredit = 1000000;
        int maxLoanRepaymentPeriod = 120;
        double minInitialFee = 3;
        double maxInitialFee = 3;
        List<User> users = new List<User>();

        public void GetUsers(ref List<User> currentUsers)
        {
            users = currentUsers;
        }

        public bool CheckPerson(Person currentPerson)
        {
            foreach (char symbol in currentPerson.Name)
            {
                if (Char.IsDigit(symbol))
                { return false; }
            }
            foreach(char symbol in currentPerson.Surname)
            {
                if (Char.IsDigit(symbol))
                { return false; }
            }
            if (currentPerson.DateOfBirth == null)
            { return false; }
            if (currentPerson.Telephone.Length != 11)
            {
                return false;
            }
            return true;
        }

        public bool CheckUser(User currentUser)
        {
            foreach (char symbol in currentUser.PIN)
            {
                if (!Char.IsDigit(symbol))
                { return false; }
            }
            if (currentUser.PIN.Length != 12)
            { return false; }
            return true;
        }

        public bool SignInCheck(User currnetUser)
        {
            return users.Contains(currnetUser);
        }

        public void Register(User currentUser)
        {
            users.Add(currentUser);
            MainWindow mainWindow = new MainWindow();
            mainWindow.GetUsers(ref users);
            mainWindow.Show();
        }

        public void Register()
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        public void Accept(ref User user)
        {
            CreditWindow creditWindow = new CreditWindow();
            creditWindow.GetCurrentUser(ref user);
            creditWindow.ShowDialog();
        }

        public bool CheckRequest(Request currentRequest)
        {
            if ((currentRequest.AmountOfCredit <= maxAmountOfCredit) && (currentRequest.AmountOfCredit > 0))
            {
                if ((currentRequest.LoanRepaymentPeriod <= maxLoanRepaymentPeriod) && (currentRequest.LoanRepaymentPeriod > 0))
                {
                    if (currentRequest.InitialFee >= minInitialFee && currentRequest.InitialFee <= maxInitialFee)
                    { return true; }
                }            
            }
            return false;
        }

        public void Clear(CreditWindow creditWindow)
        {
            creditWindow.moneyTextBox.Text = "";
            creditWindow.monthTextBox.Text = "";
            creditWindow.sixMonthRadioButton.IsChecked = null;
            creditWindow.twelveMonthRadioButton.IsChecked = null;
            creditWindow.thirtySixMonthRadioButton.IsChecked = null;

        }
    }
}
