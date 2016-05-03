using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

public class SaveLoad<T> //class for the serializing and Deserializing information
{
    public SaveLoad() { } //Default constructor

    public void Serialize(string FileName, T Data) //serializing function
    //Function that has two parameters one of type string and one of generic type
    //the string will be used to name the file and the T will be the serialized data
    {
        using (FileStream fs = File.Create(@"..\..\SavedFiles\" + FileName + ".xml"))
        //creates a file within this project its in and then names it the string passed 
        //into the function and gives them a file type of bin 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //variable name serializer initialized that will specifically serialize 
            //the type given at the start of the program 
            //reference of typeof is link:https://msdn.microsoft.com/en-us/library/58a18dwa(v=vs.110).aspx
            //TextWriter writer = new StreamWriter(FileName);
            //this gives the file the name i defined for it to be and stores it in a
            //variable called writer that i must use to serialize information
            // reference of the code above is also in link

            serializer.Serialize(fs, Data);
            //serializes the data and then names it whatever I named it in the FinalName variable
            fs.Close();
            
            //closes this file
        }
    }

    public T Deserialize(string FileName)//deserializing the function
    {
        T t;
        using (FileStream fs = File.OpenRead(Directory.GetCurrentDirectory() + "\SavedFiles\ " + FileName + ".xml"))
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            t = (T)deserializer.Deserialize(fs);
            fs.Close();

            //closes the file
        }
        return t;
    }
}
