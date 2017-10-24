using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace DocumentsApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (XpsDocument document = new XpsDocument(@"z:\1.xps", FileAccess.Write))
            {
                DocumentPaginator documentPaginator = viewer.Document.DocumentPaginator;
                XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(document);
                writer.Write(documentPaginator);
            }

            using (XpsDocument document = new XpsDocument(@"z:\1.xps", FileAccess.Read))
            {
                //var reader = document.FixedDocumentSequenceReader; не нужно
                viewer.Document = document.GetFixedDocumentSequence();
            }
        }
    }
}
