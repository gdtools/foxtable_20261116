using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002CF RID: 719
	[StandardModule]
	[oO0oooo("2675")]
	public sealed class UKey
	{
		/// <summary>
		/// 启动UKey
		/// </summary>
		// Token: 0x06002783 RID: 10115 RVA: 0x0011EEC0 File Offset: 0x0011D0C0
		[oO0oooo("2659")]
		public static bool Start()
		{
			if (OoO0o.o.0_0O.(0, ref UKey.o_o0_0.o_o_0.) == 0)
			{
				string uid = UKey.UID;
				string a_ = "";
				OoO0o.O_O0O_0.OO0_.(ref a_, 401, 56, "ABCDEF09", "9876EFCD", UKey.o_o0_0.o_o_0.);
				if (Operators.CompareString(O00.oO_.0o_oo_0O_.(a_, "ukey", "fox"), UKey.Encrypt1(uid).Substring(0, 16), true) == 0)
				{
					return true;
				}
			}
			UKey.o_o0_0.o_o_0. = "";
			return false;
		}

		/// <summary>
		/// 加密整数，加密后的整数可以用DecInt函数解密还原
		/// </summary>
		/// <param name="val">要加密的整数</param>
		// Token: 0x06002784 RID: 10116 RVA: 0x0011EF3C File Offset: 0x0011D13C
		public static int EncInt(int val)
		{
			int num;
			int result;
			if (OoO0o.OO00__O.O0.(val, ref num, UKey.o_o0_0.o_o_0.) != 0)
			{
				result = 0;
			}
			else
			{
				result = num;
			}
			return result;
		}

		/// <summary>
		/// 解密用EncInt函数加密后的整数
		/// </summary>
		/// <param name="val">要解密的整数</param>
		// Token: 0x06002785 RID: 10117 RVA: 0x0011EF60 File Offset: 0x0011D160
		public static int DecInt(int val)
		{
			int num;
			int result;
			if (OoO0o.oo_o_oo._0O.(val, ref num, UKey.o_o0_0.o_o_0.) != 0)
			{
				result = 0;
			}
			else
			{
				result = num;
			}
			return result;
		}

		/// <summary>
		/// 固化加密函数，对字符串进行加密，加密后的内容无法解密还原
		/// </summary>
		/// <param name="InString">要加密的字符串</param>
		// Token: 0x06002786 RID: 10118 RVA: 0x0011EF84 File Offset: 0x0011D184
		[oO0oooo("2660")]
		public static string Encrypt1(string InString)
		{
			string text = "";
			string result;
			if (OoO0o.o.0_0O.(InString, ref text, UKey.o_o0_0.o_o_0.) == 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
			return result;
		}

		/// <summary>
		/// 用户加密函数，对字符串进行加密，加密后的内容无法解密还原
		/// </summary>
		/// <param name="InString">要加密的字符串</param>
		// Token: 0x06002787 RID: 10119 RVA: 0x0011EFB4 File Offset: 0x0011D1B4
		[oO0oooo("2661")]
		public static string Encrypt2(string InString)
		{
			string text = "";
			string result;
			if (OoO0o.oOO.0O_0oO00_o.(InString, ref text, UKey.o_o0_0.o_o_0.) != 0)
			{
				result = "";
			}
			else
			{
				result = text;
			}
			return result;
		}

		/// <summary>
		/// 从Ukey的存取器读取数据
		/// </summary>
		/// <param name="index">开始读取位置</param>
		/// <param name="length">读取长度</param>
		// Token: 0x06002788 RID: 10120 RVA: 0x0011EFE4 File Offset: 0x0011D1E4
		[oO0oooo("2666")]
		public static string ReadStr(short index, int length)
		{
			string text = "";
			string result;
			if ((int)index + length > 400)
			{
				result = "";
			}
			else if (OoO0o.O_O0O_0.OO0_.(ref text, index, length, "ABCDEF09", "9876EFCD", UKey.o_o0_0.o_o_0.) != 0)
			{
				result = "";
			}
			else
			{
				result = text;
			}
			return result;
		}

		/// <summary>
		/// 向UKey的存储器写入数据
		/// </summary>
		/// <param name="index">开始写入位置</param>
		/// <param name="InString">要写入的字符串</param>
		/// <param name="password1">第一组写入密码</param>
		/// <param name="password2">第二组写入密码</param>
		// Token: 0x06002789 RID: 10121 RVA: 0x0011F030 File Offset: 0x0011D230
		[oO0oooo("2666")]
		public static bool WriteStr(short index, string InString, string password1, string password2)
		{
			int num = OoO0o.lstrlenA(InString);
			return (int)index + num <= 400 && OoO0o.ooO_.00O_oOO0.(InString, index, password1, password2, UKey.o_o0_0.o_o_0.) == 0;
		}

		/// <summary>
		/// 返回UKey的唯一ID
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x0011F068 File Offset: 0x0011D268
		public static string UID
		{
			get
			{
				int num;
				int num2;
				string result;
				if (OoO0o.o.0_0O.(ref num, ref num2, UKey.o_o0_0.o_o_0.) == 0)
				{
					result = num.ToString("X") + num2.ToString("X");
				}
				else
				{
					result = "";
				}
				return result;
			}
		}

		/// <summary>
		/// 用于计算字符串的字节长度
		/// </summary>
		/// <param name="val"></param>
		// Token: 0x0600278B RID: 10123 RVA: 0x0011F0AC File Offset: 0x0011D2AC
		[oO0oooo("2666")]
		public static int LenStrA(string val)
		{
			return OoO0o.lstrlenA(val);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0011F0B4 File Offset: 0x0011D2B4
		internal static string <<EMPTY_NAME>>(int A_0)
		{
			string text = "";
			string[] array = new string[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"A",
				"B",
				"C",
				"D",
				"E",
				"F"
			};
			int num = A_0 - 1;
			for (int i = 0; i <= num; i++)
			{
				text += array[OoOo0O.Oo_oOO_._Oo_o.(0, 16)];
			}
			return text;
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x0011F178 File Offset: 0x0011D378
		internal static bool <<EMPTY_NAME>>()
		{
			return OoO0o.o00_.0_O.(UKey.o_o0_0.o_o_0.) == 0 && OoO0o.O__O_o0_O0o._.("00000000", "00000000", "FFFFFFFF", "FFFFFFFF", UKey.o_o0_0.o_o_0.) == 0 && OoO0o.O.o_ooO_O.("FFFFFFFF", "FFFFFFFF", "FFFFFFFF", "FFFFFFFF", UKey.o_o0_0.o_o_0.) == 0;
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x0011F1E0 File Offset: 0x0011D3E0
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3)
		{
			return OoO0o.O__O_o0_O0o._.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) == 0;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x0011F1F3 File Offset: 0x0011D3F3
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3)
		{
			return OoO0o.O.o_ooO_O.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) == 0;
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0011F206 File Offset: 0x0011D406
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3)
		{
			return OoO0o.o0O.Oooo_.(A_0, A_1, A_2, A_3, UKey.o_o0_0.o_o_0.) == 0;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x0011F219 File Offset: 0x0011D419
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			return OoO0o.O.o_ooO_O.(A_0, UKey.o_o0_0.o_o_0.) == 0;
		}

		// Token: 0x0400104C RID: 4172
		private static string <<EMPTY_NAME>> = "";
	}
}
