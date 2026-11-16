using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000230 RID: 560
	[oO0oooo("A0063")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wTable : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x000BCC37 File Offset: 0x000BAE37
		public wTable(string A_0, string A_1) : base(A_0, A_1)
		{
			this.O_0oo._0O0. = new wRowCollection();
			this.Oo__.o0_O. = new wRowCollection();
			this.O_o_0.o___00. = new wRowCollection();
			this.Oo__.o0_O. = "●○";
			this.OOOOoO._0_O. = -1;
		}

		/// <summary>
		/// 表头
		/// </summary>
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x000BCC74 File Offset: 0x000BAE74
		[oO0oooo("A0064")]
		public wRowCollection Head
		{
			get
			{
				return this.O_0oo._0O0.;
			}
		}

		/// <summary>
		/// 表体
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000BCC7C File Offset: 0x000BAE7C
		public wRowCollection Body
		{
			get
			{
				return this.Oo__.o0_O.;
			}
		}

		/// <summary>
		/// 表尾
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x000BCC84 File Offset: 0x000BAE84
		public wRowCollection Foot
		{
			get
			{
				return this.O_o_0.o___00.;
			}
		}

		/// <summary>
		/// 用于设置行列的高亮显示方式
		/// </summary>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x000BCC8C File Offset: 0x000BAE8C
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x000BCC94 File Offset: 0x000BAE94
		[oO0oooo("A0069")]
		public int Highlight
		{
			get
			{
				return this.O_0oo._0O0.;
			}
			set
			{
				this.O_0oo._0O0. = value;
			}
		}

		/// <summary>
		/// 设置交替行显示
		/// </summary>
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x000BCC9D File Offset: 0x000BAE9D
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x000BCCA5 File Offset: 0x000BAEA5
		[oO0oooo("A0070")]
		public int Alternate
		{
			get
			{
				return this.Oo__.o0_O.;
			}
			set
			{
				this.Oo__.o0_O. = value;
			}
		}

		/// <summary>
		/// 设置合并列数量
		/// </summary>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000BCCAE File Offset: 0x000BAEAE
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x000BCCB6 File Offset: 0x000BAEB6
		[oO0oooo("A0065")]
		public int MergeCols
		{
			get
			{
				return this.oOoOoo0.OO_O.;
			}
			set
			{
				this.oOoOoo0.OO_O. = value;
			}
		}

		/// <summary>
		/// 设置行头列数量，行头列通常用于显示行号
		/// </summary>
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000BCCBF File Offset: 0x000BAEBF
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x000BCCC7 File Offset: 0x000BAEC7
		[oO0oooo("A0066")]
		public int RowHead
		{
			get
			{
				return this.OOooO_o0.o.;
			}
			set
			{
				this.OOooO_o0.o. = value;
			}
		}

		/// <summary>
		/// 用于设置列宽
		/// </summary>
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000BCCD0 File Offset: 0x000BAED0
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x000BCCD8 File Offset: 0x000BAED8
		[oO0oooo("A0071")]
		public string ColWidth
		{
			get
			{
				return this.O_0oo._0O0.;
			}
			set
			{
				this.O_0oo._0O0. = value;
			}
		}

		/// <summary>
		/// 设置逻辑值的替代显示符号, 默认True用符号●代替，False用符号○代替
		/// </summary>
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x000BCCE1 File Offset: 0x000BAEE1
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x000BCCE9 File Offset: 0x000BAEE9
		[oO0oooo("A0074")]
		public string BooleanSymbol
		{
			get
			{
				return this.Oo__.o0_O.;
			}
			set
			{
				if (value != null && value.Length == 2)
				{
					this.Oo__.o0_O. = value;
				}
			}
		}

		/// <summary>
		/// 设置主键列
		/// </summary>
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x000BCCFE File Offset: 0x000BAEFE
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x000BCD06 File Offset: 0x000BAF06
		[oO0oooo("A0118")]
		public string Primarykey
		{
			get
			{
				return this.OOooO_o0.o.;
			}
			set
			{
				this.OOooO_o0.o. = value;
			}
		}

		/// <summary>
		/// 设置页码
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x000BCD0F File Offset: 0x000BAF0F
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x000BCD17 File Offset: 0x000BAF17
		[oO0oooo("A0118")]
		public int PageNumber
		{
			get
			{
				return this.OOOOoO._0_O.;
			}
			set
			{
				this.OOOOoO._0_O. = value;
			}
		}

		/// <summary>
		/// 设置表格的菜单
		/// </summary>
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000BCD20 File Offset: 0x000BAF20
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x000BCD28 File Offset: 0x000BAF28
		[oO0oooo("A0117")]
		public string ActiveSheet
		{
			get
			{
				return this.oOoOoo0.OO_O.;
			}
			set
			{
				this.oOoOoo0.OO_O. = value;
			}
		}

		/// <summary>
		/// 指定在表格中选择不同单元格后，要执行的js事件代码
		/// </summary>
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000BCD31 File Offset: 0x000BAF31
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x000BCD39 File Offset: 0x000BAF39
		[oO0oooo("A0147")]
		public string AfterSelChange
		{
			get
			{
				return this.OoO_O.o0.;
			}
			set
			{
				this.OoO_O.o0. = value;
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000BCD44 File Offset: 0x000BAF44
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append(string.Concat(new string[]
			{
				"<table id='",
				base.ID,
				"' name='",
				base.ID,
				"' class='fox_table"
			}));
			switch (this.Highlight)
			{
			case 0:
				A_0.Append(" fox_highligh_row fox_highligh_col");
				break;
			case 1:
				A_0.Append(" fox_highligh_row");
				break;
			case 2:
				A_0.Append(" fox_highligh_col");
				break;
			}
			A_0.Append("'");
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.Append(" data-fixed='" + Conversions.ToString(this.O_0oo._0O0..Count) + "'");
			if (this.O_0oo._0O0..Count > 0)
			{
				A_0.Append(" data-cols='" + Conversions.ToString(this.O_0oo._0O0.[0].o0oO._0o0_O..Count) + "'");
			}
			else if (this.Oo__.o0_O..Count > 0)
			{
				A_0.Append(" data-cols='" + Conversions.ToString(this.Oo__.o0_O.[0].o0oO._0o0_O..Count) + "'");
			}
			else if (this.O_o_0.o___00..Count > 0)
			{
				A_0.Append(" data-cols='" + Conversions.ToString(this.O_o_0.o___00.[0].o0oO._0o0_O..Count) + "'");
			}
			if (Operators.CompareString(this.oOoOoo0.OO_O., "", true) > 0)
			{
				A_0.Append(" data-activesheet='" + this.oOoOoo0.OO_O. + "'");
			}
			if (this.OOOOoO._0_O. >= 0)
			{
				A_0.Append(" data-pagenumber='" + Conversions.ToString(this.OOOOoO._0_O.) + "'");
			}
			if (Operators.CompareString(this.OoO_O.o0., "", true) > 0)
			{
				A_0.Append(" data-afterselchange='" + this.OoO_O.o0. + "'");
			}
			A_0.AppendLine(">");
			if (this.O_0oo._0O0..Count > 0)
			{
				A_0.AppendLine("<thead>");
				int num = this.O_0oo._0O0..Count - 1;
				for (int i = 0; i <= num; i++)
				{
					wTableRow wTableRow = this.O_0oo._0O0.[i];
					wTableRow.o0oO._0o0_O. = true;
					wTableRow.OOooOo.00OO_.(A_0, i, this.O_0oo._0O0., this.oOoOoo0.OO_O., false, 0, this.ColWidth);
				}
				A_0.AppendLine("</thead>");
			}
			if (this.Oo__.o0_O..Count > 0)
			{
				A_0.AppendLine("<tbody>");
				int num2 = this.Oo__.o0_O..Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					this.Oo__.o0_O.[j].OOooOo.00OO_.(A_0, j, this.Oo__.o0_O., this.oOoOoo0.OO_O., this.o0OO0.oo0OO.(j), this.OOooO_o0.o., "");
				}
				A_0.AppendLine("</tbody>");
			}
			if (this.O_o_0.o___00..Count > 0)
			{
				A_0.AppendLine("<tfoot>");
				int num3 = this.O_o_0.o___00..Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					this.O_o_0.o___00.[k].OOooOo.00OO_.(A_0, k, this.O_o_0.o___00., this.oOoOoo0.OO_O., false, this.OOooO_o0.o., "");
				}
				A_0.AppendLine("</tfoot>");
			}
			A_0.AppendLine("</table>");
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000BD118 File Offset: 0x000BB318
		private bool <<EMPTY_NAME>>(int A_0)
		{
			return this.Alternate >= 2 && (A_0 + 1) % this.Alternate == 0;
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Filter">可选参数，指定筛选条件表达式</param>
		/// <param name="Sort">可选参数，指定排序列</param>
		/// <param name="dataCols">可选参数，指定要显示的列</param>
		// Token: 0x06001AB8 RID: 6840 RVA: 0x000BD144 File Offset: 0x000BB344
		[oO0oooo("0074")]
		public void CreateFromDataTable(DataTable dataTable, bool RowNum, string Filter, string Sort, params string[] dataCols)
		{
			if (RowNum)
			{
				this.RowHead = 1;
			}
			int num;
			foreach (string text in dataCols)
			{
				string text2 = text;
				if (Operators.CompareString(dataTable.DataCols[text].Caption, "", true) > 0)
				{
					text2 = dataTable.DataCols[text].Caption;
				}
				num = Math.Max(num, text2.Split(new char[]
				{
					'_'
				}).Length);
			}
			int num2 = num - 1;
			for (int j = 0; j <= num2; j++)
			{
				List<string> list = new List<string>();
				if (RowNum)
				{
					list.Add("");
				}
				foreach (string text3 in dataCols)
				{
					string text4 = text3;
					if (Operators.CompareString(dataTable.DataCols[text3].Caption, "", true) > 0)
					{
						text4 = dataTable.DataCols[text3].Caption;
					}
					string[] array = text4.Split(new char[]
					{
						'_'
					});
					if (array.Length > j)
					{
						list.Add(array[j]);
					}
					else
					{
						list.Add(array[array.Length - 1]);
					}
				}
				this.Head.AddRow(list);
			}
			DataColumn dataColumn = null;
			if (Operators.CompareString(this.Primarykey, "", true) > 0)
			{
				dataColumn = dataTable.BaseTable.Columns[this.Primarykey];
			}
			try
			{
				foreach (DataRow dataRow in dataTable.Select(Filter, Sort))
				{
					int num3;
					num3++;
					wTableRow wTableRow = this.Body.AddRow(new string[0]);
					if (dataColumn != null)
					{
						wTableRow.OOooO_o0.o. = dataRow.BaseRow[dataColumn].ToString();
					}
					if (RowNum)
					{
						wTableRow.AddCell(num3.ToString(), "");
					}
					foreach (string text5 in dataCols)
					{
						if (dataRow.get_IsNull(text5))
						{
							wTableRow.AddCell("", "");
						}
						else if (dataTable.DataCols[text5].IsBoolean)
						{
							if (Conversions.ToBoolean(dataRow[text5]))
							{
								wTableRow.AddCell(Conversions.ToString(this.BooleanSymbol[0]), "");
							}
							else
							{
								wTableRow.AddCell(Conversions.ToString(this.BooleanSymbol[1]), "");
							}
						}
						else if (dataTable.DataCols[text5].IsDate)
						{
							wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow[text5]), "yyyy-MM-dd"), "");
						}
						else
						{
							string name = dataTable.DataCols[text5].DataType.Name;
							if (Operators.CompareString(name, "single", true) == 0 || Operators.CompareString(name, "double", true) == 0 || Operators.CompareString(name, "decimal", true) == 0)
							{
								if (dataTable.DataCols[text5].BaseColumn.ExtendedProperties.Contains("displayformat"))
								{
									wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow[text5]), dataTable.DataCols[text5].BaseColumn.ExtendedProperties["displayformat"].ToString()), "");
								}
								else
								{
									wTableRow.AddCell(Strings.Format(RuntimeHelpers.GetObjectValue(dataRow[text5]), "#0.00"), "");
								}
							}
							else
							{
								wTableRow.AddCell(dataRow[text5].ToString(), "");
							}
						}
					}
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Filter">可选参数，指定筛选条件表达式</param>
		/// <param name="Sort">可选参数，指定排序列</param>
		/// <param name="dataCols">可选参数，指定要显示的列</param>
		// Token: 0x06001AB9 RID: 6841 RVA: 0x000BD54C File Offset: 0x000BB74C
		public void CreateFromDataTable(DataTable dataTable, bool RowNum, string Filter, string Sort, List<string> dataCols)
		{
			this.CreateFromDataTable(dataTable, RowNum, Filter, Sort, dataCols.ToArray());
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Filter">可选参数，指定筛选条件表达式</param>
		/// <param name="Sort">可选参数，指定排序列</param>
		// Token: 0x06001ABA RID: 6842 RVA: 0x000BD560 File Offset: 0x000BB760
		public void CreateFromDataTable(DataTable dataTable, bool RowNum, string Filter, string Sort)
		{
			List<string> list = new List<string>();
			try
			{
				foreach (DataCol dataCol in dataTable.DataCols)
				{
					list.Add(dataCol.Name);
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
			this.CreateFromDataTable(dataTable, RowNum, Filter, Sort, list.ToArray());
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Filter">可选参数，指定筛选条件表达式</param>
		// Token: 0x06001ABB RID: 6843 RVA: 0x000BD5CC File Offset: 0x000BB7CC
		public void CreateFromDataTable(DataTable dataTable, bool RowNum, string Filter)
		{
			this.CreateFromDataTable(dataTable, RowNum, Filter, "");
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		// Token: 0x06001ABC RID: 6844 RVA: 0x000BD5DC File Offset: 0x000BB7DC
		public void CreateFromDataTable(DataTable dataTable, bool RowNum)
		{
			this.CreateFromDataTable(dataTable, RowNum, "", "");
		}

		/// <summary>
		/// 根据DataTable生成表格
		/// </summary>
		/// <param name="dataTable">DataTable类型，根据此DataTable生成表格</param>
		// Token: 0x06001ABD RID: 6845 RVA: 0x000BD5F0 File Offset: 0x000BB7F0
		public void CreateFromDataTable(DataTable dataTable)
		{
			this.CreateFromDataTable(dataTable, false, "", "");
		}

		/// <summary>
		/// 根据Table生成表格
		/// </summary>
		/// <param name="table">Table类型，根据此Table生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Cols">可选参数，用于指定要显示的列</param>
		// Token: 0x06001ABE RID: 6846 RVA: 0x000BD604 File Offset: 0x000BB804
		public void CreateFromTable(Table table, bool RowNum, params string[] Cols)
		{
			if (RowNum)
			{
				this.RowHead = 1;
			}
			int num = table.Grid.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				List<string> list = new List<string>();
				if (RowNum)
				{
					if (i < table.Grid.Rows.Fixed)
					{
						list.Add("");
					}
					else
					{
						list.Add((i - table.Grid.Rows.Fixed + 1).ToString());
					}
				}
				foreach (string text in Cols)
				{
					if (table.Cols[text].IsBoolean() && i >= table.Grid.Rows.Fixed)
					{
						if (table.Grid.GetCellCheck(i, table.Grid.Cols[text].Index) == CheckEnum.Checked)
						{
							list.Add(Conversions.ToString(this.BooleanSymbol[0]));
						}
						else
						{
							list.Add(Conversions.ToString(this.BooleanSymbol[1]));
						}
					}
					else
					{
						list.Add(table.Grid.GetDataDisplay(i, text).ToString());
					}
				}
				if (i < table.Grid.Rows.Fixed)
				{
					this.Head.AddRow(list.ToArray());
				}
				else
				{
					this.Body.AddRow(list.ToArray());
				}
			}
		}

		/// <summary>
		/// 根据Table生成表格
		/// </summary>
		/// <param name="table">Table类型，根据此Table生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="Cols">可选参数，用于指定要显示的列</param>
		// Token: 0x06001ABF RID: 6847 RVA: 0x000BD77A File Offset: 0x000BB97A
		public void CreateFromTable(Table table, bool RowNum, List<string> Cols)
		{
			this.CreateFromTable(table, RowNum, Cols.ToArray());
		}

		/// <summary>
		/// 根据Table生成表格
		/// </summary>
		/// <param name="table">Table类型，根据此Table生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		/// <param name="OnlyVisible">是否只包括可见列</param>
		// Token: 0x06001AC0 RID: 6848 RVA: 0x000BD78C File Offset: 0x000BB98C
		public void CreateFromTable(Table table, bool RowNum, bool OnlyVisible)
		{
			List<string> list = new List<string>();
			int num = table.Cols.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (table.Cols[i].Visible)
				{
					list.Add(table.Cols[i].Name);
				}
			}
			this.CreateFromTable(table, RowNum, list.ToArray());
		}

		/// <summary>
		/// 根据Table生成表格
		/// </summary>
		/// <param name="table">Table类型，根据此Table生成表格</param>
		/// <param name="RowNum">可选参数，逻辑型，是否显示行号</param>
		// Token: 0x06001AC1 RID: 6849 RVA: 0x000BD7FC File Offset: 0x000BB9FC
		public void CreateFromTable(Table table, bool RowNum)
		{
			List<string> list = new List<string>();
			int num = table.Cols.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				list.Add(table.Cols[i].Name);
			}
			this.CreateFromTable(table, RowNum, list.ToArray());
		}

		/// <summary>
		/// 根据Table生成表格
		/// </summary>
		/// <param name="table">Table类型，根据此Table生成表格</param>
		// Token: 0x06001AC2 RID: 6850 RVA: 0x000BD853 File Offset: 0x000BBA53
		public void CreateFromTable(Table table)
		{
			this.CreateFromTable(table, false);
		}

		// Token: 0x04000B40 RID: 2880
		private wRowCollection <<EMPTY_NAME>>;

		// Token: 0x04000B41 RID: 2881
		private wRowCollection <<EMPTY_NAME>>;

		// Token: 0x04000B42 RID: 2882
		private wRowCollection <<EMPTY_NAME>>;

		// Token: 0x04000B43 RID: 2883
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B44 RID: 2884
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B45 RID: 2885
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B46 RID: 2886
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B47 RID: 2887
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B48 RID: 2888
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B49 RID: 2889
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B4A RID: 2890
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B4B RID: 2891
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B4C RID: 2892
		private string <<EMPTY_NAME>>;
	}
}
