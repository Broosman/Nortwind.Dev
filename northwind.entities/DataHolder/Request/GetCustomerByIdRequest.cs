
namespace Northwind.entities
{
    public class GetCustomerByIdRequest  
    {
        static GetCustomerByIdRequest()
        {           
        }
        public GetCustomerByIdRequest(string customerid)
        {
           Customerid = customerid;
        }
        public string Customerid { get; set; }
    }
}
