using System;
using Northwind.Core.Base;
namespace Northwind.Core.Customer
{
    public class RulesCustomer : RuleBase
        {
            // lägger const i basklassen

            public RulesCustomer(Common.StatusObject StatusObject) : base(StatusObject)
            {
            }
            public override void CheckCustomer(entities.Customer Customer)
            {

            }
            public override void CheckCustomers(System.Collections.IEnumerable Customers)
            {

            }

            public void ChangePhonenumberIf_Anpassad(bool anpassad, entities.Customer Customer)
            {
                try
                {
                    if (anpassad)
                    {
                        if (Customer.Phone.Substring(0, 3) == "030")
                        {
                            Customer.Phone = Customer.Phone.Replace("030", "010");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    
}
