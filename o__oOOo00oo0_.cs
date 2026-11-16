using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200004D RID: 77
	internal class o__oOOo00oo0_ : ColorConverter
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x000078EC File Offset: 0x00005AEC
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2, Type A_3)
		{
			object result;
			if ((Color)A_2 == Color.Transparent || (Color)A_2 == Color.Empty)
			{
				result = "默认";
			}
			else
			{
				result = base.ConvertTo(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3);
			}
			return result;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00007938 File Offset: 0x00005B38
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2)
		{
			object result;
			if (Operators.CompareString(A_2.ToString(), "默认", true) == 0)
			{
				result = Color.Transparent;
			}
			else
			{
				result = base.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2));
			}
			return result;
		}
	}
}
