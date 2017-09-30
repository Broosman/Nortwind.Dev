using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Data;
using System.Configuration;
using Northwind.Settings;
using Northwind.entities;

public class DbManager
{

    public static Customer SaveCustomer(Customer customer)
    {
        return customer;
    }
    public static Customer GetCustomerById(string customerid)
    {



        var customer = new Customer {
            CustomerID = "ALFKI"
                    ,
            CompanyName = "Alfreds Futterkiste"
                    ,
            ContactName = "Maria Anders"
                    ,
            ContactTitle = "Sales Representative"
                    ,
            Address = "Obere Str. 57"
                    ,
            City = "Berlin"
                    ,
            Region = null
                    ,
            PostalCode = "12209"
                    ,
            Country = "Germany"
                    ,
            Phone = "031-0074321"
                    ,
            Fax = "030-0076545"
        };
        //23,18,12,8,6,4,1
        var OrderDetails = new List<Order_Detail>();
        var od1 = new Order_Detail { ProductID = 23, OrderID = 1 };
        od1.Product = GetProduct(23);
        OrderDetails.Add(od1);
        var od2 = new Order_Detail { ProductID =18, OrderID = 2 };
        od2.Product = GetProduct(18);
        OrderDetails.Add(od2);
        var od3 = new Order_Detail { ProductID = 1, OrderID = 3 };
        od3.Product = GetProduct(1);
        OrderDetails.Add(od3);
        var o1 = new Order { Order_Details = OrderDetails };
        customer.Orders = new List<Order>();
        customer.Orders.Add(o1);

        var OrderDetails1 = new List<Order_Detail>();
        var od11 = new Order_Detail { ProductID = 12, OrderID = 4 };
        od11.Product = GetProduct(23);
        OrderDetails1.Add(od11);
        var od22 = new Order_Detail { ProductID = 6, OrderID = 5 };
        od22.Product = GetProduct(18);
        OrderDetails1.Add(od22);
        var od33 = new Order_Detail { ProductID = 4, OrderID = 6 };
        od3.Product = GetProduct(1);
        OrderDetails1.Add(od33);
        var od44 = new Order_Detail { ProductID = 8, OrderID = 7 };
        od44.Product = GetProduct(8);
        OrderDetails1.Add(od44);
        var o11 = new Order { Order_Details = OrderDetails1 };
        customer.Orders.Add(o11);

        return customer;

    }



    public static List<Customer> GetCustomers()
    {
        //23,18,12,8,6,4,1

        var l = new List<Customer>();
        l.Add(new Customer
        {
            CustomerID = "ALFKI"
                    ,
            CompanyName = "Alfreds Futterkiste"
                    ,
            ContactName = "Maria Anders"
                    ,
            ContactTitle = "Sales Representative"
                    ,
            Address = "Obere Str. 57"
                    ,
            City = "Berlin"
                    ,
            Region = null
                    ,
            PostalCode = "12209"
                    ,
            Country = "Germany"
                    ,
            Phone = "031-0074321"
                    ,
            Fax = "030-0076545"
        });

        l.Add(new Customer
        {
            CustomerID = "ANTON"
                    ,
            CompanyName = "Antonio Moreno Taquería"
                    ,
            ContactName = "Antonio Moreno"
                    ,
            ContactTitle = "Owner"
                    ,
            Address = "Mataderos  2312"
                    ,
            City = "México D.F."
                    ,
            Region = null
                    ,
            PostalCode = "05023"
                    ,
            Country = "Mexico"
                    ,
            Phone = "(171) 555-7788"
                    ,
            Fax = "(171) 555-6750"
        });

        l.Add(new Customer
        {
            CustomerID = "BERGS"
            ,
            CompanyName = "Berglunds snabbköp"
            ,
            ContactName = "Christina Berglund"
            ,
            ContactTitle = "Order Administrator"
            ,
            Address = "Berguvsvägen  8"
            ,
            City = "Luleå"
            ,
            Region = null
            ,
            PostalCode = "S-958 22"
            ,
            Country = "Sweden"
            ,
            Phone = "0921-12 34 65"
            ,
            Fax = "0921-12 34 67"
        });

        return l;
    }

    public static Product GetProduct(int Id)
    {
        foreach(var item in GetProducts())
        {
            item.ProductID = Id;
            return item;
        }
        return null;
    }

    public static List<Product> GetProducts()
    {
        var l = new List<Product>();
        l.Add(new Product
        {
            ProductID = 1
            ,
            ProductName = "Chai"
            ,
            SupplierID = 1
            ,
            CategoryID = 1
            ,
            QuantityPerUnit = "10 boxes x 20 bags"
            ,
            UnitPrice = 18
            ,
            UnitsOnOrder = 0
            ,
            UnitsInStock = 39
            ,
            ReorderLevel = 10
            ,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 4
    ,
            ProductName = "Chef Anton's Cajun Seasoning"
    ,
            SupplierID = 3
    ,
            CategoryID = 7
    ,
            QuantityPerUnit = "48 - 6 oz jars"
    ,
            UnitPrice = 5
    ,
            UnitsOnOrder = 0
    ,
            UnitsInStock = 300
    ,
            ReorderLevel = 10
    ,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 6
,
            ProductName = "Grandma's Boysenberry Spread"
,
            SupplierID = 2
,
            CategoryID = 3
,
            QuantityPerUnit = "12 - 8 oz jars"
,
            UnitPrice = 189
,
            UnitsOnOrder = 0
,
            UnitsInStock = 7
,
            ReorderLevel = 10
,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 8
,
            ProductName = "Northwoods Cranberry Sauce"
,
            SupplierID = 6
,
            CategoryID = 3
,
            QuantityPerUnit = "12 - 12 oz jars"
,
            UnitPrice = 300
,
            UnitsOnOrder = 0
,
            UnitsInStock = 8
,
            ReorderLevel = 10
,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 12
,
            ProductName = "Queso Manchego La Pastora"
,
            SupplierID = 2
,
            CategoryID = 3
,
            QuantityPerUnit = "10 - 500 g pkgs."
,
            UnitPrice = 39
,
            UnitsOnOrder = 0
,
            UnitsInStock = 22
,
            ReorderLevel = 10
,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 18
,
            ProductName = "Carnarvon Tigers"
,
            SupplierID = 2
,
            CategoryID = 3
,
            QuantityPerUnit = "16 kg pkg."
,
            UnitPrice = 39
,
            UnitsOnOrder = 0
,
            UnitsInStock = 22
,
            ReorderLevel = 10
,
            Discontinued = false
        });

        l.Add(new Product
        {
            ProductID = 23
,
            ProductName = "Tunnbröd"
,
            SupplierID = 2
,
            CategoryID = 3
,
            QuantityPerUnit = "12 - 250 g pkgs."
,
            UnitPrice = 39
,
            UnitsOnOrder = 0
,
            UnitsInStock = 22
,
            ReorderLevel = 10
,
            Discontinued = false
        });

        return l;
    }
}



/*
public class DbManager

    {

    public static List<Customer> GetCustomers()
    {
        List<Customer> Customers = null;
        using (var db = new NorthwindDbContext())
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[GetCustomers]";
                db.Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                Customers = ((IObjectContextAdapter)db).ObjectContext.Translate<Customer>(reader, "Customer", MergeOption.AppendOnly).ToList();
            }
            finally
            {
                db.Database.Connection.Close();
            }

        }
        return Customers;
    }
    public static List<Product> GetProducts()
    {
        List<Product> Products = null;
        using (var db = new NorthwindDbContext())
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[GetProducts]";
                db.Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                Products = ((IObjectContextAdapter)db).ObjectContext.Translate<Product>(reader, "Product", MergeOption.AppendOnly).ToList();
            }
            finally
            {
                db.Database.Connection.Close();
            }

        }
        return Products;
    }
    public static Customer SaveCustomer(Customer Customer)
    {
        using (var db = new NorthwindDbContext())
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var cmd = db.Database.Connection.CreateCommand();
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", Customer.CustomerID));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", Customer.CompanyName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", Customer.ContactName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", Customer.ContactTitle));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", Customer.Address));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", Customer.City));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", Customer.Region));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", Customer.PostalCode));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", Customer.Country));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", Customer.Phone));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", Customer.Fax));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[SaveCustomer]";
                db.Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                Customer = ((IObjectContextAdapter)db).ObjectContext.Translate<Customer>(reader, "Customer", MergeOption.AppendOnly).FirstOrDefault();
            }
            finally
            {
                db.Database.Connection.Close();
            }
        }
        return Customer;
    }
    public static Customer GetCustomerById(string customerid)
        {
            Customer Customer = null;
            using (var db = new NorthwindDbContext())
            {
                try
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    var cmd = db.Database.Connection.CreateCommand();
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerId", customerid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[GetCustomerById]";
                    db.Database.Connection.Open();
                    var reader = cmd.ExecuteReader();
                    Customer = ((IObjectContextAdapter)db).ObjectContext.Translate<Customer>(reader, "Customer", MergeOption.AppendOnly).FirstOrDefault();
                }
                finally
                {
                    db.Database.Connection.Close();
                }

            }
            return Customer;
        }
        /// <summary>
        /// 
        /// </summary>
        public static Customer GetCustomerOrderProductSummary(string customerid)
        {
            //var customerList = new List<Customer>();
            var orderDetailsList = new List<OrderDetail>();
            var Customer = new Customer();
            var employees = new List<Employee>();
            var products = new List<Product>();

            using (var db = new NorthwindDbContext())
            {
                db.Configuration.ProxyCreationEnabled = false;

                db.Database.Connection.ConnectionString = Config.NorthwindAPI.NortwindDbConnection;
                var cmd = db.Database.Connection.CreateCommand();
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerId", customerid));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[GetCustomerOrderProductSummary]";

                try
                {

                    db.Database.Connection.Open();
                    var reader = cmd.ExecuteReader();


                    Customer = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Customer>(reader, "Customer", MergeOption.AppendOnly).FirstOrDefault();


                    reader.NextResult();
                    Customer.Orders = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Order>(reader, "Order", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    orderDetailsList = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<OrderDetail>(reader, "OrderDetail", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    products = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Product>(reader, "Product", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    employees = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Employee>(reader, "Employee", MergeOption.AppendOnly).ToList();


                }
                finally
                {
                    db.Database.Connection.Close();
                }
            }


            foreach (var order in Customer.Orders)
            {
                foreach (var emp in employees)
                {
                    if (order.EmployeeID == emp.EmployeeID)
                    {
                        order.Employee = emp;
                    }
                }

                foreach (var orderdtls in order.OrderDetails)
                {
                    if (order.OrderID == orderdtls.OrderID)
                    {

                        order.OrderDetails.Add(orderdtls);

                        foreach (var product in products)
                        {
                            if (orderdtls.ProductID == product.ProductID)
                            {
                                orderdtls.Product = product;
                            }
                        }
                    }
                }
            }

            return Customer;
        }
    }

    */