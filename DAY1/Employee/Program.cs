namespace Employee
{
    public interface IDbFunctions
    {
        void insert();
        void update();
        void delete();


    }


    public abstract class Employee
    {
        private String name;
        private readonly int empNo;
        private decimal basic;
        private short deptNo;

        public static int counter = 0;
        public string Name
        {
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Please enter Valid Name");
                }
                else
                {
                    name = value;


                }

            }
            get { return name; }
        }


        public int EmpNo
        {

            get { return empNo; }
        }
        public virtual decimal Basic
        {
            set
            {
                if (value > 0 && value < 45000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("do not enter value greater than 45000 and less than 0");
                }
            }
            get { return basic; }

        }
        public virtual short Deptno
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter valid deptno");
                }
                else
                {
                    deptNo = value;
                }
            }
            get { return deptNo; }
        }


        public virtual decimal GetfullSalary()
        {
            return basic + (basic * 0.20m) - (basic * 0.10m);

        }
        public Employee(string name, decimal basic, short deptno)
        {
            counter++;
            empNo = counter;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptno;

        }
        public Employee(string name, decimal basic)
        {
            counter++;
            empNo = counter;
            this.name = name;
            this.basic = basic;


        }
        public Employee(string name)
        {
            counter++;
            empNo = counter;
            this.name = name;


        }
        public Employee()
        {
            counter++;
            empNo = counter;
        }


        public override string ToString()
        {
            return $"EmpNo:{empNo},Name:{name},Basic:{basic},DeptNo:{deptNo}";
        }



    }
    class Manager : Employee
    {
        private string designation;

        public string Designation
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Designation cannot be changed");
                }
                else
                {
                    designation = value;
                }
            }
            get { return designation; }
        }
        public override decimal Basic
        {
            set
            {
                if (value < 20000 || value > 60000)
                {
                    Console.WriteLine("Invalid basic for genral Manager");
                }
                else
                {
                    base.Basic = value;
                }
            }
            get { return base.Basic; }
        }
        public override decimal GetfullSalary()
        {
            return Basic + (Basic * 0.30m);
        }
        public Manager(string name, decimal basic, short deptno, string designation) : base(name, basic, deptno)
        {
            Designation = designation;
        }
        public override string ToString()
        {
            return base.ToString() + $",Designation:{Designation}";
        }
    }
    class GeneralManager : Manager
    {
        public string Perks { get; set; }
        public override decimal Basic
        {
            set
            {
                if (value < 30000 || value > 80000)
                {
                    Console.WriteLine("Invalid basic for GeneralManager");

                }
                else
                {
                    base.Basic = value;
                }
            }
            get { return base.Basic; }
        }
        public override decimal GetfullSalary()
        {
            return Basic + (Basic * 0.30m);
        }
        public GeneralManager(string name, decimal basic, short deptno, string designation, string perks) : base(name, basic, deptno, designation)
        {
            Perks = perks;
        }
        public override string ToString()
        {
            return base.ToString + $",Perks:{Perks}";
        }

        class CEO : Employee
        {
            public override decimal Basic
            {
                set
                {
                    if (value < 50000 || value > 100000)
                    {
                        Console.WriteLine("Invalid Basic for ceo");
                    }
                    else
                    {
                        base.Basic = value;
                    }

                }
                get { return base.Basic; }
            }
            public sealed override decimal GetfullSalary()
            {
                return Basic + (Basic * 0.80m);
            }
            public CEO(String name, decimal basic, short deptno) : base(name, basic, deptno)
            {

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {


                //Console.WriteLine("Enter Employee Name:");
                //obj.Name = Console.ReadLine();
                //Console.WriteLine("Enter Employee Number:");
                //obj.EmpNo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter Basic Salary:");
                //obj.Basic = Convert.ToDecimal(Console.ReadLine());
                //Console.WriteLine("Enter department number:");
                //obj.Deptno = Convert.ToInt16(Console.ReadLine());

                //Console.WriteLine("\n=============== Employee details=========");
                //Console.WriteLine("Name of employee is:" + obj.Name);
                //Console.WriteLine("Employee Number is:" + obj.EmpNo);
                //Console.WriteLine("department number is:" + obj.Deptno);
                //Console.WriteLine("Basic salary:" + obj.Basic);
                //Console.WriteLine("full salary is:" + obj.GetfullSalary());
                Employee o1 = new Manager("amol", 20000, 2, "HR");
                Console.WriteLine(o1.ToString());
                Employee o2 = new GeneralManager("Raj", 70000, 3, "Head", "Car+Bonus");
                Console.WriteLine(o2.ToString());
                Employee o3 = new CEO("sita",90000,5);
                Console.WriteLine(o3.ToString());

                Console.WriteLine(o1.EmpNo);
                Console.WriteLine(o2.EmpNo);
                Console.WriteLine(o3.EmpNo);

                Console.WriteLine(o3.EmpNo);
                Console.WriteLine(o2.EmpNo);
                Console.WriteLine(o1.EmpNo);

                Console.WriteLine("Full salary of Amol = " + o1.GetfullSalary());
                Console.WriteLine($"Manager Salary:"+o1.GetfullSalary());
                Console.WriteLine($"General Manager Salary:"+o2.GetfullSalary());
                Console.WriteLine($"CEO Salary:"+o3.GetfullSalary());
            }
        }
    }
}