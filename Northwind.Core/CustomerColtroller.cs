using Northwind.Core.Base;
using Northwind.Core.Common;
using Northwind.Core.Customer;
using Northwind.Core.Customer.Actions;
using Northwind.entities;
using System;

namespace Northwind.Core
{
    public class CustomerController
    {

        public static CustomerResult Get<T>(T Request)
        {

            IBussinessObject Action = GetTypeOf<T>(Request);
            CustomerResult respons = null;
           //Skicka in customerresult som U
           // gör en get i Controller och är från den.
            try
            {
                respons = new CustomerResult
                {
                    Customer = Action.Execute<GetCustomerByIdRequest, entities.Customer>(Request as GetCustomerByIdRequest),
                    StatusObject = Action.StatusObject
                };
            }
            catch (Exception e)
            {
                return new CustomerResult
                {
                    Customer = null,
                    StatusObject = Action.StatusObject
                };
            }
            return respons;
        }
        public static CustomerResult GetCustomerById<T>(T Request)
        {

            IBussinessObject Action = GetTypeOf<T>(Request);
            CustomerResult respons = null;
            try
            {
                respons = new CustomerResult
                {
                    Customer = Action.Execute<GetCustomerByIdRequest, entities.Customer>(Request as GetCustomerByIdRequest),
                    StatusObject = Action.StatusObject
                };
            }
            catch (Exception e)
            {
                return new CustomerResult
                {
                    Customer = null,
                    StatusObject = Action.StatusObject
                };
            }
            return respons;
        }

        public static U Get<T, U>(T request)
        {
            //IBussinessObject Action = null;
            IBussinessObject Action = GetTypeOf<T>(request);
            Action.Execute<T, U>(request);
            return default(U);
        }

        private static IBussinessObject GetTypeOf<T>(T request)
        {
            if (request is entities.GetCustomerByIdRequest)
            {
                return new GetCustomerById();
            }
            return null;
        }
    }
}
