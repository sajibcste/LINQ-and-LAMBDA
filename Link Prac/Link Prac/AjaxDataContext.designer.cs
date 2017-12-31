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

namespace Link_Prac
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AjaxDB")]
	public partial class AjaxDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Department(tbl_Department instance);
    partial void Updatetbl_Department(tbl_Department instance);
    partial void Deletetbl_Department(tbl_Department instance);
    partial void Inserttbl_Grade(tbl_Grade instance);
    partial void Updatetbl_Grade(tbl_Grade instance);
    partial void Deletetbl_Grade(tbl_Grade instance);
    partial void Inserttbl_Employee(tbl_Employee instance);
    partial void Updatetbl_Employee(tbl_Employee instance);
    partial void Deletetbl_Employee(tbl_Employee instance);
    #endregion
		
		public AjaxDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AjaxDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AjaxDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AjaxDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AjaxDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AjaxDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Department> tbl_Departments
		{
			get
			{
				return this.GetTable<tbl_Department>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Grade> tbl_Grades
		{
			get
			{
				return this.GetTable<tbl_Grade>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Employee> tbl_Employees
		{
			get
			{
				return this.GetTable<tbl_Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Department")]
	public partial class tbl_Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<double> _Salary;
		
		private EntitySet<tbl_Employee> _tbl_Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSalaryChanging(System.Nullable<double> value);
    partial void OnSalaryChanged();
    #endregion
		
		public tbl_Department()
		{
			this._tbl_Employees = new EntitySet<tbl_Employee>(new Action<tbl_Employee>(this.attach_tbl_Employees), new Action<tbl_Employee>(this.detach_tbl_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float")]
		public System.Nullable<double> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Department_tbl_Employee", Storage="_tbl_Employees", ThisKey="Id", OtherKey="DepartmentId")]
		public EntitySet<tbl_Employee> tbl_Employees
		{
			get
			{
				return this._tbl_Employees;
			}
			set
			{
				this._tbl_Employees.Assign(value);
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
		
		private void attach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Department = this;
		}
		
		private void detach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Grade")]
	public partial class tbl_Grade : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _GradeName;
		
		private System.Nullable<double> _Bonus;
		
		private EntitySet<tbl_Employee> _tbl_Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGradeNameChanging(string value);
    partial void OnGradeNameChanged();
    partial void OnBonusChanging(System.Nullable<double> value);
    partial void OnBonusChanged();
    #endregion
		
		public tbl_Grade()
		{
			this._tbl_Employees = new EntitySet<tbl_Employee>(new Action<tbl_Employee>(this.attach_tbl_Employees), new Action<tbl_Employee>(this.detach_tbl_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GradeName", DbType="VarChar(50)")]
		public string GradeName
		{
			get
			{
				return this._GradeName;
			}
			set
			{
				if ((this._GradeName != value))
				{
					this.OnGradeNameChanging(value);
					this.SendPropertyChanging();
					this._GradeName = value;
					this.SendPropertyChanged("GradeName");
					this.OnGradeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Float")]
		public System.Nullable<double> Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Grade_tbl_Employee", Storage="_tbl_Employees", ThisKey="Id", OtherKey="GradeId")]
		public EntitySet<tbl_Employee> tbl_Employees
		{
			get
			{
				return this._tbl_Employees;
			}
			set
			{
				this._tbl_Employees.Assign(value);
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
		
		private void attach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Grade = this;
		}
		
		private void detach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Grade = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Employee")]
	public partial class tbl_Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Name;
		
		private string _Gender;
		
		private System.Nullable<int> _DepartmentId;
		
		private System.Nullable<int> _GradeId;
		
		private string _Address;
		
		private EntityRef<tbl_Department> _tbl_Department;
		
		private EntityRef<tbl_Grade> _tbl_Grade;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDepartmentIdChanging(System.Nullable<int> value);
    partial void OnDepartmentIdChanged();
    partial void OnGradeIdChanging(System.Nullable<int> value);
    partial void OnGradeIdChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public tbl_Employee()
		{
			this._tbl_Department = default(EntityRef<tbl_Department>);
			this._tbl_Grade = default(EntityRef<tbl_Grade>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
		public System.Nullable<int> DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					if (this._tbl_Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GradeId", DbType="Int")]
		public System.Nullable<int> GradeId
		{
			get
			{
				return this._GradeId;
			}
			set
			{
				if ((this._GradeId != value))
				{
					if (this._tbl_Grade.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGradeIdChanging(value);
					this.SendPropertyChanging();
					this._GradeId = value;
					this.SendPropertyChanged("GradeId");
					this.OnGradeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(200)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Department_tbl_Employee", Storage="_tbl_Department", ThisKey="DepartmentId", OtherKey="Id", IsForeignKey=true)]
		public tbl_Department tbl_Department
		{
			get
			{
				return this._tbl_Department.Entity;
			}
			set
			{
				tbl_Department previousValue = this._tbl_Department.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Department.Entity = null;
						previousValue.tbl_Employees.Remove(this);
					}
					this._tbl_Department.Entity = value;
					if ((value != null))
					{
						value.tbl_Employees.Add(this);
						this._DepartmentId = value.Id;
					}
					else
					{
						this._DepartmentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_Department");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Grade_tbl_Employee", Storage="_tbl_Grade", ThisKey="GradeId", OtherKey="Id", IsForeignKey=true)]
		public tbl_Grade tbl_Grade
		{
			get
			{
				return this._tbl_Grade.Entity;
			}
			set
			{
				tbl_Grade previousValue = this._tbl_Grade.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Grade.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Grade.Entity = null;
						previousValue.tbl_Employees.Remove(this);
					}
					this._tbl_Grade.Entity = value;
					if ((value != null))
					{
						value.tbl_Employees.Add(this);
						this._GradeId = value.Id;
					}
					else
					{
						this._GradeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_Grade");
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
