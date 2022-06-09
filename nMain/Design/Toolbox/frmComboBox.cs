using nLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nMain.Design.Toolbox
{
	public partial class frmComboBox : Form
	{
		public frmComboBox()
		{
			InitializeComponent();
		}

		private void frmComboBox_Load(object sender, EventArgs e)
		{
			//string sql = @"SELECT SCODE,SNAME FROM VW_CUSTOMER_SEX ";
			//DataSet ds = cData.getDataSetWithSqlCommand(cConn._connStr, sql, 1000, true);

			//cmbCustomerSex.BeginUpdate();
			//cmbCustomerSex.DataSource = ds.Tables[0];
			//cmbCustomerSex.DisplayMember = "SNAME";
			//cmbCustomerSex.ValueMember = "SCODE";
			//cmbCustomerSex.EndUpdate();
		}
	}
}
