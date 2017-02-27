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
            Krebs_DB012Entities dbverbindung = new Krebs_DB012Entities();
            IQueryable<string> fragenquery = dbverbindung.T_SBF_Binnen.Select(x => x.Frage);

            foreach (var item in fragenquery)
            {
                DropFragelist.Items.Add(item);
            }
            //DropFragelist.ItemsSource = fragenquery.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 Fenster = new Window1();
            Fenster.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
   }
}

