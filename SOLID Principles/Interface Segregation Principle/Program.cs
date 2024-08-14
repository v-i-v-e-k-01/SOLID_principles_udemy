using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    //// Violation of Interface Segregation
    //public interface IMultiFunction
    //{
    //    void Print();
    //    void GetPrintSpoolDetails();
    //    void Scan();
    //    void ScanPhoto();
    //    void Fax();
    //    void InternetFax();

    //}

    //public class XeroxWorkCentre :  IMultiFunction
    //{
    //    public void Print()
    //    {
    //        //Print code
    //    }

    //    public void GetPrintSpoolDetails()
    //    {
    //        // Code to get print spool details
    //    }

    //    public void Scan()
    //    {
    //        // Code to implement Scan
    //    }

    //    public void ScanPhoto()
    //    {
    //        // Code to implement Scan Photo
    //    }

    //    public void Fax()
    //    {
    //        // Code to implement Fax
    //    }

    //    public void InternetFax()
    //    {
    //        // Code to implement Internet Fax
    //    }
    //}
    //public class HPPrinterScanner : IMultiFunction 
    //{
    //    public void Print()
    //    {
    //        //Print code
    //    }

    //    public void GetPrintSpoolDetails()
    //    {
    //        // Code to get print spool details
    //    }

    //    public void Scan()
    //    {
    //        // Code to implement Scan
    //    }

    //    public void ScanPhoto()
    //    {
    //        // Code to implement Scan Photo
    //    }

    //    public void Fax()
    //    {
    //    }

    //    public void InternetFax()
    //    {
    //    }
    //}

    //public class CannonPrinter : IMultiFunction
    //{
    //    public void Print()
    //    {
    //        //Print code
    //    }

    //    public void GetPrintSpoolDetails()
    //    {
    //        // Code to get print spool details
    //    }

    //    public void Scan()
    //    {
    //    }

    //    public void ScanPhoto()
    //    {
    //    }

    //    public void Fax()
    //    {
    //    }

    //    public void InternetFax()
    //    {           
    //    }
    //}


    //Implementing Interface Segregation
    public interface IPrintFunction
    {
        void Print();
        void GetPrintSpoolDetails();
    }

    public interface IScanFunction
    {
        void Scan();
        void ScanPhoto();
    }

    public interface IFaxFunction
    {
        void Fax();
        void InternetFax();
    }

    public class XeroxWorkCentre : IPrintFunction, IScanFunction, IFaxFunction  
    {
        public void Print()
        {
            //Print code
        }

        public void GetPrintSpoolDetails()
        {
            // Code to get print spool details
        }

        public void Scan()
        {
            // Code to implement Scan
        }

        public void ScanPhoto()
        {
            // Code to implement Scan Photo
        }

        public void Fax()
        {
            // Code to implement Fax
        }

        public void InternetFax()
        {
            // Code to implement Internet Fax
        }
    }
    public class HPPrinterScanner : IPrintFunction, IScanFunction
    {
        public void Print()
        {
            //Print code
        }

        public void GetPrintSpoolDetails()
        {
            // Code to get print spool details
        }

        public void Scan()
        {
            // Code to implement Scan
        }

        public void ScanPhoto()
        {
            // Code to implement Scan Photo
        }
    }

    public class CannonPrinter : IPrintFunction
    {
        public void Print()
        {
            //Print code
        }

        public void GetPrintSpoolDetails()
        {
            // Code to get print spool details
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
