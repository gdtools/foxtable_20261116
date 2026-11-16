using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000421 RID: 1057
	internal class ProgressBarProperty : ControlPropertyBase
	{
		// Token: 0x06004736 RID: 18230 RVA: 0x001F364B File Offset: 0x001F184B
		public ProgressBarProperty(ControlHolder A_0) : base(A_0)
		{
			this.OOO._oOooO. = (ProgressBar)A_0.ChildControl;
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x001F3665 File Offset: 0x001F1865
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x001F366D File Offset: 0x001F186D
		[DisplayName("绑定到")]
		[DefaultValue("")]
		[Category("基本")]
		[MergableProperty(true)]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.1)]
		public string BindingField
		{
			get
			{
				return this.o0O0.O0_o.;
			}
			set
			{
				this.o0O0.O0_o. = value;
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x001F3676 File Offset: 0x001F1876
		// (set) Token: 0x0600473A RID: 18234 RVA: 0x001F3683 File Offset: 0x001F1883
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("当前值")]
		[DefaultValue(50)]
		[MergableProperty(true)]
		[Category("进度")]
		public int Value
		{
			get
			{
				return this.OOO._oOooO..Value;
			}
			set
			{
				this.OOO._oOooO..Value = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x001F3691 File Offset: 0x001F1891
		// (set) Token: 0x0600473C RID: 18236 RVA: 0x001F369E File Offset: 0x001F189E
		[MergableProperty(true)]
		[Category("进度")]
		[DisplayName("最大值")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(100)]
		public int Maximum
		{
			get
			{
				return this.OOO._oOooO..Maximum;
			}
			set
			{
				this.OOO._oOooO..Maximum = value;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x001F36AC File Offset: 0x001F18AC
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x001F36B9 File Offset: 0x001F18B9
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("最小值")]
		[Category("进度")]
		[DefaultValue(0)]
		public int Minimum
		{
			get
			{
				return this.OOO._oOooO..Minimum;
			}
			set
			{
				this.OOO._oOooO..Minimum = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x001F36C7 File Offset: 0x001F18C7
		// (set) Token: 0x06004740 RID: 18240 RVA: 0x001F36D4 File Offset: 0x001F18D4
		[O_Oo00Oo000O0(3.0)]
		[Category("进度")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[DisplayName("样式")]
		public ProgressBarStyle Style
		{
			get
			{
				return this.OOO._oOooO..Style;
			}
			set
			{
				this.OOO._oOooO..Style = value;
			}
		}

		// Token: 0x04001CC4 RID: 7364
		private ProgressBar <<EMPTY_NAME>>;

		// Token: 0x04001CC5 RID: 7365
		private string <<EMPTY_NAME>>;
	}
}
