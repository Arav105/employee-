using System;
namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[]args)
        {
            int id;
            string name;
            string gender;
            double salary;
            DateTime DOJ;
            Console.WriteLine("Enter Employee ID"); 
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Date Of Joining");
            DOJ = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID\t" + "Employee Name\t" + "Gender\t" + "Salary\t" + "DOJ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(id + "\t" + name + "\t" + gender + "\t" + salary + "\t" + DOJ );
            if (salary > 90000)
            {
                Console.WriteLine("You should pay 30% Tax" + ":" + "\t"+salary);
            }
            else
            {
                Console.WriteLine("you should pay 15% Tax" + ":"+"\t"+ salary);
            }
            Console.ReadKey();
        }
    }

}
