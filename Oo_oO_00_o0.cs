using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000058 RID: 88
	internal class Oo_oO_00_o0 : StringConverter
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x00008CA0 File Offset: 0x00006EA0
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00008CA3 File Offset: 0x00006EA3
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00008CA8 File Offset: 0x00006EA8
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ooo00oO))
			{
				list.Add("");
			}
			foreach (FontFamily fontFamily in FontFamily.Families)
			{
				list.Add(fontFamily.Name);
			}
			return new TypeConverter.StandardValuesCollection(list);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00008D08 File Offset: 0x00006F08
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2)
		{
			object result;
			if (A_2 == null || Operators.CompareString(A_2.ToString(), "默认", true) == 0)
			{
				result = "";
			}
			else
			{
				result = base.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2));
			}
			return result;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00008D44 File Offset: 0x00006F44
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (value == null || Operators.CompareString(value.ToString(), "", true) == 0)
			{
				result = "默认";
			}
			else
			{
				result = base.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}
			return result;
		}
	}
}
