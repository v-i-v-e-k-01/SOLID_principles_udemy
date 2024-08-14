using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class InsurancePremiumDiscountCalculator
    {
        public int CalculatePremiumDiscountPercent(CustomerProfile customer)
        {
            if (customer.IsLoyalCustomer())
            {
                return 20;
            }
            return 0;
        }
    }
    ///////////////////////////////////////////////////////////////
    public interface CustomerProfile
    {
        bool IsLoyalCustomer();
    }
    ///////////////////////////////////////////////////////////////
    public class HealthInsuranceCustomerProfile : CustomerProfile
    {
        public bool IsLoyalCustomer()
        {
            return new Random().NextDouble() >= 0.5;
        }
    }
    ///////////////////////////////////////////////////////////////

    public class VehicleInsuranceCustomerProfile : CustomerProfile
    {
        public bool IsLoyalCustomer()
        {
            return new Random().NextDouble() >= 0.5;
        }
    }
    ///////////////////////////////////////////////////////////////
    public class HomeInsuranceCustomerProfile : CustomerProfile
    {
        public bool IsLoyalCustomer()
        {
            var random2 = new Random();
            return random2.NextDouble() >= 0.5;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var insurancePremiumCalculator = new InsurancePremiumDiscountCalculator();

            var customer = new HealthInsuranceCustomerProfile();
            var discountCustomer1 = insurancePremiumCalculator.CalculatePremiumDiscountPercent(customer);
            Console.WriteLine("Discount for Health Insurance Customer: " + discountCustomer1);

            var customer2 = new VehicleInsuranceCustomerProfile();
            var discountCustomer2 = insurancePremiumCalculator.CalculatePremiumDiscountPercent(customer2);
            Console.WriteLine("Discount for Vehicle Insurance Customer: " + discountCustomer2);

            var customer3 = new HomeInsuranceCustomerProfile();
            var discountCustomer3 = insurancePremiumCalculator.CalculatePremiumDiscountPercent(customer3);
            Console.WriteLine("Discount for Home Insurance Customer: " + discountCustomer3);

        }
    }
}
