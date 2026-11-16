using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000284 RID: 644
	internal class O0_O_0__ : ListBox
	{
		// Token: 0x06002054 RID: 8276 RVA: 0x000E0A5C File Offset: 0x000DEC5C
		protected override bool IsInputKey(Keys keyData)
		{
			return keyData == Keys.Tab || base.IsInputKey(keyData);
		}
	}
}
