using System;
//****Calculate the different company monthly hrs daily wage is 50 part time 4hrs and full time 8hrs use array using inheritance****

namespace EmpWageArrayInheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            
            EmpWageArray empWageBuilder = new EmpWageArray();
            
            empWageBuilder.AddCompany("TATA");
            empWageBuilder.AddCompany("HUNDAI");
        }
    }
}
