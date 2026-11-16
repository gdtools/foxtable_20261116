using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005F RID: 95
	internal class oo__O__O_OoO : StringConverter
	{
		// Token: 0x0600030E RID: 782 RVA: 0x000098DB File Offset: 0x00007ADB
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000098DE File Offset: 0x00007ADE
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000098E4 File Offset: 0x00007AE4
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ooo00oO))
			{
				if (((o_0oooo_OO)context.Instance).Oo._o.() is FormMenuProperty)
				{
					list.Add("(none)");
				}
				else if (((o_0oooo_OO)context.Instance).Oo._o.() is FormProperty)
				{
					list.Add("(none)");
				}
				list.Add("(default)");
			}
			list.AddRange(OO_00oOO.Themes);
			return new TypeConverter.StandardValuesCollection(list);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00009970 File Offset: 0x00007B70
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2)
		{
			object result;
			if (A_2 != null && Operators.CompareString(A_2.ToString(), "默认", true) == 0)
			{
				result = "(default)";
			}
			else if (A_2 != null && Operators.CompareString(A_2.ToString(), "无", true) == 0)
			{
				result = "(none)";
			}
			else
			{
				result = base.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2));
			}
			return result;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000099CC File Offset: 0x00007BCC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (value != null && Operators.CompareString(value.ToString(), "(default)", true) == 0)
			{
				result = "默认";
			}
			else if (value != null && Operators.CompareString(value.ToString(), "(none)", true) == 0)
			{
				result = "无";
			}
			else
			{
				result = base.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
			return result;
		}
	}
}
