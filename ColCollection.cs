using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000317 RID: 791
	[oO0oooo("0561")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ColCollection : IEnumerable<Col>
	{
		// Token: 0x06002ADD RID: 10973 RVA: 0x0013121B File Offset: 0x0012F41B
		internal ColCollection(Table A_0)
		{
			this._Columns = new Dictionary<string, Col>();
			this.Table = A_0;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00131235 File Offset: 0x0012F435
		internal void Reset()
		{
			this._Columns.Clear();
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x00131244 File Offset: 0x0012F444
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Col Item
		{
			get
			{
				Col result;
				if (this._Columns.ContainsKey(ColumnName))
				{
					result = this._Columns[ColumnName];
				}
				else if (this.Table.foxGrid.Cols.Contains(ColumnName))
				{
					ColumnName = this.Table.foxGrid.Cols[ColumnName].Name;
					if (this._Columns.ContainsKey(ColumnName))
					{
						result = this._Columns[ColumnName];
					}
					else
					{
						Col col = new Col(this.Table, ColumnName);
						this._Columns.Add(ColumnName, col);
						result = col;
					}
				}
				else
				{
					MessageBox.Show(this.Table.DataTable.Name + "不存在名为 \"" + ColumnName + "\"的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00131314 File Offset: 0x0012F514
		internal void RenameColumn(string OldName, string NewName)
		{
			if (this._Columns.ContainsKey(OldName))
			{
				if (this._Columns.ContainsKey(NewName))
				{
					this._Columns.Remove(NewName);
				}
				Col col = this._Columns[OldName];
				this._Columns.Remove(OldName);
				col.o_.ooOO0O.(NewName);
				this._Columns.Add(NewName, col);
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x06002AE1 RID: 10977 RVA: 0x00131378 File Offset: 0x0012F578
		public bool Contains(string ColumnName)
		{
			bool result;
			try
			{
				result = this.Table.foxGrid.Cols.Contains(ColumnName);
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x001313C0 File Offset: 0x0012F5C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Col Item
		{
			get
			{
				return this.get_Item(this.Table.foxGrid.Cols[Index + this.Table.foxGrid.Cols.Fixed].Name);
			}
		}

		// Token: 0x1700098C RID: 2444
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Col this[object A_0]
		{
			get
			{
				Col result;
				if (A_0 is string)
				{
					result = this.get_Item(A_0.ToString());
				}
				else
				{
					int index = -1;
					if (int.TryParse(A_0.ToString(), out index))
					{
						result = this.get_Item(index);
					}
					else
					{
						result = this.get_Item(A_0.ToString());
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 列数
		/// </summary>
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x00131449 File Offset: 0x0012F649
		public int Count
		{
			get
			{
				return this.Table.foxGrid.Cols.Count - this.Table.foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 移除指定名称的列
		/// </summary>
		/// <param name="ColumnName">要移除列的名称</param>
		// Token: 0x06002AE5 RID: 10981 RVA: 0x00131476 File Offset: 0x0012F676
		public void Remove(string ColumnName)
		{
			if (this.Table.foxGrid.Cols.Contains(ColumnName))
			{
				this.Table.foxGrid.Cols.Remove(ColumnName);
			}
			this._Columns.Remove(ColumnName);
		}

		/// <summary>
		/// 移除多列
		/// </summary>
		/// <param name="ColumnNames">要移除列的名称</param>
		// Token: 0x06002AE6 RID: 10982 RVA: 0x001314B4 File Offset: 0x0012F6B4
		public void Remove(params string[] ColumnNames)
		{
			this.Table.foxGrid.BeginUpdate();
			foreach (string text in ColumnNames)
			{
				this.Table.foxGrid.Cols.Remove(text);
				this._Columns.Remove(text);
			}
			this.Table.foxGrid.EndUpdate();
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00131519 File Offset: 0x0012F719
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Col> GetEnumerator()
		{
			return new OOOooo_o(this.Table);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00131526 File Offset: 0x0012F726
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new OOOooo_o(this.Table);
		}

		/// <summary>
		/// 冻结列数量
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x00131533 File Offset: 0x0012F733
		// (set) Token: 0x06002AEA RID: 10986 RVA: 0x0013154A File Offset: 0x0012F74A
		public int Frozen
		{
			get
			{
				return this.Table.foxGrid.Cols.Frozen;
			}
			set
			{
				this.Table.foxGrid.Cols.Frozen = value;
			}
		}

		// Token: 0x040011A4 RID: 4516
		private Dictionary<string, Col> _Columns;

		// Token: 0x040011A5 RID: 4517
		private Table Table;
	}
}
