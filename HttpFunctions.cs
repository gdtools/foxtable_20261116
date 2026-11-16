using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020001EB RID: 491
	[StandardModule]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class HttpFunctions
	{
		/// <summary>
		/// 压缩JSON对象的字符串表示
		/// </summary>
		/// <param name="token">要压缩的JSON对象</param>
		// Token: 0x06001860 RID: 6240 RVA: 0x000AC9F3 File Offset: 0x000AABF3
		[oO0oooo("A0227")]
		public static string CompressJson(JToken token)
		{
			return token.ToString(Formatting.None).Replace("\r\n", "");
		}

		/// <summary>
		/// 压缩JSON字符串
		/// </summary>
		/// <param name="jsonString">要压缩的JSON字符串</param>
		// Token: 0x06001861 RID: 6241 RVA: 0x000ACA0B File Offset: 0x000AAC0B
		[oO0oooo("A0227")]
		public static string CompressJson(string jsonString)
		{
			return JObject.Parse(jsonString).ToString(Formatting.None).Replace("\r\n", "");
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000ACA28 File Offset: 0x000AAC28
		public static string <<EMPTY_NAME>>(string A_0)
		{
			return JArray.Parse(A_0).ToString(Formatting.None).Replace("\r\n", "");
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000ACA48 File Offset: 0x000AAC48
		internal static Encoding <<EMPTY_NAME>>(string A_0)
		{
			A_0 = A_0.Trim(new char[]
			{
				'"'
			}).Trim(new char[]
			{
				'\''
			});
			Encoding result;
			if (Operators.CompareString(A_0.ToLower(), "utf-8", true) == 0 || Operators.CompareString(A_0.ToLower(), "utf8", true) == 0)
			{
				result = Encoding.UTF8;
			}
			else if (Operators.CompareString(A_0.ToLower(), "utf-16", true) == 0 || Operators.CompareString(A_0.ToLower(), "utf16", true) == 0)
			{
				result = Encoding.Unicode;
			}
			else
			{
				try
				{
					result = Encoding.GetEncoding(A_0);
				}
				catch (Exception ex)
				{
					result = Encoding.UTF8;
				}
			}
			return result;
		}
	}
}
