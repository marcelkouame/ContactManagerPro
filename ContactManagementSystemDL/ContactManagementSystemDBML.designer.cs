﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManagementSystemDL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ContactManagementSystemDB")]
	public partial class ContactManagementSystemDBMLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ContactManagementSystemDBMLDataContext() : 
				base(global::ContactManagementSystemDL.Properties.Settings.Default.ContactManagementSystemDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContactManagementSystemDBMLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactManagementSystemDBMLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactManagementSystemDBMLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactManagementSystemDBMLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetContacts")]
		public ISingleResult<GetContactsResult> GetContacts()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetContactsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertContact")]
		public int InsertContact([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(20)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(30)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="VarChar(30)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Company", DbType="VarChar(50)")] string company, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telephone", DbType="VarChar(20)")] string telephone)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, title, company, email, telephone);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class GetContactsResult
	{
		
		private int _ContactID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Title;
		
		private string _Company;
		
		private string _Email;
		
		private string _Telephone;
		
		public GetContactsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactID", DbType="Int NOT NULL")]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
			set
			{
				if ((this._ContactID != value))
				{
					this._ContactID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(30)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(50)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this._Company = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="VarChar(20)")]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this._Telephone = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
