using System.Collections.Generic;
using System.Xml;

namespace Maintenance
{
	public class CustomerDB
	{
		private const string dir = @"C:\Users\Arthur C. Baroi\Documents\C# Programming\Files\";
		private const string path = dir + "Customers.xml";

		public static List<Customer> GetCustomers()
		{
			List<Customer> customers = new List<Customer>();

			XmlReaderSettings settings = new XmlReaderSettings();
			settings.IgnoreWhitespace = true;
			settings.IgnoreComments = true;

			XmlReader xmlIn = XmlReader.Create(CustomerDB.path, settings);

			if (xmlIn.ReadToDescendant("Customer"))
			{
				do
				{
					xmlIn.ReadStartElement("Customer");
					string type = xmlIn.ReadElementContentAsString();
					switch (type)
					{
						case "":
							customers.Add(Read(xmlIn));
							break;
						case "Retail":
							customers.Add(ReadRetail(xmlIn));
							break;
						case "Wholesale":
							customers.Add(ReadWholesale(xmlIn));
							break;
						default:
							break;
					}
				}
				while (xmlIn.ReadToNextSibling("Customer"));
			}

			xmlIn.Close();
			return customers;
		}

		private static Customer Read(XmlReader xmlIn)
		{
			Customer customer = new Customer();
			customer.FirstName = xmlIn.ReadElementContentAsString();
			customer.LastName = xmlIn.ReadElementContentAsString();
			customer.Email = xmlIn.ReadElementContentAsString();
			return customer;
		}

		private static RetailCustomer ReadRetail(XmlReader xmlIn)
		{
			RetailCustomer customer = new RetailCustomer();
			customer.FirstName = xmlIn.ReadElementContentAsString();
			customer.LastName = xmlIn.ReadElementContentAsString();
			customer.Email = xmlIn.ReadElementContentAsString();
			customer.HomePhone = xmlIn.ReadElementContentAsString();
			return customer;
		}

		private static WholesaleCustomer ReadWholesale(XmlReader xmlIn)
		{
			WholesaleCustomer customer = new WholesaleCustomer();
			customer.FirstName = xmlIn.ReadElementContentAsString();
			customer.LastName = xmlIn.ReadElementContentAsString();
			customer.Email = xmlIn.ReadElementContentAsString();
			customer.Company = xmlIn.ReadElementContentAsString();
			return customer;
		}

		public static void SaveCustomers(List<Customer> customers)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.IndentChars = ("    ");

			XmlWriter xmlOut = XmlWriter.Create(CustomerDB.path, settings);

			xmlOut.WriteStartDocument();
			xmlOut.WriteStartElement("Customers");

			foreach (Customer customer in customers)
			{
				switch (customer.GetType().Name)
				{
					case "Customer":
						Write((Customer)customer, xmlOut);
						break;
					case "RetailCustomer":
						WriteRetail((RetailCustomer)customer, xmlOut);
						break;
					case "WholesaleCustomer":
						WriteWholesale((WholesaleCustomer)customer, xmlOut);
						break;
					default:
						break;
				}
			}
			xmlOut.WriteEndElement();
			xmlOut.Close();
		}

		private static void Write(Customer customer, XmlWriter xmlOut)
		{
			xmlOut.WriteStartElement("Customer");
			xmlOut.WriteElementString("Type", "");
			xmlOut.WriteElementString("FirstName", customer.FirstName);
			xmlOut.WriteElementString("LastName", customer.LastName);
			xmlOut.WriteElementString("Email", customer.Email);
			xmlOut.WriteEndElement();
		}

		private static void WriteRetail(RetailCustomer customer, XmlWriter xmlOut)
		{
			xmlOut.WriteStartElement("Customer");
			xmlOut.WriteElementString("Type", "Retail");
			xmlOut.WriteElementString("FirstName", customer.FirstName);
			xmlOut.WriteElementString("LastName", customer.LastName);
			xmlOut.WriteElementString("Email", customer.Email);
			xmlOut.WriteElementString("HomePhone", customer.HomePhone);
			xmlOut.WriteEndElement();
		}

		private static void WriteWholesale(WholesaleCustomer customer, XmlWriter xmlOut)
		{
			xmlOut.WriteStartElement("Customer");
			xmlOut.WriteElementString("Type", "Wholesale");
			xmlOut.WriteElementString("FirstName", customer.FirstName);
			xmlOut.WriteElementString("LastName", customer.LastName);
			xmlOut.WriteElementString("Email", customer.Email);
			xmlOut.WriteElementString("Company", customer.Company);
			xmlOut.WriteEndElement();
		}
	}
}
