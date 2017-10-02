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

        void AddRequest<T>(T RequestBase);

        void AddRespons<T>(T RequestBase);

        U Execute<T, U>(T Request);
        U Execute<U>();

    }
}
