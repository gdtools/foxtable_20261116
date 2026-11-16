using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200020B RID: 523
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HttpFilleCollection : Dictionary<string, List<string>>
	{
		// Token: 0x060019AA RID: 6570 RVA: 0x000B7A08 File Offset: 0x000B5C08
		public void Add(string id, string FileName)
		{
			if (!base.ContainsKey(id))
			{
				base.Add(id, new List<string>());
			}
			base[id].Add(FileName);
		}
	}
}
