using System;
//****Calculate the different company monthly hrs daily wage is 50 part time 4hrs and full time 8hrs use array using inheritance****

namespace EmpWageArrayInheritance
{
    class Program
    {
        public static string Company_Name { get; private set; }
        public static int Wage_Per_Hr { get; private set; }
        public static int Full_Hr_Per_Day { get; private set; }
        public static int Part_Hr_Per_Day { get; private set; }
        public static int Max_Working_Days { get; private set; }
        public static int Max_Working_Hrs { get; private set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Monthly wage");
            EmpWageArray empWageBuilder = new EmpWageArray();
            
            empWageBuilder.AddCompany("TCS", 20, 8, 4, 80, 20);
            empWageBuilder.AddCompany("HUNDAI", 20, 8, 4, 90, 20);
        }
    }
}
