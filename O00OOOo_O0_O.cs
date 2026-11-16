using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000039 RID: 57
	[StandardModule]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class O00OOOo_O0_O
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x000051C1 File Offset: 0x000033C1
		internal static bool <<EMPTY_NAME>>(PropertyInfo A_0)
		{
			return Attribute.IsDefined(A_0, typeof(O0O0oOO00_0OO));
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000051D3 File Offset: 0x000033D3
		internal static bool <<EMPTY_NAME>>(PropertyDescriptor A_0)
		{
			return A_0.Attributes[typeof(O0O0oOO00_0OO)] != null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000051ED File Offset: 0x000033ED
		internal static bool <<EMPTY_NAME>>(PropertyDescriptor A_0)
		{
			return A_0.Attributes[typeof(o__o)] != null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00005207 File Offset: 0x00003407
		internal static bool <<EMPTY_NAME>>(PropertyInfo A_0)
		{
			return Attribute.IsDefined(A_0, typeof(oO0oo));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00005219 File Offset: 0x00003419
		internal static bool <<EMPTY_NAME>>(PropertyInfo A_0)
		{
			return Attribute.IsDefined(A_0, typeof(OooO0));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000522C File Offset: 0x0000342C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = 1112156898 + A_1;
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_47;
			}
			IL_14:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_47:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_14;
		}
	}
}
