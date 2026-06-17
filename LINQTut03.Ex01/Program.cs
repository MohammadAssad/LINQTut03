using LINQTut03.Shared;
using System;
using System.Linq;

namespace LINQTut03.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var femaleWithFnameStartsWithS01 = employees
                .Filter(x =>
                x.Gender == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));

            femaleWithFnameStartsWithS01.Print("female With Fname Starts With S / Filter");

            var femaleWithFnameStartsWithS02 = employees.Where(x =>
               x.Gender == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));
            var femaleWithFnameStartsWithS02Count = femaleWithFnameStartsWithS02.FirstOrDefault(e => e.HasPensionPlan);

            femaleWithFnameStartsWithS02.Print("female With Fname Starts With S / Where");
            ExtensionFunctional.PrintSingle(femaleWithFnameStartsWithS02Count,"female With Fname Starts With S / femaleWithFnameStartsWithS02Count");
            
            Console.ReadKey();
        }
    }
}
