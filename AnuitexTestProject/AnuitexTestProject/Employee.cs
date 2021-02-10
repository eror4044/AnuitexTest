using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexTestProject
{
    class Employee : BaseEmployees, IEmploy
    {
        
        public void Work() {
            Console.WriteLine("Employee Work");
        }
    }
}
