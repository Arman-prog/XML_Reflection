using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_Reflection.Models;
using System.Reflection;

namespace XML_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_Repository repository = new Student_Repository(@"Data\Students.xml");
            var stlist = repository.AsEnumarable().ToList();

            stlist.SaveToXML("NewStudents.xml");
           

            
        }
        

       
    }
}
