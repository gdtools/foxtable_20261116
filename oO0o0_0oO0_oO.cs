using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200044A RID: 1098
	internal class oO0o0_0oO0_oO
	{
		// Token: 0x06004A03 RID: 18947 RVA: 0x0020C610 File Offset: 0x0020A810
		private byte[] <<EMPTY_NAME>>(string A_0, int A_1)
		{
			HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			return (byte[])Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), new byte[A_1 - 1 + 1]);
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x0020C648 File Offset: 0x0020A848
		public oO0o0_0oO0_oO(string A_0, string A_1)
		{
			this.O_0oO0o.OO_. = new TripleDESCryptoServiceProvider();
			this.O_0oO0o.OO_..Key = this.O_0oO0o.OO_.(A_0, this.O_0oO0o.OO_..KeySize / 8);
			this.O_0oO0o.OO_..IV = this.O_0oO0o.OO_.(A_1, this.O_0oO0o.OO_..BlockSize / 8);
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x0020C6A4 File Offset: 0x0020A8A4
		internal string <<EMPTY_NAME>>(string A_0)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, this.O_0oO0o.OO_..CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x0020C6F0 File Offset: 0x0020A8F0
		internal string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.Length % 4 != 0)
			{
				result = "";
			}
			else
			{
				byte[] array = Convert.FromBase64String(A_0);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, this.O_0oO0o.OO_..CreateDecryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				result = Encoding.Unicode.GetString(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x04001E13 RID: 7699
		private TripleDESCryptoServiceProvider <<EMPTY_NAME>>;
	}
}
