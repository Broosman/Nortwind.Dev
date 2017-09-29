using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public class StatusObject
    {
       // public Core.Common.Status Status { get; set; }
        public string StatusText { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }


    }
}