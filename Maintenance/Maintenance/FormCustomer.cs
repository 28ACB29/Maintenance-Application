using System.Windows.Forms;

namespace Maintenance
{
	public partial class FormCustomer : Form
	{
		private bool isDataSaved;

		private CustomerList customers;

		public FormCustomer()
		{
			InitializeComponent();
			this.isDataSaved = true;
			this.customers = new CustomerList();
		}

		/// <summary>
		/// 
		/// </summary>
		private void SaveData()
		{
			ComboBoxNames.SelectedIndex = -1;
			labelPayment.Text = "";
			this.isDataSaved = true;
			ComboBoxNames.Focus();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsValidData()
		{
			if (ComboBoxNames.SelectedIndex == -1)
			{
				MessageBox.Show("You must select a customer.", "Entry Error");
				ComboBoxNames.Focus();
				return false;
			}
			else if (labelPayment.Text == "")
			{
				MessageBox.Show("You must enter a payment.", "Entry Error");
				return false;
			}
			else
			{
				return true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void populateComboBoxCustomers()
		{
			ComboBoxNames.Items.Clear();
			Customer customer;
			for (int i = 0; i < this.customers.Count; i++)
			{
				customer = this.customers[i];
				ComboBoxNames.Items.Add(customer.GetDisplayText());
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customers"></param>
		private void HandleCustomerListChanged(CustomerList customers)
		{
			this.customers.Save();
			populateComboBoxCustomers();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormCustomer_Load(object sender, System.EventArgs e)
		{
			this.customers.Fill();
			this.populateComboBoxCustomers();
			this.customers.Changed += new CustomerList.ChangeHandler(HandleCustomerListChanged);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
		{
			string message;
			DialogResult button;
			if (!this.isDataSaved)
			{
				message = "This form contains unsaved data.\n\nDo you want to save it?";
				button = MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				switch (button)
				{
					case DialogResult.Yes:
						{
							if (this.IsValidData())
							{
								this.SaveData();
							}
							else
							{
								e.Cancel = true;
							}
							break;
						}
					case DialogResult.Cancel:
						{
							e.Cancel = true;
							break;
						}
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ComboBoxNames_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.isDataSaved = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			FormAddCustomer addCustomersForm = new FormAddCustomer();
			Customer customer = addCustomersForm.getNewCustomer();
			if (customer != null)
			{
				this.customers = this.customers + customer;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			int index = ComboBoxNames.SelectedIndex;
			string message = "Are you sure you you want to delete ";
			if (index != -1)
			{
				Customer customer = (Customer)this.customers[index];
				message += customer.GetDisplayText() + "?";
				DialogResult button = MessageBox.Show(message, "Confirm delete", MessageBoxButtons.YesNo);
				if (button == DialogResult.Yes)
				{
					this.customers = this.customers - customer;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSelectPayment_Click(object sender, System.EventArgs e)
		{
			Form paymentForm = new FormPayment();
			DialogResult selectedButton = paymentForm.ShowDialog();
			if (selectedButton == DialogResult.OK)
			{
				labelPayment.Text = (string)paymentForm.Tag;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if (this.IsValidData())
			{
				this.SaveData();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			base.Close();
		}
	}
}
