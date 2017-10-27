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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service(); 

            Person currentPerson = new Person()
            {
                Name=nameTextBox.Text,
                Surname=surnameTextBox.Text,
                DateOfBirth=dateOfBirthDatePicker.SelectedDate,
                Telephone=telephoneTextBox.Text,
            };

            if (service.CheckPerson(currentPerson))
            {
                User currentUser = new User()
                {
                    Person = currentPerson,
                    PIN = PINTextBox.Text,
                    Password = passwordTextBox.Text
                };
                if (service.CheckUser(currentUser)&&(passwordTextBox.Text==confirmPasswordTextBox.Text))
                {
                    errorLabel.Content = "Регистрация прошла успешно";
                    service.Register(currentUser);
                    Close();
                }
                else {
                    errorLabel.Content = "Ошибка ввода ИИНа или пароля";
                }
            }
            else
            {
                errorLabel.Content = "Ошибка заполнения";
            }
        }
    }
}
