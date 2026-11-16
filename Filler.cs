using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 数据填充器
	/// </summary>
	// Token: 0x02000297 RID: 663
	[oO0oooo("0680")]
	public class Filler
	{
		// Token: 0x06002150 RID: 8528 RVA: 0x000E9BA7 File Offset: 0x000E7DA7
		public Filler()
		{
			this.oo.0O_O. = true;
			this.o_0.00. = true;
		}

		/// <summary>
		/// 数据来源表
		/// </summary>
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000E9BBD File Offset: 0x000E7DBD
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x000E9BC5 File Offset: 0x000E7DC5
		public DataTable SourceTable
		{
			get
			{
				return this.O._00000.;
			}
			set
			{
				this.O._00000. = value;
			}
		}

		/// <summary>
		/// 数据接收表
		/// </summary>
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000E9BCE File Offset: 0x000E7DCE
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x000E9BD6 File Offset: 0x000E7DD6
		public DataTable DataTable
		{
			get
			{
				return this.OOo__OO.0_00.;
			}
			set
			{
				this.OOo__OO.0_00. = value;
			}
		}

		/// <summary>
		/// 数据来源列，不同的列用逗号分割
		/// </summary>
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000E9BE0 File Offset: 0x000E7DE0
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x000E9CA4 File Offset: 0x000E7EA4
		public string SourceCols
		{
			get
			{
				string result;
				if (Operators.CompareString(this.O._0o., "", true) > 0)
				{
					result = this.O._0o.;
				}
				else if (Operators.CompareString(this.OOo__OO.0_00., "", true) > 0)
				{
					result = this.OOo__OO.0_00.;
				}
				else
				{
					string text = "";
					try
					{
						foreach (DataCol dataCol in this.SourceTable.DataCols)
						{
							if (this.DataTable.DataCols.Contains(dataCol.Name))
							{
								text = text + "," + dataCol.Name;
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
					result = text.Substring(1);
				}
				return result;
			}
			set
			{
				this.O._0o. = value;
			}
		}

		/// <summary>
		/// 数据接收列，不同的列用逗号分割
		/// </summary>
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x000E9D74 File Offset: 0x000E7F74
		public string DataCols
		{
			get
			{
				string result;
				if (Operators.CompareString(this.OOo__OO.0_00., "", true) > 0)
				{
					result = this.OOo__OO.0_00.;
				}
				else if (Operators.CompareString(this.O._0o., "", true) > 0)
				{
					result = this.O._0o.;
				}
				else
				{
					string text = "";
					try
					{
						foreach (DataCol dataCol in this.SourceTable.DataCols)
						{
							if (this.DataTable.DataCols.Contains(dataCol.Name))
							{
								text = text + "," + dataCol.Name;
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
					result = text.Substring(1);
				}
				return result;
			}
			set
			{
				this.OOo__OO.0_00. = value;
			}
		}

		/// <summary>
		/// 填充条件
		/// </summary>
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000E9D7D File Offset: 0x000E7F7D
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x000E9D85 File Offset: 0x000E7F85
		public string Filter
		{
			get
			{
				return this.oo.0O_O.;
			}
			set
			{
				this.oo.0O_O. = value;
			}
		}

		/// <summary>
		/// 是否排除接收表中已经存在的内容
		/// </summary>
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000E9D8E File Offset: 0x000E7F8E
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x000E9D96 File Offset: 0x000E7F96
		public bool ExcludeExistValue
		{
			get
			{
				return this.O._0o.;
			}
			set
			{
				this.O._0o. = value;
			}
		}

		/// <summary>
		/// 是否排除空白值
		/// </summary>
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000E9D9F File Offset: 0x000E7F9F
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x000E9DA7 File Offset: 0x000E7FA7
		public bool ExcludeNullValue
		{
			get
			{
				return this.OOo__OO.0_00.;
			}
			set
			{
				this.OOo__OO.0_00. = value;
			}
		}

		/// <summary>
		/// 是否排除重复内容
		/// </summary>
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000E9DB0 File Offset: 0x000E7FB0
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x000E9DB8 File Offset: 0x000E7FB8
		public bool Distinct
		{
			get
			{
				return this.oo.0O_O.;
			}
			set
			{
				this.oo.0O_O. = value;
			}
		}

		/// <summary>
		/// 是否在原有数据之后填充，如果设置为False，则会清空原有数据
		/// </summary>
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000E9DC1 File Offset: 0x000E7FC1
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x000E9DC9 File Offset: 0x000E7FC9
		public bool Append
		{
			get
			{
				return this.o_0.00.;
			}
			set
			{
				this.o_0.00. = value;
			}
		}

		/// <summary>
		/// 开始填充
		/// </summary>
		// Token: 0x06002163 RID: 8547 RVA: 0x000E9DD2 File Offset: 0x000E7FD2
		public void Fill()
		{
			if (this.Distinct)
			{
				this.OOo__OO.0_00.();
				return;
			}
			this.OOo__OO.0_00.();
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x000E9DE9 File Offset: 0x000E7FE9
		internal void <<EMPTY_NAME>>()
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x000E9DEC File Offset: 0x000E7FEC
		internal void <<EMPTY_NAME>>()
		{
			string[] array = this.SourceCols.Split(new char[]
			{
				','
			});
			string text = array[0];
			int num = array.Length - 1;
			for (int i = 1; i <= num; i++)
			{
				text = text + "," + array[i];
			}
			DataView dataView = new DataView(this.SourceTable.BaseTable, this.Filter, text, DataViewRowState.CurrentRows);
			string[] array2 = this.DataCols.Split(new char[]
			{
				','
			});
			string text2 = array2[0];
			int num2 = array2.Length - 1;
			for (int j = 1; j <= num2; j++)
			{
				text2 = text2 + "," + array2[j];
			}
			DataView dataView2 = new DataView(this.DataTable.BaseTable, "", text2, DataViewRowState.CurrentRows);
			int num3 = 0;
			object[] array3 = new object[array2.Length - 1 + 1];
			int count = this.DataTable.BaseTable.Rows.Count;
			List<Table> list = new List<Table>();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this.DataTable && table.foxGrid.AllowAddNew)
					{
						list.Add(table);
						table.foxGrid.AllowAddNew = false;
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			OO_00oOO.LockBaseMainForm();
			this.DataTable.StopRedraw();
			try
			{
				DataTable dataTable = this.DataTable.BaseTable;
				int num4 = dataView.Count - 1;
				int k = 0;
				while (k <= num4)
				{
					if (!this.Distinct || k <= 0)
					{
						goto IL_1E7;
					}
					bool flag = true;
					int num5 = array.Length - 1;
					for (int l = 0; l <= num5; l++)
					{
						if (Operators.CompareString(dataView[k][array[l]].ToString(), dataView[k - 1][array[l]].ToString(), true) != 0)
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						goto IL_1E7;
					}
					IL_2DB:
					k++;
					continue;
					IL_1E7:
					bool flag2 = false;
					int num6 = array.Length - 1;
					for (int m = 0; m <= num6; m++)
					{
						if (this.ExcludeNullValue && dataView[k].Row.IsNull(array[m]))
						{
							flag2 = true;
							break;
						}
						array3[m] = RuntimeHelpers.GetObjectValue(dataView[k][array[m]]);
					}
					if ((this.ExcludeNullValue && flag2) || (this.ExcludeExistValue && dataView2.Find(array3) >= 0))
					{
						goto IL_2DB;
					}
					num3++;
					DataRow dataRow;
					if (!this.Append && num3 <= count)
					{
						dataRow = dataTable.Rows[num3 - 1];
					}
					else
					{
						dataRow = dataTable.NewRow();
					}
					int num7 = array2.Length - 1;
					for (int n = 0; n <= num7; n++)
					{
						dataRow[array2[n]] = RuntimeHelpers.GetObjectValue(array3[n]);
					}
					if (dataRow.RowState == DataRowState.Detached)
					{
						dataTable.Rows.Add(dataRow);
						goto IL_2DB;
					}
					goto IL_2DB;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				try
				{
					foreach (Table table2 in list)
					{
						table2.foxGrid.AllowAddNew = true;
					}
				}
				finally
				{
					List<Table>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.DataTable.ResumeRedraw();
				OO_00oOO.UnlockBaseMainForm();
			}
		}

		// Token: 0x04000DEE RID: 3566
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000DEF RID: 3567
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000DF0 RID: 3568
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DF1 RID: 3569
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DF2 RID: 3570
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DF3 RID: 3571
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DF4 RID: 3572
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DF5 RID: 3573
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DF6 RID: 3574
		private bool <<EMPTY_NAME>>;
	}
}
