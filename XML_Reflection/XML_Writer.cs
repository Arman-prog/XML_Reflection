using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Reflection
{
   public static class XML_Writer
    {      
        public static void SaveToXML<T>(this IEnumerable<T> data, string filename)
        {
            XmlTextWriter textWriter = new XmlTextWriter(filename, null);
            
                Type elementtype = typeof(T);
               
                PropertyInfo[] Properties = elementtype.GetProperties(BindingFlags.Instance
                | BindingFlags.Public
                | BindingFlags.DeclaredOnly);

                textWriter.WriteStartDocument();
                textWriter.WriteStartElement($"Listof{elementtype.Name}s");

                foreach (T item in data)
                {
                    textWriter.WriteStartElement(elementtype.Name);
                    foreach (PropertyInfo property in Properties)
                    {
                        object value = property.GetValue(item);
                        textWriter.WriteStartElement(property.Name);
                        textWriter.WriteValue(value);
                        textWriter.WriteEndElement();
                    }
                    textWriter.WriteEndElement();
                }
                textWriter.WriteEndElement();
            textWriter.Close();
            
        }

    }
}
