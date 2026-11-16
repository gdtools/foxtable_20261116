using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005E RID: 94
	internal class o00 : StringConverter
	{
		// Token: 0x06000308 RID: 776 RVA: 0x000097D8 File Offset: 0x000079D8
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000097DB File Offset: 0x000079DB
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000097E0 File Offset: 0x000079E0
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.AddRange(OO_00oOO.Themes);
			list.Insert(0, "(default)");
			list.Insert(0, "(none)");
			return new TypeConverter.StandardValuesCollection(list);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000981C File Offset: 0x00007A1C
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

		// Token: 0x0600030C RID: 780 RVA: 0x00009878 File Offset: 0x00007A78
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
