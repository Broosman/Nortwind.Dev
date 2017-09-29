using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.entities;
using Northwind.Core.Common;

namespace Northwind.Core.Base
{
    public class RuleBase
    {
        public const string CUSTOMER_ID_NOT_VALID_MESSAGE = "Customerid får endast vara 5 tecken långt.";
        public RuleBase(Common.StatusObject StatusObject)
        {
            this.StatusObject = StatusObject;
        }
        public virtual StatusObject StatusObject
        {
            get;
            set;
        }
        public virtual void CheckCustomerId(string Customerid)
        {
            try
            {
                if (string.IsNullOrEmpty(Customerid))
                {
                    throw new Common.RuleException(CUSTOMER_ID_NOT_VALID_MESSAGE);
                }
                if (Customerid.Length != 5)
                {
                    throw new Common.RuleException(CUSTOMER_ID_NOT_VALID_MESSAGE);
                }

            }
            catch (Common.RuleException ex)
            {
                throw ex;
            }
        }
        public virtual void ChangePhoneIf030(string Phonenumber)
        {

        }

        public virtual void Check_Standard_With_All_Aggregate(entities.Customer Customer)
        {
            if (Customer.Orders != null)
            {

            }
        }
        public virtual void CheckCustomer(entities.Customer Customer)
        {
            if (Customer.Orders != null)
            {

            }
        }
        public virtual void CheckCustomers(System.Collections.IEnumerable Customers)
        {

        }
        public virtual void CheckProduct(Product Product)
        {

        }
        public virtual void CheckOrders(Order Order)
        {

        }
        public virtual void CheckOrderDetail(Order_Detail OrderDetail)
        {

        }
        public virtual void CheckProducts(System.Collections.IEnumerable Products)
        {
            foreach (var p in Products)
            {

            }
        }
    }
}
