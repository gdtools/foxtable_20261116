using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200018B RID: 395
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormMenuProperty
	{
		// Token: 0x060012EB RID: 4843 RVA: 0x00083AA8 File Offset: 0x00081CA8
		public FormMenuProperty()
		{
			this.o__OOO.00O0_O. = StripTypeEnum2.快捷菜单;
			this.o__OOO.00O0_O. = new Size(16, 16);
			this.o__OOO.00O0_O. = DockStyle.Top;
			this.o__OOO.00O0_O. = true;
			this.o0.0_O00. = true;
			this.o0.0_O00. = "(default)";
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00083AE6 File Offset: 0x00081CE6
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("类型")]
		[Category("属性")]
		public StripTypeEnum2 Type2
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00083AEE File Offset: 0x00081CEE
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00083AF6 File Offset: 0x00081CF6
		[Browsable(false)]
		public StripTypeEnum2 Type
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
			set
			{
				this.o__OOO.00O0_O. = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00083AFF File Offset: 0x00081CFF
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00083B07 File Offset: 0x00081D07
		[Category("属性")]
		[DisplayName("名称")]
		[O_Oo00Oo000O0(0.0)]
		public string Name
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
			set
			{
				this.o__OOO.00O0_O. = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00083B10 File Offset: 0x00081D10
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00083B18 File Offset: 0x00081D18
		[Category("属性")]
		[DisplayName("样式")]
		[DefaultValue("(default)")]
		[TypeConverter(typeof(oo__O__O_OoO))]
		[O_Oo00Oo000O0(1.0)]
		public string Theme
		{
			get
			{
				return this.o0.0_O00.;
			}
			set
			{
				this.o0.0_O00. = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00083B21 File Offset: 0x00081D21
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00083B29 File Offset: 0x00081D29
		[O_Oo00Oo000O0(1.1)]
		[DefaultValue(true)]
		[Category("属性")]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.o0.0_O00.;
			}
			set
			{
				this.o0.0_O00. = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00083B32 File Offset: 0x00081D32
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00083B3A File Offset: 0x00081D3A
		[DefaultValue(true)]
		[O_Oo00Oo000O0(1.2)]
		[DisplayName("可用")]
		[Category("属性")]
		public bool Enabeld
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
			set
			{
				this.o__OOO.00O0_O. = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00083B43 File Offset: 0x00081D43
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00083B4B File Offset: 0x00081D4B
		[O_Oo00Oo000O0(2.0)]
		[Category("属性")]
		[DisplayName("图标尺寸")]
		public Size ImageSize
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
			set
			{
				this.o__OOO.00O0_O. = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00083B54 File Offset: 0x00081D54
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00083B5C File Offset: 0x00081D5C
		[DisplayName("停靠位置")]
		[Category("属性")]
		[O_Oo00Oo000O0(2.0)]
		public DockStyle Dock
		{
			get
			{
				return this.o__OOO.00O0_O.;
			}
			set
			{
				if (value != DockStyle.None && value != DockStyle.Fill)
				{
					this.o__OOO.00O0_O. = value;
				}
			}
		}

		// Token: 0x0400074F RID: 1871
		private string <<EMPTY_NAME>>;

		// Token: 0x04000750 RID: 1872
		private StripTypeEnum2 <<EMPTY_NAME>>;

		// Token: 0x04000751 RID: 1873
		private Size <<EMPTY_NAME>>;

		// Token: 0x04000752 RID: 1874
		private DockStyle <<EMPTY_NAME>>;

		// Token: 0x04000753 RID: 1875
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000754 RID: 1876
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000755 RID: 1877
		private string <<EMPTY_NAME>>;
	}
}
