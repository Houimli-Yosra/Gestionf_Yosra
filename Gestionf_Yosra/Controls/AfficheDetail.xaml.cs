using Gestionf_Yosra.Model;
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

namespace Gestionf_Yosra.Controls
{
    /// <summary>
    /// Logique d'interaction pour AfficheDetail.xaml
    /// </summary>
    public partial class AfficheDetail : Window
    {
      public static  Personne p = new Personne();
        public AfficheDetail()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(MainWindow.film != null)
            {
                foreach (Film f in MainWindow.film)
                {
                  

                    dataGrid1.ItemsSource = f.acteurs_film;
                    //dataGrid1.ItemsSource = f.acteur_role;
                    dataGrid2.ItemsSource = f.producteus_film;
                    dataGrid3.ItemsSource = f.realisateus_film;
                    //dataGrid4.ItemsSource = f.Titre;
                    AfficheBox1.Text = f.Titre;
                    AfficheBox2.Text = f.Genre;
                    AfficheBox3.Text = f.Annee.ToString();


                }
                 

            }
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //dataGrid1.ItemsSource = f.acteurs_film;
           

            DataGrid dg = sender as DataGrid; 
            p = (Personne)dg.SelectedItems[0];
        
            //donc maintenant je dois obtenir le film que j'ai lors de la recherche
            

            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string r = AfficheBox.Text;
            ActeurRole Acteur_role = new ActeurRole();
            Acteur_role.Acteur = p;
            Acteur_role.role = r;
            MainWindow.Film1.acteur_role.Add(Acteur_role);

        }
    }
}
