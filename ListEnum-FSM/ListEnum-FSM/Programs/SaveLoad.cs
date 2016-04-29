using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

public class SaveLoad<T>
{
    public SaveLoad() { }

    public void Serialize(string FileName, T Data)
    {
        using (FileStream fs = File.Create(@"..\..\SavedFiles\" + FileName + ".bin"));
        {
            XmlSerializer serializer = new XmlSerializer(GetType(T));


        }
    }
}
