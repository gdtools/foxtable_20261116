using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000231 RID: 561
	public class wRowCollection : IEnumerable<wTableRow>
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x000BD85D File Offset: 0x000BBA5D
		public wRowCollection()
		{
			this.OOOO0._0O. = new List<wTableRow>();
		}

		/// <summary>
		/// 增加行
		/// </summary>
		/// <param name="values">新增行中各列的值</param>
		// Token: 0x06001AC4 RID: 6852 RVA: 0x000BD870 File Offset: 0x000BBA70
		[oO0oooo("A0063")]
		public wTableRow AddRow(params string[] values)
		{
			wTableRow wTableRow = new wTableRow();
			wTableRow.AddCells(values);
			this.OOOO0._0O..Add(wTableRow);
			return wTableRow;
		}

		/// <summary>
		/// 增加行
		/// </summary>
		/// <param name="values">一个集合，用于设置新增行中每列的值</param>
		// Token: 0x06001AC5 RID: 6853 RVA: 0x000BD897 File Offset: 0x000BBA97
		[oO0oooo("A0063")]
		public wTableRow AddRow(List<string> values)
		{
			return this.AddRow(values.ToArray());
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000BD8A5 File Offset: 0x000BBAA5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<wTableRow> <<EMPTY_NAME>>()
		{
			return (IEnumerator<wTableRow>)this.OOOO0._0O..GetEnumerator();
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000BD8BC File Offset: 0x000BBABC
		[EditorBrowsable(EditorBrowsableState.Never)]
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return (IEnumerator)this.OOOO0._0O..GetEnumerator();
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x000BD8D3 File Offset: 0x000BBAD3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Count
		{
			get
			{
				return this.OOOO0._0O..Count;
			}
		}

		// Token: 0x170005A8 RID: 1448
		[EditorBrowsable(EditorBrowsableState.Never)]
		public wTableRow this[int A_0]
		{
			get
			{
				return this.OOOO0._0O.[A_0];
			}
			set
			{
				this.OOOO0._0O.[A_0] = value;
			}
		}

		// Token: 0x04000B4D RID: 2893
		private List<wTableRow> <<EMPTY_NAME>>;
	}
}
