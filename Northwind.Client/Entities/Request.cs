using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Client.Entities
{
    public class SaveCustomerRequest
    {
        public bool TelNrAnpassad { get; set; }
        public Customer Customer { get; set; }
    }
    public class CustomerRequest
    {
        public bool TelNrAnpassad { get; set; }
        public Customer Customer { get; set; }
    }
}
