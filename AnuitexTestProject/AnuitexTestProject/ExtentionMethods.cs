using System;
using System.Linq;

namespace AnuitexTestProject
{
    public static class ExtentionMethods
    {
        //public static bool IsExistEmploy(this Firm f, IEmploy emp) {
        //   return f.employees.Exists(x => x.GetType().Name == emp.GetType().Name);
        //}
        public static IEmploy IsPresentEmploy(this Firm f, IEmploy emp)
        {
            return (IEmploy)(from x in f.employees where f.GetType().Name == emp.GetType().Name select x);
        }

        public static void Print(this Firm f)
        {
            foreach (var item in f.employees)
            {
                var i = item as BaseEmployees;
                Console.WriteLine($"emp name {i.GetType().Name},FirstName: {i.FirstName},LastName:{i.LastName}, Title:{i.Title}");
            }
        }
    }
}