using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestionf_Yosra.Model
{
 public   class Personne
    {
        public string nom;
        public string prenom;
        public int age;



        public string Nom
        {
            get { return nom; }
            set
            {
                if (nom != value)
                {
                    nom = value;
                    NotifyPropertyChanged("Nom");
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (prenom != value)
                {
                    prenom = value;
                    NotifyPropertyChanged("Pernom");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    NotifyPropertyChanged("age");
                }
            }
        }

    }
}
