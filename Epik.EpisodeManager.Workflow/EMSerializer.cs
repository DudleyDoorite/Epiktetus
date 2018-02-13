using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;

namespace Epik.EpisodeManager.Workflow
{
    public class EMSerializer
    {
        public static void SaveSession(Session session, string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Session));
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, session);
            writer.Close();
        }
        public static Session LoadSession(string filename)
        {
            Session mysession;

            XmlSerializer mySerializer = new XmlSerializer(typeof(Session));
            // To read the file, create a FileStream.  
            FileStream myFileStream =  new FileStream("myFileName.xml", FileMode.Open);
            // Call the Deserialize method and cast to the object type.  
            mysession = (Session)mySerializer.Deserialize(myFileStream);
            return mysession;
        }

    }
}
