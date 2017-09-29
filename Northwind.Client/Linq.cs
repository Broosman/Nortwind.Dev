using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Client
{
    public partial class Linq : Form
    {
        public Linq()
        {
            InitializeComponent();
        }
        public Entities.Customer Customer;
        private void button1_Click(object sender, EventArgs e)
        {
            GetCustomerOrderProductSummary();

        }

        public async void GetCustomerOrderProductSummary()
        {
            var CustomerRequest = new Entities.CustomerRequest
            {
                Customer = new Entities.Customer
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
                }
            };

            //Customer = await ServiceCall.NorthwindApi.GetCustomerOrderProductSummary(CustomerRequest);
            var Customer1 = await ServiceCall.NorthwindApi.GetCustomerOrderProductSummary(CustomerRequest);
            var Customer2 = await ServiceCall.NorthwindApi.GetCustomerOrderProductSummary(CustomerRequest);


            var result = from o1 in Customer1.Orders
                         join o2 in Customer2.Orders on o1.OrderID equals o2.OrderID
                         select new { o1.CustomerID, o2.EmployeeID };

            foreach (var item in result)
            {
                string customerid = item.CustomerID;
                int? employeeId = item.EmployeeID; 
            }
            
            //var  order =  Customer.Orders.Where(d => d.OrderID > 10643);
            //var result = from order in Customer.Orders where order.OrderDetails.Count > 1 select order;
            //Entities.Order o = result.ToOrder();
  
            
            //foreach (var o in order)
            //{
            //   string asd = o.CustomerID;
            //}

        }

    }
    public static class Extensions
    {
        public static Entities.Order ToOrder(this IEnumerable<Entities.Order> source)
        {
            var order = new Entities.Order();
            foreach (var item in source)
            {
                order.OrderID = item.OrderID;
            }

            return order;
        }
    }
}
