using System;
using System.Collections.Generic;

namespace Maintenance
{
	public class CustomerList
	{
		private List<Customer> customers;

		public int Count
		{
			get
			{
				return this.customers.Count;
			}
		}

		public delegate void ChangeHandler(CustomerList customers);

		public event ChangeHandler Changed;

		public CustomerList()
		{
			this.customers = new List<Customer>();
		}

		public CustomerList(List<Customer> customers)
		{
			this.customers = new List<Customer>(customers);
		}

		public CustomerList(CustomerList customerList)
		{
			this.customers = new List<Customer>(customerList.customers);
		}

		public Customer this[int index]
		{
			get
			{
				if (index > -1 && index < this.customers.Count)
				{
					return this.customers[index];
				}
				else
				{
					throw new ArgumentOutOfRangeException(index.ToString());
				}
			}
			set
			{
				if (index > -1 && index < this.customers.Count)
				{
					this.customers[index] = value;
					this.Changed(this);
				}
				else
				{
					throw new ArgumentOutOfRangeException(index.ToString());
				}
			}
		}

		public static CustomerList operator +(CustomerList customerList, Customer customer)
		{
			CustomerList newCustomerList = new CustomerList(customerList);
			newCustomerList.customers.Add(customer);
			newCustomerList.Changed(newCustomerList);
			return newCustomerList;
		}

		public static CustomerList operator -(CustomerList customerList, Customer customer)
		{
			CustomerList newCustomerList = new CustomerList(customerList);
			newCustomerList.customers.Remove(customer);
			newCustomerList.Changed(newCustomerList);
			return newCustomerList;
		}

		public void Add(Customer customer)
		{
			this.customers.Add(customer);
			this.Changed(this);
		}

		public void Remove(Customer customer)
		{
			this.customers.Remove(customer);
			this.Changed(this);
		}

		public void Fill()
		{
			this.customers = CustomerDB.GetCustomers();
		}

		public void Save()
		{
			CustomerDB.SaveCustomers(this.customers);
		}
	}
}
