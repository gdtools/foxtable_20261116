using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200018A RID: 394
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormMenuItemProperty
	{
		// Token: 0x060012CE RID: 4814 RVA: 0x0008398F File Offset: 0x00081B8F
		public FormMenuItemProperty()
		{
			this.oO0_o.o. = StripItemTypeEnum.MenuItem;
			this.oO0_o.o. = TextPositionEnum.Right;
			this.ooo_o__OO_.o. = ToolStripItemAlignment.Left;
			this.ooO0.__0_0_. = true;
			this.oO0o00.00_. = true;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000839BA File Offset: 0x00081BBA
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x000839C2 File Offset: 0x00081BC2
		[Browsable(false)]
		public StripItemTypeEnum Type
		{
			get
			{
				return this.oO0_o.o.;
			}
			set
			{
				this.oO0_o.o. = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000839CB File Offset: 0x00081BCB
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x000839D3 File Offset: 0x00081BD3
		[DisplayName("类型")]
		[Category("属性")]
		[OooO0(true)]
		[O_Oo00Oo000O0(0.0)]
		public StripItemTypeEnum2 Type2
		{
			get
			{
				return (StripItemTypeEnum2)this.oO0_o.o.;
			}
			set
			{
				this.oO0_o.o. = (StripItemTypeEnum)value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000839DC File Offset: 0x00081BDC
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x000839E4 File Offset: 0x00081BE4
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("名称")]
		[Category("属性")]
		public string Name
		{
			get
			{
				return this.oO0_o.o.;
			}
			set
			{
				this.oO0_o.o. = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000839ED File Offset: 0x00081BED
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x000839F5 File Offset: 0x00081BF5
		[DisplayName("标题")]
		[O_Oo00Oo000O0(2.0)]
		[Category("属性")]
		public string Text
		{
			get
			{
				return this.ooO._Oo_OOoO.;
			}
			set
			{
				this.ooO._Oo_OOoO. = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000839FE File Offset: 0x00081BFE
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00083A06 File Offset: 0x00081C06
		[DisplayName("提示")]
		[Category("属性")]
		[O_Oo00Oo000O0(2.1)]
		public string ToolTipText
		{
			get
			{
				return this.oo0.o0_0_.;
			}
			set
			{
				this.oo0.o0_0_. = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00083A0F File Offset: 0x00081C0F
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00083A17 File Offset: 0x00081C17
		[Category("属性")]
		[O_Oo00Oo000O0(3.0)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[DisplayName("图标")]
		public string ImageFile
		{
			get
			{
				return this.OO0._o_0_o_OO.;
			}
			set
			{
				this.OO0._o_0_o_OO. = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00083A20 File Offset: 0x00081C20
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00083A28 File Offset: 0x00081C28
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		[DefaultValue(false)]
		[DisplayName("勾选")]
		public bool Checked
		{
			get
			{
				return this.O._0O0__o.;
			}
			set
			{
				this.O._0O0__o. = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00083A31 File Offset: 0x00081C31
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00083A39 File Offset: 0x00081C39
		[DisplayName("快捷键")]
		[O_Oo00Oo000O0(4.1)]
		[DefaultValue(false)]
		[Category("属性")]
		public Keys ShortcutKeys
		{
			get
			{
				return this.oO0_o.o.;
			}
			set
			{
				this.oO0_o.o. = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00083A42 File Offset: 0x00081C42
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00083A4A File Offset: 0x00081C4A
		[Category("属性")]
		[O_Oo00Oo000O0(6.0)]
		[DefaultValue(false)]
		[DisplayName("显示标题")]
		public bool DisplayText
		{
			get
			{
				return this.OO0._o_0_o_OO.;
			}
			set
			{
				this.OO0._o_0_o_OO. = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00083A53 File Offset: 0x00081C53
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00083A5B File Offset: 0x00081C5B
		[DefaultValue(0)]
		[Category("属性")]
		[DisplayName("标题位置")]
		[O_Oo00Oo000O0(7.0)]
		public TextPositionEnum TextPosition
		{
			get
			{
				return this.oO0_o.o.;
			}
			set
			{
				this.oO0_o.o. = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00083A64 File Offset: 0x00081C64
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00083A6C File Offset: 0x00081C6C
		[Category("属性")]
		[DisplayName("列表项目")]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(false)]
		public string ComboList
		{
			get
			{
				return this.o.0Oo_0__oO_O_.;
			}
			set
			{
				this.o.0Oo_0__oO_O_. = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00083A75 File Offset: 0x00081C75
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00083A7D File Offset: 0x00081C7D
		[DefaultValue(false)]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("位置")]
		[Category("属性")]
		public ToolStripItemAlignment Alignment
		{
			get
			{
				return this.ooo_o__OO_.o.;
			}
			set
			{
				this.ooo_o__OO_.o. = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00083A86 File Offset: 0x00081C86
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00083A8E File Offset: 0x00081C8E
		[O_Oo00Oo000O0(10.0)]
		[DefaultValue(true)]
		[Category("属性")]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.oO0o00.00_.;
			}
			set
			{
				this.oO0o00.00_. = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00083A97 File Offset: 0x00081C97
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00083A9F File Offset: 0x00081C9F
		[O_Oo00Oo000O0(11.0)]
		[DefaultValue(true)]
		[DisplayName("可用")]
		[Category("属性")]
		public bool Enabeld
		{
			get
			{
				return this.ooO0.__0_0_.;
			}
			set
			{
				this.ooO0.__0_0_. = value;
			}
		}

		// Token: 0x04000741 RID: 1857
		private string <<EMPTY_NAME>>;

		// Token: 0x04000742 RID: 1858
		private string <<EMPTY_NAME>>;

		// Token: 0x04000743 RID: 1859
		private string <<EMPTY_NAME>>;

		// Token: 0x04000744 RID: 1860
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000745 RID: 1861
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000746 RID: 1862
		private StripItemTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000747 RID: 1863
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000748 RID: 1864
		private TextPositionEnum <<EMPTY_NAME>>;

		// Token: 0x04000749 RID: 1865
		private string <<EMPTY_NAME>>;

		// Token: 0x0400074A RID: 1866
		private ToolStripItemAlignment <<EMPTY_NAME>>;

		// Token: 0x0400074B RID: 1867
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400074C RID: 1868
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400074D RID: 1869
		private Keys <<EMPTY_NAME>>;

		// Token: 0x0400074E RID: 1870
		private string <<EMPTY_NAME>>;
	}
}
