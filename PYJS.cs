using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000D1 RID: 209
	[ComVisible(true)]
	public class PYJS
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x0004CB28 File Offset: 0x0004AD28
		public string GetPY(params object[] args)
		{
			string result;
			switch (args.Length)
			{
			case 1:
				result = PY.GetPY(Conversions.ToString(args[0]));
				break;
			case 2:
				result = PY.GetPY(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
				break;
			case 3:
				result = PY.GetPY(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]), Conversions.ToInteger(args[2]));
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0004CB9C File Offset: 0x0004AD9C
		public string GetNamePY(params object[] args)
		{
			string result;
			switch (args.Length)
			{
			case 1:
				result = PY.GetNamePY(Conversions.ToString(args[0]));
				break;
			case 2:
				result = PY.GetNamePY(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
				break;
			case 3:
				result = PY.GetNamePY(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]), Conversions.ToInteger(args[2]));
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0004CC0E File Offset: 0x0004AE0E
		public bool IsHanzi(string @char)
		{
			return PY.IsHanzi(@char[0]);
		}
	}
}
