using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000189 RID: 393
	internal class ColorPickerProperty : ControlPropertyBase
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x0008386C File Offset: 0x00081A6C
		internal ColorPickerProperty(ControlHolder A_0) : base(A_0)
		{
			this.O0._ooOO. = (C1ColorPicker)A_0.ChildControl;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00083886 File Offset: 0x00081A86
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00083893 File Offset: 0x00081A93
		[O_Oo00Oo000O0(2.2)]
		[MergableProperty(false)]
		[DisplayName("默认颜色")]
		[Category("基本")]
		public Color Color
		{
			get
			{
				return this.O0._ooOO..Color;
			}
			set
			{
				this.O0._ooOO..Color = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000838A1 File Offset: 0x00081AA1
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x000838A9 File Offset: 0x00081AA9
		[O_Oo00Oo000O0(2.3)]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[DisplayName("只读")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O0._ooOO.;
			}
			set
			{
				this.O0._ooOO. = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x000838B2 File Offset: 0x00081AB2
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x000838BA File Offset: 0x00081ABA
		[Category("基本")]
		[O_Oo00Oo000O0(2.1)]
		[DefaultValue("")]
		[DisplayName("绑定到")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		public string BindingField
		{
			get
			{
				return this.oOO._O0OOO_o.;
			}
			set
			{
				this.oOO._O0OOO_o. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.O0._ooOO..Text = value;
					return;
				}
				this.O0._ooOO..Text = this.Name;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000838F0 File Offset: 0x00081AF0
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x000838FE File Offset: 0x00081AFE
		[OooO0(false)]
		[Browsable(false)]
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00083900 File Offset: 0x00081B00
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x00083912 File Offset: 0x00081B12
		[DefaultValue("(default)")]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[Category("外观")]
		[TypeConverter(typeof(o00))]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O0._ooOO.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O0._ooOO.
				});
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0008392E File Offset: 0x00081B2E
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x0008393B File Offset: 0x00081B3B
		[DisplayName("边框样式")]
		[O_Oo00Oo000O0(0.4)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(2)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O0._ooOO..BorderStyle;
			}
			set
			{
				this.O0._ooOO..BorderStyle = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00083949 File Offset: 0x00081B49
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x00083956 File Offset: 0x00081B56
		[Category("外观")]
		[DisplayName("边框颜色")]
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		[O_Oo00Oo000O0(0.41)]
		public Color BorderColor
		{
			get
			{
				return this.O0._ooOO..BorderColor;
			}
			set
			{
				this.O0._ooOO..BorderColor = value;
				if (this.O0._ooOO..BorderStyle != BorderStyle.FixedSingle)
				{
					this.O0._ooOO..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x0008397E File Offset: 0x00081B7E
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x00083986 File Offset: 0x00081B86
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[Description("选择不同颜色后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("")]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.O0._ooOO.;
			}
			set
			{
				this.O0._ooOO. = value;
			}
		}

		// Token: 0x0400073D RID: 1853
		private C1ColorPicker <<EMPTY_NAME>>;

		// Token: 0x0400073E RID: 1854
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400073F RID: 1855
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000740 RID: 1856
		private string <<EMPTY_NAME>>;
	}
}
