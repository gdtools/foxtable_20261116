using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000248 RID: 584
	public class fxDataSource : DataTable
	{
		// Token: 0x06001BD4 RID: 7124 RVA: 0x000C3245 File Offset: 0x000C1445
		public void Combine(string LeftCol, fxDataSource RightTable, string RightCol)
		{
			Oo00.oO.OO.(this, LeftCol, RightTable, RightCol);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000C3250 File Offset: 0x000C1450
		public void Combine(string[] LeftCol, fxDataSource RightTable, string[] RightCol)
		{
			Oo00.oO.OO.(this, LeftCol, RightTable, RightCol);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000C325B File Offset: 0x000C145B
		public void Union(fxDataSource DataTable2)
		{
			base.Merge(DataTable2, false, MissingSchemaAction.Ignore);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000C3266 File Offset: 0x000C1466
		public DataTable ConvetToDataTable()
		{
			DataTable dataTable = new DataTable(this, null, null, "", O_O0OO.OoO.0OO__0ooo.());
			dataTable.o.0O000_.();
			return dataTable;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000C3280 File Offset: 0x000C1480
		public void Show(string TableName, string TableCaption = "")
		{
			string left = OO_00oOO.MainTable.Name;
			if (OO_00oOO.DataTables.Contains(TableName))
			{
				if (OO_00oOO.DataTables[TableName].AddByCode)
				{
					OO_00oOO.DataTables.Delete(TableName);
				}
				if (OO_00oOO.DataTables.Contains(TableName))
				{
					MessageBox.Show("表" + TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			base.TableName = TableName;
			O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(this);
			OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(this, null, null, TableName, O_O0OO.OoO.0OO__0ooo.()));
			OO_00oOO.DataTables[TableName].o.0O000_.();
			OO_00oOO.DataTables[TableName].AddByCode = true;
			OO_00oOO.DataTables[TableName].Caption = TableCaption;
			DataTable dataTable = OO_00oOO.DataTables[TableName];
			try
			{
				foreach (DataCol dataCol in dataTable.DataCols)
				{
					if (Operators.CompareString(dataCol.BaseColumn.Caption, "", true) > 0)
					{
						dataCol.Caption = dataCol.BaseColumn.Caption;
						dataCol.BaseColumn.Caption = "";
					}
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			new O_0(O_O0OO.o__.O.(), this);
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[TableName]);
			Main.OO_O.o..o0_o_o_0.0O.(TableName, true, false);
			if (Operators.CompareString(left, TableName, true) == 0)
			{
				OO_00oOO.MainTable = OO_00oOO.Tables[TableName];
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000C3418 File Offset: 0x000C1618
		public DataTable ToDataTable()
		{
			DataTable dataTable = new DataTable(this, null, null, "", null);
			dataTable.o.0O000_.();
			try
			{
				foreach (DataCol dataCol in dataTable.DataCols)
				{
					if (Operators.CompareString(dataCol.BaseColumn.Caption, "", true) > 0)
					{
						dataCol.Caption = dataCol.BaseColumn.Caption;
						dataCol.BaseColumn.Caption = "";
					}
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x04000BC4 RID: 3012
		internal GroupTableBuilder <<EMPTY_NAME>>;

		// Token: 0x04000BC5 RID: 3013
		internal CrossTableBuilder <<EMPTY_NAME>>;
	}
}
