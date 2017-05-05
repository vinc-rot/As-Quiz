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
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Prüfung : Window
    {
        public Prüfung()
        {

            InitializeComponent();

         


        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Img_Box.Source = null;
            Random rnd = new Random();
            int fragezähler = 1;
            int maxfragen = 30;

            DatenbankEntitie dbverbindung2 = new DatenbankEntitie();
            IQueryable<string> fragenquery = dbverbindung2.T_SBF_Binnen.Select(x => x.Frage);
            List<string> Fragen = fragenquery.ToList();

           if (fragezähler <= maxfragen )
            {
                int index = rnd.Next(1, 253);
                lblFrage.Text = Fragen[index];
                if (Fragen[index].Contains("{") == true)
                ShowBild(Fragen[index]);                                           
                fragezähler++;
                lblFragenummer.Content = fragezähler++;
            } 

        }

        //Frage Parsen "REGEX"
        private void ShowBild(string frage)
        {
            try
            {
                string[] tokens = frage.Split('{', '}');
                BitmapImage bild = new BitmapImage();
                bild.BeginInit();
                bild.UriSource = new Uri(@"C:\Users\user\Pictures\" + tokens[1]);
                bild.EndInit();
                Img_Box.Source = bild;
            }
            catch
            {
                MessageBox.Show("Bild nicht gefunden");
            };

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnSubmit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubmit_Clic(object sender, RoutedEventArgs e)
        {

        }

    }
}
