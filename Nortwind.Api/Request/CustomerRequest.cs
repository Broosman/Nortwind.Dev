using Northwind.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Request
{
    public class CustomerRequest
    {
        public bool TelNrAnpassad { get; set; }
        public  Customer Customer { get; set; }
    }
}