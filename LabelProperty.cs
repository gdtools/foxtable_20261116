using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000417 RID: 1047
	internal class LabelProperty : ControlPropertyBase
	{
		// Token: 0x06004637 RID: 17975 RVA: 0x001F259D File Offset: 0x001F079D
		public LabelProperty(ControlHolder A_0) : base(A_0)
		{
			this.O0oo_0_.__0__. = (C1Label)A_0.ChildControl;
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x001F25B7 File Offset: 0x001F07B7
		// (set) Token: 0x06004639 RID: 17977 RVA: 0x001F25C4 File Offset: 0x001F07C4
		[MergableProperty(true)]
		[Category("基本")]
		[Editor(typeof(O0_00_oo0oO_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("文本")]
		public virtual string Text
		{
			get
			{
				return this.O0oo_0_.__0__..Text;
			}
			set
			{
				this.O0oo_0_.__0__..Value = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x001F25D2 File Offset: 0x001F07D2
		// (set) Token: 0x0600463B RID: 17979 RVA: 0x001F25DA File Offset: 0x001F07DA
		[O_Oo00Oo000O0(10.0)]
		[Category("基本")]
		[MergableProperty(true)]
		[DisplayName("格式符号")]
		public string FormatString
		{
			get
			{
				return this.OOOOo.oo0oO.;
			}
			set
			{
				this.OOOOo.oo0oO. = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x001F25E3 File Offset: 0x001F07E3
		// (set) Token: 0x0600463D RID: 17981 RVA: 0x001F25EB File Offset: 0x001F07EB
		[DisplayName("绑定到")]
		[Category("基本")]
		[DefaultValue("")]
		[O_Oo00Oo000O0(2.1)]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		public string BindingField
		{
			get
			{
				return this.O0Ooo0o.0O.;
			}
			set
			{
				this.O0Ooo0o.0O. = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x001F25F4 File Offset: 0x001F07F4
		// (set) Token: 0x0600463F RID: 17983 RVA: 0x001F2606 File Offset: 0x001F0806
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[DisplayName("样式")]
		[DefaultValue("(none)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O0oo_0_.__0__.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O0oo_0_.__0__.
				});
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x001F2622 File Offset: 0x001F0822
		// (set) Token: 0x06004641 RID: 17985 RVA: 0x001F262F File Offset: 0x001F082F
		[DisplayName("自动大小")]
		[O_Oo00Oo000O0(5.1)]
		[Category("位置")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool AutoSize
		{
			get
			{
				return this.O0oo_0_.__0__..AutoSize;
			}
			set
			{
				this.O0oo_0_.__0__..AutoSize = value;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x001F263D File Offset: 0x001F083D
		// (set) Token: 0x06004643 RID: 17987 RVA: 0x001F264A File Offset: 0x001F084A
		[DefaultValue(0)]
		[O_Oo00Oo000O0(3.1)]
		[MergableProperty(true)]
		[Category("外观")]
		[DisplayName("边框样式")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O0oo_0_.__0__..BorderStyle;
			}
			set
			{
				this.O0oo_0_.__0__..BorderStyle = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x001F2658 File Offset: 0x001F0858
		// (set) Token: 0x06004645 RID: 17989 RVA: 0x001F2665 File Offset: 0x001F0865
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		[DisplayName("边框颜色")]
		[O_Oo00Oo000O0(3.11)]
		public Color BorderColor
		{
			get
			{
				return this.O0oo_0_.__0__..BorderColor;
			}
			set
			{
				this.O0oo_0_.__0__..BorderColor = value;
				if (this.O0oo_0_.__0__..BorderStyle != BorderStyle.FixedSingle)
				{
					this.O0oo_0_.__0__..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x001F268D File Offset: 0x001F088D
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x001F269A File Offset: 0x001F089A
		[DefaultValue(1)]
		[MergableProperty(true)]
		[Category("外观")]
		[O_Oo00Oo000O0(0.1)]
		[DisplayName("文本位置")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.O0oo_0_.__0__..TextAlign;
			}
			set
			{
				this.O0oo_0_.__0__..TextAlign = value;
			}
		}

		// Token: 0x04001C7A RID: 7290
		private C1Label <<EMPTY_NAME>>;

		// Token: 0x04001C7B RID: 7291
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C7C RID: 7292
		private string <<EMPTY_NAME>>;
	}
}
