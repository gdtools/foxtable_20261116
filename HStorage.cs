using System;
using Newtonsoft.Json;

namespace Foxtable
{
	// Token: 0x02000100 RID: 256
	public class HStorage
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x000742FE File Offset: 0x000724FE
		internal HStorage(WebViewer A_0, string A_1)
		{
			this.O0oO.o_OOoO_. = A_0;
			this.O0oO.o_OOoO_. = A_1;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00074314 File Offset: 0x00072514
		public object length
		{
			get
			{
				string script = string.Format("{0}.length", this.O0oO.o_OOoO_.);
				return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00074340 File Offset: 0x00072540
		public object key(int n)
		{
			string script = string.Format("{0}.key({1})", this.O0oO.o_OOoO_., n);
			return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00074370 File Offset: 0x00072570
		public object getItem(string key)
		{
			string script = string.Format("{0}.getItem({1})", this.O0oO.o_OOoO_., JsonConvert.ToString(key));
			return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000743A0 File Offset: 0x000725A0
		public object setItem(string key, string value)
		{
			string script = string.Format("{0}.setItem({1},{2})", this.O0oO.o_OOoO_., JsonConvert.ToString(key), JsonConvert.ToString(value));
			return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000743D8 File Offset: 0x000725D8
		public object removeItem(string key)
		{
			string script = string.Format("{0}.removeItem({1})", this.O0oO.o_OOoO_., JsonConvert.ToString(key));
			return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00074408 File Offset: 0x00072608
		public object clear()
		{
			string script = string.Format("{0}.clear()", this.O0oO.o_OOoO_.);
			return this.O0oO.o_OOoO_..ExecuteScriptAsync(script);
		}

		// Token: 0x0400058B RID: 1419
		internal WebViewer <<EMPTY_NAME>>;

		// Token: 0x0400058C RID: 1420
		internal string <<EMPTY_NAME>>;
	}
}
