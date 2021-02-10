using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexTestProject
{
    public static class LinqExtension
    {
        public static T FiendElement<T>(this List<T> list, Func<T, bool> predicate)
        {
            return list.Where(predicate).FirstOrDefault();
        }
    
    }
}
