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

namespace menu_Ricciotti.ClassiFinestre.View
{
    /// <summary>
    /// Logica di interazione per Pane.xaml
    /// </summary>
    public partial class Pane : UserControl
    {
        public Pane()
        {
            InitializeComponent();

            int a = MainWindow.a2;
            switch (a)
            {
                case 1:
                    tipo1.IsChecked = true;
                    break;
                case 2:
                    tipo2.IsChecked = true;
                    break;
                case 3:
                    tipo3.IsChecked = true;
                    break;
                case 4:
                    tipo4.IsChecked = true;
                    break;
            }

        }

        private void tipo1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.a2 = 1;
        }

        private void tipo2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.a2 = 2;
        }

        private void tipo3_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.a2 = 3;
        }

        private void tipo4_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.a2 = 4;
        }
    }
}
