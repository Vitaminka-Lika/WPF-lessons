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

namespace _24._10._17_Binding
{
    /// <summary>
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();

            User user = new User
            {
                Id = 1,
                FullName = "Иван Иванович Иванов",
                Login = "Batman",
                Password = "Robin",
                CreationDate = DateTime.Now
            };

            // fullNameLabel.Content = user.FullName; и т.д ...тупое решение

            foreach (var element in container.Children)
            {
                (element as Label).DataContext = user;
            }

            DataContext = user;
        }
    }
}
