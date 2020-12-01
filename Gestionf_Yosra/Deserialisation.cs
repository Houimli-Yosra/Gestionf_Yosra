using Gestionf_Yosra.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gestionf_Yosra
{
  public  class Deserialisation
    {

        public static void  RecupererDonne(FileInfo file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Film));
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                 serializer.Deserialize(reader) ;
            }
        }
       
    }
}
