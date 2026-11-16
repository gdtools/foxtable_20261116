using System;
using System.ComponentModel;
using System.Drawing;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200014E RID: 334
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O_OOO : C1NavBar
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x0007DA50 File Offset: 0x0007BC50
		internal O_OOO()
		{
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.CollapseDirection = CollapseDirectionEnum.ToRight;
			base.AllowCollapse = false;
			base.CloseButton = C1NavBarCloseButtonEnum.None;
			base.ShowOptionsMenu = false;
			base.ButtonFont = new Font("宋体", 9f);
			base.PanelHeaderFont = new Font("宋体", 9f);
			base.StackButtonCount = 5;
		}
	}
}
