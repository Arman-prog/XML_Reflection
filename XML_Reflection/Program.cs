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
           
           

            
        }
        static void PrivateReader<T>(T item)
        {
            Type type = typeof(T);
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(item));
            }
        }

       
    }
}
