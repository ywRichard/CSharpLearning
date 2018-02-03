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

namespace Chapter12_LinqToOther
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SkeetysoftDefects")]
	public partial class DefectModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDefect(Defect instance);
    partial void UpdateDefect(Defect instance);
    partial void DeleteDefect(Defect instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertNotificationSubscription(NotificationSubscription instance);
    partial void UpdateNotificationSubscription(NotificationSubscription instance);
    partial void DeleteNotificationSubscription(NotificationSubscription instance);
    partial void InsertProject(Project instance);
    partial void UpdateProject(Project instance);
    partial void DeleteProject(Project instance);
    #endregion
		
		public DefectModelDataContext() : 
				base(global::Chapter12_LinqToOther.Properties.Settings.Default.SkeetysoftDefectsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Defect> Defects
		{
			get
			{
				return this.GetTable<Defect>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<NotificationSubscription> NotificationSubscriptions
		{
			get
			{
				return this.GetTable<NotificationSubscription>();
			}
		}
		
		public System.Data.Linq.Table<Project> Projects
		{
			get
			{
				return this.GetTable<Project>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Defect")]
	public partial class Defect : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Created;
		
		private System.DateTime _LastModified;
		
		private string _Summary;
		
		private Severity _Severity;
		
		private Status _Status;
		
		private System.Nullable<int> _AssignedToUserID;
		
		private int _CreatedByUserID;
		
		private int _ProjectID;
		
		private EntityRef<User> _AssignedTo;
		
		private EntityRef<User> _CreatedBy;
		
		private EntityRef<Project> _Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnLastModifiedChanging(System.DateTime value);
    partial void OnLastModifiedChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnSeverityChanging(Severity value);
    partial void OnSeverityChanged();
    partial void OnStatusChanging(Status value);
    partial void OnStatusChanged();
    partial void OnAssignedToUserIDChanging(System.Nullable<int> value);
    partial void OnAssignedToUserIDChanged();
    partial void OnCreatedByUserIDChanging(int value);
    partial void OnCreatedByUserIDChanged();
    partial void OnProjectIDChanging(int value);
    partial void OnProjectIDChanged();
    #endregion
		
		public Defect()
		{
			this._AssignedTo = default(EntityRef<User>);
			this._CreatedBy = default(EntityRef<User>);
			this._Project = default(EntityRef<Project>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DefectID", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModified", DbType="DateTime NOT NULL")]
		public System.DateTime LastModified
		{
			get
			{
				return this._LastModified;
			}
			set
			{
				if ((this._LastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._LastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summary", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Severity", DbType="TinyInt NOT NULL", CanBeNull=false)]
		public Severity Severity
		{
			get
			{
				return this._Severity;
			}
			set
			{
				if ((this._Severity != value))
				{
					this.OnSeverityChanging(value);
					this.SendPropertyChanging();
					this._Severity = value;
					this.SendPropertyChanged("Severity");
					this.OnSeverityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt NOT NULL", CanBeNull=false)]
		public Status Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignedToUserID", DbType="Int")]
		public System.Nullable<int> AssignedToUserID
		{
			get
			{
				return this._AssignedToUserID;
			}
			set
			{
				if ((this._AssignedToUserID != value))
				{
					if (this._AssignedTo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAssignedToUserIDChanging(value);
					this.SendPropertyChanging();
					this._AssignedToUserID = value;
					this.SendPropertyChanged("AssignedToUserID");
					this.OnAssignedToUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedByUserID", DbType="Int NOT NULL")]
		public int CreatedByUserID
		{
			get
			{
				return this._CreatedByUserID;
			}
			set
			{
				if ((this._CreatedByUserID != value))
				{
					if (this._CreatedBy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCreatedByUserIDChanging(value);
					this.SendPropertyChanging();
					this._CreatedByUserID = value;
					this.SendPropertyChanged("CreatedByUserID");
					this.OnCreatedByUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIDChanging(value);
					this.SendPropertyChanging();
					this._ProjectID = value;
					this.SendPropertyChanged("ProjectID");
					this.OnProjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DefectUser_Defect", Storage="_AssignedTo", ThisKey="AssignedToUserID", OtherKey="UserID", IsForeignKey=true)]
		public User AssignedTo
		{
			get
			{
				return this._AssignedTo.Entity;
			}
			set
			{
				User previousValue = this._AssignedTo.Entity;
				if (((previousValue != value) 
							|| (this._AssignedTo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AssignedTo.Entity = null;
						previousValue.AssignedDefects.Remove(this);
					}
					this._AssignedTo.Entity = value;
					if ((value != null))
					{
						value.AssignedDefects.Add(this);
						this._AssignedToUserID = value.UserID;
					}
					else
					{
						this._AssignedToUserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("AssignedTo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DefectUser_Defect1", Storage="_CreatedBy", ThisKey="CreatedByUserID", OtherKey="UserID", IsForeignKey=true)]
		public User CreatedBy
		{
			get
			{
				return this._CreatedBy.Entity;
			}
			set
			{
				User previousValue = this._CreatedBy.Entity;
				if (((previousValue != value) 
							|| (this._CreatedBy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CreatedBy.Entity = null;
						previousValue.CreatedDefects.Remove(this);
					}
					this._CreatedBy.Entity = value;
					if ((value != null))
					{
						value.CreatedDefects.Add(this);
						this._CreatedByUserID = value.UserID;
					}
					else
					{
						this._CreatedByUserID = default(int);
					}
					this.SendPropertyChanged("CreatedBy");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Defect", Storage="_Project", ThisKey="ProjectID", OtherKey="ProjectID", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.Defects.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.Defects.Add(this);
						this._ProjectID = value.ProjectID;
					}
					else
					{
						this._ProjectID = default(int);
					}
					this.SendPropertyChanged("Project");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DefectUser")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Name;
		
		private UserType _UserType;
		
		private EntitySet<Defect> _AssignedDefects;
		
		private EntitySet<Defect> _CreatedDefects;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserTypeChanging(UserType value);
    partial void OnUserTypeChanged();
    #endregion
		
		public User()
		{
			this._AssignedDefects = new EntitySet<Defect>(new Action<Defect>(this.attach_AssignedDefects), new Action<Defect>(this.detach_AssignedDefects));
			this._CreatedDefects = new EntitySet<Defect>(new Action<Defect>(this.attach_CreatedDefects), new Action<Defect>(this.detach_CreatedDefects));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="TinyInt NOT NULL", CanBeNull=false)]
		public UserType UserType
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DefectUser_Defect", Storage="_AssignedDefects", ThisKey="UserID", OtherKey="AssignedToUserID")]
		public EntitySet<Defect> AssignedDefects
		{
			get
			{
				return this._AssignedDefects;
			}
			set
			{
				this._AssignedDefects.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DefectUser_Defect1", Storage="_CreatedDefects", ThisKey="UserID", OtherKey="CreatedByUserID")]
		public EntitySet<Defect> CreatedDefects
		{
			get
			{
				return this._CreatedDefects;
			}
			set
			{
				this._CreatedDefects.Assign(value);
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
		
		private void attach_AssignedDefects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.AssignedTo = this;
		}
		
		private void detach_AssignedDefects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.AssignedTo = null;
		}
		
		private void attach_CreatedDefects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.CreatedBy = this;
		}
		
		private void detach_CreatedDefects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.CreatedBy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NotificationSubscription")]
	public partial class NotificationSubscription : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NotificationSubscriptionID;
		
		private int _ProjectID;
		
		private string _EmailAddress;
		
		private EntityRef<Project> _Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNotificationSubscriptionIDChanging(int value);
    partial void OnNotificationSubscriptionIDChanged();
    partial void OnProjectIDChanging(int value);
    partial void OnProjectIDChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    #endregion
		
		public NotificationSubscription()
		{
			this._Project = default(EntityRef<Project>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotificationSubscriptionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NotificationSubscriptionID
		{
			get
			{
				return this._NotificationSubscriptionID;
			}
			set
			{
				if ((this._NotificationSubscriptionID != value))
				{
					this.OnNotificationSubscriptionIDChanging(value);
					this.SendPropertyChanging();
					this._NotificationSubscriptionID = value;
					this.SendPropertyChanged("NotificationSubscriptionID");
					this.OnNotificationSubscriptionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIDChanging(value);
					this.SendPropertyChanging();
					this._ProjectID = value;
					this.SendPropertyChanged("ProjectID");
					this.OnProjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_NotificationSubscription", Storage="_Project", ThisKey="ProjectID", OtherKey="ProjectID", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.NotificationSubscriptions.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.NotificationSubscriptions.Add(this);
						this._ProjectID = value.ProjectID;
					}
					else
					{
						this._ProjectID = default(int);
					}
					this.SendPropertyChanged("Project");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Project")]
	public partial class Project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProjectID;
		
		private string _Name;
		
		private EntitySet<Defect> _Defects;
		
		private EntitySet<NotificationSubscription> _NotificationSubscriptions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProjectIDChanging(int value);
    partial void OnProjectIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Project()
		{
			this._Defects = new EntitySet<Defect>(new Action<Defect>(this.attach_Defects), new Action<Defect>(this.detach_Defects));
			this._NotificationSubscriptions = new EntitySet<NotificationSubscription>(new Action<NotificationSubscription>(this.attach_NotificationSubscriptions), new Action<NotificationSubscription>(this.detach_NotificationSubscriptions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this.OnProjectIDChanging(value);
					this.SendPropertyChanging();
					this._ProjectID = value;
					this.SendPropertyChanged("ProjectID");
					this.OnProjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Defect", Storage="_Defects", ThisKey="ProjectID", OtherKey="ProjectID")]
		public EntitySet<Defect> Defects
		{
			get
			{
				return this._Defects;
			}
			set
			{
				this._Defects.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_NotificationSubscription", Storage="_NotificationSubscriptions", ThisKey="ProjectID", OtherKey="ProjectID")]
		public EntitySet<NotificationSubscription> NotificationSubscriptions
		{
			get
			{
				return this._NotificationSubscriptions;
			}
			set
			{
				this._NotificationSubscriptions.Assign(value);
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
		
		private void attach_Defects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_Defects(Defect entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
		
		private void attach_NotificationSubscriptions(NotificationSubscription entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_NotificationSubscriptions(NotificationSubscription entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
	}
}
#pragma warning restore 1591