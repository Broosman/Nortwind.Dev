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

        // public static Entities.Customer ToRespons(NW_Customer source)
        //  public static NW_Customer FromRequest(Entities.Customer source)


    
            public static  NW_Customer FromRequest(Customer source)
            {
                var destination = new NW_Customer();
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

                //if (source.Orders != null)
                //{
                //    destination.Orders = new List<NW_Order>();
                //    foreach (var order in source.Orders)
                //    {
                //        var o = Order.Map_Order(order);
                //        destination.Orders.Add(o);
                //    }
                //}

                return destination;
            }

            //public static Aggregations.Customer ToRespons(NW_Customer source)
            //{
            //    if (source == null) return null;
            //    var destination = new Aggregations.Customer();
            //    destination.CustomerID = source.CustomerID;
            //    destination.CompanyName = source.CompanyName;
            //    destination.ContactName = source.ContactName;
            //    destination.ContactTitle = source.ContactTitle;
            //    destination.Address = source.Address;
            //    destination.City = source.City;
            //    destination.Region = source.Region;
            //    destination.PostalCode = source.PostalCode;
            //    destination.Country = source.Country;
            //    destination.Phone = source.Phone;
            //    destination.Fax = source.Fax;

            //    if (source.Orders != null)
            //    {
            //        destination.Orders = new List<Aggregations.Order>();
            //        foreach (var order in source.Orders)
            //        {
            //            var o = ToRespons(order);
            //            destination.Orders.Add(o);
            //        }
            //    }

            //    return destination;
            //}

            //public static Aggregations.Order ToRespons(NW_Order source)
            //{
            //    var destination = new Aggregations.Order();
            //    destination.OrderID = source.OrderID;
            //    destination.CustomerID = source.CustomerID;
            //    destination.EmployeeID = source.EmployeeID;
            //    destination.OrderDate = source.OrderDate;
            //    destination.RequiredDate = source.RequiredDate;
            //    destination.ShippedDate = source.ShippedDate;
            //    destination.ShipVia = source.ShipVia;
            //    destination.Freight = source.Freight;
            //    destination.ShipName = source.ShipName;
            //    destination.ShipAddress = source.ShipAddress;
            //    destination.ShipCity = source.ShipCity;
            //    destination.ShipRegion = source.ShipRegion;
            //    destination.ShipPostalCode = source.ShipPostalCode;
            //    destination.ShipCountry = source.ShipCountry;

            //    destination.Employee = ToRespons(source.Employee);

            //    if (source.OrderDetails != null)
            //    {
            //        destination.OrderDetails = new List<Aggregations.OrderDetails>();
            //        foreach (var orddtl in source.OrderDetails)
            //        {
            //            var oOrderDetail = ToRespons(orddtl);
            //            destination.OrderDetails.Add(oOrderDetail);
            //        }
            //    }

            //    return destination;
            //}     
            //public static Aggregations.OrderDetails ToRespons(NW_OrderDetail source)
            //{
            //    var destination = new Aggregations.OrderDetails();
            //    destination.OrderID = source.OrderID;
            //    destination.ProductID = source.ProductID;
            //    destination.UnitPrice = source.UnitPrice;
            //    destination.Quantity = source.Quantity;
            //    destination.Discount = source.Discount;

            //    destination.Product = new Aggregations.Product();
            //ToRespons(source.Product);

            //    return destination;
            //}
        
            //public static Product ToRespons(NW_Product source)
            //{
            //    var destination = new Product();
            //    destination.ProductID = source.ProductID;
            //    destination.ProductName = source.ProductName;
            //    destination.SupplierID = source.SupplierID;
            //    destination.CategoryID = source.CategoryID;
            //    destination.QuantityPerUnit = source.QuantityPerUnit;
            //    destination.UnitPrice = source.UnitPrice;
            //    destination.UnitsInStock = source.UnitsInStock;
            //    destination.UnitsOnOrder = source.UnitsOnOrder;
            //    destination.ReorderLevel = source.ReorderLevel;
            //    destination.Discontinued = source.Discontinued;

            //    return destination;
            //}
              
            //public static Aggregations.Employee ToRespons(NW_Employee source)
            //{
            //    var destination = new Aggregations.Employee();
            //    destination.EmployeeID = source.EmployeeID;
            //    destination.LastName = source.LastName;
            //    destination.FirstName = source.FirstName;
            //    destination.Title = source.Title;
            //    destination.TitleOfCourtesy = source.TitleOfCourtesy;
            //    destination.BirthDate = source.BirthDate;
            //    destination.HireDate = source.HireDate;
            //    destination.Address = source.Address;
            //    destination.City = source.City;
            //    destination.Region = source.Region;
            //    destination.PostalCode = source.PostalCode;
            //    destination.Country = source.Country;
            //    destination.HomePhone = source.HomePhone;
            //    destination.Extension = source.Extension;
            //    destination.Photo = source.Photo;
            //    destination.Notes = source.Notes;
            //    destination.ReportsTo = source.ReportsTo;
            //    destination.PhotoPath = source.PhotoPath;

            //    return destination;
            //} 

            //public static StatusObject ToRespons(Core.Common.StatusObject source)
            //{
            //    var destination = new StatusObject();
            //    destination.Status = source.Status;
            //    destination.StatusText = source.StatusText;
            //    destination.Message = source.Message;
            //    return destination;
            //}

        
    }
}