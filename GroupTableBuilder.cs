using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 分组统计工具
	/// </summary>
	// Token: 0x0200029A RID: 666
	[ComVisible(true)]
	[oO0oooo("0677")]
	public class GroupTableBuilder
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x000EA864 File Offset: 0x000E8A64
		internal GroupTableBuilder()
		{
			this.o.O0__OO. = true;
			this.O.00OOoo_0O_. = new GroupCollection();
			this.o.O0__OO. = new TotalCollection();
			this.oO0.O00oO. = 4;
			this.O.00_0OO0_. = -1;
			this.o.O0__OO. = new List<string>();
			this.ooO.oO0O00O0. = new List<string>();
			this.o0.o_O0O. = new List<string>();
			this.Oo.O0O_0. = 30;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SourceDataTable">要统计的数据表</param>
		// Token: 0x06002192 RID: 8594 RVA: 0x000EA8CC File Offset: 0x000E8ACC
		public GroupTableBuilder(string A_0, DataTable A_1)
		{
			this.o.O0__OO. = true;
			this.O.00OOoo_0O_. = new GroupCollection();
			this.o.O0__OO. = new TotalCollection();
			this.oO0.O00oO. = 4;
			this.O.00_0OO0_. = -1;
			this.o.O0__OO. = new List<string>();
			this.ooO.oO0O00O0. = new List<string>();
			this.o0.o_O0O. = new List<string>();
			this.Oo.O0O_0. = 30;
			this.o.O0__OO. = A_0;
			this.O.00OOoo_0O_. = A_1;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SourceDataTable">要统计的数据表</param>
		/// <param name="Filter">统计条件</param>
		// Token: 0x06002193 RID: 8595 RVA: 0x000EA944 File Offset: 0x000E8B44
		public GroupTableBuilder(string A_0, DataTable A_1, string A_2)
		{
			this.o.O0__OO. = true;
			this.O.00OOoo_0O_. = new GroupCollection();
			this.o.O0__OO. = new TotalCollection();
			this.oO0.O00oO. = 4;
			this.O.00_0OO0_. = -1;
			this.o.O0__OO. = new List<string>();
			this.ooO.oO0O00O0. = new List<string>();
			this.o0.o_O0O. = new List<string>();
			this.Oo.O0O_0. = 30;
			this.o.O0__OO. = A_0;
			this.O.00OOoo_0O_. = A_1;
			this.Oo.O0O_0. = A_2;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SelectString">Select语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x06002194 RID: 8596 RVA: 0x000EA9C0 File Offset: 0x000E8BC0
		public GroupTableBuilder(string A_0, string A_1, string A_2)
		{
			this.o.O0__OO. = true;
			this.O.00OOoo_0O_. = new GroupCollection();
			this.o.O0__OO. = new TotalCollection();
			this.oO0.O00oO. = 4;
			this.O.00_0OO0_. = -1;
			this.o.O0__OO. = new List<string>();
			this.ooO.oO0O00O0. = new List<string>();
			this.o0.o_O0O. = new List<string>();
			this.Oo.O0O_0. = 30;
			this.o.O0__OO. = A_0;
			this.o_O0oo__._0o. = A_1;
			this.oOO_.0___. = A_2;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SelectString">Select语句</param>
		// Token: 0x06002195 RID: 8597 RVA: 0x000EAA3C File Offset: 0x000E8C3C
		public GroupTableBuilder(string A_0, string A_1)
		{
			this.o.O0__OO. = true;
			this.O.00OOoo_0O_. = new GroupCollection();
			this.o.O0__OO. = new TotalCollection();
			this.oO0.O00oO. = 4;
			this.O.00_0OO0_. = -1;
			this.o.O0__OO. = new List<string>();
			this.ooO.oO0O00O0. = new List<string>();
			this.o0.o_O0O. = new List<string>();
			this.Oo.O0O_0. = 30;
			this.o.O0__OO. = A_0;
			this.o_O0oo__._0o. = A_1;
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x000EAAB1 File Offset: 0x000E8CB1
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x000EAAB9 File Offset: 0x000E8CB9
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SelectString
		{
			get
			{
				return this.o_O0oo__._0o.;
			}
			set
			{
				this.o_O0oo__._0o. = value;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x000EAAC2 File Offset: 0x000E8CC2
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x000EAACA File Offset: 0x000E8CCA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ConnectionName
		{
			get
			{
				return this.oOO_.0___.;
			}
			set
			{
				this.oOO_.0___. = value;
			}
		}

		/// <summary>
		/// 统计结果保留的小数位数
		/// </summary>
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000EAAD3 File Offset: 0x000E8CD3
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x000EAADB File Offset: 0x000E8CDB
		public int Decimals
		{
			get
			{
				return this.oO0.O00oO.;
			}
			set
			{
				this.oO0.O00oO. = value;
			}
		}

		/// <summary>
		/// 是否直接统计后台数据
		/// </summary>
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x000EAAE4 File Offset: 0x000E8CE4
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x000EAB6E File Offset: 0x000E8D6E
		[oO0oooo("1623")]
		public bool FromServer
		{
			get
			{
				return this.SourceDataTable != null && Operators.CompareString(this.SelectString, "", true) <= 0 && (this.SourceDataTable.frd_IsOuterTable || this.SourceDataTable.frd_IsInnerTable || this.SourceDataTable.frd_IsOuterQuery || this.SourceDataTable.frd_IsInnerQuery || Operators.CompareString(this.SourceDataTable.DataServer, "", true) > 0) && this.Oo0Oo._oO.;
			}
			set
			{
				this.Oo0Oo._oO. = value;
			}
		}

		/// <summary>
		/// 是否生成同比增长率
		/// </summary>
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x000EAB77 File Offset: 0x000E8D77
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x000EAB7F File Offset: 0x000E8D7F
		[oO0oooo("3283")]
		public bool SamePeriodGrowth
		{
			get
			{
				return this.O0.0_O_ooO.;
			}
			set
			{
				this.O0.0_O_ooO. = value;
			}
		}

		/// <summary>
		/// 是否生成环比增长率
		/// </summary>
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000EAB88 File Offset: 0x000E8D88
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x000EAB90 File Offset: 0x000E8D90
		[oO0oooo("3283")]
		public bool CircleGrowth
		{
			get
			{
				return this.OOo0o.O0oO.;
			}
			set
			{
				this.OOo0o.O0oO. = value;
			}
		}

		/// <summary>
		/// 是否生成总占比
		/// </summary>
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000EAB99 File Offset: 0x000E8D99
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x000EABA1 File Offset: 0x000E8DA1
		[oO0oooo("1618")]
		public bool GrandProportion
		{
			get
			{
				return this.o_0O0Oo_0o.o.;
			}
			set
			{
				this.o_0O0Oo_0o.o. = value;
			}
		}

		/// <summary>
		/// 是否生成分组占比 
		/// </summary>
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000EABAA File Offset: 0x000E8DAA
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x000EABB2 File Offset: 0x000E8DB2
		[oO0oooo("1618")]
		public bool GroupProportion
		{
			get
			{
				return this.Oo0.__.;
			}
			set
			{
				this.Oo0.__. = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000EABBB File Offset: 0x000E8DBB
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x000EABC3 File Offset: 0x000E8DC3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TableName
		{
			get
			{
				return this.o.O0__OO.;
			}
			set
			{
				this.o.O0__OO. = value;
			}
		}

		/// <summary>
		/// 设置生成的统计表的Visible属性
		/// </summary>
		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000EABCC File Offset: 0x000E8DCC
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x000EABD4 File Offset: 0x000E8DD4
		public bool TableVisible
		{
			get
			{
				return this.o.O0__OO.;
			}
			set
			{
				this.o.O0__OO. = value;
			}
		}

		/// <summary>
		/// 设置生成的统计表的标题
		/// </summary>
		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000EABDD File Offset: 0x000E8DDD
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000EABE5 File Offset: 0x000E8DE5
		public string Caption
		{
			get
			{
				return this.oO.00___0.;
			}
			set
			{
				this.oO.00___0. = value;
			}
		}

		/// <summary>
		/// 要统计的数据表
		/// </summary>
		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000EABEE File Offset: 0x000E8DEE
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x000EABF6 File Offset: 0x000E8DF6
		public DataTable SourceDataTable
		{
			get
			{
				return this.O.00OOoo_0O_.;
			}
			set
			{
				this.O.00OOoo_0O_. = value;
			}
		}

		/// <summary>
		/// 统计条件
		/// </summary>
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000EABFF File Offset: 0x000E8DFF
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x000EAC07 File Offset: 0x000E8E07
		public string Filter
		{
			get
			{
				return this.Oo.O0O_0.;
			}
			set
			{
				this.Oo.O0O_0. = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000EAC10 File Offset: 0x000E8E10
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000EAC18 File Offset: 0x000E8E18
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ExtendFilter
		{
			get
			{
				return this.oO0o_.OOO0_.;
			}
			set
			{
				this.oO0o_.OOO0_. = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000EAC21 File Offset: 0x000E8E21
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x000EAC29 File Offset: 0x000E8E29
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool FromAll
		{
			get
			{
				return this.O.00_0OO0_.;
			}
			set
			{
				this.O.00_0OO0_. = value;
			}
		}

		/// <summary>
		/// 是否在垂直方向自动增加汇总行
		/// </summary>
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000EAC32 File Offset: 0x000E8E32
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x000EAC3A File Offset: 0x000E8E3A
		public bool VerticalTotal
		{
			get
			{
				return this.o0.o_O0O.;
			}
			set
			{
				this.o0.o_O0O. = value;
			}
		}

		/// <summary>
		/// 是否生成汇总模式
		/// </summary>
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000EAC43 File Offset: 0x000E8E43
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x000EAC4B File Offset: 0x000E8E4B
		[oO0oooo("2669")]
		public bool Subtotal
		{
			get
			{
				return this.ooOoo__0._o_.;
			}
			set
			{
				this.ooOoo__0._o_. = value;
			}
		}

		/// <summary>
		/// 设置汇总模式的层数
		/// </summary>
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000EAC54 File Offset: 0x000E8E54
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x000EAC5C File Offset: 0x000E8E5C
		[oO0oooo("2669")]
		public int SubtotalLevel
		{
			get
			{
				return this.O.00_0OO0_.;
			}
			set
			{
				this.O.00_0OO0_. = value;
			}
		}

		/// <summary>
		/// 分组列集合
		/// </summary>
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000EAC65 File Offset: 0x000E8E65
		public GroupCollection Groups
		{
			get
			{
				return this.O.00OOoo_0O_.;
			}
		}

		/// <summary>
		/// 统计列集合
		/// </summary>
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x000EAC6D File Offset: 0x000E8E6D
		public TotalCollection Totals
		{
			get
			{
				return this.o.O0__OO.;
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000EAC78 File Offset: 0x000E8E78
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual DataTable Build(params object[] args)
		{
			DataTable result;
			if (args.Length == 0)
			{
				result = this.Build();
			}
			else if (args.Length == 1 && args[1] is bool)
			{
				bool onlyDataTable = Conversions.ToBoolean(args[1]);
				result = this.Build(onlyDataTable);
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		// Token: 0x060021BD RID: 8637 RVA: 0x000EACBC File Offset: 0x000E8EBC
		public virtual DataTable Build()
		{
			if (this.SourceDataTable != null && OO_00oOO.Tables.get_Contains(this.SourceDataTable.Name))
			{
				OO_00oOO.Tables[this.SourceDataTable.Name].O_0._O_0OO000O. = this;
			}
			return this.Build(false);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000EAD0C File Offset: 0x000E8F0C
		internal void <<EMPTY_NAME>>()
		{
			int num = this.Totals.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				TotalOn totalOn = this.Totals[i];
				bool flag = false;
				int num2 = i + 1;
				int num3 = this.Totals.Count - 1;
				for (int j = num2; j <= num3; j++)
				{
					TotalOn totalOn2 = this.Totals[j];
					if (Operators.CompareString(totalOn2.NewName, totalOn.NewName, true) == 0 && totalOn.Aggregate != totalOn2.Aggregate)
					{
						flag = true;
						totalOn2.NewName = totalOn2.NewName + "_" + Oo00.OoO_.__o.(totalOn2.Aggregate);
					}
				}
				if (flag)
				{
					totalOn.NewName = totalOn.NewName + "_" + Oo00.OoO_.__o.(totalOn.Aggregate);
				}
			}
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTable，不生成Table</param>
		// Token: 0x060021BF RID: 8639 RVA: 0x000EADE8 File Offset: 0x000E8FE8
		public virtual DataTable Build(bool OnlyDataTable)
		{
			this.o00OO.oOO0O_.();
			string a_ = OO_00oOO.MainTable.Name;
			if (OO_00oOO.DataTables.Contains(this.TableName) && !OnlyDataTable)
			{
				if (OO_00oOO.DataTables[this.TableName].AddByCode)
				{
					OO_00oOO.DataTables.Delete(this.TableName);
				}
				if (OO_00oOO.DataTables.Contains(this.TableName))
				{
					MessageBox.Show("表" + this.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return null;
				}
			}
			DataTable dataTable = this.BuildDataSource();
			DataTable dataTable2 = this.oO_oO._O__O.(dataTable, OnlyDataTable, a_);
			if (this.Subtotal && !OnlyDataTable)
			{
				this.oO0.O00oO.(dataTable2.Name, dataTable);
			}
			return dataTable2;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000EAEA8 File Offset: 0x000E90A8
		protected internal void <<EMPTY_NAME>>(string A_0, DataTable A_1)
		{
			int num;
			int num13;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Table table = OO_00oOO.Tables[A_0];
				IL_15:
				num2 = 3;
				table.SubtotalGroups.Clear();
				IL_22:
				num2 = 4;
				if (this.SubtotalLevel != -1)
				{
					goto IL_38;
				}
				IL_2D:
				num2 = 5;
				int num3 = int.MaxValue;
				goto IL_42;
				IL_38:
				num2 = 7;
				num3 = this.SubtotalLevel;
				IL_42:
				num2 = 8;
				if (num3 <= 0)
				{
					goto IL_2C6;
				}
				IL_4C:
				num2 = 9;
				int num4 = Math.Min(num3 - 1, this.Groups.Count - 2);
				IL_67:
				num2 = 10;
				for (int i = num4; i >= 0; i += -1)
				{
					IL_73:
					num2 = 11;
					string text = "";
					IL_7D:
					num2 = 12;
					IEnumerator<TotalOn> enumerator = this.Totals.GetEnumerator();
					while (enumerator.MoveNext())
					{
						TotalOn totalOn = enumerator.Current;
						IL_9B:
						num2 = 13;
						text = text + "," + totalOn.NewName;
						IL_B3:
						num2 = 14;
						if (A_1.Columns.Contains(totalOn.NewName + "gdr"))
						{
							IL_D4:
							num2 = 15;
							text = text + "," + totalOn.NewName + "gdr";
						}
						IL_F1:
						num2 = 16;
						int num5 = this.Groups.Count - 2;
						for (int j = 0; j <= num5; j++)
						{
							IL_108:
							num2 = 17;
							if (j <= i)
							{
								IL_111:
								num2 = 19;
								string text2 = totalOn.NewName + this.Groups[j].NewName + "gpr";
								IL_139:
								num2 = 20;
								if (A_1.Columns.Contains(text2))
								{
									IL_14B:
									num2 = 21;
									text = text + "," + text2;
								}
							}
							IL_15E:
							num2 = 22;
						}
						IL_16D:
						num2 = 23;
					}
					IL_17C:
					num2 = 24;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
					IL_18A:
					num2 = 25;
					text = text.Trim(new char[]
					{
						','
					});
					IL_1A1:
					num2 = 26;
					SubtotalGroup subtotalGroup = new SubtotalGroup();
					IL_1AB:
					num2 = 27;
					subtotalGroup.GroupOn = this.Groups[i].NewName;
					IL_1C7:
					num2 = 28;
					subtotalGroup.TotalOn = text;
					IL_1D3:
					num2 = 29;
					if (this.Totals.Count > 0)
					{
						IL_1E4:
						num2 = 30;
						if (this.Totals[0].Aggregate == AggregateEnum.Count)
						{
							IL_1FB:
							num2 = 31;
							subtotalGroup.Aggregate = AggregateEnum.Sum;
						}
						else
						{
							IL_208:
							num2 = 33;
							subtotalGroup.Aggregate = this.Totals[0].Aggregate;
						}
					}
					else
					{
						IL_225:
						num2 = 35;
						if (this.Totals.Exprs.Count > 0)
						{
							IL_23B:
							num2 = 36;
							if (this.Totals.Exprs[0].Aggregate == AggregateEnum.Count)
							{
								IL_257:
								num2 = 37;
								subtotalGroup.Aggregate = AggregateEnum.Sum;
							}
							else
							{
								IL_264:
								num2 = 39;
								subtotalGroup.Aggregate = this.Totals.Exprs[0].Aggregate;
							}
						}
					}
					IL_284:
					num2 = 40;
					subtotalGroup.Caption = "小计 {0}";
					IL_293:
					num2 = 41;
					table.SubtotalGroups.Add(subtotalGroup);
					IL_2A3:
					num2 = 42;
					int num6;
					num6++;
					IL_2AC:
					num2 = 43;
					if (num6 >= num3)
					{
						break;
					}
					IL_2B5:
					num2 = 45;
				}
				IL_2C6:
				num2 = 46;
				string text3 = "";
				IL_2D0:
				num2 = 47;
				IEnumerator<TotalOn> enumerator2 = this.Totals.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					TotalOn totalOn2 = enumerator2.Current;
					IL_2EB:
					num2 = 48;
					text3 = text3 + "," + totalOn2.NewName;
					IL_303:
					num2 = 49;
					if (A_1.Columns.Contains(totalOn2.NewName + "gdr"))
					{
						IL_324:
						num2 = 50;
						text3 = text3 + "," + totalOn2.NewName + "gdr";
					}
					IL_341:
					num2 = 51;
				}
				IL_34D:
				num2 = 52;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_35B:
				num2 = 53;
				text3 = text3.Trim(new char[]
				{
					','
				});
				IL_372:
				num2 = 54;
				SubtotalGroup subtotalGroup2 = new SubtotalGroup();
				IL_37C:
				num2 = 55;
				subtotalGroup2.GroupOn = "*";
				IL_38B:
				num2 = 56;
				subtotalGroup2.TotalOn = text3;
				IL_397:
				num2 = 57;
				if (this.Totals.Count <= 0)
				{
					goto IL_3E9;
				}
				IL_3A8:
				num2 = 58;
				if (this.Totals[0].Aggregate != AggregateEnum.Count)
				{
					goto IL_3CC;
				}
				IL_3BF:
				num2 = 59;
				subtotalGroup2.Aggregate = AggregateEnum.Sum;
				goto IL_448;
				IL_3CC:
				num2 = 61;
				subtotalGroup2.Aggregate = this.Totals[0].Aggregate;
				goto IL_448;
				IL_3E9:
				num2 = 63;
				if (this.Totals.Exprs.Count <= 0)
				{
					goto IL_448;
				}
				IL_3FF:
				num2 = 64;
				if (this.Totals.Exprs[0].Aggregate != AggregateEnum.Count)
				{
					goto IL_428;
				}
				IL_41B:
				num2 = 65;
				subtotalGroup2.Aggregate = AggregateEnum.Sum;
				goto IL_448;
				IL_428:
				num2 = 67;
				subtotalGroup2.Aggregate = this.Totals.Exprs[0].Aggregate;
				IL_448:
				num2 = 68;
				subtotalGroup2.Caption = "总计";
				IL_457:
				num2 = 69;
				table.SubtotalGroups.Add(subtotalGroup2);
				IL_467:
				num2 = 70;
				table.Subtotal(false);
				IL_471:
				num2 = 71;
				if (this.ooO.oO0O00O0..Count <= 0)
				{
					goto IL_5F3;
				}
				IL_485:
				num2 = 72;
				O_oOooO_O o_oOooO_O = table.foxGrid;
				IL_490:
				num2 = 73;
				int num7 = o_oOooO_O.Rows.Count - 1;
				int num8 = o_oOooO_O.Rows.Fixed + 1;
				for (int k = num7; k >= num8; k += -1)
				{
					IL_4B8:
					num2 = 74;
					Row row = o_oOooO_O.Rows[k];
					IL_4CB:
					num2 = 75;
					if (row.IsNode)
					{
						IL_4DA:
						num2 = 76;
						if (row.Node.PrevNode != null)
						{
							IL_4EE:
							num2 = 77;
							Row row2 = row.Node.PrevNode.Row;
							IL_504:
							num2 = 78;
							int num9 = this.ooO.oO0O00O0..Count - 1;
							for (int l = 0; l <= num9; l++)
							{
								IL_51E:
								num2 = 79;
								string columnName = this.ooO.oO0O00O0.[l];
								IL_530:
								num2 = 80;
								object objectValue = RuntimeHelpers.GetObjectValue(row2[columnName]);
								IL_543:
								num2 = 81;
								if (objectValue != null)
								{
									IL_54D:
									num2 = 82;
									string s = objectValue.ToString();
									IL_559:
									num2 = 83;
									double num10;
									if (double.TryParse(s, out num10))
									{
										IL_567:
										num2 = 84;
										if (num10 > 0.0)
										{
											IL_577:
											num2 = 85;
											object objectValue2 = RuntimeHelpers.GetObjectValue(row[columnName]);
											IL_58A:
											num2 = 86;
											if (objectValue2 != null)
											{
												IL_591:
												num2 = 87;
												string s2 = objectValue2.ToString();
												IL_59D:
												num2 = 88;
												double num11;
												if (double.TryParse(s2, out num11))
												{
													IL_5AB:
													num2 = 89;
													row[this.o0.o_O0O.[l]] = (num11 - num10) / num10;
												}
											}
										}
									}
								}
								IL_5CF:
								num2 = 90;
							}
						}
					}
					IL_5E1:
					num2 = 91;
				}
				IL_5F3:
				goto IL_7B5;
				IL_5F8:
				int num12 = num13 + 1;
				num13 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12);
				IL_776:
				goto IL_7AA;
				IL_778:
				num13 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_788:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num13 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_778;
			}
			IL_7AA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7B5:
			if (num13 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000EB690 File Offset: 0x000E9890
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x060021C2 RID: 8642 RVA: 0x000EB6AC File Offset: 0x000E98AC
		[oO0oooo("1909")]
		public fxDataSource BuildDataSource()
		{
			this.o00OO.oOO0O_.();
			fxDataSource fxDataSource;
			if (this.FromServer || Operators.CompareString(this.SelectString, "", true) > 0)
			{
				fxDataSource = this.o0_O.00ooOo0.();
			}
			else
			{
				fxDataSource = this.O.O0_0O.();
			}
			fxDataSource result;
			if (fxDataSource == null)
			{
				result = null;
			}
			else
			{
				if (Operators.CompareString(this.SelectString, "", true) == 0)
				{
					this.oO0O.__o_OO_oo.(fxDataSource, this.SourceDataTable.BaseTable);
				}
				else
				{
					this.oO0O.__o_OO_oo.(fxDataSource, this.o.O0__OO.);
				}
				if (this.SourceDataTable != null)
				{
					try
					{
						foreach (TotalOn totalOn in this.Totals)
						{
							if (fxDataSource.Columns.Contains(totalOn.NewName) && this.SourceDataTable.DataCols[totalOn.Name].ExtendColumnType == ExtendColumnTypeEnum.时段)
							{
								fxDataSource.Columns[totalOn.NewName].ExtendedProperties.Add("IsTimeSpan", "");
							}
						}
					}
					finally
					{
						IEnumerator<TotalOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				fxDataSource.O_O_O.00. = this;
				result = fxDataSource;
			}
			return result;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000EB7CC File Offset: 0x000E99CC
		internal fxDataSource <<EMPTY_NAME>>()
		{
			return this.o00OO.oOO0O_.();
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000EB7D4 File Offset: 0x000E99D4
		private string <<EMPTY_NAME>>(string A_0, string A_1, DataServerTypeEnum A_2)
		{
			if (A_1.IndexOf("trim(", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (A_1.IndexOf("convert", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (A_1.IndexOf("Parent(", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (A_1.IndexOf("Parent.", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (A_1.IndexOf("Child(", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (A_1.IndexOf("Child.", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if ((A_2 == DataServerTypeEnum.Oracle || A_2 == DataServerTypeEnum.SqlServer) && A_1.IndexOf("iif(", StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				A_1 = "0";
			}
			if (Operators.CompareString(A_1, "0", true) == 0)
			{
				MessageBox.Show("列\"" + A_0 + "\"不支持后台统计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			return A_1;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000EB8B0 File Offset: 0x000E9AB0
		private string <<EMPTY_NAME>>(DataTable A_0, string A_1)
		{
			string text = A_1;
			Match match = Regex.Match(A_1, "[[0-9a-zA-Z\\u4e00-\\u9fa5_]+]");
			while (Operators.CompareString(match.ToString(), "", true) != 0)
			{
				string text2 = match.ToString();
				string text3 = Oo00.oo0o.O0O_0__.(text2.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				}), A_0);
				if (!Oo00.OO_O_0O0OO0_.o.(text3))
				{
					text3 = "[" + text3 + "]";
				}
				else
				{
					text3 = "(" + text3 + ")";
				}
				text = text.Replace(text2, text3);
				match = match.NextMatch();
			}
			return text;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000EB94C File Offset: 0x000E9B4C
		private fxDataSource <<EMPTY_NAME>>()
		{
			int num;
			fxDataSource result;
			int num6;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				fxDataSource fxDataSource = new fxDataSource();
				IL_10:
				num2 = 3;
				DataTable dataTable = null;
				IL_15:
				num2 = 4;
				string text = "";
				IL_1E:
				num2 = 5;
				string text2 = "";
				IL_27:
				num2 = 6;
				OleDbConnection oleDbConnection = null;
				IL_2C:
				num2 = 7;
				string text3 = "";
				IL_35:
				num2 = 8;
				DataServerTypeEnum dataServerTypeEnum = DataServerTypeEnum.Access;
				IL_3A:
				num2 = 9;
				if (Operators.CompareString(this.SelectString, "", true) != 0)
				{
					goto IL_10C;
				}
				IL_53:
				num2 = 10;
				dataTable = this.SourceDataTable.BaseTable;
				IL_63:
				num2 = 11;
				if (Operators.CompareString(this.SourceDataTable.DataServer, "", true) <= 0)
				{
					goto IL_C6;
				}
				IL_7F:
				num2 = 12;
				this.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()[this.SourceDataTable.ConnectionName].oO0_0.o.();
				IL_A2:
				num2 = 13;
				dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()[this.SourceDataTable.ConnectionName].OO.OoO0.;
				goto IL_311;
				IL_C6:
				num2 = 15;
				oleDbConnection = new OleDbConnection(this.SourceDataTable.frd_Connection.ConnectionString);
				IL_E0:
				num2 = 16;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
				{
					goto IL_F2;
				}
				IL_EC:
				num2 = 17;
				dataServerTypeEnum = DataServerTypeEnum.Oracle;
				IL_F2:
				num2 = 18;
				if (!o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
				{
					goto IL_311;
				}
				IL_101:
				num2 = 19;
				dataServerTypeEnum = DataServerTypeEnum.SqlServer;
				goto IL_311;
				IL_10C:
				num2 = 21;
				if (Operators.CompareString(this.SelectString, "", true) <= 0)
				{
					goto IL_311;
				}
				IL_126:
				num2 = 22;
				if (Operators.CompareString(this.ConnectionName, "", true) <= 0 || !O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
				{
					goto IL_22B;
				}
				IL_155:
				num2 = 23;
				dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
				IL_16F:
				num2 = 24;
				this.SelectString = Oo00.o0_o._O_.(dataServerTypeEnum, this.SelectString, false);
				IL_186:
				num2 = 25;
				this.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				IL_1A4:
				num2 = 26;
				this.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				IL_1C2:
				num2 = 27;
				this.o.O0__OO..Select = this.SelectString;
				IL_1D6:
				num2 = 28;
				this.o.O0__OO..FormData["Action"] = 12.ToString();
				IL_1F9:
				num2 = 29;
				this.o.O0__OO. = this.o.O0__OO..GetBaseDataTable();
				IL_20D:
				num2 = 30;
				dataTable = this.o.O0__OO.;
				IL_218:
				num2 = 31;
				this.o.O0__OO..Reset();
				goto IL_311;
				IL_22B:
				num2 = 33;
				bool a_ = false;
				IL_231:
				num2 = 34;
				if (Operators.CompareString(this.ConnectionName, "", true) <= 0)
				{
					goto IL_269;
				}
				IL_248:
				num2 = 35;
				oleDbConnection = new OleDbConnection(O_O0OO.O._o_.()[this.ConnectionName].ConnectionString);
				goto IL_283;
				IL_269:
				num2 = 37;
				oleDbConnection = new OleDbConnection(O_O0OO.OoO.0OO__0ooo.().ConnectionString);
				IL_27D:
				num2 = 38;
				a_ = true;
				IL_283:
				num2 = 39;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
				{
					goto IL_295;
				}
				IL_28F:
				num2 = 40;
				dataServerTypeEnum = DataServerTypeEnum.Oracle;
				IL_295:
				num2 = 41;
				if (!o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
				{
					goto IL_2A7;
				}
				IL_2A1:
				num2 = 42;
				dataServerTypeEnum = DataServerTypeEnum.SqlServer;
				IL_2A7:
				num2 = 43;
				this.SelectString = Oo00.o0_o._O_.(oleDbConnection, this.SelectString, a_);
				IL_2BF:
				num2 = 44;
				this.o.O0__OO. = new DataTable();
				IL_2CD:
				num2 = 45;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(this.SelectString, oleDbConnection);
				IL_2DF:
				num2 = 46;
				oleDbDataAdapter.SelectCommand.CommandTimeout = this.CommandTimeOut;
				IL_2F4:
				num2 = 47;
				oleDbDataAdapter.FillSchema(this.o.O0__OO., SchemaType.Source);
				IL_306:
				num2 = 48;
				dataTable = this.o.O0__OO.;
				IL_311:
				num2 = 49;
				IEnumerator<GroupOn> enumerator = this.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_32F:
					num2 = 50;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_342:
						num2 = 51;
						text += ",";
					}
					IL_353:
					num2 = 52;
					if (Operators.CompareString(text2, "", true) > 0)
					{
						IL_366:
						num2 = 53;
						text2 += ",";
					}
					IL_377:
					num2 = 54;
					string text4 = groupOn.Name;
					IL_383:
					num2 = 55;
					if (this.SourceDataTable != null)
					{
						IL_391:
						num2 = 56;
						if (Operators.CompareString(this.SourceDataTable.o._OOO0oOo0__., "", true) > 0)
						{
							IL_3AD:
							num2 = 57;
							text4 = Oo00.OoOo_oo_.o_o.(text4, this.SourceDataTable);
							IL_3BF:
							num2 = 58;
							text4 = this.oO_oO._O__O.(groupOn.Name, text4, dataServerTypeEnum);
						}
						else
						{
							IL_3DA:
							num2 = 60;
							if (Operators.CompareString(this.SourceDataTable.DataCols[groupOn.Name].Expression, "", true) > 0)
							{
								IL_40A:
								num2 = 61;
								text4 = this.SourceDataTable.DataCols[groupOn.Name].Expression;
								IL_42B:
								num2 = 62;
								IEnumerator<DataCol> enumerator2 = this.SourceDataTable.DataCols.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataCol dataCol = enumerator2.Current;
									IL_44B:
									num2 = 63;
									if (Operators.CompareString(dataCol.Expression, "", true) > 0)
									{
										IL_463:
										num2 = 64;
										int num3 = text4.IndexOf("[" + dataCol.Name + "]", StringComparison.CurrentCultureIgnoreCase);
										IL_486:
										num2 = 65;
										if (num3 >= 0)
										{
											IL_48E:
											num2 = 66;
											text4 = text4.Substring(0, num3) + dataCol.Expression + text4.Substring(dataCol.Name.Length + 2);
										}
									}
									IL_4BE:
									num2 = 67;
								}
								IL_4CD:
								num2 = 68;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
								IL_4DB:
								num2 = 69;
								text4 = this.OO0__0_.o00.(this.SourceDataTable, text4);
								IL_4EE:
								num2 = 70;
								text4 = Oo00.OoOo_oo_.o_o.(text4, this.SourceDataTable);
								IL_500:
								num2 = 71;
								text4 = Oo00.ooO.ooo.(this.SourceDataTable, text4);
								IL_512:
								num2 = 72;
								text4 = this.oO_oO._O__O.(groupOn.Name, text4, dataServerTypeEnum);
							}
						}
					}
					IL_528:
					num2 = 73;
					if (dataTable.Columns.Contains(groupOn.Name))
					{
						IL_540:
						num2 = 74;
						if (dataTable.Columns[groupOn.Name].DataType == typeof(DateTime) && groupOn.DateGroup != DateGroupEnum.None)
						{
							IL_570:
							num2 = 75;
							groupOn.IsDate = true;
						}
					}
					IL_57B:
					num2 = 76;
					if (dataTable.Columns[groupOn.Name].DataType == typeof(DateTime) && groupOn.DateGroup != DateGroupEnum.None)
					{
						IL_5AB:
						num2 = 77;
						string str = o_O_o_oOoo__.OO_O0oO0.oooO_.("", text4, groupOn.DateGroup, dataServerTypeEnum);
						IL_5C5:
						num2 = 78;
						text += str;
						IL_5D3:
						num2 = 79;
						text2 += str;
						IL_5E1:
						num2 = 80;
						text = text + " As [" + groupOn.NewName + "]";
					}
					else
					{
						IL_600:
						num2 = 82;
						string text5 = text4;
						IL_607:
						num2 = 83;
						if (!Oo00.OO_O_0O0OO0_.o.(text5))
						{
							IL_613:
							num2 = 84;
							text5 = "[" + text5 + "]";
						}
						else
						{
							IL_62B:
							num2 = 86;
							text5 = "(" + text5 + ")";
						}
						IL_641:
						num2 = 87;
						text += text5;
						IL_64F:
						num2 = 88;
						text2 += text5;
						IL_65D:
						num2 = 89;
						text = text + " As [" + groupOn.NewName + "]";
					}
					IL_67A:
					num2 = 90;
				}
				IL_689:
				num2 = 91;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_697:
				num2 = 92;
				IEnumerator<TotalOn> enumerator3 = this.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					TotalOn totalOn = enumerator3.Current;
					IL_6B5:
					num2 = 93;
					string str2 = "";
					IL_6BF:
					num2 = 94;
					string text6 = totalOn.Name;
					IL_6CB:
					num2 = 95;
					if (this.SourceDataTable != null)
					{
						IL_6D9:
						num2 = 96;
						if (Operators.CompareString(this.SourceDataTable.o._OOO0oOo0__., "", true) > 0)
						{
							IL_6F5:
							num2 = 97;
							text6 = Oo00.OoOo_oo_.o_o.(text6, this.SourceDataTable);
							IL_707:
							num2 = 98;
							text6 = this.oO_oO._O__O.(totalOn.Name, text6, dataServerTypeEnum);
						}
						else
						{
							IL_722:
							num2 = 100;
							if (Operators.CompareString(this.SourceDataTable.DataCols[totalOn.Name].Expression, "", true) > 0)
							{
								IL_752:
								num2 = 101;
								text6 = this.SourceDataTable.DataCols[totalOn.Name].Expression;
								IL_773:
								num2 = 102;
								IEnumerator<DataCol> enumerator4 = this.SourceDataTable.DataCols.GetEnumerator();
								while (enumerator4.MoveNext())
								{
									DataCol dataCol2 = enumerator4.Current;
									IL_793:
									num2 = 103;
									if (Operators.CompareString(dataCol2.Expression, "", true) > 0)
									{
										IL_7AB:
										num2 = 104;
										int num4 = text6.IndexOf("[" + dataCol2.Name + "]", StringComparison.CurrentCultureIgnoreCase);
										IL_7CE:
										num2 = 105;
										if (num4 >= 0)
										{
											IL_7D6:
											num2 = 106;
											text6 = text6.Substring(0, num4) + dataCol2.Expression + text6.Substring(dataCol2.Name.Length + 2);
										}
									}
									IL_806:
									num2 = 107;
								}
								IL_815:
								num2 = 108;
								if (enumerator4 != null)
								{
									enumerator4.Dispose();
								}
								IL_823:
								num2 = 109;
								text6 = this.OO0__0_.o00.(this.SourceDataTable, text6);
								IL_836:
								num2 = 110;
								text6 = Oo00.OoOo_oo_.o_o.(text6, this.SourceDataTable);
								IL_848:
								num2 = 111;
								text6 = Oo00.ooO.ooo.(this.SourceDataTable, text6);
								IL_85A:
								num2 = 112;
								text6 = this.oO_oO._O__O.(totalOn.Name, text6, dataServerTypeEnum);
							}
						}
					}
					IL_870:
					num2 = 113;
					switch (totalOn.Aggregate)
					{
					case AggregateEnum.Sum:
						IL_8A6:
						num2 = 115;
						str2 = string.Concat(new string[]
						{
							"Sum(",
							text6,
							") As [",
							totalOn.NewName,
							"]"
						});
						break;
					case AggregateEnum.Count:
						IL_91E:
						num2 = 119;
						str2 = string.Concat(new string[]
						{
							"Count(",
							text6,
							") As [",
							totalOn.NewName,
							"]"
						});
						break;
					case AggregateEnum.Average:
						IL_8E2:
						num2 = 117;
						str2 = string.Concat(new string[]
						{
							"Avg(",
							text6,
							") As [",
							totalOn.NewName,
							"]"
						});
						break;
					case AggregateEnum.Max:
						IL_957:
						num2 = 121;
						str2 = string.Concat(new string[]
						{
							"Max(",
							text6,
							") As [",
							totalOn.NewName,
							"]"
						});
						break;
					case AggregateEnum.Min:
						IL_990:
						num2 = 123;
						str2 = string.Concat(new string[]
						{
							"Min(",
							text6,
							") As [",
							totalOn.NewName,
							"]"
						});
						break;
					}
					IL_9C7:
					num2 = 125;
					text = text + "," + str2;
					IL_9DA:
					num2 = 126;
				}
				IL_9E9:
				num2 = 127;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_9F7:
				num2 = 128;
				if (Operators.CompareString(this.SelectString, "", true) <= 0)
				{
					goto IL_A4F;
				}
				IL_A11:
				num2 = 129;
				string text7 = string.Concat(new string[]
				{
					"Select ",
					text,
					" From (",
					this.SelectString,
					") tmptbl"
				});
				goto IL_BA8;
				IL_A4F:
				num2 = 131;
				if (Operators.CompareString(this.SourceDataTable.o._OOO0oOo0__., "", true) != 0)
				{
					goto IL_B24;
				}
				IL_A70:
				num2 = 132;
				if (Operators.CompareString(this.SourceDataTable.DataServer, "", true) <= 0)
				{
					goto IL_AD2;
				}
				IL_A8F:
				num2 = 133;
				text7 = string.Concat(new string[]
				{
					"Select ",
					text,
					" From (",
					this.SourceDataTable.HttpSelect,
					") tmptbl"
				});
				goto IL_BA8;
				IL_AD2:
				num2 = 135;
				text7 = string.Concat(new string[]
				{
					"Select ",
					text,
					" From (",
					Oo00.O0Oo_O.0O_0O.(this.SourceDataTable._Adapter.SelectCommand.CommandText),
					") tmptbl"
				});
				goto IL_BA8;
				IL_B24:
				num2 = 137;
				if (dataServerTypeEnum != DataServerTypeEnum.Oracle)
				{
					goto IL_B55;
				}
				IL_B2F:
				num2 = 138;
				text7 = "Select " + text + " From " + this.SourceDataTable.o._OOO0oOo0__.;
				goto IL_BA8;
				IL_B55:
				num2 = 140;
				text7 = string.Concat(new string[]
				{
					"Select ",
					text,
					" From [",
					this.SourceDataTable.o._OOO0oOo0__..Trim(new char[]
					{
						'[',
						']'
					}),
					"]"
				});
				IL_BA8:
				num2 = 141;
				if (this.SourceDataTable == null || Operators.CompareString(this.SourceDataTable.LoadFilter, "", true) <= 0 || this.SourceDataTable.LoadPage < 0 || Operators.CompareString(this.SourceDataTable.LoadTop, "", true) <= 0 || this.SourceDataTable.BaseTable.Rows.Count <= 0)
				{
					goto IL_C21;
				}
				IL_C0E:
				num2 = 142;
				text3 = this.SourceDataTable.LoadFilter;
				IL_C21:
				num2 = 143;
				if (Operators.CompareString(this.Filter, "", true) <= 0 && Operators.CompareString(text3, "", true) <= 0)
				{
					goto IL_CD4;
				}
				IL_C4E:
				num2 = 144;
				if (Operators.CompareString(this.Filter, "", true) <= 0 || Operators.CompareString(text3, "", true) <= 0)
				{
					goto IL_CB8;
				}
				IL_C78:
				num2 = 145;
				text7 = string.Concat(new string[]
				{
					text7,
					" Where (",
					this.Filter,
					") And (",
					text3,
					")"
				});
				goto IL_CD4;
				IL_CB8:
				num2 = 147;
				text7 = text7 + " Where " + this.Filter + text3;
				IL_CD4:
				num2 = 148;
				text7 = text7 + " Group By " + text2;
				IL_CEA:
				num2 = 149;
				text7 = text7 + " ORDER BY " + text2;
				IL_D00:
				num2 = 150;
				if (dataServerTypeEnum != DataServerTypeEnum.Oracle)
				{
					goto IL_D33;
				}
				IL_D0B:
				num2 = 151;
				text7 = text7.Replace("[", "\"").Replace("]", "\"");
				IL_D33:
				num2 = 152;
				if (this.o.O0__OO. != null)
				{
					goto IL_D7F;
				}
				IL_D41:
				num2 = 153;
				OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter(text7, oleDbConnection);
				IL_D52:
				num2 = 154;
				oleDbDataAdapter2.SelectCommand.CommandTimeout = this.CommandTimeOut;
				IL_D6A:
				num2 = 155;
				oleDbDataAdapter2.Fill(fxDataSource);
				goto IL_E05;
				IL_D7F:
				num2 = 157;
				this.o.O0__OO..Select = text7;
				IL_D92:
				num2 = 158;
				this.o.O0__OO..FormData["Action"] = 2.ToString();
				IL_DB7:
				num2 = 159;
				this.o.O0__OO..FormData["IgnoreSchema"] = "True";
				IL_DD7:
				num2 = 160;
				DataTable baseDataTable = this.o.O0__OO..GetBaseDataTable();
				IL_DEA:
				num2 = 161;
				if (baseDataTable == null)
				{
					goto IL_E05;
				}
				IL_DF4:
				num2 = 162;
				fxDataSource.Merge(baseDataTable, false, MissingSchemaAction.AddWithKey);
				IL_E05:
				num2 = 163;
				if (fxDataSource == null)
				{
					goto IL_F34;
				}
				IL_E12:
				num2 = 164;
				IEnumerator enumerator5 = fxDataSource.Columns.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj = enumerator5.Current;
					DataColumn dataColumn = (DataColumn)obj;
					IL_E39:
					num2 = 165;
					if (dataColumn.DataType == typeof(double) || dataColumn.DataType == typeof(float) || dataColumn.DataType == typeof(decimal))
					{
						IL_E7B:
						num2 = 166;
						IEnumerator enumerator6 = fxDataSource.Rows.GetEnumerator();
						while (enumerator6.MoveNext())
						{
							object obj2 = enumerator6.Current;
							DataRow dataRow = (DataRow)obj2;
							IL_E9F:
							num2 = 167;
							if (!dataRow.IsNull(dataColumn))
							{
								IL_EB0:
								num2 = 168;
								dataRow[dataColumn] = Math.Round(Conversions.ToDecimal(dataRow[dataColumn]), this.Decimals);
							}
							IL_EDD:
							num2 = 169;
						}
						IL_EEC:
						num2 = 170;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
					}
					IL_F07:
					num2 = 171;
				}
				IL_F19:
				num2 = 172;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_F34:
				num2 = 173;
				result = fxDataSource;
				IL_F3D:
				goto IL_1247;
				IL_F42:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_1208:
				goto IL_123C;
				IL_120A:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_121A:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_120A;
			}
			IL_123C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1247:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000ECBC8 File Offset: 0x000EADC8
		internal fxDataSource <<EMPTY_NAME>>()
		{
			return this.oO_oO._O__O.();
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000ECBD0 File Offset: 0x000EADD0
		private fxDataSource <<EMPTY_NAME>>()
		{
			try
			{
				foreach (GroupOn groupOn in this.Groups)
				{
					if (!this.SourceDataTable.DataCols.Contains(groupOn.Name))
					{
						MessageBox.Show("原数据表不存在名为\"" + groupOn.Name + "\"的列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return null;
					}
				}
			}
			finally
			{
				IEnumerator<GroupOn> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (TotalOn totalOn in this.Totals)
				{
					if (!this.SourceDataTable.DataCols.Contains(totalOn.Name))
					{
						MessageBox.Show("原数据表不存在名为\"" + totalOn.Name + "\"的列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return null;
					}
				}
			}
			finally
			{
				IEnumerator<TotalOn> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			string text = "";
			string text2 = "";
			fxDataSource fxDataSource = new fxDataSource();
			DataTable dataTable = this.SourceDataTable.BaseTable;
			try
			{
				OO_00oOO.SystemReady = false;
				int num;
				try
				{
					foreach (GroupOn groupOn2 in this.Groups)
					{
						if (!fxDataSource.Columns.Contains(groupOn2.NewName))
						{
							DataColumn dataColumn = dataTable.Columns[groupOn2.Name];
							if (dataColumn.DataType == typeof(DateTime) && groupOn2.DateGroup != DateGroupEnum.None)
							{
								groupOn2.IsDate = true;
								if (this.VerticalTotal && !groupOn2.Vertical)
								{
									fxDataSource.Columns.Add(groupOn2.NewName, typeof(string), "");
								}
								else
								{
									fxDataSource.Columns.Add(groupOn2.NewName, typeof(int), "");
								}
								num++;
							}
							else
							{
								if (this.VerticalTotal && !groupOn2.Vertical)
								{
									fxDataSource.Columns.Add(groupOn2.NewName, typeof(string), "");
								}
								else
								{
									fxDataSource.Columns.Add(groupOn2.NewName, dataColumn.DataType, "");
								}
								fxDataSource.Columns[groupOn2.NewName].MaxLength = dataColumn.MaxLength;
							}
						}
						else
						{
							groupOn2.IsValid = false;
						}
					}
				}
				finally
				{
					IEnumerator<GroupOn> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				for (int i = this.Groups.Count - 1; i >= 0; i += -1)
				{
					if (!this.Groups[i].IsValid)
					{
						this.Groups.RemoveAt(i);
					}
				}
				if (this.Groups.Count == 0)
				{
					return null;
				}
				List<string> list = new List<string>();
				try
				{
					foreach (GroupOn groupOn3 in this.Groups)
					{
						if (!list.Contains(groupOn3.Name))
						{
							list.Add(groupOn3.Name);
							Operators.CompareString(text, "", true);
						}
					}
				}
				finally
				{
					IEnumerator<GroupOn> enumerator4;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
				}
				Operators.CompareString(this.Filter, "", true);
				text = this.Filter;
				try
				{
					foreach (TotalOn totalOn2 in this.Totals)
					{
						Type typeFromHandle;
						if (totalOn2.Aggregate == AggregateEnum.Count)
						{
							typeFromHandle = typeof(long);
						}
						else if (dataTable.Columns[totalOn2.Name].DataType == typeof(decimal))
						{
							typeFromHandle = typeof(decimal);
						}
						else
						{
							typeFromHandle = typeof(double);
						}
						if (list.Contains(totalOn2.NewName))
						{
							int num2 = 0;
							do
							{
								num2++;
							}
							while (list.Contains(totalOn2.NewName + "_" + Conversions.ToString(num2)));
							totalOn2.NewName = totalOn2.NewName + "_" + Conversions.ToString(num2);
						}
						if (!fxDataSource.Columns.Contains(totalOn2.NewName))
						{
							fxDataSource.Columns.Add(totalOn2.NewName, typeFromHandle);
							if (totalOn2.Aggregate == AggregateEnum.Average & num == 1)
							{
								totalOn2.OOOo.o. = OoOo0O.OO_o.0o_O.(6);
								fxDataSource.Columns.Add(totalOn2.OOOo.o., typeof(int));
							}
						}
					}
				}
				finally
				{
					IEnumerator<TotalOn> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
				list.Clear();
				try
				{
					foreach (GroupOn groupOn4 in this.Groups)
					{
						if (!list.Contains(groupOn4.Name) && !groupOn4.IsDate)
						{
							list.Add(groupOn4.Name);
							if (Operators.CompareString(text2, "", true) > 0)
							{
								text2 += ",";
							}
							text2 += groupOn4.Name;
						}
					}
				}
				finally
				{
					IEnumerator<GroupOn> enumerator6;
					if (enumerator6 != null)
					{
						enumerator6.Dispose();
					}
				}
				try
				{
					foreach (GroupOn groupOn5 in this.Groups)
					{
						if (!list.Contains(groupOn5.Name) && groupOn5.IsDate)
						{
							list.Add(groupOn5.Name);
							if (Operators.CompareString(text2, "", true) > 0)
							{
								text2 += ",";
							}
							text2 += groupOn5.Name;
						}
					}
				}
				finally
				{
					IEnumerator<GroupOn> enumerator7;
					if (enumerator7 != null)
					{
						enumerator7.Dispose();
					}
				}
				DataView dataView = new DataView(this.SourceDataTable.BaseTable, text, text2, DataViewRowState.CurrentRows);
				Foxtable.RibbonMenu.StatusBar.Message1 = "正在统计...";
				Application.DoEvents();
				int num3 = dataView.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					this.OO0__0_.o00.(dataView[j].Row);
					bool flag = true;
					if (j < dataView.Count - 1)
					{
						int num4 = this.Groups.Count - 1;
						for (int k = 0; k <= num4; k++)
						{
							GroupOn groupOn6 = this.Groups[k];
							if (Operators.CompareString(dataView[j][groupOn6.Name].ToString().TrimEnd(new char[0]), dataView[j + 1][groupOn6.Name].ToString().TrimEnd(new char[0]), true) != 0)
							{
								if (!groupOn6.IsDate)
								{
									flag = false;
									break;
								}
								int num5;
								if (dataView[j].Row.IsNull(groupOn6.Name))
								{
									num5 = -1;
								}
								else
								{
									num5 = this.oO_oO._O__O.(Conversions.ToDate(dataView[j][groupOn6.Name]), groupOn6.DateGroup);
								}
								int num6;
								if (dataView[j + 1].Row.IsNull(groupOn6.Name))
								{
									num6 = -1;
								}
								else
								{
									num6 = this.oO_oO._O__O.(Conversions.ToDate(dataView[j + 1][groupOn6.Name]), groupOn6.DateGroup);
								}
								if (num5 != num6)
								{
									flag = false;
									break;
								}
							}
						}
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						DataRow dataRow = fxDataSource.NewRow();
						int num7 = this.Groups.Count - 1;
						for (int l = 0; l <= num7; l++)
						{
							GroupOn groupOn7 = this.Groups[l];
							if (this.Groups[l].IsDate)
							{
								if (!dataView[j].Row.IsNull(groupOn7.Name))
								{
									int num8 = this.oO_oO._O__O.(Conversions.ToDate(dataView[j][groupOn7.Name]), groupOn7.DateGroup);
									if (dataRow.Table.Columns[groupOn7.NewName].DataType == typeof(string))
									{
										DateGroupEnum dateGroup = groupOn7.DateGroup;
										if (dateGroup - DateGroupEnum.Month > 5)
										{
											if (dateGroup != DateGroupEnum.DayOfYear)
											{
												dataRow[groupOn7.NewName] = num8;
											}
											else
											{
												dataRow[groupOn7.NewName] = Strings.Format(num8, "000");
											}
										}
										else
										{
											dataRow[groupOn7.NewName] = Strings.Format(num8, "00");
										}
									}
									else
									{
										dataRow[groupOn7.NewName] = num8;
									}
								}
							}
							else if (dataView.Table.Columns[groupOn7.Name].DataType == typeof(DateTime))
							{
								if (!dataView[j].Row.IsNull(groupOn7.Name))
								{
									if (dataView.Table.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
									{
										dataRow[groupOn7.NewName] = Strings.Format(RuntimeHelpers.GetObjectValue(dataView[j][groupOn7.Name]), OO_00oOO.Tables[dataView.Table.TableName].foxGrid.Cols[groupOn7.Name].Format);
									}
									else
									{
										dataRow[groupOn7.NewName] = RuntimeHelpers.GetObjectValue(dataView[j][groupOn7.Name]);
									}
								}
							}
							else if (fxDataSource.Columns[groupOn7.NewName].DataType == typeof(string))
							{
								dataRow[groupOn7.NewName] = dataView[j][groupOn7.Name].ToString().TrimEnd(new char[0]);
							}
							else
							{
								dataRow[groupOn7.NewName] = RuntimeHelpers.GetObjectValue(dataView[j][groupOn7.Name]);
							}
						}
						try
						{
							foreach (TotalOn totalOn3 in this.Totals)
							{
								switch (totalOn3.Aggregate)
								{
								case AggregateEnum.Sum:
								case AggregateEnum.Max:
								case AggregateEnum.Min:
									dataRow[totalOn3.NewName] = Math.Round(totalOn3.Oo_o0O00O.o0O., this.Decimals);
									break;
								case AggregateEnum.Count:
									dataRow[totalOn3.NewName] = totalOn3.Oo_o0O00O.o0O.;
									break;
								case AggregateEnum.Average:
									if (num == 1)
									{
										dataRow[totalOn3.NewName] = totalOn3.Oo_o0O00O.o0O.;
										dataRow[totalOn3.OOOo.o.] = totalOn3.Oo_o0O00O.o0O.;
									}
									else if (totalOn3.Oo_o0O00O.o0O. > 0)
									{
										dataRow[totalOn3.NewName] = Math.Round(totalOn3.Oo_o0O00O.o0O. / (double)totalOn3.Oo_o0O00O.o0O., this.Decimals);
									}
									break;
								}
								totalOn3.Oo_o0O00O.o0O. = 0.0;
								totalOn3.Oo_o0O00O.o0O. = 0;
							}
						}
						finally
						{
							IEnumerator<TotalOn> enumerator8;
							if (enumerator8 != null)
							{
								enumerator8.Dispose();
							}
						}
						fxDataSource.Rows.Add(dataRow);
					}
				}
				if (num == 1)
				{
					text2 = "";
					try
					{
						foreach (GroupOn groupOn8 in this.Groups)
						{
							if (Operators.CompareString(text2, "", true) > 0)
							{
								text2 += ",";
							}
							text2 += groupOn8.NewName;
						}
					}
					finally
					{
						IEnumerator<GroupOn> enumerator9;
						if (enumerator9 != null)
						{
							enumerator9.Dispose();
						}
					}
					int recordIndex = 0;
					DataView dataView2 = new DataView(fxDataSource, "", text2, DataViewRowState.CurrentRows);
					string text3 = OoOo0O.OO_o.0o_O.(6);
					fxDataSource.Columns.Add(text3, typeof(bool));
					int num9 = dataView2.Count - 1;
					for (int m = 0; m <= num9; m++)
					{
						bool flag = true;
						if (m > 0)
						{
							try
							{
								foreach (GroupOn groupOn9 in this.Groups)
								{
									if (Operators.CompareString(dataView2[m][groupOn9.NewName].ToString(), dataView2[m - 1][groupOn9.NewName].ToString(), true) != 0)
									{
										flag = false;
									}
								}
							}
							finally
							{
								IEnumerator<GroupOn> enumerator10;
								if (enumerator10 != null)
								{
									enumerator10.Dispose();
								}
							}
							if (flag)
							{
								dataView2[m][text3] = true;
								try
								{
									foreach (TotalOn totalOn4 in this.Totals)
									{
										switch (totalOn4.Aggregate)
										{
										case AggregateEnum.Sum:
										case AggregateEnum.Count:
											dataView2[recordIndex][totalOn4.NewName] = decimal.Add(Conversions.ToDecimal(dataView2[recordIndex][totalOn4.NewName]), Conversions.ToDecimal(dataView2[m][totalOn4.NewName]));
											break;
										case AggregateEnum.Average:
											dataView2[recordIndex][totalOn4.NewName] = decimal.Add(Conversions.ToDecimal(dataView2[recordIndex][totalOn4.NewName]), Conversions.ToDecimal(dataView2[m][totalOn4.NewName]));
											dataView2[recordIndex][totalOn4.OOOo.o.] = Conversions.ToLong(dataView2[recordIndex][totalOn4.OOOo.o.]) + Conversions.ToLong(dataView2[m][totalOn4.OOOo.o.]);
											break;
										case AggregateEnum.Max:
											dataView2[recordIndex][totalOn4.NewName] = Math.Max(Conversions.ToDecimal(dataView2[recordIndex][totalOn4.NewName]), Conversions.ToDecimal(dataView2[m][totalOn4.NewName]));
											break;
										case AggregateEnum.Min:
											dataView2[recordIndex][totalOn4.NewName] = Math.Min(Conversions.ToDecimal(dataView2[recordIndex][totalOn4.NewName]), Conversions.ToDecimal(dataView2[m][totalOn4.NewName]));
											break;
										}
									}
								}
								finally
								{
									IEnumerator<TotalOn> enumerator11;
									if (enumerator11 != null)
									{
										enumerator11.Dispose();
									}
								}
							}
						}
						if (!flag || m == dataView2.Count - 1)
						{
							try
							{
								foreach (TotalOn totalOn5 in this.Totals)
								{
									if (totalOn5.Aggregate == AggregateEnum.Average)
									{
										double num10 = Convert.ToDouble(Conversions.ToDecimal(dataView2[recordIndex][totalOn5.NewName]));
										long num11 = Conversions.ToLong(dataView2[recordIndex][totalOn5.OOOo.o.]);
										if (num11 != 0L)
										{
											dataView2[recordIndex][totalOn5.NewName] = Math.Round(num10 / (double)num11, this.Decimals);
										}
									}
								}
							}
							finally
							{
								IEnumerator<TotalOn> enumerator12;
								if (enumerator12 != null)
								{
									enumerator12.Dispose();
								}
							}
							recordIndex = m;
						}
						if (!flag && m == dataView2.Count - 1)
						{
							try
							{
								foreach (TotalOn totalOn6 in this.Totals)
								{
									if (totalOn6.Aggregate == AggregateEnum.Average)
									{
										double num12 = Convert.ToDouble(Conversions.ToDecimal(dataView2[m][totalOn6.NewName]));
										long num13 = Conversions.ToLong(dataView2[m][totalOn6.OOOo.o.]);
										if (num13 != 0L)
										{
											dataView2[m][totalOn6.NewName] = Math.Round(num12 / (double)num13, this.Decimals);
										}
									}
								}
							}
							finally
							{
								IEnumerator<TotalOn> enumerator13;
								if (enumerator13 != null)
								{
									enumerator13.Dispose();
								}
							}
						}
					}
					DataRow[] array = fxDataSource.Select("[" + text3 + "] = True");
					checked
					{
						for (int n = 0; n < array.Length; n++)
						{
							array[n].Delete();
						}
						try
						{
							foreach (TotalOn totalOn7 in this.Totals)
							{
								if (totalOn7.Aggregate == AggregateEnum.Average)
								{
									fxDataSource.Columns.Remove(totalOn7.OOOo.o.);
								}
							}
						}
						finally
						{
							IEnumerator<TotalOn> enumerator14;
							if (enumerator14 != null)
							{
								enumerator14.Dispose();
							}
						}
						fxDataSource.Columns.Remove(text3);
						dataView2.Dispose();
					}
				}
				dataView.Dispose();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				OO_00oOO.SystemReady = true;
				Foxtable.RibbonMenu.StatusBar.Reset();
			}
			return fxDataSource;
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000EDE6C File Offset: 0x000EC06C
		protected void <<EMPTY_NAME>>(DataTable A_0, DataTable A_1)
		{
			this.OO0__0_.o00.(A_0, A_1);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000EDE78 File Offset: 0x000EC078
		private void <<EMPTY_NAME>>(DataTable A_0, DataTable A_1)
		{
			int num;
			int num31;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				object obj = null;
				IL_0B:
				num2 = 3;
				this.o.O0__OO..Clear();
				IL_18:
				num2 = 4;
				this.ooO.oO0O00O0..Clear();
				IL_25:
				num2 = 5;
				this.o0.o_O0O..Clear();
				IL_32:
				num2 = 6;
				IEnumerator<GroupOn> enumerator = this.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_4F:
					num2 = 7;
					if (A_0.Columns.Contains(groupOn.NewName))
					{
						IL_68:
						num2 = 8;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_7F:
							num2 = 9;
							A_0.Columns[groupOn.NewName].Caption = groupOn.NewCaption;
						}
						else
						{
							IL_A5:
							num2 = 11;
							if (Operators.CompareString(groupOn.NewName, groupOn.Name, true) == 0 && this.SourceDataTable != null)
							{
								IL_C6:
								num2 = 12;
								if (Operators.CompareString(this.SourceDataTable.DataCols[groupOn.Name].Caption, "", true) > 0)
								{
									IL_F3:
									num2 = 13;
									A_0.Columns[groupOn.NewName].Caption = this.SourceDataTable.DataCols[groupOn.Name].Caption;
								}
							}
						}
					}
					IL_129:
					num2 = 14;
				}
				IL_138:
				num2 = 15;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_146:
				num2 = 16;
				IEnumerator<TotalOn> enumerator2 = this.Totals.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					TotalOn totalOn = enumerator2.Current;
					IL_164:
					num2 = 17;
					if (A_0.Columns.Contains(totalOn.NewName))
					{
						IL_17E:
						num2 = 18;
						if (Operators.CompareString(totalOn.NewCaption, "", true) > 0)
						{
							IL_196:
							num2 = 19;
							A_0.Columns[totalOn.NewName].Caption = totalOn.NewCaption;
						}
						else
						{
							IL_1BC:
							num2 = 21;
							if (Operators.CompareString(totalOn.NewName, totalOn.Name, true) == 0 && this.SourceDataTable != null)
							{
								IL_1DD:
								num2 = 22;
								if (Operators.CompareString(this.SourceDataTable.DataCols[totalOn.Name].Caption, "", true) > 0)
								{
									IL_20A:
									num2 = 23;
									A_0.Columns[totalOn.NewName].Caption = this.SourceDataTable.DataCols[totalOn.Name].Caption;
								}
							}
						}
						IL_240:
						num2 = 24;
						if (totalOn.upto && (totalOn.Aggregate == AggregateEnum.Sum || totalOn.Aggregate == AggregateEnum.Max || totalOn.Aggregate == AggregateEnum.Min))
						{
							IL_270:
							num2 = 25;
							string newName = totalOn.NewName;
							IL_27C:
							num2 = 26;
							List<string> list = new List<string>();
							IL_286:
							num2 = 27;
							if (this.Groups.Count > 1)
							{
								IL_297:
								num2 = 28;
								int num3 = this.Groups.Count - 2;
								for (int i = 0; i <= num3; i++)
								{
									IL_2AE:
									num2 = 29;
									list.Add(this.Groups[i].NewName);
									IL_2CA:
									num2 = 30;
								}
							}
							IL_2D9:
							num2 = 31;
							int num4 = A_0.Rows.Count - 1;
							for (int j = 1; j <= num4; j++)
							{
								IL_2F3:
								num2 = 32;
								DataRow dataRow = A_0.Rows[j - 1];
								IL_307:
								num2 = 33;
								DataRow dataRow2 = A_0.Rows[j];
								IL_319:
								num2 = 34;
								decimal num5;
								if (dataRow2.IsNull(newName))
								{
									IL_327:
									num2 = 35;
									num5 = 0m;
								}
								else
								{
									IL_334:
									num2 = 37;
									num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow2[newName]));
								}
								IL_34C:
								num2 = 38;
								decimal num6;
								if (!dataRow.IsNull(newName))
								{
									IL_35A:
									num2 = 39;
									num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow[newName]));
								}
								IL_372:
								num2 = 40;
								if (dataRow.IsNull(newName) | (list.Count > 0 && Oo00.o00O0O_.O.(list, dataRow, dataRow2)))
								{
									IL_399:
									num2 = 41;
									if (totalOn.Aggregate == AggregateEnum.Sum)
									{
										IL_3A6:
										num2 = 42;
										num6 = 0m;
									}
									else
									{
										IL_3B3:
										num2 = 44;
										num6 = num5;
									}
								}
								IL_3BA:
								num2 = 45;
								switch (totalOn.Aggregate)
								{
								case AggregateEnum.Sum:
								case AggregateEnum.Count:
									IL_3ED:
									num2 = 47;
									dataRow2[newName] = decimal.Add(num6, num5);
									break;
								case AggregateEnum.Max:
									IL_425:
									num2 = 51;
									dataRow2[newName] = Math.Max(num6, num5);
									break;
								case AggregateEnum.Min:
									IL_409:
									num2 = 49;
									dataRow2[newName] = Math.Min(num6, num5);
									break;
								}
								IL_43F:
								num2 = 53;
							}
						}
					}
					IL_451:
					num2 = 54;
				}
				IL_460:
				num2 = 55;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_46E:
				num2 = 56;
				if (!(this.Groups.Count == 1 & this.GroupProportion))
				{
					goto IL_49C;
				}
				IL_488:
				num2 = 57;
				this.GroupProportion = false;
				IL_492:
				num2 = 58;
				this.GrandProportion = true;
				IL_49C:
				num2 = 59;
				if (!this.GrandProportion)
				{
					goto IL_7BC;
				}
				IL_4AA:
				num2 = 60;
				IEnumerator<TotalOn> enumerator3 = this.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					TotalOn totalOn2 = enumerator3.Current;
					IL_4C8:
					num2 = 61;
					string newName2 = totalOn2.NewName;
					IL_4D4:
					num2 = 62;
					string text = newName2 + "gdr";
					IL_4E5:
					num2 = 63;
					string text2 = A_0.Columns[newName2].Caption;
					IL_4FC:
					num2 = 64;
					if (Operators.CompareString(text2, "", true) == 0)
					{
						IL_50E:
						num2 = 65;
						if (this.Totals.Count == 1)
						{
							IL_51F:
							num2 = 66;
							text2 = "占比";
						}
						else
						{
							IL_52B:
							num2 = 68;
							text2 = newName2 + "占比";
						}
					}
					else
					{
						IL_53E:
						num2 = 70;
						if (text2.IndexOf("_") > 0)
						{
							IL_550:
							num2 = 71;
							text2 = text2.Substring(0, text2.LastIndexOf("_") + 1) + "占比";
						}
						else
						{
							IL_577:
							num2 = 73;
							if (this.Totals.Count == 1)
							{
								IL_588:
								num2 = 74;
								text2 = "占比";
							}
							else
							{
								IL_594:
								num2 = 76;
								text2 += "占比";
							}
						}
					}
					IL_5A5:
					num2 = 77;
					if (this.GroupProportion)
					{
						IL_5B0:
						num2 = 78;
						text2 += "_总";
					}
					IL_5C1:
					num2 = 79;
					this.o.O0__OO..Add(text);
					IL_5D1:
					num2 = 80;
					A_0.Columns.Add(text, typeof(double));
					IL_5EC:
					num2 = 81;
					A_0.Columns[text].SetOrdinal(A_0.Columns[newName2].Ordinal + 1);
					IL_615:
					num2 = 82;
					A_0.Columns[text].Caption = text2;
					IL_62C:
					num2 = 83;
					A_0.Columns[text].ExtendedProperties.Add("displayformat", "#0.00%");
					IL_650:
					num2 = 84;
					if (totalOn2.upto)
					{
						IL_65C:
						num2 = 85;
						int num7 = A_0.Rows.Count - 1;
						for (int k = 0; k >= num7; k += -1)
						{
							IL_673:
							num2 = 86;
							if (!A_0.Rows[k].IsNull(newName2))
							{
								IL_68C:
								num2 = 87;
								obj = RuntimeHelpers.GetObjectValue(A_0.Rows[k][newName2]);
								break;
							}
							IL_6AB:
							num2 = 89;
						}
					}
					else
					{
						IL_6BC:
						num2 = 91;
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + newName2 + "])", ""));
					}
					IL_6E1:
					num2 = 92;
					double num8;
					if (obj != DBNull.Value)
					{
						IL_6EC:
						num2 = 93;
						num8 = Conversions.ToDouble(obj);
					}
					IL_6F7:
					num2 = 94;
					if (num8 != 0.0)
					{
						IL_70A:
						num2 = 95;
						IEnumerator enumerator4 = A_0.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							object obj2 = enumerator4.Current;
							DataRow dataRow3 = (DataRow)obj2;
							IL_72A:
							num2 = 96;
							if (!dataRow3.IsNull(newName2))
							{
								IL_738:
								num2 = 97;
								dataRow3[text] = Math.Round(Conversions.ToDouble(dataRow3[newName2]) / num8, this.Decimals + 2);
							}
							else
							{
								IL_769:
								num2 = 99;
								dataRow3[text] = 0;
							}
							IL_77B:
							num2 = 100;
						}
						IL_787:
						num2 = 101;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					IL_79F:
					num2 = 102;
				}
				IL_7AE:
				num2 = 103;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_7BC:
				num2 = 104;
				if (!this.GroupProportion || this.Groups.Count <= 1)
				{
					goto IL_EE4;
				}
				IL_7DB:
				num2 = 105;
				for (int l = this.Groups.Count - 2; l >= 0; l += -1)
				{
					IL_7F2:
					num2 = 106;
					IEnumerator<TotalOn> enumerator5 = this.Totals.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						TotalOn totalOn3 = enumerator5.Current;
						IL_810:
						num2 = 107;
						string newName3 = totalOn3.NewName;
						IL_81C:
						num2 = 108;
						string text3 = newName3 + this.Groups[l].NewName + "gpr";
						IL_83F:
						num2 = 109;
						string text4 = A_0.Columns[newName3].Caption;
						IL_856:
						num2 = 110;
						if (Operators.CompareString(text4, "", true) == 0)
						{
							IL_868:
							num2 = 111;
							if (this.Totals.Count == 1)
							{
								IL_879:
								num2 = 112;
								text4 = "占比";
							}
							else
							{
								IL_885:
								num2 = 114;
								text4 = newName3 + "占比";
							}
						}
						else
						{
							IL_898:
							num2 = 116;
							if (text4.IndexOf("_") > 0)
							{
								IL_8AA:
								num2 = 117;
								text4 = text4.Substring(0, text4.LastIndexOf("_") + 1) + "占比";
							}
							else
							{
								IL_8D1:
								num2 = 119;
								if (this.Totals.Count == 1)
								{
									IL_8E2:
									num2 = 120;
									text4 = "占比";
								}
								else
								{
									IL_8EE:
									num2 = 122;
									text4 += "占比";
								}
							}
						}
						IL_8FF:
						num2 = 123;
						if (this.GrandProportion && this.Groups.Count == 2)
						{
							IL_918:
							num2 = 124;
							text4 += "_分";
						}
						IL_929:
						num2 = 125;
						if (this.Groups.Count > 2)
						{
							IL_93A:
							num2 = 126;
							text4 = text4 + "_" + this.Groups[l].NewName;
						}
						IL_95D:
						num2 = 127;
						this.o.O0__OO..Add(text3);
						IL_96D:
						num2 = 128;
						A_0.Columns.Add(text3, typeof(double));
						IL_98B:
						num2 = 129;
						A_0.Columns[text3].SetOrdinal(A_0.Columns[newName3].Ordinal + 1);
						IL_9B7:
						num2 = 130;
						A_0.Columns[text3].Caption = text4;
						IL_9D1:
						num2 = 131;
						A_0.Columns[text3].ExtendedProperties.Add("displayformat", "#0.00%");
						IL_9F8:
						num2 = 132;
						int num9 = A_0.Rows.Count - 1;
						for (int m = 0; m <= num9; m++)
						{
							IL_A15:
							num2 = 133;
							bool flag = true;
							IL_A1E:
							num2 = 134;
							if (m == 0)
							{
								IL_A28:
								num2 = 135;
								flag = false;
							}
							else
							{
								IL_A36:
								num2 = 137;
								int num10 = l;
								for (int n = 0; n <= num10; n++)
								{
									IL_A45:
									num2 = 138;
									if (Operators.CompareString(A_0.Rows[m][this.Groups[n].NewName].ToString(), A_0.Rows[m - 1][this.Groups[n].NewName].ToString(), true) != 0)
									{
										IL_AA7:
										num2 = 139;
										flag = false;
										break;
									}
									IL_AB2:
									num2 = 141;
								}
							}
							IL_AC4:
							num2 = 142;
							double num18;
							if (!flag)
							{
								IL_AD1:
								num2 = 143;
								if (totalOn3.upto)
								{
									IL_AE3:
									num2 = 144;
									bool flag2 = false;
									IL_AEC:
									num2 = 145;
									int num11 = m;
									int num12 = A_0.Rows.Count - 1;
									for (int num13 = num11; num13 <= num12; num13++)
									{
										IL_B0A:
										num2 = 146;
										int num14 = this.Groups.Count - 2;
										for (int num15 = 0; num15 <= num14; num15++)
										{
											IL_B24:
											num2 = 147;
											if (Operators.CompareString(A_0.Rows[num13][this.Groups[num15].NewName].ToString(), A_0.Rows[m][this.Groups[num15].NewName].ToString(), true) != 0)
											{
												IL_B84:
												num2 = 148;
												flag2 = true;
												break;
											}
											IL_B8F:
											num2 = 150;
										}
										IL_BA1:
										num2 = 151;
										if (flag2)
										{
											break;
										}
										IL_BAE:
										num2 = 154;
										obj = RuntimeHelpers.GetObjectValue(A_0.Rows[num13][newName3]);
										IL_BCE:
										num2 = 155;
									}
								}
								else
								{
									IL_BE8:
									num2 = 157;
									string text5 = "";
									IL_BF5:
									num2 = 158;
									int num16 = l;
									for (int num17 = 0; num17 <= num16; num17++)
									{
										IL_C07:
										num2 = 159;
										if (Operators.CompareString(text5, "", true) > 0)
										{
											IL_C1D:
											num2 = 160;
											text5 += " And ";
										}
										IL_C31:
										num2 = 161;
										text5 = text5 + "[" + this.Groups[num17].NewName + "] = ";
										IL_C5C:
										num2 = 162;
										if (A_0.Columns[this.Groups[num17].NewName].DataType == typeof(string))
										{
											IL_C90:
											num2 = 163;
											text5 = text5 + "'" + A_0.Rows[m][this.Groups[num17].NewName].ToString() + "'";
										}
										else
										{
											IL_CD7:
											num2 = 165;
											if (A_0.Columns[this.Groups[num17].NewName].DataType == typeof(DateTime))
											{
												IL_D0B:
												num2 = 166;
												text5 = text5 + "#" + A_0.Rows[m][this.Groups[num17].NewName].ToString() + "#";
											}
											else
											{
												IL_D4F:
												num2 = 168;
												text5 += A_0.Rows[m][this.Groups[num17].NewName].ToString();
											}
										}
										IL_D87:
										num2 = 169;
									}
									IL_D9C:
									num2 = 170;
									obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + newName3 + "])", text5));
								}
								IL_DC1:
								num2 = 171;
								if (obj != DBNull.Value)
								{
									IL_DCF:
									num2 = 172;
									num18 = Conversions.ToDouble(obj);
								}
							}
							IL_DDD:
							num2 = 173;
							if (num18 != 0.0)
							{
								IL_DF3:
								num2 = 174;
								if (!A_0.Rows[m].IsNull(newName3))
								{
									IL_E12:
									num2 = 175;
									if (!A_0.Rows[m].IsNull(newName3))
									{
										IL_E2E:
										num2 = 176;
										A_0.Rows[m][text3] = Math.Round(Conversions.ToDouble(A_0.Rows[m][newName3]) / num18, this.Decimals + 2);
									}
									else
									{
										IL_E78:
										num2 = 178;
										A_0.Rows[m][text3] = 0;
									}
								}
							}
							IL_E98:
							num2 = 179;
						}
						IL_EAD:
						num2 = 180;
					}
					IL_EBF:
					num2 = 181;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
					IL_ED0:
					num2 = 182;
				}
				IL_EE4:
				num2 = 183;
				if (!this.CircleGrowth)
				{
					goto IL_16B6;
				}
				IL_EF5:
				num2 = 184;
				List<string> list2 = new List<string>();
				IL_F02:
				num2 = 185;
				string text6 = "";
				IL_F0F:
				num2 = 186;
				string text7 = "";
				IL_F1C:
				num2 = 187;
				IEnumerator<GroupOn> enumerator6 = this.Groups.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					GroupOn groupOn2 = enumerator6.Current;
					IL_F3D:
					num2 = 188;
					if (A_1.Columns[groupOn2.Name].DataType == typeof(DateTime))
					{
						IL_F66:
						num2 = 189;
						if (Operators.CompareString(text6, "", true) > 0)
						{
							IL_F7C:
							num2 = 190;
							text6 += ",";
						}
						IL_F90:
						num2 = 191;
						text6 += groupOn2.NewName;
					}
					else
					{
						IL_FA8:
						num2 = 193;
						if (Operators.CompareString(text7, "", true) > 0)
						{
							IL_FBE:
							num2 = 194;
							text7 += ",";
						}
						IL_FD2:
						num2 = 195;
						text7 += groupOn2.NewName;
						IL_FE8:
						num2 = 196;
						list2.Add(groupOn2.NewName);
					}
					IL_FFC:
					num2 = 197;
				}
				IL_100E:
				num2 = 198;
				if (enumerator6 != null)
				{
					enumerator6.Dispose();
				}
				IL_101F:
				num2 = 199;
				if (Operators.CompareString(text6, "", true) != 0)
				{
					goto IL_119A;
				}
				IL_1037:
				num2 = 200;
				list2.Clear();
				IL_1044:
				num2 = 201;
				text7 = "";
				IL_1051:
				num2 = 202;
				IEnumerator<GroupOn> enumerator7 = this.Groups.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					GroupOn groupOn3 = enumerator7.Current;
					IL_1072:
					num2 = 203;
					if (A_0.Columns[groupOn3.NewName].DataType == typeof(int) || A_0.Columns[groupOn3.NewName].DataType == typeof(long) || A_0.Columns[groupOn3.NewName].DataType == typeof(short))
					{
						IL_10E1:
						num2 = 204;
						if (Operators.CompareString(text6, "", true) > 0)
						{
							IL_10F7:
							num2 = 205;
							text6 += ",";
						}
						IL_110B:
						num2 = 206;
						text6 += groupOn3.NewName;
					}
					else
					{
						IL_1123:
						num2 = 208;
						if (Operators.CompareString(text7, "", true) > 0)
						{
							IL_1139:
							num2 = 209;
							text7 += ",";
						}
						IL_114D:
						num2 = 210;
						text7 += groupOn3.NewName;
						IL_1163:
						num2 = 211;
						list2.Add(groupOn3.NewName);
					}
					IL_1177:
					num2 = 212;
				}
				IL_1189:
				num2 = 213;
				if (enumerator7 != null)
				{
					enumerator7.Dispose();
				}
				IL_119A:
				num2 = 214;
				if (Operators.CompareString(text6, "", true) <= 0)
				{
					goto IL_16B6;
				}
				IL_11B3:
				num2 = 215;
				IEnumerator<TotalOn> enumerator8 = this.Totals.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					TotalOn totalOn4 = enumerator8.Current;
					IL_11D4:
					num2 = 216;
					string newName4 = totalOn4.NewName;
					IL_11E3:
					num2 = 217;
					string text8 = newName4 + "cle";
					IL_11F7:
					num2 = 218;
					string text9 = A_0.Columns[newName4].Caption;
					IL_1211:
					num2 = 219;
					if (Operators.CompareString(text9, "", true) == 0)
					{
						IL_1226:
						num2 = 220;
						if (this.Totals.Count == 1)
						{
							IL_123A:
							num2 = 221;
							text9 = "环比增长";
						}
						else
						{
							IL_124C:
							num2 = 223;
							text9 = newName4 + "环比";
						}
					}
					else
					{
						IL_1262:
						num2 = 225;
						if (text9.IndexOf("_") > 0)
						{
							IL_1277:
							num2 = 226;
							text9 = text9.Substring(0, text9.LastIndexOf("_") + 1) + "环比";
						}
						else
						{
							IL_12A1:
							num2 = 228;
							if (this.Totals.Count == 1)
							{
								IL_12B5:
								num2 = 229;
								text9 = "环比增长";
							}
							else
							{
								IL_12C4:
								num2 = 231;
								text9 += "环比";
							}
						}
					}
					IL_12D8:
					num2 = 232;
					this.o.O0__OO..Add(text8);
					IL_12EB:
					num2 = 233;
					this.ooO.oO0O00O0..Add(newName4);
					IL_12FE:
					num2 = 234;
					this.o0.o_O0O..Add(text8);
					IL_1311:
					num2 = 235;
					A_0.Columns.Add(text8, typeof(double));
					IL_132F:
					num2 = 236;
					A_0.Columns[text8].SetOrdinal(A_0.Columns[newName4].Ordinal + 1);
					IL_135B:
					num2 = 237;
					A_0.Columns[text8].Caption = text9;
					IL_1375:
					num2 = 238;
					A_0.Columns[text8].ExtendedProperties.Add("displayformat", "#0.00%");
					IL_139C:
					num2 = 239;
					if (list2.Count == 0)
					{
						IL_13AE:
						num2 = 240;
						int num19 = A_0.Rows.Count - 1;
						for (int num20 = 1; num20 <= num19; num20++)
						{
							IL_13CB:
							num2 = 241;
							double num21;
							if (!A_0.Rows[num20 - 1].IsNull(newName4))
							{
								IL_13E9:
								num2 = 242;
								num21 = Conversions.ToDouble(A_0.Rows[num20 - 1][newName4]);
							}
							else
							{
								IL_140E:
								num2 = 244;
								num21 = 0.0;
							}
							IL_141F:
							num2 = 245;
							double num22;
							if (!A_0.Rows[num20].IsNull(newName4))
							{
								IL_143B:
								num2 = 246;
								num22 = Conversions.ToDouble(A_0.Rows[num20][newName4]);
							}
							else
							{
								IL_145E:
								num2 = 248;
								num22 = 0.0;
							}
							IL_146F:
							num2 = 249;
							if (num21 != 0.0)
							{
								IL_1482:
								num2 = 250;
								A_0.Rows[num20][text8] = Math.Round((num22 - num21) / num21, this.Decimals);
							}
							IL_14B4:
							num2 = 251;
						}
					}
					else
					{
						IL_14CE:
						num2 = 253;
						DataView dataView = new DataView(A_0, "", text7 + "," + text6, DataViewRowState.CurrentRows);
						IL_14F1:
						num2 = 254;
						int num23 = dataView.Count - 1;
						for (int num24 = 1; num24 <= num23; num24++)
						{
							IL_150A:
							num2 = 255;
							bool flag3 = true;
							IL_1513:
							num2 = 256;
							List<string>.Enumerator enumerator9 = list2.GetEnumerator();
							while (enumerator9.MoveNext())
							{
								string property = enumerator9.Current;
								IL_152D:
								num2 = 257;
								if (Operators.CompareString(dataView[num24][property].ToString(), dataView[num24 - 1][property].ToString(), true) != 0)
								{
									IL_1567:
									num2 = 258;
									flag3 = false;
								}
								IL_1570:
								num2 = 259;
							}
							IL_157F:
							num2 = 260;
							((IDisposable)enumerator9).Dispose();
							IL_1592:
							num2 = 261;
							if (flag3)
							{
								IL_159F:
								num2 = 262;
								double num25;
								if (!dataView[num24 - 1].Row.IsNull(newName4))
								{
									IL_15BE:
									num2 = 263;
									num25 = Conversions.ToDouble(dataView[num24 - 1][newName4]);
								}
								else
								{
									IL_15DF:
									num2 = 265;
									num25 = 0.0;
								}
								IL_15F0:
								num2 = 266;
								double num26;
								if (!dataView[num24].Row.IsNull(newName4))
								{
									IL_160D:
									num2 = 267;
									num26 = Conversions.ToDouble(dataView[num24][newName4]);
								}
								else
								{
									IL_162C:
									num2 = 269;
									num26 = 0.0;
								}
								IL_163D:
								num2 = 270;
								if (num25 != 0.0)
								{
									IL_1650:
									num2 = 271;
									dataView[num24][text8] = Math.Round((num26 - num25) / num25, this.Decimals);
								}
							}
							IL_167E:
							num2 = 272;
						}
					}
					IL_1693:
					num2 = 273;
				}
				IL_16A5:
				num2 = 274;
				if (enumerator8 != null)
				{
					enumerator8.Dispose();
				}
				IL_16B6:
				num2 = 275;
				if (!this.SamePeriodGrowth)
				{
					goto IL_1E78;
				}
				IL_16C7:
				num2 = 276;
				string text10 = "";
				IL_16D4:
				num2 = 277;
				string left = "";
				IL_16E1:
				num2 = 278;
				IEnumerator<GroupOn> enumerator10 = this.Groups.GetEnumerator();
				while (enumerator10.MoveNext())
				{
					GroupOn groupOn4 = enumerator10.Current;
					IL_1702:
					num2 = 279;
					if (A_1.Columns[groupOn4.Name].DataType == typeof(DateTime))
					{
						IL_172B:
						num2 = 280;
						if (Operators.CompareString(text10, "", true) == 0)
						{
							IL_1740:
							num2 = 281;
							text10 = groupOn4.NewName;
						}
						else
						{
							IL_1751:
							num2 = 283;
							if (Operators.CompareString(left, "", true) == 0)
							{
								IL_1766:
								num2 = 284;
								left = groupOn4.NewName;
								break;
							}
						}
					}
					IL_1777:
					num2 = 286;
				}
				IL_1789:
				num2 = 287;
				if (enumerator10 != null)
				{
					enumerator10.Dispose();
				}
				IL_179A:
				num2 = 288;
				if (Operators.CompareString(text10, "", true) != 0 || Operators.CompareString(left, "", true) != 0)
				{
					goto IL_18C3;
				}
				IL_17C4:
				num2 = 289;
				IEnumerator<GroupOn> enumerator11 = this.Groups.GetEnumerator();
				while (enumerator11.MoveNext())
				{
					GroupOn groupOn5 = enumerator11.Current;
					IL_17E5:
					num2 = 290;
					if (A_0.Columns[groupOn5.NewName].DataType == typeof(int) || A_0.Columns[groupOn5.NewName].DataType == typeof(long) || A_0.Columns[groupOn5.NewName].DataType == typeof(short))
					{
						IL_1854:
						num2 = 291;
						if (Operators.CompareString(text10, "", true) == 0)
						{
							IL_1869:
							num2 = 292;
							text10 = groupOn5.NewName;
						}
						else
						{
							IL_187A:
							num2 = 294;
							if (Operators.CompareString(left, "", true) == 0)
							{
								IL_188F:
								num2 = 295;
								left = groupOn5.NewName;
								break;
							}
						}
					}
					IL_18A0:
					num2 = 297;
				}
				IL_18B2:
				num2 = 298;
				if (enumerator11 != null)
				{
					enumerator11.Dispose();
				}
				IL_18C3:
				num2 = 299;
				if (Operators.CompareString(left, "", true) <= 0)
				{
					goto IL_1E78;
				}
				IL_18DC:
				num2 = 300;
				List<string> list3 = new List<string>();
				IL_18E9:
				num2 = 301;
				string text11 = "";
				IL_18F6:
				num2 = 302;
				IEnumerator<GroupOn> enumerator12 = this.Groups.GetEnumerator();
				while (enumerator12.MoveNext())
				{
					GroupOn groupOn6 = enumerator12.Current;
					IL_1917:
					num2 = 303;
					if (Operators.CompareString(text10, groupOn6.NewName, true) != 0)
					{
						IL_1931:
						num2 = 305;
						list3.Add(groupOn6.NewName);
						IL_1945:
						num2 = 306;
						if (Operators.CompareString(text11, "", true) > 0)
						{
							IL_195B:
							num2 = 307;
							text11 += " And ";
						}
						IL_196F:
						num2 = 308;
						text11 = text11 + "[" + groupOn6.NewName + "] = ";
						IL_198F:
						num2 = 309;
						if (A_0.Columns[groupOn6.NewName].DataType == typeof(string))
						{
							IL_19B8:
							num2 = 310;
							text11 = text11 + "'{" + groupOn6.NewName + "}'";
						}
						else
						{
							IL_19DA:
							num2 = 312;
							if (A_0.Columns[groupOn6.NewName].DataType == typeof(DateTime))
							{
								IL_1A03:
								num2 = 313;
								text11 = text11 + "#{" + groupOn6.NewName + "}#";
							}
							else
							{
								IL_1A25:
								num2 = 315;
								text11 = text11 + "{" + groupOn6.NewName + "}";
							}
						}
					}
					IL_1A45:
					num2 = 316;
				}
				IL_1A57:
				num2 = 317;
				if (enumerator12 != null)
				{
					enumerator12.Dispose();
				}
				IL_1A68:
				num2 = 318;
				IEnumerator<TotalOn> enumerator13 = this.Totals.GetEnumerator();
				while (enumerator13.MoveNext())
				{
					TotalOn totalOn5 = enumerator13.Current;
					IL_1A89:
					num2 = 319;
					string newName5 = totalOn5.NewName;
					IL_1A98:
					num2 = 320;
					string text12 = newName5 + "stp";
					IL_1AAC:
					num2 = 321;
					string text13 = A_0.Columns[newName5].Caption;
					IL_1AC6:
					num2 = 322;
					if (Operators.CompareString(text13, "", true) == 0)
					{
						IL_1ADB:
						num2 = 323;
						if (this.Totals.Count == 1)
						{
							IL_1AEF:
							num2 = 324;
							text13 = "同比增长";
						}
						else
						{
							IL_1B01:
							num2 = 326;
							text13 = newName5 + "同比";
						}
					}
					else
					{
						IL_1B17:
						num2 = 328;
						if (text13.IndexOf("_") > 0)
						{
							IL_1B2C:
							num2 = 329;
							text13 = text13.Substring(0, text13.LastIndexOf("_") + 1) + "同比";
						}
						else
						{
							IL_1B56:
							num2 = 331;
							if (this.Totals.Count == 1)
							{
								IL_1B6A:
								num2 = 332;
								text13 = "同比增长";
							}
							else
							{
								IL_1B79:
								num2 = 334;
								text13 += "同比";
							}
						}
					}
					IL_1B8D:
					num2 = 335;
					this.o.O0__OO..Add(text12);
					IL_1BA0:
					num2 = 336;
					this.ooO.oO0O00O0..Add(newName5);
					IL_1BB3:
					num2 = 337;
					this.o0.o_O0O..Add(text12);
					IL_1BC6:
					num2 = 338;
					A_0.Columns.Add(text12, typeof(double));
					IL_1BE4:
					num2 = 339;
					A_0.Columns[text12].SetOrdinal(A_0.Columns[newName5].Ordinal + 1);
					IL_1C10:
					num2 = 340;
					A_0.Columns[text12].Caption = text13;
					IL_1C2A:
					num2 = 341;
					A_0.Columns[text12].ExtendedProperties.Add("displayformat", "#0.00%");
					IL_1C51:
					num2 = 342;
					IEnumerator enumerator14 = A_0.Rows.GetEnumerator();
					while (enumerator14.MoveNext())
					{
						object obj3 = enumerator14.Current;
						DataRow dataRow4 = (DataRow)obj3;
						IL_1C77:
						num2 = 343;
						string text14 = text11;
						IL_1C81:
						num2 = 344;
						List<string>.Enumerator enumerator15 = list3.GetEnumerator();
						while (enumerator15.MoveNext())
						{
							string text15 = enumerator15.Current;
							IL_1C9B:
							num2 = 345;
							text14 = text14.Replace("{" + text15 + "}", dataRow4[text15].ToString());
							IL_1CC9:
							num2 = 346;
						}
						IL_1CD8:
						num2 = 347;
						((IDisposable)enumerator15).Dispose();
						IL_1CEB:
						num2 = 348;
						if (!dataRow4.IsNull(text10))
						{
							IL_1CFF:
							num2 = 349;
							int num27 = Conversions.ToInteger(dataRow4[text10]);
							IL_1D15:
							num2 = 352;
							text14 = string.Concat(new string[]
							{
								text14,
								" And [",
								text10,
								"] = ",
								Conversions.ToString(num27 - 1)
							});
							IL_1D4E:
							num2 = 353;
							DataRow[] array = A_0.Select(text14);
							IL_1D5E:
							num2 = 354;
							if (array.Length >= 1)
							{
								IL_1D6E:
								num2 = 355;
								DataRow dataRow5 = array[0];
								IL_1D7A:
								num2 = 356;
								double num28;
								if (!dataRow5.IsNull(newName5))
								{
									IL_1D8B:
									num2 = 357;
									num28 = Conversions.ToDouble(dataRow5[newName5]);
								}
								else
								{
									IL_1DA3:
									num2 = 359;
									num28 = 0.0;
								}
								IL_1DB4:
								num2 = 360;
								double num29;
								if (!dataRow4.IsNull(newName5))
								{
									IL_1DC5:
									num2 = 361;
									num29 = Conversions.ToDouble(dataRow4[newName5]);
								}
								else
								{
									IL_1DDD:
									num2 = 363;
									num29 = 0.0;
								}
								IL_1DEE:
								num2 = 364;
								if (num28 > 0.0)
								{
									IL_1E01:
									num2 = 365;
									dataRow4[text12] = Math.Round((num29 - num28) / num28, this.Decimals);
								}
							}
						}
						IL_1E28:
						num2 = 366;
					}
					IL_1E3A:
					num2 = 367;
					if (enumerator14 is IDisposable)
					{
						(enumerator14 as IDisposable).Dispose();
					}
					IL_1E55:
					num2 = 368;
				}
				IL_1E67:
				num2 = 369;
				if (enumerator13 != null)
				{
					enumerator13.Dispose();
				}
				IL_1E78:
				num2 = 370;
				if (this.Subtotal)
				{
					goto IL_20B9;
				}
				IL_1E89:
				num2 = 372;
				if (!this.VerticalTotal)
				{
					goto IL_20B9;
				}
				IL_1E9A:
				num2 = 373;
				DataRow dataRow6 = A_0.NewRow();
				IL_1EA8:
				num2 = 374;
				IEnumerator<TotalOn> enumerator16 = this.Totals.GetEnumerator();
				while (enumerator16.MoveNext())
				{
					TotalOn totalOn6 = enumerator16.Current;
					IL_1EC9:
					num2 = 375;
					string newName6 = totalOn6.NewName;
					IL_1ED8:
					num2 = 376;
					switch (totalOn6.Aggregate)
					{
					case AggregateEnum.Sum:
					case AggregateEnum.Count:
						IL_1F11:
						num2 = 378;
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + totalOn6.NewName + "])", ""));
						break;
					case AggregateEnum.Average:
						IL_1F43:
						num2 = 380;
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Avg([" + totalOn6.NewName + "])", ""));
						break;
					case AggregateEnum.Max:
						IL_1F72:
						num2 = 382;
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Max([" + totalOn6.NewName + "])", ""));
						break;
					case AggregateEnum.Min:
						IL_1FA1:
						num2 = 384;
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Min([" + totalOn6.NewName + "])", ""));
						break;
					}
					IL_1FCE:
					num2 = 386;
					if (obj != DBNull.Value)
					{
						IL_1FDC:
						num2 = 387;
						dataRow6[newName6] = Math.Round(Conversions.ToDecimal(obj), this.Decimals);
					}
					IL_2001:
					num2 = 388;
				}
				IL_2013:
				num2 = 389;
				if (enumerator16 != null)
				{
					enumerator16.Dispose();
				}
				IL_2024:
				num2 = 390;
				IEnumerator<GroupOn> enumerator17 = this.Groups.GetEnumerator();
				while (enumerator17.MoveNext())
				{
					GroupOn groupOn7 = enumerator17.Current;
					IL_2042:
					num2 = 391;
					if (A_0.Columns[groupOn7.NewName].DataType == typeof(string))
					{
						IL_206B:
						num2 = 392;
						dataRow6[groupOn7.NewName] = "合计";
						break;
					}
					IL_2086:
					num2 = 394;
				}
				IL_2095:
				num2 = 395;
				if (enumerator17 != null)
				{
					enumerator17.Dispose();
				}
				IL_20A6:
				num2 = 396;
				A_0.Rows.Add(dataRow6);
				IL_20B9:
				num2 = 397;
				A_0.AcceptChanges();
				IL_20C5:
				goto IL_274F;
				IL_20CA:
				int num30 = num31 + 1;
				num31 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num30);
				IL_2710:
				goto IL_2744;
				IL_2712:
				num31 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2722:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num31 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_2712;
			}
			IL_2744:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_274F:
			if (num31 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000F05F8 File Offset: 0x000EE7F8
		protected DataTable <<EMPTY_NAME>>(DataTable A_0, bool A_1, string A_2)
		{
			A_0.TableName = this.TableName;
			DataTable dataTable;
			if (A_1)
			{
				dataTable = new DataTable(A_0, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				dataTable.o.0O000_.();
			}
			else
			{
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(A_0);
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(A_0, null, null, this.TableName, O_O0OO.OoO.0OO__0ooo.()));
				OO_00oOO.DataTables[this.TableName].o.0O000_.();
				OO_00oOO.DataTables[this.TableName].AddByCode = true;
				OO_00oOO.DataTables[this.TableName].Caption = this.Caption;
				dataTable = OO_00oOO.DataTables[this.TableName];
			}
			try
			{
				foreach (DataCol dataCol in dataTable.DataCols)
				{
					if (Operators.CompareString(dataCol.BaseColumn.Caption, "", true) > 0)
					{
						dataCol.Caption = dataCol.BaseColumn.Caption;
						dataCol.BaseColumn.Caption = "";
					}
					if (dataCol.BaseColumn.ExtendedProperties.ContainsKey("IsTimeSpan"))
					{
						dataCol.ExtendColumnType = ExtendColumnTypeEnum.时段;
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
			DataTable result;
			if (A_1)
			{
				result = dataTable;
			}
			else
			{
				new O_0(O_O0OO.o__.O.(), A_0);
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
				Main.OO_O.o..o0_o_o_0.0O.(this.TableName, this.TableVisible, false);
				try
				{
					foreach (string text in this.o.O0__OO.)
					{
						OO_00oOO.Tables[this.TableName].foxGrid.Cols[text].Format = "#0.00%";
						OO_00oOO.DataTables[this.TableName].DataCols[text].PercentStyle = true;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (Operators.CompareString(A_2, this.TableName, true) == 0)
				{
					OO_00oOO.MainTable = OO_00oOO.Tables[this.TableName];
				}
				result = dataTable;
			}
			return result;
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000F0840 File Offset: 0x000EEA40
		private void <<EMPTY_NAME>>(DataRow A_0)
		{
			try
			{
				foreach (TotalOn totalOn in this.Totals)
				{
					if (!A_0.IsNull(totalOn.Name))
					{
						switch (totalOn.Aggregate)
						{
						case AggregateEnum.Sum:
						case AggregateEnum.Average:
							totalOn.Oo_o0O00O.o0O.++;
							totalOn.Oo_o0O00O.o0O. += Convert.ToDouble(Conversions.ToDecimal(A_0[totalOn.Name]));
							break;
						case AggregateEnum.Count:
							totalOn.Oo_o0O00O.o0O.++;
							break;
						case AggregateEnum.Max:
							totalOn.Oo_o0O00O.o0O.++;
							if (totalOn.Oo_o0O00O.o0O. == 1)
							{
								totalOn.Oo_o0O00O.o0O. = Convert.ToDouble(Conversions.ToDecimal(A_0[totalOn.Name]));
							}
							else
							{
								totalOn.Oo_o0O00O.o0O. = Math.Max(totalOn.Oo_o0O00O.o0O., Convert.ToDouble(Conversions.ToDecimal(A_0[totalOn.Name])));
							}
							break;
						case AggregateEnum.Min:
							totalOn.Oo_o0O00O.o0O.++;
							if (totalOn.Oo_o0O00O.o0O. == 1)
							{
								totalOn.Oo_o0O00O.o0O. = Convert.ToDouble(Conversions.ToDecimal(A_0[totalOn.Name]));
							}
							else
							{
								totalOn.Oo_o0O00O.o0O. = Math.Min(totalOn.Oo_o0O00O.o0O., Convert.ToDouble(Conversions.ToDecimal(A_0[totalOn.Name])));
							}
							break;
						}
					}
				}
			}
			finally
			{
				IEnumerator<TotalOn> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000F09E0 File Offset: 0x000EEBE0
		private int <<EMPTY_NAME>>(DateTime A_0, DateGroupEnum A_1)
		{
			int result;
			switch (A_1)
			{
			case DateGroupEnum.Year:
				result = A_0.Year;
				break;
			case DateGroupEnum.Quarter:
				result = DateAndTime.DatePart(DateInterval.Quarter, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				break;
			case DateGroupEnum.Month:
				result = A_0.Month;
				break;
			case DateGroupEnum.Week:
				result = DateAndTime.DatePart(DateInterval.WeekOfYear, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				break;
			case DateGroupEnum.Day:
				result = A_0.Day;
				break;
			case DateGroupEnum.Hour:
				result = A_0.Hour;
				break;
			case DateGroupEnum.Minute:
				result = A_0.Minute;
				break;
			case DateGroupEnum.Second:
				result = A_0.Second;
				break;
			case DateGroupEnum.DayOfYear:
				result = DateAndTime.DatePart(DateInterval.DayOfYear, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				break;
			case DateGroupEnum.DayOfWeek:
				result = DateAndTime.DatePart(DateInterval.Weekday, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		/// <summary>
		/// 统计后台数据时的超时时限，默认为30秒
		/// </summary>
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000F0A90 File Offset: 0x000EEC90
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x000F0A98 File Offset: 0x000EEC98
		public int CommandTimeOut
		{
			get
			{
				return this.Oo.O0O_0.;
			}
			set
			{
				this.Oo.O0O_0. = value;
			}
		}

		// Token: 0x04000E02 RID: 3586
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E03 RID: 3587
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E04 RID: 3588
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E05 RID: 3589
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E06 RID: 3590
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E07 RID: 3591
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E08 RID: 3592
		private GroupCollection <<EMPTY_NAME>>;

		// Token: 0x04000E09 RID: 3593
		private TotalCollection <<EMPTY_NAME>>;

		// Token: 0x04000E0A RID: 3594
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000E0B RID: 3595
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E0C RID: 3596
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E0D RID: 3597
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E0E RID: 3598
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E0F RID: 3599
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E10 RID: 3600
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E11 RID: 3601
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E12 RID: 3602
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E13 RID: 3603
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E14 RID: 3604
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E15 RID: 3605
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E16 RID: 3606
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000E17 RID: 3607
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000E18 RID: 3608
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000E19 RID: 3609
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E1A RID: 3610
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000E1B RID: 3611
		protected HttpClient <<EMPTY_NAME>>;
	}
}
