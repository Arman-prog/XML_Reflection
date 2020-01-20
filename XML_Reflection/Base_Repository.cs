using System;
using System.Collections.Generic;
using System.Xml;

namespace XML_Reflection
{
   public abstract class Base_Repository<TModel>
    {
        protected Base_Repository(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; }

        public IEnumerable<TModel> AsEnumarable()
        {
            var XDoc = new XmlDocument();
            XDoc.Load(FileName);
            var xRoot = XDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot.ChildNodes)
            {
                yield return  ToModel(xnode);
            }
        }

        public abstract TModel ToModel(XmlNode xnode);
    }
}
