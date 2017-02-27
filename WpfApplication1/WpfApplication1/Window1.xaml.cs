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
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            Random rnd = new Random(253);

            InitializeComponent();
            Krebs_DB012Entities dbverbindung = new Krebs_DB012Entities();
            fragenquery = dbverbindung.T_SBF_Binnen.Select(x => x.Frage);

            lblFrage.Content = fragenquery.ElementAt(rnd.Next).ToString;

        }
    }
}
