using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexTestProject
{
    public class Manager : BaseEmployees, IEmploy
    {
        public void Work()
        {
            Console.WriteLine("сбор заказов");
        }

        public void TakeTask()
        {
            Console.WriteLine("Задание выдано");
        }

    }
}
