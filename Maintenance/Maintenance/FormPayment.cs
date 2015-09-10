using System;
using System.Windows.Forms;

namespace Maintenance
{
	public partial class FormPayment : Form
	{
		private static readonly string[] cards = { "Visa", "Mastercard", "American Express" };

		private static readonly string[] months = { "Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "Septmeber", "October", "November", "December" };

		public FormPayment()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsValidData()
		{
			if (radioButtonCreditCard.Checked)
			{
				if (listBoxCreditCardType.SelectedIndex == -1)
				{
					MessageBox.Show("You must select a credit card type.", "Entry Error");
					listBoxCreditCardType.Focus();
					return false;
				}
				else if (textBoxCardNumber.Text == "")
				{
					MessageBox.Show("You must enter a credit card number.", "Entry Error");
					textBoxCardNumber.Focus();
					return false;
				}
				else if (comboBoxExpirationMonth.SelectedIndex == 0)
				{
					MessageBox.Show("You must select a month.", "Entry Error");
					comboBoxExpirationMonth.Focus();
					return false;
				}
				else if (comboBoxExpirationYear.SelectedIndex == 0)
				{
					MessageBox.Show("You must select a year.", "Entry Error");
					comboBoxExpirationYear.Focus();
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		private void SaveData()
		{
			string message;
			if (radioButtonCreditCard.Checked)
			{
				message = "Charge to credit card.\n\nCard type: " + listBoxCreditCardType.Text + "\nCard number: " + textBoxCardNumber.Text + "\nExpiration date: " + comboBoxExpirationMonth.Text + "/" + comboBoxExpirationYear.Text + "\n";
			}
			else
			{
				message = "Send bill to customer.\n\n";
			}

			message += "Default billing: " + checkBoxDefault.Checked.ToString();

			this.Tag = message;
			this.DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="enabled"></param>
		private void ControlControls(bool enabled)
		{
			listBoxCreditCardType.Enabled = enabled;
			textBoxCardNumber.Enabled = enabled;
			comboBoxExpirationMonth.Enabled = enabled;
			comboBoxExpirationYear.Enabled = enabled;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormPayment_Load(object sender, System.EventArgs e)
		{
			listBoxCreditCardType.Items.AddRange(FormPayment.cards);
			listBoxCreditCardType.SelectedIndex = 0;

			comboBoxExpirationMonth.Items.AddRange(FormPayment.months);
			comboBoxExpirationMonth.SelectedIndex = 0;

			comboBoxExpirationYear.Items.Add("Select a year...");
			for (int i = 0; i < 8; i++)
			{
				comboBoxExpirationYear.Items.Add(DateTime.Today.Year + i);
			}
			comboBoxExpirationYear.SelectedIndex = 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = radioButtonCreditCard.Checked;
			ControlControls(enabled);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.IsValidData())
			{
				this.SaveData();
			}
		}
	}
}
