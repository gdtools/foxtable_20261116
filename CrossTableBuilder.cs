using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 交叉统计工具
	/// </summary>
	// Token: 0x02000290 RID: 656
	[ComVisible(true)]
	[oO0oooo("0678")]
	public class CrossTableBuilder
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x000E3228 File Offset: 0x000E1428
		internal CrossTableBuilder()
		{
			this.o0__oo.o_0o. = true;
			this.OO0o_O00.o. = new GroupCollection();
			this.O.oOO_0. = new CrossGroupCollection();
			this.o0__oo.o_0o. = new CrossTotalCollection();
			this.o_o00_O.0_oo. = 4;
			this.oo.o. = "份额";
			this.oO.00__O__. = "占比";
			this.O.0O__oOO0. = -1;
			this.O.oOO_0. = new List<string>();
			this.Oo_0O0o.ooO. = new List<string>();
			this.O_O_ooo.OOOOoo. = new List<string>();
			this.O0OO.00OOO_O. = 30;
			this.o.000Oo_o. = new List<string>();
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SourceDataTable">要统计的数据表</param>
		// Token: 0x060020B6 RID: 8374 RVA: 0x000E32BC File Offset: 0x000E14BC
		public CrossTableBuilder(string A_0, DataTable A_1)
		{
			this.o0__oo.o_0o. = true;
			this.OO0o_O00.o. = new GroupCollection();
			this.O.oOO_0. = new CrossGroupCollection();
			this.o0__oo.o_0o. = new CrossTotalCollection();
			this.o_o00_O.0_oo. = 4;
			this.oo.o. = "份额";
			this.oO.00__O__. = "占比";
			this.O.0O__oOO0. = -1;
			this.O.oOO_0. = new List<string>();
			this.Oo_0O0o.ooO. = new List<string>();
			this.O_O_ooo.OOOOoo. = new List<string>();
			this.O0OO.00OOO_O. = 30;
			this.o.000Oo_o. = new List<string>();
			this.o0__oo.o_0o. = A_0;
			this.o0__oo.o_0o. = A_1;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SourceDataTable">要统计的数据表</param>
		/// <param name="Filter">统计条件</param>
		// Token: 0x060020B7 RID: 8375 RVA: 0x000E3360 File Offset: 0x000E1560
		public CrossTableBuilder(string A_0, DataTable A_1, string A_2)
		{
			this.o0__oo.o_0o. = true;
			this.OO0o_O00.o. = new GroupCollection();
			this.O.oOO_0. = new CrossGroupCollection();
			this.o0__oo.o_0o. = new CrossTotalCollection();
			this.o_o00_O.0_oo. = 4;
			this.oo.o. = "份额";
			this.oO.00__O__. = "占比";
			this.O.0O__oOO0. = -1;
			this.O.oOO_0. = new List<string>();
			this.Oo_0O0o.ooO. = new List<string>();
			this.O_O_ooo.OOOOoo. = new List<string>();
			this.O0OO.00OOO_O. = 30;
			this.o.000Oo_o. = new List<string>();
			this.o0__oo.o_0o. = A_0;
			this.o0__oo.o_0o. = A_1;
			this.ooO._. = A_2;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SelectString">Select语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x060020B8 RID: 8376 RVA: 0x000E3408 File Offset: 0x000E1608
		public CrossTableBuilder(string A_0, string A_1, string A_2)
		{
			this.o0__oo.o_0o. = true;
			this.OO0o_O00.o. = new GroupCollection();
			this.O.oOO_0. = new CrossGroupCollection();
			this.o0__oo.o_0o. = new CrossTotalCollection();
			this.o_o00_O.0_oo. = 4;
			this.oo.o. = "份额";
			this.oO.00__O__. = "占比";
			this.O.0O__oOO0. = -1;
			this.O.oOO_0. = new List<string>();
			this.Oo_0O0o.ooO. = new List<string>();
			this.O_O_ooo.OOOOoo. = new List<string>();
			this.O0OO.00OOO_O. = 30;
			this.o.000Oo_o. = new List<string>();
			this.o0__oo.o_0o. = A_0;
			this.o0o__0_.oO_. = A_1;
			this.oOOO._. = A_2;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SelectString">Select语句</param>
		// Token: 0x060020B9 RID: 8377 RVA: 0x000E34B0 File Offset: 0x000E16B0
		public CrossTableBuilder(string A_0, string A_1)
		{
			this.o0__oo.o_0o. = true;
			this.OO0o_O00.o. = new GroupCollection();
			this.O.oOO_0. = new CrossGroupCollection();
			this.o0__oo.o_0o. = new CrossTotalCollection();
			this.o_o00_O.0_oo. = 4;
			this.oo.o. = "份额";
			this.oO.00__O__. = "占比";
			this.O.0O__oOO0. = -1;
			this.O.oOO_0. = new List<string>();
			this.Oo_0O0o.ooO. = new List<string>();
			this.O_O_ooo.OOOOoo. = new List<string>();
			this.O0OO.00OOO_O. = 30;
			this.o.000Oo_o. = new List<string>();
			this.o0__oo.o_0o. = A_0;
			this.o0o__0_.oO_. = A_1;
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000E3551 File Offset: 0x000E1751
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x000E3559 File Offset: 0x000E1759
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SelectString
		{
			get
			{
				return this.o0o__0_.oO_.;
			}
			set
			{
				this.o0o__0_.oO_. = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x000E3562 File Offset: 0x000E1762
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x000E356A File Offset: 0x000E176A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ConnectionName
		{
			get
			{
				return this.oOOO._.;
			}
			set
			{
				this.oOOO._. = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x000E3573 File Offset: 0x000E1773
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x000E357B File Offset: 0x000E177B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TableName
		{
			get
			{
				return this.o0__oo.o_0o.;
			}
			set
			{
				this.o0__oo.o_0o. = value;
			}
		}

		/// <summary>
		/// 统计结果保留的小数位数
		/// </summary>
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x000E3584 File Offset: 0x000E1784
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x000E358C File Offset: 0x000E178C
		public int Decimals
		{
			get
			{
				return this.o_o00_O.0_oo.;
			}
			set
			{
				this.o_o00_O.0_oo. = value;
			}
		}

		/// <summary>
		/// 是否直接统计后台数据
		/// </summary>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x000E3598 File Offset: 0x000E1798
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x000E3622 File Offset: 0x000E1822
		[oO0oooo("1623")]
		public bool FromServer
		{
			get
			{
				return this.SourceDataTable != null && Operators.CompareString(this.SelectString, "", true) <= 0 && (this.SourceDataTable.frd_IsOuterTable || this.SourceDataTable.frd_IsInnerTable || this.SourceDataTable.frd_IsOuterQuery || this.SourceDataTable.frd_IsInnerQuery || Operators.CompareString(this.SourceDataTable.DataServer, "", true) > 0) && this.OoO.o_ooO.;
			}
			set
			{
				this.OoO.o_ooO. = value;
			}
		}

		/// <summary>
		/// 设置生成的统计表的Visible属性
		/// </summary>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x000E362B File Offset: 0x000E182B
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x000E3633 File Offset: 0x000E1833
		public bool TableVisible
		{
			get
			{
				return this.o0__oo.o_0o.;
			}
			set
			{
				this.o0__oo.o_0o. = value;
			}
		}

		/// <summary>
		/// 设置生成的统计表的标题
		/// </summary>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000E363C File Offset: 0x000E183C
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x000E3644 File Offset: 0x000E1844
		public string Caption
		{
			get
			{
				return this.OO0._O_0O.;
			}
			set
			{
				this.OO0._O_0O. = value;
			}
		}

		/// <summary>
		/// 要统计的数据表
		/// </summary>
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000E364D File Offset: 0x000E184D
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x000E3655 File Offset: 0x000E1855
		public DataTable SourceDataTable
		{
			get
			{
				return this.o0__oo.o_0o.;
			}
			set
			{
				this.o0__oo.o_0o. = value;
			}
		}

		/// <summary>
		/// 统计条件
		/// </summary>
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000E365E File Offset: 0x000E185E
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x000E3666 File Offset: 0x000E1866
		public string Filter
		{
			get
			{
				return this.ooO._.;
			}
			set
			{
				this.ooO._. = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000E366F File Offset: 0x000E186F
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x000E3677 File Offset: 0x000E1877
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ExtendFilter
		{
			get
			{
				return this.oO._o_0_00o__0.;
			}
			set
			{
				this.oO._o_0_00o__0. = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000E3680 File Offset: 0x000E1880
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x000E3688 File Offset: 0x000E1888
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool FromAll
		{
			get
			{
				return this.O_O.o.;
			}
			set
			{
				this.O_O.o. = value;
			}
		}

		/// <summary>
		/// 是否在水平方向自动增加汇总列
		/// </summary>
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000E3691 File Offset: 0x000E1891
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x000E3699 File Offset: 0x000E1899
		public bool HorizontalTotal
		{
			get
			{
				return this.ooO._.;
			}
			set
			{
				this.ooO._. = value;
			}
		}

		/// <summary>
		/// 是否在垂直方向自动增加汇总行
		/// </summary>
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000E36A2 File Offset: 0x000E18A2
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x000E36AA File Offset: 0x000E18AA
		public bool VerticalTotal
		{
			get
			{
				return this.ooOO._o__OO.;
			}
			set
			{
				this.ooOO._o__OO. = value;
			}
		}

		/// <summary>
		/// 是否生成水平份额
		/// </summary>
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x000E36B3 File Offset: 0x000E18B3
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x000E36BB File Offset: 0x000E18BB
		[oO0oooo("1619")]
		public bool HorizontalProportion
		{
			get
			{
				return this.oo.o.;
			}
			set
			{
				this.oo.o. = value;
			}
		}

		/// <summary>
		/// 是否生成垂直占比
		/// </summary>
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x000E36C4 File Offset: 0x000E18C4
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x000E36CC File Offset: 0x000E18CC
		[oO0oooo("1619")]
		public bool VerticalProportion
		{
			get
			{
				return this.oO.00__O__.;
			}
			set
			{
				this.oO.00__O__. = value;
			}
		}

		/// <summary>
		/// 是否生成同比增长率。
		/// </summary>
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000E36D5 File Offset: 0x000E18D5
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x000E36DD File Offset: 0x000E18DD
		[oO0oooo("3286")]
		public bool SamePeriodGrowth
		{
			get
			{
				return this.Oo.OO.;
			}
			set
			{
				this.Oo.OO. = value;
			}
		}

		/// <summary>
		/// 是否生成环比增长率
		/// </summary>
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000E36E6 File Offset: 0x000E18E6
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x000E36EE File Offset: 0x000E18EE
		[oO0oooo("3286")]
		public bool CircleGrowth
		{
			get
			{
				return this.OoO_O_o._.;
			}
			set
			{
				this.OoO_O_o._. = value;
			}
		}

		/// <summary>
		/// 是否生成汇总模式
		/// </summary>
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000E36F7 File Offset: 0x000E18F7
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x000E36FF File Offset: 0x000E18FF
		[oO0oooo("2671")]
		public bool Subtotal
		{
			get
			{
				return this.o.ooOo__00.;
			}
			set
			{
				this.o.ooOo__00. = value;
			}
		}

		/// <summary>
		/// 设置汇总模式的层数
		/// </summary>
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000E3708 File Offset: 0x000E1908
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x000E3710 File Offset: 0x000E1910
		[oO0oooo("2671")]
		public int SubtotalLevel
		{
			get
			{
				return this.O.0O__oOO0.;
			}
			set
			{
				this.O.0O__oOO0. = value;
			}
		}

		/// <summary>
		/// 设置水平份额标题，默认为“份额”
		/// </summary>
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000E371C File Offset: 0x000E191C
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x000E374D File Offset: 0x000E194D
		[oO0oooo("1619")]
		public string HorizontalProportionCaption
		{
			get
			{
				string result;
				if (Operators.CompareString(this.oo.o., "", true) > 0)
				{
					result = this.oo.o.;
				}
				else
				{
					result = "份额";
				}
				return result;
			}
			set
			{
				this.oo.o. = value;
			}
		}

		/// <summary>
		/// 用于设置垂直占比标题，默认为“占比”
		/// </summary>
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000E3758 File Offset: 0x000E1958
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x000E3789 File Offset: 0x000E1989
		[oO0oooo("1619")]
		public string VerticalProportionCaption
		{
			get
			{
				string result;
				if (Operators.CompareString(this.oO.00__O__., "", true) > 0)
				{
					result = this.oO.00__O__.;
				}
				else
				{
					result = "占比";
				}
				return result;
			}
			set
			{
				this.oO.00__O__. = value;
			}
		}

		/// <summary>
		/// 水平分组
		/// </summary>
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000E3792 File Offset: 0x000E1992
		public GroupCollection HGroups
		{
			get
			{
				return this.OO0o_O00.o.;
			}
		}

		/// <summary>
		/// 垂直分组
		/// </summary>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000E379A File Offset: 0x000E199A
		public CrossGroupCollection VGroups
		{
			get
			{
				return this.O.oOO_0.;
			}
		}

		/// <summary>
		/// 统计列集合
		/// </summary>
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000E37A2 File Offset: 0x000E19A2
		public CrossTotalCollection Totals
		{
			get
			{
				return this.o0__oo.o_0o.;
			}
		}

		/// <summary>
		/// 在有多个统计列时，是否将同一个统计列的数据排放在一起
		/// </summary>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x000E37AA File Offset: 0x000E19AA
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x000E37B2 File Offset: 0x000E19B2
		public bool OrderByTotal
		{
			get
			{
				return this.oOoo.O.;
			}
			set
			{
				this.oOoo.O. = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x000E37BB File Offset: 0x000E19BB
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x000E37C3 File Offset: 0x000E19C3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpClient HttpClient
		{
			get
			{
				return this.OO0o_O00.o.;
			}
			set
			{
				this.OO0o_O00.o. = value;
			}
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000E37CC File Offset: 0x000E19CC
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
		// Token: 0x060020EC RID: 8428 RVA: 0x000E3810 File Offset: 0x000E1A10
		public virtual DataTable Build()
		{
			if (Operators.CompareString(this.SelectString, "", true) == 0 && OO_00oOO.Tables.get_Contains(this.SourceDataTable.Name))
			{
				OO_00oOO.Tables[this.SourceDataTable.Name].O_0._O_0OO000O. = this;
			}
			return this.Build(false);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTable，不生成Table</param>
		// Token: 0x060020ED RID: 8429 RVA: 0x000E386C File Offset: 0x000E1A6C
		public virtual DataTable Build(bool OnlyDataTable)
		{
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
			DataTable result;
			if ((this.HGroups.Count == 0 || this.VGroups.Count == 0) | this.Totals.Count == 0)
			{
				result = null;
			}
			else
			{
				DataTable dataTable = this.BuildDataSource();
				DataTable dataTable2 = this.O0oo00.0O_oO_.(dataTable, OnlyDataTable, a_);
				if (this.Subtotal && !OnlyDataTable)
				{
					this.o_o00_O.0_oo.(dataTable2.Name, dataTable);
				}
				result = dataTable2;
			}
			return result;
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000E3958 File Offset: 0x000E1B58
		protected internal void <<EMPTY_NAME>>(string A_0, DataTable A_1)
		{
			Table table = OO_00oOO.Tables[A_0];
			table.SubtotalGroups.Clear();
			int num;
			if (this.SubtotalLevel == -1)
			{
				num = int.MaxValue;
			}
			else
			{
				num = this.SubtotalLevel;
			}
			if (num > 0)
			{
				for (int i = Math.Min(this.SubtotalLevel - 1, this.o.000Oo_o..Count - 2); i >= 0; i += -1)
				{
					SubtotalGroup subtotalGroup = new SubtotalGroup();
					subtotalGroup.GroupOn = this.o.000Oo_o.[i];
					subtotalGroup.TotalOn = this.o0_.o..Trim(new char[]
					{
						','
					}) + "," + this.o_o.__.;
					if (this.Totals.Count > 0)
					{
						if (this.Totals[0].Aggregate == AggregateEnum.Count)
						{
							subtotalGroup.Aggregate = AggregateEnum.Sum;
						}
						else
						{
							subtotalGroup.Aggregate = this.Totals[0].Aggregate;
						}
					}
					else if (this.Totals.Exprs.Count > 0)
					{
						if (this.Totals.Exprs[0].Aggregate == AggregateEnum.Count)
						{
							subtotalGroup.Aggregate = AggregateEnum.Sum;
						}
						else
						{
							subtotalGroup.Aggregate = this.Totals.Exprs[0].Aggregate;
						}
					}
					subtotalGroup.Caption = "小计 {0}";
					table.SubtotalGroups.Add(subtotalGroup);
					int num2;
					num2++;
					if (num2 >= num)
					{
						break;
					}
				}
			}
			SubtotalGroup subtotalGroup2 = new SubtotalGroup();
			subtotalGroup2.GroupOn = "*";
			if (table.SubtotalGroups.Count == 0)
			{
				subtotalGroup2.TotalOn = this.o0_.o..Trim(new char[]
				{
					','
				}) + "," + this.o_o.__.;
			}
			else
			{
				subtotalGroup2.TotalOn = this.O__0O_o_.0_OO_..Trim(new char[]
				{
					','
				}) + "," + this.o_o.__.;
			}
			if (this.Totals.Count > 0)
			{
				if (this.Totals[0].Aggregate == AggregateEnum.Count)
				{
					subtotalGroup2.Aggregate = AggregateEnum.Sum;
				}
				else
				{
					subtotalGroup2.Aggregate = this.Totals[0].Aggregate;
				}
			}
			else if (this.Totals.Exprs.Count > 0)
			{
				if (this.Totals.Exprs[0].Aggregate == AggregateEnum.Count)
				{
					subtotalGroup2.Aggregate = AggregateEnum.Sum;
				}
				else
				{
					subtotalGroup2.Aggregate = this.Totals.Exprs[0].Aggregate;
				}
			}
			subtotalGroup2.Caption = "总计";
			table.SubtotalGroups.Add(subtotalGroup2);
			table.Subtotal(false);
			if (this.Oo_0O0o.ooO..Count > 0)
			{
				O_oOooO_O o_oOooO_O = table.foxGrid;
				int num3 = o_oOooO_O.Rows.Count - 1;
				int num4 = o_oOooO_O.Rows.Fixed + 1;
				for (int j = num3; j >= num4; j += -1)
				{
					Row row = o_oOooO_O.Rows[j];
					if (row.IsNode && row.Node.PrevNode != null)
					{
						Row row2 = row.Node.PrevNode.Row;
						int num5 = this.Oo_0O0o.ooO..Count - 1;
						for (int k = 0; k <= num5; k++)
						{
							string columnName = this.Oo_0O0o.ooO.[k];
							object objectValue = RuntimeHelpers.GetObjectValue(row2[columnName]);
							double num6;
							if (objectValue != null && double.TryParse(objectValue.ToString(), out num6) && num6 > 0.0)
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(row[columnName]);
								double num7;
								if (objectValue2 != null && double.TryParse(objectValue2.ToString(), out num7))
								{
									row[this.O_O_ooo.OOOOoo.[k]] = (num7 - num6) / num6;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000E3D30 File Offset: 0x000E1F30
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x060020F0 RID: 8432 RVA: 0x000E3D4C File Offset: 0x000E1F4C
		[oO0oooo("1909")]
		public virtual fxDataSource BuildDataSource()
		{
			GroupTableBuilder groupTableBuilder = new GroupTableBuilder();
			List<CrossTotalOn> list = new List<CrossTotalOn>();
			groupTableBuilder.SourceDataTable = this.SourceDataTable;
			groupTableBuilder.CommandTimeOut = this.CommandTimeOut;
			groupTableBuilder.Filter = this.Filter;
			groupTableBuilder.Decimals = this.Decimals;
			groupTableBuilder.FromServer = this.FromServer;
			groupTableBuilder.TableName = OoOo0O.OO_o.0o_O.(6);
			groupTableBuilder.Groups.AddRange(this.HGroups);
			groupTableBuilder.VerticalTotal = this.VerticalTotal;
			groupTableBuilder.SelectString = this.SelectString;
			groupTableBuilder.ConnectionName = this.ConnectionName;
			try
			{
				foreach (CrossGroupOn crossGroupOn in this.VGroups)
				{
					GroupOn groupOn = new GroupOn();
					groupOn.Name = crossGroupOn.Name;
					groupOn.NewName = crossGroupOn.NewName;
					groupOn.DateGroup = crossGroupOn.DateGroup;
					groupOn.Pattern = crossGroupOn.Pattern;
					groupOn.Vertical = true;
					groupTableBuilder.Groups.Add(groupOn);
				}
			}
			finally
			{
				IEnumerator<CrossGroupOn> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			int num = this.Totals.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				bool flag = false;
				CrossTotalOn crossTotalOn = this.Totals[i];
				int num2 = i + 1;
				int num3 = this.Totals.Count - 1;
				for (int j = num2; j <= num3; j++)
				{
					CrossTotalOn crossTotalOn2 = this.Totals[j];
					if (Operators.CompareString(crossTotalOn.Name, crossTotalOn2.Name, true) == 0 && Operators.CompareString(crossTotalOn.Caption, crossTotalOn2.Caption, true) == 0)
					{
						if (crossTotalOn.Aggregate == crossTotalOn2.Aggregate)
						{
							list.Add(crossTotalOn2);
						}
						else
						{
							flag = true;
							crossTotalOn2.Caption = Oo00.OoO_.__o.(crossTotalOn2.Aggregate);
						}
					}
				}
				if (flag)
				{
					crossTotalOn.Caption = Oo00.OoO_.__o.(crossTotalOn.Aggregate);
				}
			}
			try
			{
				foreach (CrossTotalOn item in list)
				{
					this.Totals.Remove(item);
				}
			}
			finally
			{
				List<CrossTotalOn>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			int num4 = this.Totals.Count - 1;
			for (int k = 0; k <= num4; k++)
			{
				bool flag2 = false;
				CrossTotalOn crossTotalOn3 = this.Totals[k];
				int num5 = k + 1;
				int num6 = this.Totals.Count - 1;
				for (int l = num5; l <= num6; l++)
				{
					CrossTotalOn crossTotalOn4 = this.Totals[l];
					if (Operators.CompareString(crossTotalOn3.Name, crossTotalOn4.Name, true) != 0 && Operators.CompareString(crossTotalOn3.Caption, crossTotalOn4.Caption, true) == 0 && !crossTotalOn4.Caption.StartsWith(crossTotalOn4.Name + "_"))
					{
						flag2 = true;
						crossTotalOn4.Caption = crossTotalOn4.Name + "_" + crossTotalOn4.Caption;
					}
				}
				if (flag2 && !crossTotalOn3.Caption.StartsWith(crossTotalOn3.Name + "_"))
				{
					crossTotalOn3.Caption = crossTotalOn3.Name + "_" + crossTotalOn3.Caption;
				}
			}
			try
			{
				foreach (CrossTotalOn crossTotalOn5 in this.Totals)
				{
					TotalOn totalOn = new TotalOn();
					totalOn.Name = crossTotalOn5.Name;
					totalOn.Aggregate = crossTotalOn5.Aggregate;
					totalOn.NewCaption = crossTotalOn5.Caption;
					totalOn.upto = crossTotalOn5.upto;
					if (totalOn.upto)
					{
						totalOn.NewName = totalOn.Name + "_up";
					}
					groupTableBuilder.Totals.Add(totalOn);
				}
			}
			finally
			{
				IEnumerator<CrossTotalOn> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			groupTableBuilder.o00OO.oOO0O_.();
			DataTable a_;
			if (Operators.CompareString(this.SelectString, "", true) > 0 || this.FromServer)
			{
				a_ = groupTableBuilder.o0_O.00ooOo0.();
			}
			else
			{
				a_ = groupTableBuilder.O.O0_0O.();
			}
			fxDataSource fxDataSource = this.o__.Ooo.(a_, groupTableBuilder);
			fxDataSource.O_O_O.00. = this;
			return fxDataSource;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000E419C File Offset: 0x000E239C
		protected DataTable <<EMPTY_NAME>>(DataTable A_0, bool A_1, string A_2)
		{
			DataTable dataTable;
			if (A_1)
			{
				Foxtable.RibbonMenu.StatusBar.Reset();
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
			try
			{
				foreach (GroupOn groupOn in this.HGroups)
				{
					if (dataTable.DataCols.Contains(groupOn.NewName))
					{
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							dataTable.DataCols[groupOn.NewName].Caption = groupOn.NewCaption;
						}
						else if (Operators.CompareString(groupOn.NewName, groupOn.Name, true) == 0 && this.SourceDataTable != null && Operators.CompareString(this.SourceDataTable.DataCols[groupOn.Name].Caption, "", true) > 0)
						{
							dataTable.DataCols[groupOn.NewName].Caption = this.SourceDataTable.DataCols[groupOn.Name].Caption;
						}
					}
				}
			}
			finally
			{
				IEnumerator<GroupOn> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			DataTable result;
			if (A_1)
			{
				Foxtable.RibbonMenu.StatusBar.Reset();
				result = dataTable;
			}
			else
			{
				new O_0(O_O0OO.o__.O.(), A_0);
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
				Main.OO_O.o..o0_o_o_0.0O.(this.TableName, this.TableVisible, false);
				try
				{
					foreach (string text in this.O.oOO_0.)
					{
						OO_00oOO.Tables[this.TableName].foxGrid.Cols[text].Format = "#0.00%";
						OO_00oOO.DataTables[this.TableName].DataCols[text].PercentStyle = true;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				if (Operators.CompareString(A_2, this.TableName, true) == 0)
				{
					OO_00oOO.MainTable = OO_00oOO.Tables[this.TableName];
				}
				Foxtable.RibbonMenu.StatusBar.Reset();
				result = dataTable;
			}
			return result;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000E44F0 File Offset: 0x000E26F0
		protected fxDataSource <<EMPTY_NAME>>(DataTable A_0, GroupTableBuilder A_1)
		{
			return this.O0oo00.0O_oO_.(A_0, A_1);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000E44FC File Offset: 0x000E26FC
		private fxDataSource <<EMPTY_NAME>>(DataTable A_0, GroupTableBuilder A_1)
		{
			int num;
			fxDataSource result;
			int num47;
			object obj15;
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
				Dictionary<string, GroupOn> dictionary = new Dictionary<string, GroupOn>();
				IL_19:
				num2 = 4;
				Dictionary<string, GroupOn> dictionary2 = new Dictionary<string, GroupOn>();
				IL_22:
				num2 = 5;
				List<string> list = new List<string>();
				IL_2B:
				num2 = 6;
				List<string> list2 = new List<string>();
				IL_34:
				num2 = 7;
				string text = "";
				IL_3D:
				num2 = 8;
				string text2 = "";
				IL_46:
				num2 = 9;
				string text3 = "";
				IL_50:
				num2 = 10;
				List<string> list3 = new List<string>();
				IL_5A:
				num2 = 11;
				this.O.oOO_0..Clear();
				IL_68:
				num2 = 12;
				this.Oo_0O0o.ooO..Clear();
				IL_76:
				num2 = 13;
				this.O_O_ooo.OOOOoo..Clear();
				IL_84:
				num2 = 14;
				this.o.000Oo_o..Clear();
				IL_92:
				num2 = 15;
				this.o0_.o. = "";
				IL_A0:
				num2 = 16;
				this.O__0O_o_.0_OO_. = "";
				IL_AE:
				num2 = 17;
				IEnumerator<GroupOn> enumerator = A_1.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_CC:
					num2 = 18;
					if (A_0.Columns.Contains(groupOn.NewName))
					{
						IL_E6:
						num2 = 19;
						if (!groupOn.Vertical)
						{
							IL_F5:
							num2 = 20;
							this.o.000Oo_o..Add(groupOn.NewName);
							IL_10A:
							num2 = 21;
							dictionary.Add(groupOn.NewName, groupOn);
							IL_11D:
							num2 = 22;
							list.Add(groupOn.NewName);
							IL_12E:
							num2 = 23;
							if (!this.VerticalTotal)
							{
								IL_139:
								num2 = 24;
								fxDataSource.Columns.Add(groupOn.NewName, A_0.Columns[groupOn.NewName].DataType);
							}
							else
							{
								IL_169:
								num2 = 26;
								fxDataSource.Columns.Add(groupOn.NewName, typeof(string));
							}
						}
						else
						{
							IL_18C:
							num2 = 28;
							dictionary2.Add(groupOn.NewName, groupOn);
							IL_19F:
							num2 = 29;
							list2.Add(groupOn.NewName);
						}
					}
					IL_1B0:
					num2 = 30;
				}
				IL_1BF:
				num2 = 31;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_1CD:
				num2 = 32;
				IEnumerator<GroupOn> enumerator2 = A_1.Groups.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					GroupOn groupOn2 = enumerator2.Current;
					IL_1E8:
					num2 = 33;
					if (!groupOn2.Vertical)
					{
						IL_1F4:
						num2 = 34;
						if (Operators.CompareString(text2, "", true) > 0)
						{
							IL_207:
							num2 = 35;
							text2 += ",";
						}
						IL_218:
						num2 = 36;
						text2 += groupOn2.NewName;
					}
					IL_22B:
					num2 = 37;
				}
				IL_237:
				num2 = 38;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_245:
				num2 = 39;
				IEnumerator<GroupOn> enumerator3 = A_1.Groups.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					GroupOn groupOn3 = enumerator3.Current;
					IL_263:
					num2 = 40;
					if (groupOn3.Vertical)
					{
						IL_26F:
						num2 = 41;
						if (Operators.CompareString(text2, "", true) > 0)
						{
							IL_282:
							num2 = 42;
							text2 += ",";
						}
						IL_293:
						num2 = 43;
						text2 += groupOn3.NewName;
						IL_2A6:
						num2 = 44;
						if (Operators.CompareString(text, "", true) > 0)
						{
							IL_2B9:
							num2 = 45;
							text += ",";
						}
						IL_2CA:
						num2 = 46;
						text += groupOn3.NewName;
					}
					IL_2DD:
					num2 = 47;
				}
				IL_2EC:
				num2 = 48;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_2FA:
				num2 = 49;
				if (list.Count <= 1)
				{
					goto IL_351;
				}
				IL_307:
				num2 = 50;
				text3 = list[list.Count - 2];
				IL_31C:
				num2 = 51;
				int num3 = list.Count - 2;
				for (int i = 0; i <= num3; i++)
				{
					IL_32F:
					num2 = 52;
					list3.Add(list[i]);
					IL_342:
					num2 = 53;
				}
				IL_351:
				num2 = 54;
				DataRow[] array = A_0.Select("", text, DataViewRowState.CurrentRows);
				IL_365:
				num2 = 55;
				IEnumerator<TotalOn> enumerator4 = A_1.Totals.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					TotalOn totalOn = enumerator4.Current;
					IL_383:
					num2 = 56;
					totalOn.Oo_o0O00O.o0O..Clear();
					IL_392:
					num2 = 57;
					if (A_0.Columns.Contains(totalOn.NewName))
					{
						IL_3AC:
						num2 = 58;
						int num4 = 1;
						IL_3B2:
						num2 = 59;
						string text4 = "";
						IL_3BC:
						num2 = 60;
						int num5 = array.Length - 1;
						int j = 0;
						while (j <= num5)
						{
							IL_3CF:
							num2 = 61;
							DataRow dataRow = array[j];
							IL_3D9:
							num2 = 62;
							bool flag;
							if (j == 0)
							{
								IL_3E0:
								num2 = 63;
								flag = false;
							}
							else
							{
								IL_3E8:
								num2 = 65;
								flag = true;
								IL_3EE:
								num2 = 66;
								List<string>.Enumerator enumerator5 = list2.GetEnumerator();
								while (enumerator5.MoveNext())
								{
									string columnName = enumerator5.Current;
									IL_405:
									num2 = 67;
									if (Operators.CompareString(dataRow[columnName].ToString(), array[j - 1][columnName].ToString(), true) != 0)
									{
										IL_431:
										num2 = 68;
										flag = false;
										break;
									}
									IL_439:
									num2 = 70;
								}
								IL_445:
								num2 = 71;
								((IDisposable)enumerator5).Dispose();
							}
							IL_455:
							num2 = 72;
							if (flag)
							{
								goto IL_86B;
							}
							IL_45F:
							num2 = 73;
							text4 = totalOn.NewName + "_" + Conversions.ToString(num4);
							IL_47C:
							num2 = 74;
							if (!fxDataSource.Columns.Contains(text4))
							{
								IL_492:
								num2 = 76;
								fxDataSource.Columns.Add(text4, A_0.Columns[totalOn.NewName].DataType);
								IL_4BB:
								num2 = 77;
								totalOn.Oo_o0O00O.o0O..Add(text4);
								IL_4CC:
								num2 = 78;
								if (this.SourceDataTable != null && this.SourceDataTable.DataCols.Contains(totalOn.Name))
								{
									IL_4F0:
									num2 = 79;
									if (this.SourceDataTable.DataCols[totalOn.Name].ExtendColumnType == ExtendColumnTypeEnum.时段)
									{
										IL_512:
										num2 = 80;
										fxDataSource.Columns[text4].ExtendedProperties.Add("IsTimeSpan", "");
									}
								}
								IL_537:
								num2 = 81;
								string text5 = "";
								IL_541:
								num2 = 82;
								num4++;
								IL_54A:
								num2 = 83;
								this.o0_.o. = this.o0_.o. + "," + text4;
								IL_565:
								num2 = 84;
								this.O__0O_o_.0_OO_. = this.O__0O_o_.0_OO_. + "," + text4;
								IL_580:
								num2 = 85;
								List<string>.Enumerator enumerator6 = list2.GetEnumerator();
								while (enumerator6.MoveNext())
								{
									string text6 = enumerator6.Current;
									IL_59A:
									num2 = 86;
									if (Operators.CompareString(text5, "", true) > 0)
									{
										IL_5AD:
										num2 = 87;
										text5 += "_";
									}
									IL_5BE:
									num2 = 88;
									if (dataRow.Table.Columns[text6].DataType == typeof(bool))
									{
										IL_5E8:
										num2 = 89;
										if (Operators.CompareString(dictionary2[text6].Pattern, "", true) > 0)
										{
											IL_60A:
											num2 = 90;
											string[] array2 = dictionary2[text6].Pattern.Split(new char[]
											{
												'|'
											});
											IL_62D:
											num2 = 91;
											if (array2.Length == 2)
											{
												IL_63A:
												num2 = 92;
												bool flag2 = Conversions.ToBoolean(dataRow[text6]);
												IL_64D:
												num2 = 93;
												if (flag2)
												{
													IL_654:
													num2 = 94;
													text5 += array2[0];
												}
												else
												{
													IL_669:
													num2 = 96;
													text5 += array2[1];
												}
											}
										}
									}
									else
									{
										IL_67E:
										num2 = 98;
										if (dataRow.IsNull(text6))
										{
											IL_68C:
											num2 = 99;
											text5 += "空";
										}
										else
										{
											IL_6A2:
											num2 = 101;
											if (Operators.CompareString(dictionary2[text6].Pattern, "", true) > 0 && dictionary2[text6].Pattern.IndexOf("{0}") >= 0)
											{
												IL_6DC:
												num2 = 102;
												text5 += dictionary2[text6].Pattern.Replace("{0}", dataRow[text6].ToString());
											}
											else
											{
												IL_713:
												num2 = 104;
												if (dataRow.Table.Columns[text6].DataType == typeof(DateTime))
												{
													IL_73D:
													num2 = 105;
													DateTime dateTime = Conversions.ToDate(dataRow[text6]);
													IL_750:
													num2 = 106;
													if (DateTime.Compare(dateTime.Date, dateTime) == 0)
													{
														IL_763:
														num2 = 107;
														text5 += Strings.Format(dateTime, "yyyy-MM-dd");
													}
													else
													{
														IL_782:
														num2 = 109;
														if (dateTime.Second == 0)
														{
															IL_78E:
															num2 = 110;
															text5 += Strings.Format(dateTime, "yyyy-MM-dd HH:mm");
														}
														else
														{
															IL_7AD:
															num2 = 112;
															text5 += Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss");
														}
													}
												}
												else
												{
													IL_7CC:
													num2 = 114;
													text5 += dataRow[text6].ToString();
												}
											}
										}
									}
									IL_7E6:
									num2 = 115;
								}
								IL_7F5:
								num2 = 116;
								((IDisposable)enumerator6).Dispose();
								IL_805:
								num2 = 117;
								if (A_1.Totals.Count > 1)
								{
									IL_816:
									num2 = 118;
									if (this.OrderByTotal)
									{
										IL_821:
										num2 = 119;
										text5 = totalOn.NewCaption + "_" + text5;
									}
									else
									{
										IL_83B:
										num2 = 121;
										text5 = text5 + "_" + totalOn.NewCaption;
									}
								}
								IL_853:
								num2 = 122;
								fxDataSource.Columns[text4].Caption = text5;
								goto IL_86B;
							}
							IL_8A9:
							num2 = 124;
							j++;
							continue;
							IL_86B:
							num2 = 123;
							dataRow.RowError = string.Concat(new string[]
							{
								dataRow.RowError,
								totalOn.NewName,
								"\v",
								text4,
								"\v"
							});
							goto IL_8A9;
						}
					}
					IL_8BB:
					num2 = 125;
				}
				IL_8CA:
				num2 = 126;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_8D8:
				num2 = 127;
				array = A_0.Select("", text2, DataViewRowState.CurrentRows);
				IL_8EC:
				num2 = 128;
				DataRow dataRow2 = null;
				IL_8F5:
				num2 = 129;
				int num6 = array.Length - 1;
				for (int k = 0; k <= num6; k++)
				{
					IL_90B:
					num2 = 130;
					DataRow dataRow3 = array[k];
					IL_918:
					num2 = 131;
					bool flag;
					if (k == 0)
					{
						IL_922:
						num2 = 132;
						flag = false;
					}
					else
					{
						IL_92D:
						num2 = 134;
						flag = true;
						IL_936:
						num2 = 135;
						List<string>.Enumerator enumerator7 = list.GetEnumerator();
						while (enumerator7.MoveNext())
						{
							string columnName2 = enumerator7.Current;
							IL_950:
							num2 = 136;
							if (Operators.CompareString(dataRow3[columnName2].ToString(), array[k - 1][columnName2].ToString(), true) != 0)
							{
								IL_97F:
								num2 = 137;
								flag = false;
								break;
							}
							IL_98A:
							num2 = 139;
						}
						IL_999:
						num2 = 140;
						((IDisposable)enumerator7).Dispose();
					}
					IL_9AC:
					num2 = 141;
					if (!flag)
					{
						IL_9B9:
						num2 = 142;
						dataRow2 = fxDataSource.NewRow();
						IL_9C8:
						num2 = 143;
						List<string>.Enumerator enumerator8 = list.GetEnumerator();
						while (enumerator8.MoveNext())
						{
							string text7 = enumerator8.Current;
							IL_9E5:
							num2 = 144;
							if (A_0.Columns[text7].DataType == typeof(DateTime))
							{
								IL_A0C:
								num2 = 145;
								if (!dataRow3.IsNull(text7))
								{
									IL_A20:
									num2 = 146;
									DateTime dateTime2 = Conversions.ToDate(dataRow3[text7]);
									IL_A36:
									num2 = 147;
									if (DateTime.Compare(dateTime2.Date, dateTime2) == 0)
									{
										IL_A4C:
										num2 = 148;
										dataRow2[text7] = Strings.Format(dateTime2, "yyyy-MM-dd");
									}
									else
									{
										IL_A6E:
										num2 = 150;
										if (dateTime2.Second == 0)
										{
											IL_A7D:
											num2 = 151;
											dataRow2[text7] = Strings.Format(dateTime2, "yyyy-MM-dd HH:mm");
										}
										else
										{
											IL_A9F:
											num2 = 153;
											dataRow2[text7] = Strings.Format(dateTime2, "yyyy-MM-dd HH:mm:ss");
										}
									}
								}
							}
							else
							{
								IL_AC1:
								num2 = 155;
								dataRow2[text7] = RuntimeHelpers.GetObjectValue(dataRow3[text7]);
							}
							IL_ADE:
							num2 = 156;
						}
						IL_AF0:
						num2 = 157;
						((IDisposable)enumerator8).Dispose();
						IL_B03:
						num2 = 158;
						fxDataSource.Rows.Add(dataRow2);
					}
					IL_B17:
					num2 = 159;
					if (Operators.CompareString(dataRow3.RowError, "", true) > 0)
					{
						IL_B32:
						num2 = 160;
						string[] array3 = dataRow3.RowError.Trim(new char[]
						{
							'\v'
						}).Split(new char[]
						{
							'\v'
						});
						IL_B61:
						num2 = 161;
						int num7 = array3.Length - 2;
						for (int l = 0; l <= num7; l += 2)
						{
							IL_B74:
							num2 = 162;
							dataRow2[array3[l + 1]] = RuntimeHelpers.GetObjectValue(dataRow3[array3[l]]);
							IL_B99:
							num2 = 163;
						}
					}
					IL_BAB:
					num2 = 164;
				}
				IL_BC0:
				num2 = 165;
				IEnumerator<TotalOn> enumerator9 = A_1.Totals.GetEnumerator();
				while (enumerator9.MoveNext())
				{
					TotalOn totalOn2 = enumerator9.Current;
					IL_BE1:
					num2 = 166;
					if (totalOn2.upto && (totalOn2.Aggregate == AggregateEnum.Sum || totalOn2.Aggregate == AggregateEnum.Max || totalOn2.Aggregate == AggregateEnum.Min))
					{
						IL_C14:
						num2 = 167;
						List<string>.Enumerator enumerator10 = totalOn2.Oo_o0O00O.o0O..GetEnumerator();
						while (enumerator10.MoveNext())
						{
							string columnName3 = enumerator10.Current;
							IL_C36:
							num2 = 168;
							int num8 = fxDataSource.Rows.Count - 1;
							for (int m = 1; m <= num8; m++)
							{
								IL_C54:
								num2 = 169;
								DataRow dataRow4 = fxDataSource.Rows[m - 1];
								IL_C6C:
								num2 = 170;
								DataRow dataRow5 = fxDataSource.Rows[m];
								IL_C82:
								num2 = 171;
								decimal num9;
								if (dataRow5.IsNull(columnName3))
								{
									IL_C93:
									num2 = 172;
									num9 = 0m;
								}
								else
								{
									IL_CA3:
									num2 = 174;
									num9 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow5[columnName3]));
								}
								IL_CBE:
								num2 = 175;
								decimal num10;
								if (!dataRow4.IsNull(columnName3))
								{
									IL_CCF:
									num2 = 176;
									num10 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow4[columnName3]));
								}
								IL_CEA:
								num2 = 177;
								if (dataRow4.IsNull(columnName3) | (list3.Count > 0 && Oo00.o00O0O_.O.(list3, dataRow4, dataRow5)))
								{
									IL_D14:
									num2 = 178;
									if (totalOn2.Aggregate == AggregateEnum.Sum)
									{
										IL_D24:
										num2 = 179;
										num10 = 0m;
									}
									else
									{
										IL_D34:
										num2 = 181;
										num10 = num9;
									}
								}
								IL_D3E:
								num2 = 182;
								switch (totalOn2.Aggregate)
								{
								case AggregateEnum.Sum:
								case AggregateEnum.Count:
									IL_D74:
									num2 = 184;
									dataRow5[columnName3] = decimal.Add(num10, num9);
									break;
								case AggregateEnum.Max:
									IL_DB2:
									num2 = 188;
									dataRow5[columnName3] = Math.Max(num10, num9);
									break;
								case AggregateEnum.Min:
									IL_D93:
									num2 = 186;
									dataRow5[columnName3] = Math.Min(num10, num9);
									break;
								}
								IL_DCF:
								num2 = 190;
							}
							IL_DE4:
							num2 = 191;
						}
						IL_DF6:
						num2 = 192;
						((IDisposable)enumerator10).Dispose();
					}
					IL_E09:
					num2 = 193;
				}
				IL_E1B:
				num2 = 194;
				if (enumerator9 != null)
				{
					enumerator9.Dispose();
				}
				IL_E2C:
				num2 = 195;
				if (this.OrderByTotal || A_1.Totals.Count <= 1)
				{
					goto IL_F73;
				}
				IL_E4E:
				num2 = 196;
				List<string> list4 = new List<string>();
				IL_E5B:
				num2 = 197;
				int count = list.Count;
				int num11 = fxDataSource.Columns.Count - 1;
				for (int n = count; n <= num11; n++)
				{
					IL_E7F:
					num2 = 198;
					string text8 = fxDataSource.Columns[n].Caption;
					IL_E9A:
					num2 = 199;
					text8 = text8.Substring(0, text8.LastIndexOf("_") + 1);
					IL_EB8:
					num2 = 200;
					if (!list4.Contains(text8))
					{
						IL_ECC:
						num2 = 203;
						list4.Add(text8);
						IL_EDB:
						num2 = 204;
						int num12 = n;
						IL_EE5:
						num2 = 205;
						int num13 = n + 1;
						int num14 = fxDataSource.Columns.Count - 1;
						for (int num15 = num13; num15 <= num14; num15++)
						{
							IL_F03:
							num2 = 206;
							if (fxDataSource.Columns[num15].Caption.StartsWith(text8))
							{
								IL_F25:
								num2 = 207;
								num12++;
								IL_F31:
								num2 = 208;
								fxDataSource.Columns[num15].SetOrdinal(num12);
							}
							IL_F4C:
							num2 = 209;
						}
					}
					IL_F5E:
					num2 = 210;
				}
				IL_F73:
				num2 = 211;
				if (!this.VerticalProportion)
				{
					goto IL_16B9;
				}
				IL_F84:
				num2 = 212;
				IEnumerator<TotalOn> enumerator11 = A_1.Totals.GetEnumerator();
				while (enumerator11.MoveNext())
				{
					TotalOn totalOn3 = enumerator11.Current;
					IL_FA5:
					num2 = 213;
					if (A_0.Columns.Contains(totalOn3.NewName))
					{
						IL_FC2:
						num2 = 214;
						List<string> list5 = new List<string>();
						IL_FCF:
						num2 = 215;
						IEnumerator enumerator12 = fxDataSource.Columns.GetEnumerator();
						while (enumerator12.MoveNext())
						{
							object obj = enumerator12.Current;
							DataColumn dataColumn = (DataColumn)obj;
							IL_FF3:
							num2 = 216;
							if (dataColumn.ColumnName.StartsWith(totalOn3.NewName + "_") && Versioned.IsNumeric(dataColumn.ColumnName.Substring(totalOn3.NewName.Length + 1)))
							{
								IL_1039:
								num2 = 217;
								list5.Add(dataColumn.ColumnName);
							}
							IL_104D:
							num2 = 218;
						}
						IL_105C:
						num2 = 219;
						if (enumerator12 is IDisposable)
						{
							(enumerator12 as IDisposable).Dispose();
						}
						IL_1077:
						num2 = 220;
						List<string>.Enumerator enumerator13 = list5.GetEnumerator();
						while (enumerator13.MoveNext())
						{
							string text9 = enumerator13.Current;
							IL_1094:
							num2 = 221;
							string text10 = text9 + "vp";
							IL_10A8:
							num2 = 222;
							this.o0_.o. = this.o0_.o. + "," + text10;
							IL_10C6:
							num2 = 223;
							fxDataSource.Columns.Add(text10, typeof(double));
							IL_10E5:
							num2 = 224;
							fxDataSource.Columns[text10].SetOrdinal(fxDataSource.Columns[text9].Ordinal + 1);
							IL_1113:
							num2 = 225;
							string text11 = fxDataSource.Columns[text9].Caption;
							IL_112E:
							num2 = 226;
							int num16 = text11.Length - text11.Replace("_", "").Length;
							IL_1154:
							num2 = 227;
							if (num16 > this.VGroups.Count + this.Totals.Count - 2)
							{
								IL_1177:
								num2 = 228;
								text11 = text11.Substring(0, text11.LastIndexOf("_") + 1);
								IL_1195:
								num2 = 229;
								fxDataSource.Columns[text10].Caption = text11 + this.VerticalProportionCaption;
							}
							else
							{
								IL_11BD:
								num2 = 231;
								fxDataSource.Columns[text10].Caption = text11 + this.VerticalProportionCaption;
							}
							IL_11E3:
							num2 = 232;
							fxDataSource.Columns[text10].ExtendedProperties.Add("displayformat", "#0.00%");
							IL_120B:
							num2 = 233;
							this.O.oOO_0..Add(text10);
							IL_121E:
							num2 = 234;
						}
						IL_1230:
						num2 = 235;
						((IDisposable)enumerator13).Dispose();
						IL_1243:
						num2 = 236;
						List<string>.Enumerator enumerator14 = list5.GetEnumerator();
						while (enumerator14.MoveNext())
						{
							string text12 = enumerator14.Current;
							IL_1260:
							num2 = 237;
							if (Operators.CompareString(text3, "", true) == 0)
							{
								IL_1278:
								num2 = 238;
								double num17 = 0.0;
								IL_1289:
								num2 = 239;
								if (totalOn3.upto)
								{
									IL_1298:
									num2 = 240;
									for (int num18 = fxDataSource.Rows.Count - 1; num18 >= 0; num18 += -1)
									{
										IL_12B0:
										num2 = 241;
										if (!fxDataSource.Rows[num18].IsNull(text12))
										{
											IL_12CD:
											num2 = 242;
											num17 = Convert.ToDouble(Conversions.ToDecimal(fxDataSource.Rows[num18][text12]));
											break;
										}
										IL_12F9:
										num2 = 244;
									}
								}
								else
								{
									IL_130C:
									num2 = 246;
									IEnumerator enumerator15 = fxDataSource.Rows.GetEnumerator();
									while (enumerator15.MoveNext())
									{
										object obj2 = enumerator15.Current;
										DataRow dataRow6 = (DataRow)obj2;
										IL_1330:
										num2 = 247;
										if (!dataRow6.IsNull(text12))
										{
											IL_1341:
											num2 = 248;
											num17 += Convert.ToDouble(Conversions.ToDecimal(dataRow6[text12]));
										}
										IL_135F:
										num2 = 249;
									}
									IL_136E:
									num2 = 250;
									if (enumerator15 is IDisposable)
									{
										(enumerator15 as IDisposable).Dispose();
									}
								}
								IL_1389:
								num2 = 251;
								if (num17 != 0.0)
								{
									IL_139F:
									num2 = 252;
									IEnumerator enumerator16 = fxDataSource.Rows.GetEnumerator();
									while (enumerator16.MoveNext())
									{
										object obj3 = enumerator16.Current;
										DataRow dataRow7 = (DataRow)obj3;
										IL_13C3:
										num2 = 253;
										if (!dataRow7.IsNull(text12))
										{
											IL_13D4:
											num2 = 254;
											dataRow7[text12 + "vp"] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow7[text12])) / num17, this.Decimals + 2);
										}
										IL_1415:
										num2 = 255;
									}
									IL_1424:
									num2 = 256;
									if (enumerator16 is IDisposable)
									{
										(enumerator16 as IDisposable).Dispose();
									}
								}
							}
							else
							{
								IL_1447:
								num2 = 258;
								string right = OoOo0O.OO_o.0o_O.(8);
								IL_1455:
								num2 = 259;
								int num19 = fxDataSource.Rows.Count - 1;
								for (int num20 = 0; num20 <= num19; num20++)
								{
									IL_1473:
									num2 = 260;
									DataRow dataRow8 = fxDataSource.Rows[num20];
									IL_1489:
									num2 = 261;
									double num17;
									if (Operators.CompareString(dataRow8[text3].ToString(), right, true) != 0)
									{
										IL_14AA:
										num2 = 262;
										right = dataRow8[text3].ToString();
										IL_14C0:
										num2 = 263;
										if (totalOn3.upto)
										{
											IL_14D2:
											num2 = 264;
											int num21 = num20;
											int num22 = fxDataSource.Rows.Count - 1;
											for (int num23 = num21; num23 <= num22; num23++)
											{
												IL_14EE:
												num2 = 265;
												DataRow dataRow9 = fxDataSource.Rows[num23];
												IL_1504:
												num2 = 266;
												if (Operators.CompareString(dataRow9[text3].ToString(), right, true) != 0)
												{
													break;
												}
												IL_1525:
												num2 = 267;
												if (!dataRow9.IsNull(text12))
												{
													IL_1536:
													num2 = 268;
													num17 = Convert.ToDouble(Conversions.ToDecimal(dataRow9[text12]));
												}
												IL_1551:
												num2 = 271;
											}
										}
										else
										{
											IL_1568:
											num2 = 273;
											num17 = 0.0;
											IL_1579:
											num2 = 274;
											int num24 = num20;
											int num25 = fxDataSource.Rows.Count - 1;
											for (int num26 = num24; num26 <= num25; num26++)
											{
												IL_1595:
												num2 = 275;
												DataRow dataRow10 = fxDataSource.Rows[num26];
												IL_15AB:
												num2 = 276;
												if (Operators.CompareString(dataRow10[text3].ToString(), right, true) != 0)
												{
													break;
												}
												IL_15C9:
												num2 = 277;
												if (!dataRow10.IsNull(text12))
												{
													IL_15DA:
													num2 = 278;
													num17 += Convert.ToDouble(Conversions.ToDecimal(dataRow10[text12]));
												}
												IL_15F8:
												num2 = 281;
											}
										}
									}
									IL_160A:
									num2 = 282;
									if (!dataRow8.IsNull(text12))
									{
										IL_161B:
										num2 = 283;
										dataRow8[text12 + "vp"] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow8[text12])) / num17, this.Decimals + 2);
									}
									IL_165C:
									num2 = 284;
								}
							}
							IL_1671:
							num2 = 285;
						}
						IL_1683:
						num2 = 286;
						((IDisposable)enumerator14).Dispose();
					}
					IL_1696:
					num2 = 287;
				}
				IL_16A8:
				num2 = 288;
				if (enumerator11 != null)
				{
					enumerator11.Dispose();
				}
				IL_16B9:
				num2 = 289;
				if (!this.SamePeriodGrowth)
				{
					goto IL_1FAE;
				}
				IL_16CA:
				num2 = 290;
				string text13 = "";
				IL_16D7:
				num2 = 291;
				string left = "";
				IL_16E4:
				num2 = 292;
				IEnumerator<GroupOn> enumerator17 = A_1.Groups.GetEnumerator();
				while (enumerator17.MoveNext())
				{
					GroupOn groupOn4 = enumerator17.Current;
					IL_1702:
					num2 = 293;
					if (!groupOn4.Vertical)
					{
						IL_1711:
						num2 = 295;
						if (groupOn4.IsDate)
						{
							IL_1720:
							num2 = 296;
							if (Operators.CompareString(text13, "", true) == 0)
							{
								IL_1735:
								num2 = 297;
								text13 = groupOn4.NewName;
							}
							else
							{
								IL_1746:
								num2 = 299;
								if (Operators.CompareString(left, "", true) == 0)
								{
									IL_175B:
									num2 = 300;
									left = groupOn4.NewName;
									break;
								}
							}
						}
					}
					IL_176C:
					num2 = 302;
				}
				IL_177E:
				num2 = 303;
				if (enumerator17 != null)
				{
					enumerator17.Dispose();
				}
				IL_178F:
				num2 = 304;
				if (Operators.CompareString(left, "", true) != 0)
				{
					goto IL_18BB;
				}
				IL_17A7:
				num2 = 305;
				IEnumerator<GroupOn> enumerator18 = A_1.Groups.GetEnumerator();
				while (enumerator18.MoveNext())
				{
					GroupOn groupOn5 = enumerator18.Current;
					IL_17C8:
					num2 = 306;
					if (!groupOn5.Vertical)
					{
						IL_17DA:
						num2 = 308;
						if (fxDataSource.Columns[groupOn5.NewName].DataType == typeof(int) || fxDataSource.Columns[groupOn5.NewName].DataType == typeof(long) || fxDataSource.Columns[groupOn5.NewName].DataType == typeof(short))
						{
							IL_184C:
							num2 = 309;
							if (Operators.CompareString(text13, "", true) == 0)
							{
								IL_1861:
								num2 = 310;
								text13 = groupOn5.NewName;
							}
							else
							{
								IL_1872:
								num2 = 312;
								if (Operators.CompareString(left, "", true) == 0)
								{
									IL_1887:
									num2 = 313;
									left = groupOn5.NewName;
									break;
								}
							}
						}
					}
					IL_1898:
					num2 = 315;
				}
				IL_18AA:
				num2 = 316;
				if (enumerator18 != null)
				{
					enumerator18.Dispose();
				}
				IL_18BB:
				num2 = 317;
				if (Operators.CompareString(left, "", true) <= 0)
				{
					goto IL_1FAE;
				}
				IL_18D4:
				num2 = 318;
				List<string> list6 = new List<string>();
				IL_18E1:
				num2 = 319;
				string text14 = "";
				IL_18EE:
				num2 = 320;
				IEnumerator<GroupOn> enumerator19 = A_1.Groups.GetEnumerator();
				while (enumerator19.MoveNext())
				{
					GroupOn groupOn6 = enumerator19.Current;
					IL_190F:
					num2 = 321;
					if (Operators.CompareString(text13, groupOn6.NewName, true) != 0)
					{
						IL_1929:
						num2 = 323;
						if (!groupOn6.Vertical)
						{
							IL_193B:
							num2 = 325;
							list6.Add(groupOn6.NewName);
							IL_194F:
							num2 = 326;
							if (Operators.CompareString(text14, "", true) > 0)
							{
								IL_1965:
								num2 = 327;
								text14 += " And ";
							}
							IL_1979:
							num2 = 328;
							text14 = text14 + "[" + groupOn6.NewName + "] = ";
							IL_1999:
							num2 = 329;
							if (fxDataSource.Columns[groupOn6.NewName].DataType == typeof(string))
							{
								IL_19C3:
								num2 = 330;
								text14 = text14 + "'{" + groupOn6.NewName + "}'";
							}
							else
							{
								IL_19E5:
								num2 = 332;
								if (fxDataSource.Columns[groupOn6.NewName].DataType == typeof(DateTime))
								{
									IL_1A0F:
									num2 = 333;
									text14 = text14 + "#{" + groupOn6.NewName + "}#";
								}
								else
								{
									IL_1A31:
									num2 = 335;
									text14 = text14 + "{" + groupOn6.NewName + "}";
								}
							}
						}
					}
					IL_1A51:
					num2 = 336;
				}
				IL_1A63:
				num2 = 337;
				if (enumerator19 != null)
				{
					enumerator19.Dispose();
				}
				IL_1A74:
				num2 = 338;
				IEnumerator<TotalOn> enumerator20 = A_1.Totals.GetEnumerator();
				while (enumerator20.MoveNext())
				{
					TotalOn totalOn4 = enumerator20.Current;
					IL_1A95:
					num2 = 339;
					List<string> list7 = new List<string>();
					IL_1AA2:
					num2 = 340;
					if (A_0.Columns.Contains(totalOn4.NewName))
					{
						IL_1ABF:
						num2 = 341;
						IEnumerator enumerator21 = fxDataSource.Columns.GetEnumerator();
						while (enumerator21.MoveNext())
						{
							object obj4 = enumerator21.Current;
							DataColumn dataColumn2 = (DataColumn)obj4;
							IL_1AE3:
							num2 = 342;
							if (dataColumn2.ColumnName.StartsWith(totalOn4.NewName + "_") && Versioned.IsNumeric(dataColumn2.ColumnName.Substring(totalOn4.NewName.Length + 1)))
							{
								IL_1B29:
								num2 = 343;
								list7.Add(dataColumn2.ColumnName);
							}
							IL_1B3D:
							num2 = 344;
						}
						IL_1B4C:
						num2 = 345;
						if (enumerator21 is IDisposable)
						{
							(enumerator21 as IDisposable).Dispose();
						}
					}
					IL_1B67:
					num2 = 346;
					List<string>.Enumerator enumerator22 = list7.GetEnumerator();
					while (enumerator22.MoveNext())
					{
						string text15 = enumerator22.Current;
						IL_1B84:
						num2 = 347;
						string text16 = text15 + "stp";
						IL_1B98:
						num2 = 348;
						fxDataSource.Columns.Add(text16, typeof(double));
						IL_1BB7:
						num2 = 349;
						fxDataSource.Columns[text16].SetOrdinal(fxDataSource.Columns[text15].Ordinal + 1);
						IL_1BE5:
						num2 = 350;
						string text17 = fxDataSource.Columns[text15].Caption;
						IL_1C00:
						num2 = 351;
						int num27 = text17.Length - text17.Replace("_", "").Length;
						IL_1C26:
						num2 = 352;
						if (num27 > this.VGroups.Count + this.Totals.Count - 2)
						{
							IL_1C49:
							num2 = 353;
							text17 = text17.Substring(0, text17.LastIndexOf("_") + 1);
							IL_1C67:
							num2 = 354;
							fxDataSource.Columns[text16].Caption = text17 + "同比";
						}
						else
						{
							IL_1C8E:
							num2 = 356;
							fxDataSource.Columns[text16].Caption = text17 + "同比";
						}
						IL_1CB3:
						num2 = 357;
						fxDataSource.Columns[text16].ExtendedProperties.Add("displayformat", "#0.00%");
						IL_1CDB:
						num2 = 358;
						this.O.oOO_0..Add(text16);
						IL_1CEE:
						num2 = 359;
						this.Oo_0O0o.ooO..Add(text15);
						IL_1D01:
						num2 = 360;
						this.O_O_ooo.OOOOoo..Add(text16);
						IL_1D14:
						num2 = 361;
					}
					IL_1D26:
					num2 = 362;
					((IDisposable)enumerator22).Dispose();
					IL_1D39:
					num2 = 363;
					List<string>.Enumerator enumerator23 = list7.GetEnumerator();
					while (enumerator23.MoveNext())
					{
						string text18 = enumerator23.Current;
						IL_1D56:
						num2 = 364;
						IEnumerator enumerator24 = fxDataSource.Rows.GetEnumerator();
						while (enumerator24.MoveNext())
						{
							object obj5 = enumerator24.Current;
							DataRow dataRow11 = (DataRow)obj5;
							IL_1D7D:
							num2 = 365;
							string text19 = text14;
							IL_1D87:
							num2 = 366;
							List<string>.Enumerator enumerator25 = list6.GetEnumerator();
							while (enumerator25.MoveNext())
							{
								string text20 = enumerator25.Current;
								IL_1DA1:
								num2 = 367;
								text19 = text19.Replace("{" + text20 + "}", dataRow11[text20].ToString());
								IL_1DCF:
								num2 = 368;
							}
							IL_1DDE:
							num2 = 369;
							((IDisposable)enumerator25).Dispose();
							IL_1DF1:
							num2 = 370;
							if (!dataRow11.IsNull(text13))
							{
								IL_1E05:
								num2 = 371;
								int num28 = Conversions.ToInteger(dataRow11[text13]);
								IL_1E1B:
								num2 = 374;
								text19 = string.Concat(new string[]
								{
									text19,
									" And [",
									text13,
									"] = ",
									Conversions.ToString(num28 - 1)
								});
								IL_1E54:
								num2 = 375;
								DataRow[] array4 = fxDataSource.Select(text19);
								IL_1E65:
								num2 = 376;
								if (array4.Length >= 1)
								{
									IL_1E75:
									num2 = 377;
									DataRow dataRow12 = array4[0];
									IL_1E81:
									num2 = 378;
									double num29;
									if (!dataRow12.IsNull(text18))
									{
										IL_1E92:
										num2 = 379;
										num29 = Conversions.ToDouble(dataRow12[text18]);
									}
									else
									{
										IL_1EAA:
										num2 = 381;
										num29 = 0.0;
									}
									IL_1EBB:
									num2 = 382;
									double num30;
									if (!dataRow11.IsNull(text18))
									{
										IL_1ECC:
										num2 = 383;
										num30 = Conversions.ToDouble(dataRow11[text18]);
									}
									else
									{
										IL_1EE4:
										num2 = 385;
										num30 = 0.0;
									}
									IL_1EF5:
									num2 = 386;
									if (num29 > 0.0)
									{
										IL_1F08:
										num2 = 387;
										dataRow11[text18 + "stp"] = Math.Round((num30 - num29) / num29, this.Decimals);
									}
								}
							}
							IL_1F39:
							num2 = 388;
						}
						IL_1F4B:
						num2 = 389;
						if (enumerator24 is IDisposable)
						{
							(enumerator24 as IDisposable).Dispose();
						}
						IL_1F66:
						num2 = 390;
					}
					IL_1F78:
					num2 = 391;
					((IDisposable)enumerator23).Dispose();
					IL_1F8B:
					num2 = 392;
				}
				IL_1F9D:
				num2 = 393;
				if (enumerator20 != null)
				{
					enumerator20.Dispose();
				}
				IL_1FAE:
				num2 = 394;
				if (!this.CircleGrowth)
				{
					goto IL_28C6;
				}
				IL_1FBF:
				num2 = 395;
				List<string> list8 = new List<string>();
				IL_1FCC:
				num2 = 396;
				string text21 = "";
				IL_1FD9:
				num2 = 397;
				string text22 = "";
				IL_1FE6:
				num2 = 398;
				IEnumerator<GroupOn> enumerator26 = A_1.Groups.GetEnumerator();
				while (enumerator26.MoveNext())
				{
					GroupOn groupOn7 = enumerator26.Current;
					IL_2007:
					num2 = 399;
					if (!groupOn7.Vertical)
					{
						IL_2019:
						num2 = 401;
						if (groupOn7.IsDate)
						{
							IL_2028:
							num2 = 402;
							if (Operators.CompareString(text21, "", true) > 0)
							{
								IL_203E:
								num2 = 403;
								text21 += ",";
							}
							IL_2052:
							num2 = 404;
							text21 += groupOn7.NewName;
						}
						else
						{
							IL_206A:
							num2 = 406;
							if (Operators.CompareString(text22, "", true) > 0)
							{
								IL_2080:
								num2 = 407;
								text22 += ",";
							}
							IL_2094:
							num2 = 408;
							text22 += groupOn7.NewName;
							IL_20AA:
							num2 = 409;
							list8.Add(groupOn7.NewName);
						}
					}
					IL_20BE:
					num2 = 410;
				}
				IL_20D0:
				num2 = 411;
				if (enumerator26 != null)
				{
					enumerator26.Dispose();
				}
				IL_20E1:
				num2 = 412;
				if (Operators.CompareString(text21, "", true) != 0)
				{
					goto IL_2271;
				}
				IL_20F9:
				num2 = 413;
				list8.Clear();
				IL_2106:
				num2 = 414;
				text22 = "";
				IL_2113:
				num2 = 415;
				IEnumerator<GroupOn> enumerator27 = A_1.Groups.GetEnumerator();
				while (enumerator27.MoveNext())
				{
					GroupOn groupOn8 = enumerator27.Current;
					IL_2134:
					num2 = 416;
					if (!groupOn8.Vertical)
					{
						IL_2146:
						num2 = 418;
						if (fxDataSource.Columns[groupOn8.NewName].DataType == typeof(int) || fxDataSource.Columns[groupOn8.NewName].DataType == typeof(long) || fxDataSource.Columns[groupOn8.NewName].DataType == typeof(short))
						{
							IL_21B8:
							num2 = 419;
							if (Operators.CompareString(text21, "", true) > 0)
							{
								IL_21CE:
								num2 = 420;
								text21 += ",";
							}
							IL_21E2:
							num2 = 421;
							text21 += groupOn8.NewName;
						}
						else
						{
							IL_21FA:
							num2 = 423;
							if (Operators.CompareString(text22, "", true) > 0)
							{
								IL_2210:
								num2 = 424;
								text22 += ",";
							}
							IL_2224:
							num2 = 425;
							text22 += groupOn8.NewName;
							IL_223A:
							num2 = 426;
							list8.Add(groupOn8.NewName);
						}
					}
					IL_224E:
					num2 = 427;
				}
				IL_2260:
				num2 = 428;
				if (enumerator27 != null)
				{
					enumerator27.Dispose();
				}
				IL_2271:
				num2 = 429;
				if (Operators.CompareString(text21, "", true) <= 0)
				{
					goto IL_28C6;
				}
				IL_228A:
				num2 = 430;
				IEnumerator<TotalOn> enumerator28 = A_1.Totals.GetEnumerator();
				while (enumerator28.MoveNext())
				{
					TotalOn totalOn5 = enumerator28.Current;
					IL_22AB:
					num2 = 431;
					List<string> list9 = new List<string>();
					IL_22B8:
					num2 = 432;
					if (A_0.Columns.Contains(totalOn5.NewName))
					{
						IL_22D5:
						num2 = 433;
						IEnumerator enumerator29 = fxDataSource.Columns.GetEnumerator();
						while (enumerator29.MoveNext())
						{
							object obj6 = enumerator29.Current;
							DataColumn dataColumn3 = (DataColumn)obj6;
							IL_22F9:
							num2 = 434;
							if (dataColumn3.ColumnName.StartsWith(totalOn5.NewName + "_") && Versioned.IsNumeric(dataColumn3.ColumnName.Substring(totalOn5.NewName.Length + 1)))
							{
								IL_233F:
								num2 = 435;
								list9.Add(dataColumn3.ColumnName);
							}
							IL_2353:
							num2 = 436;
						}
						IL_2362:
						num2 = 437;
						if (enumerator29 is IDisposable)
						{
							(enumerator29 as IDisposable).Dispose();
						}
					}
					IL_237D:
					num2 = 438;
					List<string>.Enumerator enumerator30 = list9.GetEnumerator();
					while (enumerator30.MoveNext())
					{
						string text23 = enumerator30.Current;
						IL_239A:
						num2 = 439;
						string text24 = text23 + "cle";
						IL_23AE:
						num2 = 440;
						fxDataSource.Columns.Add(text24, typeof(double));
						IL_23CD:
						num2 = 441;
						fxDataSource.Columns[text24].SetOrdinal(fxDataSource.Columns[text23].Ordinal + 1);
						IL_23FB:
						num2 = 442;
						string text25 = fxDataSource.Columns[text23].Caption;
						IL_2416:
						num2 = 443;
						int num31 = text25.Length - text25.Replace("_", "").Length;
						IL_243C:
						num2 = 444;
						if (num31 > this.VGroups.Count + this.Totals.Count - 2)
						{
							IL_245F:
							num2 = 445;
							text25 = text25.Substring(0, text25.LastIndexOf("_") + 1);
							IL_247D:
							num2 = 446;
							fxDataSource.Columns[text24].Caption = text25 + "环比";
						}
						else
						{
							IL_24A4:
							num2 = 448;
							fxDataSource.Columns[text24].Caption = text25 + "环比";
						}
						IL_24C9:
						num2 = 449;
						fxDataSource.Columns[text24].ExtendedProperties.Add("displayformat", "#0.00%");
						IL_24F1:
						num2 = 450;
						this.O.oOO_0..Add(text24);
						IL_2504:
						num2 = 451;
						this.Oo_0O0o.ooO..Add(text23);
						IL_2517:
						num2 = 452;
						this.O_O_ooo.OOOOoo..Add(text24);
						IL_252A:
						num2 = 453;
					}
					IL_253C:
					num2 = 454;
					((IDisposable)enumerator30).Dispose();
					IL_254F:
					num2 = 455;
					List<string>.Enumerator enumerator31 = list9.GetEnumerator();
					while (enumerator31.MoveNext())
					{
						string text26 = enumerator31.Current;
						IL_256C:
						num2 = 456;
						string text27 = text26 + "cle";
						IL_2580:
						num2 = 457;
						if (list8.Count == 0)
						{
							IL_2592:
							num2 = 458;
							int num32 = fxDataSource.Rows.Count - 1;
							for (int num33 = 1; num33 <= num32; num33++)
							{
								IL_25B0:
								num2 = 459;
								double num34;
								if (!fxDataSource.Rows[num33 - 1].IsNull(text26))
								{
									IL_25CF:
									num2 = 460;
									num34 = Conversions.ToDouble(fxDataSource.Rows[num33 - 1][text26]);
								}
								else
								{
									IL_25F5:
									num2 = 462;
									num34 = 0.0;
								}
								IL_2606:
								num2 = 463;
								double num35;
								if (!fxDataSource.Rows[num33].IsNull(text26))
								{
									IL_2623:
									num2 = 464;
									num35 = Conversions.ToDouble(fxDataSource.Rows[num33][text26]);
								}
								else
								{
									IL_2647:
									num2 = 466;
									num35 = 0.0;
								}
								IL_2658:
								num2 = 467;
								if (num34 != 0.0)
								{
									IL_266B:
									num2 = 468;
									fxDataSource.Rows[num33][text27] = Math.Round((num35 - num34) / num34, this.Decimals);
								}
								IL_269E:
								num2 = 469;
							}
						}
						else
						{
							IL_26B8:
							num2 = 471;
							DataView dataView = new DataView(fxDataSource, "", text22 + "," + text21, DataViewRowState.CurrentRows);
							IL_26DC:
							num2 = 472;
							int num36 = dataView.Count - 1;
							for (int num37 = 1; num37 <= num36; num37++)
							{
								IL_26F5:
								num2 = 473;
								bool flag3 = true;
								IL_26FE:
								num2 = 474;
								List<string>.Enumerator enumerator32 = list8.GetEnumerator();
								while (enumerator32.MoveNext())
								{
									string property = enumerator32.Current;
									IL_2718:
									num2 = 475;
									if (Operators.CompareString(dataView[num37][property].ToString(), dataView[num37 - 1][property].ToString(), true) != 0)
									{
										IL_2752:
										num2 = 476;
										flag3 = false;
									}
									IL_275B:
									num2 = 477;
								}
								IL_276A:
								num2 = 478;
								((IDisposable)enumerator32).Dispose();
								IL_277D:
								num2 = 479;
								if (flag3)
								{
									IL_278A:
									num2 = 480;
									double num38;
									if (!dataView[num37 - 1].Row.IsNull(text26))
									{
										IL_27A9:
										num2 = 481;
										num38 = Conversions.ToDouble(dataView[num37 - 1][text26]);
									}
									else
									{
										IL_27CA:
										num2 = 483;
										num38 = 0.0;
									}
									IL_27DB:
									num2 = 484;
									double num39;
									if (!dataView[num37].Row.IsNull(text26))
									{
										IL_27F8:
										num2 = 485;
										num39 = Conversions.ToDouble(dataView[num37][text26]);
									}
									else
									{
										IL_2817:
										num2 = 487;
										num39 = 0.0;
									}
									IL_2828:
									num2 = 488;
									if (num38 != 0.0)
									{
										IL_283B:
										num2 = 489;
										dataView[num37][text27] = Math.Round((num39 - num38) / num38, this.Decimals);
									}
								}
								IL_2869:
								num2 = 490;
							}
						}
						IL_287E:
						num2 = 491;
					}
					IL_2890:
					num2 = 492;
					((IDisposable)enumerator31).Dispose();
					IL_28A3:
					num2 = 493;
				}
				IL_28B5:
				num2 = 494;
				if (enumerator28 != null)
				{
					enumerator28.Dispose();
				}
				IL_28C6:
				num2 = 495;
				if (!this.HorizontalProportion)
				{
					goto IL_2D0F;
				}
				IL_28D7:
				num2 = 496;
				IEnumerator<TotalOn> enumerator33 = A_1.Totals.GetEnumerator();
				while (enumerator33.MoveNext())
				{
					TotalOn totalOn6 = enumerator33.Current;
					IL_28F8:
					num2 = 497;
					if (A_0.Columns.Contains(totalOn6.NewName))
					{
						IL_2915:
						num2 = 498;
						List<string> list10 = new List<string>();
						IL_2922:
						num2 = 499;
						IEnumerator enumerator34 = fxDataSource.Columns.GetEnumerator();
						while (enumerator34.MoveNext())
						{
							object obj7 = enumerator34.Current;
							DataColumn dataColumn4 = (DataColumn)obj7;
							IL_2946:
							num2 = 500;
							if (dataColumn4.ColumnName.StartsWith(totalOn6.NewName + "_") && Versioned.IsNumeric(dataColumn4.ColumnName.Substring(totalOn6.NewName.Length + 1)))
							{
								IL_298C:
								num2 = 501;
								list10.Add(dataColumn4.ColumnName);
							}
							IL_29A0:
							num2 = 502;
						}
						IL_29AF:
						num2 = 503;
						if (enumerator34 is IDisposable)
						{
							(enumerator34 as IDisposable).Dispose();
						}
						IL_29CA:
						num2 = 504;
						List<string>.Enumerator enumerator35 = list10.GetEnumerator();
						while (enumerator35.MoveNext())
						{
							string text28 = enumerator35.Current;
							IL_29E7:
							num2 = 505;
							string text29 = text28 + "hp";
							IL_29FB:
							num2 = 506;
							fxDataSource.Columns.Add(text29, typeof(double));
							IL_2A1A:
							num2 = 507;
							fxDataSource.Columns[text29].SetOrdinal(fxDataSource.Columns[text28].Ordinal + 1);
							IL_2A48:
							num2 = 508;
							string text30 = fxDataSource.Columns[text28].Caption;
							IL_2A63:
							num2 = 509;
							int num40 = text30.Length - text30.Replace("_", "").Length;
							IL_2A89:
							num2 = 510;
							if (num40 > this.VGroups.Count + this.Totals.Count - 2)
							{
								IL_2AAC:
								num2 = 511;
								text30 = text30.Substring(0, text30.LastIndexOf("_") + 1);
								IL_2ACA:
								num2 = 512;
								fxDataSource.Columns[text29].Caption = text30 + this.HorizontalProportionCaption;
							}
							else
							{
								IL_2AF2:
								num2 = 514;
								fxDataSource.Columns[text29].Caption = text30 + this.HorizontalProportionCaption;
							}
							IL_2B18:
							num2 = 515;
							fxDataSource.Columns[text29].ExtendedProperties.Add("displayformat", "#0.00%");
							IL_2B40:
							num2 = 516;
							this.O.oOO_0..Add(text29);
							IL_2B53:
							num2 = 517;
						}
						IL_2B65:
						num2 = 518;
						((IDisposable)enumerator35).Dispose();
						IL_2B78:
						num2 = 519;
						IEnumerator enumerator36 = fxDataSource.Rows.GetEnumerator();
						while (enumerator36.MoveNext())
						{
							object obj8 = enumerator36.Current;
							DataRow dataRow13 = (DataRow)obj8;
							IL_2B9F:
							num2 = 520;
							double num41 = 0.0;
							IL_2BB0:
							num2 = 521;
							List<string>.Enumerator enumerator37 = list10.GetEnumerator();
							while (enumerator37.MoveNext())
							{
								string columnName4 = enumerator37.Current;
								IL_2BCA:
								num2 = 522;
								if (!dataRow13.IsNull(columnName4))
								{
									IL_2BDB:
									num2 = 523;
									num41 += Convert.ToDouble(Conversions.ToDecimal(dataRow13[columnName4]));
								}
								IL_2BF9:
								num2 = 524;
							}
							IL_2C08:
							num2 = 525;
							((IDisposable)enumerator37).Dispose();
							IL_2C1B:
							num2 = 526;
							if (num41 != 0.0)
							{
								IL_2C31:
								num2 = 527;
								List<string>.Enumerator enumerator38 = list10.GetEnumerator();
								while (enumerator38.MoveNext())
								{
									string text31 = enumerator38.Current;
									IL_2C4B:
									num2 = 528;
									if (!dataRow13.IsNull(text31))
									{
										IL_2C5C:
										num2 = 529;
										dataRow13[text31 + "hp"] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow13[text31])) / num41, this.Decimals + 2);
									}
									IL_2C9D:
									num2 = 530;
								}
								IL_2CAC:
								num2 = 531;
								((IDisposable)enumerator38).Dispose();
							}
							IL_2CBF:
							num2 = 532;
						}
						IL_2CD1:
						num2 = 533;
						if (enumerator36 is IDisposable)
						{
							(enumerator36 as IDisposable).Dispose();
						}
					}
					IL_2CEC:
					num2 = 534;
				}
				IL_2CFE:
				num2 = 535;
				if (enumerator33 != null)
				{
					enumerator33.Dispose();
				}
				IL_2D0F:
				num2 = 536;
				if (!this.VerticalTotal || this.Subtotal)
				{
					goto IL_3281;
				}
				IL_2D2B:
				num2 = 537;
				DataRow dataRow14 = fxDataSource.NewRow();
				IL_2D3A:
				num2 = 538;
				IEnumerator<TotalOn> enumerator39 = A_1.Totals.GetEnumerator();
				while (enumerator39.MoveNext())
				{
					TotalOn totalOn7 = enumerator39.Current;
					IL_2D5B:
					num2 = 539;
					if (A_0.Columns.Contains(totalOn7.NewName))
					{
						IL_2D78:
						num2 = 540;
						List<string> list11 = new List<string>();
						IL_2D85:
						num2 = 541;
						IEnumerator enumerator40 = fxDataSource.Columns.GetEnumerator();
						while (enumerator40.MoveNext())
						{
							object obj9 = enumerator40.Current;
							DataColumn dataColumn5 = (DataColumn)obj9;
							IL_2DA9:
							num2 = 542;
							if (dataColumn5.ColumnName.StartsWith(totalOn7.Name + "_") && Versioned.IsNumeric(dataColumn5.ColumnName.Substring(totalOn7.Name.Length + 1)))
							{
								IL_2DEF:
								num2 = 543;
								list11.Add(dataColumn5.ColumnName);
							}
							IL_2E03:
							num2 = 544;
						}
						IL_2E12:
						num2 = 545;
						if (enumerator40 is IDisposable)
						{
							(enumerator40 as IDisposable).Dispose();
						}
						IL_2E2D:
						num2 = 546;
						List<string>.Enumerator enumerator41 = list11.GetEnumerator();
						while (enumerator41.MoveNext())
						{
							string text32 = enumerator41.Current;
							IL_2E4A:
							num2 = 547;
							double num42 = 0.0;
							IL_2E5B:
							num2 = 548;
							IEnumerator enumerator42 = fxDataSource.Rows.GetEnumerator();
							while (enumerator42.MoveNext())
							{
								object obj10 = enumerator42.Current;
								DataRow dataRow15 = (DataRow)obj10;
								IL_2E7F:
								num2 = 549;
								if (!dataRow15.IsNull(text32))
								{
									IL_2E90:
									num2 = 550;
									num42 += Convert.ToDouble(Conversions.ToDecimal(dataRow15[text32]));
								}
								IL_2EAE:
								num2 = 551;
							}
							IL_2EBD:
							num2 = 552;
							if (enumerator42 is IDisposable)
							{
								(enumerator42 as IDisposable).Dispose();
							}
							IL_2ED8:
							num2 = 553;
							dataRow14[text32] = Math.Round(num42, this.Decimals);
							IL_2EF9:
							num2 = 554;
							if (fxDataSource.Columns.Contains(text32 + "vp") && list.Count == 1)
							{
								IL_2F23:
								num2 = 555;
								dataRow14[text32 + "vp"] = 1;
							}
							IL_2F42:
							num2 = 556;
						}
						IL_2F54:
						num2 = 557;
						((IDisposable)enumerator41).Dispose();
					}
					IL_2F67:
					num2 = 558;
				}
				IL_2F79:
				num2 = 559;
				if (enumerator39 != null)
				{
					enumerator39.Dispose();
				}
				IL_2F8A:
				num2 = 560;
				fxDataSource.Rows.Add(dataRow14);
				IL_2F9E:
				num2 = 561;
				if (!this.HorizontalProportion)
				{
					goto IL_320A;
				}
				IL_2FAF:
				num2 = 562;
				IEnumerator<TotalOn> enumerator43 = A_1.Totals.GetEnumerator();
				while (enumerator43.MoveNext())
				{
					TotalOn totalOn8 = enumerator43.Current;
					IL_2FD0:
					num2 = 563;
					if (A_0.Columns.Contains(totalOn8.NewName))
					{
						IL_2FED:
						num2 = 564;
						List<string> list12 = new List<string>();
						IL_2FFA:
						num2 = 565;
						IEnumerator enumerator44 = fxDataSource.Columns.GetEnumerator();
						while (enumerator44.MoveNext())
						{
							object obj11 = enumerator44.Current;
							DataColumn dataColumn6 = (DataColumn)obj11;
							IL_301E:
							num2 = 566;
							if (dataColumn6.ColumnName.StartsWith(totalOn8.NewName + "_") && Versioned.IsNumeric(dataColumn6.ColumnName.Substring(totalOn8.NewName.Length + 1)))
							{
								IL_3064:
								num2 = 567;
								list12.Add(dataColumn6.ColumnName);
							}
							IL_3078:
							num2 = 568;
						}
						IL_3087:
						num2 = 569;
						if (enumerator44 is IDisposable)
						{
							(enumerator44 as IDisposable).Dispose();
						}
						IL_30A2:
						num2 = 570;
						double num43 = 0.0;
						IL_30B3:
						num2 = 571;
						List<string>.Enumerator enumerator45 = list12.GetEnumerator();
						while (enumerator45.MoveNext())
						{
							string columnName5 = enumerator45.Current;
							IL_30CD:
							num2 = 572;
							if (!dataRow14.IsNull(columnName5))
							{
								IL_30DE:
								num2 = 573;
								num43 += Convert.ToDouble(Conversions.ToDecimal(dataRow14[columnName5]));
							}
							IL_30FC:
							num2 = 574;
						}
						IL_310B:
						num2 = 575;
						((IDisposable)enumerator45).Dispose();
						IL_311E:
						num2 = 576;
						if (num43 != 0.0)
						{
							IL_3134:
							num2 = 577;
							List<string>.Enumerator enumerator46 = list12.GetEnumerator();
							while (enumerator46.MoveNext())
							{
								string text33 = enumerator46.Current;
								IL_3151:
								num2 = 578;
								if (!dataRow14.IsNull(text33))
								{
									IL_3162:
									num2 = 579;
									dataRow14[text33 + "hp"] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow14[text33])) / num43, this.Decimals);
								}
								else
								{
									IL_31A3:
									num2 = 581;
									dataRow14[text33 + "hp"] = 0;
								}
								IL_31C2:
								num2 = 582;
							}
							IL_31D4:
							num2 = 583;
							((IDisposable)enumerator46).Dispose();
						}
					}
					IL_31E7:
					num2 = 584;
				}
				IL_31F9:
				num2 = 585;
				if (enumerator43 != null)
				{
					enumerator43.Dispose();
				}
				IL_320A:
				num2 = 586;
				List<string>.Enumerator enumerator47 = list.GetEnumerator();
				while (enumerator47.MoveNext())
				{
					string text34 = enumerator47.Current;
					IL_3224:
					num2 = 587;
					if (fxDataSource.Columns[text34].DataType == typeof(string))
					{
						IL_3249:
						num2 = 588;
						dataRow14[text34] = "合计";
						break;
					}
					IL_325F:
					num2 = 590;
				}
				IL_326E:
				num2 = 591;
				((IDisposable)enumerator47).Dispose();
				IL_3281:
				num2 = 592;
				this.o_o.__. = "";
				IL_3292:
				num2 = 593;
				if (!this.HorizontalTotal)
				{
					goto IL_37D3;
				}
				IL_32A3:
				num2 = 594;
				IEnumerator<TotalOn> enumerator48 = A_1.Totals.GetEnumerator();
				while (enumerator48.MoveNext())
				{
					TotalOn totalOn9 = enumerator48.Current;
					IL_32C4:
					num2 = 595;
					string text35 = totalOn9.Name;
					IL_32D3:
					num2 = 596;
					if (totalOn9.upto)
					{
						IL_32E2:
						num2 = 597;
						text35 += "_up";
					}
					IL_32F6:
					num2 = 598;
					if (!A_0.Columns.Contains(text35))
					{
						IL_330B:
						num2 = 599;
						if (text35.StartsWith("{") && text35.IndexOf("}.") > 0)
						{
							IL_332E:
							num2 = 600;
							text35 = text35.Substring(text35.IndexOf("}.") + 2);
						}
					}
					IL_334B:
					num2 = 601;
					if (A_0.Columns.Contains(text35))
					{
						IL_3363:
						num2 = 602;
						List<string> list13 = new List<string>();
						IL_3370:
						num2 = 603;
						string text36 = "";
						IL_337D:
						num2 = 604;
						double num44 = 0.0;
						IL_338E:
						num2 = 605;
						string text37;
						if (A_1.Totals.Count == 1)
						{
							IL_33A2:
							num2 = 606;
							if (!this.VerticalProportion)
							{
								IL_33B0:
								num2 = 607;
								text37 = "合计";
							}
							else
							{
								IL_33C2:
								num2 = 609;
								text37 = "合计_" + totalOn9.NewCaption;
								IL_33DB:
								num2 = 610;
								text36 = "合计_" + this.VerticalProportionCaption;
							}
						}
						else
						{
							IL_33F5:
							num2 = 612;
							if (!this.VerticalProportion)
							{
								IL_3403:
								num2 = 613;
								text37 = "合计_" + totalOn9.NewCaption;
							}
							else
							{
								IL_341E:
								num2 = 615;
								text37 = totalOn9.NewCaption + "_合计";
								IL_3437:
								num2 = 616;
								text36 = totalOn9.NewCaption + "_" + this.VerticalProportionCaption;
							}
						}
						IL_3456:
						num2 = 617;
						fxDataSource.Columns.Add(text37, typeof(double));
						IL_3475:
						num2 = 618;
						this.o_o.__. = this.o_o.__. + "," + text37;
						IL_3493:
						num2 = 619;
						if (this.VerticalProportion)
						{
							IL_34A1:
							num2 = 620;
							fxDataSource.Columns.Add(text36, typeof(double));
							IL_34C0:
							num2 = 621;
							this.o_o.__. = this.o_o.__. + "," + text36;
							IL_34DE:
							num2 = 622;
							fxDataSource.Columns[text36].ExtendedProperties.Add("displayformat", "#0.00%");
							IL_3506:
							num2 = 623;
							this.O.oOO_0..Add(text36);
						}
						IL_3519:
						num2 = 624;
						IEnumerator enumerator49 = fxDataSource.Columns.GetEnumerator();
						while (enumerator49.MoveNext())
						{
							object obj12 = enumerator49.Current;
							DataColumn dataColumn7 = (DataColumn)obj12;
							IL_353D:
							num2 = 625;
							if (dataColumn7.ColumnName.StartsWith(text35 + "_") && Versioned.IsNumeric(dataColumn7.ColumnName.Substring(text35.Length + 1)))
							{
								IL_3579:
								num2 = 626;
								list13.Add(dataColumn7.ColumnName);
							}
							IL_358D:
							num2 = 627;
						}
						IL_359C:
						num2 = 628;
						if (enumerator49 is IDisposable)
						{
							(enumerator49 as IDisposable).Dispose();
						}
						IL_35B7:
						num2 = 629;
						IEnumerator enumerator50 = fxDataSource.Rows.GetEnumerator();
						while (enumerator50.MoveNext())
						{
							object obj13 = enumerator50.Current;
							DataRow dataRow16 = (DataRow)obj13;
							IL_35DE:
							num2 = 630;
							double num45 = 0.0;
							IL_35EF:
							num2 = 631;
							List<string>.Enumerator enumerator51 = list13.GetEnumerator();
							while (enumerator51.MoveNext())
							{
								string columnName6 = enumerator51.Current;
								IL_3609:
								num2 = 632;
								if (!dataRow16.IsNull(columnName6))
								{
									IL_361A:
									num2 = 633;
									num45 += Convert.ToDouble(Conversions.ToDecimal(dataRow16[columnName6]));
								}
								IL_3638:
								num2 = 634;
							}
							IL_3647:
							num2 = 635;
							((IDisposable)enumerator51).Dispose();
							IL_365A:
							num2 = 636;
							dataRow16[text37] = Math.Round(num45, this.Decimals);
							IL_367B:
							num2 = 637;
							if (this.VerticalProportion)
							{
								IL_3689:
								num2 = 638;
								dataRow16[text36] = num45;
								IL_369F:
								num2 = 639;
								num44 += num45;
							}
							IL_36AC:
							num2 = 640;
						}
						IL_36BE:
						num2 = 641;
						if (enumerator50 is IDisposable)
						{
							(enumerator50 as IDisposable).Dispose();
						}
						IL_36D9:
						num2 = 642;
						if (this.VerticalTotal)
						{
							IL_36E7:
							num2 = 643;
							num44 /= 2.0;
						}
						IL_36FB:
						num2 = 644;
						if (this.VerticalProportion && num44 != 0.0)
						{
							IL_371C:
							num2 = 645;
							IEnumerator enumerator52 = fxDataSource.Rows.GetEnumerator();
							while (enumerator52.MoveNext())
							{
								object obj14 = enumerator52.Current;
								DataRow dataRow17 = (DataRow)obj14;
								IL_3740:
								num2 = 646;
								if (!dataRow17.IsNull(text36))
								{
									IL_3751:
									num2 = 647;
									dataRow17[text36] = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow17[text36])) / num44, this.Decimals);
								}
								IL_3786:
								num2 = 648;
							}
							IL_3795:
							num2 = 649;
							if (enumerator52 is IDisposable)
							{
								(enumerator52 as IDisposable).Dispose();
							}
						}
					}
					IL_37B0:
					num2 = 650;
				}
				IL_37C2:
				num2 = 651;
				if (enumerator48 != null)
				{
					enumerator48.Dispose();
				}
				IL_37D3:
				num2 = 652;
				this.o_o.__. = this.o_o.__..Trim(new char[]
				{
					','
				});
				IL_37F5:
				num2 = 653;
				fxDataSource.AcceptChanges();
				IL_3802:
				num2 = 654;
				fxDataSource.TableName = this.TableName;
				IL_3815:
				num2 = 655;
				result = fxDataSource;
				IL_381E:
				goto IL_42B0;
				IL_3823:
				int num46 = num47 + 1;
				num47 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num46);
				IL_4271:
				goto IL_42A5;
				IL_4273:
				num47 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4283:;
			}
			catch when (endfilter(obj15 is Exception & num != 0 & num47 == 0))
			{
				Exception ex = (Exception)obj16;
				goto IL_4273;
			}
			IL_42A5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_42B0:
			if (num47 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 统计后台数据时的超时时限，默认为30秒
		/// </summary>
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000E87E0 File Offset: 0x000E69E0
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x000E87E8 File Offset: 0x000E69E8
		public int CommandTimeOut
		{
			get
			{
				return this.O0OO.00OOO_O.;
			}
			set
			{
				this.O0OO.00OOO_O. = value;
			}
		}

		// Token: 0x04000DB3 RID: 3507
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB4 RID: 3508
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DB5 RID: 3509
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB6 RID: 3510
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB7 RID: 3511
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB8 RID: 3512
		private GroupCollection <<EMPTY_NAME>>;

		// Token: 0x04000DB9 RID: 3513
		private CrossGroupCollection <<EMPTY_NAME>>;

		// Token: 0x04000DBA RID: 3514
		private CrossTotalCollection <<EMPTY_NAME>>;

		// Token: 0x04000DBB RID: 3515
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000DBC RID: 3516
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DBD RID: 3517
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DBE RID: 3518
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DBF RID: 3519
		private int <<EMPTY_NAME>>;

		// Token: 0x04000DC0 RID: 3520
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DC1 RID: 3521
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DC2 RID: 3522
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DC3 RID: 3523
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DC4 RID: 3524
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DC5 RID: 3525
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DC6 RID: 3526
		private int <<EMPTY_NAME>>;

		// Token: 0x04000DC7 RID: 3527
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000DC8 RID: 3528
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000DC9 RID: 3529
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000DCA RID: 3530
		private int <<EMPTY_NAME>>;

		// Token: 0x04000DCB RID: 3531
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DCC RID: 3532
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DCD RID: 3533
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000DCE RID: 3534
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DCF RID: 3535
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD0 RID: 3536
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD1 RID: 3537
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD2 RID: 3538
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD3 RID: 3539
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DD4 RID: 3540
		private HttpClient <<EMPTY_NAME>>;
	}
}
