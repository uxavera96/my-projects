using System;

namespace ConsoleApp2
{
    public class SalaryCalculator
    {
        public int Empid;
        public string Name;
        public string Position;

        public SalaryCalculator(int empid, string name, string  position)
        {
            this.Empid = empid;
            this.Name = name;
            this.Position = position;
        }

        public void test()
        {
            Console.WriteLine("SalaryCalculator");
        }
        
        public static double CalculateSalary(double Gs)
        {
            double Salary;
            Salary=Gs-(Gs*0.3) - (Gs*0.05) - (Gs*0.03);
            return Salary;
        }
        public static double CalculateHourly(double RT, double NumberOfOur )
        {
            double SalaryHour;
            SalaryHour=(RT*NumberOfOur)-0.05-0.03;
            return SalaryHour;
        }
        public static double CalculateDaily(double Gs)
        {
            double SalaryDay;
            SalaryDay=Gs-(Gs*0.3) ;
            return SalaryDay;
        }
    }
}