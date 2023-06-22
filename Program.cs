using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anonymous Income Comparison Program");  //displays greeting message
            Console.WriteLine("Person 1, please enter the following details!");  
            Console.WriteLine("Your hourly rate:");
            string rate1 = Console.ReadLine();  //creates variable with value based on user input
            Console.WriteLine("Hours worked per week:");
            string hours1 = Console.ReadLine();     //creates variable with value based on user input
            Double annual1 = (Convert.ToDouble(rate1) * Convert.ToDouble(hours1)) * 52;  //creates varible with value of converted values previously given by user
            Console.WriteLine("Person 2, please enter the following details!");
            Console.WriteLine("Your hourly rate:");
            string rate2 = Console.ReadLine();  //creates variable with value based on user input
            Console.WriteLine("Hours worked per week:");
            string hours2 = Console.ReadLine();  //creates variable with value based on user input
            Double annual2 = (Convert.ToDouble(rate2) * Convert.ToDouble(hours2)) * 52;  //creates varible with value of converted values previously given by user
            Console.WriteLine("The annual salary of Person 1 is: " + annual1);  //Displays annual salary 
            Console.WriteLine("The annual salary of Person 2 is: " + annual2);
            bool comparison = annual1 > annual2;  //boolean logic to compare annual salaries
            Console.WriteLine("Person 1 makes more money than Person 2: " + comparison);  //displays message saying that the statement is either true or false based on data given
            Console.ReadLine();
        }
    }
}
