using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020002ED RID: 749
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class IMServerCollections : Dictionary<string, IMServer>, IEnumerable<IMServer>
	{
		// Token: 0x06002904 RID: 10500 RVA: 0x00127989 File Offset: 0x00125B89
		public IMServerCollections()
		{
			this.oO_0OO.0. = "jsn3DUSsXEPZuuflGGv9gzvJFXsmNjC4BjTrGYJ6t6bwNwcz2W9Mpg==";
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0012799C File Offset: 0x00125B9C
		public void Add(string Name)
		{
			if (base.Count > 0 && !o0OO__.OO0oO.o.())
			{
				MessageBox.Show(O00.DecryptText(this.oO_0OO.0., "my", "fox"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			IMServer value = new IMServer(Name);
			base.Add(Name, value);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x001279EC File Offset: 0x00125BEC
		public new void Remove(string Name)
		{
			if (base.ContainsKey(Name))
			{
				base.Remove(Name);
			}
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x001279FF File Offset: 0x00125BFF
		public bool Contains(string ServerName)
		{
			return base.ContainsKey(ServerName);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00127A08 File Offset: 0x00125C08
		public IEnumerator<IMServer> GetEnumerator1()
		{
			return (IEnumerator<IMServer>)base.Values.GetEnumerator();
		}

		// Token: 0x040010F2 RID: 4338
		private string <<EMPTY_NAME>>;
	}
}
