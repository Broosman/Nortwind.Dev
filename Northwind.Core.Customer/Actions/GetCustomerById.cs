using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Base;
using Northwind.entities;

namespace Northwind.Core.Customer.Actions
{
    public class GetCustomerById : BizCustomer 
    {

        public override U Execute<T, U>(T request)
        {
            try
            {
                var req = request as GetCustomerByIdRequest;
                var Customerid = req.Customerid;
                Rules.CheckCustomerId(Customerid);
                Customer = null; // DbManager.GetCustomerById(Customerid);
                Rules.ChangePhoneIf030(Customer.Phone);
                return (U)Convert.ChangeType(Customer, typeof(U));
            }
            catch (Exception e)
            {
                HandleException(e);
                throw;
            }

        }
        public string CustomerId
        {
            get;
            set;
        }

        public GetCustomerById() : base()
        {
        }

    }
}
