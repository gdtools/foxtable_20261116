using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D5 RID: 469
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class IMClientCollections : Dictionary<string, IMClient>, IEnumerable<IMClient>
	{
		// Token: 0x06001667 RID: 5735 RVA: 0x000A0744 File Offset: 0x0009E944
		public IMClientCollections()
		{
			this.O00.O0. = "jsn3DUSsXEPZuuflGGv9gzvJFXsmNjC4JEPCOTHL/1hyPIJjPJ1BaA==";
			this.O00.O0. = RuntimeHelpers.GetObjectValue(new object());
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000A0768 File Offset: 0x0009E968
		internal void Add(string Name)
		{
			IMClient value = new IMClient(Name);
			base.Add(Name, value);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000A0784 File Offset: 0x0009E984
		internal new void Remove(string Name)
		{
			if (base.ContainsKey(Name))
			{
				base.Remove(Name);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000A0797 File Offset: 0x0009E997
		public bool Contains(string ClientName)
		{
			return base.ContainsKey(ClientName);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000A07A0 File Offset: 0x0009E9A0
		public IEnumerator<IMClient> GetEnumerator1()
		{
			return (IEnumerator<IMClient>)base.Values.GetEnumerator();
		}

		// Token: 0x04000903 RID: 2307
		private string <<EMPTY_NAME>>;

		// Token: 0x04000904 RID: 2308
		internal object <<EMPTY_NAME>>;
	}
}
