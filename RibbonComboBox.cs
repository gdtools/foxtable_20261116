using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000489 RID: 1161
	[oO0oooo("1114")]
	[OoO0___o("RibbonComboBox")]
	internal class RibbonComboBox : RibbonTextBox
	{
		// Token: 0x06004F01 RID: 20225 RVA: 0x002385E8 File Offset: 0x002367E8
		public RibbonComboBox(DataRow A_0) : base(A_0)
		{
			this.O_o0oO.O00o. = 12;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x00238601 File Offset: 0x00236801
		// (set) Token: 0x06004F03 RID: 20227 RVA: 0x00238609 File Offset: 0x00236809
		[DisplayName("最大下拉项目数")]
		[DefaultValue(12)]
		[O_Oo00Oo000O0(6.0)]
		[Category("属性")]
		public int MaxDropDownItems
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
			set
			{
				this.O_o0oO.O00o. = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x00238612 File Offset: 0x00236812
		// (set) Token: 0x06004F05 RID: 20229 RVA: 0x00238619 File Offset: 0x00236819
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[Category("属性")]
		[DisplayName("列表项目")]
		[O_Oo00Oo000O0(100.0)]
		public Hashtable Items
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x0023861B File Offset: 0x0023681B
		// (set) Token: 0x06004F07 RID: 20231 RVA: 0x00238623 File Offset: 0x00236823
		[Category("事件")]
		[O_Oo00Oo000O0(10.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("显示下拉列表后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString DropDown
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
			set
			{
				this.O_o0oO.O00o. = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x0023862C File Offset: 0x0023682C
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x00238634 File Offset: 0x00236834
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(11.0)]
		[Description("关闭下拉列表后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DropDownClosed
		{
			get
			{
				return this.OOO_0.Oooo_0.;
			}
			set
			{
				this.OOO_0.Oooo_0. = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x0023863D File Offset: 0x0023683D
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00238645 File Offset: 0x00236845
		[Description("选择不同项目后执行。")]
		[O_Oo00Oo000O0(11.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.o.Ooo0O_0O.;
			}
			set
			{
				this.o.Ooo0O_0O. = value;
			}
		}

		// Token: 0x0400204F RID: 8271
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002050 RID: 8272
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002051 RID: 8273
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002052 RID: 8274
		private int <<EMPTY_NAME>>;
	}
}
