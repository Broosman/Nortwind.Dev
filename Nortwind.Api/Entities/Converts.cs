using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.Database.Database;
using Northwind.Api.Entities.Aggregations;



namespace Northwind.Api.Entities
{
    public class Converts
    {

        // public static Entities.Customer ToRespons(Customer source)
        //  public static Customer FromRequest(Entities.Customer source)


    
            public static  Customer FromRequest(Customer source)
            {
                var destination = new Customer();
                destination.CustomerID = source.CustomerID;
                destination.CompanyName = source.CompanyName;
                destination.ContactName = source.ContactName;
                destination.ContactTitle = source.ContactTitle;
                destination.Address = source.Address;
                destination.City = source.City;
                destination.Region = source.Region;
                destination.PostalCode = source.PostalCode;
                destination.Country = source.Country;
                destination.Phone = source.Phone;
                destination.Fax = source.Fax;



                return destination;
            }

        
    }
}