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
	/// 层级分组统计工具
	/// </summary>
	// Token: 0x020000B1 RID: 177
	[ComVisible(true)]
	[oO0oooo("3368")]
	public class LayersGroupTableBuilder
	{
		/// <summary>
		/// 要生成的统计表名称
		/// </summary>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000334F0 File Offset: 0x000316F0
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000334F8 File Offset: 0x000316F8
		public string TableName { get; set; }

		/// <summary>
		/// 被统计的数据表
		/// </summary>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00033501 File Offset: 0x00031701
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00033509 File Offset: 0x00031709
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 层级列
		/// </summary>
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00033512 File Offset: 0x00031712
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0003351A File Offset: 0x0003171A
		public string PathCol { get; set; }

		/// <summary>
		/// 名称列
		/// </summary>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00033523 File Offset: 0x00031723
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0003352B File Offset: 0x0003172B
		public string NameCol { get; set; }

		/// <summary>
		/// 层级列的分割符号
		/// </summary>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00033534 File Offset: 0x00031734
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0003353C File Offset: 0x0003173C
		public string Separator { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00033548 File Offset: 0x00031748
		internal char Separator2
		{
			get
			{
				char result;
				if (Operators.CompareString(this.Separator, "", true) > 0)
				{
					result = this.Separator[0];
				}
				return result;
			}
		}

		/// <summary>
		/// 如果层级列是按长度分割的，用于此属性指定层级列的各级长度，如果{1,3,2}
		/// </summary>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00033577 File Offset: 0x00031777
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x0003357F File Offset: 0x0003177F
		public object[] lengths { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00033588 File Offset: 0x00031788
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int[] lengths2
		{
			get
			{
				List<int> list = new List<int>();
				checked
				{
					int[] result;
					if (this.lengths == null)
					{
						result = list.ToArray();
					}
					else
					{
						object[] array = this.lengths;
						for (int i = 0; i < array.Length; i++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(array[i]);
							list.Add(Conversions.ToInteger(objectValue));
						}
						result = list.ToArray();
					}
					return result;
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000335E0 File Offset: 0x000317E0
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x000335E8 File Offset: 0x000317E8
		internal List<o0o_> Totals { get; set; }

		/// <summary>
		/// 统计条件表达式
		/// </summary>
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000335F1 File Offset: 0x000317F1
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x000335F9 File Offset: 0x000317F9
		public string Filter { get; set; }

		/// <summary>
		/// 生成的统计表是否默认开启折叠模式
		/// </summary>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00033602 File Offset: 0x00031802
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0003360A File Offset: 0x0003180A
		public bool GridTree { get; set; }

		/// <summary>
		/// 指定折叠树默认展开到第几级
		/// </summary>
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00033613 File Offset: 0x00031813
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0003361B File Offset: 0x0003181B
		public int ExpandTo { get; set; }

		/// <summary>
		/// 统计表是否只保留分组行
		/// </summary>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00033624 File Offset: 0x00031824
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0003362C File Offset: 0x0003182C
		public bool OnlyGroupRows { get; set; }

		/// <summary>
		/// 指定统计统计表保留到第几级分组行
		/// </summary>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00033635 File Offset: 0x00031835
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0003363D File Offset: 0x0003183D
		public int PreserveTo { get; set; }

		/// <summary>
		/// 是否在层级列显示折叠树
		/// </summary>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00033646 File Offset: 0x00031846
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0003364E File Offset: 0x0003184E
		public bool ShowTreeInPathCol { get; set; }

		/// <summary>
		/// 用于附加数据列
		/// </summary>
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00033657 File Offset: 0x00031857
		[oO0oooo("3699")]
		public MRPExtendTables Additions { get; }

		/// <param name="TableName">要生成的统计表名称</param>
		/// <param name="SourceTable">被统计的数据表</param>
		// Token: 0x0600073B RID: 1851 RVA: 0x00033660 File Offset: 0x00031860
		public LayersGroupTableBuilder(string A_0, DataTable A_1)
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.o_.__OOO0. = new HashSet<string>();
			this.TableName = A_0;
			this.DataTable = A_1;
		}

		/// <param name="TableName">要生成的统计表名称</param>
		// Token: 0x0600073C RID: 1852 RVA: 0x000336B0 File Offset: 0x000318B0
		public LayersGroupTableBuilder(string A_0)
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.o_.__OOO0. = new HashSet<string>();
			this.TableName = A_0;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000336EE File Offset: 0x000318EE
		public LayersGroupTableBuilder()
		{
			this.Totals = new List<o0o_>();
			this.ExpandTo = 0;
			this.PreserveTo = -1;
			this.Additions = new MRPExtendTables();
			this.o_.__OOO0. = new HashSet<string>();
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00033725 File Offset: 0x00031925
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
		// Token: 0x0600073F RID: 1855 RVA: 0x00033749 File Offset: 0x00031949
		public DataTable Build()
		{
			return this.Build(false);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00033754 File Offset: 0x00031954
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
		// Token: 0x06000741 RID: 1857 RVA: 0x00033819 File Offset: 0x00031A19
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
		// Token: 0x06000742 RID: 1858 RVA: 0x00033825 File Offset: 0x00031A25
		public void AddTotal(string Column, string newName, AggregateRange AggregateRange)
		{
			this.AddTotal(Column, newName, AggregateRange, AggregateType.Sum);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00033831 File Offset: 0x00031A31
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
		// Token: 0x06000744 RID: 1860 RVA: 0x0003383C File Offset: 0x00031A3C
		public void AddTotal(string Column, string newName, AggregateRange AggregateRange, AggregateType AggregateType)
		{
			if (!this.o_.__OOO0..Contains(newName))
			{
				this.o_.__OOO0..Add(newName);
				this.Totals.Add(new o0o_(Column, newName, AggregateRange, AggregateType));
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003386E File Offset: 0x00031A6E
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
		// Token: 0x06000746 RID: 1862 RVA: 0x0003387B File Offset: 0x00031A7B
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
		// Token: 0x06000747 RID: 1863 RVA: 0x00033886 File Offset: 0x00031A86
		public void AddTotal(bool Count, string newName, AggregateRange AggregateRange)
		{
			if (!this.o_.__OOO0..Contains(newName))
			{
				this.o_.__OOO0..Add(newName);
				this.Totals.Add(new o0o_(true, newName, AggregateRange));
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000338B6 File Offset: 0x00031AB6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTotal(bool Count, string newName, int AggregateRange)
		{
			this.AddTotal(Count, newName, (AggregateRange)AggregateRange);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTab,不生成Table</param>
		// Token: 0x06000749 RID: 1865 RVA: 0x000338C4 File Offset: 0x00031AC4
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
				goto IL_674;
				IL_B3:
				num2 = 10;
				DataTable dataTable = this.Ooo.0O.();
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
				goto IL_674;
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
				if (!this.GridTree)
				{
					goto IL_660;
				}
				IL_400:
				num2 = 46;
				OO_00oOO.DataTables[this.TableName].oOOO.OOO_0ooO0. = true;
				IL_419:
				num2 = 47;
				if (!this.ShowTreeInPathCol && Operators.CompareString(this.NameCol, "", true) != 0)
				{
					goto IL_4AB;
				}
				IL_437:
				num2 = 48;
				if (this.lengths2 == null || this.lengths2.Length <= 0)
				{
					goto IL_47C;
				}
				IL_44D:
				num2 = 49;
				OO_00oOO.Tables[this.TableName].O_.o__ooo.(this.PathCol, this.lengths2, this.ExpandTo);
				goto IL_5C8;
				IL_47C:
				num2 = 51;
				OO_00oOO.Tables[this.TableName].O_.o__ooo.(this.PathCol, this.Separator2, this.ExpandTo);
				goto IL_5C8;
				IL_4AB:
				num2 = 53;
				OO_00oOO.Tables[this.TableName].O_.oOoOO0o. = this.PathCol;
				IL_4C9:
				num2 = 54;
				OO_00oOO.Tables[this.TableName].O000__.o_ooo_O. = this.NameCol;
				IL_4E7:
				num2 = 55;
				OO_00oOO.Tables[this.TableName].o__.O0o. = this.ExpandTo;
				IL_505:
				num2 = 56;
				if (this.lengths2 == null || this.lengths2.Length <= 0)
				{
					goto IL_575;
				}
				IL_51B:
				num2 = 57;
				OO_00oOO.Tables[this.TableName].OOo0_Oo._OOo.(this.PathCol, this.NameCol, this.lengths2, this.ExpandTo);
				IL_54B:
				num2 = 58;
				OO_00oOO.Tables[this.TableName].O_OO.oO0_. = string.Join<int>("", this.lengths2);
				goto IL_5C8;
				IL_575:
				num2 = 60;
				OO_00oOO.Tables[this.TableName].O_.o__ooo.(this.PathCol, this.NameCol, this.Separator2, this.ExpandTo);
				IL_5A5:
				num2 = 61;
				OO_00oOO.Tables[this.TableName].oO0.00. = Conversions.ToString(this.Separator2);
				IL_5C8:
				num2 = 62;
				if (!this.ShowTreeInPathCol && Operators.CompareString(this.NameCol, "", true) != 0)
				{
					goto IL_624;
				}
				IL_5E6:
				num2 = 63;
				OO_00oOO.DataTables[this.TableName].OoOo_OoOO0.o. = this.PathCol;
				IL_604:
				num2 = 64;
				OO_00oOO.Tables[this.TableName].OO0o_o0.0oOo0o. = this.PathCol;
				goto IL_660;
				IL_624:
				num2 = 66;
				OO_00oOO.DataTables[this.TableName].OoOo_OoOO0.o. = this.NameCol;
				IL_642:
				num2 = 67;
				OO_00oOO.Tables[this.TableName].OO0o_o0.0oOo0o. = this.NameCol;
				IL_660:
				num2 = 68;
				result = OO_00oOO.DataTables[this.TableName];
				IL_674:
				goto IL_7DA;
				IL_679:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_79B:
				goto IL_7CF;
				IL_79D:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7AD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_79D;
			}
			IL_7CF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7DA:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000340D0 File Offset: 0x000322D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x0600074B RID: 1867 RVA: 0x000340EA File Offset: 0x000322EA
		public fxDataSource BuildDataSource()
		{
			return this.Ooo.0O.();
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000340F4 File Offset: 0x000322F4
		private fxDataSource <<EMPTY_NAME>>()
		{
			int num;
			fxDataSource result;
			int num19;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				fxDataSource fxDataSource = this.oo___O0.O.();
				IL_11:
				num2 = 3;
				DataView dataView = new DataView(this.DataTable.BaseTable, this.Filter, this.PathCol, DataViewRowState.CurrentRows);
				IL_33:
				num2 = 4;
				Dictionary<DataRow, List<DataRow>> dictionary = new Dictionary<DataRow, List<DataRow>>();
				IL_3C:
				num2 = 5;
				string left = "";
				IL_45:
				num2 = 6;
				int num3 = dataView.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_5A:
					num2 = 7;
					if (!dataView[i].Row.IsNull(this.PathCol))
					{
						IL_7A:
						num2 = 9;
						List<DataRow> list = new List<DataRow>();
						IL_84:
						num2 = 10;
						string text = dataView[i][this.PathCol].ToString();
						IL_A2:
						num2 = 11;
						if (i <= 0 || Operators.CompareString(left, text, true) != 0)
						{
							IL_B9:
							num2 = 13;
							int num4;
							if (this.lengths2 != null && this.lengths2.Length > 0)
							{
								IL_D5:
								num2 = 14;
								if (this.lengths2.Length == 1)
								{
									IL_E3:
									num2 = 15;
									num4 = text.Length / this.lengths2[0] - 1;
								}
								else
								{
									IL_FF:
									num2 = 17;
									int num5 = 0;
									IL_105:
									num2 = 18;
									int num6 = 0;
									IL_10B:
									num2 = 19;
									num4 = -1;
									for (;;)
									{
										IL_147:
										num2 = 21;
										if (num6 >= text.Length)
										{
											break;
										}
										IL_113:
										num2 = 22;
										num6 += this.lengths2[num5];
										IL_124:
										num2 = 23;
										num4++;
										IL_12D:
										num2 = 24;
										if (num5 < this.lengths2.Length - 1)
										{
											IL_13E:
											num2 = 25;
											num5++;
										}
									}
								}
							}
							else
							{
								IL_157:
								num2 = 28;
								if (Operators.CompareString(Conversions.ToString(this.Separator2), "", true) > 0)
								{
									IL_173:
									num2 = 29;
									num4 = text.Split(new char[]
									{
										this.Separator2
									}).Length - 1;
								}
							}
							IL_192:
							num2 = 30;
							list.Add(dataView[i].Row);
							IL_1AA:
							num2 = 31;
							int num7 = i + 1;
							int num8 = dataView.Count - 1;
							for (int j = num7; j <= num8; j++)
							{
								IL_1C3:
								num2 = 32;
								string text2 = dataView[j][this.PathCol].ToString();
								IL_1E1:
								num2 = 33;
								if (Operators.CompareString(text2, text, true) == 0)
								{
									IL_1F0:
									num2 = 34;
									list.Add(dataView[j].Row);
								}
								else
								{
									IL_20A:
									num2 = 36;
									if (this.lengths2 != null && this.lengths2.Length > 0)
									{
										IL_220:
										num2 = 37;
										if (!text2.StartsWith(text, StringComparison.OrdinalIgnoreCase))
										{
											break;
										}
									}
									else
									{
										IL_231:
										num2 = 40;
										if (Operators.CompareString(Conversions.ToString(this.Separator2), "", true) > 0)
										{
											IL_24D:
											num2 = 41;
											if (!text2.StartsWith(text + Conversions.ToString(this.Separator2), StringComparison.OrdinalIgnoreCase))
											{
												break;
											}
										}
									}
								}
								IL_26C:
								num2 = 43;
							}
							IL_27E:
							num2 = 44;
							DataRow dataRow = fxDataSource.NewRow();
							IL_28A:
							num2 = 45;
							dataRow[this.PathCol] = RuntimeHelpers.GetObjectValue(dataView[i][this.PathCol]);
							IL_2B3:
							num2 = 46;
							dataRow["sys_Hierarchy_Level"] = num4;
							IL_2C9:
							num2 = 47;
							if (Operators.CompareString(this.NameCol, "", true) > 0)
							{
								IL_2E0:
								num2 = 48;
								dataRow[this.NameCol] = RuntimeHelpers.GetObjectValue(dataView[i][this.NameCol]);
							}
							IL_309:
							num2 = 49;
							IEnumerator<o00_0__O> enumerator = this.Additions.GetEnumerator();
							while (enumerator.MoveNext())
							{
								o00_0__O o00_0__O = enumerator.Current;
								IL_324:
								num2 = 50;
								int num9 = o00_0__O.oo__.0O00.().Find(text);
								IL_337:
								num2 = 51;
								if (num9 >= 0)
								{
									IL_33F:
									num2 = 52;
									dataRow[o00_0__O.o0o.OooOOo0__.()] = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()[num9][o00_0__O.oooO00.o00O.()]);
								}
								IL_36F:
								num2 = 53;
							}
							IL_37B:
							num2 = 54;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
							IL_389:
							num2 = 55;
							fxDataSource.Rows.Add(dataRow);
							IL_39A:
							num2 = 56;
							dictionary[dataRow] = list;
							IL_3A8:
							num2 = 57;
							left = text;
						}
					}
					IL_3AF:
					num2 = 58;
				}
				IL_3C1:
				num2 = 59;
				int num10 = fxDataSource.Rows.Count - 1;
				for (int k = 0; k <= num10; k++)
				{
					IL_3DC:
					num2 = 60;
					DataRow dataRow2 = fxDataSource.Rows[k];
					IL_3EF:
					num2 = 61;
					int num11 = Conversions.ToInteger(dataRow2["sys_Hierarchy_Level"]);
					IL_405:
					num2 = 62;
					List<o0o_>.Enumerator enumerator2 = this.Totals.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						o0o_ o0o_ = enumerator2.Current;
						IL_423:
						num2 = 63;
						int num12 = 0;
						IL_429:
						num2 = 64;
						double num13 = 0.0;
						IL_437:
						num2 = 65;
						if (o0o_.o0oO._o_.() == AggregateType.Min)
						{
							IL_444:
							num2 = 66;
							num13 = double.MaxValue;
						}
						else
						{
							IL_454:
							num2 = 68;
							if (o0o_.o0oO._o_.() == AggregateType.Max)
							{
								IL_461:
								num2 = 69;
								num13 = double.MinValue;
							}
						}
						IL_46F:
						num2 = 70;
						int num14 = k;
						IL_476:
						num2 = 71;
						int num15 = fxDataSource.Rows.Count - 1;
						IL_489:
						num2 = 72;
						if (o0o_.O0OO_0.O.() == AggregateRange.Self)
						{
							IL_495:
							num2 = 73;
							num15 = k;
						}
						else
						{
							IL_49E:
							num2 = 75;
							if (o0o_.O0OO_0.O.() == AggregateRange.Sub)
							{
								IL_4AB:
								num2 = 76;
								num14 = k + 1;
							}
						}
						IL_4B4:
						num2 = 77;
						int num16 = num14;
						int num17 = num15;
						for (int l = num16; l <= num17; l++)
						{
							IL_4C4:
							num2 = 78;
							DataRow dataRow3 = fxDataSource.Rows[l];
							IL_4D7:
							num2 = 79;
							if (l > k && Conversions.ToInteger(dataRow3["sys_Hierarchy_Level"]) <= num11)
							{
								break;
							}
							IL_4F8:
							num2 = 81;
							List<DataRow> list2 = dictionary[dataRow3];
							IL_506:
							num2 = 82;
							num12 += list2.Count;
							IL_515:
							num2 = 83;
							if (o0o_.o0oO._o_.() != AggregateType.Count)
							{
								IL_525:
								num2 = 85;
								List<DataRow>.Enumerator enumerator3 = list2.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									DataRow dataRow4 = enumerator3.Current;
									IL_53F:
									num2 = 86;
									if (!dataRow4.IsNull(o0o_.o0oO._o_.()))
									{
										IL_555:
										num2 = 88;
										switch (o0o_.o0oO._o_.())
										{
										case AggregateType.Sum:
										case AggregateType.Average:
											IL_57A:
											num2 = 90;
											num13 += Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]);
											break;
										case AggregateType.Max:
											IL_5B8:
											num2 = 94;
											num13 = Math.Max(num13, Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]));
											break;
										case AggregateType.Min:
											IL_597:
											num2 = 92;
											num13 = Math.Min(num13, Conversions.ToDouble(dataRow4[o0o_.o0oO._o_.()]));
											break;
										}
									}
									IL_5D7:
									num2 = 96;
								}
								IL_5E6:
								num2 = 97;
								((IDisposable)enumerator3).Dispose();
							}
							IL_5F6:
							num2 = 98;
						}
						IL_608:
						num2 = 99;
						if (o0o_.o0oO._o_.() == AggregateType.Average && num12 > 0)
						{
							IL_61A:
							num2 = 100;
							num13 /= (double)num12;
						}
						IL_625:
						num2 = 101;
						if (o0o_.o0oO._o_.() == AggregateType.Count)
						{
							IL_632:
							num2 = 102;
							dataRow2[o0o_.Oo0oO0oOO_.0_o.()] = num12;
						}
						else
						{
							IL_64C:
							num2 = 104;
							dataRow2[o0o_.Oo0oO0oOO_.0_o.()] = num13;
						}
						IL_664:
						num2 = 105;
					}
					IL_673:
					num2 = 106;
					((IDisposable)enumerator2).Dispose();
					IL_683:
					num2 = 107;
				}
				IL_695:
				num2 = 108;
				dictionary.Clear();
				IL_69F:
				num2 = 109;
				result = fxDataSource;
				IL_6A5:
				goto IL_8AF;
				IL_6AA:
				int num18 = num19 + 1;
				num19 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18);
				IL_870:
				goto IL_8A4;
				IL_872:
				num19 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_882:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num19 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_872;
			}
			IL_8A4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8AF:
			if (num19 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000349D8 File Offset: 0x00032BD8
		private fxDataSource <<EMPTY_NAME>>()
		{
			fxDataSource fxDataSource = new fxDataSource();
			fxDataSource.Columns.Add(this.PathCol, typeof(string));
			if (Operators.CompareString(this.NameCol, "", true) > 0)
			{
				fxDataSource.Columns.Add(this.NameCol, typeof(string));
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

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000211 RID: 529
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private object[] <<EMPTY_NAME>>;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private List<o0o_> <<EMPTY_NAME>>;

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000215 RID: 533
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000217 RID: 535
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000218 RID: 536
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000219 RID: 537
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x0400021B RID: 539
		private HashSet<string> <<EMPTY_NAME>>;
	}
}
