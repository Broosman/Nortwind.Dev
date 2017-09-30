using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.entities;
using Northwind.Core;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           var req = new GetCustomerByIdRequest("ALFKI");
           var result = Controller.Execute<GetCustomerByIdRequest, CustomerResult>(req);


            var request = new SaveCustomerRequest();
            request.Customer = result.Customer;
            Controller.Execute<SaveCustomerRequest, CustomerResult>(request);
            
        }
    }
}
