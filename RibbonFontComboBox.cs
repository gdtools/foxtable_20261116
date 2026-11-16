using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000496 RID: 1174
	[OoO0___o("RibbonFontComboBox")]
	[oO0oooo("1124")]
	internal class RibbonFontComboBox : RibbonTextBox
	{
		// Token: 0x06004FAD RID: 20397 RVA: 0x00238D59 File Offset: 0x00236F59
		public RibbonFontComboBox(DataRow A_0) : base(A_0)
		{
			this.oO_.OO__OOo_o0. = 8;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x00238D71 File Offset: 0x00236F71
		// (set) Token: 0x06004FAF RID: 20399 RVA: 0x00238D79 File Offset: 0x00236F79
		[DisplayName("最大下拉项目数")]
		[O_Oo00Oo000O0(6.0)]
		[Category("属性")]
		[DefaultValue(8)]
		public int MaxDropDownItems
		{
			get
			{
				return this.oO_.OO__OOo_o0.;
			}
			set
			{
				this.oO_.OO__OOo_o0. = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x00238D82 File Offset: 0x00236F82
		// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x00238D8A File Offset: 0x00236F8A
		[O_Oo00Oo000O0(10.0)]
		[Description("显示下拉列表后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DropDown
		{
			get
			{
				return this.OO_._O0.;
			}
			set
			{
				this.OO_._O0. = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x00238D93 File Offset: 0x00236F93
		// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x00238D9B File Offset: 0x00236F9B
		[Category("事件")]
		[O_Oo00Oo000O0(11.0)]
		[Description("关闭下拉列表后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString DropDownClosed
		{
			get
			{
				return this.o_0O.Ooo.;
			}
			set
			{
				this.o_0O.Ooo. = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x00238DA4 File Offset: 0x00236FA4
		// (set) Token: 0x06004FB5 RID: 20405 RVA: 0x00238DAC File Offset: 0x00236FAC
		[Description("选择不同项目后执行。")]
		[O_Oo00Oo000O0(11.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.o._000O0.;
			}
			set
			{
				this.o._000O0. = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x00238DB8 File Offset: 0x00236FB8
		[Browsable(false)]
		public new int MaxLength
		{
			get
			{
				int result;
				return result;
			}
		}

		// Token: 0x04002094 RID: 8340
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002095 RID: 8341
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002096 RID: 8342
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002097 RID: 8343
		private int <<EMPTY_NAME>>;
	}
}
