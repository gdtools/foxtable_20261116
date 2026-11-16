using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200014C RID: 332
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class O0oO_0 : Form
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x0007D99D File Offset: 0x0007BB9D
		public O0oO_0()
		{
			base.KeyDown += this.OoO0O0.0O_oo.;
			base.KeyPreview = true;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0007D9C0 File Offset: 0x0007BBC0
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.Control && A_1.Shift && A_1.KeyCode == Keys.F6)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
				try
				{
					Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator = OO_00oOO.IMClients.Values.GetEnumerator();
					if (enumerator.MoveNext())
					{
						enumerator.Current.o0.0o_00.(this);
					}
				}
				finally
				{
					Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}
	}
}
