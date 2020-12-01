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
    
    public partial class Recherche : Window
    {
        public static List<Personne> Personnes = new List<Personne>();
        public static Personne unePersonne = new Personne();
        public Recherche()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personnes = new List<Personne>();
            unePersonne = new Personne();
            if (PersonneControls.personnes != null)
            {
                foreach (var f in PersonneControls.personnes)
                {
                    if (RechercheBox.Text == f.Nom || RechercheBox.Text == f.Prenom )
                    {
                        unePersonne = f;
                        Personnes.Add(f);
                    }

                    
                }
                dataGridR.ItemsSource = Personnes;




            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FilmsControls.films.ForEach(c => c.realisateus_film.Add(unePersonne));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FilmsControls.films.ForEach(c => c.producteus_film.Add(unePersonne));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Film film = new Film();
            film = MainWindow.F;
            film.acteurs_film.Add(unePersonne);
            FilmsControls.films.Add(film);
            //FilmsControls.films.ForEach(c => c.acteurs_film.Add((unePersonne));
        }
    }
}
