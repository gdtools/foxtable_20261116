using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200018C RID: 396
	internal class FontPickerProperty : ControlPropertyBase
	{
		// Token: 0x060012FB RID: 4859 RVA: 0x00083B6C File Offset: 0x00081D6C
		internal FontPickerProperty(ControlHolder A_0) : base(A_0)
		{
			this.O0_o0.o__. = (C1FontPicker)A_0.ChildControl;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00083B86 File Offset: 0x00081D86
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00083B8E File Offset: 0x00081D8E
		[DefaultValue(0)]
		[MergableProperty(true)]
		[Description("是否禁止用户修改。")]
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[Category("基本")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O0_o0.o__.;
			}
			set
			{
				this.O0_o0.o__. = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00083B97 File Offset: 0x00081D97
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00083B9F File Offset: 0x00081D9F
		[DisplayName("绑定到")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.1)]
		[DefaultValue("")]
		[Category("基本")]
		[MergableProperty(true)]
		public string BindingField
		{
			get
			{
				return this.O0_o0.o__.;
			}
			set
			{
				this.O0_o0.o__. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.O0_o0.o__..Text = value;
					return;
				}
				this.O0_o0.o__..Text = this.Name;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00083BD8 File Offset: 0x00081DD8
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00083BE6 File Offset: 0x00081DE6
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

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00083BE8 File Offset: 0x00081DE8
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x00083BFA File Offset: 0x00081DFA
		[Category("外观")]
		[O_Oo00Oo000O0(0.0)]
		[DefaultValue("(default)")]
		[DisplayName("样式")]
		[TypeConverter(typeof(o00))]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O0_o0.o__.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O0_o0.o__.
				});
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00083C16 File Offset: 0x00081E16
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x00083C23 File Offset: 0x00081E23
		[DefaultValue(2)]
		[O_Oo00Oo000O0(0.4)]
		[Category("外观")]
		[MergableProperty(true)]
		[DisplayName("边框样式")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O0_o0.o__..BorderStyle;
			}
			set
			{
				this.O0_o0.o__..BorderStyle = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00083C31 File Offset: 0x00081E31
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00083C3E File Offset: 0x00081E3E
		[O_Oo00Oo000O0(0.41)]
		[Category("外观")]
		[DisplayName("边框颜色")]
		[DefaultValue(-10197916)]
		[MergableProperty(true)]
		public Color BorderColor
		{
			get
			{
				return this.O0_o0.o__..BorderColor;
			}
			set
			{
				this.O0_o0.o__..BorderColor = value;
				if (this.O0_o0.o__..BorderStyle != BorderStyle.FixedSingle)
				{
					this.O0_o0.o__..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00083C66 File Offset: 0x00081E66
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00083C6E File Offset: 0x00081E6E
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[Description("选择不同字体后执行")]
		[oO0oooo("0769")]
		[O_Oo00Oo000O0(0.1)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString ValueChanged
		{
			get
			{
				return this.ooOoo.O.;
			}
			set
			{
				this.ooOoo.O. = value;
			}
		}

		// Token: 0x04000756 RID: 1878
		private C1FontPicker <<EMPTY_NAME>>;

		// Token: 0x04000757 RID: 1879
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000758 RID: 1880
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000759 RID: 1881
		private string <<EMPTY_NAME>>;

		// Token: 0x0400075A RID: 1882
		private EventString <<EMPTY_NAME>>;
	}
}
