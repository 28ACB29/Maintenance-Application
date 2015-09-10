namespace Maintenance
{
	partial class FormCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelPayment = new System.Windows.Forms.Label();
			this.buttonSelectPayment = new System.Windows.Forms.Button();
			this.labelPaymentMethod = new System.Windows.Forms.Label();
			this.labelCustomerName = new System.Windows.Forms.Label();
			this.ComboBoxNames = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(254, 205);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 28;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(166, 205);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 27;
			this.buttonSave.Text = "&Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// labelPayment
			// 
			this.labelPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPayment.Location = new System.Drawing.Point(14, 101);
			this.labelPayment.Name = "labelPayment";
			this.labelPayment.Size = new System.Drawing.Size(200, 80);
			this.labelPayment.TabIndex = 26;
			// 
			// buttonSelectPayment
			// 
			this.buttonSelectPayment.Location = new System.Drawing.Point(230, 101);
			this.buttonSelectPayment.Name = "buttonSelectPayment";
			this.buttonSelectPayment.Size = new System.Drawing.Size(104, 23);
			this.buttonSelectPayment.TabIndex = 25;
			this.buttonSelectPayment.Text = "Select Payment";
			this.buttonSelectPayment.Click += new System.EventHandler(this.buttonSelectPayment_Click);
			// 
			// labelPaymentMethod
			// 
			this.labelPaymentMethod.Location = new System.Drawing.Point(14, 77);
			this.labelPaymentMethod.Name = "labelPaymentMethod";
			this.labelPaymentMethod.Size = new System.Drawing.Size(100, 23);
			this.labelPaymentMethod.TabIndex = 24;
			this.labelPaymentMethod.Text = "Payment method:";
			// 
			// labelCustomerName
			// 
			this.labelCustomerName.Location = new System.Drawing.Point(14, 14);
			this.labelCustomerName.Name = "labelCustomerName";
			this.labelCustomerName.Size = new System.Drawing.Size(100, 23);
			this.labelCustomerName.TabIndex = 23;
			this.labelCustomerName.Text = "Customer name:";
			// 
			// ComboBoxNames
			// 
			this.ComboBoxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxNames.FormattingEnabled = true;
			this.ComboBoxNames.Location = new System.Drawing.Point(134, 14);
			this.ComboBoxNames.Name = "ComboBoxNames";
			this.ComboBoxNames.Size = new System.Drawing.Size(200, 21);
			this.ComboBoxNames.TabIndex = 22;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(14, 45);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 29;
			this.buttonAdd.Text = "&Add";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(102, 45);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 30;
			this.buttonDelete.Text = "&Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// FormCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 241);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPayment);
			this.Controls.Add(this.buttonSelectPayment);
			this.Controls.Add(this.labelPaymentMethod);
			this.Controls.Add(this.labelCustomerName);
			this.Controls.Add(this.ComboBoxNames);
			this.Name = "FormCustomer";
			this.Text = "FormCustomer";
			this.Load += new System.EventHandler(this.FormCustomer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelPayment;
		private System.Windows.Forms.Button buttonSelectPayment;
		private System.Windows.Forms.Label labelPaymentMethod;
		private System.Windows.Forms.Label labelCustomerName;
		private System.Windows.Forms.ComboBox ComboBoxNames;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
	}
}