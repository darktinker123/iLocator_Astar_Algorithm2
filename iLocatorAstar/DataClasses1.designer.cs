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

namespace iLocatorAstar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbiLocator")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Person(tbl_Person instance);
    partial void Updatetbl_Person(tbl_Person instance);
    partial void Deletetbl_Person(tbl_Person instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::iLocatorAstar.Properties.Settings.Default.dbiLocatorConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUserLog> tblUserLogs
		{
			get
			{
				return this.GetTable<tblUserLog>();
			}
		}
		
		public System.Data.Linq.Table<v_userlog> v_userlogs
		{
			get
			{
				return this.GetTable<v_userlog>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Person> tbl_Persons
		{
			get
			{
				return this.GetTable<tbl_Person>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_AddUserLogs")]
		public int sp_AddUserLogs([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string utype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string start, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string dest, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> logTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), utype, start, dest, logTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewSummaryAll")]
		public ISingleResult<sp_ViewSummaryAllResult> sp_ViewSummaryAll([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> year, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), year, month);
			return ((ISingleResult<sp_ViewSummaryAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewSummaryByUserType")]
		public ISingleResult<sp_ViewSummaryByUserTypeResult> sp_ViewSummaryByUserType([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> year, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> month, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string usertype)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), year, month, usertype);
			return ((ISingleResult<sp_ViewSummaryByUserTypeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_AddPerson")]
		public int sp_AddPerson([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(255)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(255)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserType", DbType="VarChar(255)")] string userType, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Purpose", DbType="VarChar(255)")] string purpose)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lastName, firstName, userType, purpose);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewSearch")]
		public ISingleResult<sp_ViewSearchResult> sp_ViewSearch()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ViewSearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_UpdatePerson")]
		public int sp_UpdatePerson([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(255)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(255)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Purpose", DbType="VarChar(255)")] string purpose)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, firstName, lastName, purpose);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Search")]
		public ISingleResult<sp_SearchResult> sp_Search([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Key", DbType="VarChar(MAX)")] string key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), key);
			return ((ISingleResult<sp_SearchResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUserLogs")]
	public partial class tblUserLog
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public tblUserLog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.v_userlogs")]
	public partial class v_userlog
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public v_userlog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Person")]
	public partial class tbl_Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _UserType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIDChanging(int value);
    partial void OnPersonIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public tbl_Person()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					this.OnPersonIDChanging(value);
					this.SendPropertyChanging();
					this._PersonID = value;
					this.SendPropertyChanged("PersonID");
					this.OnPersonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
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
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
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
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(255)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class sp_ViewSummaryAllResult
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public sp_ViewSummaryAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", DbType="Int NOT NULL")]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	public partial class sp_ViewSummaryByUserTypeResult
	{
		
		private int _userLogID;
		
		private string _usertype;
		
		private string _currentLocation;
		
		private string _destination;
		
		private System.Nullable<System.DateTime> _userLogTime;
		
		public sp_ViewSummaryByUserTypeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogID", DbType="Int NOT NULL")]
		public int userLogID
		{
			get
			{
				return this._userLogID;
			}
			set
			{
				if ((this._userLogID != value))
				{
					this._userLogID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="VarChar(20)")]
		public string usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this._usertype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentLocation", DbType="VarChar(50)")]
		public string currentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				if ((this._currentLocation != value))
				{
					this._currentLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destination", DbType="VarChar(50)")]
		public string destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if ((this._destination != value))
				{
					this._destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userLogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> userLogTime
		{
			get
			{
				return this._userLogTime;
			}
			set
			{
				if ((this._userLogTime != value))
				{
					this._userLogTime = value;
				}
			}
		}
	}
	
	public partial class sp_ViewSearchResult
	{
		
		private int _PersonID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _UserType;
		
		private string _Purpose;
		
		public sp_ViewSearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonID", DbType="Int NOT NULL")]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					this._PersonID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(255)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Purpose", DbType="VarChar(255)")]
		public string Purpose
		{
			get
			{
				return this._Purpose;
			}
			set
			{
				if ((this._Purpose != value))
				{
					this._Purpose = value;
				}
			}
		}
	}
	
	public partial class sp_SearchResult
	{
		
		private int _PersonID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _UserType;
		
		private string _Purpose;
		
		public sp_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonID", DbType="Int NOT NULL")]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					this._PersonID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(255)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Purpose", DbType="VarChar(255)")]
		public string Purpose
		{
			get
			{
				return this._Purpose;
			}
			set
			{
				if ((this._Purpose != value))
				{
					this._Purpose = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
