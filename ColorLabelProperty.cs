using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200040E RID: 1038
	internal class ColorLabelProperty : ControlPropertyBase
	{
		// Token: 0x060044D8 RID: 17624 RVA: 0x001F10BC File Offset: 0x001EF2BC
		public ColorLabelProperty(ControlHolder A_0) : base(A_0)
		{
			this.oOO._O0OOO_o. = (Label)A_0.ChildControl;
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x001F10D6 File Offset: 0x001EF2D6
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x001F10DE File Offset: 0x001EF2DE
		[DefaultValue("")]
		[O_Oo00Oo000O0(2.1)]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[Category("基本")]
		[DisplayName("绑定到")]
		public string BindingField
		{
			get
			{
				return this.oOO._O0OOO_o.;
			}
			set
			{
				this.oOO._O0OOO_o. = value;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x001F10E7 File Offset: 0x001EF2E7
		// (set) Token: 0x060044DC RID: 17628 RVA: 0x001F10FC File Offset: 0x001EF2FC
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("当前值")]
		[Category("基本")]
		[MergableProperty(true)]
		public override Color BackColor
		{
			get
			{
				return this.o_0_.Oo..ChildControl.BackColor;
			}
			set
			{
				if (this.o_0_.Oo..ControlType != ControlTypeEnum.Button || !(value == SystemColors.Control) || !(this.o_0_.Oo..ChildControl.BackColor == value))
				{
					this.o_0_.Oo..ChildControl.BackColor = value;
				}
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x001F114D File Offset: 0x001EF34D
		// (set) Token: 0x060044DE RID: 17630 RVA: 0x001F1155 File Offset: 0x001EF355
		[Description("禁止用户修改。")]
		[MergableProperty(true)]
		[Category("基本")]
		[O_Oo00Oo000O0(2.3)]
		[DefaultValue(false)]
		[DisplayName("只读")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.oOO._O0OOO_o.;
			}
			set
			{
				this.oOO._O0OOO_o. = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x001F115E File Offset: 0x001EF35E
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x001F116B File Offset: 0x001EF36B
		[O_Oo00Oo000O0(3.1)]
		[DefaultValue(2)]
		[MergableProperty(true)]
		[Category("外观")]
		[DisplayName("边框")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.oOO._O0OOO_o..BorderStyle;
			}
			set
			{
				this.oOO._O0OOO_o..BorderStyle = value;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x001F1179 File Offset: 0x001EF379
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x001F1186 File Offset: 0x001EF386
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("文本位置")]
		[O_Oo00Oo000O0(0.1)]
		[Category("外观")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.oOO._O0OOO_o..TextAlign;
			}
			set
			{
				this.oOO._O0OOO_o..TextAlign = value;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x001F1194 File Offset: 0x001EF394
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x001F119C File Offset: 0x001EF39C
		[Description("值改变后执行")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0792")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString ValueChanged
		{
			get
			{
				return this.oOO._O0OOO_o.;
			}
			set
			{
				this.oOO._O0OOO_o. = value;
			}
		}

		// Token: 0x04001BFC RID: 7164
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001BFD RID: 7165
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001BFE RID: 7166
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BFF RID: 7167
		private EventString <<EMPTY_NAME>>;
	}
}
