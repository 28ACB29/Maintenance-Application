namespace Maintenance
{
	partial class FormAddCustomer
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
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(79, 73);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(176, 20);
			this.textBoxEmail.TabIndex = 23;
			this.textBoxEmail.Tag = "Email";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(79, 41);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(176, 20);
			this.textBoxLastName.TabIndex = 22;
			this.textBoxLastName.Tag = "Last Name";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(79, 9);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(176, 20);
			this.textBoxFirstName.TabIndex = 21;
			this.textBoxFirstName.Tag = "First Name";
			// 
			// labelEmail
			// 
			this.labelEmail.Location = new System.Drawing.Point(7, 73);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(72, 23);
			this.labelEmail.TabIndex = 28;
			this.labelEmail.Text = "Email:";
			this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLastName
			// 
			this.labelLastName.Location = new System.Drawing.Point(7, 41);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(72, 23);
			this.labelLastName.TabIndex = 27;
			this.labelLastName.Text = "Last Name:";
			this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelFirstName
			// 
			this.labelFirstName.Location = new System.Drawing.Point(7, 9);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(72, 23);
			this.labelFirstName.TabIndex = 26;
			this.labelFirstName.Text = "First Name:";
			this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(178, 104);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 25;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(97, 104);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 24;
			this.buttonSave.Text = "&Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormAddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(262, 137);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Name = "FormAddCustomer";
			this.Text = "FormAddCustomer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
	}
}