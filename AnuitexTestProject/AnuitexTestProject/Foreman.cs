using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexTestProject
{
    public class Foreman : BaseEmployees, IEmploy
    {
        public void Work()
        {
            Console.WriteLine("закупка материалов");
        }
        public void Сheckemployees() {
            Console.WriteLine("Сотрудники проверены");
        }
    }
}
