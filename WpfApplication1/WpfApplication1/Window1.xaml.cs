﻿using System;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {


            InitializeComponent();




        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int fragezähler = 1;
            int maxfragen = 20;

            Krebs_DB012Entities dbverbindung = new Krebs_DB012Entities();
            IQueryable<string> fragenquery = dbverbindung.T_SBF_Binnen.Select(x => x.Frage);
            List<string> Fragen = fragenquery.ToList();

            if (fragezähler < maxfragen)
            {
                int index = rnd.Next(1, 253);
                lblFrage.Content = Fragen[index];
                fragezähler++;
                lblFragenummer.Content = fragezähler;
            }
        }
    }
}
