using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 内联分组统计工具
	/// </summary>
	// Token: 0x020000AB RID: 171
	[oO0oooo("3367")]
	[ComVisible(true)]
	public class InlineGroupTableBuilder
	{
		/// <summary>
		/// 要生成的统计表名称
		/// </summary>
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00030FB9 File Offset: 0x0002F1B9
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00030FC1 File Offset: 0x0002F1C1
		public string TableName { get; set; }

		/// <summary>
		/// 被统计的数据表
		/// </summary>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00030FCA File Offset: 0x0002F1CA
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00030FD2 File Offset: 0x0002F1D2
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 父列
		/// </summary>
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00030FDB File Offset: 0x0002F1DB
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00030FE3 File Offset: 0x0002F1E3
		public string ParentCol { get; set; }

		/// <summary>
		/// 子列
		/// </summary>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00030FEC File Offset: 0x0002F1EC
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00030FF4 File Offset: 0x0002F1F4
		public string ChildCol { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00030FFD File Offset: 0x0002F1FD
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00031005 File Offset: 0x0002F205
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal List<o0o_> Totals { get; set; }

		/// <summary>
		/// 统计条件表达式
		/// </summary>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0003100E File Offset: 0x0002F20E
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00031016 File Offset: 0x0002F216
		public string Filter { get; set; }

		/// <summary>
		/// 是否将父列添加到统计表中
		/// </summary>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0003101F File Offset: 0x0002F21F
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00031027 File Offset: 0x0002F227
		public bool IncludeParentCol { get; set; }

		/// <summary>
		/// 生成的统计表是否默认开启折叠模式
		/// </summary>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00031030 File Offset: 0x0002F230
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00031038 File Offset: 0x0002F238
		public bool GridTree { get; set; }

		/// <summary>
		/// 指定折叠树默认展开到第几级
		/// </summary>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00031041 File Offset: 0x0002F241
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00031049 File Offset: 0x0002F249
		public int ExpandTo { get; set; }

		/// <summary>
		/// 统计表是否只保留分组行
		/// </summary>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00031052 File Offset: 0x0002F252
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0003105A File Offset: 0x0002F25A
		public bool OnlyGroupRows { get; set; }

		/// <summary>
		/// 指定统计统计表保留到第几级分组行
		/// </summary>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00031063 File Offset: 0x0002F263
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0003106B File Offset: 0x0002F26B
		public int PreserveTo { get; set; }

		/// <summary>
		/// 统计表的折叠树是否显示在父列
		/// </summary>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00031074 File Offset: 0x0002F274
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0003107C File Offset: 0x0002F27C
		public bool ShowTreeInParentCol { get; set; }

		/// <summary>
		/// 用于附加数据列
		/// </summary>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00031085 File Offset: 0x0002F285
		[oO0oooo("3699")]
		public MRPExtendTables Additions { get; }

		/// <param name="TableName">要生成的统计表名称</param>
		/// <param name="SourceTable">被统计的数据表</param>
		// Token: 0x060006BD RID: 1725 RVA: 0x00031090 File Offset: 0x0002F290
		public InlineGroupTableBuilder(string A_0, DataTable A_1)
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.OO_Oo.0oO. = new HashSet<string>();
			this.TableName = A_0;
			this.DataTable = A_1;
		}

		/// <param name="TableName">要生成的统计表名称</param>
		// Token: 0x060006BE RID: 1726 RVA: 0x000310E0 File Offset: 0x0002F2E0
		public InlineGroupTableBuilder(string A_0)
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.OO_Oo.0oO. = new HashSet<string>();
			this.TableName = A_0;
			this.DataTable = this.DataTable;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00031135 File Offset: 0x0002F335
		public InlineGroupTableBuilder()
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.OO_Oo.0oO. = new HashSet<string>();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0003116C File Offset: 0x0002F36C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Build(params object[] args)
		{
			if (args.Length == 0)
			{
				this.Build();
				return;
			}
			if (args.Length == 1)
			{
				this.Build(Conversions.ToBoolean(args[0]));
			}
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		// Token: 0x060006C1 RID: 1729 RVA: 0x00031190 File Offset: 0x0002F390
		public DataTable Build()
		{
			return this.Build(false);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0003119C File Offset: 0x0002F39C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTotal(params object[] args)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
			string newName = Conversions.ToString(args[1]);
			if (!(objectValue is bool))
			{
				if (objectValue is string)
				{
					string column = Conversions.ToString(objectValue);
					switch (args.Length)
					{
					case 2:
						this.AddTotal(column, newName);
						return;
					case 3:
					{
						AggregateRange aggregateRange = (AggregateRange)Conversions.ToInteger(args[2]);
						this.AddTotal(column, newName, aggregateRange);
						return;
					}
					case 4:
					{
						AggregateRange aggregateRange2 = (AggregateRange)Conversions.ToInteger(args[2]);
						AggregateType aggregateType = (AggregateType)Conversions.ToInteger(args[3]);
						this.AddTotal(column, newName, aggregateRange2, aggregateType);
						break;
					}
					default:
						return;
					}
				}
				return;
			}
			bool count = Conversions.ToBoolean(objectValue);
			int num = args.Length;
			if (num == 2)
			{
				this.AddTotal(count, newName);
				return;
			}
			if (num != 3)
			{
				return;
			}
			AggregateRange aggregateRange3 = (AggregateRange)Conversions.ToInteger(args[2]);
			this.AddTotal(count, newName, aggregateRange3);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Column">指定要统计的数据列</param>
		/// <param name="newName">为生成的统计结果指定一个列名</param>
		// Token: 0x060006C3 RID: 1731 RVA: 0x00031261 File Offset: 0x0002F461
		public void AddTotal(string Column, string newName)
		{
			this.AddTotal(Column, newName, AggregateRange.Both, AggregateType.Sum);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Column">指定要统计的数据列</param>
		/// <param name="newName">为生成的统计结果指定一个列名</param>&gt;
		/// <param name="AggregateRange">指定统计范围</param>
		// Token: 0x060006C4 RID: 1732 RVA: 0x0003126D File Offset: 0x0002F46D
		public void AddTotal(string Column, string newName, AggregateRange AggregateRange)
		{
			this.AddTotal(Column, newName, AggregateRange, AggregateType.Sum);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00031279 File Offset: 0x0002F479
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTotal(string Column, string newName, int AggregateRange)
		{
			this.AddTotal(Column, newName, (AggregateRange)AggregateRange);
		}

		/// <summary>
		/// 增加统计列
		/// </summary>
		/// <param name="Column">指定要统计的数据列</param>
		/// <param name="newName">为生成的统计结果指定一个列名</param>&gt;
		/// <param name="AggregateRange">指定统计范围</param>
		/// <param name="AggregateType">指定统计类型</param>
		// Token: 0x060006C6 RID: 1734 RVA: 0x00031284 File Offset: 0x0002F484
		public void AddTotal(string Column, string newName, AggregateRange AggregateRange, AggregateType AggregateType)
		{
			if (!this.OO_Oo.0oO..Contains(newName))
			{
				this.OO_Oo.0oO..Add(newName);
				this.Totals.Add(new o0o_(Column, newName, AggregateRange, AggregateType));
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000312B6 File Offset: 0x0002F4B6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTotal(string Column, string newName, int AggregateRange, int AggregateType)
		{
			this.AddTotal(Column, newName, (AggregateRange)AggregateRange, (AggregateType)AggregateType);
		}

		/// <summary>
		/// 增加记录数统计列
		/// </summary>
		/// <param name="Count">如果要进行记录数统计，请将此参数设置为True</param>
		/// <param name="newName">为生成的统计结果指定一个列名</param>
		// Token: 0x060006C8 RID: 1736 RVA: 0x000312C3 File Offset: 0x0002F4C3
		public void AddTotal(bool Count, string newName)
		{
			this.AddTotal(true, newName, AggregateRange.Both);
		}

		/// <summary>
		/// 增加记录数统计列
		/// </summary>
		/// <param name="Count">如果要进行记录数统计，请将此参数设置为True</param>
		/// <param name="newName">为生成的统计结果指定一个列名</param>
		/// <param name="AggregateRange">指定统计范围</param>
		// Token: 0x060006C9 RID: 1737 RVA: 0x000312CE File Offset: 0x0002F4CE
		public void AddTotal(bool Count, string newName, AggregateRange AggregateRange)
		{
			if (!this.OO_Oo.0oO..Contains(newName))
			{
				this.OO_Oo.0oO..Add(newName);
				this.Totals.Add(new o0o_(true, newName, AggregateRange));
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000312FE File Offset: 0x0002F4FE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTotal(bool Count, string newName, int AggregateRange)
		{
			this.AddTotal(Count, newName, (AggregateRange)AggregateRange);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTab,不生成Table</param>
		// Token: 0x060006CB RID: 1739 RVA: 0x0003130C File Offset: 0x0002F50C
		public DataTable Build(bool OnlyDataTable)
		{
			int num;
			DataTable result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.TableName, "", true) != 0)
				{
					goto IL_2E;
				}
				IL_1C:
				num2 = 3;
				this.TableName = Oo00.oo0o.O0O_0__.("统计表");
				IL_2E:
				num2 = 4;
				if (!OO_00oOO.DataTables.Contains(this.TableName) || OnlyDataTable)
				{
					goto IL_B3;
				}
				IL_45:
				num2 = 5;
				if (!OO_00oOO.DataTables[this.TableName].AddByCode)
				{
					goto IL_70;
				}
				IL_5E:
				num2 = 6;
				OO_00oOO.DataTables.Delete(this.TableName);
				IL_70:
				num2 = 7;
				if (!OO_00oOO.DataTables.Contains(this.TableName))
				{
					goto IL_B3;
				}
				IL_84:
				num2 = 8;
				MessageBox.Show("表" + this.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_A9:
				num2 = 9;
				result = null;
				goto IL_504;
				IL_B3:
				num2 = 10;
				DataTable dataTable = this.o0o0000.O00o.();
				IL_BE:
				num2 = 11;
				dataTable.TableName = this.TableName;
				IL_CE:
				num2 = 12;
				if (!OnlyDataTable)
				{
					goto IL_101;
				}
				IL_D4:
				num2 = 13;
				DataTable dataTable2 = new DataTable(dataTable, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				IL_EC:
				num2 = 14;
				dataTable2.o.0O000_.();
				IL_F6:
				num2 = 15;
				result = dataTable2;
				goto IL_504;
				IL_101:
				num2 = 16;
				if (!this.OnlyGroupRows || dataTable.Rows.Count <= 0)
				{
					goto IL_2BC;
				}
				IL_121:
				num2 = 17;
				List<DataRow> list = new List<DataRow>();
				IL_12B:
				num2 = 18;
				int num3 = dataTable.Rows.Count - 2;
				for (int i = 1; i <= num3; i++)
				{
					IL_146:
					num2 = 19;
					if (Conversions.ToInteger(dataTable.Rows[i]["sys_Hierarchy_Level"]) == Conversions.ToInteger(dataTable.Rows[i + 1]["sys_Hierarchy_Level"]) && Conversions.ToInteger(dataTable.Rows[i]["sys_Hierarchy_Level"]) > 0)
					{
						IL_1A7:
						num2 = 20;
						list.Add(dataTable.Rows[i]);
					}
					else
					{
						IL_1C1:
						num2 = 22;
						if (Conversions.ToInteger(dataTable.Rows[i]["sys_Hierarchy_Level"]) > Conversions.ToInteger(dataTable.Rows[i + 1]["sys_Hierarchy_Level"]))
						{
							IL_202:
							num2 = 23;
							list.Add(dataTable.Rows[i]);
						}
					}
					IL_21A:
					num2 = 24;
				}
				IL_22C:
				num2 = 25;
				if (Conversions.ToInteger(dataTable.Rows[dataTable.Rows.Count - 1]["sys_Hierarchy_Level"]) <= 0)
				{
					goto IL_27F;
				}
				IL_25B:
				num2 = 26;
				list.Add(dataTable.Rows[dataTable.Rows.Count - 1]);
				IL_27F:
				num2 = 27;
				List<DataRow>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = enumerator.Current;
					IL_296:
					num2 = 28;
					dataRow.Delete();
					IL_2A0:
					num2 = 29;
				}
				IL_2AC:
				num2 = 30;
				((IDisposable)enumerator).Dispose();
				IL_2BC:
				num2 = 31;
				if (this.PreserveTo <= -1)
				{
					goto IL_32D;
				}
				IL_2C8:
				num2 = 32;
				new List<DataRow>();
				IL_2D1:
				num2 = 33;
				for (int j = dataTable.Rows.Count - 1; j >= 0; j += -1)
				{
					IL_2E6:
					num2 = 34;
					if (Conversions.ToInteger(dataTable.Rows[j]["sys_Hierarchy_Level"]) > this.PreserveTo)
					{
						IL_30E:
						num2 = 35;
						dataTable.Rows.RemoveAt(j);
					}
					IL_31F:
					num2 = 36;
				}
				IL_32D:
				num2 = 37;
				dataTable.AcceptChanges();
				IL_337:
				num2 = 38;
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
				IL_34B:
				num2 = 39;
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable, null, null, this.TableName, O_O0OO.OoO.0OO__0ooo.()));
				IL_36C:
				num2 = 40;
				OO_00oOO.DataTables[this.TableName].o.0O000_.();
				IL_384:
				num2 = 41;
				OO_00oOO.DataTables[this.TableName].AddByCode = true;
				IL_39D:
				num2 = 42;
				new O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables[this.TableName].BaseTable);
				IL_3C0:
				num2 = 43;
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
				IL_3DD:
				num2 = 44;
				Main.OO_O.o..o0_o_o_0.0O.(this.TableName, true, false);
				IL_3F2:
				num2 = 45;
				if (!this.ShowTreeInParentCol || !this.IncludeParentCol)
				{
					goto IL_443;
				}
				IL_405:
				num2 = 46;
				OO_00oOO.DataTables[this.TableName].OoOo_OoOO0.o. = this.ParentCol;
				IL_423:
				num2 = 47;
				OO_00oOO.Tables[this.TableName].OO0o_o0.0oOo0o. = this.ParentCol;
				goto IL_47F;
				IL_443:
				num2 = 49;
				OO_00oOO.DataTables[this.TableName].OoOo_OoOO0.o. = this.ChildCol;
				IL_461:
				num2 = 50;
				OO_00oOO.Tables[this.TableName].OO0o_o0.0oOo0o. = this.ChildCol;
				IL_47F:
				num2 = 51;
				OO_00oOO.DataTables[this.TableName].oOOO.OOO_0ooO0. = true;
				IL_498:
				num2 = 52;
				if (!this.GridTree)
				{
					goto IL_4F0;
				}
				IL_4A3:
				num2 = 53;
				OO_00oOO.Tables[this.TableName].HierarchyData = true;
				IL_4BC:
				num2 = 54;
				if (this.ExpandTo <= -1)
				{
					goto IL_4F0;
				}
				IL_4C8:
				num2 = 55;
				((O_oOooO_O)OO_00oOO.Tables[this.TableName].Grid).OoO._OOo__.(this.ExpandTo);
				IL_4F0:
				num2 = 56;
				result = OO_00oOO.DataTables[this.TableName];
				IL_504:
				goto IL_63A;
				IL_509:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_5FB:
				goto IL_62F;
				IL_5FD:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_60D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5FD;
			}
			IL_62F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_63A:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00031978 File Offset: 0x0002FB78
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x060006CD RID: 1741 RVA: 0x00031992 File Offset: 0x0002FB92
		public fxDataSource BuildDataSource()
		{
			return this.o0o0000.O00o.();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0003199C File Offset: 0x0002FB9C
		private fxDataSource <<EMPTY_NAME>>()
		{
			int num;
			fxDataSource result;
			int num12;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				fxDataSource fxDataSource = this.oO._O_0oO__0.();
				IL_11:
				num2 = 3;
				DataView a_ = new DataView(this.DataTable.BaseTable, this.Filter, this.ChildCol, DataViewRowState.CurrentRows);
				IL_33:
				num2 = 4;
				DataView a_2 = new DataView(this.DataTable.BaseTable, this.Filter, this.ParentCol, DataViewRowState.CurrentRows);
				IL_55:
				num2 = 5;
				string text = string.Concat(new string[]
				{
					"(",
					this.ParentCol,
					" Is Null And ",
					this.ChildCol,
					" Is Not Null) or (",
					this.ParentCol,
					" = ",
					this.ChildCol,
					")"
				});
				IL_B1:
				num2 = 6;
				if (Operators.CompareString(this.Filter, "", true) <= 0)
				{
					goto IL_FC;
				}
				IL_C7:
				num2 = 7;
				text = string.Concat(new string[]
				{
					"(",
					text,
					") And (",
					this.Filter,
					")"
				});
				IL_FC:
				num2 = 8;
				DataRow[] array = this.DataTable.BaseTable.Select(text, this.ChildCol, DataViewRowState.CurrentRows);
				IL_11A:
				num2 = 9;
				HashSet<string> hashSet = Oo00.O____0O._0.(this.DataTable.BaseTable, this.Filter, "", this.ParentCol);
				IL_140:
				num2 = 10;
				HashSet<string> hashSet2 = Oo00.O____0O._0.(this.DataTable.BaseTable, this.Filter, "", this.ChildCol);
				IL_166:
				num2 = 11;
				Dictionary<DataRow, List<DataRow>> dictionary = new Dictionary<DataRow, List<DataRow>>();
				IL_170:
				num2 = 12;
				hashSet.ExceptWith(hashSet2);
				IL_17C:
				num2 = 13;
				foreach (DataRow dataRow in array)
				{
					IL_18F:
					num2 = 14;
					hashSet.Add(dataRow[this.ChildCol].ToString());
					IL_1AC:
					num2 = 15;
				}
				IL_1BD:
				num2 = 16;
				List<string> list = new List<string>();
				IL_1C7:
				num2 = 17;
				list.AddRange(hashSet);
				IL_1D3:
				num2 = 18;
				list.Sort();
				IL_1DD:
				num2 = 19;
				hashSet.Clear();
				IL_1E7:
				num2 = 20;
				hashSet2.Clear();
				IL_1F1:
				num2 = 21;
				List<string>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = enumerator.Current;
					IL_208:
					num2 = 22;
					if (Operators.CompareString(text2, "", true) != 0)
					{
						IL_21A:
						num2 = 24;
						this.oO._O_0oO__0.(fxDataSource, a_2, a_, text2, new List<string>(), dictionary, 0);
					}
					IL_233:
					num2 = 25;
				}
				IL_23F:
				num2 = 26;
				((IDisposable)enumerator).Dispose();
				IL_24F:
				num2 = 27;
				int num3 = fxDataSource.Rows.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					IL_26A:
					num2 = 28;
					DataRow dataRow2 = fxDataSource.Rows[j];
					IL_27D:
					num2 = 29;
					int num4 = Conversions.ToInteger(dataRow2["sys_Hierarchy_Level"]);
					IL_293:
					num2 = 30;
					List<o0o_>.Enumerator enumerator2 = this.Totals.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						o0o_ o0o_ = enumerator2.Current;
						IL_2B1:
						num2 = 31;
						int num5 = 0;
						IL_2B7:
						num2 = 32;
						double num6 = 0.0;
						IL_2C5:
						num2 = 33;
						if (o0o_.o0oO._o_.() == AggregateType.Min)
						{
							IL_2D2:
							num2 = 34;
							num6 = double.MaxValue;
						}
						else
						{
							IL_2E2:
							num2 = 36;
							if (o0o_.o0oO._o_.() == AggregateType.Max)
							{
								IL_2EF:
								num2 = 37;
								num6 = double.MinValue;
							}
						}
						IL_2FD:
						num2 = 38;
						int num7 = j;
						IL_304:
						num2 = 39;
						int num8 = fxDataSource.Rows.Count - 1;
						IL_317:
						num2 = 40;
						if (o0o_.O0OO_0.O.() == AggregateRange.Self)
						{
							IL_323:
							num2 = 41;
							num8 = j;
						}
						else
						{
							IL_32C:
							num2 = 43;
							if (o0o_.O0OO_0.O.() == AggregateRange.Sub)
							{
								IL_339:
								num2 = 44;
								num7 = j + 1;
							}
						}
						IL_342:
						num2 = 45;
						int num9 = num7;
						int num10 = num8;
						for (int k = num9; k <= num10; k++)
						{
							IL_352:
							num2 = 46;
							DataRow dataRow3 = fxDataSource.Rows[k];
							IL_365:
							num2 = 47;
							if (k > j && Conversions.ToInteger(dataRow3["sys_Hierarchy_Level"]) <= num4)
							{
								break;
							}
							IL_386:
							num2 = 49;
							List<DataRow> list2 = dictionary[dataRow3];
							IL_394:
							num2 = 50;
							num5 += list2.Count;
							IL_3A3:
							num2 = 51;
							if (o0o_.o0oO._o_.() != AggregateType.Count)
							{
								IL_3B3:
								num2 = 53;
								List<DataRow>.Enumerator enumerator3 = list2.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									DataRow dataRow4 = enumerator3.Current;
									IL_3CD:
									num2 = 54;
									if (!dataRow4.IsNull(o0o_.o0oO._o_.()))
									{
										IL_3E3:
										num2 = 56;
										switch (o0o_.o0oO._o_.())
										{
										case AggregateType.Sum:
										case AggregateType.Average:
											IL_408:
											num2 = 58;
											num6 += Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]);
											break;
										case AggregateType.Max:
											IL_446:
											num2 = 62;
											num6 = Math.Max(num6, Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]));
											break;
										case AggregateType.Min:
											IL_425:
											num2 = 60;
											num6 = Math.Min(num6, Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]));
											break;
										}
									}
									IL_465:
									num2 = 64;
								}
								IL_474:
								num2 = 65;
								((IDisposable)enumerator3).Dispose();
							}
							IL_484:
							num2 = 66;
						}
						IL_496:
						num2 = 67;
						if (o0o_.o0oO._o_.() == AggregateType.Average && num5 > 0)
						{
							IL_4A8:
							num2 = 68;
							num6 /= (double)num5;
						}
						IL_4B3:
						num2 = 69;
						if (o0o_.o0oO._o_.() == AggregateType.Count)
						{
							IL_4C0:
							num2 = 70;
							dataRow2[o0o_.Oo0oO0oOO_.0_o.()] = num5;
						}
						else
						{
							IL_4DA:
							num2 = 72;
							dataRow2[o0o_.Oo0oO0oOO_.0_o.()] = num6;
						}
						IL_4F2:
						num2 = 73;
					}
					IL_501:
					num2 = 74;
					((IDisposable)enumerator2).Dispose();
					IL_511:
					num2 = 75;
				}
				IL_523:
				num2 = 76;
				dictionary.Clear();
				IL_52D:
				num2 = 77;
				result = fxDataSource;
				IL_533:
				goto IL_6BD;
				IL_538:
				int num11 = num12 + 1;
				num12 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num11);
				IL_67E:
				goto IL_6B2;
				IL_680:
				num12 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_690:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num12 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_680;
			}
			IL_6B2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6BD:
			if (num12 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0003208C File Offset: 0x0003028C
		private void <<EMPTY_NAME>>(fxDataSource A_0, DataView A_1, DataView A_2, string A_3, List<string> A_4, Dictionary<DataRow, List<DataRow>> A_5, int A_6)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!A_4.Contains(A_3))
				{
					goto IL_65;
				}
				IL_14:
				num2 = 3;
				MessageBox.Show(string.Concat(new string[]
				{
					"发现循环引用：",
					string.Join("→", A_4.ToArray()),
					"→",
					A_3,
					"\r\n无法完成统计!"
				}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_31D;
				IL_65:
				num2 = 5;
				DataRow dataRow = A_0.NewRow();
				IL_6E:
				num2 = 6;
				string text = "";
				IL_77:
				num2 = 7;
				if (A_4.Count <= 0)
				{
					goto IL_B5;
				}
				IL_83:
				num2 = 8;
				text = A_4[A_4.Count - 1];
				IL_97:
				num2 = 9;
				if (!this.IncludeParentCol)
				{
					goto IL_D1;
				}
				IL_A2:
				num2 = 10;
				dataRow[this.ParentCol] = text;
				goto IL_D1;
				IL_B5:
				num2 = 12;
				if (!this.IncludeParentCol)
				{
					goto IL_D1;
				}
				IL_C0:
				num2 = 13;
				dataRow[this.ParentCol] = A_3;
				IL_D1:
				num2 = 14;
				A_4.Add(A_3);
				IL_DD:
				num2 = 15;
				DataRowView[] array = A_2.FindRows(A_3);
				IL_EA:
				num2 = 16;
				dataRow[this.ChildCol] = A_3;
				IL_FB:
				num2 = 17;
				dataRow["sys_Hierarchy_Level"] = A_6;
				IL_110:
				num2 = 18;
				IEnumerator<o00_0__O> enumerator = this.Additions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					o00_0__O o00_0__O = enumerator.Current;
					IL_12B:
					num2 = 19;
					int num3 = o00_0__O.oo__.0O00.().Find(A_3);
					IL_13E:
					num2 = 20;
					if (num3 >= 0)
					{
						IL_146:
						num2 = 21;
						dataRow[o00_0__O.o0o.OooOOo0__.()] = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()[num3][o00_0__O.oooO00.o00O.()]);
					}
					IL_175:
					num2 = 22;
				}
				IL_181:
				num2 = 23;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_18F:
				num2 = 24;
				A_0.Rows.Add(dataRow);
				IL_19E:
				num2 = 25;
				List<DataRow> list = new List<DataRow>();
				IL_1A8:
				num2 = 26;
				foreach (DataRowView dataRowView in array)
				{
					IL_1BB:
					num2 = 27;
					if (A_6 == 0 || Operators.CompareString(dataRowView[this.ParentCol].ToString(), text, true) == 0)
					{
						IL_1DE:
						num2 = 28;
						list.Add(dataRowView.Row);
					}
					IL_1EF:
					num2 = 29;
				}
				IL_200:
				num2 = 30;
				A_5[dataRow] = list;
				IL_20D:
				num2 = 31;
				array = A_1.FindRows(A_3);
				IL_21A:
				num2 = 32;
				HashSet<string> hashSet = new HashSet<string>();
				IL_224:
				num2 = 33;
				foreach (DataRowView dataRowView2 in array)
				{
					IL_23A:
					num2 = 34;
					if (Operators.CompareString(dataRowView2[this.ChildCol].ToString(), A_3, true) != 0)
					{
						IL_25C:
						num2 = 36;
						if (!dataRowView2.Row.IsNull(this.ChildCol) && !hashSet.Contains(dataRowView2[this.ChildCol].ToString()))
						{
							IL_291:
							num2 = 38;
							if (Operators.CompareString(dataRowView2[this.ParentCol].ToString(), A_3, true) == 0)
							{
								IL_2B0:
								num2 = 40;
								hashSet.Add(dataRowView2[this.ChildCol].ToString());
								IL_2CD:
								num2 = 41;
								List<string> list2 = new List<string>();
								IL_2D7:
								num2 = 42;
								list2.AddRange(A_4);
								IL_2E3:
								num2 = 43;
								this.oO._O_0oO__0.(A_0, A_1, A_2, dataRowView2[this.ChildCol].ToString(), list2, A_5, A_6 + 1);
							}
						}
					}
					IL_309:
					num2 = 44;
				}
				IL_31D:
				goto IL_423;
				IL_322:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_3E4:
				goto IL_418;
				IL_3E6:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3F6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3E6;
			}
			IL_418:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_423:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000324E0 File Offset: 0x000306E0
		private fxDataSource <<EMPTY_NAME>>()
		{
			fxDataSource fxDataSource = new fxDataSource();
			if (this.ShowTreeInParentCol)
			{
				if (this.IncludeParentCol)
				{
					fxDataSource.Columns.Add(this.ParentCol, typeof(string));
				}
				fxDataSource.Columns.Add(this.ChildCol, typeof(string));
			}
			else
			{
				fxDataSource.Columns.Add(this.ChildCol, typeof(string));
				if (this.IncludeParentCol)
				{
					fxDataSource.Columns.Add(this.ParentCol, typeof(string));
				}
			}
			try
			{
				foreach (o00_0__O o00_0__O in this.Additions)
				{
					o00_0__O.oo__.0O00.(true);
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].DataType);
					fxDataSource.Columns[o00_0__O.o0o.OooOOo0__.()].MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].MaxLength;
				}
			}
			finally
			{
				IEnumerator<o00_0__O> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (o0o_ o0o_ in this.Totals)
				{
					if (o0o_.o0oO._o_.() == AggregateType.Count)
					{
						fxDataSource.Columns.Add(o0o_.Oo0oO0oOO_.0_o.(), typeof(int));
					}
					else
					{
						fxDataSource.Columns.Add(o0o_.Oo0oO0oOO_.0_o.(), typeof(double));
					}
				}
			}
			finally
			{
				List<o0o_>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			fxDataSource.Columns.Add("sys_Hierarchy_Level", typeof(int));
			return fxDataSource;
		}

		// Token: 0x040001D3 RID: 467
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001D4 RID: 468
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040001D5 RID: 469
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001D6 RID: 470
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001D7 RID: 471
		[CompilerGenerated]
		private List<o0o_> <<EMPTY_NAME>>;

		// Token: 0x040001D8 RID: 472
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001D9 RID: 473
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001DA RID: 474
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001DB RID: 475
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x040001DC RID: 476
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001DD RID: 477
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x040001DE RID: 478
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001DF RID: 479
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x040001E0 RID: 480
		private HashSet<string> <<EMPTY_NAME>>;
	}
}
