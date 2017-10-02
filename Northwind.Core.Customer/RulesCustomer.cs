using System;
using Northwind.Core.Base;
using Northwind.entities;
using System.Collections.Generic;
namespace Northwind.Core.Customer
{
    public enum CustomerRules
    {
        Check1,
        Check2,
        Check11,
        Check12,
        Check13,
    }
    public class RulesCustomer : RuleBase
    {
        public RulesCustomer()
        {
        }
        public override bool  Check1()
        {
            return true;
        }
        public override bool Check2()
        {
            return true;
        }
        public override bool Check3()
        {
            return true;
        }
        public bool Check10(entities.Customer Customer)
        {
            return true;
        }
        public bool Check11(entities.Customer Customer)
        {
            return true;
        }
        public bool Check12(entities.Customer Customer)
        {
            return true;
        }
    }


}
