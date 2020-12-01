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
    /// Logique d'interaction pour AjoutProducteur.xaml
    /// </summary>
    /// 
    
    public partial class AjoutProducteur : Window
    {
        public AjoutProducteur()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne();

            p.Nom = ProducteurBox1.Text;
            p.Prenom = ProducteurBox2.Text;
            p.Age = int.Parse(ProducteurBox3.Text);


            //film1.Titre = FilmsControls.f.Titre;
            //film1.Annee = FilmsControls.f.Annee;
           
            //PersonneControls.personnes.Add(p);
            FilmsControls.films.ForEach(c => c.producteus_film.Add(p));
        }
    }
}
