using Northwind.Database.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }

        public static Order Convert(Order source)
        {
            var destination = new Order();
            destination.OrderID = source.OrderID;
            destination.CustomerID = source.CustomerID;
            destination.EmployeeID = source.EmployeeID;
            destination.OrderDate = source.OrderDate;
            destination.RequiredDate = source.RequiredDate;
            destination.ShippedDate = source.ShippedDate;
            destination.ShipVia = source.ShipVia;
            destination.Freight = source.Freight;
            destination.ShipName = source.ShipName;
            destination.ShipAddress = source.ShipAddress;
            destination.ShipCity = source.ShipCity;
            destination.ShipRegion = source.ShipRegion;
            destination.ShipPostalCode = source.ShipPostalCode;
            destination.ShipCountry = source.ShipCountry;

           // destination.Employee = ToRespons(source.Employee);

            if (source.OrderDetails != null)
            {
                destination.OrderDetails  = new List<OrderDetail>();
                foreach (var orddtl in source.OrderDetails)
                {
                    var oOrderDetail = OrderDetail.Convert(orddtl);
                    destination.OrderDetails.Add(oOrderDetail);
                }
            }

            return destination;
        }
        public static Database.Database.Order Convert(Order  source)
        {
            var destination = new Order ();
            destination.OrderID = source.OrderID;
            destination.CustomerID = source.CustomerID;
            destination.EmployeeID = source.EmployeeID;
            destination.OrderDate = source.OrderDate;
            destination.RequiredDate = source.RequiredDate;
            destination.ShippedDate = source.ShippedDate;
            destination.ShipVia = source.ShipVia;
            destination.Freight = source.Freight;
            destination.ShipName = source.ShipName;
            destination.ShipAddress = source.ShipAddress;
            destination.ShipCity = source.ShipCity;
            destination.ShipRegion = source.ShipRegion;
            destination.ShipPostalCode = source.ShipPostalCode;
            destination.ShipCountry = source.ShipCountry;

            //destination.Employee = ToRespons(source.Employee);

            if (source.OrderDetails  != null)
            {
                destination.OrderDetails  = new List<OrderDetail>();
                foreach (var orddtl in source.OrderDetails)
                {
                    var oOrderDetail = OrderDetail.Convert(orddtl);
                    destination.OrderDetails.Add(oOrderDetail);
                }
            }
            return destination;
        }
    }
}
