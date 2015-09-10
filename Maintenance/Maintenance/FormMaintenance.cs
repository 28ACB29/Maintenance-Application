using System;
using System.Windows.Forms;

namespace Maintenance
{
	public partial class FormMaintenance : Form
	{
		public FormMaintenance()
		{
			InitializeComponent();
		}

		private void buttonInvoices_Click(object sender, EventArgs e)
		{
			FormInvoices invoicesForm = new FormInvoices();
			invoicesForm.Show();
		}

		private void buttonCustomer_Click(object sender, EventArgs e)
		{
			FormCustomer customerForm = new FormCustomer();
			customerForm.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
