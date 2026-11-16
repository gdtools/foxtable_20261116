using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000419 RID: 1049
	internal class ListBoxProperty : ControlPropertyBase
	{
		// Token: 0x06004655 RID: 18005 RVA: 0x001F275A File Offset: 0x001F095A
		public ListBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.O0.ooOo0. = 3;
			this.O0.ooOo0. = (CustomListBox)A_0.ChildControl;
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x001F277B File Offset: 0x001F097B
		// (set) Token: 0x06004657 RID: 18007 RVA: 0x001F2788 File Offset: 0x001F0988
		[DisplayName("边框")]
		[DefaultValue(2)]
		[O_Oo00Oo000O0(0.4)]
		[Category("外观")]
		[MergableProperty(true)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O0.ooOo0..BorderStyle;
			}
			set
			{
				this.O0.ooOo0..BorderStyle = value;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x001F2796 File Offset: 0x001F0996
		// (set) Token: 0x06004659 RID: 18009 RVA: 0x001F27A0 File Offset: 0x001F09A0
		[Category("列表项目")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("自定义项目")]
		[Editor(typeof(ooO0o0_oO0_0), typeof(UITypeEditor))]
		public string ComboList
		{
			get
			{
				return this.O_0__.0oo0.;
			}
			set
			{
				this.O_0__.0oo0. = value;
				this.O0.ooOo0..Items.Clear();
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
						this.O0.ooOo0..Items.Add(array[i]);
					}
				}
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x001F2812 File Offset: 0x001F0A12
		// (set) Token: 0x0600465B RID: 18011 RVA: 0x001F281A File Offset: 0x001F0A1A
		[DisplayName("显示列")]
		[Category("列表项目")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(3.0)]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string DisplayMember
		{
			get
			{
				return this.o0_._O0o.;
			}
			set
			{
				this.o0_._O0o. = value;
				if (Operators.CompareString(this.OO_oo0O0o.OO., "", true) == 0)
				{
					this.OO_oo0O0o.OO. = value;
				}
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x001F283D File Offset: 0x001F0A3D
		// (set) Token: 0x0600465D RID: 18013 RVA: 0x001F2845 File Offset: 0x001F0A45
		[Category("列表项目")]
		[TypeConverter(typeof(oo0OOO_0__))]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(false)]
		[DisplayName("取值列")]
		public string ValueMember
		{
			get
			{
				return this.OO_oo0O0o.OO.;
			}
			set
			{
				this.OO_oo0O0o.OO. = value;
				if (Operators.CompareString(this.o0_._O0o., "", true) == 0)
				{
					this.o0_._O0o. = value;
				}
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x001F2868 File Offset: 0x001F0A68
		// (set) Token: 0x0600465F RID: 18015 RVA: 0x001F2870 File Offset: 0x001F0A70
		[TypeConverter(typeof(OoO_O0_OO0))]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("数据表")]
		[Category("列表项目")]
		[Description("候选项目来源表")]
		[MergableProperty(false)]
		public string DataSource
		{
			get
			{
				return this.O000_o.oo00.;
			}
			set
			{
				this.O000_o.oo00. = value;
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

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x001F292E File Offset: 0x001F0B2E
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x001F2936 File Offset: 0x001F0B36
		[DisplayName("过滤条件")]
		[Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")]
		[Editor(typeof(O0O00), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[Category("列表项目")]
		[MergableProperty(false)]
		public string DataFilter
		{
			get
			{
				return this.o_ooO0o.00_.;
			}
			set
			{
				this.o_ooO0o.00_. = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x001F293F File Offset: 0x001F0B3F
		// (set) Token: 0x06004663 RID: 18019 RVA: 0x001F294C File Offset: 0x001F0B4C
		[DefaultValue(false)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("多列显示")]
		[Category("列表项目")]
		[Description("是否分多列显示项目。")]
		public bool MultiColumn
		{
			get
			{
				return this.O0.ooOo0..MultiColumn;
			}
			set
			{
				this.O0.ooOo0..MultiColumn = value;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x001F295A File Offset: 0x001F0B5A
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x001F2967 File Offset: 0x001F0B67
		[O_Oo00Oo000O0(7.0)]
		[Category("列表项目")]
		[Description("设置多列显示时，各列的宽度。")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("每列列宽")]
		public int ColumnWidth
		{
			get
			{
				return this.O0.ooOo0..ColumnWidth;
			}
			set
			{
				this.O0.ooOo0..ColumnWidth = value;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x001F2975 File Offset: 0x001F0B75
		// (set) Token: 0x06004667 RID: 18023 RVA: 0x001F2982 File Offset: 0x001F0B82
		[DisplayName("项目间距")]
		[DefaultValue(3)]
		[Description("项目间距，单位为像素。")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(7.0)]
		[Category("列表项目")]
		public int ItemSpacing
		{
			get
			{
				return this.O0.ooOo0..ItemSpacing;
			}
			set
			{
				this.O0.ooOo0..ItemSpacing = value;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x001F2990 File Offset: 0x001F0B90
		// (set) Token: 0x06004669 RID: 18025 RVA: 0x001F2998 File Offset: 0x001F0B98
		[MergableProperty(false)]
		[Category("基本")]
		[O_Oo00Oo000O0(2.1)]
		[DisplayName("绑定到")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		public string BindingField
		{
			get
			{
				return this.o._Ooo0oOO.;
			}
			set
			{
				this.o._Ooo0oOO. = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x001F29A1 File Offset: 0x001F0BA1
		// (set) Token: 0x0600466B RID: 18027 RVA: 0x001F29A9 File Offset: 0x001F0BA9
		[O_Oo00Oo000O0(2.3)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("只读")]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O0.ooOo0.;
			}
			set
			{
				this.O0.ooOo0. = value;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x001F29B2 File Offset: 0x001F0BB2
		// (set) Token: 0x0600466D RID: 18029 RVA: 0x001F29BA File Offset: 0x001F0BBA
		[Category("事件")]
		[oO0oooo("0962")]
		[Description("选择不同项目后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.O0.ooOo0.;
			}
			set
			{
				this.O0.ooOo0. = value;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x001F29C3 File Offset: 0x001F0BC3
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x001F29CB File Offset: 0x001F0BCB
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("格式化列表项目显示值的时候执行！")]
		[oO0oooo("0963")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.4)]
		public EventString ListItemFormat
		{
			get
			{
				return this.o0_.O0_0ooo0o.;
			}
			set
			{
				this.o0_.O0_0ooo0o. = value;
			}
		}

		// Token: 0x04001C7E RID: 7294
		private CustomListBox <<EMPTY_NAME>>;

		// Token: 0x04001C7F RID: 7295
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C80 RID: 7296
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C81 RID: 7297
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C82 RID: 7298
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C83 RID: 7299
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C84 RID: 7300
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C85 RID: 7301
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C86 RID: 7302
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C87 RID: 7303
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C88 RID: 7304
		private int <<EMPTY_NAME>>;
	}
}
