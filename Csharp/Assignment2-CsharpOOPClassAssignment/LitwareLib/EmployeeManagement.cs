using System;


namespace LitwareLib
{
    class Employee
    {
        public int EmpNo {  get;  set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        double HRA, TA, DA, PF, TDS, NetSalary;

        public double GrossSalary { set; get; }
        public Employee() { }
        public Employee(int ENo, string EName, double Sal)
        {
            this.EmpName = EName;
            this.EmpNo = ENo;
            this.Salary = Sal;
        }
        public void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000 )
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000 )
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000 )
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;
            }
            else
            {
                HRA = 0.30 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }
            this.GrossSalary = Salary + HRA + TA + DA;
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
           
        }
        public void PrintDetails(int i)
        {
            Console.WriteLine("Employee{0}, Employee No: {1},Employee Name: {2},Salary: {3},Gross Salary: {4}", i + 1, EmpNo, EmpName, Salary,GrossSalary);
        }
    }

    internal class EmpManagement
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of Employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] EmpArr = new Employee[n];
            
            for(int i = 0; i < n; i++)
            {
                Employee E = new Employee();
                
                Console.WriteLine("Enter Employee Number: ");
                E.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name of Employee{0} : ", i+1);
                E.EmpName = Console.ReadLine();
                Console.WriteLine("Enter Salary of Employee{0} : ",i+1);
                E.Salary = Convert.ToDouble(Console.ReadLine());
                E.CalculateSalary();
                EmpArr[i] = E;
            }

            for (int i = 0; i < n; i++)
            {
                EmpArr[i].PrintDetails(i);
            }
        }
    }

}
