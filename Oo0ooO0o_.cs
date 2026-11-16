using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000059 RID: 89
	internal class Oo0ooO0o_ : Int32Converter
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00008D89 File Offset: 0x00006F89
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00008D8C File Offset: 0x00006F8C
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00008D90 File Offset: 0x00006F90
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			int[] values;
			if (((o_0oooo_OO)context.Instance).Oo._o.() is ooo00oO)
			{
				values = new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13
				};
			}
			else
			{
				values = new int[]
				{
					0,
					8,
					9,
					10,
					11,
					12,
					13
				};
			}
			return new TypeConverter.StandardValuesCollection(values);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value != null & Operators.CompareString(value.ToString(), "默认", true) == 0)
			{
				result = 0;
			}
			else
			{
				result = base.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}
			return result;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008E24 File Offset: 0x00007024
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (value == null || Operators.CompareString(value.ToString(), "0", true) == 0)
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
