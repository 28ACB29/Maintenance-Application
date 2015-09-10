using System.Windows.Forms;

namespace Maintenance
{
	public partial class FormAddCustomer : Form
	{
		private Customer customer;

		/// <summary>
		/// 
		/// </summary>
		public FormAddCustomer()
		{
			InitializeComponent();
			this.customer = null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Customer getNewCustomer()
		{
			this.ShowDialog();
			return this.customer;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsValidData()
		{
			return Validator.IsPresent(textBoxFirstName) &&
				Validator.IsPresent(textBoxLastName) &&
				Validator.IsPresent(textBoxEmail) &&
				Validator.IsValidEmail(textBoxEmail);
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
				this.customer = new Customer(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text);
				this.Close();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			base.Close();
		}
	}
}
