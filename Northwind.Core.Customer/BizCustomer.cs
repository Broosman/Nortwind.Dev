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
        public BizCustomer() : base()
        {
            Customers = new List<entities.Customer>();
            Customer = new entities.Customer();
            Rules = new RulesCustomer(this.StatusObject);
        }
        public override RuleBase Rules
        {
            get;
            set;
        }

        public virtual entities.Customer Customer
        {
            get;
            set;
        }

        public virtual List<entities.Customer> Customers
        {
            get;
            set;
        }

       public override  U Execute<T, U>(T request)
        {
            throw new System.NotImplementedException();
        }
    }
}
