using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020001E0 RID: 480
	[ComVisible(true)]
	[DefaultMember("Item")]
	public class OO___O_oOOO
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x000A9561 File Offset: 0x000A7761
		public OO___O_oOOO(Assembly A_0, string A_1)
		{
			this.ooO_0oo.oOo0o. = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
			this.ooO_0oo.oOo0o. = A_0;
			this.ooO_0oo.oOo0o. = A_1;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000A9588 File Offset: 0x000A7788
		private Type <<EMPTY_NAME>>(string A_0)
		{
			Type result;
			if (this.ooO_0oo.oOo0o..ContainsKey(A_0))
			{
				result = this.ooO_0oo.oOo0o.[A_0];
			}
			else
			{
				A_0.ToLower();
				Type type = this.ooO_0oo.oOo0o..GetType(this.ooO_0oo.oOo0o. + "." + A_0, false, true);
				if (type != null)
				{
					this.ooO_0oo.oOo0o..Add(A_0, type);
					result = type;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000A95F4 File Offset: 0x000A77F4
		public object <<EMPTY_NAME>>(string A_0)
		{
			Type type = this.O.0o_0_o.(A_0);
			object result;
			if (type != null)
			{
				if (type.IsClass || (type.IsValueType && !type.IsEnum && !type.IsPrimitive))
				{
					try
					{
						return Activator.CreateInstance(type);
					}
					catch (Exception ex)
					{
						return null;
					}
				}
				result = new DyncMemberAccessor(type);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000A9664 File Offset: 0x000A7864
		public IEnumerator <<EMPTY_NAME>>()
		{
			return Enumerable.Empty<object>().GetEnumerator();
		}

		// Token: 0x0400099A RID: 2458
		private string <<EMPTY_NAME>>;

		// Token: 0x0400099B RID: 2459
		private readonly Assembly <<EMPTY_NAME>>;

		// Token: 0x0400099C RID: 2460
		private readonly Dictionary<string, Type> <<EMPTY_NAME>>;
	}
}
