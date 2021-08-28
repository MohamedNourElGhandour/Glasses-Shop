﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glasses_Shop
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="glasses_shop")]
	public partial class glasses_shopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public glasses_shopDataContext() : 
				base(global::glasses_Shop.Properties.Settings.Default.glasses_shopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public glasses_shopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public glasses_shopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public glasses_shopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public glasses_shopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Name;
		
		private string _doctorname;
		
		private System.Nullable<decimal> _price;
		
		private System.Nullable<System.DateTime> _date;
		
		private string _observations;
		
		private string _tele;
		
		private string _lensec_Id;
		
		private string _DR_sph;
		
		private string _DR_cyx;
		
		private string _DR_ax;
		
		private string _DL_sph;
		
		private string _DL_cyx;
		
		private string _DL_ax;
		
		private string _RR_sph;
		
		private string _RR_cyx;
		
		private string _RR_ax;
		
		private string _RL_sph;
		
		private string _RL_cyx;
		
		private string _RL_ax;
		
		private string _D_IPD;
		
		private string _R_IPD;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OndoctornameChanging(string value);
    partial void OndoctornameChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void OnobservationsChanging(string value);
    partial void OnobservationsChanged();
    partial void OnteleChanging(string value);
    partial void OnteleChanged();
    partial void Onlensec_IdChanging(string value);
    partial void Onlensec_IdChanged();
    partial void OnDR_sphChanging(string value);
    partial void OnDR_sphChanged();
    partial void OnDR_cyxChanging(string value);
    partial void OnDR_cyxChanged();
    partial void OnDR_axChanging(string value);
    partial void OnDR_axChanged();
    partial void OnDL_sphChanging(string value);
    partial void OnDL_sphChanged();
    partial void OnDL_cyxChanging(string value);
    partial void OnDL_cyxChanged();
    partial void OnDL_axChanging(string value);
    partial void OnDL_axChanged();
    partial void OnRR_sphChanging(string value);
    partial void OnRR_sphChanged();
    partial void OnRR_cyxChanging(string value);
    partial void OnRR_cyxChanged();
    partial void OnRR_axChanging(string value);
    partial void OnRR_axChanged();
    partial void OnRL_sphChanging(string value);
    partial void OnRL_sphChanged();
    partial void OnRL_cyxChanging(string value);
    partial void OnRL_cyxChanged();
    partial void OnRL_axChanging(string value);
    partial void OnRL_axChanged();
    partial void OnD_IPDChanging(string value);
    partial void OnD_IPDChanged();
    partial void OnR_IPDChanging(string value);
    partial void OnR_IPDChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doctorname", DbType="NVarChar(200)")]
		public string doctorname
		{
			get
			{
				return this._doctorname;
			}
			set
			{
				if ((this._doctorname != value))
				{
					this.OndoctornameChanging(value);
					this.SendPropertyChanging();
					this._doctorname = value;
					this.SendPropertyChanged("doctorname");
					this.OndoctornameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_observations", DbType="NVarChar(MAX)")]
		public string observations
		{
			get
			{
				return this._observations;
			}
			set
			{
				if ((this._observations != value))
				{
					this.OnobservationsChanging(value);
					this.SendPropertyChanging();
					this._observations = value;
					this.SendPropertyChanged("observations");
					this.OnobservationsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tele", DbType="NVarChar(50)")]
		public string tele
		{
			get
			{
				return this._tele;
			}
			set
			{
				if ((this._tele != value))
				{
					this.OnteleChanging(value);
					this.SendPropertyChanging();
					this._tele = value;
					this.SendPropertyChanged("tele");
					this.OnteleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lensec_Id", DbType="NVarChar(50)")]
		public string lensec_Id
		{
			get
			{
				return this._lensec_Id;
			}
			set
			{
				if ((this._lensec_Id != value))
				{
					this.Onlensec_IdChanging(value);
					this.SendPropertyChanging();
					this._lensec_Id = value;
					this.SendPropertyChanged("lensec_Id");
					this.Onlensec_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DR_sph", DbType="NVarChar(10)")]
		public string DR_sph
		{
			get
			{
				return this._DR_sph;
			}
			set
			{
				if ((this._DR_sph != value))
				{
					this.OnDR_sphChanging(value);
					this.SendPropertyChanging();
					this._DR_sph = value;
					this.SendPropertyChanged("DR_sph");
					this.OnDR_sphChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DR_cyx", DbType="NVarChar(10)")]
		public string DR_cyx
		{
			get
			{
				return this._DR_cyx;
			}
			set
			{
				if ((this._DR_cyx != value))
				{
					this.OnDR_cyxChanging(value);
					this.SendPropertyChanging();
					this._DR_cyx = value;
					this.SendPropertyChanged("DR_cyx");
					this.OnDR_cyxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DR_ax", DbType="NVarChar(10)")]
		public string DR_ax
		{
			get
			{
				return this._DR_ax;
			}
			set
			{
				if ((this._DR_ax != value))
				{
					this.OnDR_axChanging(value);
					this.SendPropertyChanging();
					this._DR_ax = value;
					this.SendPropertyChanged("DR_ax");
					this.OnDR_axChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DL_sph", DbType="NVarChar(10)")]
		public string DL_sph
		{
			get
			{
				return this._DL_sph;
			}
			set
			{
				if ((this._DL_sph != value))
				{
					this.OnDL_sphChanging(value);
					this.SendPropertyChanging();
					this._DL_sph = value;
					this.SendPropertyChanged("DL_sph");
					this.OnDL_sphChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DL_cyx", DbType="NVarChar(10)")]
		public string DL_cyx
		{
			get
			{
				return this._DL_cyx;
			}
			set
			{
				if ((this._DL_cyx != value))
				{
					this.OnDL_cyxChanging(value);
					this.SendPropertyChanging();
					this._DL_cyx = value;
					this.SendPropertyChanged("DL_cyx");
					this.OnDL_cyxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DL_ax", DbType="NVarChar(10)")]
		public string DL_ax
		{
			get
			{
				return this._DL_ax;
			}
			set
			{
				if ((this._DL_ax != value))
				{
					this.OnDL_axChanging(value);
					this.SendPropertyChanging();
					this._DL_ax = value;
					this.SendPropertyChanged("DL_ax");
					this.OnDL_axChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RR_sph", DbType="NVarChar(10)")]
		public string RR_sph
		{
			get
			{
				return this._RR_sph;
			}
			set
			{
				if ((this._RR_sph != value))
				{
					this.OnRR_sphChanging(value);
					this.SendPropertyChanging();
					this._RR_sph = value;
					this.SendPropertyChanged("RR_sph");
					this.OnRR_sphChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RR_cyx", DbType="NVarChar(10)")]
		public string RR_cyx
		{
			get
			{
				return this._RR_cyx;
			}
			set
			{
				if ((this._RR_cyx != value))
				{
					this.OnRR_cyxChanging(value);
					this.SendPropertyChanging();
					this._RR_cyx = value;
					this.SendPropertyChanged("RR_cyx");
					this.OnRR_cyxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RR_ax", DbType="NVarChar(10)")]
		public string RR_ax
		{
			get
			{
				return this._RR_ax;
			}
			set
			{
				if ((this._RR_ax != value))
				{
					this.OnRR_axChanging(value);
					this.SendPropertyChanging();
					this._RR_ax = value;
					this.SendPropertyChanged("RR_ax");
					this.OnRR_axChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RL_sph", DbType="NVarChar(10)")]
		public string RL_sph
		{
			get
			{
				return this._RL_sph;
			}
			set
			{
				if ((this._RL_sph != value))
				{
					this.OnRL_sphChanging(value);
					this.SendPropertyChanging();
					this._RL_sph = value;
					this.SendPropertyChanged("RL_sph");
					this.OnRL_sphChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RL_cyx", DbType="NVarChar(10)")]
		public string RL_cyx
		{
			get
			{
				return this._RL_cyx;
			}
			set
			{
				if ((this._RL_cyx != value))
				{
					this.OnRL_cyxChanging(value);
					this.SendPropertyChanging();
					this._RL_cyx = value;
					this.SendPropertyChanged("RL_cyx");
					this.OnRL_cyxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RL_ax", DbType="NVarChar(10)")]
		public string RL_ax
		{
			get
			{
				return this._RL_ax;
			}
			set
			{
				if ((this._RL_ax != value))
				{
					this.OnRL_axChanging(value);
					this.SendPropertyChanging();
					this._RL_ax = value;
					this.SendPropertyChanged("RL_ax");
					this.OnRL_axChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_IPD", DbType="NVarChar(10)")]
		public string D_IPD
		{
			get
			{
				return this._D_IPD;
			}
			set
			{
				if ((this._D_IPD != value))
				{
					this.OnD_IPDChanging(value);
					this.SendPropertyChanging();
					this._D_IPD = value;
					this.SendPropertyChanged("D_IPD");
					this.OnD_IPDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_R_IPD", DbType="NVarChar(10)")]
		public string R_IPD
		{
			get
			{
				return this._R_IPD;
			}
			set
			{
				if ((this._R_IPD != value))
				{
					this.OnR_IPDChanging(value);
					this.SendPropertyChanging();
					this._R_IPD = value;
					this.SendPropertyChanged("R_IPD");
					this.OnR_IPDChanged();
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
}
#pragma warning restore 1591