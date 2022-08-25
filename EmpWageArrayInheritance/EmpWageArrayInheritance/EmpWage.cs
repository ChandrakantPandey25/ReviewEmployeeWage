//****Calculate the different company monthly hrs daily wage is 50 part time 4hrs and full time 8hrs use array using inheritance****
using System;
using System.Collections.Generic;
using System.Text;


namespace EmpWageArrayInheritance
{
    public class EmpWage
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public string Company_Name;
        public int Wage_Per_Hr;
        public int Full_Hr_Per_Day;
        public int Part_Hr_Per_Day;
        public int Max_Working_Days;
        public int Max_Working_Hrs;
        //public int wagesPerMonth = 0;
        public int[] companies;
        public int compCount;

        public EmpWage( int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)
        {
            
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
            companies = new int[2];
            compCount = 0;
        }

    }

    public class EmpWageArray : EmpWage
    {
        public EmpWageArray() : base( 50, 8, 4, 20, 160)
        {

        }
        public int Calculations()
        {
            EmpWage company = new EmpWage( Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);
            int Hr_Per_Day = 0;
            int Wage_Per_Day = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;
            int Monthly_Wage = 0;



            while (Total_Working_Hrs < Max_Working_Hrs && Present_Days < Max_Working_Days)
            {

                switch (new Random().Next(0, 3))
                {
                    case Full_Time:                        
                        Hr_Per_Day = Full_Hr_Per_Day;
                        Present_Days++;
                        break;

                    case Part_Time:                        
                        Hr_Per_Day = Part_Hr_Per_Day;
                        Present_Days++;
                        break;

                    default:
                        Hr_Per_Day = 0;
                        break;

                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (company.Wage_Per_Hr * Hr_Per_Day);
                Monthly_Wage += Wage_Per_Day;
            }
            return Monthly_Wage;
        }

        
        public  void AddCompany(string Company_Name)

        {
            this.Company_Name = Company_Name;
            EmpWageArray result = new EmpWageArray();
            int wage = result.Calculations();
            companies[compCount] = wage;
            Console.WriteLine($"Monthly Employee Wage in {Company_Name} is { companies[compCount]}");
            compCount++;

        }
        


    }



}