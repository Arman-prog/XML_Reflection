using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Reflection
{
   class Test
    {
        private string Name { get; set; } = "UnNamed";
        private int Age { get; set; }

        private void Method()
        {
            Console.WriteLine("private method");
        }
    }
}
