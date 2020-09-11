using System;

namespace LearnSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILogger log = new EventViewLogger();
            CustomerDAL cus = new CustomerDAL(log);
            cus.InsertCustomer();

            IEmployeeReportBAL objBal = new ReportBAL();
          
            objBal.GeneratePFReport();


            Console.ReadKey();
        }
    }
}
