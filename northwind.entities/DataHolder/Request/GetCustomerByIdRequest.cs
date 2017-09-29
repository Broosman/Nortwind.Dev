
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
        public static string Customerid { get; set; }
    }
}
