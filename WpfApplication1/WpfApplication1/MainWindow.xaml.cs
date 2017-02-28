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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();


            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {

            
            if (txtUsername.Text == "")
            {
                txtUsername.Background = Brushes.Red;

                MessageBox.Show("Bitte geben Sie ihren Usernamen an um fortfahren zu können");
            }
            else
            {

                Prüfung prüfung = new Prüfung();
                prüfung.Show();
                prüfung.lblUsername.Content = txtUsername.Text;
                this.Close();
                 
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnconfig_Click(object sender, RoutedEventArgs e)
        {
            
            Konfiguration konfiguration = new Konfiguration();
            konfiguration.Show();
            this.Close();

        }

        private void txtUsername_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void DropFragelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
   }
}

