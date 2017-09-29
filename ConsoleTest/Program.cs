using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.entities;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var req = new Northwind.entities.GetCustomerByIdRequest("ALFKI");
            Northwind.Core.Controller.Get<GetCustomerByIdRequest, CustomerResult>(req);  
        }
    }
}
