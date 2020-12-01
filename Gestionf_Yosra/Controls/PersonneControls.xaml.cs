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
    /// Logique d'interaction pour PersonneControls.xaml
    /// </summary>
    public partial class PersonneControls : Window
    {
        public static List<Personne> personnes; 
        public PersonneControls()
        {
            InitializeComponent();
            if (personnes == null)
            {
                personnes = new List<Personne>();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //enregistrement de l'ajout Personne dans un fichier xml 
            try
            {
              Personne p = new Personne();
            p.Nom = textBox3.Text;
            p.Prenom = textBox2.Text;
             p.Age = int.Parse(textBox1.Text);
            personnes.Add(p);
          

                
                Enregistrerxml.EnregistrerDonne(personnes, "personnes.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }
    }
}
