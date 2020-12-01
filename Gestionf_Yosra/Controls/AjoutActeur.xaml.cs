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
    /// Logique d'interaction pour AjoutActeur.xaml
    /// </summary>
    public partial class AjoutActeur : Window
    {
        public  Film film1 =new Film();
        public static List<Film> Films;
        public AjoutActeur()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne();
          
            p.Nom = ActeurBox1.Text;
            p.Prenom= ActeurBox2.Text;
            p.Age=int.Parse( ActeurBox3.Text);

          
            //film1.Titre = FilmsControls.f.Titre;
            //film1.Annee = FilmsControls.f.Annee;
            film1.acteurs_film.Add(p);
            //PersonneControls.personnes.Add(p);
            FilmsControls.films.ForEach(c => c.acteurs_film.Add(p));







        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Personne> personne = new List<Personne>();
            foreach(Personne p in film1.acteurs_film)
            {
                if(p.Nom== ActeurBox4.Text || p.Prenom== ActeurBox4.Text)
                {

                    personne.Add(p);
                    
                }
                dataGridActeur.ItemsSource = personne;
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
