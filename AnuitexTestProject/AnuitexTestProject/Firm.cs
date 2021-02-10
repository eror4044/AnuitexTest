using System.Collections.Generic;

namespace AnuitexTestProject
{
    public class Firm
    {
        public List<IEmploy> employees;

        public Firm()
        {
            employees = new List<IEmploy>();
        }

        public static Firm operator +(Firm f, IEmploy emp){
           f.employees.Add(emp);
           return f;
        }
        public static Firm operator -(Firm f, IEmploy emp)
        {
            f.employees.Remove(emp);
            return f;
        }
    }
    
}