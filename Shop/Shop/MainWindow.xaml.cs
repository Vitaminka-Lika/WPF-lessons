using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();
            productsGrid.ItemsSource = products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            double price;
            bool isParsed = Double.TryParse(priceProductTextBox.Text,out price);
            if (isParsed)
            {
                Product product = new Product()
                {
                    Id = products.LongCount(),
                    Name = nameProductTextBox.Text,
                    Price = price,
                    ShelfLife = shelfLifedatePicker.DisplayDate.ToShortDateString()
                };

                products.Add(product);
            }
        }
    }
}
