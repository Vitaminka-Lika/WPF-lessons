using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KaspyBankCredit
{
    /// <summary>
    /// Логика взаимодействия для CreditWindow.xaml
    /// </summary>
    public partial class CreditWindow : Window
    {
        Service service = new Service();
        User user = new User();

        public CreditWindow()
        {
            InitializeComponent();
        }

        private void MoneySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            moneyTextBox.Text = moneySlider.Value.ToString();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            bool isParsed = false;
            bool firstIsParsed = Int32.TryParse(moneyTextBox.Text, out int firstResult);
            bool secondIsParsed = Int32.TryParse(monthTextBox.Text, out int secondResult);
            bool thirdIsParsed = Double.TryParse(InitialFeeTextBox.Text, out double thirdResult);

            isParsed = firstIsParsed && secondIsParsed && thirdIsParsed;
            if (isParsed)
            {
                Request request = new Request()
                {
                    Borrower = user,
                    AmountOfCredit = Int32.Parse(moneyTextBox.Text),
                    LoanRepaymentPeriod = Int32.Parse(monthTextBox.Text),
                    InitialFee=Double.Parse(InitialFeeTextBox.Text)
                };
                if (service.CheckRequest(request))
                {
                    errorLabel.Content = "Заявка успешно принята";
                    //service.Clear();
                }
                else
                {
                    errorLabel.Content = "Ошибка ввода";
                }
            }
            else {
                errorLabel.Content = "Ошибка ввода";
            }
        }

        public void GetCurrentUser(ref User currentUser)
        {
            user = currentUser;
        }
    }
}
