using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000049 RID: 73
	internal class o0O : EnumConverter
	{
		// Token: 0x060002BA RID: 698 RVA: 0x00006419 File Offset: 0x00004619
		public o0O() : base(typeof(BooleanEnum))
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000642C File Offset: 0x0000462C
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2)
		{
			object result;
			if (Operators.CompareString(A_2.ToString(), "默认", true) == 0)
			{
				result = BooleanEnum.Default;
			}
			else
			{
				result = base.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2));
			}
			return result;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00006468 File Offset: 0x00004668
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2, Type A_3)
		{
			object result;
			if (Conversions.ToInteger(A_2) == 0)
			{
				result = "默认";
			}
			else
			{
				result = base.ConvertTo(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3);
			}
			return result;
		}
	}
}
