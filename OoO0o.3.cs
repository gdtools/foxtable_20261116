using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002D0 RID: 720
	[StandardModule]
	internal sealed class OoO0o
	{
		// Token: 0x06002792 RID: 10130
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(ref byte A_0, ref byte A_1, int A_2);

		// Token: 0x06002793 RID: 10131
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(ref byte A_0, string A_1, int A_2);

		// Token: 0x06002794 RID: 10132
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(StringBuilder A_0, ref byte A_1, int A_2);

		// Token: 0x06002795 RID: 10133
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetAttributes(int A_0, ref OoO0o.o_O000_Oo0oo A_1);

		// Token: 0x06002796 RID: 10134
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern int HidD_GetHidGuid(ref OoO0o.O0o_0o_00_Oo A_0);

		// Token: 0x06002797 RID: 10135
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetPreparsedData(int A_0, ref int A_1);

		// Token: 0x06002798 RID: 10136
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern int HidP_GetCaps(int A_0, ref OoO0o.o_OO000_0 A_1);

		// Token: 0x06002799 RID: 10137
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_FreePreparsedData(int A_0);

		// Token: 0x0600279A RID: 10138
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_SetFeature(int A_0, ref byte A_1, int A_2);

		// Token: 0x0600279B RID: 10139
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetFeature(int A_0, ref byte A_1, int A_2);

		// Token: 0x0600279C RID: 10140
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern int SetupDiGetClassDevsA(ref OoO0o.O0o_0o_00_Oo A_0, int A_1, int A_2, int A_3);

		// Token: 0x0600279D RID: 10141
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiDestroyDeviceInfoList(int A_0);

		// Token: 0x0600279E RID: 10142
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiGetDeviceInterfaceDetailA(int A_0, ref OoO0o.O_0O00__o0O A_1, ref OoO0o.O0__0o A_2, int A_3, ref int A_4, int A_5);

		// Token: 0x0600279F RID: 10143
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiEnumDeviceInterfaces(int A_0, int A_1, ref OoO0o.O0o_0o_00_Oo A_2, int A_3, ref OoO0o.O_0O00__o0O A_4);

		// Token: 0x060027A0 RID: 10144
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "CreateFileA")]
		private static extern int <<EMPTY_NAME>>(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6);

		// Token: 0x060027A1 RID: 10145
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int GetLastError();

		// Token: 0x060027A2 RID: 10146
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "lstrcpyA")]
		private static extern int <<EMPTY_NAME>>(string A_0, ref byte A_1);

		// Token: 0x060027A3 RID: 10147
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "CreateSemaphoreA")]
		private static extern int <<EMPTY_NAME>>(int A_0, int A_1, int A_2, string A_3);

		// Token: 0x060027A4 RID: 10148
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int WaitForSingleObject(int A_0, int A_1);

		// Token: 0x060027A5 RID: 10149
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int ReleaseSemaphore(int A_0, int A_1, ref int A_2);

		// Token: 0x060027A6 RID: 10150
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		public static extern int lstrlenA(string A_0);

		// Token: 0x060027A7 RID: 10151
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		public static extern void <<EMPTY_NAME>>(ref byte A_0, ref int A_1, int A_2);

		// Token: 0x060027A8 RID: 10152
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		public static extern void <<EMPTY_NAME>>(ref int A_0, ref byte A_1, int A_2);

		// Token: 0x060027A9 RID: 10153
		[DllImport("kernel32.dll")]
		internal static extern int CreateFile(string A_0, uint A_1, int A_2, int A_3, int A_4, int A_5, int A_6);

		// Token: 0x060027AA RID: 10154
		[DllImport("kernel32.dll")]
		internal static extern int CloseHandle(int A_0);

		// Token: 0x060027AB RID: 10155
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool ReadFile(int A_0, byte[] A_1, uint A_2, ref int A_3, uint A_4);

		// Token: 0x060027AC RID: 10156
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool WriteFile(int A_0, byte[] A_1, uint A_2, ref int A_3, uint A_4);

		// Token: 0x060027AD RID: 10157
		[DllImport("kernel32.dll")]
		internal static extern int WaitNamedPipe(string A_0, int A_1);

		// Token: 0x060027AE RID: 10158
		[DllImport("user32.dll")]
		internal static extern IntPtr FindWindow(string A_0, string A_1);

		// Token: 0x060027AF RID: 10159
		[DllImport("user32.dll")]
		internal static extern int GetWindowText(IntPtr A_0, StringBuilder A_1, int A_2);

		// Token: 0x060027B0 RID: 10160
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		internal static extern int ShowWindow(IntPtr A_0, int A_1);

		// Token: 0x060027B1 RID: 10161
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		internal static extern int CloseWindow(IntPtr A_0);

		// Token: 0x060027B2 RID: 10162
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		internal static extern int DestroyWindow(IntPtr A_0);

		// Token: 0x060027B3 RID: 10163
		[DllImport("Foxtable.core.dll", CharSet = CharSet.Ansi, SetLastError = true)]
		internal static extern bool LoadRuntime();

		// Token: 0x060027B4 RID: 10164 RVA: 0x0011F22C File Offset: 0x0011D42C
		private static int <<EMPTY_NAME>>(string A_0)
		{
			A_0 = Strings.UCase(A_0);
			string str = "0123456789ABCDEF";
			int num = 1;
			int num2 = 0;
			for (int i = A_0.Length; i >= 1; i += -1)
			{
				string left = Strings.Mid(A_0, i, 1);
				int num3 = 0;
				int num4 = 1;
				do
				{
					if (Operators.CompareString(left, Strings.Mid(str, num4, 1), true) == 0)
					{
						num3 = num4 - 1;
					}
					num4++;
				}
				while (num4 <= 16);
				num2 += num3 * num;
				num *= 16;
			}
			return num2;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0011F2A8 File Offset: 0x0011D4A8
		private static long <<EMPTY_NAME>>(long A_0, long A_1)
		{
			long num = A_0 & -2147483648L;
			long num2 = A_1 & -2147483648L;
			long num3 = A_0 & 1073741824L;
			long num4 = A_1 & 1073741824L;
			long num5 = (A_0 & 1073741823L) + (A_1 & 1073741823L);
			if ((num3 & num4) != 0L)
			{
				num5 = (num5 ^ -2147483648L ^ num ^ num2);
			}
			else if ((num3 | num4) != 0L)
			{
				if ((num5 & 1073741824L) != 0L)
				{
					num5 = (num5 ^ -1073741824L ^ num ^ num2);
				}
				else
				{
					num5 = (num5 ^ 1073741824L ^ num ^ num2);
				}
			}
			else
			{
				num5 = (num5 ^ num ^ num2);
			}
			return num5;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x0011F354 File Offset: 0x0011D554
		private static long <<EMPTY_NAME>>(long A_0, long A_1)
		{
			long num = A_0 & -2147483648L;
			long num2 = A_1 & -2147483648L;
			double num3 = (double)(A_0 & 2147483647L);
			double num4 = (double)(A_1 & 2147483647L);
			double num5;
			if (num != 0L)
			{
				if (num2 != 0L)
				{
					num5 = num3 - num4;
				}
				else
				{
					num3 += 2147483648.0;
					num5 = num3 - num4;
				}
			}
			else if (num2 != 0L)
			{
				num4 = (double)A_1;
				num5 = num3 - num4;
			}
			else
			{
				num5 = num3 - num4;
			}
			long result;
			if (num5 < 0.0)
			{
				result = (((long)Math.Round(2147483648.0 + num5) | -2147483648L) & -1L);
			}
			else if (num5 > 2147483647.0)
			{
				result = (((long)Math.Round(num5 - 2147483648.0) | -2147483648L) & -1L);
			}
			else
			{
				result = ((long)Math.Round(num5) & -1L);
			}
			return result;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x0011F430 File Offset: 0x0011D630
		private static long <<EMPTY_NAME>>(long A_0, int A_1)
		{
			A_1 %= 32;
			long num = A_0;
			long result;
			if (A_1 == 0)
			{
				result = num;
			}
			else
			{
				int num2 = A_1;
				for (int i = 1; i <= num2; i++)
				{
					long num3 = num & 1073741824L;
					num = (num & 1073741823L) * 2L;
					if ((num3 & 1073741824L) != 0L)
					{
						num |= -2147483648L;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x0011F488 File Offset: 0x0011D688
		private static long <<EMPTY_NAME>>(long A_0, int A_1)
		{
			long num = A_0;
			A_1 %= 32;
			long result;
			if (A_1 == 0)
			{
				result = num;
			}
			else
			{
				int num2 = A_1;
				for (int i = 1; i <= num2; i++)
				{
					long num3 = num & -2147483648L;
					num = (num & 2147483647L) / 2L;
					if (num3 != 0L)
					{
						num |= 1073741824L;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0011F4D8 File Offset: 0x0011D6D8
		private static byte <<EMPTY_NAME>>(byte A_0)
		{
			byte b = (byte)(OoO0o.O0o0Ooo0.oO. & 1L);
			byte b2 = (A_0 & 128) / 128;
			byte result = (A_0 & 127) * 2 | b;
			OoO0o.O0o0Ooo0.oO. = (long)((ulong)b2);
			return result;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x0011F514 File Offset: 0x0011D714
		private static byte <<EMPTY_NAME>>(byte A_0)
		{
			byte b = (byte)(OoO0o.O0o0Ooo0.oO. & 128L);
			byte b2 = (A_0 & 1) * 128;
			byte result = A_0 / 2 | b;
			OoO0o.O0o0Ooo0.oO. = (long)((ulong)b2);
			return result;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0011F54C File Offset: 0x0011D74C
		public static int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			int result = A_0;
			byte[] array = new byte[4];
			OoO0o.Oo___0.O_o.(ref array[0], ref result, 4);
			for (int i = 1; i <= A_1; i++)
			{
				OoO0o.O0o0Ooo0.oO. = 0L;
				OoO0o.o00_.0_O.(array[3]);
				int num = 0;
				do
				{
					array[num] = OoO0o.o00_.0_O.(array[num]);
					num++;
				}
				while (num <= 3);
			}
			OoO0o.Oo___0.O_o.(ref result, ref array[0], 4);
			return result;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0011F5C0 File Offset: 0x0011D7C0
		public static int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			int result = A_0;
			byte[] array = new byte[4];
			OoO0o.Oo___0.O_o.(ref array[0], ref result, 4);
			for (int i = 1; i <= A_1; i++)
			{
				OoO0o.O0o0Ooo0.oO. = 0L;
				OoO0o.o0O.Oooo_.(array[0]);
				int num = 3;
				do
				{
					array[num] = OoO0o.o0O.Oooo_.(array[num]);
					num += -1;
				}
				while (num >= 0);
			}
			OoO0o.Oo___0.O_o.(ref result, ref array[0], 4);
			return result;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0011F634 File Offset: 0x0011D834
		private static void <<EMPTY_NAME>>(long[] A_0, long[] A_1)
		{
			new long[2];
			long num = A_0[0];
			long num2 = A_0[1];
			long a_ = A_1[0];
			long a_2 = A_1[1];
			long a_3 = A_1[2];
			long a_4 = A_1[3];
			int num3 = 32;
			for (int i = 1; i <= num3; i++)
			{
				long num4 = OoO0o.o0O.Oo.(num4, -1640531527L);
				long num5 = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num2, 4), a_);
				long num6 = OoO0o.o0O.Oo.(num2, num4);
				long num7 = OoO0o.o0O.Oooo_.(num2, 5);
				num7 = OoO0o.o0O.Oo.(num7, a_2);
				long num8 = num5 ^ num6;
				num8 ^= num7;
				num = OoO0o.o0O.Oo.(num, num8);
				long num9 = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num, 4), a_3);
				num6 = OoO0o.o0O.Oo.(num, num4);
				num7 = OoO0o.o0O.Oooo_.(num, 5);
				num7 = OoO0o.o0O.Oo.(num7, a_4);
				num8 = (num9 ^ num6 ^ num7);
				num2 = OoO0o.o0O.Oo.(num2, num8);
			}
			A_0[0] = num;
			A_0[1] = num2;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0011F710 File Offset: 0x0011D910
		private static void <<EMPTY_NAME>>(long[] A_0, long[] A_1)
		{
			new long[2];
			long num = A_0[0];
			long num2 = A_0[1];
			long a_ = A_1[0];
			long a_2 = A_1[1];
			long a_3 = A_1[2];
			long a_4 = A_1[3];
			int num3 = 32;
			long num4 = OoO0o.OoO0.O0_0.(-1640531527L, 5);
			int num5 = num3;
			for (int i = 1; i <= num5; i++)
			{
				long num6 = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num, 4), a_3);
				long num7 = OoO0o.o0O.Oo.(num, num4);
				long num8 = OoO0o.o0O.Oooo_.(num, 5);
				num8 = OoO0o.o0O.Oo.(num8, a_4);
				long a_5 = num6 ^ num7 ^ num8;
				num2 = OoO0o.oo_o_oo._0O.(num2, a_5);
				long num9 = OoO0o.o0O.Oo.(OoO0o.OoO0.O0_0.(num2, 4), a_);
				num7 = OoO0o.o0O.Oo.(num2, num4);
				num8 = OoO0o.o0O.Oooo_.(num2, 5);
				num8 = OoO0o.o0O.Oo.(num8, a_2);
				a_5 = (num9 ^ num7 ^ num8);
				num = OoO0o.oo_o_oo._0O.(num, a_5);
				num4 = OoO0o.oo_o_oo._0O.(num4, -1640531527L);
			}
			A_0[0] = num;
			A_0[1] = num2;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x0011F7F8 File Offset: 0x0011D9F8
		private static void <<EMPTY_NAME>>(long[] A_0, byte[] A_1)
		{
			A_0[0] = 0L;
			A_0[1] = 0L;
			int num = 0;
			do
			{
				A_0[0] = ((long)OoO0o.OOo0o.00000o.((int)A_1[num], num * 8) | A_0[0]);
				A_0[1] = ((long)OoO0o.OOo0o.00000o.((int)A_1[num + 4], num * 8) | A_0[1]);
				num++;
			}
			while (num <= 3);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0011F844 File Offset: 0x0011DA44
		private static void <<EMPTY_NAME>>(long[] A_0, byte[] A_1)
		{
			int num = 0;
			do
			{
				A_1[num] = (byte)(OoO0o.O_O0O_0.OO0_.((int)A_0[0], num * 8) & 255);
				A_1[num + 4] = (byte)(OoO0o.O_O0O_0.OO0_.((int)A_0[1], num * 8) & 255);
				num++;
			}
			while (num <= 3);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0011F88C File Offset: 0x0011DA8C
		public static string <<EMPTY_NAME>>(string A_0, string A_1)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			int num = OoO0o.lstrlenA(A_0) + 1;
			int num2;
			if (num < 8)
			{
				num2 = 8;
			}
			else
			{
				num2 = num;
			}
			byte[] array3 = new byte[num2 + 1];
			byte[] array4 = new byte[num2 + 1];
			OoO0o.Oo___0.O_o.(ref array3[0], A_0, num);
			array3.CopyTo(array4, 0);
			int num3 = num2 - 8;
			for (int i = 0; i <= num3; i += 8)
			{
				int num4 = 0;
				do
				{
					array[num4] = array3[num4 + i];
					num4++;
				}
				while (num4 <= 7);
				OoO0o.oOO.0O_0oO00_o.(array, array2, A_1);
				num4 = 0;
				do
				{
					array4[num4 + i] = array2[num4];
					num4++;
				}
				while (num4 <= 7);
			}
			string text = "";
			int num5 = num2 - 1;
			for (int i = 0; i <= num5; i++)
			{
				text += array4[i].ToString("X2");
			}
			return text;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0011F980 File Offset: 0x0011DB80
		private static void <<EMPTY_NAME>>(string A_0, long[] A_1)
		{
			long[] array = new long[17];
			int num = Strings.Len(A_0);
			int num2 = 0;
			int num3 = num;
			int i;
			for (i = 1; i <= num3; i += 2)
			{
				string a_ = Strings.Mid(A_0, i, 2);
				array[num2] = (long)OoO0o.O_O.oOO0_.(a_);
				num2++;
			}
			i = 0;
			do
			{
				A_1[i] = 0L;
				i++;
			}
			while (i <= 3);
			i = 0;
			do
			{
				A_1[0] = ((long)OoO0o.OOo0o.00000o.((int)array[i], i * 8) | A_1[0]);
				A_1[1] = ((long)OoO0o.OOo0o.00000o.((int)array[i + 4], i * 8) | A_1[1]);
				A_1[2] = ((long)OoO0o.OOo0o.00000o.((int)array[i + 4 + 4], i * 8) | A_1[2]);
				A_1[3] = ((long)OoO0o.OOo0o.00000o.((int)array[i + 4 + 4 + 4], i * 8) | A_1[3]);
				i++;
			}
			while (i <= 3);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x0011FA38 File Offset: 0x0011DC38
		public static void <<EMPTY_NAME>>(byte[] A_0, byte[] A_1, string A_2)
		{
			new byte[17];
			long[] a_ = new long[3];
			long[] a_2 = new long[5];
			OoO0o.o__._00.(A_2, a_2);
			OoO0o.o00._OOo.(a_, A_0);
			OoO0o.OO00__O.O0.(a_, a_2);
			OoO0o.o__._00.(a_, A_1);
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x0011FA78 File Offset: 0x0011DC78
		public static void <<EMPTY_NAME>>(byte[] A_0, byte[] A_1, string A_2)
		{
			new byte[17];
			long[] a_ = new long[3];
			long[] a_2 = new long[5];
			OoO0o.o__._00.(A_2, a_2);
			OoO0o.o00._OOo.(a_, A_0);
			OoO0o.OO.00_0.(a_, a_2);
			OoO0o.o__._00.(a_, A_1);
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0011FAB8 File Offset: 0x0011DCB8
		public static string <<EMPTY_NAME>>(string A_0, string A_1)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			int length = A_0.Length;
			if (length < 16)
			{
			}
			int num = (int)Math.Round((double)length / 2.0);
			byte[] array3 = new byte[num + 1];
			byte[] array4 = new byte[num + 1];
			int num2 = 0;
			int num3 = length;
			for (int i = 1; i <= num3; i += 2)
			{
				string a_ = A_0.Substring(i - 1, 2);
				array3[num2] = (byte)OoO0o.O_O.oOO0_.(a_);
				num2++;
			}
			array3.CopyTo(array4, 0);
			int num4 = num - 8;
			for (int i = 0; i <= num4; i += 8)
			{
				num2 = 0;
				do
				{
					array[num2] = array3[num2 + i];
					num2++;
				}
				while (num2 <= 7);
				OoO0o.o.0_0O.(array, array2, A_1);
				num2 = 0;
				do
				{
					array4[num2 + i] = array2[num2];
					num2++;
				}
				while (num2 <= 7);
			}
			StringBuilder stringBuilder = new StringBuilder("", num);
			OoO0o.Oo___0.O_o.(stringBuilder, ref array4[0], num);
			return stringBuilder.ToString();
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0011FBBC File Offset: 0x0011DDBC
		private static long <<EMPTY_NAME>>(string A_0, ref byte[] A_1)
		{
			int num = Strings.Len(A_0);
			if (num < 16)
			{
			}
			long num2 = (long)Math.Round((double)num / 2.0);
			A_1 = new byte[(int)num2 + 1];
			int num3 = 0;
			int num4 = num;
			for (int i = 1; i <= num4; i += 2)
			{
				string a_ = Strings.Mid(A_0, i, 2);
				A_1[num3] = (byte)OoO0o.O_O.oOO0_.(a_);
				num3++;
			}
			return num2;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0011FC20 File Offset: 0x0011DE20
		private static bool <<EMPTY_NAME>>(int A_0, ref byte[] A_1, short A_2)
		{
			byte[] array = new byte[513];
			int a_;
			bool result;
			if (OoO0o.HidD_GetPreparsedData(A_0, ref a_))
			{
				OoO0o.o_OO000_0 o_OO000_;
				if (OoO0o.HidP_GetCaps(a_, ref o_OO000_) == 0)
				{
					OoO0o.HidD_FreePreparsedData(a_);
				}
				else
				{
					bool flag = true;
					array[0] = 1;
					bool flag2 = OoO0o.HidD_GetFeature(A_0, ref array[0], (int)o_OO000_.FeatureReportByteLength);
					if (flag2)
					{
						short num = A_2 - 1;
						for (short num2 = 0; num2 <= num; num2 += 1)
						{
							A_1[(int)num2] = array[(int)num2];
						}
					}
					flag = (flag && flag2);
					OoO0o.HidD_FreePreparsedData(a_);
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0011FCA4 File Offset: 0x0011DEA4
		private static bool <<EMPTY_NAME>>(int A_0, ref byte[] A_1, short A_2)
		{
			byte[] array = new byte[513];
			int a_;
			bool result;
			if (OoO0o.HidD_GetPreparsedData(A_0, ref a_))
			{
				OoO0o.o_OO000_0 o_OO000_;
				if (OoO0o.HidP_GetCaps(a_, ref o_OO000_) == 0)
				{
					OoO0o.HidD_FreePreparsedData(a_);
				}
				else
				{
					bool flag = true;
					array[0] = 2;
					short num = A_2 - 1;
					for (short num2 = 0; num2 <= num; num2 += 1)
					{
						array[(int)(num2 + 1)] = A_1[(int)(num2 + 1)];
					}
					bool flag2 = OoO0o.HidD_SetFeature(A_0, ref array[0], (int)o_OO000_.FeatureReportByteLength);
					flag = (flag && flag2);
					OoO0o.HidD_FreePreparsedData(a_);
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0011FD28 File Offset: 0x0011DF28
		private static bool <<EMPTY_NAME>>(short A_0, ref short A_1, ref StringBuilder A_2)
		{
			OoO0o.O0o_0o_00_Oo o0o_0o_00_Oo;
			OoO0o.HidD_GetHidGuid(ref o0o_0o_00_Oo);
			int num = OoO0o.SetupDiGetClassDevsA(ref o0o_0o_00_Oo, 0, 0, 18);
			bool result;
			if (num != -1)
			{
				OoO0o.O_0O00__o0O o_0O00__o0O;
				o_0O00__o0O.cbSize = Strings.Len(o_0O00__o0O);
				int num2;
				while (OoO0o.SetupDiEnumDeviceInterfaces(num, 0, ref o0o_0o_00_Oo, num2, ref o_0O00__o0O) && OoO0o.GetLastError() != 259)
				{
					OoO0o.O0__0o o0__0o;
					o0__0o.cbSize = 5;
					int num3;
					if (!OoO0o.SetupDiGetDeviceInterfaceDetailA(num, ref o_0O00__o0O, ref o0__0o, 300, ref num3, 0))
					{
						OoO0o.SetupDiDestroyDeviceInfoList(num);
						return result;
					}
					A_2 = new StringBuilder(new string(o0__0o.DevicePath), 260);
					int num4 = OoO0o.Oo___0.O_o.(A_2.ToString(), 0, 3, 0, 3, 0, 0);
					if (-1 != num4)
					{
						OoO0o.o_O000_Oo0oo o_O000_Oo0oo;
						if (OoO0o.HidD_GetAttributes(num4, ref o_O000_Oo0oo) && (o_O000_Oo0oo.ProductID == -30878 & o_O000_Oo0oo.VendorID == 13961))
						{
							if (A_0 == A_1)
							{
								OoO0o.SetupDiDestroyDeviceInfoList(num);
								OoO0o.CloseHandle(num4);
								return true;
							}
							A_1 += 1;
						}
						OoO0o.CloseHandle(num4);
					}
					num2++;
				}
				OoO0o.SetupDiDestroyDeviceInfoList(num);
			}
			return result;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x0011FE40 File Offset: 0x0011E040
		private static int <<EMPTY_NAME>>(short A_0, ref string A_1)
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			short num;
			int result;
			if (!OoO0o.o__._00.(A_0, ref num, ref stringBuilder))
			{
				result = -92;
			}
			else
			{
				A_1 = stringBuilder.ToString();
				result = 0;
			}
			return result;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0011FE7C File Offset: 0x0011E07C
		private static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			short num = A_0;
			while (num <= 256)
			{
				short num2;
				int result;
				if (!OoO0o.o__._00.(num, ref num2, ref stringBuilder))
				{
					result = -92;
				}
				else
				{
					short num3 = (short)OoO0o.oOo0_O.O0_.(A_1, A_3);
					if (num3 != 0)
					{
						result = (int)num3;
					}
					else
					{
						int num4;
						num3 = (short)OoO0o.o00_.0_O.(ref num4, A_3);
						if (num3 != 0)
						{
							result = (int)num3;
						}
						else
						{
							if (num4 != A_2)
							{
								num += 1;
								continue;
							}
							A_3 = stringBuilder.ToString();
							result = 0;
						}
					}
				}
				return result;
			}
			return -92;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		private static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			if (Strings.Len(A_1) < 1)
			{
				StringBuilder stringBuilder = new StringBuilder("", 260);
				short num;
				if (!OoO0o.o__._00.(0, ref num, ref stringBuilder))
				{
					return -92;
				}
				A_0 = OoO0o.Oo___0.O_o.(stringBuilder.ToString(), -1073741824, 3, 0, 3, 128, 0);
				if (A_0 == -1)
				{
					return -92;
				}
			}
			else
			{
				A_0 = OoO0o.Oo___0.O_o.(A_1, -1073741824, 3, 0, 3, 128, 0);
				if (A_0 == -1)
				{
					return -92;
				}
			}
			return 0;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0011FF7C File Offset: 0x0011E17C
		private static int <<EMPTY_NAME>>(ref byte A_0, ref byte A_1, ref byte A_2, ref byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array, 5))
			{
				OoO0o.CloseHandle(a_);
				result = -93;
			}
			else
			{
				OoO0o.CloseHandle(a_);
				A_0 = array[0];
				A_1 = array[1];
				A_2 = array[2];
				A_3 = array[3];
				result = 0;
			}
			return result;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0011FFD8 File Offset: 0x0011E1D8
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 3;
				array[2] = A_0;
				array[3] = A_1;
				array[4] = A_2;
				array[5] = A_3;
				if (!OoO0o.OO.00_0.(a_, ref array, 5))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00120034 File Offset: 0x0011E234
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 4;
				array[2] = A_0;
				array[3] = A_1;
				array[4] = A_2;
				array[5] = A_3;
				if (!OoO0o.OO.00_0.(a_, ref array, 5))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00120090 File Offset: 0x0011E290
		private static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_1) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 1;
				if (!OoO0o.OO.00_0.(a_, ref array, 1))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 1))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					A_0 = (short)array2[0];
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00120100 File Offset: 0x0011E300
		private static int <<EMPTY_NAME>>(ref int A_0, ref int A_1, string A_2)
		{
			int[] array = new int[9];
			byte[] array2 = new byte[26];
			byte[] array3 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array2[1] = 2;
				if (!OoO0o.OO.00_0.(a_, ref array2, 1))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array3, 8))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					array[0] = (int)array3[0];
					array[1] = (int)array3[1];
					array[2] = (int)array3[2];
					array[3] = (int)array3[3];
					array[4] = (int)array3[4];
					array[5] = (int)array3[5];
					array[6] = (int)array3[6];
					array[7] = (int)array3[7];
					A_0 = (array[3] | array[2] << 8 | array[1] << 16 | array[0] << 24);
					A_1 = (array[7] | array[6] << 8 | array[5] << 16 | array[4] << 24);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x001201E0 File Offset: 0x0011E3E0
		private static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, ref byte[] A_3, string A_4, short A_5)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else if (A_2 > 16)
			{
				result = -87;
			}
			else if (A_2 + A_1 > 495)
			{
				result = -88;
			}
			else
			{
				short num = (short)(A_1 >> 8) * 2;
				short num2 = A_1 & 255;
				int a_;
				if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 18;
					array[2] = (byte)num;
					array[3] = (byte)num2;
					array[4] = (byte)A_2;
					short num3 = 0;
					do
					{
						array[(int)(5 + num3)] = A_3[(int)num3];
						num3 += 1;
					}
					while (num3 <= 7);
					if (!OoO0o.OO.00_0.(a_, ref array, 13))
					{
						OoO0o.CloseHandle(a_);
						result = -93;
					}
					else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, A_2 + 1))
					{
						OoO0o.CloseHandle(a_);
						result = -94;
					}
					else
					{
						OoO0o.CloseHandle(a_);
						if (array2[0] != 0)
						{
							result = -83;
						}
						else
						{
							short num4 = A_2 - 1;
							for (num3 = 0; num3 <= num4; num3 += 1)
							{
								A_0[(int)(num3 + A_5)] = array2[(int)(num3 + 1)];
							}
							result = 0;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x001202F8 File Offset: 0x0011E4F8
		private static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, ref byte[] A_3, string A_4, short A_5)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_2 > 8)
			{
				result = -87;
			}
			else if (A_1 + A_2 - 1 > 512 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				short num = (short)(A_1 >> 8) * 2;
				short num2 = A_1 & 255;
				int a_;
				if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 19;
					array[2] = (byte)num;
					array[3] = (byte)num2;
					array[4] = (byte)A_2;
					short num3 = 0;
					do
					{
						array[(int)(5 + num3)] = A_3[(int)num3];
						num3 += 1;
					}
					while (num3 <= 7);
					short num4 = A_2 - 1;
					for (num3 = 0; num3 <= num4; num3 += 1)
					{
						array[(int)(13 + num3)] = A_0[(int)(num3 + A_5)];
					}
					if (!OoO0o.OO.00_0.(a_, ref array, 13 + A_2))
					{
						OoO0o.CloseHandle(a_);
						result = -93;
					}
					else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
					{
						OoO0o.CloseHandle(a_);
						result = -94;
					}
					else
					{
						OoO0o.CloseHandle(a_);
						if (array2[0] != 0)
						{
							result = -82;
						}
						else
						{
							result = 0;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00120400 File Offset: 0x0011E600
		private static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2, short A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 8;
				short num = 2;
				do
				{
					array[(int)num] = A_0[(int)(num - 2 + A_3)];
					num += 1;
				}
				while (num <= 9);
				if (!OoO0o.OO.00_0.(a_, ref array, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					num = 0;
					do
					{
						A_1[(int)(num + A_3)] = array2[(int)num];
						num += 1;
					}
					while (num <= 7);
					if (array2[8] != 85)
					{
						result = -20;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x001204A8 File Offset: 0x0011E6A8
		private static int <<EMPTY_NAME>>(ref byte[] A_0, byte A_1, string A_2, short A_3)
		{
			byte[] array = new byte[31];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 9;
				array[2] = A_1;
				short num = 0;
				do
				{
					array[(int)(3 + num)] = A_0[(int)(num + A_3)];
					num += 1;
				}
				while (num <= 7);
				if (!OoO0o.OO.00_0.(a_, ref array, 11))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
				{
					OoO0o.CloseHandle(a_);
					result = -94;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					if (array2[0] != 0)
					{
						result = -82;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0012053C File Offset: 0x0011E73C
		private static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			byte b;
			byte b2;
			byte b3;
			byte b4;
			int result = OoO0o.o0_o.OOO__0.(ref b, ref b2, ref b3, ref b4, A_1);
			int num = (int)b;
			int num2 = (int)b2;
			int num3 = (int)b3;
			int num4 = (int)b4;
			A_0 = (num | num2 << 8 | num3 << 16 | num4 << 24);
			return result;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00120578 File Offset: 0x0011E778
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return OoO0o.o00_.0_O.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x001205BC File Offset: 0x0011E7BC
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return OoO0o.o0O.Oooo_.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00120600 File Offset: 0x0011E800
		public static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.O0ooo0.OO_0.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00120640 File Offset: 0x0011E840
		public static int <<EMPTY_NAME>>(ref int A_0, ref int A_1, string A_2)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.ooO0O.O_oO.(ref A_0, ref A_1, A_2);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00120680 File Offset: 0x0011E880
		public static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.o00_.0_O.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x001206C0 File Offset: 0x0011E8C0
		public static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.oOo0_O.O0_.(A_0, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00120700 File Offset: 0x0011E900
		public static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 + A_2 - 1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				OoO0o.o__._00.(A_3, A_4, ref array);
				int num = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
				OoO0o.WaitForSingleObject(num, -1);
				short num2 = A_1 % 16;
				short num3 = 16 - num2;
				if (num3 > A_2)
				{
					num3 = A_2;
				}
				int num6;
				int num7;
				if (num3 > 0)
				{
					short num4 = num3 / 8 - 1;
					short num5;
					for (num5 = 0; num5 <= num4; num5 += 1)
					{
						num6 = OoO0o.O_O0O_0.OO0_.(ref A_0, A_1 + num5 * 8, 8, ref array, A_5, 8 * num5);
						if (num6 != 0)
						{
							int a_ = num;
							int a_2 = 1;
							num7 = 0;
							OoO0o.ReleaseSemaphore(a_, a_2, ref num7);
							OoO0o.CloseHandle(num);
							return num6;
						}
					}
					if (num3 - 8 * num5 > 0)
					{
						num6 = OoO0o.O_O0O_0.OO0_.(ref A_0, A_1 + num5 * 8, num3 - num5 * 8, ref array, A_5, 8 * num5);
						if (num6 != 0)
						{
							int a_3 = num;
							int a_4 = 1;
							num7 = 0;
							OoO0o.ReleaseSemaphore(a_3, a_4, ref num7);
							OoO0o.CloseHandle(num);
							return num6;
						}
					}
				}
				A_2 -= num3;
				A_1 += num3;
				if (A_2 > 0)
				{
					short num8 = A_2 / 8 - 1;
					short num5;
					for (num5 = 0; num5 <= num8; num5 += 1)
					{
						num6 = OoO0o.O_O0O_0.OO0_.(ref A_0, A_1 + num5 * 8, 8, ref array, A_5, num3 + 8 * num5);
						if (num6 != 0)
						{
							int a_5 = num;
							int a_6 = 1;
							num7 = 0;
							OoO0o.ReleaseSemaphore(a_5, a_6, ref num7);
							OoO0o.CloseHandle(num);
							return num6;
						}
					}
					if (A_2 - 8 * num5 > 0)
					{
						num6 = OoO0o.O_O0O_0.OO0_.(ref A_0, A_1 + num5 * 8, A_2 - num5 * 8, ref array, A_5, num3 + 8 * num5);
						if (num6 != 0)
						{
							int a_7 = num;
							int a_8 = 1;
							num7 = 0;
							OoO0o.ReleaseSemaphore(a_7, a_8, ref num7);
							OoO0o.CloseHandle(num);
							return num6;
						}
					}
				}
				int a_9 = num;
				int a_10 = 1;
				num7 = 0;
				OoO0o.ReleaseSemaphore(a_9, a_10, ref num7);
				OoO0o.CloseHandle(num);
				result = num6;
			}
			return result;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x001208CC File Offset: 0x0011EACC
		public static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 + A_2 - 1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				OoO0o.o__._00.(A_3, A_4, ref array);
				int num = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
				OoO0o.WaitForSingleObject(num, -1);
				short num2 = A_2 / 16 - 1;
				short num3;
				int num4;
				int num5;
				for (num3 = 0; num3 <= num2; num3 += 1)
				{
					num4 = OoO0o.OOo0o.00000o.(ref A_0, A_1 + num3 * 16, 16, ref array, A_5, num3 * 16);
					if (num4 != 0)
					{
						int a_ = num;
						int a_2 = 1;
						num5 = 0;
						OoO0o.ReleaseSemaphore(a_, a_2, ref num5);
						OoO0o.CloseHandle(num);
						return num4;
					}
				}
				if (A_2 - 16 * num3 > 0)
				{
					num4 = OoO0o.OOo0o.00000o.(ref A_0, A_1 + num3 * 16, A_2 - 16 * num3, ref array, A_5, 16 * num3);
					if (num4 != 0)
					{
						int a_3 = num;
						int a_4 = 1;
						num5 = 0;
						OoO0o.ReleaseSemaphore(a_3, a_4, ref num5);
						OoO0o.CloseHandle(num);
						return num4;
					}
				}
				int a_5 = num;
				int a_6 = 1;
				num5 = 0;
				OoO0o.ReleaseSemaphore(a_5, a_6, ref num5);
				OoO0o.CloseHandle(num);
				result = num4;
			}
			return result;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x001209CC File Offset: 0x0011EBCC
		public static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.ooO0O.O_oO.(A_0, A_1, A_2, ref A_3);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00120A0C File Offset: 0x0011EC0C
		public static int <<EMPTY_NAME>>(short A_0, ref string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.ooO0O.O_oO.(A_0, ref A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00120A4C File Offset: 0x0011EC4C
		public static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.OOo.O___oo_.(A_0, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00120A8C File Offset: 0x0011EC8C
		private static string <<EMPTY_NAME>>(string A_0)
		{
			for (short num = (short)Strings.Len(A_0); num <= 7; num += 1)
			{
				A_0 = "0" + A_0;
			}
			return A_0;
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00120ABC File Offset: 0x0011ECBC
		private static void <<EMPTY_NAME>>(string A_0, string A_1, ref byte[] A_2)
		{
			A_0 = OoO0o.Oo___0.O_o.(A_0);
			A_1 = OoO0o.Oo___0.O_o.(A_1);
			short num = 0;
			do
			{
				A_2[(int)num] = (byte)OoO0o.O_O.oOO0_.(Strings.Mid(A_0, (int)(1 + num * 2), 2));
				num += 1;
			}
			while (num <= 3);
			num = 0;
			do
			{
				A_2[(int)(num + 4)] = (byte)OoO0o.O_O.oOO0_.(Strings.Mid(A_1, (int)(1 + num * 2), 2));
				num += 1;
			}
			while (num <= 3);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00120B20 File Offset: 0x0011ED20
		public static int <<EMPTY_NAME>>(ref byte A_0, int A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				OoO0o.o__._00.(A_2, A_3, ref array);
				int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
				OoO0o.WaitForSingleObject(a_, -1);
				int num = OoO0o.oo_o_oo._0O.(ref A_0, (short)A_1, ref array, A_4);
				int a_2 = 1;
				int num2 = 0;
				OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
				OoO0o.CloseHandle(a_);
				result = num;
			}
			return result;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00120B8C File Offset: 0x0011ED8C
		private static int <<EMPTY_NAME>>(ref byte A_0, short A_1, ref byte[] A_2, string A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				byte b = 128;
				if (A_1 > 255)
				{
					b = 160;
					A_1 -= 256;
				}
				int a_;
				if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_3) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 16;
					array[2] = b;
					array[3] = (byte)A_1;
					array[4] = (byte)A_1;
					short num = 0;
					do
					{
						array[(int)(5 + num)] = A_2[(int)num];
						num += 1;
					}
					while (num <= 7);
					if (!OoO0o.OO.00_0.(a_, ref array, 13))
					{
						OoO0o.CloseHandle(a_);
						result = -93;
					}
					else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
					{
						OoO0o.CloseHandle(a_);
						result = -94;
					}
					else
					{
						OoO0o.CloseHandle(a_);
						if (array2[0] != 83)
						{
							result = -83;
						}
						else
						{
							A_0 = array2[1];
							result = 0;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00120C68 File Offset: 0x0011EE68
		public static int <<EMPTY_NAME>>(byte A_0, int A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 > 495 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				OoO0o.o__._00.(A_2, A_3, ref array);
				int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
				OoO0o.WaitForSingleObject(a_, -1);
				int num = OoO0o.oo_o_oo._0O.(A_0, (short)A_1, ref array, A_4);
				int a_2 = 1;
				int num2 = 0;
				OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
				OoO0o.CloseHandle(a_);
				result = num;
			}
			return result;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00120CD4 File Offset: 0x0011EED4
		private static int <<EMPTY_NAME>>(byte A_0, short A_1, ref byte[] A_2, string A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_1 > 511 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				byte b = 64;
				if (A_1 > 255)
				{
					b = 96;
					A_1 -= 256;
				}
				int a_;
				if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_3) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 17;
					array[2] = b;
					array[3] = (byte)A_1;
					array[4] = A_0;
					short num = 0;
					do
					{
						array[(int)(5 + num)] = A_2[(int)num];
						num += 1;
					}
					while (num <= 7);
					if (!OoO0o.OO.00_0.(a_, ref array, 13))
					{
						OoO0o.CloseHandle(a_);
						result = -93;
					}
					else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
					{
						OoO0o.CloseHandle(a_);
						result = -94;
					}
					else
					{
						OoO0o.CloseHandle(a_);
						if (array2[1] != 1)
						{
							result = -82;
						}
						else
						{
							result = 0;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00120DA4 File Offset: 0x0011EFA4
		public static int <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			OoO0o.o__._00.(A_0, A_1, ref array);
			OoO0o.o__._00.(A_2, A_3, ref array2);
			short a_ = 496;
			int a_2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_2, -1);
			int result = OoO0o.O_O0O_0.OO0_.(ref array2, a_, 8, ref array, A_4, 0);
			int a_3 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_2, a_3, ref num);
			OoO0o.CloseHandle(a_2);
			return result;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00120E14 File Offset: 0x0011F014
		public static int <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			OoO0o.o__._00.(A_0, A_1, ref array);
			OoO0o.o__._00.(A_2, A_3, ref array2);
			short a_ = 504;
			int a_2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_2, -1);
			int result = OoO0o.O_O0O_0.OO0_.(ref array2, a_, 8, ref array, A_4, 0);
			int a_3 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_2, a_3, ref num);
			OoO0o.CloseHandle(a_2);
			return result;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00120E84 File Offset: 0x0011F084
		public static int <<EMPTY_NAME>>(string A_0, short A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 < 0)
			{
				result = -81;
			}
			else
			{
				OoO0o.o__._00.(A_2, A_3, ref array);
				short num = (short)OoO0o.lstrlenA(A_0);
				byte[] array2 = new byte[(int)(num + 1)];
				OoO0o.Oo___0.O_o.(ref array2[0], A_0, (int)num);
				if (A_1 + num > 495)
				{
					result = -47;
				}
				else
				{
					int num2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
					OoO0o.WaitForSingleObject(num2, -1);
					short num3 = A_1 % 16;
					short num4 = 16 - num3;
					if (num4 > num)
					{
						num4 = num;
					}
					int num7;
					int num8;
					if (num4 > 0)
					{
						short num5 = num4 / 8 - 1;
						short num6;
						for (num6 = 0; num6 <= num5; num6 += 1)
						{
							num7 = OoO0o.O_O0O_0.OO0_.(ref array2, A_1 + num6 * 8, 8, ref array, A_4, num6 * 8);
							if (num7 != 0)
							{
								int a_ = num2;
								int a_2 = 1;
								num8 = 0;
								OoO0o.ReleaseSemaphore(a_, a_2, ref num8);
								OoO0o.CloseHandle(num2);
								return num7;
							}
						}
						if (num4 - 8 * num6 > 0)
						{
							num7 = OoO0o.O_O0O_0.OO0_.(ref array2, A_1 + num6 * 8, num4 - num6 * 8, ref array, A_4, 8 * num6);
							if (num7 != 0)
							{
								int a_3 = num2;
								int a_4 = 1;
								num8 = 0;
								OoO0o.ReleaseSemaphore(a_3, a_4, ref num8);
								OoO0o.CloseHandle(num2);
								return num7;
							}
						}
					}
					num -= num4;
					A_1 += num4;
					if (num > 0)
					{
						short num9 = num / 8 - 1;
						short num6;
						for (num6 = 0; num6 <= num9; num6 += 1)
						{
							num7 = OoO0o.O_O0O_0.OO0_.(ref array2, A_1 + num6 * 8, 8, ref array, A_4, num4 + num6 * 8);
							if (num7 != 0)
							{
								int a_5 = num2;
								int a_6 = 1;
								num8 = 0;
								OoO0o.ReleaseSemaphore(a_5, a_6, ref num8);
								OoO0o.CloseHandle(num2);
								return num7;
							}
						}
						if (num - 8 * num6 > 0)
						{
							num7 = OoO0o.O_O0O_0.OO0_.(ref array2, A_1 + num6 * 8, num - num6 * 8, ref array, A_4, num4 + 8 * num6);
							if (num7 != 0)
							{
								int a_7 = num2;
								int a_8 = 1;
								num8 = 0;
								OoO0o.ReleaseSemaphore(a_7, a_8, ref num8);
								OoO0o.CloseHandle(num2);
								return num7;
							}
						}
					}
					int a_9 = num2;
					int a_10 = 1;
					num8 = 0;
					OoO0o.ReleaseSemaphore(a_9, a_10, ref num8);
					OoO0o.CloseHandle(num2);
					result = num7;
				}
			}
			return result;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00121080 File Offset: 0x0011F280
		public static short <<EMPTY_NAME>>(ref string A_0, short A_1, int A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[A_2 + 1];
			OoO0o.o__._00.(A_3, A_4, ref array);
			short result;
			if (A_1 < 0)
			{
				result = -81;
			}
			else if ((short)((int)A_1 + A_2) > 495)
			{
				result = -47;
			}
			else
			{
				int num = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
				OoO0o.WaitForSingleObject(num, -1);
				short num2 = (short)(A_2 / 16 - 1);
				short num3;
				int num4;
				int num5;
				for (num3 = 0; num3 <= num2; num3 += 1)
				{
					num4 = OoO0o.OOo0o.00000o.(ref array2, A_1 + num3 * 16, 16, ref array, A_5, num3 * 16);
					if (num4 != 0)
					{
						int a_ = num;
						int a_2 = 1;
						num5 = 0;
						OoO0o.ReleaseSemaphore(a_, a_2, ref num5);
						OoO0o.CloseHandle(num);
						return (short)num4;
					}
				}
				if (A_2 - (int)(16 * num3) > 0)
				{
					num4 = OoO0o.OOo0o.00000o.(ref array2, A_1 + num3 * 16, (short)(A_2 - (int)(16 * num3)), ref array, A_5, 16 * num3);
					if (num4 != 0)
					{
						int a_3 = num;
						int a_4 = 1;
						num5 = 0;
						OoO0o.ReleaseSemaphore(a_3, a_4, ref num5);
						OoO0o.CloseHandle(num);
						return (short)num4;
					}
				}
				int a_5 = num;
				int a_6 = 1;
				num5 = 0;
				OoO0o.ReleaseSemaphore(a_5, a_6, ref num5);
				OoO0o.CloseHandle(num);
				StringBuilder stringBuilder = new StringBuilder("", A_2);
				short num6 = (short)A_2;
				for (num3 = 1; num3 <= num6; num3 += 1)
				{
					stringBuilder.Append(0);
				}
				OoO0o.Oo___0.O_o.(stringBuilder, ref array2[0], A_2);
				A_0 = stringBuilder.ToString();
				result = (short)num4;
			}
			return result;
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x001211DC File Offset: 0x0011F3DC
		public static int <<EMPTY_NAME>>(string A_0, string A_1)
		{
			new byte[9];
			byte[] array;
			OoO0o.o__._00.(A_0, ref array);
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int num = OoO0o.ooO0O.O_oO.(ref array, 0, A_1, 8);
			if (num == 0)
			{
				num = OoO0o.ooO0O.O_oO.(ref array, 1, A_1, 0);
			}
			int a_2 = 1;
			int num2 = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
			OoO0o.CloseHandle(a_);
			return num;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x0012123C File Offset: 0x0011F43C
		public static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.OoO0.O0_0.(ref A_0, ref A_1, A_2, 0);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0012127C File Offset: 0x0011F47C
		public static int <<EMPTY_NAME>>(string A_0, ref string A_1, string A_2)
		{
			int num = OoO0o.lstrlenA(A_0) + 1;
			int a_ = num;
			if (num < 8)
			{
				num = 8;
			}
			else
			{
				num = num;
			}
			byte[] array = new byte[num + 1];
			byte[] array2 = new byte[num + 1];
			OoO0o.Oo___0.O_o.(ref array[0], A_0, a_);
			array.CopyTo(array2, 0);
			int num2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(num2, -1);
			int num3 = num - 8;
			int num4;
			for (int i = 0; i <= num3; i += 8)
			{
				num4 = OoO0o.OoO0.O0_0.(ref array, ref array2, A_2, (short)i);
				if (num4 != 0)
				{
					break;
				}
			}
			int a_2 = num2;
			int a_3 = 1;
			int num5 = 0;
			OoO0o.ReleaseSemaphore(a_2, a_3, ref num5);
			OoO0o.CloseHandle(num2);
			A_1 = "";
			num5 = num - 1;
			for (int i = 0; i <= num5; i++)
			{
				A_1 += array2[i].ToString("X2");
			}
			return num4;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00121358 File Offset: 0x0011F558
		public static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int num = OoO0o.oOo0_O.O0_.(A_0, A_2);
			if (num == 0)
			{
				num = OoO0o.o00_.0_O.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
			OoO0o.CloseHandle(a_);
			return num;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x001213A0 File Offset: 0x0011F5A0
		public static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int num = OoO0o.OOo.O___oo_.(A_0, A_2);
			if (num == 0)
			{
				num = OoO0o.o00_.0_O.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
			OoO0o.CloseHandle(a_);
			return num;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x001213E8 File Offset: 0x0011F5E8
		public static int <<EMPTY_NAME>>(string A_0)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.o0_o.OOO__0.(A_0);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00121424 File Offset: 0x0011F624
		private static int <<EMPTY_NAME>>(string A_0)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_0) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 32;
				if (!OoO0o.OO.00_0.(a_, ref array, 2))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					if (array2[0] != 0)
					{
						result = -82;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00121498 File Offset: 0x0011F698
		public static int <<EMPTY_NAME>>(string A_0, string A_1)
		{
			new byte[9];
			byte[] array;
			OoO0o.o__._00.(A_0, ref array);
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int num = OoO0o.o0_o.OOO__0.(ref array, 0, A_1, 8);
			if (num == 0)
			{
				num = OoO0o.o0_o.OOO__0.(ref array, 1, A_1, 0);
			}
			int a_2 = 1;
			int num2 = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num2);
			OoO0o.CloseHandle(a_);
			return num;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x001214F8 File Offset: 0x0011F6F8
		public static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.o0_o.OOO__0.(ref A_0, ref A_1, A_2, 0);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00121538 File Offset: 0x0011F738
		public static int <<EMPTY_NAME>>(string A_0, ref string A_1, string A_2)
		{
			int num = OoO0o.lstrlenA(A_0) + 1;
			int a_ = num;
			if (num < 8)
			{
				num = 8;
			}
			else
			{
				num = num;
			}
			byte[] array = new byte[num + 1];
			byte[] array2 = new byte[num + 1];
			OoO0o.Oo___0.O_o.(ref array[0], A_0, a_);
			array.CopyTo(array2, 0);
			int num2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(num2, -1);
			int num3 = num - 8;
			int num4;
			for (int i = 0; i <= num3; i += 8)
			{
				num4 = OoO0o.o0_o.OOO__0.(ref array, ref array2, A_2, (short)i);
				if (num4 != 0)
				{
					break;
				}
			}
			int a_2 = num2;
			int a_3 = 1;
			int num5 = 0;
			OoO0o.ReleaseSemaphore(a_2, a_3, ref num5);
			OoO0o.CloseHandle(num2);
			A_1 = "";
			num5 = num - 1;
			for (int i = 0; i <= num5; i++)
			{
				A_1 += array2[i].ToString("X2");
			}
			return num4;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00121614 File Offset: 0x0011F814
		public static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.o.0_0O.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00121654 File Offset: 0x0011F854
		private static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2, short A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 12;
				short num = 2;
				do
				{
					array[(int)num] = A_0[(int)(num - 2 + A_3)];
					num += 1;
				}
				while (num <= 9);
				if (!OoO0o.OO.00_0.(a_, ref array, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					num = 0;
					do
					{
						A_1[(int)(num + A_3)] = array2[(int)num];
						num += 1;
					}
					while (num <= 7);
					if (array2[8] != 85)
					{
						result = -20;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x001216FC File Offset: 0x0011F8FC
		private static int <<EMPTY_NAME>>(ref byte[] A_0, byte A_1, string A_2, short A_3)
		{
			byte[] array = new byte[31];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 13;
				array[2] = A_1;
				short num = 0;
				do
				{
					array[(int)(3 + num)] = A_0[(int)(num + A_3)];
					num += 1;
				}
				while (num <= 7);
				if (!OoO0o.OO.00_0.(a_, ref array, 11))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
				{
					OoO0o.CloseHandle(a_);
					result = -94;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					if (array2[0] != 0)
					{
						result = -82;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00121790 File Offset: 0x0011F990
		private static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_1) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 5;
				if (!OoO0o.OO.00_0.(a_, ref array, 1))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 1))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					A_0 = (short)array2[0];
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00121800 File Offset: 0x0011FA00
		private static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, ref byte[] A_3, string A_4)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			int a_;
			if (A_2 > 8)
			{
				result = -87;
			}
			else if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 6;
				array[2] = 0;
				array[3] = 0;
				array[4] = (byte)A_2;
				short num = 0;
				do
				{
					array[(int)(5 + num)] = A_3[(int)num];
					num += 1;
				}
				while (num <= 7);
				short num2 = A_2 - 1;
				for (num = 0; num <= num2; num += 1)
				{
					array[(int)(13 + num)] = A_0[(int)num];
				}
				if (!OoO0o.OO.00_0.(a_, ref array, 13 + A_2))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 2))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					if (array2[0] != 0)
					{
						result = -82;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x001218CC File Offset: 0x0011FACC
		public static int <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			OoO0o.o__._00.(A_0, A_1, ref array);
			OoO0o.o__._00.(A_2, A_3, ref array2);
			short a_ = 0;
			int a_2 = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_2, -1);
			int result = OoO0o.O_O0O_0.OO0_.(ref array2, a_, 8, ref array, A_4);
			int a_3 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_2, a_3, ref num);
			OoO0o.CloseHandle(a_2);
			return result;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00121934 File Offset: 0x0011FB34
		private static int <<EMPTY_NAME>>(ref byte[] A_0, string A_1)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (OoO0o.o0_Ooo_.o_00_.(ref a_, A_1) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 7;
				short num = 2;
				do
				{
					array[(int)num] = A_0[(int)(num - 2)];
					num += 1;
				}
				while (num <= 9);
				if (!OoO0o.OO.00_0.(a_, ref array, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else if (!OoO0o.oOO.0O_0oO00_o.(a_, ref array2, 9))
				{
					OoO0o.CloseHandle(a_);
					result = -93;
				}
				else
				{
					OoO0o.CloseHandle(a_);
					if (array2[0] != 0)
					{
						result = -82;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x001219C4 File Offset: 0x0011FBC4
		public static int <<EMPTY_NAME>>(string A_0, string A_1)
		{
			byte[] array;
			OoO0o.o__._00.(A_0, ref array);
			int a_ = OoO0o.o.0_0O.(0, 1, 1, "ex_sim");
			OoO0o.WaitForSingleObject(a_, -1);
			int result = OoO0o.o0O.Oooo_.(ref array, A_1);
			int a_2 = 1;
			int num = 0;
			OoO0o.ReleaseSemaphore(a_, a_2, ref num);
			OoO0o.CloseHandle(a_);
			return result;
		}

		// Token: 0x0400104D RID: 4173
		private const short <<EMPTY_NAME>> = 13961;

		// Token: 0x0400104E RID: 4174
		private const short <<EMPTY_NAME>> = -30878;

		// Token: 0x0400104F RID: 4175
		private const short <<EMPTY_NAME>> = 2;

		// Token: 0x04001050 RID: 4176
		private const short <<EMPTY_NAME>> = 16;

		// Token: 0x04001051 RID: 4177
		private const short <<EMPTY_NAME>> = -1;

		// Token: 0x04001052 RID: 4178
		private const short <<EMPTY_NAME>> = 259;

		// Token: 0x04001053 RID: 4179
		private const int <<EMPTY_NAME>> = -2147483648;

		// Token: 0x04001054 RID: 4180
		private const int <<EMPTY_NAME>> = 1073741824;

		// Token: 0x04001055 RID: 4181
		private const short <<EMPTY_NAME>> = 1;

		// Token: 0x04001056 RID: 4182
		private const short <<EMPTY_NAME>> = 2;

		// Token: 0x04001057 RID: 4183
		private const short <<EMPTY_NAME>> = 3;

		// Token: 0x04001058 RID: 4184
		private const short <<EMPTY_NAME>> = 128;

		// Token: 0x04001059 RID: 4185
		private const short <<EMPTY_NAME>> = -1;

		// Token: 0x0400105A RID: 4186
		private const short <<EMPTY_NAME>> = 495;

		// Token: 0x0400105B RID: 4187
		private const long <<EMPTY_NAME>> = 4294967296L;

		// Token: 0x0400105C RID: 4188
		private const long <<EMPTY_NAME>> = 2147483647L;

		// Token: 0x0400105D RID: 4189
		private const long <<EMPTY_NAME>> = 2147483648L;

		// Token: 0x0400105E RID: 4190
		private const long <<EMPTY_NAME>> = -1640531527L;

		// Token: 0x0400105F RID: 4191
		private static long <<EMPTY_NAME>>;

		// Token: 0x020002D1 RID: 721
		private struct O0o_0o_00_Oo
		{
			// Token: 0x04001060 RID: 4192
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public byte[] Data1;

			// Token: 0x04001061 RID: 4193
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] Data2;

			// Token: 0x04001062 RID: 4194
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] Data3;

			// Token: 0x04001063 RID: 4195
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] Data4;
		}

		// Token: 0x020002D2 RID: 722
		private struct O_0O00__o0O
		{
			// Token: 0x04001064 RID: 4196
			public int cbSize;

			// Token: 0x04001065 RID: 4197
			public OoO0o.O0o_0o_00_Oo InterfaceClassGuid;

			// Token: 0x04001066 RID: 4198
			public int Flags;

			// Token: 0x04001067 RID: 4199
			public int Reserved;
		}

		// Token: 0x020002D3 RID: 723
		private struct oOO0oOo__ooo
		{
			// Token: 0x04001068 RID: 4200
			public int cbSize;

			// Token: 0x04001069 RID: 4201
			public OoO0o.O0o_0o_00_Oo ClassGuid;

			// Token: 0x0400106A RID: 4202
			public int DevInst;

			// Token: 0x0400106B RID: 4203
			public int Reserved;
		}

		// Token: 0x020002D4 RID: 724
		private struct O0__0o
		{
			// Token: 0x0400106C RID: 4204
			public int cbSize;

			// Token: 0x0400106D RID: 4205
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
			public char[] DevicePath;
		}

		// Token: 0x020002D5 RID: 725
		private struct o_O000_Oo0oo
		{
			// Token: 0x0400106E RID: 4206
			public int Size;

			// Token: 0x0400106F RID: 4207
			public short VendorID;

			// Token: 0x04001070 RID: 4208
			public short ProductID;

			// Token: 0x04001071 RID: 4209
			public short VersionNumber;
		}

		// Token: 0x020002D6 RID: 726
		private struct o_OO000_0
		{
			// Token: 0x04001072 RID: 4210
			public short Usage;

			// Token: 0x04001073 RID: 4211
			public short UsagePage;

			// Token: 0x04001074 RID: 4212
			public short InputReportByteLength;

			// Token: 0x04001075 RID: 4213
			public short OutputReportByteLength;

			// Token: 0x04001076 RID: 4214
			public short FeatureReportByteLength;

			// Token: 0x04001077 RID: 4215
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public short[] Reserved;

			// Token: 0x04001078 RID: 4216
			public short NumberLinkCollectionNodes;

			// Token: 0x04001079 RID: 4217
			public short NumberInputButtonCaps;

			// Token: 0x0400107A RID: 4218
			public short NumberInputValueCaps;

			// Token: 0x0400107B RID: 4219
			public short NumberInputDataIndices;

			// Token: 0x0400107C RID: 4220
			public short NumberOutputButtonCaps;

			// Token: 0x0400107D RID: 4221
			public short NumberOutputValueCaps;

			// Token: 0x0400107E RID: 4222
			public short NumberOutputDataIndices;

			// Token: 0x0400107F RID: 4223
			public short NumberFeatureButtonCaps;

			// Token: 0x04001080 RID: 4224
			public short NumberFeatureValueCaps;

			// Token: 0x04001081 RID: 4225
			public short NumberFeatureDataIndices;
		}
	}
}
