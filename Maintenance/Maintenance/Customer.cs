using System;

namespace Maintenance
{
	public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			set
			{
				if (value.Length <= 30)
				{
					this.firstName = value;
				}
				else
				{
					throw new ArgumentException("Length must be at most 30 characters");
				}
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				if (value.Length <= 30)
				{
					this.lastName = value;
				}
				else
				{
					throw new ArgumentException("Length must be at most 30 characters");
				}
			}
		}

		public string Email
		{
			get
			{
				return this.email;
			}
			set
			{
				if (value.Length <= 30)
				{
					this.email = value;
				}
				else
				{
					throw new ArgumentException("Length must be at most 30 characters");
				}
			}
		}

		public virtual string GetDisplayText()
		{
			return this.firstName + " " + this.lastName + ", " + this.email;
		}
	}
}
