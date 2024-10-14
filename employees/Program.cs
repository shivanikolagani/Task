namespace employees
{
    public abstract class Employee
    {
        // Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        public bool ValidateEmployeeId()
        {
            if (Id.Length != 5 || !Id.StartsWith("EM"))
                return false;

            string numericPart = Id.Substring(2);
            return int.TryParse(numericPart, out _);
        }

        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        public override Employee SalaryCalculation()
        {
            double da = BasicPay * 0.50; 
            double hra = BasicPay * 0.30;
            Salary = BasicPay + da + hra; 
            return this;
        }
    }

    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages; 
            return this;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");
            Console.Write("Choose the employee type: ");
            int employeeType = int.Parse(Console.ReadLine());

            Console.Write("Enter the employee id: ");
            string employeeId = Console.ReadLine();

            Employee employee;
            if (employeeType == 1)
            {
                employee = new Permanent();
                Console.Write("Enter the name: ");
                employee.Name = Console.ReadLine();
                Console.Write("Enter basic pay: ");
                ((Permanent)employee).BasicPay = double.Parse(Console.ReadLine());
            }
            else
            {
                employee = new Temporary();
                Console.Write("Enter the name: ");
                employee.Name = Console.ReadLine();
                Console.Write("Enter hours worked: ");
                ((Temporary)employee).HrsWorked = int.Parse(Console.ReadLine());
                Console.Write("Enter hourly wages: ");
                ((Temporary)employee).HrlyWages = int.Parse(Console.ReadLine());
            }

            employee.Id = employeeId;

            if (!employee.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                employee.SalaryCalculation();
                Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
            }
        }
    }

}
