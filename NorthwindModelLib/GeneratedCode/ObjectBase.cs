﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ObjectBase : IBussinessObject
{
	public virtual StatusObject StatusObject
	{
		get;
		set;
	}

	public virtual RuleBase Rules
	{
		get;
		set;
	}

	public virtual IEnumerable<object> Entities
	{
		get;
		set;
	}

	public virtual object Entity
	{
		get;
		set;
	}

	public virtual T Execute<T>()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Addrequest(object item)
	{
		throw new System.NotImplementedException();
	}

}
