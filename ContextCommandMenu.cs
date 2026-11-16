using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200047B RID: 1147
	[OoO0___o("ContextCommandMenu")]
	internal class ContextCommandMenu : ContextCommand
	{
		// Token: 0x06004E4B RID: 20043 RVA: 0x002377E3 File Offset: 0x002359E3
		public ContextCommandMenu(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x002377F4 File Offset: 0x002359F4
		// (set) Token: 0x06004E4D RID: 20045 RVA: 0x002377FB File Offset: 0x002359FB
		[O_Oo00Oo000O0(100.0)]
		[Category("属性")]
		[DisplayName("子菜单项目")]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06004E4E RID: 20046 RVA: 0x002377FD File Offset: 0x002359FD
		// (set) Token: 0x06004E4F RID: 20047 RVA: 0x00237805 File Offset: 0x00235A05
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("展开菜单的时候执行。")]
		[Category("事件")]
		[oO0oooo("1335")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(3.0)]
		public EventString Popup
		{
			get
			{
				return this.Oo_oo.O0O_0OO0.;
			}
			set
			{
				this.Oo_oo.O0O_0OO0. = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x0023780E File Offset: 0x00235A0E
		// (set) Token: 0x06004E51 RID: 20049 RVA: 0x00237816 File Offset: 0x00235A16
		[Description("关闭菜单的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1336")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString Closed
		{
			get
			{
				return this.O_o_.___oO0_O.;
			}
			set
			{
				this.O_o_.___oO0_O. = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x0023781F File Offset: 0x00235A1F
		// (set) Token: 0x06004E53 RID: 20051 RVA: 0x00237822 File Offset: 0x00235A22
		[Browsable(false)]
		public new EventString Click
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x04001FFB RID: 8187
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001FFC RID: 8188
		private EventString <<EMPTY_NAME>>;
	}
}
