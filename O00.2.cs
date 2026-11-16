using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200044B RID: 1099
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StandardModule]
	public sealed class O00
	{
		// Token: 0x06004A07 RID: 18951
		[DllImport("Foxtable.IO.dll")]
		private static extern int FileEncrypt(string A_0, string A_1, string A_2);

		// Token: 0x06004A08 RID: 18952
		[DllImport("Foxtable.IO.dll")]
		private static extern int FileDecrypt(string A_0, string A_1, string A_2);

		// Token: 0x06004A09 RID: 18953
		[DllImport("Foxtable.IO.dll")]
		private static extern int CRCFileCheck(string A_0, StringBuilder A_1);

		// Token: 0x06004A0A RID: 18954
		[DllImport("Foxtable.IO.dll")]
		private static extern int CRC32(string A_0, int A_1, StringBuilder A_2);

		// Token: 0x06004A0B RID: 18955 RVA: 0x0020C750 File Offset: 0x0020A950
		[oO0oooo("0352")]
		public static string MD5Encrypt(string strToHash)
		{
			new MD5CryptoServiceProvider();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(strToHash);
			byte[] inArray = md5CryptoServiceProvider.ComputeHash(bytes);
			md5CryptoServiceProvider.Clear();
			return Convert.ToBase64String(inArray);
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x0020C788 File Offset: 0x0020A988
		public static string MD5(string strToHash)
		{
			new MD5CryptoServiceProvider();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
			byte[] value = md5CryptoServiceProvider.ComputeHash(bytes);
			md5CryptoServiceProvider.Clear();
			return BitConverter.ToString(value).Replace("-", "");
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x0020C7CE File Offset: 0x0020A9CE
		[oO0oooo("0350")]
		public static string EncryptText(string Text, string Key, string IV)
		{
			return new OO_O__0oo(Key, IV).o0O_.00.(Text);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x0020C7E0 File Offset: 0x0020A9E0
		[oO0oooo("0351")]
		public static string DecryptText(string Text, string Key, string IV)
		{
			OO_O__0oo oo_O__0oo = new OO_O__0oo(Key, IV);
			string result;
			if (Text == null || Text.Length == 0)
			{
				result = "";
			}
			else
			{
				result = oo_O__0oo.OO.O0_O.(Text);
			}
			return result;
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x0020C814 File Offset: 0x0020AA14
		[oO0oooo("1489")]
		public static string CRCCheckFile(string FileName)
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			string result;
			if (O00.CRCFileCheck(FileName, stringBuilder) == 1)
			{
				result = stringBuilder.ToString().Trim();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x0020C844 File Offset: 0x0020AA44
		[oO0oooo("1490")]
		public static string CRCCheckString(string strValue)
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			string result;
			if (O00.CRC32(strValue, strValue.Length, stringBuilder) == 1)
			{
				result = stringBuilder.ToString().Trim();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x0020C87C File Offset: 0x0020AA7C
		[oO0oooo("1491")]
		public static bool EncryptFile(string InFile, string OutFile, string PassWord)
		{
			return Operators.CompareString(InFile, OutFile, true) != 0 && O00.FileEncrypt(InFile, OutFile, PassWord) == 1;
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0020C8AC File Offset: 0x0020AAAC
		[oO0oooo("1492")]
		public static bool DecryptFile(string InFile, string OutFile, string PassWord)
		{
			return Operators.CompareString(InFile, OutFile, true) != 0 && O00.FileDecrypt(InFile, OutFile, PassWord) == 1;
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x0020C8D9 File Offset: 0x0020AAD9
		internal static string <<EMPTY_NAME>>(string A_0, string A_1, string A_2)
		{
			return new oO0o0_0oO0_oO(A_1, A_2).O_0oO0o.OO_.(A_0);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x0020C8E8 File Offset: 0x0020AAE8
		internal static string <<EMPTY_NAME>>(string A_0, string A_1, string A_2)
		{
			oO0o0_0oO0_oO oO0o0_0oO0_oO = new oO0o0_0oO0_oO(A_1, A_2);
			string result;
			if (A_0 == null || A_0.Length == 0)
			{
				result = "";
			}
			else
			{
				result = oO0o0_0oO0_oO.o___oOo.o_OO.(A_0);
			}
			return result;
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x0020C91C File Offset: 0x0020AB1C
		internal static string <<EMPTY_NAME>>(string A_0, string A_1, string A_2)
		{
			OO_O__0oo oo_O__0oo = new OO_O__0oo(A_1, A_2);
			string result;
			if (A_0 == null || A_0.Length == 0)
			{
				result = "";
			}
			else
			{
				result = oo_O__0oo.OO.O0_O.(A_0);
			}
			return result;
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x0020C950 File Offset: 0x0020AB50
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			string result;
			if (O00.CRCFileCheck(A_0, stringBuilder) == 1)
			{
				result = stringBuilder.ToString().Trim();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x0020C980 File Offset: 0x0020AB80
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			new MD5CryptoServiceProvider();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			byte[] inArray = md5CryptoServiceProvider.ComputeHash(bytes);
			md5CryptoServiceProvider.Clear();
			return Convert.ToBase64String(inArray);
		}
	}
}
