namespace nMain.Design.Toolbox
{
	partial class frmComboBox
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
			this.cmbCustomerSex = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cmbCustomerSex
			// 
			this.cmbCustomerSex.FormattingEnabled = true;
			this.cmbCustomerSex.Location = new System.Drawing.Point(219, 92);
			this.cmbCustomerSex.Name = "cmbCustomerSex";
			this.cmbCustomerSex.Size = new System.Drawing.Size(294, 30);
			this.cmbCustomerSex.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "เพศ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(130, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(219, 153);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(294, 30);
			this.comboBox2.TabIndex = 2;
			// 
			// frmComboBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 619);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCustomerSex);
			this.Font = new System.Drawing.Font("Sylfaen", 10.2F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmComboBox";
			this.Text = "frmComboBox";
			this.Load += new System.EventHandler(this.frmComboBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCustomerSex;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}