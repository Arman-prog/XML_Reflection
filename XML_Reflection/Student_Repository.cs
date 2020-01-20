using System;
using XML_Reflection.Models;
using System.Xml;

namespace XML_Reflection
{
    public class Student_Repository : Base_Repository<Student>
    {
        public Student_Repository(string filename):base(filename)
        {

        }

        public override Student ToModel(XmlNode xnode)
        {
            Student item = new Student();

            foreach (XmlNode xchild in xnode.ChildNodes)
            {
                switch (xchild.Name)
                {
                    case Keywords.FirstName:
                        {
                            item.FirstName = xchild.InnerText;
                            break;
                        }
                    case Keywords.LastName:
                        {
                            item.Lastname = xchild.InnerText;
                            break;
                        }
                    case Keywords.BirthDate:
                        {
                            if (DateTime.TryParse(xchild.InnerText,out DateTime date))
                            {
                                item.BirthDate = DateTime.Parse(xchild.InnerText);                               
                            }
                            break;
                        }

                }               

            }
            return item;
        }




    }
}
