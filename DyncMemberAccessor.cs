using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020001E3 RID: 483
	[ComVisible(true)]
	public class DyncMemberAccessor
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x000ABF91 File Offset: 0x000AA191
		public DyncMemberAccessor(Type A_0)
		{
			this.o.0_OoO_. = A_0;
		}

		// Token: 0x170004E3 RID: 1251
		public object this[string A_0]
		{
			get
			{
				object result;
				if (this.o.0_OoO_..IsEnum)
				{
					result = Enum.Parse(this.o.0_OoO_., A_0, true);
				}
				else
				{
					PropertyInfo property = this.o.0_OoO_..GetProperty(A_0, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
					if (property != null)
					{
						result = property.GetValue(null);
					}
					else
					{
						FieldInfo field = this.o.0_OoO_..GetField(A_0, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
						if (field != null)
						{
							result = field.GetValue(null);
						}
						else
						{
							result = null;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x040009A8 RID: 2472
		private readonly Type <<EMPTY_NAME>>;

		// Token: 0x040009A9 RID: 2473
		private const BindingFlags <<EMPTY_NAME>> = BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public;
	}
}
