namespace Employee;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public class Employee {
        private string name;
        private string identityNumber;
        private string grossSales;
        private string commissionRate;


    }

    public class CommissionEmployee :Employee{
        public double Earnings() { }
    }

    public class BasePlusCommissionEmployee: Employee {

    }
}

