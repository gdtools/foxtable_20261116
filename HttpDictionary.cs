using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001EA RID: 490
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HttpDictionary
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x000AC8D2 File Offset: 0x000AAAD2
		public HttpDictionary()
		{
			this.o0O_.0o0_oO. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x170004EE RID: 1262
		public string this[string key]
		{
			get
			{
				string result;
				if (this.o0O_.0o0_oO..ContainsKey(key))
				{
					result = this.o0O_.0o0_oO.[key];
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.o0O_.0o0_oO..ContainsKey(key))
				{
					this.o0O_.0o0_oO.[key] = value;
				}
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000AC936 File Offset: 0x000AAB36
		public void Add(string key, string value)
		{
			this.o0O_.0o0_oO..Add(key, value);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x000AC945 File Offset: 0x000AAB45
		public void Clear()
		{
			this.o0O_.0o0_oO..Clear();
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000AC952 File Offset: 0x000AAB52
		public bool ContainsKey(string key)
		{
			return this.o0O_.0o0_oO..ContainsKey(key);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000AC960 File Offset: 0x000AAB60
		public bool ContainsValue(string value)
		{
			bool result;
			try
			{
				foreach (string key in this.o0O_.0o0_oO..Keys)
				{
					if (Operators.CompareString(this.o0O_.0o0_oO.[key], value, true) == 0)
					{
						result = true;
						break;
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return result;
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x000AC9CC File Offset: 0x000AABCC
		public Dictionary<string, string>.KeyCollection Keys
		{
			get
			{
				return this.o0O_.0o0_oO..Keys;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x000AC9D9 File Offset: 0x000AABD9
		public Dictionary<string, string>.ValueCollection Values
		{
			get
			{
				return this.o0O_.0o0_oO..Values;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x000AC9E6 File Offset: 0x000AABE6
		public int Count
		{
			get
			{
				return this.o0O_.0o0_oO..Count;
			}
		}

		// Token: 0x040009CC RID: 2508
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
