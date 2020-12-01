using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestionf_Yosra.Model
{
  public  class Film
    {
        public string titre;
        public int annee;
        public string genre;
        //public Personne acteur =new Personne();

        public  List<Personne> acteurs_film = new List<Personne>();
        public  List<Personne> producteus_film = new List<Personne>();
        public  List<Personne> realisateus_film = new List<Personne>();
        public List<ActeurRole> acteur_role = new List<ActeurRole>();


        public int Annee
        {
            get { return annee; }
            set
            {
                if (annee != value)
                {
                    annee = value;
                    NotifyPropertyChanged("Annee");
                }
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (genre != value)
                {
                    genre = value;
                    NotifyPropertyChanged("genre");
                }
            }
        }
        //public List<Personne> Acteurs_film
        //{
        //    get { return acteurs_film; }
        //    set
        //    {
        //        if (acteurs_film == value) return;
        //        acteurs_film = value;
        //        NotifyPropertyChanged();
        //    }
            


        //}



        //public List<Personne> Producteurs_film
        //{
        //    get { return producteus_film; }
        //    set
        //    {
        //        if (producteus_film == value) return;
        //        producteus_film = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        //public List<Personne> Realisateurs_film
        //{
        //    get { return realisateus_film; }
        //    set
        //    {
        //        if (realisateus_film == value) return;
        //        realisateus_film = value;
        //        NotifyPropertyChanged();
        //    }
        //}
 
     

        //public string Prenom_Acteur
        //{
        //    get { return acteur.prenom; }
        //    set
        //    {
        //        if (acteur.prenom != value)

        //            acteur.prenom = value;
        //        NotifyPropertyChanged("acteur.prenom");

        //    }
        //}
        public string Titre
        {
            get { return titre; }
            set
            {
                if (titre != value)
                {
                    titre = value;
                    NotifyPropertyChanged("Titre");
                }
            }
        }

        //public string Name
        //{
        //    get { return nomRealisateur; }
        //    set
        //    {
        //        if (Name != value)
        //        {
        //            nomRealisateur = value;
        //            NotifyPropertyChanged("Name");
        //        }
        //    }
        //}
     
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
