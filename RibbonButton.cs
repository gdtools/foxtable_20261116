using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Foxtable
{
	// Token: 0x02000483 RID: 1155
	[OoO0___o("RibbonButton")]
	[oO0oooo("1102")]
	internal class RibbonButton : RibbonItem
	{
		// Token: 0x06004ECD RID: 20173 RVA: 0x002383B0 File Offset: 0x002365B0
		public RibbonButton(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x002383C1 File Offset: 0x002365C1
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x002383DC File Offset: 0x002365DC
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("标题")]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.o0o__0.OO0O. == null)
				{
					this.o0o__0.OO0O. = "";
				}
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x002383E5 File Offset: 0x002365E5
		// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x002383ED File Offset: 0x002365ED
		[Category("属性")]
		[O_Oo00Oo000O0(1.3)]
		[DisplayName("快捷键")]
		[DefaultValue(0)]
		[Editor(typeof(ShortcutKeysEditor), typeof(UITypeEditor))]
		public Keys ShortcutKeys
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x002383F6 File Offset: 0x002365F6
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x002383FE File Offset: 0x002365FE
		[O_Oo00Oo000O0(0.1)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击按钮后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString Click
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x00238407 File Offset: 0x00236607
		// (set) Token: 0x06004ED5 RID: 20181 RVA: 0x0023840F File Offset: 0x0023660F
		[Category("事件")]
		[O_Oo00Oo000O0(0.2)]
		[Description("双击按钮后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Browsable(false)]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClick
		{
			get
			{
				return this.ooo._0o.;
			}
			set
			{
				this.ooo._0o. = value;
			}
		}

		// Token: 0x0400203A RID: 8250
		private new string <<EMPTY_NAME>>;

		// Token: 0x0400203B RID: 8251
		private new Keys <<EMPTY_NAME>>;

		// Token: 0x0400203C RID: 8252
		private new EventString <<EMPTY_NAME>>;

		// Token: 0x0400203D RID: 8253
		private EventString <<EMPTY_NAME>>;
	}
}
