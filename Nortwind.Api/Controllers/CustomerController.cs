using System.Web.Http;

namespace Northwind.Api.Controllers
{
    [RoutePrefix("Api/Northwind")]
    public class CustomerController : ApiController
    {

        //[HttpGet]
        //[Route("GetCustomers/")]
        //public HttpResponseMessage GetCustomers()
        //{
        //    CustomersResults Respons;
        //    //SaveLog(CustomerId);
        //    try
        //    {
        //        Respons = Core.NWManager.GetCustomers();
        //        if (Respons.StatusObject.Ok)
        //            return Request.CreateResponse(HttpStatusCode.OK, Respons.Customers);
        //        else
        //            return ReturnStatus(Respons.StatusObject);
        //    }
        //    catch (Exception e)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}
        //[HttpGet]
        //[Route("GetProducts/")]
        //public HttpResponseMessage GetProducts()
        //{
        //   ProductsResults Respons;
        //    //SaveLog(CustomerId);
        //    try
        //    {
        //        Respons = Core.NWManager.GetProducts();
        //        if (Respons.StatusObject.Ok)
        //            return Request.CreateResponse(HttpStatusCode.OK, Respons.Products);
        //        else
        //            return ReturnStatus(Respons.StatusObject);
        //    }
        //    catch (System.Exception e)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}
        //[HttpGet]
        //[Route("GetCustomerById/{CustomerId}")]
        //public HttpResponseMessage GetCustomerById(string Customerid)
        //{
        //    CustomerResult Respons;
        //    //SaveLog(CustomerId);
        //    try
        //    {
        //        var oReq = new Core.BaseObjetcs.RequestBase();
        //        oReq.Customer = new NW_Customer();
        //        oReq.Customer.CustomerID = Customerid;
        //        ////////////////////////////////////
        //        Respons = Core.NWManager.GetCustomerById(oReq);
        //        ////////////////////////////////////
        //        if (Respons.StatusObject.Ok)
        //            return Request.CreateResponse(HttpStatusCode.OK, Respons.Customer);  
        //        else
        //            return ReturnStatus(Respons.StatusObject);
        //    }
        //    catch (System.Exception e)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError , e.Message);
        //    }
        //}

        //[HttpPost]
        //[Route("GetCustomerSummary/")]
        //public HttpResponseMessage GetCustomerSummary([FromBody]  CustomerRequest CustomerRequest)
        //{
        //    CustomerResult Respons;
        //    //SaveLog(CustomerId);
        //    try
        //    {
        //        var oReq = new Core.BaseObjetcs.RequestBase();
        //        oReq.Customer = Customer.Convert(CustomerRequest.Customer);
        //        Respons = Core.NWManager.GetCustomerSummary(oReq);
        //        if (Respons.StatusObject.Ok)
        //            return Request.CreateResponse(HttpStatusCode.OK, Customer.Convert(Respons.Customer));
        //        else
        //            return ReturnStatus(Respons.StatusObject);
        //    }
        //    catch (System.Exception e)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}

        //[HttpPost]
        //[Route("SaveCustomer/")]
        //public HttpResponseMessage SaveCustomer([FromBody]  CustomerRequest CustomerRequest)
        //{
        //    CustomerResult Respons;
        //    //SaveLog(CustomerId);
        //    try
        //    {
        //        var oReq = new Core.BaseObjetcs.RequestBase();
        //        oReq.Customer = Customer.Convert(CustomerRequest.Customer);
        //        Respons = Core.NWManager.SaveCustomer(oReq);
        //        if (Respons.StatusObject.Ok)
        //            return Request.CreateResponse(HttpStatusCode.OK, Respons.Customer);
        //        else
        //            return ReturnStatus(Respons.StatusObject);
        //       // return null;
        //    }
        //    catch (System.Exception e)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}


        //private HttpResponseMessage ReturnStatus(Core.Common.StatusObject StatusObject)
        //{

        //    if (StatusObject.Status == Core.Common.Status.NOT_VALID)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotAcceptable, StatusObject.Message);
        //    }
        //    else if (StatusObject.Status == Core.Common.Status.INFO)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, StatusObject.Message);
        //    }
        //    else if (StatusObject.Status == Core.Common.Status.ERROR)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, StatusObject.Message );
        //    }
        //    return Request.CreateResponse(HttpStatusCode.InternalServerError, "");
        //}


    }

}
