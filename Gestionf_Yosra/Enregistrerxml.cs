using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Gestionf_Yosra.Model;

namespace Gestionf_Yosra
{
 public   class Enregistrerxml
    {
        public static void EnregistrerDonne(object objet, string filename)
        {
            XmlSerializer s = new XmlSerializer(objet.GetType());
            TextWriter writer = new StreamWriter(filename);
            s.Serialize(writer, objet);
         
            writer.Close();
        }

       
    }
}
