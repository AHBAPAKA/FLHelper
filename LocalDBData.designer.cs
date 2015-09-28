﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SvetanFlickrApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFav(Fav instance);
    partial void UpdateFav(Fav instance);
    partial void DeleteFav(Fav instance);
    partial void InsertFavsToDelete(FavsToDelete instance);
    partial void UpdateFavsToDelete(FavsToDelete instance);
    partial void DeleteFavsToDelete(FavsToDelete instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::SvetanFlickrApp.Properties.Settings.Default.FDBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Fav> Favs
		{
			get
			{
				return this.GetTable<Fav>();
			}
		}
		
		public System.Data.Linq.Table<FavsToDelete> FavsToDeletes
		{
			get
			{
				return this.GetTable<FavsToDelete>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Favs")]
	public partial class Fav : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _photoid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnphotoidChanging(string value);
    partial void OnphotoidChanged();
    #endregion
		
		public Fav()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photoid", DbType="NChar(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string photoid
		{
			get
			{
				return this._photoid;
			}
			set
			{
				if ((this._photoid != value))
				{
					this.OnphotoidChanging(value);
					this.SendPropertyChanging();
					this._photoid = value;
					this.SendPropertyChanged("photoid");
					this.OnphotoidChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FavsToDelete")]
	public partial class FavsToDelete : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _photoID;
		
		private System.DateTime _DateAdded;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnphotoIDChanging(string value);
    partial void OnphotoIDChanged();
    partial void OnDateAddedChanging(System.DateTime value);
    partial void OnDateAddedChanged();
    #endregion
		
		public FavsToDelete()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photoID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string photoID
		{
			get
			{
				return this._photoID;
			}
			set
			{
				if ((this._photoID != value))
				{
					this.OnphotoIDChanging(value);
					this.SendPropertyChanging();
					this._photoID = value;
					this.SendPropertyChanged("photoID");
					this.OnphotoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime NOT NULL")]
		public System.DateTime DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._DateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
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
