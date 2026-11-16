using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200028C RID: 652
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossExpressionGroupCollections : List<CrossExpressionGroup>
	{
		// Token: 0x0600208F RID: 8335 RVA: 0x000E2DD0 File Offset: 0x000E0FD0
		public void Adddef(string Name, string Expression)
		{
			base.Add(new CrossExpressionGroup(Name, Expression, ""));
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000E2DE4 File Offset: 0x000E0FE4
		public void Adddef(string Name, string Expression, string Pattern)
		{
			base.Add(new CrossExpressionGroup(Name, Expression, Pattern));
		}
	}
}
