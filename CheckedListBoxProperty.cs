using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200040D RID: 1037
	internal class CheckedListBoxProperty : ControlPropertyBase
	{
		// Token: 0x060044B9 RID: 17593 RVA: 0x001F0E21 File Offset: 0x001EF021
		public CheckedListBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.oo0._. = ',';
			this.O_.o_O0O_o__. = (CheckedListBox)A_0.ChildControl;
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x001F0E43 File Offset: 0x001EF043
		// (set) Token: 0x060044BB RID: 17595 RVA: 0x001F0E50 File Offset: 0x001EF050
		[O_Oo00Oo000O0(0.4)]
		[MergableProperty(true)]
		[DisplayName("边框")]
		[Category("外观")]
		[DefaultValue(2)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O_.o_O0O_o__..BorderStyle;
			}
			set
			{
				this.O_.o_O0O_o__..BorderStyle = value;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x001F0E5E File Offset: 0x001EF05E
		// (set) Token: 0x060044BD RID: 17597 RVA: 0x001F0E66 File Offset: 0x001EF066
		[Category("基本")]
		[DisplayName("绑定到")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.1)]
		[MergableProperty(false)]
		public string BindingField
		{
			get
			{
				return this.o0Oo._0O.;
			}
			set
			{
				this.o0Oo._0O. = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x001F0E6F File Offset: 0x001EF06F
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x001F0E77 File Offset: 0x001EF077
		[MergableProperty(true)]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(2.3)]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[DisplayName("只读")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.oo0._.;
			}
			set
			{
				this.oo0._. = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x001F0E80 File Offset: 0x001EF080
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x001F0E88 File Offset: 0x001EF088
		[DisplayName("自定义项目")]
		[Category("列表项目")]
		[Editor(typeof(ooO0o0_oO0_0), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		public string ComboList
		{
			get
			{
				return this.O_o._o0O.;
			}
			set
			{
				this.O_o._o0O. = value;
				this.O_.o_O0O_o__..Items.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					string[] array = value.Split(new char[]
					{
						'\r',
						'\n',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries);
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						this.O_.o_O0O_o__..Items.Add(array[i]);
					}
				}
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x001F0EFA File Offset: 0x001EF0FA
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x001F0F02 File Offset: 0x001EF102
		[TypeConverter(typeof(oo0OOO_0__))]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(false)]
		[DisplayName("显示列")]
		[Category("列表项目")]
		public string DisplayMember
		{
			get
			{
				return this.OOO0.o.;
			}
			set
			{
				this.OOO0.o. = value;
				if (Operators.CompareString(this.O.ooo0_O., "", true) == 0)
				{
					this.O.ooo0_O. = value;
				}
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x001F0F25 File Offset: 0x001EF125
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x001F0F2D File Offset: 0x001EF12D
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("取值列")]
		[Category("列表项目")]
		[MergableProperty(false)]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string ValueMember
		{
			get
			{
				return this.O.ooo0_O.;
			}
			set
			{
				this.O.ooo0_O. = value;
				if (Operators.CompareString(this.OOO0.o., "", true) == 0)
				{
					this.OOO0.o. = value;
				}
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x001F0F50 File Offset: 0x001EF150
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x001F0F58 File Offset: 0x001EF158
		[Category("列表项目")]
		[TypeConverter(typeof(OoO_O0_OO0))]
		[DisplayName("数据表")]
		[O_Oo00Oo000O0(2.0)]
		[Description("候选项目来源表")]
		[MergableProperty(false)]
		public string DataSource
		{
			get
			{
				return this.o_.oo.;
			}
			set
			{
				this.o_.oo. = value;
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.ValueMember = "";
					this.DisplayMember = "";
					return;
				}
				if (OO_00oOO.DataTables.Contains(value))
				{
					if (Operators.CompareString(this.DisplayMember, "", true) > 0 && !OO_00oOO.DataTables[value].DataCols.Contains(this.DisplayMember))
					{
						this.DisplayMember = "";
					}
					if (Operators.CompareString(this.ValueMember, "", true) > 0 && !OO_00oOO.DataTables[value].DataCols.Contains(this.ValueMember))
					{
						this.ValueMember = "";
					}
				}
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x001F1016 File Offset: 0x001EF216
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x001F101E File Offset: 0x001EF21E
		[Description("用于分隔值的符号")]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("分隔符")]
		[Category("列表项目")]
		[MergableProperty(true)]
		[DefaultValue(',')]
		public char Separator
		{
			get
			{
				return this.oo0._.;
			}
			set
			{
				this.oo0._. = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x001F1027 File Offset: 0x001EF227
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x001F102F File Offset: 0x001EF22F
		[O_Oo00Oo000O0(6.0)]
		[Category("列表项目")]
		[MergableProperty(false)]
		[Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")]
		[Editor(typeof(O0O00), typeof(UITypeEditor))]
		[DisplayName("过滤条件")]
		public string DataFilter
		{
			get
			{
				return this.O_._o.;
			}
			set
			{
				this.O_._o. = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x001F1038 File Offset: 0x001EF238
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x001F1045 File Offset: 0x001EF245
		[O_Oo00Oo000O0(7.0)]
		[Description("是否分多列显示项目。")]
		[DefaultValue(false)]
		[MergableProperty(true)]
		[DisplayName("多列显示")]
		[Category("列表项目")]
		public bool MultiColumn
		{
			get
			{
				return this.O_.o_O0O_o__..MultiColumn;
			}
			set
			{
				this.O_.o_O0O_o__..MultiColumn = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x001F1053 File Offset: 0x001EF253
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x001F1060 File Offset: 0x001EF260
		[Category("列表项目")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("每列列宽")]
		[Description("设置多列显示时，各列的宽度。")]
		[O_Oo00Oo000O0(8.0)]
		public int ColumnWidth
		{
			get
			{
				return this.O_.o_O0O_o__..ColumnWidth;
			}
			set
			{
				this.O_.o_O0O_o__..ColumnWidth = value;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x001F106E File Offset: 0x001EF26E
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x001F107B File Offset: 0x001EF27B
		[MergableProperty(true)]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("自动选中")]
		[Category("列表项目")]
		[Description("复选框是否在首次单击某项时切换。")]
		[DefaultValue(true)]
		public bool CheckOnClick
		{
			get
			{
				return this.O_.o_O0O_o__..CheckOnClick;
			}
			set
			{
				this.O_.o_O0O_o__..CheckOnClick = value;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x001F1089 File Offset: 0x001EF289
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x001F1091 File Offset: 0x001EF291
		[oO0oooo("0962")]
		[Description("选择不同项目后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.oo0._.;
			}
			set
			{
				this.oo0._. = value;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x001F109A File Offset: 0x001EF29A
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x001F10A2 File Offset: 0x001EF2A2
		[oO0oooo("0965")]
		[Description("某一项目的选中状态将要改变时执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString ItemCheck
		{
			get
			{
				return this.o_.oo.;
			}
			set
			{
				this.o_.oo. = value;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x001F10AB File Offset: 0x001EF2AB
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x001F10B3 File Offset: 0x001EF2B3
		[oO0oooo("0963")]
		[Description("格式化列表项目显示值的时候执行！")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.4)]
		public EventString ListItemFormat
		{
			get
			{
				return this.O_o._o0O.;
			}
			set
			{
				this.O_o._o0O. = value;
			}
		}

		// Token: 0x04001BF0 RID: 7152
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001BF1 RID: 7153
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001BF2 RID: 7154
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF3 RID: 7155
		private char <<EMPTY_NAME>>;

		// Token: 0x04001BF4 RID: 7156
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF5 RID: 7157
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF6 RID: 7158
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF7 RID: 7159
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF8 RID: 7160
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BF9 RID: 7161
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BFA RID: 7162
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BFB RID: 7163
		private EventString <<EMPTY_NAME>>;
	}
}
