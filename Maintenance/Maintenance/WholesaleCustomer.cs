using System;

namespace Maintenance
{
	class WholesaleCustomer : Customer
	{
		private string company;

		public string Company
		{
			get
			{
				return this.company;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException("Maximum length of first name is 50 characters.");
				}
				this.company = value;
			}
		}

		public WholesaleCustomer()
			: base()
		{
			this.Company = "";
		}

		public WholesaleCustomer(string firstName, string lastName, string email, string Company)
			: base(firstName, lastName, email)
		{
			this.Company = Company;
		}

		public override string GetDisplayText()
		{
			return base.FirstName + " " + base.LastName + ", " + base.Email + " (" + this.Company + ")";
		}
	}
}
