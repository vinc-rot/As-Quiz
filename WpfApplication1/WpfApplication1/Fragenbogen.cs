using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Fragenbogen
    {
        // Konstruktor
        public Fragenbogen() { }
        
        // Methode zum selektieren der vorhandenen Frageboegen
        public List<int> GetFragebogen(int[] fragenID)
        {

            DatenbankEntitie dbVerbindungFragebogen = new DatenbankEntitie();
            IQueryable<int> fragenbogenquery = dbVerbindungFragebogen.T_Fragebogen_unter_Maschine.Select(x => x.FragebogenNr);
            List<int> fragenboegen = fragenbogenquery.ToList();

            //schreibt jede Fragennummer in die ListBox
            foreach (var fragenIDs in fragenboegen)
            {
                MainWindow mainwindow = new MainWindow();
                mainwindow.DropFragelist.ItemsSource = fragenboegen;
            }
            return fragenboegen;
            
        }

    }
}
