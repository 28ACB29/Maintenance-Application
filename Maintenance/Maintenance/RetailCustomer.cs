using System;

namespace Maintenance
{
	class RetailCustomer : Customer
	{
		private string homePhone;

		public string HomePhone
		{
			get
			{
				return this.homePhone;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException("Maximum length of first name is 50 characters.");
				}
				this.homePhone = value;
			}
		}

		public RetailCustomer()
			: base()
		{
			this.HomePhone = "";
		}

		public RetailCustomer(string firstName, string lastName, string email, string Company)
			: base(firstName, lastName, email)
		{
			this.HomePhone = Company;
		}

		public override string GetDisplayText()
		{
			return base.FirstName + " " + base.LastName + ", " + base.Email + " ph: " + this.HomePhone;
		}
	}
}
