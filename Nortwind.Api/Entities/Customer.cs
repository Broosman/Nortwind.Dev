using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public static Customer Convert(Database.Database.Customer  source)
        {
            if (source == null) return null;
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

            if (source.Orders != null)
            {
                destination.Orders = new List<Order>();
                foreach (var order in source.Orders)
                {
                    var nw_order = Order.Convert(order);
                    destination.Orders.Add(nw_order);
                }
            }
            return destination;
        }

        public static Database.Database.Customer Convert(Customer source)
        {
            if (source == null) return null;
            var destination = new Database.Database.Customer();
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

            if (source.Orders != null)
            {
                destination.Orders = new List<Database.Database.Order>();
                foreach (var order in source.Orders)
                {
                    var nw_order = Order.Convert(order);
                    destination.Orders.Add(nw_order);
                }
            }
            return destination;
        }
    }
}

//        public static Database.Database.Customer ToBussinessEntity(Aggregations.Customer source)
//        {
//            if (source == null) return null;
//            var destination = new Database.Database.Customer();
//            destination.CustomerID = source.CustomerID;
//            destination.CompanyName = source.CompanyName;
//            destination.ContactName = source.ContactName;
//            destination.ContactTitle = source.ContactTitle;
//            destination.Address = source.Address;
//            destination.City = source.City;
//            destination.Region = source.Region;
//            destination.PostalCode = source.PostalCode;
//            destination.Country = source.Country;
//            destination.Phone = source.Phone;
//            destination.Fax = source.Fax;
//            if (source.Orders != null)
//            {
//                destination.Orders = new List<Database.Database.Order>();
//                foreach (var order in source.Orders)
//                {
//                    //var o = ToRespons(order);
//                    //destination.Orders.Add(o);
//                }
//            }
//            return destination;
//        }

//    }
//}

//namespace Northwind.Api.Entities.Aggregations
//{
//    public class Customer : Entities.Customer 
//    {
//        public Customer()
//        {
//            this.Orders = new HashSet<Order>();
//        }
//        public virtual ICollection<Aggregations.Order> Orders { get; set; }

//    }
//}