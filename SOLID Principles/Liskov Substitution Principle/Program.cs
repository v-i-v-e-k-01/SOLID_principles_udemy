using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Product
    {
        public double discount = 20;

        public virtual double GetDiscount()
        {
            return discount;
        }
    }

    public class InHouseProduct : Product
    {
        //public void ApplyExtraDiscount()
        //{
        //    discount *= 1.5;
        //}

        // OR
        // overriding to add extra discount
        public override double GetDiscount()
        {
            ApplyExtraDiscount();
            return discount;
        }

        public void ApplyExtraDiscount()
        {
            discount *= 1.5;
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new InHouseProduct(); // observe that derived class is also stored in parent class type variable

            List<Product> productList = new List<Product>();
            productList.Add(p1);
            productList.Add(p2);

            //foreach (Product p in productList)
            //{
            //    if(p is InHouseProduct)
            //    {
            //        ((InHouseProduct)p).applyExtraDiscount();
            //    }
            //    Console.WriteLine(p.GetDiscount());
            //}

            // so instead of above "ASK" whether p is instance of InHouseProduct, we override getDiscount() inside InHouseProduct() and add extra discount. This way, we just "TELL" in Main() function to getDiscount() and no checking for instance 


            foreach (Product p in productList)
            {
                Console.WriteLine(p.GetDiscount());
            }


            //this way main function will also be executed with ease and the functionality of parent class is also preserved

            // i.e. "Objects should be replacable with their sub-types without affecting the correctness of the program "
        }
    }
}