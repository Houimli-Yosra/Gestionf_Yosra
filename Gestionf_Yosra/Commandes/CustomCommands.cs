using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestionf_Yosra
{
  public  class CustomCommands
    {
        public static readonly RoutedUICommand Ouvrir = new RoutedUICommand();
        public static readonly RoutedUICommand Enregistrer = new RoutedUICommand();
        //public static readonly RoutedUICommand AjouterFilm = new RoutedUICommand();
        public static readonly RoutedUICommand AjouterPersonne = new RoutedUICommand();
        public static readonly RoutedUICommand AjouterFilm = new RoutedUICommand();
        public static readonly RoutedUICommand Rechercher = new RoutedUICommand();

    }
}
