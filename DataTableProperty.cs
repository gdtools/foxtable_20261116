using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000335 RID: 821
	[OoO0___o("Table")]
	internal class DataTableProperty
	{
		// Token: 0x06002E69 RID: 11881 RVA: 0x00150B18 File Offset: 0x0014ED18
		public DataTableProperty(DataTable A_0)
		{
			this.o__.0ooOOoo0o. = A_0;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00150B27 File Offset: 0x0014ED27
		public DataTableProperty()
		{
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00150B2F File Offset: 0x0014ED2F
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00150B3C File Offset: 0x0014ED3C
		[Browsable(false)]
		public string Caption
		{
			get
			{
				return this.o__.0ooOOoo0o..Caption;
			}
			set
			{
				this.o__.0ooOOoo0o..Caption = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x00150B4A File Offset: 0x0014ED4A
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x00150B57 File Offset: 0x0014ED57
		[Browsable(false)]
		public string AsmCrcString
		{
			get
			{
				return this.o__.0ooOOoo0o..frd_AsmCrcString;
			}
			set
			{
				this.o__.0ooOOoo0o..frd_AsmCrcString = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00150B65 File Offset: 0x0014ED65
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x00150B6D File Offset: 0x0014ED6D
		[oO0oooo("0605")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("进入单元格，准备编辑的时候执行。")]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(1.0)]
		public EventString PrepareEdit
		{
			get
			{
				return this.o_o00.oOo000.;
			}
			set
			{
				this.o_o00.oOo000. = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x00150B76 File Offset: 0x0014ED76
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x00150B7E File Offset: 0x0014ED7E
		[oO0oooo("0615")]
		[Description("真正有了编辑单元格动作的时候执行，例如用户通过键盘输入内容，或者用鼠标单击了下拉按钮。")]
		[Category("A.编辑")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.0)]
		[O0O0oOO00_0OO(true)]
		public EventString StartEdit
		{
			get
			{
				return this.O.OOOOO.;
			}
			set
			{
				this.O.OOOOO. = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00150B87 File Offset: 0x0014ED87
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x00150B8F File Offset: 0x0014ED8F
		[O0O0oOO00_0OO(true)]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(2.1)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单元格真正进入编辑状态之前执行，此时编辑框(Editor)已经初始化，可以设置其属性。")]
		[Browsable(false)]
		public EventString SetupEditor
		{
			get
			{
				return this.O.O_0oo.;
			}
			set
			{
				this.O.O_0oo. = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x00150B98 File Offset: 0x0014ED98
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x00150BA0 File Offset: 0x0014EDA0
		[oO0oooo("0617")]
		[Category("A.编辑")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("结束编辑单元格前执行，通常用于验证输入的内容。")]
		[O_Oo00Oo000O0(3.0)]
		public EventString ValidateEdit
		{
			get
			{
				return this.O_0_.O.;
			}
			set
			{
				this.O_0_.O. = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00150BA9 File Offset: 0x0014EDA9
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00150BB1 File Offset: 0x0014EDB1
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0616")]
		[Description("结束编辑单元格后执行，通常用于执行一些特定的操作和计算。")]
		[O0O0oOO00_0OO(true)]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(4.0)]
		public EventString AfterEdit
		{
			get
			{
				return this.O.OOO_oo.;
			}
			set
			{
				this.O.OOO_oo. = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00150BBA File Offset: 0x0014EDBA
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00150BC2 File Offset: 0x0014EDC2
		[oO0oooo("0619")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("编辑框中内容发生变化时执行。")]
		[O0O0oOO00_0OO(true)]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(4.1)]
		public EventString ChangeEdit
		{
			get
			{
				return this.o_o.O00000_OO.;
			}
			set
			{
				this.o_o.O00000_OO. = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x00150BCB File Offset: 0x0014EDCB
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x00150BD3 File Offset: 0x0014EDD3
		[oO0oooo("0620")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("在编辑框(Editor)输入一字符键时执行。")]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(4.2)]
		public EventString KeyPressEdit
		{
			get
			{
				return this.o00_0.0OoO0.;
			}
			set
			{
				this.o00_0.0OoO0. = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x00150BDC File Offset: 0x0014EDDC
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x00150BE4 File Offset: 0x0014EDE4
		[oO0oooo("0622")]
		[Category("A.编辑")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("在编辑状态时，按下一按键时执行。")]
		[O_Oo00Oo000O0(4.3)]
		public EventString KeyDownEdit
		{
			get
			{
				return this.O_.0oo.;
			}
			set
			{
				this.O_.0oo. = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x00150BED File Offset: 0x0014EDED
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x00150BF5 File Offset: 0x0014EDF5
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("A.编辑")]
		[oO0oooo("0623")]
		[Description("在编辑状态时，松开一按键时执行。")]
		[O_Oo00Oo000O0(4.4)]
		[O0O0oOO00_0OO(true)]
		public EventString KeyUpEdit
		{
			get
			{
				return this.O0O0._.;
			}
			set
			{
				this.O0O0._. = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x00150BFE File Offset: 0x0014EDFE
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x00150C06 File Offset: 0x0014EE06
		[Category("A.编辑")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0642")]
		[O0O0oOO00_0OO(true)]
		[Description("单击单元格按钮后执行。")]
		[O_Oo00Oo000O0(4.5)]
		public EventString CellButtonClick
		{
			get
			{
				return this.O_OoO0.0o0O.;
			}
			set
			{
				this.O_OoO0.0o0O. = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x00150C0F File Offset: 0x0014EE0F
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x00150C17 File Offset: 0x0014EE17
		[Category("B.数据")]
		[oO0oooo("0624")]
		[Description("某一列的内容变化前执行，通常用于验证该列内容。")]
		[DisplayName("DataColChanging")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataColChanging
		{
			get
			{
				return this.Oo_.0oO_.;
			}
			set
			{
				this.Oo_.0oO_. = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00150C20 File Offset: 0x0014EE20
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x00150C28 File Offset: 0x0014EE28
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0625")]
		[DisplayName("DataColChanged")]
		[Category("B.数据")]
		[Description("某一列的内容变化后执行，通常用于执行一些特定的操作和计算。")]
		[O_Oo00Oo000O0(6.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataColChanged
		{
			get
			{
				return this.O.00_o__o.;
			}
			set
			{
				this.O.00_o__o. = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00150C31 File Offset: 0x0014EE31
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x00150C39 File Offset: 0x0014EE39
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("保存某一行之前执行，通常用于对数据进行保存前的验证！。")]
		[Category("B.数据")]
		[oO0oooo("0628")]
		[O_Oo00Oo000O0(6.1)]
		public EventString BeforeSaveDataRow
		{
			get
			{
				return this.OoO.0.;
			}
			set
			{
				this.OoO.0. = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x00150C42 File Offset: 0x0014EE42
		// (set) Token: 0x06002E8A RID: 11914 RVA: 0x00150C4A File Offset: 0x0014EE4A
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("3755")]
		[Category("B.数据")]
		[Description("保存某一行之后执行。")]
		[O_Oo00Oo000O0(6.11)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSaveDataRow
		{
			get
			{
				return this.O._OooO0o0_o.;
			}
			set
			{
				this.O._OooO0o0_o. = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x00150C53 File Offset: 0x0014EE53
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x00150C5B File Offset: 0x0014EE5B
		[Category("C.增加行")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0629")]
		[Description("增加行之前执行。")]
		[O_Oo00Oo000O0(8.1)]
		public EventString BeforeAddDataRow
		{
			get
			{
				return this.o.Oo_O0OO_0o0.;
			}
			set
			{
				this.o.Oo_O0OO_0o0. = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x00150C64 File Offset: 0x0014EE64
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x00150C6C File Offset: 0x0014EE6C
		[Description("增加一行时执行，此时DataRow还处于孤立状态，并未真正增加到DataTable中。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0630")]
		[Category("C.增加行")]
		[O_Oo00Oo000O0(9.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowAdding
		{
			get
			{
				return this.O_oO_0OOo_o.0O.;
			}
			set
			{
				this.O_oO_0OOo_o.0O. = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x00150C75 File Offset: 0x0014EE75
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x00150C7D File Offset: 0x0014EE7D
		[Category("C.增加行")]
		[Description("增加一行后执行，此时DataRow已经真正增加到DataTable中。")]
		[oO0oooo("0631")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(10.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowAdded
		{
			get
			{
				return this.o_._0.;
			}
			set
			{
				this.o_._0. = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00150C86 File Offset: 0x0014EE86
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x00150C8E File Offset: 0x0014EE8E
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("删除行之前执行。")]
		[Category("D.删除行")]
		[oO0oooo("0632")]
		[O_Oo00Oo000O0(10.1)]
		public EventString BeforeDeleteDataRow
		{
			get
			{
				return this.O.0o0O__0.;
			}
			set
			{
				this.O.0o0O__0. = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x00150C97 File Offset: 0x0014EE97
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x00150C9F File Offset: 0x0014EE9F
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("删除某一行时执行。")]
		[O0O0oOO00_0OO(true)]
		[Category("D.删除行")]
		[oO0oooo("0633")]
		[O_Oo00Oo000O0(11.0)]
		public EventString DataRowDeleting
		{
			get
			{
				return this.oO.o0OO_0.;
			}
			set
			{
				this.oO.o0OO_0. = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00150CA8 File Offset: 0x0014EEA8
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x00150CB0 File Offset: 0x0014EEB0
		[O0O0oOO00_0OO(true)]
		[oO0oooo("0634")]
		[Category("D.删除行")]
		[Description("删除某一行之后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(12.0)]
		public EventString DataRowDeleted
		{
			get
			{
				return this.o0ooo.O_Oo.;
			}
			set
			{
				this.o0ooo.O_Oo. = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00150CB9 File Offset: 0x0014EEB9
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x00150CC1 File Offset: 0x0014EEC1
		[oO0oooo("0635")]
		[Category("E.锁定行")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("行的锁定状态发生变化之前执行。")]
		[O_Oo00Oo000O0(13.0)]
		public EventString DataRowLockedChanging
		{
			get
			{
				return this.oooO.o_o.;
			}
			set
			{
				this.oooO.o_o. = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00150CCA File Offset: 0x0014EECA
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x00150CD2 File Offset: 0x0014EED2
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("行的锁定状态发生变化之后执行。")]
		[oO0oooo("0636")]
		[Category("E.锁定行")]
		[O_Oo00Oo000O0(14.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowLockedChanged
		{
			get
			{
				return this.o_0o._.;
			}
			set
			{
				this.o_0o._. = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00150CDB File Offset: 0x0014EEDB
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00150CE3 File Offset: 0x0014EEE3
		[Category("F.选择")]
		[Description("选择不同记录后执行，也就是Current属性发生变化后执行。")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0641")]
		[O_Oo00Oo000O0(14.0)]
		public EventString CurrentChanged
		{
			get
			{
				return this.OOo.0_.;
			}
			set
			{
				this.OOo.0_. = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00150CEC File Offset: 0x0014EEEC
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00150CF4 File Offset: 0x0014EEF4
		[O0O0oOO00_0OO(true)]
		[Category("F.选择")]
		[oO0oooo("0640")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("选择不同行后执行，也就是Position属性发生变化后执行")]
		[O_Oo00Oo000O0(15.0)]
		public EventString PositionChanged
		{
			get
			{
				return this.O0._0.;
			}
			set
			{
				this.O0._0. = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00150CFD File Offset: 0x0014EEFD
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00150D05 File Offset: 0x0014EF05
		[Description("选择不同的单元格前执行，也就是表的RowSel、ColSel属性发生变化前执行。")]
		[Category("F.选择")]
		[oO0oooo("0644")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(16.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSelChange
		{
			get
			{
				return this.o0_.o_.;
			}
			set
			{
				this.o0_.o_. = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00150D0E File Offset: 0x0014EF0E
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x00150D16 File Offset: 0x0014EF16
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0645")]
		[O0O0oOO00_0OO(true)]
		[Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")]
		[Category("F.选择")]
		[O_Oo00Oo000O0(16.1)]
		public EventString AfterSelChange
		{
			get
			{
				return this.oOoO._.;
			}
			set
			{
				this.oOoO._. = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00150D1F File Offset: 0x0014EF1F
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x00150D27 File Offset: 0x0014EF27
		[Category("F.选择")]
		[oO0oooo("0646")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("选择不同的区域前执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化前执行。")]
		[O_Oo00Oo000O0(17.0)]
		public EventString BeforeSelRangeChange
		{
			get
			{
				return this.OO.0OoOOoO.;
			}
			set
			{
				this.OO.0OoOOoO. = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00150D30 File Offset: 0x0014EF30
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00150D38 File Offset: 0x0014EF38
		[Description("选择不同的区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")]
		[oO0oooo("0647")]
		[O0O0oOO00_0OO(true)]
		[Category("F.选择")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(17.1)]
		public EventString AfterSelRangeChange
		{
			get
			{
				return this.Ooo.oO_.;
			}
			set
			{
				this.Ooo.oO_. = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00150D41 File Offset: 0x0014EF41
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x00150D49 File Offset: 0x0014EF49
		[oO0oooo("1639")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("G.复选")]
		[Description("修改行复选框状态前执行。")]
		[O_Oo00Oo000O0(19.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeCheckRow
		{
			get
			{
				return this.Oo_0oOo.OooO.;
			}
			set
			{
				this.Oo_0oOo.OooO. = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00150D52 File Offset: 0x0014EF52
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00150D5A File Offset: 0x0014EF5A
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("修改行复选框状态后执行。")]
		[Category("G.复选")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("1640")]
		[O_Oo00Oo000O0(19.1)]
		public EventString AfterCheckRow
		{
			get
			{
				return this.O0oO0_oO._O_O.;
			}
			set
			{
				this.O0oO0_oO._O_O. = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00150D63 File Offset: 0x0014EF63
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00150D6B File Offset: 0x0014EF6B
		[oO0oooo("1847")]
		[Category("H.调整")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("移动行后执行。")]
		[O_Oo00Oo000O0(18.0)]
		public EventString AfterMoveRow
		{
			get
			{
				return this.O.OO0O0OOO.;
			}
			set
			{
				this.O.OO0O0OOO. = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00150D74 File Offset: 0x0014EF74
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00150D7C File Offset: 0x0014EF7C
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2271")]
		[Category("H.调整")]
		[O0O0oOO00_0OO(true)]
		[Description("移动行前执行。")]
		[O_Oo00Oo000O0(17.9)]
		public EventString BeforeMoveRow
		{
			get
			{
				return this.O0_o.0Oo.;
			}
			set
			{
				this.O0_o.0Oo. = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00150D85 File Offset: 0x0014EF85
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00150D8D File Offset: 0x0014EF8D
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0648")]
		[O0O0oOO00_0OO(true)]
		[Description("拖动列之前发生。")]
		[Category("H.调整")]
		[O_Oo00Oo000O0(19.0)]
		public EventString BeforeDragColumn
		{
			get
			{
				return this.o_.0_0_oo0.;
			}
			set
			{
				this.o_.0_0_oo0. = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x00150D96 File Offset: 0x0014EF96
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00150D9E File Offset: 0x0014EF9E
		[Description("拖动列之后发生。")]
		[oO0oooo("0649")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("H.调整")]
		[O_Oo00Oo000O0(20.0)]
		public EventString AfterDragColumn
		{
			get
			{
				return this.O._O.;
			}
			set
			{
				this.O._O. = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00150DA7 File Offset: 0x0014EFA7
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00150DAF File Offset: 0x0014EFAF
		[oO0oooo("0650")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("调整冻结区之前发生。")]
		[O0O0oOO00_0OO(true)]
		[Category("H.调整")]
		[O_Oo00Oo000O0(21.0)]
		public EventString BeforeFreezeColumn
		{
			get
			{
				return this.O.___O_.;
			}
			set
			{
				this.O.___O_. = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00150DB8 File Offset: 0x0014EFB8
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00150DC0 File Offset: 0x0014EFC0
		[oO0oooo("0651")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("调整冻结区之后发生。")]
		[Category("H.调整")]
		[O_Oo00Oo000O0(22.0)]
		public EventString AfterFreezeColumn
		{
			get
			{
				return this.o.O0_OOoo_o0.;
			}
			set
			{
				this.o.O0_OOoo_o0. = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00150DC9 File Offset: 0x0014EFC9
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00150DD1 File Offset: 0x0014EFD1
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0652")]
		[O0O0oOO00_0OO(true)]
		[Description("调整列宽之前发生。")]
		[Category("H.调整")]
		[O_Oo00Oo000O0(23.0)]
		public EventString BeforeResizeColumn
		{
			get
			{
				return this.OOO.__0.;
			}
			set
			{
				this.OOO.__0. = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00150DDA File Offset: 0x0014EFDA
		// (set) Token: 0x06002EBA RID: 11962 RVA: 0x00150DE2 File Offset: 0x0014EFE2
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0653")]
		[O0O0oOO00_0OO(true)]
		[Description("调整列宽之后发生。")]
		[Category("H.调整")]
		[O_Oo00Oo000O0(24.0)]
		public EventString AfterResizeColumn
		{
			get
			{
				return this.Oo_oO__.o_oOo.;
			}
			set
			{
				this.Oo_oO__.o_oOo. = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00150DEB File Offset: 0x0014EFEB
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x00150DF3 File Offset: 0x0014EFF3
		[Description("调整行高之前发生。")]
		[oO0oooo("0654")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("H.调整")]
		[O_Oo00Oo000O0(25.0)]
		public EventString BeforeResizeRow
		{
			get
			{
				return this.o_O0O0_0O.oO.;
			}
			set
			{
				this.o_O0O0_0O.oO. = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00150DFC File Offset: 0x0014EFFC
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00150E04 File Offset: 0x0014F004
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("0655")]
		[Description("调整行高之后发生。")]
		[Category("H.调整")]
		[O_Oo00Oo000O0(26.0)]
		public EventString AfterResizeRow
		{
			get
			{
				return this.o_O._o0Oo_O0_.;
			}
			set
			{
				this.o_O._o0Oo_O0_. = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x00150E0D File Offset: 0x0014F00D
		// (set) Token: 0x06002EC0 RID: 11968 RVA: 0x00150E15 File Offset: 0x0014F015
		[Category("I.绘制")]
		[Description("绘制某一单元格的时候执行，该事件执行非常频繁，对性能影响极大，代码必需简洁高效,不能有耗时的计算和操作。")]
		[oO0oooo("0656")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(28.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DrawCell
		{
			get
			{
				return this.Oo0.o0O_oO.;
			}
			set
			{
				this.Oo0.o0O_oO. = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x00150E1E File Offset: 0x0014F01E
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x00150E26 File Offset: 0x0014F026
		[Description("绘制某一行之前执行，通常用于动态设置行高。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("I.绘制")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("1952")]
		[O_Oo00Oo000O0(28.1)]
		public EventString BeforeDrawRow
		{
			get
			{
				return this.O_0oO_0.____.;
			}
			set
			{
				this.O_0oO_0.____. = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x00150E2F File Offset: 0x0014F02F
		// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x00150E37 File Offset: 0x0014F037
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("J.加载")]
		[oO0oooo("2057")]
		[Description("重新加载数据之前执行。")]
		[O_Oo00Oo000O0(29.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeLoad
		{
			get
			{
				return this.O.00o.;
			}
			set
			{
				this.O.00o. = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x00150E40 File Offset: 0x0014F040
		// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x00150E48 File Offset: 0x0014F048
		[oO0oooo("2058")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("重新加载数据之后执行。")]
		[Category("J.加载")]
		[O_Oo00Oo000O0(30.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterLoad
		{
			get
			{
				return this.oo.O__.;
			}
			set
			{
				this.oo.O__. = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x00150E51 File Offset: 0x0014F051
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00150E59 File Offset: 0x0014F059
		[O0O0oOO00_0OO(true)]
		[Category("K.筛选")]
		[Description("筛选数据之前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2059")]
		[O_Oo00Oo000O0(31.0)]
		public EventString BeforeFilter
		{
			get
			{
				return this.O.O0O__OO0.;
			}
			set
			{
				this.O.O0O__OO0. = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00150E62 File Offset: 0x0014F062
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00150E6A File Offset: 0x0014F06A
		[Category("K.筛选")]
		[oO0oooo("2060")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("筛选数据之后执行。")]
		[O_Oo00Oo000O0(32.0)]
		public EventString AfterFilter
		{
			get
			{
				return this.o_Oo.o000OOO00.;
			}
			set
			{
				this.o_Oo.o000OOO00. = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00150E73 File Offset: 0x0014F073
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x00150E7B File Offset: 0x0014F07B
		[oO0oooo("2061")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("数据排序之前执行。")]
		[O0O0oOO00_0OO(true)]
		[Category("L.排序")]
		[O_Oo00Oo000O0(33.0)]
		public EventString BeforeSort
		{
			get
			{
				return this.oO_._0.;
			}
			set
			{
				this.oO_._0. = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00150E84 File Offset: 0x0014F084
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x00150E8C File Offset: 0x0014F08C
		[Category("L.排序")]
		[Description("数据排序之后执行。")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("2062")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(34.0)]
		public EventString AfterSort
		{
			get
			{
				return this.OO._O_0.;
			}
			set
			{
				this.OO._O_0. = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00150E95 File Offset: 0x0014F095
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00150E9D File Offset: 0x0014F09D
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("双击单元格后执行。")]
		[Category("M.鼠标与键盘")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("1499")]
		[O_Oo00Oo000O0(37.0)]
		public EventString DoubleClick
		{
			get
			{
				return this.O.00oo_0OOOO0o.;
			}
			set
			{
				this.O.00oo_0OOOO0o. = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00150EA6 File Offset: 0x0014F0A6
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00150EAE File Offset: 0x0014F0AE
		[Description("单击单元格后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2386")]
		[Category("M.鼠标与键盘")]
		[O_Oo00Oo000O0(37.0)]
		[O0O0oOO00_0OO(true)]
		public EventString Click
		{
			get
			{
				return this.O0o0.o.;
			}
			set
			{
				this.O0o0.o. = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00150EB7 File Offset: 0x0014F0B7
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00150EBF File Offset: 0x0014F0BF
		[oO0oooo("2678")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("鼠标进入某个单元格的时候执行。")]
		[Category("M.鼠标与键盘")]
		[O_Oo00Oo000O0(37.5)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnterCell
		{
			get
			{
				return this.o.O_O_ooo0.;
			}
			set
			{
				this.o.O_O_ooo0. = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x00150EC8 File Offset: 0x0014F0C8
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x00150ED0 File Offset: 0x0014F0D0
		[oO0oooo("2679")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("M.鼠标与键盘")]
		[Description("鼠标离开某个单元格的时候执行。")]
		[O_Oo00Oo000O0(37.5)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeaveCell
		{
			get
			{
				return this.o0_O000O._.;
			}
			set
			{
				this.o0_O000O._. = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x00150ED9 File Offset: 0x0014F0D9
		// (set) Token: 0x06002ED8 RID: 11992 RVA: 0x00150EE1 File Offset: 0x0014F0E1
		[Category("M.鼠标与键盘")]
		[oO0oooo("3750")]
		[Description("鼠标停留在某个单元格的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.55)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseHoverCell
		{
			get
			{
				return this.o_.0o__0.;
			}
			set
			{
				this.o_.0o__0. = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x00150EEA File Offset: 0x0014F0EA
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00150EF2 File Offset: 0x0014F0F2
		[oO0oooo("2929")]
		[Category("M.鼠标与键盘")]
		[Description("双击行头时执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.6)]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClickRowHeader
		{
			get
			{
				return this.Oo00_0.0o.;
			}
			set
			{
				this.Oo00_0.0o. = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00150EFB File Offset: 0x0014F0FB
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00150F03 File Offset: 0x0014F103
		[oO0oooo("1642")]
		[Category("M.鼠标与键盘")]
		[Description("压下按键时执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(38.0)]
		public EventString KeyDown
		{
			get
			{
				return this.o0._o00_0_O_0O.;
			}
			set
			{
				this.o0._o00_0_O_0O. = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x00150F0C File Offset: 0x0014F10C
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00150F14 File Offset: 0x0014F114
		[oO0oooo("1643")]
		[Category("M.鼠标与键盘")]
		[Description("松开按键执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(39.0)]
		public EventString KeyUp
		{
			get
			{
				return this.OOo_O_O.0oooO0.;
			}
			set
			{
				this.OOo_O_O.0oooO0. = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00150F1D File Offset: 0x0014F11D
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00150F25 File Offset: 0x0014F125
		[oO0oooo("2210")]
		[Category("N.附件")]
		[Description("向图片列或文件列添加文件的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAttachFile
		{
			get
			{
				return this.oO0.0OoO.;
			}
			set
			{
				this.oO0.0OoO. = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00150F2E File Offset: 0x0014F12E
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00150F36 File Offset: 0x0014F136
		[oO0oooo("2637")]
		[Category("N.附件")]
		[Description("打开附件文件或者图片的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.2)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeOpenFile
		{
			get
			{
				return this.o_0_0.0.;
			}
			set
			{
				this.o_0_0.0. = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00150F3F File Offset: 0x0014F13F
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00150F47 File Offset: 0x0014F147
		[oO0oooo("2638")]
		[Category("N.附件")]
		[Description("添加附件文件或者图片的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAddFile
		{
			get
			{
				return this.o_oOoo_O._00.;
			}
			set
			{
				this.o_oOoo_O._00. = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x00150F50 File Offset: 0x0014F150
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00150F58 File Offset: 0x0014F158
		[oO0oooo("2716")]
		[Category("N.附件")]
		[Description("删除附件文件或图片的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.3)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDeleteFile
		{
			get
			{
				return this.oOo00_O.0_o0.;
			}
			set
			{
				this.oOo00_O.0_o0. = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x00150F61 File Offset: 0x0014F161
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00150F69 File Offset: 0x0014F169
		[oO0oooo("0661")]
		[Category("O.杂项")]
		[Description("加载表设置后执行，可以在此处添加代码，对表和列的属性进行设置。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterLoadTableSetting
		{
			get
			{
				return this.O_o_.o.;
			}
			set
			{
				this.O_o_.o. = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00150F72 File Offset: 0x0014F172
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00150F7A File Offset: 0x0014F17A
		[oO0oooo("0662")]
		[Category("O.杂项")]
		[Description("显示快捷菜单之前执行，可以在此禁止显示快捷菜单，或更改要显示的快捷菜单。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(36.0)]
		public EventString BeforeShowContextMenu
		{
			get
			{
				return this.O0_0__Oo.O_.;
			}
			set
			{
				this.O0_0__Oo.O_. = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x00150F83 File Offset: 0x0014F183
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00150F8B File Offset: 0x0014F18B
		[oO0oooo("2357")]
		[Category("O.杂项")]
		[Description("滚动表格后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(40.0)]
		public EventString AfterScroll
		{
			get
			{
				return this.o_O_o.o0_.;
			}
			set
			{
				this.o_O_o.o0_. = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x00150F94 File Offset: 0x0014F194
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00150FA1 File Offset: 0x0014F1A1
		[DisplayName("允许拖动列")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(true)]
		[Description("是否可以利用鼠标拖动列标题来调整列位置。")]
		[Category("鼠标")]
		public bool AllowDragColumn
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowDragColumn;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowDragColumn = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00150FAF File Offset: 0x0014F1AF
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x00150FBC File Offset: 0x0014F1BC
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(true)]
		[Category("鼠标")]
		[DisplayName("允许冻结列")]
		[Description("是否可以利用鼠标拖动来调整冻结列数。")]
		public bool AllowFreezeColumn
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowFreezeColumn;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowFreezeColumn = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x00150FCA File Offset: 0x0014F1CA
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x00150FD7 File Offset: 0x0014F1D7
		[DefaultValue(true)]
		[O_Oo00Oo000O0(4.0)]
		[Category("鼠标")]
		[DisplayName("允许调整列宽")]
		[Description("是否可以利用鼠标拖动来调整列宽。")]
		public bool AllowResizeColumn
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowResizeColumn;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowResizeColumn = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00150FE5 File Offset: 0x0014F1E5
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x00150FF2 File Offset: 0x0014F1F2
		[Category("鼠标")]
		[Description("是否可以利用鼠标拖动来调整行高。")]
		[DisplayName("允许调整行高")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(true)]
		public bool AllowResizeRow
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowResizeRow;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowResizeRow = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x00151000 File Offset: 0x0014F200
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x0015100D File Offset: 0x0014F20D
		[Description("用鼠标调整行高时，是否可以分别调整没每一行的高度。")]
		[Category("鼠标")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("允许分别调整行高")]
		public bool AllowResizeSingleRow
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowResizeSingleRow;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowResizeSingleRow = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x0015101B File Offset: 0x0014F21B
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00151028 File Offset: 0x0014F228
		[DefaultValue(true)]
		[O_Oo00Oo000O0(-1.0)]
		[Category("操作")]
		[DisplayName("允许编辑")]
		public bool AllowEdit
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowEdit;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowEdit = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00151036 File Offset: 0x0014F236
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00151043 File Offset: 0x0014F243
		[O_Oo00Oo000O0(-0.9)]
		[DefaultValue(0)]
		[DisplayName("保持编辑状态")]
		[Category("操作")]
		public BooleanEnum PreserveEditMode
		{
			get
			{
				return this.o__.0ooOOoo0o..PreserveEditMode2;
			}
			set
			{
				this.o__.0ooOOoo0o..PreserveEditMode2 = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00151051 File Offset: 0x0014F251
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x0015105E File Offset: 0x0014F25E
		[DefaultValue(true)]
		[O_Oo00Oo000O0(7.0)]
		[Category("操作")]
		[DisplayName("允许增加行")]
		public bool AllowAddNew
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowAddNew;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowAddNew = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x0015106C File Offset: 0x0014F26C
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00151079 File Offset: 0x0014F279
		[DefaultValue(false)]
		[Description("在最后一个单元格按回车时，是否自动增加一行")]
		[O_Oo00Oo000O0(7.1)]
		[Category("操作")]
		[DisplayName("自动增加行")]
		public bool AutoAddNew
		{
			get
			{
				return this.o__.0ooOOoo0o..AutoAddNew;
			}
			set
			{
				this.o__.0ooOOoo0o..AutoAddNew = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x00151087 File Offset: 0x0014F287
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00151094 File Offset: 0x0014F294
		[O_Oo00Oo000O0(8.0)]
		[Category("操作")]
		[DefaultValue(true)]
		[DisplayName("允许删除行")]
		public bool AllowDelete
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowDelete;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowDelete = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x001510A2 File Offset: 0x0014F2A2
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x001510AF File Offset: 0x0014F2AF
		[DisplayName("允许锁定行")]
		[Category("操作")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(true)]
		public bool AllowLockRow
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowLockRow;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowLockRow = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x001510BD File Offset: 0x0014F2BD
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x001510CA File Offset: 0x0014F2CA
		[DefaultValue(true)]
		[DisplayName("允许解锁行")]
		[O_Oo00Oo000O0(10.0)]
		[Category("操作")]
		public bool AllowUnLockRow
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowUnlockRow;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowUnlockRow = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x001510D8 File Offset: 0x0014F2D8
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x001510E5 File Offset: 0x0014F2E5
		[DefaultValue(true)]
		[Description("设为False，将禁止用户复制粘贴表中数据，防止重要数据被非法复制。")]
		[Category("操作")]
		[DisplayName("允许复制粘贴")]
		[O_Oo00Oo000O0(10.1)]
		public bool AllowClipBoard
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowClipBoard;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowClipBoard = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x001510F3 File Offset: 0x0014F2F3
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00151100 File Offset: 0x0014F300
		[O_Oo00Oo000O0(10.2)]
		[Category("操作")]
		[DisplayName("允许初始化")]
		[DefaultValue(true)]
		[Description("设为False，将禁止用户初始化此表。")]
		public bool AllowInitialize
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowInitialize;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowInitialize = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x0015110E File Offset: 0x0014F30E
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x0015111B File Offset: 0x0014F31B
		[Description("设为False，将禁止用户重定向此表。")]
		[O_Oo00Oo000O0(10.2)]
		[DefaultValue(true)]
		[DisplayName("允许重定向")]
		[Category("操作")]
		public bool AllowRedirect
		{
			get
			{
				return this.o__.0ooOOoo0o..AllowRedirect;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowRedirect = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00151129 File Offset: 0x0014F329
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00151136 File Offset: 0x0014F336
		[Description("是否允许用户直接通过菜单筛选后台数据。")]
		[O_Oo00Oo000O0(15.0)]
		[DisplayName("分页后台筛选")]
		[Category("操作")]
		[DefaultValue(false)]
		public bool AllowBackEndFilter
		{
			get
			{
				return this.o__.0ooOOoo0o..o0OOOo_.0_o_0o.;
			}
			set
			{
				this.o__.0ooOOoo0o..AllowBackEndFilter = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x00151144 File Offset: 0x0014F344
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x00151151 File Offset: 0x0014F351
		[Description("是否在删除行之前提示用户确认。")]
		[O_Oo00Oo000O0(12.0)]
		[Category("操作")]
		[DisplayName("删除行需要确认")]
		[DefaultValue(true)]
		public bool DeleteRowPrompt
		{
			get
			{
				return this.o__.0ooOOoo0o..DeleteRowPrompt;
			}
			set
			{
				this.o__.0ooOOoo0o..DeleteRowPrompt = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x0015115F File Offset: 0x0014F35F
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x0015116C File Offset: 0x0014F36C
		[O_Oo00Oo000O0(13.0)]
		[DefaultValue(false)]
		[DisplayName("按回车键向下移动")]
		[Category("操作")]
		public bool EnterKeyActionDown
		{
			get
			{
				return this.o__.0ooOOoo0o..EnterKeyActionDown;
			}
			set
			{
				this.o__.0ooOOoo0o..EnterKeyActionDown = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x0015117A File Offset: 0x0014F37A
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00151187 File Offset: 0x0014F387
		[DisplayName("按Tab键向下移动")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(14.0)]
		[Category("操作")]
		public bool TabKeyActionDown
		{
			get
			{
				return this.o__.0ooOOoo0o..TabKeyActionDown;
			}
			set
			{
				this.o__.0ooOOoo0o..TabKeyActionDown = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00151198 File Offset: 0x0014F398
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x001511A6 File Offset: 0x0014F3A6
		[OooO0(true)]
		[Browsable(false)]
		public bool SystemVisualStyle
		{
			get
			{
				bool result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x001511A8 File Offset: 0x0014F3A8
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x001511B5 File Offset: 0x0014F3B5
		[DisplayName("表格样式")]
		[O_Oo00Oo000O0(-1.0)]
		[Browsable(false)]
		[Category("杂项")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return this.o__.0ooOOoo0o..O0__.00.;
			}
			set
			{
				this.o__.0ooOOoo0o..O0__.00. = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x001511C3 File Offset: 0x0014F3C3
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x001511D0 File Offset: 0x0014F3D0
		[O_Oo00Oo000O0(1.0)]
		[Category("杂项")]
		[DisplayName("启用多层表头")]
		[DefaultValue(true)]
		public bool MultiRowHeader
		{
			get
			{
				return this.o__.0ooOOoo0o..MultiRowHeader;
			}
			set
			{
				this.o__.0ooOOoo0o..MultiRowHeader = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x001511DE File Offset: 0x0014F3DE
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x001511EB File Offset: 0x0014F3EB
		[DisplayName("自定义图标")]
		[O_Oo00Oo000O0(2.0)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Category("杂项")]
		public string CustomImage
		{
			get
			{
				return this.o__.0ooOOoo0o..frd_CustomImage;
			}
			set
			{
				this.o__.0ooOOoo0o..frd_CustomImage = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x001511F9 File Offset: 0x0014F3F9
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00151206 File Offset: 0x0014F406
		[O_Oo00Oo000O0(5.0)]
		[Category("杂项")]
		[DisplayName("责任设计者")]
		[TypeConverter(typeof(oO0O_O))]
		[Description("指定负责此表属性和事件设计的用户")]
		public string Developer
		{
			get
			{
				return this.o__.0ooOOoo0o..Developer;
			}
			set
			{
				this.o__.0ooOOoo0o..Developer = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00151214 File Offset: 0x0014F414
		[Browsable(false)]
		[OooO0(true)]
		public static bool Connected
		{
			get
			{
				return DataTableProperty.o.O0_oo0O.;
			}
		}

		// Token: 0x04001287 RID: 4743
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04001288 RID: 4744
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001289 RID: 4745
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128A RID: 4746
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128B RID: 4747
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128C RID: 4748
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128D RID: 4749
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128E RID: 4750
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400128F RID: 4751
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001290 RID: 4752
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001291 RID: 4753
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001292 RID: 4754
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001293 RID: 4755
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001294 RID: 4756
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001295 RID: 4757
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001296 RID: 4758
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001297 RID: 4759
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001298 RID: 4760
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001299 RID: 4761
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129A RID: 4762
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129B RID: 4763
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129C RID: 4764
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129D RID: 4765
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129E RID: 4766
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400129F RID: 4767
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A0 RID: 4768
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A1 RID: 4769
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A2 RID: 4770
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A3 RID: 4771
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A4 RID: 4772
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A5 RID: 4773
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A6 RID: 4774
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A7 RID: 4775
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A8 RID: 4776
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012A9 RID: 4777
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AA RID: 4778
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AB RID: 4779
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AC RID: 4780
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AD RID: 4781
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AE RID: 4782
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012AF RID: 4783
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B0 RID: 4784
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B1 RID: 4785
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B2 RID: 4786
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B3 RID: 4787
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B4 RID: 4788
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B5 RID: 4789
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B6 RID: 4790
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B7 RID: 4791
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B8 RID: 4792
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012B9 RID: 4793
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BA RID: 4794
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BB RID: 4795
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BC RID: 4796
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BD RID: 4797
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BE RID: 4798
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012BF RID: 4799
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C0 RID: 4800
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C1 RID: 4801
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C2 RID: 4802
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C3 RID: 4803
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C4 RID: 4804
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C5 RID: 4805
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C6 RID: 4806
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C7 RID: 4807
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C8 RID: 4808
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040012C9 RID: 4809
		private int <<EMPTY_NAME>>;

		// Token: 0x040012CA RID: 4810
		private int <<EMPTY_NAME>>;

		// Token: 0x040012CB RID: 4811
		private string <<EMPTY_NAME>>;

		// Token: 0x040012CC RID: 4812
		private static bool <<EMPTY_NAME>> = true;
	}
}
