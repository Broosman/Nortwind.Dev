using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.entities;
using Northwind.Core.Common;
using Northwind.Core.Base;



namespace Northwind.Core.Customer
{
    public class BizCustomer : Base.ObjectBase 
    {
        public RulesCustomer RulesCustomer { get; set; }

        
        public BizCustomer() : base()
        {
            Customers = new List<entities.Customer>();
            RulesCustomer = new RulesCustomer();
            RulesCustomer.StatusObject = StatusObject;
        }

        public virtual List<entities.Customer> Customers
        {
            get;
            set;
        }

        public virtual entities.Customer Customer
        {
            get { return Customers[0]; }
            set
            {
                if (Customers == null){Customers = new List<entities.Customer>();}
                Customers.Add(value);
            }
        }

        public override void AddRequest<T>(T item)
        {
            Customer = item as entities.Customer;
        }

        public override void AddRespons<T>(T item)
        {
            Customers = null;
            Customer = item as entities.Customer;
        }

        public override  U Execute<T, U>(T request)
        {
            throw new System.NotImplementedException();
        }

        public void Rules(CustomerRules rule)
        {
            foreach (var item in Customers)
            {
                if (rule == CustomerRules.Check11)
                {
                    RulesCustomer.Check11(item);
                }
                else if (rule == CustomerRules.Check12)
                {
                    RulesCustomer.Check12(item);
                }
                else if (rule == CustomerRules.Check13)
                {
                    RulesCustomer.Check10(item);
                }
            }
        }
    }
}
