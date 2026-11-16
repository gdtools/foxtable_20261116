using System;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 表关联
	/// </summary>
	// Token: 0x02000311 RID: 785
	[ComVisible(true)]
	[oO0oooo("1941")]
	public class Relation
	{
		// Token: 0x06002A54 RID: 10836 RVA: 0x0012D1C8 File Offset: 0x0012B3C8
		public Relation(DataRelation A_0)
		{
			this.o.0OoO. = (O0Oo)A_0;
			this.O.OOoo_o0. = new DataCol[A_0.ParentColumns.Length - 1 + 1];
			this.oo_.000o0Oo0. = new DataCol[A_0.ChildColumns.Length - 1 + 1];
			int num = this.O.OOoo_o0..Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(A_0.ParentColumns[i].ColumnName, "_Identify", true) == 0)
				{
					this.O.OOoo_o0.[i] = new DataCol(A_0.ParentColumns[i]);
				}
				else
				{
					this.O.OOoo_o0.[i] = this.ParentTable.DataCols[A_0.ParentColumns[i].ColumnName];
				}
				this.oo_.000o0Oo0.[i] = this.ChildTable.DataCols[A_0.ChildColumns[i].ColumnName];
			}
		}

		/// <summary>
		/// 父表
		/// </summary>
		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x0012D2AA File Offset: 0x0012B4AA
		public DataTable ParentTable
		{
			get
			{
				return OO_00oOO.DataTables[this.o.0OoO..ParentTable.TableName];
			}
		}

		/// <summary>
		/// 子表
		/// </summary>
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x0012D2C6 File Offset: 0x0012B4C6
		public DataTable ChildTable
		{
			get
			{
				return OO_00oOO.DataTables[this.o.0OoO..ChildTable.TableName];
			}
		}

		/// <summary>
		/// 一个数组，包括所有父表关联列，一般通过多列建立关联时才使用
		/// </summary>
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x0012D2E2 File Offset: 0x0012B4E2
		public DataCol[] ParentColumns
		{
			get
			{
				return this.O.OOoo_o0.;
			}
		}

		/// <summary>
		/// 父表关联列
		/// </summary>
		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x0012D2EA File Offset: 0x0012B4EA
		public DataCol ParentColumn
		{
			get
			{
				return this.O.OOoo_o0.[0];
			}
		}

		/// <summary>
		/// 一个数组，包括所有子表关联列，一般通过多列建立关联时才使用
		/// </summary>
		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x0012D2F4 File Offset: 0x0012B4F4
		public DataCol[] ChildColumns
		{
			get
			{
				return this.oo_.000o0Oo0.;
			}
		}

		/// <summary>
		/// 子表关联列
		/// </summary>
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0012D2FC File Offset: 0x0012B4FC
		public DataCol ChildColumn
		{
			get
			{
				return this.oo_.000o0Oo0.[0];
			}
		}

		/// <summary>
		/// 关联名
		/// </summary>
		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x0012D306 File Offset: 0x0012B506
		public string Name
		{
			get
			{
				return this.o.0OoO..RelationName;
			}
		}

		/// <summary>
		/// 是否同步删除关联行
		/// </summary>
		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0012D313 File Offset: 0x0012B513
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0012D320 File Offset: 0x0012B520
		public bool CascadeDelete
		{
			get
			{
				return this.o.0OoO..o.O0_o.();
			}
			set
			{
				this.o.0OoO..o.O0_o.(value);
			}
		}

		/// <summary>
		/// 是否同步更新关联列内容
		/// </summary>
		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0012D32E File Offset: 0x0012B52E
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x0012D33B File Offset: 0x0012B53B
		public bool CascadeUpdate
		{
			get
			{
				return this.o.0OoO..oo0__.0Oo0o_.();
			}
			set
			{
				this.o.0OoO..oo0__.0Oo0o_.(value);
			}
		}

		/// <summary>
		/// 返回关联表生成模式
		/// </summary>
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0012D349 File Offset: 0x0012B549
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x0012D356 File Offset: 0x0012B556
		public RelationPathEnum RelationPath
		{
			get
			{
				return this.o.0OoO..oo0__.0Oo0o_.();
			}
			set
			{
				this.o.0OoO..oo0__.0Oo0o_.(value);
			}
		}

		// Token: 0x04001187 RID: 4487
		private DataCol[] <<EMPTY_NAME>>;

		// Token: 0x04001188 RID: 4488
		private DataCol[] <<EMPTY_NAME>>;

		// Token: 0x04001189 RID: 4489
		private O0Oo <<EMPTY_NAME>>;
	}
}
