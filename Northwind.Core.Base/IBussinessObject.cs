using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Common;

namespace Northwind.Core.Base
{
    public interface IBussinessObject
    {
        StatusObject StatusObject { get; set; }

        RuleBase Rules { get; set; }

        object Entity { get; set; }

        IEnumerable<object> Entities { get; set; }

        void Addrequest(RequestBase RequestBase);

       // T Execute<T>(RequestBase RequestBase);

        U Execute<T, U>(T Request);

    }
}
