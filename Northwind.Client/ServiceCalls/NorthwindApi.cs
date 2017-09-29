using Newtonsoft.Json;
using Northwind.Client.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Northwind.Client.ServiceCall
{
    class NorthwindApi
    {
        static HttpClient client = new HttpClient();


        static  void Initialize()
        {

            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:30384/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Customer> GetCustomerById(string id)
        {
            try
            {
                Initialize();
                // HttpResponseMessage response = await client.GetAsync("Api/Northwind/GetCustomerById/ALFKI" + id); 
                HttpResponseMessage response = await client.GetAsync("Api/Northwind/GetCustomerById/" + id);           
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Customer = JsonConvert.DeserializeObject<Customer>(responseBody);
                return Customer;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }

        }

        public static async Task<Customer> GetCustomerOrderProductSummary(Entities.CustomerRequest CustomerRequest)
        {
            try
            {
                Initialize();
                HttpResponseMessage response = await client.PostAsJsonAsync("Api/Northwind/GetCustomerSummary", CustomerRequest);
                response.EnsureSuccessStatusCode();
                Customer oCustomer = await response.Content.ReadAsAsync<Customer>();
                return oCustomer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async void SaveCustomer(Customer Customer)
        {
            Initialize();
            //  HttpResponseMessage response = await client.PutAsJsonAsync($"api/products/{product.Id}", product);
            HttpResponseMessage response = await client.PostAsJsonAsync("Api/Northwind/SaveCustomer", Customer);
            response.EnsureSuccessStatusCode();
            Customer res = await response.Content.ReadAsAsync<Customer>();
        }
    }
}
