using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200043A RID: 1082
	internal class o0_O_O0O__ : O_o_0o
	{
		// Token: 0x060048D2 RID: 18642 RVA: 0x001F57B0 File Offset: 0x001F39B0
		internal o0_O_O0O__(string A_0, C1DockingTabPage A_1, PropertyBase A_2)
		{
			this.Oo_._O0oOOOo. = A_1;
			this.Oo_._O0oOOOo. = A_2;
			this.Oo_._O0oOOOo. = A_0;
			PropertyInfo property = A_2.GetType().GetProperty(A_0);
			this.oo0_O0_000o.0o. = RuntimeHelpers.GetObjectValue(property.GetValue(A_2, null));
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x001F57F8 File Offset: 0x001F39F8
		internal void <<EMPTY_NAME>>()
		{
			C1DockingTab c1DockingTab = (C1DockingTab)this.Oo_._O0oOOOo..Holder.ChildControl;
			if (c1DockingTab.SelectedTab != this.Oo_._O0oOOOo.)
			{
				c1DockingTab.SelectedTab = this.Oo_._O0oOOOo.;
				Application.DoEvents();
			}
			this.Oo_._O0oOOOo..GetType().GetProperty(this.Oo_._O0oOOOo.).SetValue(this.Oo_._O0oOOOo., RuntimeHelpers.GetObjectValue(this.oo0_O0_000o.0o.), null);
			if (!this.Oo_._O0oOOOo..Holder.Selected)
			{
				this.Oo_._O0oOOOo..Holder.Selected = true;
			}
		}

		// Token: 0x04001D77 RID: 7543
		private PropertyBase <<EMPTY_NAME>>;

		// Token: 0x04001D78 RID: 7544
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001D79 RID: 7545
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D7A RID: 7546
		private object <<EMPTY_NAME>>;
	}
}
