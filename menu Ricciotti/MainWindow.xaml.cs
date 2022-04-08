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

namespace menu_Ricciotti
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var fullFilePath = @"https://i.pinimg.com/originals/5b/ae/7d/5bae7d55932a8970bce7b35a29a703ef.jpg";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            img.Source = bitmap;
            
        }

        public static int a1 = 0;
        public static int a2 = 0;
        public static int a3 = 0;
        public static int a4 = 0;
        public static int a5 = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (Home.IsChecked == true)
            {
                Home.IsChecked = false;
            }
            else if(Pane.IsChecked == true)
            {
                Pane.IsChecked = false;

            }
            else if(Hamburger.IsChecked == true)
            {
                Hamburger.IsChecked = false;
            }
            else if(Formaggio.IsChecked == true)
            {
                Formaggio.IsChecked = false;
            }
            else if(Salsa.IsChecked == true)
            {
                Salsa.IsChecked = false;
            }
        }

        private void Conto_Click(object sender, RoutedEventArgs e)
        {
            if (Home.IsChecked == true)
            {
                Home.IsChecked = false;
            }
            else if (Pane.IsChecked == true)
            {
                Pane.IsChecked = false;

            }
            else if (Hamburger.IsChecked == true)
            {
                Hamburger.IsChecked = false;
            }
            else if (Formaggio.IsChecked == true)
            {
                Formaggio.IsChecked = false;
            }
            else if (Salsa.IsChecked == true)
            {
                Salsa.IsChecked = false;
            }
        }
    }
}
