using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using O0o0.00;

namespace Foxtable
{
	/// <summary>
	/// HTTP客户端类
	/// </summary>
	// Token: 0x020001F1 RID: 497
	[ComVisible(true)]
	[oO0oooo("A0163")]
	public class HttpClient
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x000B2AFE File Offset: 0x000B0CFE
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x000B2B06 File Offset: 0x000B0D06
		public bool EncodeCookie { get; set; }

		/// <summary>
		/// 服务端地址
		/// </summary>
		/// <param name="url"></param>
		// Token: 0x0600192D RID: 6445 RVA: 0x000B2B10 File Offset: 0x000B0D10
		public HttpClient(string A_0)
		{
			this.o00__oO.0OO. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.o.__00OOO. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.o0Oo0o.o_O. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			this.o00__oO.0OO. = new HttpFilleCollection();
			this.oOO0.0oOOOo. = "utf-8";
			this.O00_OO0.oooO. = "utf-8";
			this.O_o0.00. = -1;
			this.oOO0.0oOOOo. = -1;
			this.O_O.0o. = new Dictionary<string, string>();
			this.O_o0.00. = false;
			this.oOo0_.O_O0. = "";
			this.oOO0.0oOOOo. = true;
			this.oo__.o_. = true;
			this.EncodeCookie = true;
			this.ResponseHeaders = new NameValueCollection();
			if (!A_0.Trim().StartsWith("ws:", StringComparison.OrdinalIgnoreCase) && !A_0.Trim().StartsWith("wss:", StringComparison.OrdinalIgnoreCase))
			{
				this.O_0_.0O. = (HttpWebRequest)WebRequest.Create(A_0);
				this.O_0_.0O..ServicePoint.Expect100Continue = false;
			}
			this.O0o__._0_0O___. = new Uri(A_0).Host;
			this.Oo_0oO0Oo0_.O_. = A_0;
		}

		/// <summary>
		/// 重新连接服务端
		/// </summary>
		// Token: 0x0600192E RID: 6446 RVA: 0x000B2C1F File Offset: 0x000B0E1F
		public void Reset()
		{
			this.O_0_.0O. = (HttpWebRequest)WebRequest.Create(this.Oo_0oO0Oo0_.O_.);
			this.o0Oo0o.o_O..Clear();
			this.O0o__._0_0O___. = new Uri(this.Oo_0oO0Oo0_.O_.).Host;
		}

		/// <summary>
		/// 表单数据
		/// </summary>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x000B2C58 File Offset: 0x000B0E58
		[oO0oooo("A0159")]
		public Dictionary<string, string> FormData
		{
			get
			{
				return this.o00__oO.0OO.;
			}
		}

		/// <summary>
		/// 要发送到服务器的所有Cookie
		/// </summary>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000B2C60 File Offset: 0x000B0E60
		[oO0oooo("A0158")]
		public Dictionary<string, string> SCookies
		{
			get
			{
				return this.o.__00OOO.;
			}
		}

		/// <summary>
		/// 从服务器返回的所有Cookie
		/// </summary>
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000B2C68 File Offset: 0x000B0E68
		[oO0oooo("A0158")]
		public Dictionary<string, string> RCookies
		{
			get
			{
				return this.o0Oo0o.o_O.;
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000B2C70 File Offset: 0x000B0E70
		internal HttpClient <<EMPTY_NAME>>()
		{
			HttpClient httpClient = new HttpClient(this.Oo_0oO0Oo0_.O_.);
			try
			{
				foreach (string key in this.o00__oO.0OO..Keys)
				{
					httpClient.FormData[key] = this.o00__oO.0OO.[key];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (string key2 in this.o.__00OOO..Keys)
				{
					httpClient.SCookies[key2] = this.o.__00OOO.[key2];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			httpClient.Timeout = this.Timeout;
			httpClient.ReadWriteTimeout = this.Timeout;
			return httpClient;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000B2D5C File Offset: 0x000B0F5C
		public HttpClient Clone()
		{
			HttpClient httpClient = new HttpClient(this.Oo_0oO0Oo0_.O_.);
			try
			{
				foreach (string key in this.o00__oO.0OO..Keys)
				{
					httpClient.FormData[key] = this.o00__oO.0OO.[key];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (string key2 in this.o.__00OOO..Keys)
				{
					httpClient.SCookies[key2] = this.o.__00OOO.[key2];
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (string key3 in this.Files.Keys)
				{
					httpClient.Files.Add(key3, this.o00__oO.0OO.[key3]);
				}
			}
			finally
			{
				Dictionary<string, List<string>>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				foreach (string key4 in this.Headers.Keys)
				{
					httpClient.Headers.Add(key4, this.O_O.0o.[key4]);
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			httpClient.Method = this.Method;
			httpClient.Timeout = this.Timeout;
			httpClient.SkipError = this.SkipError;
			httpClient.ReadWriteTimeout = this.ReadWriteTimeout;
			httpClient.Content = this.Content;
			httpClient.ContentType = this.ContentType;
			httpClient.UserAgent = this.UserAgent;
			httpClient.Accept = this.Accept;
			httpClient.RequestEncoding = this.RequestEncoding;
			httpClient.ResponseEncoding = this.ResponseEncoding;
			httpClient.EncodeCookie = this.EncodeCookie;
			httpClient.RunOnServer = this.RunOnServer;
			return httpClient;
		}

		/// <summary>
		/// 所有需要发送到服务器的文件
		/// </summary>
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000B2F78 File Offset: 0x000B1178
		[oO0oooo("A0161")]
		public HttpFilleCollection Files
		{
			get
			{
				return this.o00__oO.0OO.;
			}
		}

		/// <summary>
		/// 字符型，用于设置向服务器发送数据时所使用的字符编码，默认为"utf-8"，一般无需设置
		/// </summary>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x000B2F80 File Offset: 0x000B1180
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x000B2F88 File Offset: 0x000B1188
		public string RequestEncoding
		{
			get
			{
				return this.oOO0.0oOOOo.;
			}
			set
			{
				this.oOO0.0oOOOo. = value;
			}
		}

		/// <summary>
		/// 符型，用于设置解析收到的服务器数据时所采用的字符编码，默认为"utf-8"，一般无需设置
		/// </summary>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x000B2F91 File Offset: 0x000B1191
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x000B2F99 File Offset: 0x000B1199
		public string ResponseEncoding
		{
			get
			{
				return this.O00_OO0.oooO.;
			}
			set
			{
				this.O00_OO0.oooO. = value;
			}
		}

		/// <summary>
		/// 整数型，用于设置获取服务器响应的超时时限，单位为秒，默认是100秒。
		/// </summary>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x000B2FA2 File Offset: 0x000B11A2
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x000B2FAA File Offset: 0x000B11AA
		public int Timeout
		{
			get
			{
				return this.O_o0.00.;
			}
			set
			{
				this.O_o0.00. = value;
			}
		}

		/// <summary>
		/// 获取或设置 User-agent HTTP 标头的值
		/// </summary>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x000B2FB3 File Offset: 0x000B11B3
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x000B2FBB File Offset: 0x000B11BB
		public string UserAgent
		{
			get
			{
				return this.ooooO._o_0O__.;
			}
			set
			{
				this.ooooO._o_0O__. = value;
			}
		}

		/// <summary>
		/// 整数型，用于获取读写服务器数据的超时时限，单位为秒，默认是300秒
		/// </summary>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x000B2FC4 File Offset: 0x000B11C4
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x000B2FCC File Offset: 0x000B11CC
		public int ReadWriteTimeout
		{
			get
			{
				return this.oOO0.0oOOOo.;
			}
			set
			{
				this.oOO0.0oOOOo. = value;
			}
		}

		/// <summary>
		/// 字符型，用于设置要发送到服务器的数据
		/// </summary>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x000B2FD5 File Offset: 0x000B11D5
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x000B2FDD File Offset: 0x000B11DD
		[oO0oooo("A0165")]
		public string Content
		{
			get
			{
				return this.O00oo.O___.;
			}
			set
			{
				this.O00oo.O___. = value;
			}
		}

		/// <summary>
		/// 字符型， 用于设置数据类型，默认为"text/plain"，一般无需设置
		/// </summary>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x000B2FE6 File Offset: 0x000B11E6
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x000B2FEE File Offset: 0x000B11EE
		public string ContentType
		{
			get
			{
				return this.O__oo.0OoooO.;
			}
			set
			{
				this.O__oo.0OoooO. = value;
			}
		}

		/// <summary>
		/// HTTP头，一般无需设置
		/// </summary>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x000B2FF7 File Offset: 0x000B11F7
		[oO0oooo("A0246")]
		public Dictionary<string, string> Headers
		{
			get
			{
				return this.O_O.0o.;
			}
		}

		/// <summary>
		/// 用于接收从服务器返回的DataTable
		/// </summary>
		// Token: 0x06001944 RID: 6468 RVA: 0x000B3000 File Offset: 0x000B1200
		[oO0oooo("0162")]
		public DataTable GetDataTable()
		{
			DataTable baseDataTable = this.GetBaseDataTable();
			DataTable result;
			if (baseDataTable != null)
			{
				DataTable dataTable = new DataTable(baseDataTable, null, null, null, null);
				dataTable.o.0O000_.();
				if (dataTable.BaseTable.ExtendedProperties.ContainsKey("HttpSelect"))
				{
					string a_ = dataTable.BaseTable.ExtendedProperties["HttpSelect"].ToString();
					DataTable dataTable2;
					string a_2 = (dataTable2 = dataTable).LoadFilter;
					DataTable dataTable3;
					string a_3 = (dataTable3 = dataTable).LoadTop;
					DataTable dataTable4 = dataTable;
					DataTable dataTable5 = dataTable;
					DataTable dataTable6;
					string a_4 = (dataTable6 = dataTable).LoadOrder;
					Oo00.ooO.ooo.(a_, ref a_2, ref a_3, ref dataTable4.o0_oO00.0oO_., ref dataTable5.O0o0__o.0000__., ref a_4);
					dataTable6.LoadOrder = a_4;
					dataTable3.LoadTop = a_3;
					dataTable2.LoadFilter = a_2;
					dataTable.ooO.oO0O0_oo. = false;
				}
				result = dataTable;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000B30BC File Offset: 0x000B12BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable GetBaseDataTable()
		{
			DataSet dataSet = this.oOO.__.();
			DataTable result;
			if (dataSet != null && dataSet.Tables.Count > 0)
			{
				DataTable dataTable = dataSet.Tables[0];
				dataSet.Tables.Remove(dataTable);
				dataSet.Dispose();
				dataTable.AcceptChanges();
				if (dataSet.Tables.Count > 0)
				{
					try
					{
						foreach (object obj in dataSet.Tables[0].Rows)
						{
							DataRow dataRow = (DataRow)obj;
							if (Operators.CompareString(dataRow["Name"].ToString(), "UpdateColumns", true) == 0)
							{
								string[] collection = dataRow["Value"].ToString().Split(new char[]
								{
									'|'
								});
								List<string> list = new List<string>();
								list.AddRange(collection);
								dataTable.ExtendedProperties.Add("UpdateColumns", list);
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				dataSet.Tables.Clear();
				dataSet.Dispose();
				result = dataTable;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000B31EC File Offset: 0x000B13EC
		internal DataSet <<EMPTY_NAME>>()
		{
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			Stream stream2 = null;
			try
			{
				this.FormData.ContainsKey("Action");
				DataSet dataSet = new DataSet();
				if (this.o00__oO.0OO. != null)
				{
					httpWebResponse = this.o00__oO.0OO.;
				}
				else
				{
					this.oo__.o_.();
					httpWebResponse = (HttpWebResponse)this.O_0_.0O..GetResponse();
					this.oOO.__.(httpWebResponse);
				}
				if (this.RCookies.ContainsKey("Error"))
				{
					throw new Exception(this.RCookies["Error"]);
				}
				stream = httpWebResponse.GetResponseStream();
				stream2 = stream;
				if (httpWebResponse.Headers["Content-Encoding"] != null)
				{
					if (httpWebResponse.Headers["Content-Encoding"].Contains("gzip"))
					{
						stream = new GZipStream(stream, CompressionMode.Decompress, false);
					}
					else if (httpWebResponse.Headers["Content-Encoding"].Contains("deflate"))
					{
						stream = new DeflateStream(stream, CompressionMode.Decompress, false);
					}
				}
				dataSet.ReadXml(stream);
				dataSet.AcceptChanges();
				return dataSet;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (this.O_o0.00.)
						{
							return null;
						}
					}
				}
				if (!this.O_o0.00.)
				{
					ooO.oOo0Oo.o.(ex, "");
				}
				else
				{
					this.RCookies["Error"] = ex.Message;
				}
			}
			finally
			{
				if (stream != null && stream != stream2)
				{
					stream.Dispose();
				}
				else if (stream2 != null)
				{
					stream2.Dispose();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
			}
			return null;
		}

		/// <summary>
		///  用于接收从服务器返回的文件 
		/// </summary>
		/// <param name="FileName">将接收到的文件保存在本地的文件名，含路径</param>
		// Token: 0x06001947 RID: 6471 RVA: 0x000B33E0 File Offset: 0x000B15E0
		[oO0oooo("A0160")]
		public bool GetFile(string FileName)
		{
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			Stream stream2 = null;
			FileStream fileStream = null;
			try
			{
				string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
				if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					OO_00oOO.FileSys.CreateDirectory(parentPath);
				}
				if (this.o00__oO.0OO. != null)
				{
					httpWebResponse = this.o00__oO.0OO.;
				}
				else
				{
					this.oo__.o_.();
					httpWebResponse = (HttpWebResponse)this.O_0_.0O..GetResponse();
					this.oOO.__.(httpWebResponse);
				}
				if (this.RCookies.ContainsKey("Error"))
				{
					throw new Exception(this.RCookies["Error"]);
				}
				if (this.RCookies.ContainsKey("IsNull"))
				{
					return false;
				}
				stream = httpWebResponse.GetResponseStream();
				stream2 = stream;
				if (httpWebResponse.Headers["Content-Encoding"] != null)
				{
					if (httpWebResponse.Headers["Content-Encoding"].Contains("gzip"))
					{
						stream = new GZipStream(stream, CompressionMode.Decompress, false);
					}
					else if (httpWebResponse.Headers["Content-Encoding"].Contains("deflate"))
					{
						stream = new DeflateStream(stream, CompressionMode.Decompress, false);
					}
				}
				byte[] array = new byte[513];
				int i = stream.Read(array, 0, array.Length);
				fileStream = new FileStream(FileName, FileMode.Create);
				while (i > 0)
				{
					fileStream.Write(array, 0, i);
					i = stream.Read(array, 0, array.Length);
				}
				return true;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (this.O_o0.00.)
						{
							return false;
						}
					}
				}
				if (!this.O_o0.00.)
				{
					ooO.oOo0Oo.o.(ex, "");
				}
				else
				{
					this.RCookies["Error"] = ex.Message;
				}
			}
			finally
			{
				if (stream != null && stream != stream2)
				{
					stream.Dispose();
				}
				else if (stream2 != null)
				{
					stream2.Dispose();
				}
				if (fileStream != null)
				{
					fileStream.Dispose();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
			}
			return false;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000B3648 File Offset: 0x000B1848
		public Task<bool> GetFileAsync(string FileName)
		{
			HttpClient.O__oOoo0Oo0_O o__oOoo0Oo0_O = default(HttpClient.O__oOoo0Oo0_O);
			o__oOoo0Oo0_O.O_.ooO_00o0. = this;
			o__oOoo0Oo0_O.O_.ooO_00o0. = FileName;
			o__oOoo0Oo0_O.O_.ooO_00o0. = -1;
			o__oOoo0Oo0_O.O_.ooO_00o0. = AsyncTaskMethodBuilder<bool>.Create();
			o__oOoo0Oo0_O.O_.ooO_00o0..Start<HttpClient.O__oOoo0Oo0_O>(ref o__oOoo0Oo0_O);
			return o__oOoo0Oo0_O.O_.ooO_00o0..Task;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000B369C File Offset: 0x000B189C
		public Task<string> GetDataAsync()
		{
			HttpClient.oo____o oo____o = default(HttpClient.oo____o);
			oo____o.OO00OOo.o0_. = this;
			oo____o.O_.ooO_00o0. = -1;
			oo____o.O_.ooO_00o0. = AsyncTaskMethodBuilder<string>.Create();
			oo____o.O_.ooO_00o0..Start<HttpClient.oo____o>(ref oo____o);
			return oo____o.O_.ooO_00o0..Task;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000B36E8 File Offset: 0x000B18E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool GetMemStream(MemoryStream mem)
		{
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			Stream stream2 = null;
			try
			{
				if (this.o00__oO.0OO. != null)
				{
					httpWebResponse = this.o00__oO.0OO.;
				}
				else
				{
					this.oo__.o_.();
					httpWebResponse = (HttpWebResponse)this.O_0_.0O..GetResponse();
					this.oOO.__.(httpWebResponse);
				}
				if (this.RCookies.ContainsKey("Error"))
				{
					throw new Exception(this.RCookies["Error"]);
				}
				stream = httpWebResponse.GetResponseStream();
				stream2 = stream;
				byte[] array = new byte[513];
				int i = stream.Read(array, 0, array.Length);
				if (i == 0)
				{
					stream.Close();
					return false;
				}
				while (i > 0)
				{
					mem.Write(array, 0, i);
					i = stream.Read(array, 0, array.Length);
				}
				return true;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (this.O_o0.00.)
						{
							return false;
						}
					}
				}
				if (!this.O_o0.00.)
				{
					ooO.oOo0Oo.o.(ex, "");
				}
				else
				{
					this.RCookies["Error"] = ex.Message;
				}
			}
			finally
			{
				if (stream != null && stream != stream2)
				{
					stream.Dispose();
				}
				else if (stream2 != null)
				{
					stream2.Dispose();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
			}
			return false;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000B38A4 File Offset: 0x000B1AA4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string GetMediaFile(string path, string NewName = null)
		{
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			Stream stream2 = null;
			Stream stream3 = null;
			try
			{
				string text = path;
				if (!OO_00oOO.FileSys.DirectoryExists(path))
				{
					OO_00oOO.FileSys.CreateDirectory(path);
				}
				if (this.o00__oO.0OO. != null)
				{
					httpWebResponse = this.o00__oO.0OO.;
				}
				else
				{
					this.oo__.o_.();
					httpWebResponse = (HttpWebResponse)this.O_0_.0O..GetResponse();
					this.oOO.__.(httpWebResponse);
				}
				if (this.RCookies.ContainsKey("Error"))
				{
					throw new Exception(this.RCookies["Error"]);
				}
				string text2 = httpWebResponse.Headers["Content-disposition"];
				bool flag;
				if (NewName != null)
				{
					if (text2 != null && text2.ToLower().IndexOf("filename=") >= 0)
					{
						text = Path.Combine(text, NewName);
						flag = true;
					}
				}
				else if (text2 != null)
				{
					foreach (string text2 in text2.Split(new char[]
					{
						';'
					}))
					{
						text2 = text2.Trim();
						if (text2.StartsWith("filename="))
						{
							text2 = text2.Split(new char[]
							{
								'='
							})[1].Trim(new char[]
							{
								'"'
							});
							text = Path.Combine(text, text2);
							flag = true;
						}
					}
				}
				stream = httpWebResponse.GetResponseStream();
				stream2 = stream;
				if (httpWebResponse.Headers["Content-Encoding"] != null)
				{
					if (httpWebResponse.Headers["Content-Encoding"].Contains("gzip"))
					{
						stream = new GZipStream(stream, CompressionMode.Decompress, false);
					}
					else if (httpWebResponse.Headers["Content-Encoding"].Contains("deflate"))
					{
						stream = new DeflateStream(stream, CompressionMode.Decompress, false);
					}
				}
				byte[] array2 = new byte[513];
				int j = stream.Read(array2, 0, array2.Length);
				if (j == 0)
				{
					stream.Close();
					return "";
				}
				if (flag)
				{
					stream3 = new FileStream(text, FileMode.Create);
				}
				else
				{
					stream3 = new MemoryStream();
				}
				while (j > 0)
				{
					stream3.Write(array2, 0, j);
					j = stream.Read(array2, 0, array2.Length);
				}
				if (!flag)
				{
					text = Encoding.GetEncoding(this.O00_OO0.oooO.).GetString(((MemoryStream)stream3).ToArray());
				}
				if (stream != httpWebResponse.GetResponseStream())
				{
					httpWebResponse.GetResponseStream().Close();
				}
				return text;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (this.O_o0.00.)
						{
							return "";
						}
					}
				}
				if (!this.O_o0.00.)
				{
					ooO.oOo0Oo.o.(ex, "");
				}
				else
				{
					this.RCookies["Error"] = ex.Message;
				}
			}
			finally
			{
				if (stream != null && stream != stream2)
				{
					stream.Dispose();
				}
				else if (stream2 != null)
				{
					stream2.Dispose();
				}
				if (stream3 != null)
				{
					stream3.Dispose();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
			}
			return "";
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000B3C04 File Offset: 0x000B1E04
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string GetData(bool SkipErr)
		{
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			Stream stream2 = null;
			MemoryStream memoryStream = null;
			try
			{
				Encoding encoding = Encoding.GetEncoding(this.O00_OO0.oooO.);
				if (this.o00__oO.0OO. != null)
				{
					httpWebResponse = this.o00__oO.0OO.;
				}
				else
				{
					this.oo__.o_.();
					httpWebResponse = (HttpWebResponse)this.O_0_.0O..GetResponse();
					this.oOO.__.(httpWebResponse);
				}
				if (this.RCookies.ContainsKey("Error"))
				{
					throw new Exception(this.RCookies["Error"]);
				}
				memoryStream = new MemoryStream();
				stream = httpWebResponse.GetResponseStream();
				stream2 = stream;
				byte[] array = new byte[513];
				if (httpWebResponse.Headers["Content-Encoding"] != null)
				{
					if (httpWebResponse.Headers["Content-Encoding"].Contains("gzip"))
					{
						stream = new GZipStream(stream, CompressionMode.Decompress, false);
					}
					else if (httpWebResponse.Headers["Content-Encoding"].Contains("deflate"))
					{
						stream = new DeflateStream(stream, CompressionMode.Decompress, false);
					}
				}
				for (int i = stream.Read(array, 0, array.Length); i > 0; i = stream.Read(array, 0, array.Length))
				{
					memoryStream.Write(array, 0, i);
				}
				bool flag;
				if (memoryStream.Length >= 3L)
				{
					memoryStream.Position = 0L;
					if (memoryStream.Read(array, 0, 3) == 3 && array[0] == 239 && array[1] == 187 && array[2] == 191)
					{
						flag = true;
					}
				}
				string @string;
				if (flag)
				{
					@string = Encoding.UTF8.GetString(memoryStream.ToArray(), 3, (int)(memoryStream.Length - 3L));
				}
				else
				{
					@string = encoding.GetString(memoryStream.ToArray());
				}
				return @string;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (SkipErr || this.O_o0.00.)
						{
							return "";
						}
					}
				}
				if (SkipErr || this.O_o0.00.)
				{
					this.RCookies["Error"] = ex.Message;
				}
				else
				{
					ooO.oOo0Oo.o.(ex, "");
				}
			}
			finally
			{
				if (stream != null && stream != stream2)
				{
					stream.Dispose();
				}
				else if (stream2 != null)
				{
					stream2.Dispose();
				}
				if (memoryStream != null)
				{
					memoryStream.Dispose();
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
			}
			return "";
		}

		/// <summary>
		/// 用于接收从服务器返回的数据
		/// </summary>
		// Token: 0x0600194D RID: 6477 RVA: 0x000B3EBC File Offset: 0x000B20BC
		[oO0oooo("A0294")]
		public string GetData()
		{
			return this.GetData(false);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		public Task<JObject> ReadOpenAiSseAsync(Action<string, string> chunkHandler = null, CancellationTokenSource SSECancellation = null)
		{
			HttpClient.OoOOO_000_O0o ooOOO_000_O0o = default(HttpClient.OoOOO_000_O0o);
			ooOOO_000_O0o.OO00OOo.o0_. = this;
			ooOOO_000_O0o.OO00OOo.o0_. = chunkHandler;
			ooOOO_000_O0o.OO00OOo.o0_. = SSECancellation;
			ooOOO_000_O0o.OO00OOo.o0_. = -1;
			ooOOO_000_O0o.OO00OOo.o0_. = AsyncTaskMethodBuilder<JObject>.Create();
			ooOOO_000_O0o.OO00OOo.o0_..Start<HttpClient.OoOOO_000_O0o>(ref ooOOO_000_O0o);
			return ooOOO_000_O0o.OO00OOo.o0_..Task;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000B3F24 File Offset: 0x000B2124
		public Task<JObject> ReadOpenAiSseAsync(Action<string, string> chunkHandler = null)
		{
			HttpClient.oo00OO_O0_o_ oo00OO_O0_o_ = default(HttpClient.oo00OO_O0_o_);
			oo00OO_O0_o_.O__.o0o. = this;
			oo00OO_O0_o_.O__.o0o. = chunkHandler;
			oo00OO_O0_o_.O__.o0o. = -1;
			oo00OO_O0_o_.O__.o0o. = AsyncTaskMethodBuilder<JObject>.Create();
			oo00OO_O0_o_.O__.o0o..Start<HttpClient.oo00OO_O0_o_>(ref oo00OO_O0_o_);
			return oo00OO_O0_o_.O__.o0o..Task;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000B3F77 File Offset: 0x000B2177
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x000B3F7F File Offset: 0x000B217F
		internal bool RunOnServer { get; set; }

		// Token: 0x06001952 RID: 6482 RVA: 0x000B3F88 File Offset: 0x000B2188
		private void <<EMPTY_NAME>>(Action<string, string> A_0, string A_1, string A_2)
		{
			HttpClient.b b = new HttpClient.b();
			b.a = A_0;
			b.a = A_1;
			b.b = A_2;
			if (b.a != null)
			{
				if (this.RunOnServer)
				{
					b.a(b.a, b.b);
					return;
				}
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(b.a));
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000B3FF0 File Offset: 0x000B21F0
		private Task<JObject> <<EMPTY_NAME>>(Action<string, string> A_0)
		{
			HttpClient.c c = default(HttpClient.c);
			c.a = this;
			c.a = A_0;
			c.a = -1;
			c.a = AsyncTaskMethodBuilder<JObject>.Create();
			c.a.Start<HttpClient.c>(ref c);
			return c.a.Task;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000B4044 File Offset: 0x000B2244
		private void <<EMPTY_NAME>>(HttpWebResponse A_0)
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator enumerator = A_0.Cookies.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Cookie cookie = (Cookie)obj;
					IL_24:
					num2 = 3;
					this.RCookies.Add(OO_00oOO.O_0.0O__O0.(cookie.Name), OO_00oOO.O_0.0O__O0.(cookie.Value));
					IL_49:
					num2 = 4;
				}
				IL_53:
				num2 = 5;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_68:
				num2 = 6;
				this.LastModified = A_0.LastModified;
				IL_76:
				num2 = 7;
				this.ResponseContentType = A_0.ContentType;
				IL_84:
				num2 = 8;
				this.ResponseContentLength = A_0.ContentLength;
				IL_92:
				num2 = 9;
				this.StatusCode = (int)A_0.StatusCode;
				IL_A1:
				num2 = 10;
				this.StatusDescription = A_0.StatusDescription;
				IL_B0:
				num2 = 11;
				int num3 = A_0.Headers.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_C7:
					num2 = 12;
					this.ResponseHeaders.Add(A_0.Headers.Keys[i], A_0.Headers[i]);
					IL_F4:
					num2 = 13;
				}
				IL_103:
				goto IL_18D;
				IL_108:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_14E:
				goto IL_182;
				IL_150:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_160:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_150;
			}
			IL_182:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_18D:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x17000548 RID: 1352
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x000B4204 File Offset: 0x000B2404
		internal string Select
		{
			set
			{
				this.FormData["Select"] = O00.ooo000o_0.00o0.(value, "fox", "table");
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000B4228 File Offset: 0x000B2428
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.Files.Count <= 0)
				{
					goto IL_24;
				}
				IL_17:
				num2 = 3;
				this.O0o__._0_0O___.();
				goto IL_3D8;
				IL_24:
				num2 = 5;
				string text = "";
				IL_2C:
				num2 = 6;
				Encoding encoding = Encoding.GetEncoding(this.oOO0.0oOOOo.);
				IL_3B:
				num2 = 7;
				if (this.Timeout <= 0)
				{
					goto IL_5F;
				}
				IL_46:
				num2 = 8;
				this.O_0_.0O..Timeout = this.Timeout * 1000;
				IL_5F:
				num2 = 9;
				if (this.ReadWriteTimeout <= 0)
				{
					goto IL_85;
				}
				IL_6B:
				num2 = 10;
				this.O_0_.0O..ReadWriteTimeout = this.ReadWriteTimeout * 1000;
				IL_85:
				num2 = 11;
				CookieContainer cookieContainer = new CookieContainer();
				IL_8F:
				num2 = 12;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.o.__00OOO..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = enumerator.Current;
					IL_AF:
					num2 = 13;
					Cookie cookie;
					if (this.EncodeCookie)
					{
						IL_BA:
						num2 = 14;
						cookie = new Cookie(OO_00oOO.o_.0_OoOo0_0.(text2), OO_00oOO.o_.0_OoOo0_0.(this.o.__00OOO.[text2]));
					}
					else
					{
						IL_DF:
						num2 = 16;
						cookie = new Cookie(OO_00oOO.o_.0_OoOo0_0.(text2), this.o.__00OOO.[text2]);
					}
					IL_FD:
					num2 = 17;
					cookie.Domain = this.O0o__._0_0O___.;
					IL_10D:
					num2 = 18;
					cookieContainer.Add(cookie);
					IL_119:
					num2 = 19;
				}
				IL_125:
				num2 = 20;
				((IDisposable)enumerator).Dispose();
				IL_135:
				num2 = 21;
				this.O_0_.0O..CookieContainer = cookieContainer;
				IL_145:
				num2 = 22;
				if (Operators.CompareString(this.Method, "", true) <= 0)
				{
					goto IL_1C8;
				}
				IL_15C:
				num2 = 23;
				this.O_0_.0O..Method = this.Method;
				IL_170:
				num2 = 24;
				if (Operators.CompareString(this.ContentType, "", true) <= 0)
				{
					goto IL_19B;
				}
				IL_187:
				num2 = 25;
				this.O_0_.0O..ContentType = this.ContentType;
				IL_19B:
				num2 = 26;
				if (Operators.CompareString(this.O_0_.0O..Method, "post", true) != 0)
				{
					goto IL_321;
				}
				IL_1B9:
				num2 = 27;
				text = this.Content;
				goto IL_321;
				IL_1C8:
				num2 = 29;
				if (this.o00__oO.0OO..Count <= 0)
				{
					goto IL_2A2;
				}
				IL_1DC:
				num2 = 30;
				this.O_0_.0O..Method = "post";
				IL_1EF:
				num2 = 31;
				this.O_0_.0O..ContentType = "application/x-www-form-urlencoded; charset=" + this.oOO0.0oOOOo.;
				IL_20D:
				num2 = 32;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2 = this.o00__oO.0OO..Keys.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text3 = enumerator2.Current;
					IL_22D:
					num2 = 33;
					text = string.Concat(new string[]
					{
						text,
						OO_00oOO.o_.0_OoOo0_0.(text3),
						"=",
						OO_00oOO.o_.0_OoOo0_0.(this.o00__oO.0OO.[text3]),
						"&"
					});
					IL_26F:
					num2 = 34;
				}
				IL_27B:
				num2 = 35;
				((IDisposable)enumerator2).Dispose();
				IL_28B:
				num2 = 36;
				text = text.Trim(new char[]
				{
					'&'
				});
				goto IL_321;
				IL_2A2:
				num2 = 38;
				if (Operators.CompareString(this.Content, "", true) <= 0)
				{
					goto IL_321;
				}
				IL_2B9:
				num2 = 39;
				this.O_0_.0O..Method = "post";
				IL_2CC:
				num2 = 40;
				if (Operators.CompareString(this.ContentType, "", true) <= 0)
				{
					goto IL_2F9;
				}
				IL_2E3:
				num2 = 41;
				this.O_0_.0O..ContentType = this.ContentType;
				goto IL_317;
				IL_2F9:
				num2 = 43;
				this.O_0_.0O..ContentType = "text/plain; charset=" + this.oOO0.0oOOOo.;
				IL_317:
				num2 = 44;
				text = this.Content;
				IL_321:
				num2 = 45;
				this.O.__oOOoO0oo.();
				IL_32A:
				num2 = 46;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_3D8;
				}
				IL_33F:
				num2 = 47;
				MemoryStream memoryStream = new MemoryStream(encoding.GetBytes(text));
				IL_351:
				num2 = 48;
				byte[] array = new byte[51201];
				IL_360:
				num2 = 49;
				this.O_0_.0O..ContentLength = memoryStream.Length;
				IL_375:
				num2 = 50;
				Stream requestStream = this.O_0_.0O..GetRequestStream();
				IL_385:
				num2 = 51;
				int num3 = memoryStream.Read(array, 0, array.Length);
				for (;;)
				{
					IL_3BC:
					num2 = 53;
					if (num3 <= 0)
					{
						break;
					}
					IL_39A:
					num2 = 54;
					requestStream.Write(array, 0, num3);
					IL_3A9:
					num2 = 55;
					num3 = memoryStream.Read(array, 0, array.Length);
				}
				IL_3C4:
				num2 = 57;
				requestStream.Close();
				IL_3CE:
				num2 = 58;
				memoryStream.Dispose();
				IL_3D8:
				goto IL_516;
				IL_3DD:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_4D7:
				goto IL_50B;
				IL_4D9:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4E9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4D9;
			}
			IL_50B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_516:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000B4770 File Offset: 0x000B2970
		private void <<EMPTY_NAME>>()
		{
			if (this.Headers.Count > 0)
			{
				try
				{
					foreach (string text in this.Headers.Keys)
					{
						string left = text;
						if (Operators.CompareString(left, "Accept", true) == 0)
						{
							this.O_0_.0O..Accept = this.Headers[text];
						}
						else if (Operators.CompareString(left, "Expect", true) == 0)
						{
							this.O_0_.0O..Expect = this.Headers[text];
						}
						else if (Operators.CompareString(left, "UserAgent", true) == 0)
						{
							this.O_0_.0O..UserAgent = this.Headers[text];
						}
						else if (Operators.CompareString(left, "ContentType", true) == 0)
						{
							this.O_0_.0O..ContentType = this.Headers[text];
						}
						else if (Operators.CompareString(left, "TransferEncoding", true) == 0)
						{
							this.O_0_.0O..TransferEncoding = this.Headers[text];
						}
						else if (Operators.CompareString(left, "Connection", true) == 0)
						{
							this.O_0_.0O..Connection = this.Headers[text];
						}
						else if (Operators.CompareString(left, "IfModifiedSince", true) == 0)
						{
							DateTime ifModifiedSince;
							if (DateTime.TryParse(this.Headers[text], out ifModifiedSince))
							{
								this.O_0_.0O..IfModifiedSince = ifModifiedSince;
							}
						}
						else if (Operators.CompareString(left, "Referer", true) == 0)
						{
							this.O_0_.0O..Referer = this.Headers[text];
						}
						else
						{
							this.O_0_.0O..Headers.Add(text, this.Headers[text]);
						}
					}
				}
				finally
				{
					Dictionary<string, string>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (!string.IsNullOrEmpty(this.UserAgent))
			{
				this.O_0_.0O..UserAgent = this.UserAgent;
			}
			if (!string.IsNullOrEmpty(this.Accept))
			{
				this.O_0_.0O..Accept = this.Accept;
			}
			if (this.gzip)
			{
				this.O_0_.0O..Headers.Add("Accept-Encoding", "gzip");
			}
			if (this.deflate)
			{
				this.O_0_.0O..Headers.Add("Accept-Encoding", "deflate");
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000B49D4 File Offset: 0x000B2BD4
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IL_09:
				num2 = 3;
				Encoding encoding = Encoding.GetEncoding(this.oOO0.0oOOOo.);
				IL_17:
				num2 = 4;
				this.O_0_.0O..Headers.Add("charset", this.oOO0.0oOOOo.);
				IL_34:
				num2 = 5;
				if (this.Timeout <= 0)
				{
					goto IL_58;
				}
				IL_3F:
				num2 = 6;
				this.O_0_.0O..Timeout = this.Timeout * 1000;
				IL_58:
				num2 = 7;
				if (this.ReadWriteTimeout <= 0)
				{
					goto IL_7C;
				}
				IL_63:
				num2 = 8;
				this.O_0_.0O..ReadWriteTimeout = this.ReadWriteTimeout * 1000;
				IL_7C:
				num2 = 9;
				CookieContainer cookieContainer = new CookieContainer();
				IL_86:
				num2 = 10;
				if (this.o.__00OOO..Count <= 0)
				{
					goto IL_140;
				}
				IL_9A:
				num2 = 11;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.o.__00OOO..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_BA:
					num2 = 12;
					Cookie cookie;
					if (this.EncodeCookie)
					{
						IL_C5:
						num2 = 13;
						cookie = new Cookie(OO_00oOO.o_.0_OoOo0_0.(text), OO_00oOO.o_.0_OoOo0_0.(this.o.__00OOO.[text]));
					}
					else
					{
						IL_EA:
						num2 = 15;
						cookie = new Cookie(OO_00oOO.o_.0_OoOo0_0.(text), this.o.__00OOO.[text]);
					}
					IL_108:
					num2 = 16;
					cookie.Domain = this.O0o__._0_0O___.;
					IL_118:
					num2 = 17;
					cookieContainer.Add(cookie);
					IL_124:
					num2 = 18;
				}
				IL_130:
				num2 = 19;
				((IDisposable)enumerator).Dispose();
				IL_140:
				num2 = 20;
				this.O_0_.0O..CookieContainer = cookieContainer;
				IL_150:
				num2 = 21;
				this.O.__oOOoO0oo.();
				IL_159:
				num2 = 22;
				string str = "----" + OoOo0O.OO_o.0o_O.(34);
				IL_16F:
				num2 = 23;
				this.O_0_.0O..ContentType = "multipart/form-data; boundary=" + str;
				IL_189:
				num2 = 24;
				this.O_0_.0O..Method = "post";
				IL_19C:
				num2 = 25;
				Stream requestStream = this.O_0_.0O..GetRequestStream();
				IL_1AC:
				num2 = 26;
				StringBuilder stringBuilder = new StringBuilder();
				IL_1B6:
				num2 = 27;
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2 = this.o00__oO.0OO..Keys.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text2 = enumerator2.Current;
					IL_1D6:
					num2 = 28;
					stringBuilder.AppendLine("--" + str);
					IL_1ED:
					num2 = 29;
					stringBuilder.AppendLine("Content-Disposition: form-data; name=\"" + text2 + "\"");
					IL_209:
					num2 = 30;
					stringBuilder.AppendLine();
					IL_214:
					num2 = 31;
					stringBuilder.AppendLine(this.o00__oO.0OO.[text2]);
					IL_22C:
					num2 = 32;
				}
				IL_238:
				num2 = 33;
				((IDisposable)enumerator2).Dispose();
				IL_248:
				num2 = 34;
				byte[] bytes = encoding.GetBytes(stringBuilder.ToString());
				IL_25A:
				num2 = 35;
				requestStream.Write(bytes, 0, bytes.Length);
				IL_26B:
				num2 = 36;
				Dictionary<string, List<string>>.KeyCollection.Enumerator enumerator3 = this.Files.Keys.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string text3 = enumerator3.Current;
					IL_28E:
					num2 = 37;
					List<string>.Enumerator enumerator4 = this.Files[text3].GetEnumerator();
					while (enumerator4.MoveNext())
					{
						string path = enumerator4.Current;
						IL_2B3:
						num2 = 38;
						stringBuilder = new StringBuilder();
						IL_2BD:
						num2 = 39;
						stringBuilder.AppendLine("--" + str);
						IL_2D4:
						num2 = 40;
						stringBuilder.AppendLine(string.Concat(new string[]
						{
							"Content-Disposition: form-data; name=\"",
							text3,
							"\"; filename=\"",
							OO_00oOO.FileSys.GetName(path),
							"\""
						}));
						IL_316:
						num2 = 41;
						stringBuilder.AppendLine("Content-Type: application/octet-stream");
						IL_326:
						num2 = 42;
						stringBuilder.AppendLine();
						IL_331:
						num2 = 43;
						bytes = encoding.GetBytes(stringBuilder.ToString());
						IL_343:
						num2 = 44;
						requestStream.Write(bytes, 0, bytes.Length);
						IL_354:
						num2 = 45;
						FileStream fileStream = new FileStream(path, FileMode.Open);
						IL_361:
						num2 = 46;
						byte[] array = new byte[51201];
						IL_370:
						num2 = 47;
						int num3 = fileStream.Read(array, 0, array.Length);
						for (;;)
						{
							IL_3A7:
							num2 = 49;
							if (num3 <= 0)
							{
								break;
							}
							IL_385:
							num2 = 50;
							requestStream.Write(array, 0, num3);
							IL_394:
							num2 = 51;
							num3 = fileStream.Read(array, 0, array.Length);
						}
						IL_3AF:
						num2 = 53;
						fileStream.Close();
						IL_3B9:
						num2 = 54;
						bytes = encoding.GetBytes("\r\n");
						IL_3C9:
						num2 = 55;
						requestStream.Write(bytes, 0, bytes.Length);
						IL_3DA:
						num2 = 56;
					}
					IL_3E9:
					num2 = 57;
					((IDisposable)enumerator4).Dispose();
					IL_3F9:
					num2 = 58;
				}
				IL_408:
				num2 = 59;
				((IDisposable)enumerator3).Dispose();
				IL_418:
				num2 = 60;
				bytes = encoding.GetBytes("--" + str + "--\r\n");
				IL_434:
				num2 = 61;
				requestStream.Write(bytes, 0, bytes.Length);
				IL_445:
				num2 = 62;
				requestStream.Close();
				IL_44F:
				goto IL_59D;
				IL_454:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_55E:
				goto IL_592;
				IL_560:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_570:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_560;
			}
			IL_592:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_59D:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x000B4FA4 File Offset: 0x000B31A4
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x000B4FAC File Offset: 0x000B31AC
		public DateTime LastModified { get; set; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000B4FB5 File Offset: 0x000B31B5
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x000B4FBD File Offset: 0x000B31BD
		public int StatusCode { get; set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000B4FC6 File Offset: 0x000B31C6
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x000B4FCE File Offset: 0x000B31CE
		public string StatusDescription { get; set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x000B4FD7 File Offset: 0x000B31D7
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x000B4FDF File Offset: 0x000B31DF
		public string ResponseContentType { get; set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		public long ResponseContentLength { get; set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x000B4FF9 File Offset: 0x000B31F9
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x000B5001 File Offset: 0x000B3201
		public NameValueCollection ResponseHeaders { get; set; }

		/// <summary>
		/// 提前获取内容信息，此方法执行之后并不会关闭和服务端的连
		/// </summary>
		// Token: 0x06001965 RID: 6501 RVA: 0x000B500C File Offset: 0x000B320C
		[oO0oooo("A3278")]
		public bool GetInformation()
		{
			try
			{
				this.oo__.o_.();
				HttpWebResponse a_ = (HttpWebResponse)this.O_0_.0O..GetResponse();
				this.oOO.__.(a_);
				this.o00__oO.0OO. = a_;
				return true;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					WebException ex2 = (WebException)ex;
					if (ex2.Response is HttpWebResponse)
					{
						this.StatusCode = (int)((HttpWebResponse)ex2.Response).StatusCode;
						this.StatusDescription = ((HttpWebResponse)ex2.Response).StatusDescription;
						if (this.O_o0.00.)
						{
							return false;
						}
					}
				}
				if (!this.O_o0.00.)
				{
					ooO.oOo0Oo.o.(ex, "");
				}
				else
				{
					this.RCookies["Error"] = ex.Message;
				}
			}
			return false;
		}

		/// <summary>
		/// 关闭连接
		/// </summary>
		// Token: 0x06001966 RID: 6502 RVA: 0x000B50EC File Offset: 0x000B32EC
		public void Close()
		{
			if (this.o00__oO.0OO. != null)
			{
				this.o00__oO.0OO..Close();
			}
		}

		/// <summary>
		/// 获取或设置 Accept 标头的值
		/// </summary>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x000B5101 File Offset: 0x000B3301
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x000B5109 File Offset: 0x000B3309
		public string Accept
		{
			get
			{
				return this.O_O__ooOO_._O.;
			}
			set
			{
				this.O_O__ooOO_._O. = value;
			}
		}

		/// <summary>
		/// 是否跳过错误提示
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x000B5112 File Offset: 0x000B3312
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x000B511A File Offset: 0x000B331A
		[oO0oooo("A0294")]
		public bool SkipError
		{
			get
			{
				return this.O_o0.00.;
			}
			set
			{
				this.O_o0.00. = value;
			}
		}

		/// <summary>
		/// 字符串性，用于设置请求方式，通常无需设置，由HttpClient根据提交的内容自行决定
		/// </summary>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x000B5123 File Offset: 0x000B3323
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x000B512B File Offset: 0x000B332B
		public string Method
		{
			get
			{
				return this.oOo0_.O_O0.;
			}
			set
			{
				this.oOo0_.O_O0. = value;
			}
		}

		/// <summary>
		/// 是否允许使用gzip压缩传输方式
		/// </summary>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000B5134 File Offset: 0x000B3334
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x000B513C File Offset: 0x000B333C
		public bool gzip
		{
			get
			{
				return this.oOO0.0oOOOo.;
			}
			set
			{
				this.oOO0.0oOOOo. = value;
			}
		}

		/// <summary>
		/// 是否允许使用deflate压缩传输方式
		/// </summary>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000B5145 File Offset: 0x000B3345
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x000B514D File Offset: 0x000B334D
		public bool deflate
		{
			get
			{
				return this.oo__.o_.;
			}
			set
			{
				this.oo__.o_. = true;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000B5156 File Offset: 0x000B3356
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x000B5163 File Offset: 0x000B3363
		public string Referer
		{
			get
			{
				return this.O_0_.0O..Referer;
			}
			set
			{
				this.O_0_.0O..Referer = value;
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000B5174 File Offset: 0x000B3374
		public Task<WsConnectResult> GetWebSocketAsync()
		{
			HttpClient.a a = default(HttpClient.a);
			a.a = this;
			a.a = -1;
			a.a = AsyncTaskMethodBuilder<WsConnectResult>.Create();
			a.a.Start<HttpClient.a>(ref a);
			return a.a.Task;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000B51BF File Offset: 0x000B33BF
		[CompilerGenerated]
		private string <<EMPTY_NAME>>()
		{
			return this.GetData();
		}

		// Token: 0x04000A28 RID: 2600
		private HttpWebRequest <<EMPTY_NAME>>;

		// Token: 0x04000A29 RID: 2601
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000A2A RID: 2602
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000A2B RID: 2603
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000A2C RID: 2604
		private HttpFilleCollection <<EMPTY_NAME>>;

		// Token: 0x04000A2D RID: 2605
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A2E RID: 2606
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A2F RID: 2607
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A30 RID: 2608
		private int <<EMPTY_NAME>>;

		// Token: 0x04000A31 RID: 2609
		private int <<EMPTY_NAME>>;

		// Token: 0x04000A32 RID: 2610
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A33 RID: 2611
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A34 RID: 2612
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000A35 RID: 2613
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A36 RID: 2614
		private HttpWebResponse <<EMPTY_NAME>>;

		// Token: 0x04000A37 RID: 2615
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A38 RID: 2616
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A39 RID: 2617
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A3A RID: 2618
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A3B RID: 2619
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A3C RID: 2620
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000A3D RID: 2621
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A3E RID: 2622
		[CompilerGenerated]
		private bool a;

		// Token: 0x04000A3F RID: 2623
		private CancellationTokenSource <<EMPTY_NAME>>;

		// Token: 0x04000A40 RID: 2624
		[CompilerGenerated]
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04000A41 RID: 2625
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000A42 RID: 2626
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A43 RID: 2627
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A44 RID: 2628
		[CompilerGenerated]
		private long <<EMPTY_NAME>>;

		// Token: 0x04000A45 RID: 2629
		[CompilerGenerated]
		private NameValueCollection <<EMPTY_NAME>>;

		// Token: 0x020001F2 RID: 498
		[CompilerGenerated]
		internal sealed class o0oO
		{
			// Token: 0x06001976 RID: 6518 RVA: 0x000B51CF File Offset: 0x000B33CF
			internal bool <<EMPTY_NAME>>()
			{
				return this.O_0_.0O..GetFile(this.O_0_.0O.);
			}

			// Token: 0x04000A46 RID: 2630
			public string <<EMPTY_NAME>>;

			// Token: 0x04000A47 RID: 2631
			public HttpClient <<EMPTY_NAME>>;
		}

		// Token: 0x020001F5 RID: 501
		[CompilerGenerated]
		internal sealed class o_00oOo
		{
			// Token: 0x0600197C RID: 6524 RVA: 0x000B53CC File Offset: 0x000B35CC
			internal Task<JObject> <<EMPTY_NAME>>()
			{
				HttpClient.o_00oOo.a a = default(HttpClient.o_00oOo.a);
				a.OoOO0o0O.o0. = this;
				a.OoOO0o0O.o0. = -1;
				a.OoOO0o0O.o0. = AsyncTaskMethodBuilder<JObject>.Create();
				a.OoOO0o0O.o0..Start<HttpClient.o_00oOo.a>(ref a);
				return a.OoOO0o0O.o0..Task;
			}

			// Token: 0x04000A51 RID: 2641
			public Action<string, string> <<EMPTY_NAME>>;

			// Token: 0x04000A52 RID: 2642
			public HttpClient <<EMPTY_NAME>>;
		}

		// Token: 0x020001F8 RID: 504
		[CompilerGenerated]
		internal sealed class o_O_
		{
			// Token: 0x06001982 RID: 6530 RVA: 0x000B5614 File Offset: 0x000B3814
			internal Task<JObject> <<EMPTY_NAME>>()
			{
				HttpClient.o_O_.a a = default(HttpClient.o_O_.a);
				a.Oo_O_o0__._0_. = this;
				a.Oo_O_o0__._0_. = -1;
				a.Oo_O_o0__._0_. = AsyncTaskMethodBuilder<JObject>.Create();
				a.Oo_O_o0__._0_..Start<HttpClient.o_O_.a>(ref a);
				return a.Oo_O_o0__._0_..Task;
			}

			// Token: 0x04000A5D RID: 2653
			public Action<string, string> <<EMPTY_NAME>>;

			// Token: 0x04000A5E RID: 2654
			public HttpClient <<EMPTY_NAME>>;
		}

		// Token: 0x020001FB RID: 507
		[CompilerGenerated]
		internal sealed class b
		{
			// Token: 0x06001988 RID: 6536 RVA: 0x000B584A File Offset: 0x000B3A4A
			internal void a()
			{
				this.a(this.a, this.b);
			}

			// Token: 0x04000A68 RID: 2664
			public Action<string, string> a;

			// Token: 0x04000A69 RID: 2665
			public string a;

			// Token: 0x04000A6A RID: 2666
			public string b;
		}
	}
}
