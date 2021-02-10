using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexTestProject
{
    public class Worker : BaseEmployees, IEmploy
    {
        public void Work()
        {
            Console.WriteLine("выпуск продукции");
        }
     
    }
}
