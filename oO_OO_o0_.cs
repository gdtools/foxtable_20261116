using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020001D0 RID: 464
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class oO_OO_o0_ : Dictionary<string, UDPClient>, IEnumerable<UDPClient>
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x0009AD00 File Offset: 0x00098F00
		public oO_OO_o0_()
		{
			this.OO.000O. = "jsn3DUSsXEPyI0w1RKCIV/+CtcaS959KLMVZa/cPJ8fr5Y8WV8v+ZA==";
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0009AD14 File Offset: 0x00098F14
		public void Add(string Name)
		{
			if (!o0OO__.OO0oO.o.())
			{
				MessageBox.Show(O00.DecryptText(this.OO.000O., "my", "fox"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			UDPClient value = new UDPClient(Name);
			base.Add(Name, value);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0009AD5B File Offset: 0x00098F5B
		public new void Remove(string Name)
		{
			if (base.ContainsKey(Name))
			{
				base.Remove(Name);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0009AD6E File Offset: 0x00098F6E
		public bool Contains(string Name)
		{
			return base.ContainsKey(Name);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0009AD77 File Offset: 0x00098F77
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<UDPClient> GetEnumerator1()
		{
			return (IEnumerator<UDPClient>)base.Values.GetEnumerator();
		}

		// Token: 0x040008EE RID: 2286
		private string <<EMPTY_NAME>>;
	}
}
