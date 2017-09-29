using System;
using System.Collections.Generic;


namespace Northwind.Client.Entities
{
    //public class CustomerResult
    //{
    //    public virtual Customer Customer
    //    {
    //        get;
    //        set;
    //    }
    //}
    public  class Customer
    {
        
        public Customer()
        {
           this.Orders = new HashSet<Order>();
        }

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



    }

    public  class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

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

        //public virtual Customer Customer { get; set; }
       // public Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        //public virtual Shipper Shipper { get; set; }


        //    public static Order Map_Order(Core.Database.NW_Order source)
        //    {

        //        var destination = new Order();
        //        destination.OrderID = source.OrderID;
        //        destination.CustomerID = source.CustomerID;
        //        destination.EmployeeID = source.EmployeeID;
        //        destination.OrderDate = source.OrderDate;
        //        destination.RequiredDate = source.RequiredDate;
        //        destination.ShippedDate = source.ShippedDate;
        //        destination.ShipVia = source.ShipVia;
        //        destination.Freight = source.Freight;
        //        destination.ShipName = source.ShipName;
        //        destination.ShipAddress = source.ShipAddress;
        //        destination.ShipCity = source.ShipCity;
        //        destination.ShipRegion = source.ShipRegion;
        //        destination.ShipPostalCode = source.ShipPostalCode;
        //        destination.ShipCountry = source.ShipCountry;

        //        destination.Employee = Employee.Map_Employee(source.Employee);



        //        if (source.OrderDetails  != null)
        //        {
        //            destination.OrderDetails = new List<OrderDetail>();
        //            foreach (var orddtl in source.OrderDetails)
        //            {
        //                var oOrderDetail = OrderDetail.Map_OrderDetail (orddtl);
        //                destination.OrderDetails.Add(oOrderDetail);
        //            }
        //        }

        //        return destination;
        //    }

        //}

        public class OrderDetail
        {
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }

            // public virtual Order Order { get; set; }
            public virtual Product Product { get; set; }


        }

        public class Shipper
        {
            public Shipper()
            {
                this.Orders = new HashSet<Order>();
            }

            public int ShipperID { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }


            public virtual ICollection<Order> Orders { get; set; }
        }

        public class Product
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Product()
            {
                // this.OrderDetails = new HashSet<OrderDetail>();
            }

            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public Nullable<int> SupplierID { get; set; }
            public Nullable<int> CategoryID { get; set; }
            public string QuantityPerUnit { get; set; }
            public Nullable<decimal> UnitPrice { get; set; }
            public Nullable<short> UnitsInStock { get; set; }
            public Nullable<short> UnitsOnOrder { get; set; }
            public Nullable<short> ReorderLevel { get; set; }
            public bool Discontinued { get; set; }

            public virtual Categorie Categorie { get; set; }
            public virtual Supplier Supplier { get; set; }

        }

        public partial class Employee
        {

            public Employee()
            {
                this.Orders = new HashSet<Order>();
            }

            public int EmployeeID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Title { get; set; }
            public string TitleOfCourtesy { get; set; }
            public Nullable<System.DateTime> BirthDate { get; set; }
            public Nullable<System.DateTime> HireDate { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string HomePhone { get; set; }
            public string Extension { get; set; }
            public byte[] Photo { get; set; }
            public string Notes { get; set; }
            public Nullable<int> ReportsTo { get; set; }
            public string PhotoPath { get; set; }
            public virtual ICollection<Order> Orders { get; set; }
            }

        public partial class Supplier
        {
            public Supplier()
            {
                this.Products = new HashSet<Product>();
            }
            public int SupplierID { get; set; }
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
            public string HomePage { get; set; }
            public virtual ICollection<Product> Products { get; set; }
        }

        public partial class Categorie
        {

            public Categorie()
            {
                this.Products = new HashSet<Product>();
            }

            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public byte[] Picture { get; set; }


            public virtual ICollection<Product> Products { get; set; }
        }
    }
}