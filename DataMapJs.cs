using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200010C RID: 268
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class DataMapJs
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x00074B56 File Offset: 0x00072D56
		public DataMapJs()
		{
			this.oo._Oo0. = new ListDictionary();
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00074B69 File Offset: 0x00072D69
		public void Add(object Key, object Value)
		{
			this.oo._Oo0..Add(RuntimeHelpers.GetObjectValue(Key), RuntimeHelpers.GetObjectValue(Value));
		}

		// Token: 0x040005A0 RID: 1440
		internal ListDictionary <<EMPTY_NAME>>;
	}
}
