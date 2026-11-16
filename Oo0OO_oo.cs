using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002C6 RID: 710
	[StandardModule]
	internal sealed class Oo0OO_oo
	{
		// Token: 0x060026E7 RID: 9959
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		internal static extern void <<EMPTY_NAME>>(byte[] A_0, ref int A_1, int A_2);

		// Token: 0x060026E8 RID: 9960
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		internal static extern void <<EMPTY_NAME>>(ref int A_0, byte[] A_1, int A_2);

		// Token: 0x060026E9 RID: 9961
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(byte[] A_0, byte[] A_1, int A_2);

		// Token: 0x060026EA RID: 9962
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(byte[] A_0, string A_1, int A_2);

		// Token: 0x060026EB RID: 9963
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "RtlMoveMemory")]
		private static extern void <<EMPTY_NAME>>(StringBuilder A_0, byte[] A_1, int A_2);

		// Token: 0x060026EC RID: 9964
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetAttributes(int A_0, ref Oo0OO_oo.OOo A_1);

		// Token: 0x060026ED RID: 9965
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern int HidD_GetHidGuid(ref Oo0OO_oo.o00oO_o A_0);

		// Token: 0x060026EE RID: 9966
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetPreparsedData(int A_0, ref int A_1);

		// Token: 0x060026EF RID: 9967
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern int HidP_GetCaps(int A_0, ref Oo0OO_oo.OoOo A_1);

		// Token: 0x060026F0 RID: 9968
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_FreePreparsedData(int A_0);

		// Token: 0x060026F1 RID: 9969
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_SetFeature(int A_0, byte[] A_1, int A_2);

		// Token: 0x060026F2 RID: 9970
		[DllImport("HID.dll", CharSet = CharSet.Ansi)]
		private static extern bool HidD_GetFeature(int A_0, byte[] A_1, int A_2);

		// Token: 0x060026F3 RID: 9971
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern int SetupDiGetClassDevsA(ref Oo0OO_oo.o00oO_o A_0, int A_1, int A_2, int A_3);

		// Token: 0x060026F4 RID: 9972
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiDestroyDeviceInfoList(int A_0);

		// Token: 0x060026F5 RID: 9973
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi, EntryPoint = "SetupDiGetDeviceInterfaceDetailA")]
		private static extern bool <<EMPTY_NAME>>(int A_0, ref Oo0OO_oo.O_OO0__0___Oo A_1, ref Oo0OO_oo.O_0O A_2, int A_3, ref int A_4, int A_5);

		// Token: 0x060026F6 RID: 9974
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi, EntryPoint = "SetupDiEnumDeviceInterfaces")]
		private static extern bool <<EMPTY_NAME>>(int A_0, int A_1, ref Oo0OO_oo.o00oO_o A_2, int A_3, ref Oo0OO_oo.O_OO0__0___Oo A_4);

		// Token: 0x060026F7 RID: 9975
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiGetDeviceInterfaceDetailA(int A_0, ref Oo0OO_oo.O000_O0o__o A_1, ref Oo0OO_oo.O_0O A_2, int A_3, ref int A_4, int A_5);

		// Token: 0x060026F8 RID: 9976
		[DllImport("SetupApi.dll", CharSet = CharSet.Ansi)]
		private static extern bool SetupDiEnumDeviceInterfaces(int A_0, int A_1, ref Oo0OO_oo.o00oO_o A_2, int A_3, ref Oo0OO_oo.O000_O0o__o A_4);

		// Token: 0x060026F9 RID: 9977
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "CreateFileA")]
		private static extern int <<EMPTY_NAME>>(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6);

		// Token: 0x060026FA RID: 9978
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int CloseHandle(int A_0);

		// Token: 0x060026FB RID: 9979
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int GetLastError();

		// Token: 0x060026FC RID: 9980
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "lstrcpyA")]
		private static extern int <<EMPTY_NAME>>(string A_0, ref byte A_1);

		// Token: 0x060026FD RID: 9981
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "CreateSemaphoreA")]
		private static extern int <<EMPTY_NAME>>(int A_0, int A_1, int A_2, string A_3);

		// Token: 0x060026FE RID: 9982
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int WaitForSingleObject(int A_0, int A_1);

		// Token: 0x060026FF RID: 9983
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern int ReleaseSemaphore(int A_0, int A_1, ref int A_2);

		// Token: 0x06002700 RID: 9984
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		internal static extern int lstrlenA(string A_0);

		// Token: 0x06002701 RID: 9985 RVA: 0x0011B390 File Offset: 0x00119590
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

		// Token: 0x06002702 RID: 9986 RVA: 0x0011B40C File Offset: 0x0011960C
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

		// Token: 0x06002703 RID: 9987 RVA: 0x0011B4B8 File Offset: 0x001196B8
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

		// Token: 0x06002704 RID: 9988 RVA: 0x0011B594 File Offset: 0x00119794
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

		// Token: 0x06002705 RID: 9989 RVA: 0x0011B5EC File Offset: 0x001197EC
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

		// Token: 0x06002706 RID: 9990 RVA: 0x0011B63C File Offset: 0x0011983C
		private static byte <<EMPTY_NAME>>(byte A_0)
		{
			byte b = (byte)(Oo0OO_oo.O_O_0_.oo_0O. & 1L);
			byte b2 = (A_0 & 128) / 128;
			byte result = (A_0 & 127) * 2 | b;
			Oo0OO_oo.O_O_0_.oo_0O. = (long)((ulong)b2);
			return result;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x0011B678 File Offset: 0x00119878
		private static byte <<EMPTY_NAME>>(byte A_0)
		{
			byte b = (byte)(Oo0OO_oo.O_O_0_.oo_0O. & 128L);
			byte b2 = (A_0 & 1) * 128;
			byte result = A_0 / 2 | b;
			Oo0OO_oo.O_O_0_.oo_0O. = (long)((ulong)b2);
			return result;
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0011B6B0 File Offset: 0x001198B0
		internal static int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			int result = A_0;
			byte[] array = new byte[4];
			Oo0OO_oo.O.OOO0_0.(array, ref result, 4);
			for (int i = 1; i <= A_1; i++)
			{
				Oo0OO_oo.O_O_0_.oo_0O. = 0L;
				Oo0OO_oo.OO_o_0.0__0.(array[3]);
				int num = 0;
				do
				{
					array[num] = Oo0OO_oo.OO_o_0.0__0.(array[num]);
					num++;
				}
				while (num <= 3);
			}
			Oo0OO_oo.O.OOO0_0.(ref result, array, 4);
			return result;
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x0011B718 File Offset: 0x00119918
		internal static int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			int result = A_0;
			byte[] array = new byte[4];
			Oo0OO_oo.O.OOO0_0.(array, ref result, 4);
			for (int i = 1; i <= A_1; i++)
			{
				Oo0OO_oo.O_O_0_.oo_0O. = 0L;
				Oo0OO_oo.Oo__._0Oo.(array[0]);
				int num = 3;
				do
				{
					array[num] = Oo0OO_oo.Oo__._0Oo.(array[num]);
					num += -1;
				}
				while (num >= 0);
			}
			Oo0OO_oo.O.OOO0_0.(ref result, array, 4);
			return result;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0011B780 File Offset: 0x00119980
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
				long num4 = Oo0OO_oo.O0o_OO._0__OOo.(num4, -1640531527L);
				long num5 = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num2, 4), a_);
				long num6 = Oo0OO_oo.O0o_OO._0__OOo.(num2, num4);
				long num7 = Oo0OO_oo.Oo__._0Oo.(num2, 5);
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num7, a_2);
				long num8 = num5 ^ num6;
				num8 ^= num7;
				num = Oo0OO_oo.O0o_OO._0__OOo.(num, num8);
				long num9 = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num, 4), a_3);
				num6 = Oo0OO_oo.O0o_OO._0__OOo.(num, num4);
				num7 = Oo0OO_oo.Oo__._0Oo.(num, 5);
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num7, a_4);
				num8 = (num9 ^ num6 ^ num7);
				num2 = Oo0OO_oo.O0o_OO._0__OOo.(num2, num8);
			}
			A_0[0] = num;
			A_0[1] = num2;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0011B85C File Offset: 0x00119A5C
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
			long num4 = Oo0OO_oo.o00.00_0_OOOOo.(-1640531527L, 5);
			int num5 = num3;
			for (int i = 1; i <= num5; i++)
			{
				long num6 = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num, 4), a_3);
				long num7 = Oo0OO_oo.O0o_OO._0__OOo.(num, num4);
				long num8 = Oo0OO_oo.Oo__._0Oo.(num, 5);
				num8 = Oo0OO_oo.O0o_OO._0__OOo.(num8, a_4);
				long a_5 = num6 ^ num7 ^ num8;
				num2 = Oo0OO_oo.O0Oo0o.O.(num2, a_5);
				long num9 = Oo0OO_oo.O0o_OO._0__OOo.(Oo0OO_oo.o00.00_0_OOOOo.(num2, 4), a_);
				num7 = Oo0OO_oo.O0o_OO._0__OOo.(num2, num4);
				num8 = Oo0OO_oo.Oo__._0Oo.(num2, 5);
				num8 = Oo0OO_oo.O0o_OO._0__OOo.(num8, a_2);
				a_5 = (num9 ^ num7 ^ num8);
				num = Oo0OO_oo.O0Oo0o.O.(num, a_5);
				num4 = Oo0OO_oo.O0Oo0o.O.(num4, -1640531527L);
			}
			A_0[0] = num;
			A_0[1] = num2;
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0011B944 File Offset: 0x00119B44
		private static void <<EMPTY_NAME>>(long[] A_0, byte[] A_1)
		{
			A_0[0] = 0L;
			A_0[1] = 0L;
			int num = 0;
			do
			{
				A_0[0] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)A_1[num], num * 8) | A_0[0]);
				A_0[1] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)A_1[num + 4], num * 8) | A_0[1]);
				num++;
			}
			while (num <= 3);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x0011B990 File Offset: 0x00119B90
		private static void <<EMPTY_NAME>>(long[] A_0, byte[] A_1)
		{
			int num = 0;
			do
			{
				A_1[num] = (byte)(Oo0OO_oo.o.O_O00o0o_.((int)A_0[0], num * 8) & 255);
				A_1[num + 4] = (byte)(Oo0OO_oo.o.O_O00o0o_.((int)A_0[1], num * 8) & 255);
				num++;
			}
			while (num <= 3);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0011B9D8 File Offset: 0x00119BD8
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
				array[num2] = (long)Oo0OO_oo.Ooo_o_o._0o0.(a_);
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
				A_1[0] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)array[i], i * 8) | A_1[0]);
				A_1[1] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)array[i + 4], i * 8) | A_1[1]);
				A_1[2] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)array[i + 4 + 4], i * 8) | A_1[2]);
				A_1[3] = ((long)Oo0OO_oo.O0_Oo0._oO.((int)array[i + 4 + 4 + 4], i * 8) | A_1[3]);
				i++;
			}
			while (i <= 3);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x0011BA90 File Offset: 0x00119C90
		internal static void <<EMPTY_NAME>>(byte[] A_0, byte[] A_1, string A_2)
		{
			new byte[17];
			long[] a_ = new long[3];
			long[] a_2 = new long[5];
			Oo0OO_oo.o0___0O._0.(A_2, a_2);
			Oo0OO_oo.O0o_OO._0__OOo.(a_, A_0);
			Oo0OO_oo.O00.00o0.(a_, a_2);
			Oo0OO_oo.O0ooo__oOO.o_0.(a_, A_1);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x0011BAD0 File Offset: 0x00119CD0
		internal static void <<EMPTY_NAME>>(byte[] A_0, byte[] A_1, string A_2)
		{
			new byte[17];
			long[] a_ = new long[3];
			long[] a_2 = new long[5];
			Oo0OO_oo.o0___0O._0.(A_2, a_2);
			Oo0OO_oo.O0o_OO._0__OOo.(a_, A_0);
			Oo0OO_oo.O0Oo0o.O.(a_, a_2);
			Oo0OO_oo.O0ooo__oOO.o_0.(a_, A_1);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0011BB10 File Offset: 0x00119D10
		internal static string <<EMPTY_NAME>>(string A_0, string A_1)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			int num = Oo0OO_oo.lstrlenA(A_0) + 1;
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
			Oo0OO_oo.O.OOO0_0.(array3, A_0, num);
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
				Oo0OO_oo.OO.OO0oO0__.(array, array2, A_1);
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

		// Token: 0x06002712 RID: 10002 RVA: 0x0011BBFC File Offset: 0x00119DFC
		internal static string <<EMPTY_NAME>>(string A_0, string A_1)
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
				array3[num2] = (byte)Oo0OO_oo.Ooo_o_o._0o0.(a_);
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
				Oo0OO_oo.o_o0oO000.0_.(array, array2, A_1);
				num2 = 0;
				do
				{
					array4[num2 + i] = array2[num2];
					num2++;
				}
				while (num2 <= 7);
			}
			StringBuilder stringBuilder = new StringBuilder("", num);
			Oo0OO_oo.O.OOO0_0.(stringBuilder, array4, num);
			return stringBuilder.ToString();
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0011BCF8 File Offset: 0x00119EF8
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
				A_1[num3] = (byte)Oo0OO_oo.Ooo_o_o._0o0.(a_);
				num3++;
			}
			return num2;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0011BD5C File Offset: 0x00119F5C
		private static bool <<EMPTY_NAME>>(int A_0, ref byte[] A_1, short A_2)
		{
			byte[] array = new byte[513];
			int a_;
			bool result;
			if (Oo0OO_oo.HidD_GetPreparsedData(A_0, ref a_))
			{
				Oo0OO_oo.OoOo ooOo;
				if (Oo0OO_oo.HidP_GetCaps(a_, ref ooOo) == 0)
				{
					Oo0OO_oo.HidD_FreePreparsedData(a_);
				}
				else
				{
					bool flag = true;
					array[0] = 1;
					bool flag2 = Oo0OO_oo.HidD_GetFeature(A_0, array, (int)ooOo.OO__.0.);
					if (flag2)
					{
						short num = A_2 - 1;
						for (short num2 = 0; num2 <= num; num2 += 1)
						{
							A_1[(int)num2] = array[(int)num2];
						}
					}
					flag = (flag && flag2);
					Oo0OO_oo.HidD_FreePreparsedData(a_);
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0011BDDC File Offset: 0x00119FDC
		private static bool <<EMPTY_NAME>>(int A_0, ref byte[] A_1, short A_2)
		{
			byte[] array = new byte[513];
			int a_;
			bool result;
			if (Oo0OO_oo.HidD_GetPreparsedData(A_0, ref a_))
			{
				Oo0OO_oo.OoOo ooOo;
				if (Oo0OO_oo.HidP_GetCaps(a_, ref ooOo) == 0)
				{
					Oo0OO_oo.HidD_FreePreparsedData(a_);
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
					bool flag2 = Oo0OO_oo.HidD_SetFeature(A_0, array, (int)ooOo.OO__.0.);
					flag = (flag && flag2);
					Oo0OO_oo.HidD_FreePreparsedData(a_);
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0011BE5C File Offset: 0x0011A05C
		private static bool <<EMPTY_NAME>>(short A_0, ref short A_1, ref StringBuilder A_2)
		{
			bool result;
			if (IntPtr.Size == 4)
			{
				result = Oo0OO_oo.o00.00_0_OOOOo.(A_0, ref A_1, ref A_2);
			}
			else
			{
				result = Oo0OO_oo.o0___0O._0.(A_0, ref A_1, ref A_2);
			}
			return result;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0011BE88 File Offset: 0x0011A088
		private static bool <<EMPTY_NAME>>(short A_0, ref short A_1, ref StringBuilder A_2)
		{
			Oo0OO_oo.o00oO_o o00oO_o;
			Oo0OO_oo.HidD_GetHidGuid(ref o00oO_o);
			int num = Oo0OO_oo.SetupDiGetClassDevsA(ref o00oO_o, 0, 0, 18);
			bool result;
			if (num != -1)
			{
				Oo0OO_oo.O000_O0o__o o000_O0o__o;
				o000_O0o__o.o00o.0. = Strings.Len(o000_O0o__o);
				int num2;
				while (Oo0OO_oo.SetupDiEnumDeviceInterfaces(num, 0, ref o00oO_o, num2, ref o000_O0o__o) && Oo0OO_oo.GetLastError() != 259)
				{
					Oo0OO_oo.O_0O o_0O;
					o_0O.o00o.0. = 5;
					int num3;
					if (!Oo0OO_oo.SetupDiGetDeviceInterfaceDetailA(num, ref o000_O0o__o, ref o_0O, 300, ref num3, 0))
					{
						Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
						return result;
					}
					A_2 = new StringBuilder(new string(o_0O.o00o.0.), 260);
					int num4 = Oo0OO_oo.o_o0oO000.0_.(A_2.ToString(), 0, 3, 0, 3, 0, 0);
					if (-1 != num4)
					{
						Oo0OO_oo.OOo ooo;
						if (Oo0OO_oo.HidD_GetAttributes(num4, ref ooo) && (ooo.ooO_O._Ooo. == 13961 & ooo.o_o__.0. == 13961))
						{
							if (A_0 == A_1)
							{
								Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
								Oo0OO_oo.CloseHandle(num4);
								return true;
							}
							A_1 += 1;
						}
						Oo0OO_oo.CloseHandle(num4);
					}
					num2++;
				}
				Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
			}
			return result;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0011BFA0 File Offset: 0x0011A1A0
		private static bool <<EMPTY_NAME>>(short A_0, ref short A_1, ref StringBuilder A_2)
		{
			Oo0OO_oo.o00oO_o o00oO_o;
			Oo0OO_oo.HidD_GetHidGuid(ref o00oO_o);
			int num = Oo0OO_oo.SetupDiGetClassDevsA(ref o00oO_o, 0, 0, 18);
			bool result;
			if (num != -1)
			{
				Oo0OO_oo.O_OO0__0___Oo o_OO0__0___Oo;
				o_OO0__0___Oo.O_0o00_._o. = (long)Strings.Len(o_OO0__0___Oo);
				int num2;
				while (Oo0OO_oo.O0Oo0o.O.(num, 0, ref o00oO_o, num2, ref o_OO0__0___Oo) && Oo0OO_oo.GetLastError() != 259)
				{
					Oo0OO_oo.O_0O o_0O;
					o_0O.o00o.0. = 8;
					int num3;
					if (!Oo0OO_oo.O0Oo0o.O.(num, ref o_OO0__0___Oo, ref o_0O, 300, ref num3, 0))
					{
						Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
						return result;
					}
					A_2 = new StringBuilder(new string(o_0O.o00o.0.), 260);
					int num4 = Oo0OO_oo.o_o0oO000.0_.(A_2.ToString(), 0, 3, 0, 3, 0, 0);
					if (-1 != num4)
					{
						Oo0OO_oo.OOo ooo;
						if (Oo0OO_oo.HidD_GetAttributes(num4, ref ooo) && (ooo.ooO_O._Ooo. == 13961 & ooo.o_o__.0. == 13961))
						{
							if (A_0 == A_1)
							{
								Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
								Oo0OO_oo.CloseHandle(num4);
								return true;
							}
							A_1 += 1;
						}
						Oo0OO_oo.CloseHandle(num4);
					}
					num2++;
				}
				Oo0OO_oo.SetupDiDestroyDeviceInfoList(num);
			}
			return result;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x0011C0B8 File Offset: 0x0011A2B8
		private static int <<EMPTY_NAME>>(short A_0, ref string A_1)
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			short num;
			int result;
			if (!Oo0OO_oo.Ooo_o_o._0o0.(A_0, ref num, ref stringBuilder))
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

		// Token: 0x0600271A RID: 10010 RVA: 0x0011C0F4 File Offset: 0x0011A2F4
		private static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			short num = A_0;
			while (num <= 256)
			{
				short num2;
				int result;
				if (!Oo0OO_oo.Ooo_o_o._0o0.(num, ref num2, ref stringBuilder))
				{
					result = -92;
				}
				else
				{
					short num3 = (short)Oo0OO_oo.O_O_O0oO.o_Oo.(A_1, A_3);
					if (num3 != 0)
					{
						result = (int)num3;
					}
					else
					{
						int num4;
						num3 = (short)Oo0OO_oo.OO_o_0.0__0.(ref num4, A_3);
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

		// Token: 0x0600271B RID: 10011 RVA: 0x0011C174 File Offset: 0x0011A374
		private static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			short num = A_0;
			while (num <= 256)
			{
				short num2;
				int result;
				if (!Oo0OO_oo.Ooo_o_o._0o0.(num, ref num2, ref stringBuilder))
				{
					result = -92;
				}
				else
				{
					short num3 = (short)Oo0OO_oo.o_OOoo.O_0o_O.(A_1, A_3);
					if (num3 != 0)
					{
						result = (int)num3;
					}
					else
					{
						int num4;
						num3 = (short)Oo0OO_oo.OO_o_0.0__0.(ref num4, A_3);
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

		// Token: 0x0600271C RID: 10012 RVA: 0x0011C1F4 File Offset: 0x0011A3F4
		private static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			if (Strings.Len(A_1) < 1)
			{
				StringBuilder stringBuilder = new StringBuilder("", 260);
				short num;
				if (!Oo0OO_oo.Ooo_o_o._0o0.(0, ref num, ref stringBuilder))
				{
					return -92;
				}
				A_0 = Oo0OO_oo.o_o0oO000.0_.(stringBuilder.ToString(), -1073741824, 3, 0, 3, 128, 0);
				if (A_0 == -1)
				{
					return -92;
				}
			}
			else
			{
				A_0 = Oo0OO_oo.o_o0oO000.0_.(A_1, -1073741824, 3, 0, 3, 128, 0);
				if (A_0 == -1)
				{
					return -92;
				}
			}
			return 0;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0011C274 File Offset: 0x0011A474
		private static int <<EMPTY_NAME>>(ref byte A_0, ref byte A_1, ref byte A_2, ref byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array, 5))
			{
				Oo0OO_oo.CloseHandle(a_);
				result = -93;
			}
			else
			{
				Oo0OO_oo.CloseHandle(a_);
				A_0 = array[0];
				A_1 = array[1];
				A_2 = array[2];
				A_3 = array[3];
				result = 0;
			}
			return result;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0011C2D0 File Offset: 0x0011A4D0
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 5))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0011C32C File Offset: 0x0011A52C
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 5))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0011C388 File Offset: 0x0011A588
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 10;
				array[2] = A_0;
				array[3] = A_1;
				array[4] = A_2;
				array[5] = A_3;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 5))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0011C3E4 File Offset: 0x0011A5E4
		private static int <<EMPTY_NAME>>(byte A_0, byte A_1, byte A_2, byte A_3, string A_4)
		{
			byte[] array = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 11;
				array[2] = A_0;
				array[3] = A_1;
				array[4] = A_2;
				array[5] = A_3;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 5))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x0011C440 File Offset: 0x0011A640
		private static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_1) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 1;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 1))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 1))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					A_0 = (short)array2[0];
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x0011C4B0 File Offset: 0x0011A6B0
		private static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_1) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 5;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 1))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 1))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
					A_0 = (short)array2[0];
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x0011C520 File Offset: 0x0011A720
		private static int <<EMPTY_NAME>>(ref int A_0, ref int A_1, string A_2)
		{
			int[] array = new int[9];
			byte[] array2 = new byte[26];
			byte[] array3 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_2) != 0)
			{
				result = -92;
			}
			else
			{
				array2[1] = 2;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array2, 1))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array3, 8))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x06002725 RID: 10021 RVA: 0x0011C600 File Offset: 0x0011A800
		private static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, ref byte[] A_3, string A_4, short A_5)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_1 > 2031 | A_1 < 0)
			{
				result = -81;
			}
			else if (A_2 > 16)
			{
				result = -87;
			}
			else if (A_2 + A_1 > 2031)
			{
				result = -88;
			}
			else
			{
				short num = (short)(A_1 >> 8) * 2;
				short num2 = A_1 & 255;
				int a_;
				if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 16;
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
					if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 13))
					{
						Oo0OO_oo.CloseHandle(a_);
						result = -93;
					}
					else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, A_2 + 1))
					{
						Oo0OO_oo.CloseHandle(a_);
						result = -94;
					}
					else
					{
						Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x06002726 RID: 10022 RVA: 0x0011C718 File Offset: 0x0011A918
		private static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, ref byte[] A_3, string A_4, short A_5)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int result;
			if (A_2 > 8)
			{
				result = -87;
			}
			else if (A_1 + A_2 - 1 > 2048 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				short num = (short)(A_1 >> 8) * 2;
				short num2 = A_1 & 255;
				int a_;
				if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_4) != 0)
				{
					result = -92;
				}
				else
				{
					array[1] = 17;
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
					if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 13 + A_2))
					{
						Oo0OO_oo.CloseHandle(a_);
						result = -93;
					}
					else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 2))
					{
						Oo0OO_oo.CloseHandle(a_);
						result = -94;
					}
					else
					{
						Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x06002727 RID: 10023 RVA: 0x0011C820 File Offset: 0x0011AA20
		private static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2, short A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_2) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 9))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 9))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x06002728 RID: 10024 RVA: 0x0011C8C8 File Offset: 0x0011AAC8
		private static int <<EMPTY_NAME>>(ref byte[] A_0, byte A_1, string A_2, short A_3)
		{
			byte[] array = new byte[31];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_2) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 11))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 2))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -94;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x06002729 RID: 10025 RVA: 0x0011C95C File Offset: 0x0011AB5C
		private static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2, short A_3)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_2) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 9))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 9))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x0600272A RID: 10026 RVA: 0x0011CA04 File Offset: 0x0011AC04
		private static int <<EMPTY_NAME>>(ref byte[] A_0, byte A_1, string A_2, short A_3)
		{
			byte[] array = new byte[31];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_2) != 0)
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
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 11))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 2))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -94;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x0600272B RID: 10027 RVA: 0x0011CA98 File Offset: 0x0011AC98
		private static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			byte b;
			byte b2;
			byte b3;
			byte b4;
			int result = Oo0OO_oo.o0_0__O00._O_o.(ref b, ref b2, ref b3, ref b4, A_1);
			int num = (int)b;
			int num2 = (int)b2;
			int num3 = (int)b3;
			int num4 = (int)b4;
			A_0 = (num | num2 << 8 | num3 << 16 | num4 << 24);
			return result;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0011CAD4 File Offset: 0x0011ACD4
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return Oo0OO_oo.oO0_OO0.O0.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0011CB18 File Offset: 0x0011AD18
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return Oo0OO_oo.o0____o.0oO.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x0011CB5C File Offset: 0x0011AD5C
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return Oo0OO_oo.O.__00O0.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0011CBA0 File Offset: 0x0011ADA0
		private static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			byte a_ = (byte)(A_0 & 255);
			byte a_2 = (byte)(A_0 >> 8 & 255);
			byte a_3 = (byte)(A_0 >> 16 & 255);
			byte a_4 = (byte)(A_0 >> 24 & 255);
			return Oo0OO_oo.o0_0__O00._O_o.(a_, a_2, a_3, a_4, A_1);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0011CBE4 File Offset: 0x0011ADE4
		internal static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.ooooooOo.O.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0011CC24 File Offset: 0x0011AE24
		internal static int <<EMPTY_NAME>>(ref short A_0, string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o_O.0OOO_ooO.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0011CC64 File Offset: 0x0011AE64
		internal static int <<EMPTY_NAME>>(ref int A_0, ref int A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o____OOO.ooo.(ref A_0, ref A_1, A_2);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0011CCA4 File Offset: 0x0011AEA4
		internal static int <<EMPTY_NAME>>(ref int A_0, string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.OO_o_0.0__0.(ref A_0, A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0011CCE4 File Offset: 0x0011AEE4
		internal static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.O_O_O0oO.o_Oo.(A_0, A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0011CD24 File Offset: 0x0011AF24
		internal static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 + A_2 - 1 > 2031 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, ref array);
				int num = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
				Oo0OO_oo.WaitForSingleObject(num, -1);
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
						num6 = Oo0OO_oo.o.O_O00o0o_.(ref A_0, A_1 + num5 * 8, 8, ref array, A_5, 8 * num5);
						if (num6 != 0)
						{
							int a_ = num;
							int a_2 = 1;
							num7 = 0;
							Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num7);
							Oo0OO_oo.CloseHandle(num);
							return num6;
						}
					}
					if (num3 - 8 * num5 > 0)
					{
						num6 = Oo0OO_oo.o.O_O00o0o_.(ref A_0, A_1 + num5 * 8, num3 - num5 * 8, ref array, A_5, 8 * num5);
						if (num6 != 0)
						{
							int a_3 = num;
							int a_4 = 1;
							num7 = 0;
							Oo0OO_oo.ReleaseSemaphore(a_3, a_4, ref num7);
							Oo0OO_oo.CloseHandle(num);
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
						num6 = Oo0OO_oo.o.O_O00o0o_.(ref A_0, A_1 + num5 * 8, 8, ref array, A_5, num3 + 8 * num5);
						if (num6 != 0)
						{
							int a_5 = num;
							int a_6 = 1;
							num7 = 0;
							Oo0OO_oo.ReleaseSemaphore(a_5, a_6, ref num7);
							Oo0OO_oo.CloseHandle(num);
							return num6;
						}
					}
					if (A_2 - 8 * num5 > 0)
					{
						num6 = Oo0OO_oo.o.O_O00o0o_.(ref A_0, A_1 + num5 * 8, A_2 - num5 * 8, ref array, A_5, num3 + 8 * num5);
						if (num6 != 0)
						{
							int a_7 = num;
							int a_8 = 1;
							num7 = 0;
							Oo0OO_oo.ReleaseSemaphore(a_7, a_8, ref num7);
							Oo0OO_oo.CloseHandle(num);
							return num6;
						}
					}
				}
				int a_9 = num;
				int a_10 = 1;
				num7 = 0;
				Oo0OO_oo.ReleaseSemaphore(a_9, a_10, ref num7);
				Oo0OO_oo.CloseHandle(num);
				result = num6;
			}
			return result;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0011CEF0 File Offset: 0x0011B0F0
		internal static int <<EMPTY_NAME>>(ref byte[] A_0, short A_1, short A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 + A_2 - 1 > 2031 | A_1 < 0)
			{
				result = -81;
			}
			else
			{
				Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, ref array);
				int num = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
				Oo0OO_oo.WaitForSingleObject(num, -1);
				short num2 = A_2 / 16 - 1;
				short num3;
				int num4;
				int num5;
				for (num3 = 0; num3 <= num2; num3 += 1)
				{
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(ref A_0, A_1 + num3 * 16, 16, ref array, A_5, num3 * 16);
					if (num4 != 0)
					{
						int a_ = num;
						int a_2 = 1;
						num5 = 0;
						Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num5);
						Oo0OO_oo.CloseHandle(num);
						return num4;
					}
				}
				if (A_2 - 16 * num3 > 0)
				{
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(ref A_0, A_1 + num3 * 16, A_2 - 16 * num3, ref array, A_5, 16 * num3);
					if (num4 != 0)
					{
						int a_3 = num;
						int a_4 = 1;
						num5 = 0;
						Oo0OO_oo.ReleaseSemaphore(a_3, a_4, ref num5);
						Oo0OO_oo.CloseHandle(num);
						return num4;
					}
				}
				int a_5 = num;
				int a_6 = 1;
				num5 = 0;
				Oo0OO_oo.ReleaseSemaphore(a_5, a_6, ref num5);
				Oo0OO_oo.CloseHandle(num);
				result = num4;
			}
			return result;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0011CFF0 File Offset: 0x0011B1F0
		internal static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o.0_0OOoO.(A_0, A_1, A_2, ref A_3);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0011D030 File Offset: 0x0011B230
		internal static int <<EMPTY_NAME>>(short A_0, int A_1, int A_2, ref string A_3)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o0_.____Oo00.(A_0, A_1, A_2, ref A_3);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x0011D070 File Offset: 0x0011B270
		internal static int <<EMPTY_NAME>>(short A_0, ref string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o____OOO.ooo.(A_0, ref A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0011D0B0 File Offset: 0x0011B2B0
		internal static int <<EMPTY_NAME>>(int A_0, string A_1)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o_oO0._0O0O_oO.(A_0, A_1);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0011D0F0 File Offset: 0x0011B2F0
		private static string <<EMPTY_NAME>>(string A_0)
		{
			for (short num = (short)Strings.Len(A_0); num <= 7; num += 1)
			{
				A_0 = "0" + A_0;
			}
			return A_0;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0011D120 File Offset: 0x0011B320
		private static void <<EMPTY_NAME>>(string A_0, string A_1, ref byte[] A_2)
		{
			A_0 = Oo0OO_oo.O.OOO0_0.(A_0);
			A_1 = Oo0OO_oo.O.OOO0_0.(A_1);
			short num = 0;
			do
			{
				A_2[(int)num] = (byte)Oo0OO_oo.Ooo_o_o._0o0.(Strings.Mid(A_0, (int)(1 + num * 2), 2));
				num += 1;
			}
			while (num <= 3);
			num = 0;
			do
			{
				A_2[(int)(num + 4)] = (byte)Oo0OO_oo.Ooo_o_o._0o0.(Strings.Mid(A_1, (int)(1 + num * 2), 2));
				num += 1;
			}
			while (num <= 3);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0011D184 File Offset: 0x0011B384
		internal static int <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			Oo0OO_oo.O0ooo__oOO.o_0.(A_0, A_1, ref array);
			Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, ref array2);
			short a_ = 2032;
			int a_2 = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_2, -1);
			int result = Oo0OO_oo.o.O_O00o0o_.(ref array2, a_, 8, ref array, A_4, 0);
			int a_3 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num);
			Oo0OO_oo.CloseHandle(a_2);
			return result;
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0011D1F4 File Offset: 0x0011B3F4
		internal static int <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			byte[] array2 = new byte[9];
			Oo0OO_oo.O0ooo__oOO.o_0.(A_0, A_1, ref array);
			Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, ref array2);
			short a_ = 2040;
			int a_2 = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_2, -1);
			int result = Oo0OO_oo.o.O_O00o0o_.(ref array2, a_, 8, ref array, A_4, 0);
			int a_3 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num);
			Oo0OO_oo.CloseHandle(a_2);
			return result;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0011D264 File Offset: 0x0011B464
		internal static int <<EMPTY_NAME>>(string A_0, short A_1, string A_2, string A_3, string A_4)
		{
			byte[] array = new byte[9];
			int result;
			if (A_1 < 0)
			{
				result = -81;
			}
			else
			{
				Oo0OO_oo.O0ooo__oOO.o_0.(A_2, A_3, ref array);
				short num = (short)Oo0OO_oo.lstrlenA(A_0);
				byte[] a_ = new byte[(int)(num + 1)];
				Oo0OO_oo.O.OOO0_0.(a_, A_0, (int)num);
				if (A_1 + num > 2031)
				{
					result = -47;
				}
				else
				{
					int num2 = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
					Oo0OO_oo.WaitForSingleObject(num2, -1);
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
							num7 = Oo0OO_oo.o.O_O00o0o_.(ref a_, A_1 + num6 * 8, 8, ref array, A_4, num6 * 8);
							if (num7 != 0)
							{
								int a_2 = num2;
								int a_3 = 1;
								num8 = 0;
								Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num8);
								Oo0OO_oo.CloseHandle(num2);
								return num7;
							}
						}
						if (num4 - 8 * num6 > 0)
						{
							num7 = Oo0OO_oo.o.O_O00o0o_.(ref a_, A_1 + num6 * 8, num4 - num6 * 8, ref array, A_4, 8 * num6);
							if (num7 != 0)
							{
								int a_4 = num2;
								int a_5 = 1;
								num8 = 0;
								Oo0OO_oo.ReleaseSemaphore(a_4, a_5, ref num8);
								Oo0OO_oo.CloseHandle(num2);
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
							num7 = Oo0OO_oo.o.O_O00o0o_.(ref a_, A_1 + num6 * 8, 8, ref array, A_4, num4 + num6 * 8);
							if (num7 != 0)
							{
								int a_6 = num2;
								int a_7 = 1;
								num8 = 0;
								Oo0OO_oo.ReleaseSemaphore(a_6, a_7, ref num8);
								Oo0OO_oo.CloseHandle(num2);
								return num7;
							}
						}
						if (num - 8 * num6 > 0)
						{
							num7 = Oo0OO_oo.o.O_O00o0o_.(ref a_, A_1 + num6 * 8, num - num6 * 8, ref array, A_4, num4 + 8 * num6);
							if (num7 != 0)
							{
								int a_8 = num2;
								int a_9 = 1;
								num8 = 0;
								Oo0OO_oo.ReleaseSemaphore(a_8, a_9, ref num8);
								Oo0OO_oo.CloseHandle(num2);
								return num7;
							}
						}
					}
					int a_10 = num2;
					int a_11 = 1;
					num8 = 0;
					Oo0OO_oo.ReleaseSemaphore(a_10, a_11, ref num8);
					Oo0OO_oo.CloseHandle(num2);
					result = num7;
				}
			}
			return result;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0011D45C File Offset: 0x0011B65C
		internal static short <<EMPTY_NAME>>(ref string A_0, short A_1, int A_2, string A_3, string A_4, string A_5)
		{
			byte[] array = new byte[9];
			byte[] a_ = new byte[A_2 + 1];
			Oo0OO_oo.O0ooo__oOO.o_0.(A_3, A_4, ref array);
			short result;
			if (A_1 < 0)
			{
				result = -81;
			}
			else if ((short)((int)A_1 + A_2) > 2031)
			{
				result = -47;
			}
			else
			{
				int num = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
				Oo0OO_oo.WaitForSingleObject(num, -1);
				short num2 = (short)(A_2 / 16 - 1);
				short num3;
				int num4;
				int num5;
				for (num3 = 0; num3 <= num2; num3 += 1)
				{
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(ref a_, A_1 + num3 * 16, 16, ref array, A_5, num3 * 16);
					if (num4 != 0)
					{
						int a_2 = num;
						int a_3 = 1;
						num5 = 0;
						Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num5);
						Oo0OO_oo.CloseHandle(num);
						return (short)num4;
					}
				}
				if (A_2 - (int)(16 * num3) > 0)
				{
					num4 = Oo0OO_oo.o.o0OO0___OOOo.(ref a_, A_1 + num3 * 16, (short)(A_2 - (int)(16 * num3)), ref array, A_5, 16 * num3);
					if (num4 != 0)
					{
						int a_4 = num;
						int a_5 = 1;
						num5 = 0;
						Oo0OO_oo.ReleaseSemaphore(a_4, a_5, ref num5);
						Oo0OO_oo.CloseHandle(num);
						return (short)num4;
					}
				}
				int a_6 = num;
				int a_7 = 1;
				num5 = 0;
				Oo0OO_oo.ReleaseSemaphore(a_6, a_7, ref num5);
				Oo0OO_oo.CloseHandle(num);
				StringBuilder stringBuilder = new StringBuilder("", A_2);
				short num6 = (short)A_2;
				for (num3 = 1; num3 <= num6; num3 += 1)
				{
					stringBuilder.Append(0);
				}
				Oo0OO_oo.O.OOO0_0.(stringBuilder, a_, A_2);
				A_0 = stringBuilder.ToString();
				result = (short)num4;
			}
			return result;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0011D5B0 File Offset: 0x0011B7B0
		internal static int <<EMPTY_NAME>>(string A_0, string A_1)
		{
			new byte[9];
			byte[] array;
			Oo0OO_oo.o0___0O._0.(A_0, ref array);
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.O.__00O0.(ref array, 0, A_1, 8);
			if (num == 0)
			{
				num = Oo0OO_oo.O.__00O0.(ref array, 1, A_1, 0);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0011D610 File Offset: 0x0011B810
		internal static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o____OOO.ooo.(ref A_0, ref A_1, A_2, 0);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0011D650 File Offset: 0x0011B850
		internal static int <<EMPTY_NAME>>(string A_0, ref string A_1, string A_2)
		{
			int num = Oo0OO_oo.lstrlenA(A_0) + 1;
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
			Oo0OO_oo.O.OOO0_0.(array, A_0, a_);
			array.CopyTo(array2, 0);
			int num2 = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(num2, -1);
			int num3 = num - 8;
			int num4;
			for (int i = 0; i <= num3; i += 8)
			{
				num4 = Oo0OO_oo.o____OOO.ooo.(ref array, ref array2, A_2, (short)i);
				if (num4 != 0)
				{
					break;
				}
			}
			int a_2 = num2;
			int a_3 = 1;
			int num5 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num5);
			Oo0OO_oo.CloseHandle(num2);
			A_1 = "";
			num5 = num - 1;
			for (int i = 0; i <= num5; i++)
			{
				A_1 += array2[i].ToString("X2");
			}
			return num4;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0011D724 File Offset: 0x0011B924
		internal static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.O_O_O0oO.o_Oo.(A_0, A_2);
			if (num == 0)
			{
				num = Oo0OO_oo.OO_o_0.0__0.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0011D76C File Offset: 0x0011B96C
		internal static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.o_oO0._0O0O_oO.(A_0, A_2);
			if (num == 0)
			{
				num = Oo0OO_oo.OO_o_0.0__0.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0011D7B4 File Offset: 0x0011B9B4
		internal static int <<EMPTY_NAME>>(string A_0, string A_1)
		{
			new byte[9];
			byte[] array;
			Oo0OO_oo.o0___0O._0.(A_0, ref array);
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.o0_0__O00._O_o.(ref array, 0, A_1, 8);
			if (num == 0)
			{
				num = Oo0OO_oo.o0_0__O00._O_o.(ref array, 1, A_1, 0);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0011D814 File Offset: 0x0011BA14
		internal static int <<EMPTY_NAME>>(ref byte[] A_0, ref byte[] A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.O0ooo__oOO.o_0.(ref A_0, ref A_1, A_2, 0);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0011D854 File Offset: 0x0011BA54
		internal static int <<EMPTY_NAME>>(string A_0, ref string A_1, string A_2)
		{
			int num = Oo0OO_oo.lstrlenA(A_0) + 1;
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
			Oo0OO_oo.O.OOO0_0.(array, A_0, a_);
			array.CopyTo(array2, 0);
			int num2 = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(num2, -1);
			int num3 = num - 8;
			int num4;
			for (int i = 0; i <= num3; i += 8)
			{
				num4 = Oo0OO_oo.O0ooo__oOO.o_0.(ref array, ref array2, A_2, (short)i);
				if (num4 != 0)
				{
					break;
				}
			}
			int a_2 = num2;
			int a_3 = 1;
			int num5 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_2, a_3, ref num5);
			Oo0OO_oo.CloseHandle(num2);
			A_1 = "";
			num5 = num - 1;
			for (int i = 0; i <= num5; i++)
			{
				A_1 += array2[i].ToString("X2");
			}
			return num4;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0011D928 File Offset: 0x0011BB28
		internal static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.o_OOoo.O_0o_O.(A_0, A_2);
			if (num == 0)
			{
				num = Oo0OO_oo.OO_o_0.0__0.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0011D970 File Offset: 0x0011BB70
		internal static int <<EMPTY_NAME>>(int A_0, ref int A_1, string A_2)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int num = Oo0OO_oo.Ooo0OOo.oO0oO.(A_0, A_2);
			if (num == 0)
			{
				num = Oo0OO_oo.OO_o_0.0__0.(ref A_1, A_2);
			}
			int a_2 = 1;
			int num2 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num2);
			Oo0OO_oo.CloseHandle(a_);
			return num;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0011D9B8 File Offset: 0x0011BBB8
		internal static int <<EMPTY_NAME>>(string A_0)
		{
			long num = (long)Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject((int)num, -1);
			int num3;
			short num2 = (short)num3;
			int num4 = Oo0OO_oo.ooooooOo.O.(ref num2, A_0);
			num3 = (int)num2;
			int num5 = num4;
			if (num5 == 0)
			{
				num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0);
				if (num5 == 0)
				{
					num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0);
					if (num5 == 0)
					{
						num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0);
						if (num5 == 0)
						{
							num5 = Oo0OO_oo.o0_0__O00._O_o.(A_0);
						}
					}
				}
			}
			int a_ = (int)num;
			int a_2 = 1;
			int num6 = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num6);
			Oo0OO_oo.CloseHandle((int)num);
			return num5;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0011DA2C File Offset: 0x0011BC2C
		private static int <<EMPTY_NAME>>(string A_0)
		{
			byte[] array = new byte[26];
			byte[] array2 = new byte[26];
			int a_;
			int result;
			if (Oo0OO_oo.oo000oOOooo.oO.(ref a_, A_0) != 0)
			{
				result = -92;
			}
			else
			{
				array[1] = 32;
				if (!Oo0OO_oo.Oo__._0Oo.(a_, ref array, 2))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else if (!Oo0OO_oo.o00.00_0_OOOOo.(a_, ref array2, 2))
				{
					Oo0OO_oo.CloseHandle(a_);
					result = -93;
				}
				else
				{
					Oo0OO_oo.CloseHandle(a_);
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

		// Token: 0x0600274D RID: 10061 RVA: 0x0011DAA0 File Offset: 0x0011BCA0
		internal static int a8(short start, int in_data, int verf_data, ref string OutPath)
		{
			int a_ = Oo0OO_oo.o_o0oO000.0_.(0, 1, 1, Oo0OO_oo.O0ooo__oOO.o_0.());
			Oo0OO_oo.WaitForSingleObject(a_, -1);
			int result = Oo0OO_oo.o.0_0OOoO.(start, in_data, verf_data, ref OutPath);
			int a_2 = 1;
			int num = 0;
			Oo0OO_oo.ReleaseSemaphore(a_, a_2, ref num);
			Oo0OO_oo.CloseHandle(a_);
			return result;
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0011DAE0 File Offset: 0x0011BCE0
		private static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[11];
			array[0] = 121;
			array[1] = 116;
			array[2] = 100;
			array[3] = 103;
			array[4] = 121;
			array[5] = 122;
			array[6] = 116;
			array[7] = 95;
			array[8] = 54;
			array[9] = 100;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x04000FFD RID: 4093
		private const short <<EMPTY_NAME>> = 13961;

		// Token: 0x04000FFE RID: 4094
		private const short <<EMPTY_NAME>> = 13961;

		// Token: 0x04000FFF RID: 4095
		private const short <<EMPTY_NAME>> = 2;

		// Token: 0x04001000 RID: 4096
		private const short <<EMPTY_NAME>> = 16;

		// Token: 0x04001001 RID: 4097
		private const short <<EMPTY_NAME>> = -1;

		// Token: 0x04001002 RID: 4098
		private const short <<EMPTY_NAME>> = 259;

		// Token: 0x04001003 RID: 4099
		private const int <<EMPTY_NAME>> = -2147483648;

		// Token: 0x04001004 RID: 4100
		private const int <<EMPTY_NAME>> = 1073741824;

		// Token: 0x04001005 RID: 4101
		private const short <<EMPTY_NAME>> = 1;

		// Token: 0x04001006 RID: 4102
		private const short <<EMPTY_NAME>> = 2;

		// Token: 0x04001007 RID: 4103
		private const short <<EMPTY_NAME>> = 3;

		// Token: 0x04001008 RID: 4104
		private const short <<EMPTY_NAME>> = 128;

		// Token: 0x04001009 RID: 4105
		private const short <<EMPTY_NAME>> = -1;

		// Token: 0x0400100A RID: 4106
		private const short <<EMPTY_NAME>> = 2031;

		// Token: 0x0400100B RID: 4107
		private const long <<EMPTY_NAME>> = 4294967296L;

		// Token: 0x0400100C RID: 4108
		private const long <<EMPTY_NAME>> = 2147483647L;

		// Token: 0x0400100D RID: 4109
		private const long <<EMPTY_NAME>> = 2147483648L;

		// Token: 0x0400100E RID: 4110
		private const long <<EMPTY_NAME>> = -1640531527L;

		// Token: 0x0400100F RID: 4111
		private static long <<EMPTY_NAME>>;

		// Token: 0x020002C7 RID: 711
		private struct o00oO_o
		{
			// Token: 0x04001010 RID: 4112
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public byte[] <<EMPTY_NAME>>;

			// Token: 0x04001011 RID: 4113
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] <<EMPTY_NAME>>;

			// Token: 0x04001012 RID: 4114
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] <<EMPTY_NAME>>;

			// Token: 0x04001013 RID: 4115
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] <<EMPTY_NAME>>;
		}

		// Token: 0x020002C8 RID: 712
		private struct O000_O0o__o
		{
			// Token: 0x04001014 RID: 4116
			public int <<EMPTY_NAME>>;

			// Token: 0x04001015 RID: 4117
			public Oo0OO_oo.o00oO_o <<EMPTY_NAME>>;

			// Token: 0x04001016 RID: 4118
			public int <<EMPTY_NAME>>;

			// Token: 0x04001017 RID: 4119
			public int <<EMPTY_NAME>>;
		}

		// Token: 0x020002C9 RID: 713
		private struct O_OO0__0___Oo
		{
			// Token: 0x04001018 RID: 4120
			public long <<EMPTY_NAME>>;

			// Token: 0x04001019 RID: 4121
			public Oo0OO_oo.o00oO_o <<EMPTY_NAME>>;

			// Token: 0x0400101A RID: 4122
			public int <<EMPTY_NAME>>;

			// Token: 0x0400101B RID: 4123
			public int <<EMPTY_NAME>>;
		}

		// Token: 0x020002CA RID: 714
		private struct oO0OOoo0O
		{
			// Token: 0x0400101C RID: 4124
			public int <<EMPTY_NAME>>;

			// Token: 0x0400101D RID: 4125
			public Oo0OO_oo.o00oO_o <<EMPTY_NAME>>;

			// Token: 0x0400101E RID: 4126
			public int <<EMPTY_NAME>>;

			// Token: 0x0400101F RID: 4127
			public int <<EMPTY_NAME>>;
		}

		// Token: 0x020002CB RID: 715
		private struct O_0O
		{
			// Token: 0x04001020 RID: 4128
			public int <<EMPTY_NAME>>;

			// Token: 0x04001021 RID: 4129
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
			public char[] <<EMPTY_NAME>>;
		}

		// Token: 0x020002CC RID: 716
		private struct OOo
		{
			// Token: 0x04001022 RID: 4130
			public int <<EMPTY_NAME>>;

			// Token: 0x04001023 RID: 4131
			public short <<EMPTY_NAME>>;

			// Token: 0x04001024 RID: 4132
			public short <<EMPTY_NAME>>;

			// Token: 0x04001025 RID: 4133
			public short <<EMPTY_NAME>>;
		}

		// Token: 0x020002CD RID: 717
		private struct OoOo
		{
			// Token: 0x04001026 RID: 4134
			public short <<EMPTY_NAME>>;

			// Token: 0x04001027 RID: 4135
			public short <<EMPTY_NAME>>;

			// Token: 0x04001028 RID: 4136
			public short <<EMPTY_NAME>>;

			// Token: 0x04001029 RID: 4137
			public short <<EMPTY_NAME>>;

			// Token: 0x0400102A RID: 4138
			public short <<EMPTY_NAME>>;

			// Token: 0x0400102B RID: 4139
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public short[] <<EMPTY_NAME>>;

			// Token: 0x0400102C RID: 4140
			public short <<EMPTY_NAME>>;

			// Token: 0x0400102D RID: 4141
			public short <<EMPTY_NAME>>;

			// Token: 0x0400102E RID: 4142
			public short <<EMPTY_NAME>>;

			// Token: 0x0400102F RID: 4143
			public short <<EMPTY_NAME>>;

			// Token: 0x04001030 RID: 4144
			public short <<EMPTY_NAME>>;

			// Token: 0x04001031 RID: 4145
			public short <<EMPTY_NAME>>;

			// Token: 0x04001032 RID: 4146
			public short <<EMPTY_NAME>>;

			// Token: 0x04001033 RID: 4147
			public short <<EMPTY_NAME>>;

			// Token: 0x04001034 RID: 4148
			public short <<EMPTY_NAME>>;

			// Token: 0x04001035 RID: 4149
			public short <<EMPTY_NAME>>;
		}
	}
}
