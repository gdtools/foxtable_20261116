using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200047C RID: 1148
	[OoO0___o("ContextMenu")]
	internal class ContextMenu : RibbonBase
	{
		// Token: 0x06004E54 RID: 20052 RVA: 0x00237824 File Offset: 0x00235A24
		public ContextMenu(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x00237835 File Offset: 0x00235A35
		// (set) Token: 0x06004E56 RID: 20054 RVA: 0x0023783C File Offset: 0x00235A3C
		[O_Oo00Oo000O0(100.0)]
		[DisplayName("菜单项目")]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[Category("属性")]
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

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x0023783E File Offset: 0x00235A3E
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x00237846 File Offset: 0x00235A46
		[oO0oooo("1329")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("打开快捷菜单的时候执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
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

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x0023784F File Offset: 0x00235A4F
		// (set) Token: 0x06004E5A RID: 20058 RVA: 0x00237857 File Offset: 0x00235A57
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[oO0oooo("1330")]
		[Description("关闭快捷菜单的时候执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(3.0)]
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

		// Token: 0x04001FFD RID: 8189
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001FFE RID: 8190
		private EventString <<EMPTY_NAME>>;
	}
}
