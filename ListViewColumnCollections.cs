using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001AF RID: 431
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ListViewColumnCollections : IEnumerable<ListViewColumn>
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x0009814D File Offset: 0x0009634D
		internal ListViewColumnCollections(o_OO_oOOO0o A_0, System.Windows.Forms.ListView.ColumnHeaderCollection A_1)
		{
			this.oo.oO_. = A_0;
			this.oo.oO_. = A_1;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00098163 File Offset: 0x00096363
		public int Count
		{
			get
			{
				return this.oo.oO_..Count;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00098170 File Offset: 0x00096370
		public bool Contains
		{
			get
			{
				return this.oo.oO_..ContainsKey(key);
			}
		}

		// Token: 0x17000407 RID: 1031
		public ListViewColumn this[int Index]
		{
			get
			{
				return new ListViewColumn(this.oo.oO_.[Index]);
			}
		}

		// Token: 0x17000408 RID: 1032
		public ListViewColumn this[string Key]
		{
			get
			{
				ListViewColumn result;
				if (Operators.CompareString(Key, this.oo.oO_..O_O.0Oo_o.(), true) == 0)
				{
					result = new ListViewColumn(this.oo.oO_..Columns[0]);
				}
				else
				{
					result = new ListViewColumn(this.oo.oO_.[Key]);
				}
				return result;
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000981E1 File Offset: 0x000963E1
		public void Clear()
		{
			this.oo.oO_..Items.Clear();
			this.oo.oO_..Clear();
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00098200 File Offset: 0x00096400
		public ListViewColumn Add()
		{
			ListViewColumn result;
			if (!this.oo.oO_.())
			{
				result = null;
			}
			else
			{
				ColumnHeader columnHeader = new ColumnHeader();
				this.oo.oO_..Add(columnHeader);
				result = new ListViewColumn(columnHeader);
			}
			return result;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00098234 File Offset: 0x00096434
		public void Delete(string Key)
		{
			if (this.oo.oO_.())
			{
				if (Operators.CompareString(Key, this.oo.oO_..O_O.0Oo_o.(), true) == 0)
				{
					this.oo.oO_..RemoveAt(0);
					if (this.oo.oO_..Count > 0)
					{
						this.oo.oO_..o0__o.O0.(this.oo.oO_..Columns[0].Name);
						return;
					}
				}
				else
				{
					this.oo.oO_..RemoveByKey(Key);
				}
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000982A5 File Offset: 0x000964A5
		public void Delete(int Index)
		{
			this.oo.oO_..RemoveAt(Index);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000982B3 File Offset: 0x000964B3
		public void Delete(ListViewColumn item)
		{
			if (this.oo.oO_.())
			{
				this.oo.oO_..Remove(item.BaseColumn);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000982CE File Offset: 0x000964CE
		public IEnumerator<ListViewColumn> GetEnumerator()
		{
			return new O0o(this.oo.oO_.);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000982DB File Offset: 0x000964DB
		public IEnumerator GetEnumerator1()
		{
			return new O0o(this.oo.oO_.);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000982E8 File Offset: 0x000964E8
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			if (this.oo.oO_..Items.Count > 0)
			{
				MessageBox.Show("在已经有行的情况下，不能再增加或删除列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000850 RID: 2128
		private System.Windows.Forms.ListView.ColumnHeaderCollection <<EMPTY_NAME>>;

		// Token: 0x04000851 RID: 2129
		private o_OO_oOOO0o <<EMPTY_NAME>>;
	}
}
