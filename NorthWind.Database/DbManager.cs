using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Data;
using Northwind.Database.Database;
using System.Configuration;
using Northwind.Settings;

public class DbManager
    {


    //private static string _ConnectionName = "NORTHWINDDBCONTEXT";
    //private static string _Environment = null;
    //public static string Connection
    //{
    //    get
    //    {
    //        return ConfigurationManager.AppSettings[string.Concat("NORTHWINDDBCONTEXT", _Environment)];
    //        var asd = ConfigurationManager.AppSettings[string.Concat("NORTHWINDDBCONTEXT", string.Concat("_", ConfigurationManager.AppSettings["ACTIVE_ENVIRONMENT"]))];
    //        return ConfigurationManager.AppSettings[string.Concat("NORTHWINDDBCONTEXT", string.Concat("_", ConfigurationManager.AppSettings["ACTIVE_ENVIRONMENT"]))];                
    //    }
    //}

    public static List<NW_Customer> GetCustomers()
    {
        List<NW_Customer> Customers = null;
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
                Customers = ((IObjectContextAdapter)db).ObjectContext.Translate<NW_Customer>(reader, "NW_Customer", MergeOption.AppendOnly).ToList();
            }
            finally
            {
                db.Database.Connection.Close();
            }

        }
        return Customers;
    }
    public static List<NW_Product> GetProducts()
    {
        List<NW_Product> Products = null;
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
                Products = ((IObjectContextAdapter)db).ObjectContext.Translate<NW_Product>(reader, "NW_Product", MergeOption.AppendOnly).ToList();
            }
            finally
            {
                db.Database.Connection.Close();
            }

        }
        return Products;
    }
    public static NW_Customer SaveCustomer(NW_Customer Customer)
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
                Customer = ((IObjectContextAdapter)db).ObjectContext.Translate<NW_Customer>(reader, "NW_Customer", MergeOption.AppendOnly).FirstOrDefault();
            }
            finally
            {
                db.Database.Connection.Close();
            }
        }
        return Customer;
    }
    public static NW_Customer GetCustomerById(string customerid)
        {
            NW_Customer Customer = null;
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
                    Customer = ((IObjectContextAdapter)db).ObjectContext.Translate<NW_Customer>(reader, "NW_Customer", MergeOption.AppendOnly).FirstOrDefault();
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
        public static NW_Customer GetCustomerOrderProductSummary(string customerid)
        {
            //var customerList = new List<NW_Customer>();
            var orderDetailsList = new List<NW_OrderDetail>();
            var Customer = new NW_Customer();
            var employees = new List<NW_Employee>();
            var products = new List<NW_Product>();

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
                        .Translate<NW_Customer>(reader, "NW_Customer", MergeOption.AppendOnly).FirstOrDefault();


                    reader.NextResult();
                    Customer.Orders = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<NW_Order>(reader, "NW_Order", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    orderDetailsList = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<NW_OrderDetail>(reader, "NW_OrderDetail", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    products = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<NW_Product>(reader, "NW_Product", MergeOption.AppendOnly).ToList();

                    reader.NextResult();
                    employees = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<NW_Employee>(reader, "NW_Employee", MergeOption.AppendOnly).ToList();


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

