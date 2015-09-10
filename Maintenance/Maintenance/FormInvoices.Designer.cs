namespace Maintenance
{
	partial class FormInvoices
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
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
			this.textBoxDiscountPercent = new System.Windows.Forms.TextBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.textBoxSubtotal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelDiscountAmount = new System.Windows.Forms.Label();
			this.labelDiscountPercent = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.textBoxCustomerType = new System.Windows.Forms.TextBox();
			this.labelCustomerType = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(140, 142);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotal.TabIndex = 25;
			this.textBoxTotal.TabStop = false;
			// 
			// textBoxDiscountAmount
			// 
			this.textBoxDiscountAmount.Location = new System.Drawing.Point(140, 116);
			this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
			this.textBoxDiscountAmount.ReadOnly = true;
			this.textBoxDiscountAmount.Size = new System.Drawing.Size(100, 20);
			this.textBoxDiscountAmount.TabIndex = 24;
			this.textBoxDiscountAmount.TabStop = false;
			// 
			// textBoxDiscountPercent
			// 
			this.textBoxDiscountPercent.Location = new System.Drawing.Point(140, 89);
			this.textBoxDiscountPercent.Name = "textBoxDiscountPercent";
			this.textBoxDiscountPercent.ReadOnly = true;
			this.textBoxDiscountPercent.Size = new System.Drawing.Size(100, 20);
			this.textBoxDiscountPercent.TabIndex = 23;
			this.textBoxDiscountPercent.TabStop = false;
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(165, 176);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 18;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(78, 176);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 16;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// textBoxSubtotal
			// 
			this.textBoxSubtotal.Location = new System.Drawing.Point(140, 63);
			this.textBoxSubtotal.Name = "textBoxSubtotal";
			this.textBoxSubtotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxSubtotal.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(153, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 22;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(153, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 21;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(153, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 20;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(46, 145);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(34, 13);
			this.labelTotal.TabIndex = 19;
			this.labelTotal.Text = "Total:";
			this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDiscountAmount
			// 
			this.labelDiscountAmount.AutoSize = true;
			this.labelDiscountAmount.Location = new System.Drawing.Point(46, 119);
			this.labelDiscountAmount.Name = "labelDiscountAmount";
			this.labelDiscountAmount.Size = new System.Drawing.Size(91, 13);
			this.labelDiscountAmount.TabIndex = 17;
			this.labelDiscountAmount.Text = "Discount Amount:";
			this.labelDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDiscountPercent
			// 
			this.labelDiscountPercent.AutoSize = true;
			this.labelDiscountPercent.Location = new System.Drawing.Point(45, 92);
			this.labelDiscountPercent.Name = "labelDiscountPercent";
			this.labelDiscountPercent.Size = new System.Drawing.Size(92, 13);
			this.labelDiscountPercent.TabIndex = 15;
			this.labelDiscountPercent.Text = "Discount Percent:";
			this.labelDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.AutoSize = true;
			this.labelSubtotal.Location = new System.Drawing.Point(45, 66);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(49, 13);
			this.labelSubtotal.TabIndex = 13;
			this.labelSubtotal.Text = "&Subtotal:";
			this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxCustomerType
			// 
			this.textBoxCustomerType.Location = new System.Drawing.Point(152, 32);
			this.textBoxCustomerType.Name = "textBoxCustomerType";
			this.textBoxCustomerType.Size = new System.Drawing.Size(84, 20);
			this.textBoxCustomerType.TabIndex = 27;
			// 
			// labelCustomerType
			// 
			this.labelCustomerType.Location = new System.Drawing.Point(48, 32);
			this.labelCustomerType.Name = "labelCustomerType";
			this.labelCustomerType.Size = new System.Drawing.Size(94, 20);
			this.labelCustomerType.TabIndex = 26;
			this.labelCustomerType.Text = "Customer type:";
			this.labelCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormInvoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.textBoxCustomerType);
			this.Controls.Add(this.labelCustomerType);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.textBoxDiscountAmount);
			this.Controls.Add(this.textBoxDiscountPercent);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.textBoxSubtotal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.labelDiscountAmount);
			this.Controls.Add(this.labelDiscountPercent);
			this.Controls.Add(this.labelSubtotal);
			this.Name = "FormInvoices";
			this.Text = "FormInvoices";
			this.Load += new System.EventHandler(this.FormInvoices_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxDiscountAmount;
		private System.Windows.Forms.TextBox textBoxDiscountPercent;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TextBox textBoxSubtotal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelDiscountAmount;
		private System.Windows.Forms.Label labelDiscountPercent;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.TextBox textBoxCustomerType;
		private System.Windows.Forms.Label labelCustomerType;
	}
}