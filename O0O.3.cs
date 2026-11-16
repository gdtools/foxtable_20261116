using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000CB RID: 203
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O0O
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x0004A837 File Offset: 0x00048A37
		public O0O(string A_0)
		{
			this.OO.OoO0. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.Oo_.O_O0oO__. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.OO.OoO0. = 30;
			this.OO._o_OO.(A_0);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0004A86E File Offset: 0x00048A6E
		public int <<EMPTY_NAME>>()
		{
			return this.OO.OoO0.;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0004A876 File Offset: 0x00048A76
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.OO.OoO0. = A_0;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0004A87F File Offset: 0x00048A7F
		internal string <<EMPTY_NAME>>()
		{
			return this.OO.OoO0.;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004A887 File Offset: 0x00048A87
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.OO.OoO0. = A_0;
			this.OO._o_OO.();
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0004A898 File Offset: 0x00048A98
		internal void <<EMPTY_NAME>>()
		{
			this.OO.OoO0..Clear();
			this.Oo_.O_O0oO__..Clear();
			StringReader stringReader = new StringReader(this.oO0_0.o.());
			this.Oo_.O_O0oO__. = stringReader.ReadLine();
			Dictionary<string, string> dictionary = null;
			while (stringReader.Peek() != -1)
			{
				string text = stringReader.ReadLine();
				if (Operators.CompareString(text, "", true) > 0)
				{
					text = text.Trim();
				}
				if (Operators.CompareString(text.Trim(), "-FormData-", true) == 0)
				{
					dictionary = this.OO.OoO0.;
				}
				else if (Operators.CompareString(text.Trim(), "-Cookies-", true) == 0)
				{
					dictionary = this.Oo_.O_O0oO__.;
				}
				else if (dictionary != null && Operators.CompareString(text, "", true) > 0)
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					if (array.Length == 2)
					{
						dictionary[array[0]] = array[1];
					}
				}
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0004A974 File Offset: 0x00048B74
		internal HttpClient <<EMPTY_NAME>>()
		{
			HttpClient httpClient = new HttpClient(this.Oo_.O_O0oO__.);
			try
			{
				foreach (string key in this.OO.OoO0..Keys)
				{
					httpClient.FormData[key] = this.OO.OoO0.[key];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (string key2 in this.Oo_.O_O0oO__..Keys)
				{
					httpClient.SCookies[key2] = this.Oo_.O_O0oO__.[key2];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			if (this.OO._o_OO.() > 0)
			{
				httpClient.Timeout = this.OO._o_OO.();
				httpClient.ReadWriteTimeout = this.OO._o_OO.();
			}
			return httpClient;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0004AA68 File Offset: 0x00048C68
		internal bool <<EMPTY_NAME>>()
		{
			this.OO.OoO0. = false;
			HttpClient httpClient = this.oO0_0.o.();
			httpClient.FormData["Action"] = 9.ToString();
			string data = httpClient.GetData(true);
			if (httpClient.RCookies.ContainsKey("Error"))
			{
				throw new Exception(httpClient.RCookies["Error"]);
			}
			int num = -1;
			if (Operators.CompareString(data, "", true) > 0 && !int.TryParse(data, out num))
			{
				num = -1;
			}
			if (num >= 0 && Enum.IsDefined(typeof(DataServerTypeEnum), num))
			{
				this.OO.OoO0. = (DataServerTypeEnum)num;
				this.OO.OoO0. = true;
				return true;
			}
			throw new Exception("无法连接服务端数据源！");
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0004AB28 File Offset: 0x00048D28
		internal List<string> <<EMPTY_NAME>>()
		{
			HttpClient httpClient = this.oO0_0.o.();
			httpClient.FormData["Action"] = 10.ToString();
			string data = httpClient.GetData();
			List<string> list = new List<string>();
			if (Operators.CompareString(data, "", true) > 0)
			{
				list.AddRange(data.ToString().Split(new char[]
				{
					'|'
				}));
			}
			return list;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0004AB90 File Offset: 0x00048D90
		public List<string> <<EMPTY_NAME>>()
		{
			HttpClient httpClient = this.oO0_0.o.();
			httpClient.FormData["Action"] = 11.ToString();
			string data = httpClient.GetData();
			List<string> list = new List<string>();
			if (Operators.CompareString(data, "", true) > 0)
			{
				list.AddRange(data.ToString().Split(new char[]
				{
					'|'
				}));
			}
			return list;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0004ABF8 File Offset: 0x00048DF8
		internal DataTable <<EMPTY_NAME>>(string A_0, bool A_1 = false)
		{
			string a_ = A_0;
			if (!A_1)
			{
				if (this.OO.OoO0. == DataServerTypeEnum.Oracle)
				{
					a_ = "Select * From " + A_0;
				}
				else if (!A_0.StartsWith("["))
				{
					a_ = "Select * From [" + A_0 + "]";
				}
				else
				{
					a_ = "Select * From " + A_0;
				}
			}
			HttpClient httpClient = this.oO0_0.o.();
			httpClient.FormData["Action"] = 12.ToString();
			httpClient.Select = a_;
			return httpClient.GetBaseDataTable();
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0004AC7C File Offset: 0x00048E7C
		internal DataTable <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			HttpClient httpClient = this.oO0_0.o.();
			if (A_1)
			{
				httpClient.Select = A_0;
			}
			else
			{
				httpClient.FormData["DataTable"] = A_0;
			}
			httpClient.FormData["Action"] = 1.ToString();
			return httpClient.GetBaseDataTable();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0004ACCC File Offset: 0x00048ECC
		internal DataTable <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			HttpClient httpClient = this.oO0_0.o.();
			if (A_1)
			{
				httpClient.Select = A_0;
			}
			else
			{
				httpClient.FormData["DataTable"] = A_0;
			}
			httpClient.FormData["Action"] = 2.ToString();
			return httpClient.GetBaseDataTable();
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0004AD1C File Offset: 0x00048F1C
		internal Dictionary<string, string> <<EMPTY_NAME>>()
		{
			return this.OO.OoO0.;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0004AD24 File Offset: 0x00048F24
		internal Dictionary<string, string> <<EMPTY_NAME>>()
		{
			return this.Oo_.O_O0oO__.;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0004AD2C File Offset: 0x00048F2C
		public string <<EMPTY_NAME>>()
		{
			return this.Oo_.O_O0oO__.;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0004AD34 File Offset: 0x00048F34
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.Oo_.O_O0oO__. = A_0;
		}

		// Token: 0x0400033A RID: 826
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400033B RID: 827
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400033C RID: 828
		internal DataServerTypeEnum <<EMPTY_NAME>>;

		// Token: 0x0400033D RID: 829
		private string <<EMPTY_NAME>>;

		// Token: 0x0400033E RID: 830
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x0400033F RID: 831
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000340 RID: 832
		private int <<EMPTY_NAME>>;
	}
}
