using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001E4 RID: 484
	internal class OoOo0O
	{
		// Token: 0x06001834 RID: 6196 RVA: 0x000AC010 File Offset: 0x000AA210
		static OoOo0O()
		{
			char[] array = "modnaR.metsyS".ToCharArray();
			Array.Reverse(array);
			OoOo0O.OO_o.0o_O. = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetType(new string(array))));
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000AC048 File Offset: 0x000AA248
		internal static int <<EMPTY_NAME>>()
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., null, "Next", new object[0], null, null, null));
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000AC068 File Offset: 0x000AA268
		internal static int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			object[] array;
			bool[] array2;
			object value = NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., null, "Next", array = new object[]
			{
				A_0,
				A_1
			}, null, null, array2 = new bool[]
			{
				true,
				true
			});
			if (array2[0])
			{
				A_0 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			if (array2[1])
			{
				A_1 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			return Conversions.ToInteger(value);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000AC0FC File Offset: 0x000AA2FC
		internal static int <<EMPTY_NAME>>(int A_0)
		{
			object[] array;
			bool[] array2;
			object value = NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., null, "Next", array = new object[]
			{
				A_0
			}, null, null, array2 = new bool[]
			{
				true
			});
			if (array2[0])
			{
				A_0 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			return Conversions.ToInteger(value);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000AC160 File Offset: 0x000AA360
		internal static double <<EMPTY_NAME>>()
		{
			return Conversions.ToDouble(NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., null, "NextDouble", new object[0], null, null, null));
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000AC180 File Offset: 0x000AA380
		internal static string <<EMPTY_NAME>>(int A_0)
		{
			if (A_0 > 32)
			{
				A_0 = 32;
			}
			if (A_0 < 1)
			{
				A_0 = 1;
			}
			return Guid.NewGuid().ToString().Replace("-", "").Substring(0, A_0);
		}

		// Token: 0x040009AA RID: 2474
		private static object <<EMPTY_NAME>>;
	}
}
