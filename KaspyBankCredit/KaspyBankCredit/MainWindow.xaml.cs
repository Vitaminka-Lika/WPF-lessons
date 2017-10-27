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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KaspyBankCredit
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service();
            service.Register();
            Hide();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            User checkThisUser = new User()
            {
                PIN=pinTextBox.Text,
                Password=passwordPasswordBox.Password
            };

            Service service = new Service();
            if (service.SignInCheck(checkThisUser))
            {
                service
            }
            else {
                errorLabel.Content = "Ошибка ввода";
            }
            Hide();
        }
    }
}
