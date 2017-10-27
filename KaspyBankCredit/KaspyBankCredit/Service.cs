using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspyBankCredit
{
    public class Service
    {
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
            mainWindow.Show();
        }

        public void Register()
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        public void Accept()
        {
            CreditWindow creditWindow = new CreditWindow();
            creditWindow.ShowDialog();
        }
    }
}
