using System;


namespace LitwareLib
{
    interface IPrintable
    {
        void PrintDetails();
    }
    public class Employee : IPrintable
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        double HRA, TA, DA, PF, TDS;

        public double NetSalary;
        public double GrossSalary { set; get; }
        public Employee() { }
        public Employee(int ENo, string EName, double Sal)
        {
            this.EmpName = EName;
            this.EmpNo = ENo;
            this.Salary = Sal;
            //GrossSalary = 0.0;
        }

        public virtual void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000 && Salary >= 5000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000 && Salary >= 10000)
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000 && Salary >= 15000)
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
        public void PrintDetails()
        {
            Console.WriteLine("\nEmpployee No. {0}\tEmployee Name {1}\tEmployee Salary {2}\tGross Salary {3}",this.EmpNo,this.EmpName,this.Salary,this.GrossSalary);
        }
    }
    public class Manager : Employee,IPrintable
    {
        double PA, OA, FA;
        public Manager() { }
        public Manager(int ENo, string EName, double Sal) :base(ENo, EName, Sal) {
            PA = 0.08 * Salary;
            FA = 0.13 * Salary;
            OA = 0.03 * Salary;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            base.NetSalary += (OA + FA + PA);
            base.GrossSalary += OA + FA + PA;
           
        }
        public void PrintDetails()
        {
            Console.WriteLine("\nManager No. {0}\tManager Name {1}\tManager Salary {2}\tGross Salary {3}",this.EmpNo, this.EmpName, this.Salary, this.GrossSalary);
        }
    }
    public class MarketingExecutive:Employee,IPrintable
    {
        public int Kilometer { get; set; }
        public double TourAllowances { get;set; }
        public double TelephoneAllowance = 1000.00;

        public MarketingExecutive() : base() { }
        public MarketingExecutive(int ENo, string EName, double Sal, int km) : base(ENo, EName, Sal)
        {
            this.Kilometer = km;
            this.TourAllowances = 5 * this.Kilometer;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            base.GrossSalary += TourAllowances + TelephoneAllowance;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Empployee No. {0}\tEmployee Name {1}\tEmployee Salary {2}\nGross Salary {3}", this.EmpNo, this.EmpName, this.Salary, this.GrossSalary);
        }
    }
    internal class EmpManagement
    {
        public static void Main()
        {
            Manager m = new Manager(100,"Akshat", 20000);
            m.CalculateSalary();
            m.PrintDetails();

            MarketingExecutive me = new MarketingExecutive(100, "Akshat", 20000,5);
            me.CalculateSalary();
            me.PrintDetails();
            //Console.WriteLine("Enter number of Employees : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Employee[] EmpArr = new Employee[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Employee E = new Employee();

            //    Console.WriteLine("Enter Employee Number: ");
            //    E.EmpNo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Name of Employee{0} : ", i + 1);
            //    E.EmpName = Console.ReadLine();
            //    Console.WriteLine("Enter Salary of Employee{0} : ", i + 1);
            //    E.Salary = Convert.ToDouble(Console.ReadLine());
            //    E.CalculateSalary();
            //    EmpArr[i] = E;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Details of Employee{0} are - {1} {2} {3} {4}", i + 1, EmpArr[i].EmpNo, EmpArr[i].EmpName, EmpArr[i].Salary,EmpArr[i].GrossSalary);
            //}
        }
    }

}
