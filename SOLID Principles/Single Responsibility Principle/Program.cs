using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class Employee
    {
        public String EmployeeID {  get; set; }
        public String EmployeeName { get; set; }
        public String EmployeeAddress { get; set; }
        public String EmployeeNumber { get; set; }
        public String EmployeeType { get; set; }

        public void Save()
        {
            new EmployeeRepository().Save(this);  
            // moved the save method out of Employee class
            // for it is less related to other methods in current class -- violates cohesion rule
            // and more dependent on Database classes. -- violates coupling rule 
        }

        public void CalculateTax()
        {
            new TaxCalculator().CalculateTax(this);
        }
    }

    public class EmployeeRepository  
    {
        public void Save(Employee employee)
        {
            // Code to save Employee details to database
        }
    }

    public class TaxCalculator 
    {
        public void CalculateTax(Employee employee)
        {

            if (employee.EmployeeType.Equals("fulltime"))
            {
                // tax calculation for full-time employee
            }
            if (employee.EmployeeType.Equals("contract"))
            {
                // tax calculaton for contract employee
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
