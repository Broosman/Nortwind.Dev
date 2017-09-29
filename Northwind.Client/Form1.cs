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
    public partial class Form1 : Form
    {

        delegate void run1_GetCustomerByCustomerId(string id);
        delegate string run2_GetCustomerByCustomerId(string id);
        public Form1()
        {
            InitializeComponent();

        }
      

        public Entities.Customer Customer;
        private void button1_Click(object sender, EventArgs e)
        {

           // GetCustomerByCustomerid("ALFKI");

            run1_GetCustomerByCustomerId r1 = (x) =>
            {
                GetCustomerByCustomerId(x);
            };
            r1("ALFKI");
        }
        private async void GetCustomerByCustomerId(string id)
        {
            try
            {
                Customer = await ServiceCall.NorthwindApi.GetCustomerById(id);
                button1.Text = Customer.ContactName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button2_Click(object sender, EventArgs e)
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

            Customer = await ServiceCall.NorthwindApi.GetCustomerOrderProductSummary(CustomerRequest);         
            button2.Text = Customer.CustomerID;
        }
  
    }
}
