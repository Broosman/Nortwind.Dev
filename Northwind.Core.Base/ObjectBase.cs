using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Northwind.entities;
using Northwind.Core.Common;

namespace Northwind.Core.Base
{

    public abstract class ObjectBase : IBussinessObject
    {
        public ObjectBase()
        {
            StatusObject = new Common.StatusObject();
            StatusObject.Ok = true;
            StatusObject.Status = Common.Status.OK;


        }


        public virtual StatusObject StatusObject
        {
            get;
            set;
        }

        StatusObject IBussinessObject.StatusObject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        RuleBase IBussinessObject.Rules
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual U Execute<T,U>(T request)
        {
            throw new System.NotImplementedException();
        }
        public virtual U Execute<U>()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Addrequest(RequestBase Request)
        {
            throw new System.NotImplementedException();
        }

        public virtual void HandleException(Exception e)
        {
            if (e is RuleException)
            {
                StatusObject.Ok = false;
                StatusObject.Status = Status.NOT_VALID;
                StatusObject.Message = e.Message;
            }
            else if (e is RuleException)
            {
                StatusObject.Ok = false;
                StatusObject.Status = Status.INFO;
                StatusObject.Message = e.Message;
            }
            else if (e is SqlException)
            {
                StatusObject.Ok = false;
                StatusObject.Status = Status.ERROR;
                StatusObject.Message = ((SqlException)e).Message;
                StatusObject.StackTrace = ((SqlException)e).StackTrace;
            }
            else if (e is Exception)
            {
                StatusObject.Ok = false;
                StatusObject.Status = Status.ERROR;
                StatusObject.Message = e.Message;
                StatusObject.StackTrace = e.StackTrace;
            }
            StatusObject.Exception = e;
        }

        public virtual void AddRequest<T>(T request)
        {
            throw new NotImplementedException();
        }

        public virtual void AddRespons<T>(T respons)
        {
            throw new NotImplementedException();
        }
    }
}
