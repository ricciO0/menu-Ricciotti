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
    /// Logica di interazione per Conto.xaml
    /// </summary>
    public partial class Conto : UserControl
    {
        public Conto()
        {
            InitializeComponent();

            for (int i = 1; i < 6; i++)
            {
                int a=0;
                switch (i)
                {
                    case 1:
                        a = MainWindow.a1;
                        switch (a)
                        {
                            case 1:
                                Tipo.Text = " Panino Piccolo";
                                Totale.Text = "CONTO = 8,00€";
                                break;
                            case 2:
                                Tipo.Text = " Panino Medio";
                                Totale.Text = "CONTO = 10,00€";
                                break;
                            case 3:
                                Tipo.Text = " Panino Grande";
                                Totale.Text = "CONTO = 13,00€";
                                break;
                            case 4:
                                Tipo.Text = " Panino Enorme";
                                Totale.Text = "CONTO = 16,00€";
                                break;
                        }
                        break;
                    case 2:
                        a = MainWindow.a2;
                        switch (a)
                        {
                            case 1:
                                Pane.Text = " Pane a Ciabatta";
                                break;
                            case 2:
                                Pane.Text = " Pane di Segale";
                                break;
                            case 3:
                                Pane.Text = " Pane Turco";
                                break;
                            case 4:
                                Pane.Text = " Pane Classico";
                                break;
                        }
                        break;
                    case 3:
                        a = MainWindow.a3;
                        switch (a)
                        {
                            case 1:
                                Hamburger.Text = " Angus Texano";
                                break;
                            case 2:
                                Hamburger.Text = " Wurstel";
                                break;
                            case 3:
                                Hamburger.Text = " Pollo";
                                break;
                            case 4:
                                Hamburger.Text = " Tonno";
                                break;
                        }
                        break;
                    case 4:
                        a = MainWindow.a4;
                        switch (a)
                        {
                            case 1:
                                Formaggio.Text = " Cheddar";
                                break;
                            case 2:
                                Formaggio.Text = " Gorgonzola";
                                break;
                            case 3:
                                Formaggio.Text = " Philadelpia";
                                break;
                            case 4:
                                Formaggio.Text = " Scamorza Affumicata";
                                break;
                        }
                        break;
                    case 5:
                        a = MainWindow.a5;
                        switch (a)
                        {
                            case 1:
                                Salsa.Text = " Salsa Maionese";
                                break;
                            case 2:
                                Salsa.Text = " Salsa Ketchap";
                                break;
                            case 3:
                                Salsa.Text = " Salsa Senape";
                                break;
                            case 4:
                                Salsa.Text = " Salsa BBQ";
                                break;
                        }
                        break;
                }

 
            }
        }

        private void Paga_Click(object sender, RoutedEventArgs e)
        {
            if(Tipo.Text == "-")
            {
                MessageBox.Show("Scegli un Formato di panino", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Ritira il panino alla cassa", "Grazie E Arrivederci", MessageBoxButton.OK);
                Application.Current.Shutdown();
            }
        }
    }
}
