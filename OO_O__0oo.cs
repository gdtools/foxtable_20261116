using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200044E RID: 1102
	internal sealed class OO_O__0oo
	{
		// Token: 0x06004A44 RID: 19012 RVA: 0x0020DC04 File Offset: 0x0020BE04
		private byte[] <<EMPTY_NAME>>(string A_0, int A_1)
		{
			HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			return (byte[])Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), new byte[A_1 - 1 + 1]);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0020DC3C File Offset: 0x0020BE3C
		public OO_O__0oo(string A_0, string A_1)
		{
			this.o0O_.00. = new TripleDESCryptoServiceProvider();
			this.o0O_.00..Key = this.o0O_.00.(A_0, this.o0O_.00..KeySize / 8);
			this.o0O_.00..IV = this.o0O_.00.(A_1, this.o0O_.00..BlockSize / 8);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0020DC98 File Offset: 0x0020BE98
		internal string <<EMPTY_NAME>>(string A_0)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, this.o0O_.00..CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0020DCE4 File Offset: 0x0020BEE4
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
				CryptoStream cryptoStream = new CryptoStream(memoryStream, this.o0O_.00..CreateDecryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				result = Encoding.Unicode.GetString(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x04001E29 RID: 7721
		private TripleDESCryptoServiceProvider <<EMPTY_NAME>>;
	}
}
