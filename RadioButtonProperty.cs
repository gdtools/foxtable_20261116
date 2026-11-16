using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000422 RID: 1058
	internal class RadioButtonProperty : ControlPropertyBase
	{
		// Token: 0x06004741 RID: 18241 RVA: 0x001F36E2 File Offset: 0x001F18E2
		public RadioButtonProperty(ControlHolder A_0) : base(A_0)
		{
			this.oO0000.OO0oo. = (RadioButton)A_0.ChildControl;
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x001F36FC File Offset: 0x001F18FC
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x001F3704 File Offset: 0x001F1904
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("绑定到")]
		[MergableProperty(false)]
		[DefaultValue("")]
		[Category("基本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		public string BindingField
		{
			get
			{
				return this.Oo.O0OOo0.;
			}
			set
			{
				this.Oo.O0OOo0. = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x001F370D File Offset: 0x001F190D
		// (set) Token: 0x06004745 RID: 18245 RVA: 0x001F3715 File Offset: 0x001F1915
		[Description("是否禁止用户修改。")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.3)]
		[Category("基本")]
		[DisplayName("只读")]
		[DefaultValue(0)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.oO0000.OO0oo.;
			}
			set
			{
				this.oO0000.OO0oo. = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x001F371E File Offset: 0x001F191E
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x001F372B File Offset: 0x001F192B
		[DisplayName("标题")]
		[O_Oo00Oo000O0(2.4)]
		[MergableProperty(true)]
		[Category("基本")]
		public virtual string Text
		{
			get
			{
				return this.oO0000.OO0oo..Text;
			}
			set
			{
				this.oO0000.OO0oo..Text = value;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x001F3739 File Offset: 0x001F1939
		// (set) Token: 0x06004749 RID: 18249 RVA: 0x001F3746 File Offset: 0x001F1946
		[DisplayName("选中")]
		[Category("基本")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(2.5)]
		[MergableProperty(true)]
		public bool Checked
		{
			get
			{
				return this.oO0000.OO0oo..Checked;
			}
			set
			{
				this.oO0000.OO0oo..Checked = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x001F3754 File Offset: 0x001F1954
		// (set) Token: 0x0600474B RID: 18251 RVA: 0x001F3761 File Offset: 0x001F1961
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("外观样式")]
		[O_Oo00Oo000O0(0.01)]
		public Appearance Appearance
		{
			get
			{
				return this.oO0000.OO0oo..Appearance;
			}
			set
			{
				this.oO0000.OO0oo..Appearance = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x001F376F File Offset: 0x001F196F
		// (set) Token: 0x0600474D RID: 18253 RVA: 0x001F3778 File Offset: 0x001F1978
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.1)]
		[DisplayName("图标")]
		[Category("外观")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string ImageFile
		{
			get
			{
				return this.oO0000.OO0oo.;
			}
			set
			{
				bool flag = Operators.CompareString(this.oO0000.OO0oo., "", true) == 0 & Operators.CompareString(value, "", true) > 0;
				this.oO0000.OO0oo. = value;
				this.oO0000.OO0oo..Image = OO_00oOO.GetImage(this.oO0000.OO0oo.);
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x001F37C7 File Offset: 0x001F19C7
		// (set) Token: 0x0600474F RID: 18255 RVA: 0x001F37D4 File Offset: 0x001F19D4
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.2)]
		[DefaultValue(16)]
		[DisplayName("文本位置")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.oO0000.OO0oo..TextAlign;
			}
			set
			{
				this.oO0000.OO0oo..TextAlign = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x001F37E2 File Offset: 0x001F19E2
		// (set) Token: 0x06004751 RID: 18257 RVA: 0x001F37EF File Offset: 0x001F19EF
		[O_Oo00Oo000O0(0.3)]
		[MergableProperty(true)]
		[DisplayName("单选框位置")]
		[DefaultValue(16)]
		[Category("外观")]
		public ContentAlignment CheckAlign
		{
			get
			{
				return this.oO0000.OO0oo..CheckAlign;
			}
			set
			{
				this.oO0000.OO0oo..CheckAlign = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x001F37FD File Offset: 0x001F19FD
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x001F380A File Offset: 0x001F1A0A
		[DisplayName("图标位置")]
		[DefaultValue(32)]
		[O_Oo00Oo000O0(0.4)]
		[Category("外观")]
		[MergableProperty(true)]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.oO0000.OO0oo..ImageAlign;
			}
			set
			{
				this.oO0000.OO0oo..ImageAlign = value;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x001F3818 File Offset: 0x001F1A18
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x001F3825 File Offset: 0x001F1A25
		[Description("设置文本和图标的相对位置。")]
		[O_Oo00Oo000O0(0.5)]
		[Category("外观")]
		[MergableProperty(true)]
		[DisplayName("相对位置")]
		[DefaultValue(0)]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.oO0000.OO0oo..TextImageRelation;
			}
			set
			{
				this.oO0000.OO0oo..TextImageRelation = value;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x001F3833 File Offset: 0x001F1A33
		// (set) Token: 0x06004757 RID: 18263 RVA: 0x001F383B File Offset: 0x001F1A3B
		[Description("选中属性发生变化后执行。")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[oO0oooo("0781")]
		[O0O0oOO00_0OO(true)]
		public EventString CheckedChanged
		{
			get
			{
				return this.oO0000.OO0oo.;
			}
			set
			{
				this.oO0000.OO0oo. = value;
			}
		}

		// Token: 0x04001CC6 RID: 7366
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001CC7 RID: 7367
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CC8 RID: 7368
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001CC9 RID: 7369
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CCA RID: 7370
		private EventString <<EMPTY_NAME>>;
	}
}
