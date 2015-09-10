namespace Maintenance
{
	partial class FormPayment
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
			this.labelExpirationDate = new System.Windows.Forms.Label();
			this.labelCardNumber = new System.Windows.Forms.Label();
			this.labelCreditCardType = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.checkBoxDefault = new System.Windows.Forms.CheckBox();
			this.comboBoxExpirationYear = new System.Windows.Forms.ComboBox();
			this.comboBoxExpirationMonth = new System.Windows.Forms.ComboBox();
			this.listBoxCreditCardType = new System.Windows.Forms.ListBox();
			this.textBoxCardNumber = new System.Windows.Forms.TextBox();
			this.groupBoxBilling = new System.Windows.Forms.GroupBox();
			this.radioButtonBillCustomer = new System.Windows.Forms.RadioButton();
			this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
			this.groupBoxBilling.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelExpirationDate
			// 
			this.labelExpirationDate.AutoSize = true;
			this.labelExpirationDate.Location = new System.Drawing.Point(0, 166);
			this.labelExpirationDate.Name = "labelExpirationDate";
			this.labelExpirationDate.Size = new System.Drawing.Size(79, 13);
			this.labelExpirationDate.TabIndex = 20;
			this.labelExpirationDate.Text = "Expiration Date";
			// 
			// labelCardNumber
			// 
			this.labelCardNumber.AutoSize = true;
			this.labelCardNumber.Location = new System.Drawing.Point(0, 142);
			this.labelCardNumber.Name = "labelCardNumber";
			this.labelCardNumber.Size = new System.Drawing.Size(69, 13);
			this.labelCardNumber.TabIndex = 19;
			this.labelCardNumber.Text = "Card Number";
			// 
			// labelCreditCardType
			// 
			this.labelCreditCardType.AutoSize = true;
			this.labelCreditCardType.Location = new System.Drawing.Point(0, 46);
			this.labelCreditCardType.Name = "labelCreditCardType";
			this.labelCreditCardType.Size = new System.Drawing.Size(86, 13);
			this.labelCreditCardType.TabIndex = 17;
			this.labelCreditCardType.Text = "Credit Card Type";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(192, 230);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 18;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(104, 230);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 16;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// checkBoxDefault
			// 
			this.checkBoxDefault.AutoSize = true;
			this.checkBoxDefault.Location = new System.Drawing.Point(0, 190);
			this.checkBoxDefault.Name = "checkBoxDefault";
			this.checkBoxDefault.Size = new System.Drawing.Size(158, 17);
			this.checkBoxDefault.TabIndex = 15;
			this.checkBoxDefault.Text = "Set as default billing method";
			this.checkBoxDefault.UseVisualStyleBackColor = true;
			this.checkBoxDefault.CheckedChanged += new System.EventHandler(this.checkBoxDefault_CheckedChanged);
			// 
			// comboBoxExpirationYear
			// 
			this.comboBoxExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxExpirationYear.FormattingEnabled = true;
			this.comboBoxExpirationYear.Location = new System.Drawing.Point(184, 166);
			this.comboBoxExpirationYear.Name = "comboBoxExpirationYear";
			this.comboBoxExpirationYear.Size = new System.Drawing.Size(96, 21);
			this.comboBoxExpirationYear.TabIndex = 14;
			// 
			// comboBoxExpirationMonth
			// 
			this.comboBoxExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxExpirationMonth.FormattingEnabled = true;
			this.comboBoxExpirationMonth.Location = new System.Drawing.Point(80, 166);
			this.comboBoxExpirationMonth.Name = "comboBoxExpirationMonth";
			this.comboBoxExpirationMonth.Size = new System.Drawing.Size(96, 21);
			this.comboBoxExpirationMonth.TabIndex = 13;
			// 
			// listBoxCreditCardType
			// 
			this.listBoxCreditCardType.Location = new System.Drawing.Point(88, 46);
			this.listBoxCreditCardType.Name = "listBoxCreditCardType";
			this.listBoxCreditCardType.Size = new System.Drawing.Size(120, 95);
			this.listBoxCreditCardType.TabIndex = 11;
			// 
			// textBoxCardNumber
			// 
			this.textBoxCardNumber.Location = new System.Drawing.Point(88, 142);
			this.textBoxCardNumber.Name = "textBoxCardNumber";
			this.textBoxCardNumber.Size = new System.Drawing.Size(100, 20);
			this.textBoxCardNumber.TabIndex = 12;
			// 
			// groupBoxBilling
			// 
			this.groupBoxBilling.Controls.Add(this.radioButtonBillCustomer);
			this.groupBoxBilling.Controls.Add(this.radioButtonCreditCard);
			this.groupBoxBilling.Location = new System.Drawing.Point(0, 6);
			this.groupBoxBilling.Name = "groupBoxBilling";
			this.groupBoxBilling.Size = new System.Drawing.Size(208, 40);
			this.groupBoxBilling.TabIndex = 10;
			this.groupBoxBilling.TabStop = false;
			this.groupBoxBilling.Text = "Billing";
			// 
			// radioButtonBillCustomer
			// 
			this.radioButtonBillCustomer.AutoSize = true;
			this.radioButtonBillCustomer.Location = new System.Drawing.Point(104, 16);
			this.radioButtonBillCustomer.Name = "radioButtonBillCustomer";
			this.radioButtonBillCustomer.Size = new System.Drawing.Size(85, 17);
			this.radioButtonBillCustomer.TabIndex = 1;
			this.radioButtonBillCustomer.Text = "Bill Customer";
			this.radioButtonBillCustomer.UseVisualStyleBackColor = true;
			// 
			// radioButtonCreditCard
			// 
			this.radioButtonCreditCard.AutoSize = true;
			this.radioButtonCreditCard.Checked = true;
			this.radioButtonCreditCard.Location = new System.Drawing.Point(16, 16);
			this.radioButtonCreditCard.Name = "radioButtonCreditCard";
			this.radioButtonCreditCard.Size = new System.Drawing.Size(77, 17);
			this.radioButtonCreditCard.TabIndex = 0;
			this.radioButtonCreditCard.TabStop = true;
			this.radioButtonCreditCard.Text = "Credit Card";
			this.radioButtonCreditCard.UseVisualStyleBackColor = true;
			// 
			// FormPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 258);
			this.Controls.Add(this.labelExpirationDate);
			this.Controls.Add(this.labelCardNumber);
			this.Controls.Add(this.labelCreditCardType);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkBoxDefault);
			this.Controls.Add(this.comboBoxExpirationYear);
			this.Controls.Add(this.comboBoxExpirationMonth);
			this.Controls.Add(this.listBoxCreditCardType);
			this.Controls.Add(this.textBoxCardNumber);
			this.Controls.Add(this.groupBoxBilling);
			this.Name = "FormPayment";
			this.Text = "FormPayment";
			this.Load += new System.EventHandler(this.FormPayment_Load);
			this.groupBoxBilling.ResumeLayout(false);
			this.groupBoxBilling.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelExpirationDate;
		private System.Windows.Forms.Label labelCardNumber;
		private System.Windows.Forms.Label labelCreditCardType;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.CheckBox checkBoxDefault;
		private System.Windows.Forms.ComboBox comboBoxExpirationYear;
		private System.Windows.Forms.ComboBox comboBoxExpirationMonth;
		private System.Windows.Forms.ListBox listBoxCreditCardType;
		private System.Windows.Forms.TextBox textBoxCardNumber;
		private System.Windows.Forms.GroupBox groupBoxBilling;
		private System.Windows.Forms.RadioButton radioButtonBillCustomer;
		private System.Windows.Forms.RadioButton radioButtonCreditCard;
	}
}