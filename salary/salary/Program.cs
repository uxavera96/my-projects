using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee1=new SalaryCalculator( 1, "danny", "section");
            Console.WriteLine("your net salary: " + SalaryCalculator.CalculateSalary(100000));
            Console.WriteLine("your Hourly salary:"+SalaryCalculator.CalculateHourly(12, 34));
            Console.WriteLine("your Hourly salary:"+ SalaryCalculator.CalculateDaily(12));
            
        }
    }
}