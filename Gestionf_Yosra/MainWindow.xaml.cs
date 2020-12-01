using Gestionf_Yosra.Controls;
using Gestionf_Yosra.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml.Serialization;

namespace Gestionf_Yosra
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int valeur = 0;
        public static Film Film1;
        public static Film F;

        public static List<Film> film = new List<Film>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ouvrir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Ouvrir_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Enregistrer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Enregistrer_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void AjouterFilm_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AjouterFilm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Film f = (Film)DataContext;
            //FilmsControls.films.Add(f); 
        }

        private void AjouterPersonner_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AjouterPersonne_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // j'ai crer une fentre de type FilmControl qui contient les champs de la classe film 

            FilmsControls w = new FilmsControls();
            // renvoyer la fenetre du film que je dois remplir 
            w.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {



        }





        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {


                Enregistrerxml.EnregistrerDonne(PersonneControls.personnes, "personnes.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }


        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            // ici je dois créer un control de type fenetre pour pouvoir afficher 
            //la fenetre coresspandante à l'ajout Personne 
            PersonneControls w = new PersonneControls();
            w.Show();
        }

        private void Rechercher_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Rechercher_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            film = new List<Film>();

            List<Personne> personne = new List<Personne>();
            try
            {
                if (FilmsControls.films != null)
                {
                    foreach (var f in FilmsControls.films)
                    {
                        if (T.Text == f.Genre || T.Text == f.Titre)
                        {
                            film.Add(f);
                            valeur = 1;
                            Film1 = f;
                        }

                    }
                    //dataGrid.ItemsSource = null;
                    //dataGrid.ItemsSource = film;

                }

                if (PersonneControls.personnes != null)
                {
                    foreach (var f in PersonneControls.personnes)
                    {
                        if (T.Text == f.Nom || T.Text == f.Prenom)
                        {
                            personne.Add(f);
                        }
                    }
                    //dataGrid1.ItemsSource = personne;
                    //dataGridx.ItemsSource = personne;

                }

                ////dataGrid.ItemsSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDetail_Click(object sender, RoutedEventArgs e)
        {
            if (valeur == 1)
            {
                AfficheDetail w = new AfficheDetail();
                w.Show();
            }

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            F = new Film();
            DataGrid dg = sender as DataGrid;
            F = (Film)dg.SelectedItems[0];
            Recherche w = new Recherche();
            w.Show();
        }
    }

}
