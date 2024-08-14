using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dependency_Inversion_Principle
{
    ////Without Dependency inversion -- High level module ProductCatalog depends on Low level module SQLProductRepository

    //public class ProductCatalog
    //{
    //    SQLProductRepository repo = new SQLProductRepository();
    //    public void PresentProductCatalog()
    //    {
    //        Console.WriteLine(repo.getProductNames());
    //    }
    //}
    //public class SQLProductRepository
    //{
    //    public List<String> getProductNames()
    //    {
    //        return new List<string>() { "soap", "toothpaste" };
    //    }
    //}



    //////////////////////////////////////////////////////////////////////////////////////////////////


    //// With Dependency Inversion -- using factory class and interface IProductRepository
    //public class ProductCatalog
    //{
    //    IProductRepository repo = ProductFactory.create();

    //    public void PresentProductCatalog()
    //    {
    //        Console.WriteLine(repo.getProductNames());
    //    }
    //}

    ////defining interface IProductRepository
    //public interface IProductRepository
    //{
    //    List<string> getProductNames();
    //}

    //public class SQLProductRepository :IProductRepository
    //{
    //    public List<String> getProductNames()
    //    {
    //        return new List<string>() { "soap", "toothpaste" };
    //    }
    //}

    ////defining Factory Class and Method
    //public class ProductFactory
    //{
    //    public static IProductRepository create()
    //    {
    //        return new SQLProductRepository();
    //    }
    //}



    //////////////////////////////////////////////////////////////////////////////////////////////////



    // With dependency inversion and dependency injection -- injecting Factory object directly as input attribute to the high level module

    //Defining Topmost module Application
    public class Application
    {
        public void DisplayProducts()
        {
            IProductRepository productFactory = ProductFactory.create();
            ProductCatalog productCatalog = new ProductCatalog(productFactory);

            //Display products
            List<string> products= productCatalog.PresentProductCatalog();
            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
    public class ProductCatalog
    {
        private IProductRepository _productRepository;

        public ProductCatalog(IProductRepository productFactory)
        {
            _productRepository = productFactory;
        }

        public List<string> PresentProductCatalog()
        {
            return _productRepository.getProductNames();
        }
    }

    //defining interface IProductRepository
    public interface IProductRepository
    {
        List<string> getProductNames();
    }

    public class SQLProductRepository : IProductRepository
    {
        public List<String> getProductNames()
        {
            return new List<string>() { "soap", "toothpaste" };
        }
    }

    //defining Factory Class and Method
    public class ProductFactory
    {
        public static IProductRepository create()
        {
            return new SQLProductRepository();
        }
    }


    internal class Program

    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.DisplayProducts();
        }
    }
}

