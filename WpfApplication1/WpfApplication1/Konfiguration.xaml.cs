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
            mainwindow.lblProjectName.Content = txtProgrammName.Text;
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
    }
}
