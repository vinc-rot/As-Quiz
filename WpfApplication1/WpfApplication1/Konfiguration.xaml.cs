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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für Konfiguration.xaml
    /// </summary>
    public partial class Konfiguration : Window
    {
        
        public Konfiguration()
        {
            InitializeComponent();
          
        }

        private void btnbacktostart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            
            mainwindow.Show();

            this.Close();
        }

        private void btnHistDelete_Click(object sender, RoutedEventArgs e)
        {   
            MainWindow mainwindow = new MainWindow();
            mainwindow.listHistorie.Items.Clear();
        }

        // - KonfigurationSheet
        public void UeberschriftColorChange()
        {

        }

        private void btnhistdelete_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow2 = new MainWindow();
            mainwindow2.listHistorie.Items.Clear();
            if (mainwindow2.listHistorie.Items.IsEmpty)
            {
                MessageBox.Show("Die History wurde erfolgreich gelöscht!","Erfolgreich!",MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Es gab einen Fehler beim Versuch, die History zu säubern!","Error!",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
    }
}
