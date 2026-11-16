using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000B5 RID: 181
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oooOo_0oo : Dictionary<string, object>
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x000397E2 File Offset: 0x000379E2
		public oooOo_0oo()
		{
			this.oO_0o_.oOO0. = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			this.o0O___o_o_0o.o. = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0003980A File Offset: 0x00037A0A
		public new void Clear()
		{
			base.Clear();
			this.oO_0o_.oOO0..Clear();
			this.o0O___o_o_0o.o..Clear();
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00039828 File Offset: 0x00037A28
		public new void Remove(string key)
		{
			base.Remove(key);
			this.oO_0o_.oOO0..Remove(key);
			this.o0O___o_o_0o.o..Remove(key);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0003984C File Offset: 0x00037A4C
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			return this.oO_0o_.oOO0..ContainsKey(A_0);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0003985A File Offset: 0x00037A5A
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			return this.o0O___o_o_0o.o..ContainsKey(A_0);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00039868 File Offset: 0x00037A68
		public void Add(string Key, object value, bool Output, int Size = 32)
		{
			if (value == null)
			{
				value = DBNull.Value;
			}
			base.Add(Key, RuntimeHelpers.GetObjectValue(value));
			if (Output)
			{
				this.oO_0o_.oOO0..Add(Key, Size);
				return;
			}
			this.o0O___o_o_0o.o..Add(Key, Size);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000398A1 File Offset: 0x00037AA1
		public void <<EMPTY_NAME>>(string A_0, object A_1)
		{
			base.Add(A_0, RuntimeHelpers.GetObjectValue(A_1));
		}

		// Token: 0x04000247 RID: 583
		internal Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x04000248 RID: 584
		internal Dictionary<string, int> <<EMPTY_NAME>>;
	}
}
