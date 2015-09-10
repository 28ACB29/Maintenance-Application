using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maintenance
{
	/// <summary>
	/// 
	/// </summary>
	public partial class FormInvoices : Form
	{
		private const string PERCENT_FORMAT_STRING = "p1";

		private const string CURRENCY_FORMAT_STRING = "c";

		private const short invoiceTotalArraySize = 5;

		private decimal[] invoiceTotalArray;

		private int invoiceTotalArrayIndex;

		private List<decimal> invoiceTotalList;

		/// <summary>
		/// 
		/// </summary>
		public FormInvoices()
		{
			InitializeComponent();
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormInvoices_Load(object sender, EventArgs e)
		{
			this.invoiceTotalArray = new decimal[invoiceTotalArraySize];
			this.invoiceTotalArrayIndex = 0;
			this.invoiceTotalList = new List<decimal>();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			string customerType = textBoxCustomerType.Text;
			decimal subtotal;
			decimal discountPercent = .0m;
			decimal discountAmount;
			decimal invoiceTotal;

			try
			{
				if (textBoxSubtotal.Text.Length != 0)
				{
					subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
					if (subtotal > 0 && subtotal < 10000)
					{
						switch (customerType.ToUpper())
						{
							case "R":
								if (subtotal < 100)
								{
									discountPercent = .0m;
								}
								else if (subtotal >= 100 && subtotal < 250)
								{
									discountPercent = .25m;
								}
								else if (subtotal >= 250)
								{
									discountPercent = .3m;
								}
								break;
							case "C":
								discountPercent = .2m;
								break;
							case "T":
								if (subtotal < 500)
								{
									discountPercent = .4m;
								}
								else
								{
									discountPercent = .5m;
								}
								break;
							default:
								discountPercent = .1m;
								break;
						}

						discountAmount = subtotal * discountPercent;
						invoiceTotal = subtotal - discountAmount;

						discountAmount = Math.Round(discountAmount, 2);
						invoiceTotal = Math.Round(invoiceTotal, 2);

						this.invoiceTotalArray[this.invoiceTotalArrayIndex] = invoiceTotal;
						this.invoiceTotalArrayIndex++;
						decimal[] temp = new decimal[this.invoiceTotalArrayIndex];
						Array.Copy(this.invoiceTotalArray, temp, this.invoiceTotalArrayIndex);
						Array.Sort(temp);
						Array.Copy(temp, this.invoiceTotalArray, this.invoiceTotalArrayIndex);

						this.invoiceTotalList.Add(invoiceTotal);

						textBoxDiscountPercent.Text = discountPercent.ToString(FormInvoices.PERCENT_FORMAT_STRING);
						textBoxDiscountAmount.Text = discountAmount.ToString(FormInvoices.CURRENCY_FORMAT_STRING);
						textBoxTotal.Text = invoiceTotal.ToString(FormInvoices.CURRENCY_FORMAT_STRING);
					}
				}
				else
				{
					MessageBox.Show("The subtotal field should not be empty.", "Entry Error");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter a valid number for the subtotal field.", "Entry Error");
			}

			textBoxSubtotal.Focus();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonExit_Click(object sender, EventArgs e)
		{
			string arrayOutput = "";
			for (int i = 0; i < this.invoiceTotalArrayIndex; i++)
			{
				arrayOutput += this.invoiceTotalArray[i].ToString() + "\n";
			}
			MessageBox.Show(arrayOutput, "Order Totals");

			string listOutput = "";
			foreach (decimal invoice in this.invoiceTotalList)
			{
				listOutput += invoice.ToString() + "\n";
			}
			MessageBox.Show(listOutput, "Order Totals");

			base.Close();
		}
	}
}
