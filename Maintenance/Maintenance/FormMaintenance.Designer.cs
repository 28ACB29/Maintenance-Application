namespace Maintenance
{
	partial class FormMaintenance
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
			this.buttonInvoices = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonInvoices
			// 
			this.buttonInvoices.Location = new System.Drawing.Point(8, 8);
			this.buttonInvoices.Name = "buttonInvoices";
			this.buttonInvoices.Size = new System.Drawing.Size(75, 23);
			this.buttonInvoices.TabIndex = 0;
			this.buttonInvoices.Text = "Invoices";
			this.buttonInvoices.UseVisualStyleBackColor = true;
			this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(168, 8);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonCustomer
			// 
			this.buttonCustomer.Location = new System.Drawing.Point(88, 8);
			this.buttonCustomer.Name = "buttonCustomer";
			this.buttonCustomer.Size = new System.Drawing.Size(75, 23);
			this.buttonCustomer.TabIndex = 2;
			this.buttonCustomer.Text = "Customer";
			this.buttonCustomer.UseVisualStyleBackColor = true;
			this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
			// 
			// FormMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonCustomer);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonInvoices);
			this.Name = "FormMaintenance";
			this.Text = "FormMaintenance";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonInvoices;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonCustomer;
	}
}

