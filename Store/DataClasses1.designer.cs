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

namespace Store
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="c_store")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertaccount(account instance);
    partial void Updateaccount(account instance);
    partial void Deleteaccount(account instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void Insertinvoice(invoice instance);
    partial void Updateinvoice(invoice instance);
    partial void Deleteinvoice(invoice instance);
    partial void Insertinvoice_item(invoice_item instance);
    partial void Updateinvoice_item(invoice_item instance);
    partial void Deleteinvoice_item(invoice_item instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertcartItem(cartItem instance);
    partial void UpdatecartItem(cartItem instance);
    partial void DeletecartItem(cartItem instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Store.Properties.Settings.Default.c_storeConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<account> accounts
		{
			get
			{
				return this.GetTable<account>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<invoice> invoices
		{
			get
			{
				return this.GetTable<invoice>();
			}
		}
		
		public System.Data.Linq.Table<invoice_item> invoice_items
		{
			get
			{
				return this.GetTable<invoice_item>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<cartItem> cartItems
		{
			get
			{
				return this.GetTable<cartItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.account")]
	public partial class account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccountID;
		
		private decimal _Balance;
		
		private string _Username;
		
		private string _CustPassword;
		
		private System.Nullable<int> _custId;
		
		private EntitySet<Customer> _Customers;
		
		private EntitySet<invoice> _invoices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccountIDChanging(int value);
    partial void OnAccountIDChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnCustPasswordChanging(string value);
    partial void OnCustPasswordChanged();
    partial void OncustIdChanging(System.Nullable<int> value);
    partial void OncustIdChanged();
    #endregion
		
		public account()
		{
			this._Customers = new EntitySet<Customer>(new Action<Customer>(this.attach_Customers), new Action<Customer>(this.detach_Customers));
			this._invoices = new EntitySet<invoice>(new Action<invoice>(this.attach_invoices), new Action<invoice>(this.detach_invoices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this.OnAccountIDChanging(value);
					this.SendPropertyChanging();
					this._AccountID = value;
					this.SendPropertyChanged("AccountID");
					this.OnAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(5,2) NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustPassword", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string CustPassword
		{
			get
			{
				return this._CustPassword;
			}
			set
			{
				if ((this._CustPassword != value))
				{
					this.OnCustPasswordChanging(value);
					this.SendPropertyChanging();
					this._CustPassword = value;
					this.SendPropertyChanged("CustPassword");
					this.OnCustPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_custId", DbType="Int")]
		public System.Nullable<int> custId
		{
			get
			{
				return this._custId;
			}
			set
			{
				if ((this._custId != value))
				{
					this.OncustIdChanging(value);
					this.SendPropertyChanging();
					this._custId = value;
					this.SendPropertyChanged("custId");
					this.OncustIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="account_Customer", Storage="_Customers", ThisKey="AccountID", OtherKey="AccountId")]
		public EntitySet<Customer> Customers
		{
			get
			{
				return this._Customers;
			}
			set
			{
				this._Customers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="account_invoice", Storage="_invoices", ThisKey="AccountID", OtherKey="accountID")]
		public EntitySet<invoice> invoices
		{
			get
			{
				return this._invoices;
			}
			set
			{
				this._invoices.Assign(value);
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
		
		private void attach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.account = this;
		}
		
		private void detach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.account = null;
		}
		
		private void attach_invoices(invoice entity)
		{
			this.SendPropertyChanging();
			entity.account = this;
		}
		
		private void detach_invoices(invoice entity)
		{
			this.SendPropertyChanging();
			entity.account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CId;
		
		private string _Fname;
		
		private string _Lname;
		
		private string _Phone;
		
		private string _Street;
		
		private string _City;
		
		private string _CState;
		
		private string _Zip;
		
		private int _AccountId;
		
		private EntityRef<account> _account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCIdChanging(int value);
    partial void OnCIdChanged();
    partial void OnFnameChanging(string value);
    partial void OnFnameChanged();
    partial void OnLnameChanging(string value);
    partial void OnLnameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCStateChanging(string value);
    partial void OnCStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnAccountIdChanging(int value);
    partial void OnAccountIdChanged();
    #endregion
		
		public Customer()
		{
			this._account = default(EntityRef<account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CId
		{
			get
			{
				return this._CId;
			}
			set
			{
				if ((this._CId != value))
				{
					this.OnCIdChanging(value);
					this.SendPropertyChanging();
					this._CId = value;
					this.SendPropertyChanged("CId");
					this.OnCIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fname", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Fname
		{
			get
			{
				return this._Fname;
			}
			set
			{
				if ((this._Fname != value))
				{
					this.OnFnameChanging(value);
					this.SendPropertyChanging();
					this._Fname = value;
					this.SendPropertyChanged("Fname");
					this.OnFnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lname", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Lname
		{
			get
			{
				return this._Lname;
			}
			set
			{
				if ((this._Lname != value))
				{
					this.OnLnameChanging(value);
					this.SendPropertyChanging();
					this._Lname = value;
					this.SendPropertyChanged("Lname");
					this.OnLnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CState", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string CState
		{
			get
			{
				return this._CState;
			}
			set
			{
				if ((this._CState != value))
				{
					this.OnCStateChanging(value);
					this.SendPropertyChanging();
					this._CState = value;
					this.SendPropertyChanged("CState");
					this.OnCStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountId", DbType="Int NOT NULL")]
		public int AccountId
		{
			get
			{
				return this._AccountId;
			}
			set
			{
				if ((this._AccountId != value))
				{
					if (this._account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountIdChanging(value);
					this.SendPropertyChanging();
					this._AccountId = value;
					this.SendPropertyChanged("AccountId");
					this.OnAccountIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="account_Customer", Storage="_account", ThisKey="AccountId", OtherKey="AccountID", IsForeignKey=true)]
		public account account
		{
			get
			{
				return this._account.Entity;
			}
			set
			{
				account previousValue = this._account.Entity;
				if (((previousValue != value) 
							|| (this._account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._account.Entity = null;
						previousValue.Customers.Remove(this);
					}
					this._account.Entity = value;
					if ((value != null))
					{
						value.Customers.Add(this);
						this._AccountId = value.AccountID;
					}
					else
					{
						this._AccountId = default(int);
					}
					this.SendPropertyChanged("account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.invoice")]
	public partial class invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _invoiceID;
		
		private decimal _totalPrice;
		
		private int _accountID;
		
		private System.DateTime _dateOrdered;
		
		private EntitySet<invoice_item> _invoice_items;
		
		private EntityRef<account> _account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninvoiceIDChanging(int value);
    partial void OninvoiceIDChanged();
    partial void OntotalPriceChanging(decimal value);
    partial void OntotalPriceChanged();
    partial void OnaccountIDChanging(int value);
    partial void OnaccountIDChanged();
    partial void OndateOrderedChanging(System.DateTime value);
    partial void OndateOrderedChanged();
    #endregion
		
		public invoice()
		{
			this._invoice_items = new EntitySet<invoice_item>(new Action<invoice_item>(this.attach_invoice_items), new Action<invoice_item>(this.detach_invoice_items));
			this._account = default(EntityRef<account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int invoiceID
		{
			get
			{
				return this._invoiceID;
			}
			set
			{
				if ((this._invoiceID != value))
				{
					this.OninvoiceIDChanging(value);
					this.SendPropertyChanging();
					this._invoiceID = value;
					this.SendPropertyChanged("invoiceID");
					this.OninvoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalPrice", DbType="Decimal(5,2) NOT NULL")]
		public decimal totalPrice
		{
			get
			{
				return this._totalPrice;
			}
			set
			{
				if ((this._totalPrice != value))
				{
					this.OntotalPriceChanging(value);
					this.SendPropertyChanging();
					this._totalPrice = value;
					this.SendPropertyChanged("totalPrice");
					this.OntotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accountID", DbType="Int NOT NULL")]
		public int accountID
		{
			get
			{
				return this._accountID;
			}
			set
			{
				if ((this._accountID != value))
				{
					if (this._account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnaccountIDChanging(value);
					this.SendPropertyChanging();
					this._accountID = value;
					this.SendPropertyChanged("accountID");
					this.OnaccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateOrdered", DbType="Date NOT NULL")]
		public System.DateTime dateOrdered
		{
			get
			{
				return this._dateOrdered;
			}
			set
			{
				if ((this._dateOrdered != value))
				{
					this.OndateOrderedChanging(value);
					this.SendPropertyChanging();
					this._dateOrdered = value;
					this.SendPropertyChanged("dateOrdered");
					this.OndateOrderedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="invoice_invoice_item", Storage="_invoice_items", ThisKey="invoiceID", OtherKey="invoiceID")]
		public EntitySet<invoice_item> invoice_items
		{
			get
			{
				return this._invoice_items;
			}
			set
			{
				this._invoice_items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="account_invoice", Storage="_account", ThisKey="accountID", OtherKey="AccountID", IsForeignKey=true)]
		public account account
		{
			get
			{
				return this._account.Entity;
			}
			set
			{
				account previousValue = this._account.Entity;
				if (((previousValue != value) 
							|| (this._account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._account.Entity = null;
						previousValue.invoices.Remove(this);
					}
					this._account.Entity = value;
					if ((value != null))
					{
						value.invoices.Add(this);
						this._accountID = value.AccountID;
					}
					else
					{
						this._accountID = default(int);
					}
					this.SendPropertyChanged("account");
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
		
		private void attach_invoice_items(invoice_item entity)
		{
			this.SendPropertyChanging();
			entity.invoice = this;
		}
		
		private void detach_invoice_items(invoice_item entity)
		{
			this.SendPropertyChanging();
			entity.invoice = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.invoice_item")]
	public partial class invoice_item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _invoiceID;
		
		private string _productID;
		
		private int _quantityOrdered;
		
		private decimal _price;
		
		private EntityRef<invoice> _invoice;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninvoiceIDChanging(int value);
    partial void OninvoiceIDChanged();
    partial void OnproductIDChanging(string value);
    partial void OnproductIDChanged();
    partial void OnquantityOrderedChanging(int value);
    partial void OnquantityOrderedChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public invoice_item()
		{
			this._invoice = default(EntityRef<invoice>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int invoiceID
		{
			get
			{
				return this._invoiceID;
			}
			set
			{
				if ((this._invoiceID != value))
				{
					if (this._invoice.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninvoiceIDChanging(value);
					this.SendPropertyChanging();
					this._invoiceID = value;
					this.SendPropertyChanged("invoiceID");
					this.OninvoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="VarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantityOrdered", DbType="Int NOT NULL")]
		public int quantityOrdered
		{
			get
			{
				return this._quantityOrdered;
			}
			set
			{
				if ((this._quantityOrdered != value))
				{
					this.OnquantityOrderedChanging(value);
					this.SendPropertyChanging();
					this._quantityOrdered = value;
					this.SendPropertyChanged("quantityOrdered");
					this.OnquantityOrderedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(5,2) NOT NULL")]
		public decimal price
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="invoice_invoice_item", Storage="_invoice", ThisKey="invoiceID", OtherKey="invoiceID", IsForeignKey=true)]
		public invoice invoice
		{
			get
			{
				return this._invoice.Entity;
			}
			set
			{
				invoice previousValue = this._invoice.Entity;
				if (((previousValue != value) 
							|| (this._invoice.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._invoice.Entity = null;
						previousValue.invoice_items.Remove(this);
					}
					this._invoice.Entity = value;
					if ((value != null))
					{
						value.invoice_items.Add(this);
						this._invoiceID = value.invoiceID;
					}
					else
					{
						this._invoiceID = default(int);
					}
					this.SendPropertyChanged("invoice");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_invoice_item", Storage="_Product", ThisKey="productID", OtherKey="Pcode", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.invoice_items.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.invoice_items.Add(this);
						this._productID = value.Pcode;
					}
					else
					{
						this._productID = default(string);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Pcode;
		
		private string _description;
		
		private int _quantity;
		
		private decimal _price;
		
		private EntitySet<invoice_item> _invoice_items;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPcodeChanging(string value);
    partial void OnPcodeChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public Product()
		{
			this._invoice_items = new EntitySet<invoice_item>(new Action<invoice_item>(this.attach_invoice_items), new Action<invoice_item>(this.detach_invoice_items));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pcode", DbType="VarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Pcode
		{
			get
			{
				return this._Pcode;
			}
			set
			{
				if ((this._Pcode != value))
				{
					this.OnPcodeChanging(value);
					this.SendPropertyChanging();
					this._Pcode = value;
					this.SendPropertyChanged("Pcode");
					this.OnPcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(4,2) NOT NULL")]
		public decimal price
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_invoice_item", Storage="_invoice_items", ThisKey="Pcode", OtherKey="productID")]
		public EntitySet<invoice_item> invoice_items
		{
			get
			{
				return this._invoice_items;
			}
			set
			{
				this._invoice_items.Assign(value);
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
		
		private void attach_invoice_items(invoice_item entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_invoice_items(invoice_item entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cartItems")]
	public partial class cartItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Pcode;
		
		private string _description;
		
		private decimal _price;
		
		private int _quant_ordered;
		
		private int _cartItemId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPcodeChanging(string value);
    partial void OnPcodeChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void Onquant_orderedChanging(int value);
    partial void Onquant_orderedChanged();
    partial void OncartItemIdChanging(int value);
    partial void OncartItemIdChanged();
    #endregion
		
		public cartItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pcode", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Pcode
		{
			get
			{
				return this._Pcode;
			}
			set
			{
				if ((this._Pcode != value))
				{
					this.OnPcodeChanging(value);
					this.SendPropertyChanging();
					this._Pcode = value;
					this.SendPropertyChanged("Pcode");
					this.OnPcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(8,2) NOT NULL")]
		public decimal price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quant_ordered", DbType="Int NOT NULL")]
		public int quant_ordered
		{
			get
			{
				return this._quant_ordered;
			}
			set
			{
				if ((this._quant_ordered != value))
				{
					this.Onquant_orderedChanging(value);
					this.SendPropertyChanging();
					this._quant_ordered = value;
					this.SendPropertyChanged("quant_ordered");
					this.Onquant_orderedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cartItemId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cartItemId
		{
			get
			{
				return this._cartItemId;
			}
			set
			{
				if ((this._cartItemId != value))
				{
					this.OncartItemIdChanging(value);
					this.SendPropertyChanging();
					this._cartItemId = value;
					this.SendPropertyChanged("cartItemId");
					this.OncartItemIdChanged();
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
