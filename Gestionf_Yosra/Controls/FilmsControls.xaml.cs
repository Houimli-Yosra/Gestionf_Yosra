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
    /// Logique d'interaction pour FilmsControls.xaml
    /// </summary>
    public partial class FilmsControls : Window
    {
        public static List<Film> films;
        //public static Film f= new Film();
        public FilmsControls()
        {
            InitializeComponent();
            if(films == null)
            {
                films = new List<Film>();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Film f = new Film();
                //Personne p = new Personne();
                f.Titre = textBox3.Text;
                f.Annee = int.Parse(textBox2.Text);
                f.Genre = textBox1.Text;

     


                films.Add(f);

                Enregistrerxml.EnregistrerDonne(films, "ab1234.xml");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AjoutActeur w = new AjoutActeur();

            w.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AjoutProducteur w = new AjoutProducteur();

            w.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AjoutRealisateur w = new AjoutRealisateur();

            w.Show();
        }
    }
}
