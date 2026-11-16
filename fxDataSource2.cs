using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200009D RID: 157
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class fxDataSource2
	{
		// Token: 0x06000633 RID: 1587 RVA: 0x0002FC5F File Offset: 0x0002DE5F
		public fxDataSource2(fxDataSource A_0)
		{
			this.Oo.0_O00_. = A_0;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0002FC6E File Offset: 0x0002DE6E
		internal fxDataSource DataSource
		{
			get
			{
				return this.Oo.0_O00_.;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002FC78 File Offset: 0x0002DE78
		public void Combine(params object[] args)
		{
			if (args[0] is string)
			{
				this.Combine(Conversions.ToString(args[0]), (fxDataSource2)args[1], Conversions.ToString(args[2]));
				return;
			}
			if (args[0] is string[])
			{
				string[] leftCol = ooO.oO0__o.0o__.((object[])args[0]);
				string[] rightCol = ooO.oO0__o.0o__.((object[])args[2]);
				this.Combine(leftCol, (fxDataSource2)args[1], rightCol);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002FCE4 File Offset: 0x0002DEE4
		public void Combine(string LeftCol, fxDataSource2 RightTable, string RightCol)
		{
			Oo00.oO.OO.(this.Oo.0_O00_., LeftCol, RightTable.DataSource, RightCol);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002FCF9 File Offset: 0x0002DEF9
		public void Combine(string[] LeftCol, fxDataSource2 RightTable, string[] RightCol)
		{
			Oo00.oO.OO.(this.Oo.0_O00_., LeftCol, RightTable.DataSource, RightCol);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002FD0E File Offset: 0x0002DF0E
		public void Union(fxDataSource2 DataTable2)
		{
			this.Oo.0_O00_..Merge(DataTable2.DataSource, false, MissingSchemaAction.Ignore);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002FD23 File Offset: 0x0002DF23
		public DataTable ConvetToDataTable()
		{
			return this.Oo.0_O00_..ConvetToDataTable();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002FD30 File Offset: 0x0002DF30
		public void Show(string TableName, string TableCaption = "")
		{
			this.Oo.0_O00_..Show(TableName, TableCaption);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0002FD3F File Offset: 0x0002DF3F
		public DataTable ToDataTable()
		{
			return this.Oo.0_O00_..ToDataTable();
		}

		// Token: 0x040001A2 RID: 418
		private fxDataSource <<EMPTY_NAME>>;
	}
}
