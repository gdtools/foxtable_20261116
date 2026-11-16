using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using C1.C1Excel;
using Foxtable.XLS;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020001EF RID: 495
	public class RequestEventArgs
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x000AEDB2 File Offset: 0x000ACFB2
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x000AEDBA File Offset: 0x000ACFBA
		public bool Cancel { get; set; }

		// Token: 0x060018DB RID: 6363 RVA: 0x000AEDC4 File Offset: 0x000ACFC4
		internal RequestEventArgs(HttpListenerContext A_0, string A_1, List<string> A_2)
		{
			this.oo_OO_0._O0O. = new Dictionary<string, string>();
			this.oo_OO_0._O0O. = new Dictionary<string, List<string>>();
			this.o0__O0.o_0. = new HttpDictionary();
			this.o0__0oOoo_.o. = new HttpDictionary();
			this.O.OOooO0o_O__o. = new HttpDictionary();
			this.o_00.OO0O. = new HttpDictionary();
			this.o0__O0.o_0. = "utf-8";
			this.Oo._00O_0Oo. = "utf-8";
			this.oo_OO_0._O0O. = -1;
			this.oo_OO_0._O0O. = A_0;
			this.o0__O0.o_0. = A_0.Request;
			this.o0__O0.o_0. = A_0.Response;
			this.O_OOo_.0oO_. = A_1;
			this.oo_OO_0._O0O. = A_2;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x000AEE63 File Offset: 0x000AD063
		public HttpListenerContext Context
		{
			get
			{
				return this.oo_OO_0._O0O.;
			}
		}

		/// <summary>
		/// 通知系统,将采用异步方式生成网页
		/// </summary>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x000AEE6B File Offset: 0x000AD06B
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x000AEE73 File Offset: 0x000AD073
		[oO0oooo("A278")]
		public bool AsyncExecute
		{
			get
			{
				return this.o0__0oOoo_.o.;
			}
			set
			{
				this.o0__0oOoo_.o. = true;
			}
		}

		/// <summary>
		/// 设置缓存时间，单位为秒，在指定缓存时间内，将不再访问服务器重新下载内容
		/// </summary>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x000AEE7C File Offset: 0x000AD07C
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x000AEE84 File Offset: 0x000AD084
		[oO0oooo("A3275")]
		public int CacheTime
		{
			get
			{
				return this.oo_OO_0._O0O.;
			}
			set
			{
				this.oo_OO_0._O0O. = value;
				this.o0__O0.o_0..Headers["Cache-Control"] = "max-age=" + Conversions.ToString(value);
			}
		}

		/// <summary>
		/// 通知系统异步函数执行完毕,可以关闭信道
		/// </summary>
		// Token: 0x17000528 RID: 1320
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x000AEEB4 File Offset: 0x000AD0B4
		[oO0oooo("A278")]
		public bool Handled
		{
			set
			{
				if (value)
				{
					this.o0__O0.o_0..Clear();
					this.oo_OO_0._O0O..Clear();
					try
					{
						foreach (string text in this.oo_OO_0._O0O..Keys)
						{
						}
					}
					finally
					{
						Dictionary<string, string>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.oo_OO_0._O0O..Clear();
					try
					{
						this.Request.InputStream.Close();
						if (!this.oo0o.oo_oOoOo0.)
						{
							this.Response.OutputStream.Close();
							this.Response.Close();
							this.Response.Abort();
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		/// <summary>
		/// 返回一个HttpListenerRequest对象，适合专业开发人员使用
		/// </summary>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x000AEF88 File Offset: 0x000AD188
		public HttpListenerRequest Request
		{
			get
			{
				return this.o0__O0.o_0.;
			}
		}

		/// <summary>
		/// 返回一个HttpListenerResponse对象，适合专业人员使用
		/// </summary>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x000AEF90 File Offset: 0x000AD190
		public HttpListenerResponse Response
		{
			get
			{
				return this.o0__O0.o_0.;
			}
		}

		/// <summary>
		/// 返回接收到的数据，包括通过post和get方式提交的数据
		/// </summary>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x000AEF98 File Offset: 0x000AD198
		[oO0oooo("A0113")]
		public HttpDictionary Values
		{
			get
			{
				if (!this.O_0O00.o.)
				{
					this.O0_OO0oOO.O_0O.();
				}
				return this.o0__O0.o_0.;
			}
		}

		/// <summary>
		/// 返回接收到的文件
		/// </summary>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x000AEFAE File Offset: 0x000AD1AE
		[oO0oooo("A0030")]
		public Dictionary<string, List<string>> Files
		{
			get
			{
				return this.oo_OO_0._O0O.;
			}
		}

		/// <summary>
		/// 返回接收到的Cookie
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x000AEFB6 File Offset: 0x000AD1B6
		[oO0oooo("A0042")]
		public HttpDictionary Cookies
		{
			get
			{
				if (!this.O_0O00.o.)
				{
					this.O0_OO0oOO.O_0O.();
				}
				return this.o_00.OO0O.;
			}
		}

		/// <summary>
		/// 增加Cookie
		/// </summary>
		/// <param name="name">Cookie的名称</param>
		/// <param name="value">Cookie的值</param>
		// Token: 0x060018E7 RID: 6375 RVA: 0x000AEFCC File Offset: 0x000AD1CC
		[oO0oooo("A0042")]
		public void AppendCookie(string name, string value)
		{
			value = OO_00oOO.o_.0_OoOo0_0.(value);
			if (value.IndexOf("'") >= 0)
			{
				value = value.Replace("'", "%27");
			}
			Cookie cookie = new Cookie(OO_00oOO.o_.0_OoOo0_0.(name), value);
			this.Response.AppendCookie(cookie);
		}

		/// <summary>
		/// 字符型，返回客户端访问的服务器IP地址(或域名)
		/// </summary>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x000AF01A File Offset: 0x000AD21A
		[oO0oooo("A0006")]
		public string Host
		{
			get
			{
				return this.Request.Url.Host;
			}
		}

		/// <summary>
		/// 返回客户端访问的服务器端口号
		/// </summary>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x000AF02C File Offset: 0x000AD22C
		[oO0oooo("A0006")]
		public int Port
		{
			get
			{
				return this.Request.Url.Port;
			}
		}

		/// <summary>
		/// 字符型，返回客户端访问的路径，含文件名
		/// </summary>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x000AF040 File Offset: 0x000AD240
		[oO0oooo("A0006")]
		public string path
		{
			get
			{
				string text = HttpUtility.UrlDecode(this.Request.RawUrl);
				if (Operators.CompareString(text, "", true) > 0 && text.IndexOf("?") >= 0)
				{
					text = text.Substring(0, text.IndexOf("?"));
				}
				return text.Trim(new char[]
				{
					'/'
				}).Trim(new char[]
				{
					'\\'
				}).Replace("/", "\\");
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x000AF0C0 File Offset: 0x000AD2C0
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		public string RequestEncoding
		{
			get
			{
				return this.o0__O0.o_0.;
			}
			set
			{
				this.o0__O0.o_0. = value;
			}
		}

		/// <summary>
		/// 字符型，用于设置向客户端发送文本内容时采用的编码
		/// </summary>
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x000AF0D1 File Offset: 0x000AD2D1
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x000AF0D9 File Offset: 0x000AD2D9
		[oO0oooo("A0022")]
		public string ResponseEncoding
		{
			get
			{
				return this.Oo._00O_0Oo.;
			}
			set
			{
				this.Oo._00O_0Oo. = value;
			}
		}

		/// <summary>
		/// 设置返回给客户端的HTTP状态代码
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x000AF0E2 File Offset: 0x000AD2E2
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x000AF0EF File Offset: 0x000AD2EF
		public int StatusCode
		{
			get
			{
				return this.Response.StatusCode;
			}
			set
			{
				this.Response.StatusCode = value;
			}
		}

		/// <summary>
		/// 用于获取客户端发来的头部信息
		/// </summary>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000AF0FD File Offset: 0x000AD2FD
		[oO0oooo("A3279")]
		public NameValueCollection Headers
		{
			get
			{
				return this.Request.Headers;
			}
		}

		/// <summary>
		/// 用于设置向客户端发送的头部信息
		/// </summary>
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000AF10A File Offset: 0x000AD30A
		[oO0oooo("A3279")]
		public NameValueCollection ResponseHeaders
		{
			get
			{
				return this.Response.Headers;
			}
		}

		/// <summary>
		/// 设置返回给客户端的HTTP状态代码的文本说明
		/// </summary>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000AF117 File Offset: 0x000AD317
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x000AF124 File Offset: 0x000AD324
		public string StatusDescription
		{
			get
			{
				return this.Response.StatusDescription;
			}
			set
			{
				this.Response.StatusDescription = value;
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000AF134 File Offset: 0x000AD334
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SaveFile(string ID, int idx, string LocalFileName)
		{
			OO_00oOO.FileSys.GetParentPath(LocalFileName);
			if (this.Files.ContainsKey(ID) && this.Files.Count > idx)
			{
				this.SaveFile(ID, this.Files[ID][idx], LocalFileName);
			}
		}

		/// <summary>
		/// 保存客户端上传的文件
		/// </summary>
		/// <param name="Key">文件上传组件的name属性</param>
		/// <param name="UploadFile">用户上传的文件名称，不含路径</param>
		/// <param name="LocalFile">要保存到本地的文件名称，含路径</param>
		// Token: 0x060018F6 RID: 6390 RVA: 0x000AF184 File Offset: 0x000AD384
		[oO0oooo("A0030")]
		public void SaveFile(string Key, string UploadFile, string LocalFile)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(UploadFile, "", true) != 0)
				{
					goto IL_67;
				}
				IL_17:
				num2 = 3;
				if (!OO_00oOO.FileSys.FileExists(this.oo_OO_0._O0O.[Key + "_" + UploadFile]))
				{
					goto IL_110;
				}
				IL_3F:
				num2 = 4;
				OO_00oOO.FileSys.DeleteFile(this.oo_OO_0._O0O.[Key + "_" + UploadFile]);
				goto IL_110;
				IL_67:
				num2 = 6;
				string parentPath = OO_00oOO.FileSys.GetParentPath(LocalFile);
				IL_75:
				num2 = 7;
				if (!this.Files.ContainsKey(Key) || !this.Files[Key].Contains(UploadFile))
				{
					goto IL_110;
				}
				IL_9C:
				num2 = 10;
				if (Operators.CompareString(parentPath, "", true) <= 0)
				{
					goto IL_CC;
				}
				IL_AE:
				num2 = 11;
				if (OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					goto IL_CC;
				}
				IL_BE:
				num2 = 12;
				OO_00oOO.FileSys.CreateDirectory(parentPath);
				IL_CC:
				num2 = 13;
				if (!OO_00oOO.FileSys.FileExists(LocalFile))
				{
					goto IL_EA;
				}
				IL_DC:
				num2 = 14;
				OO_00oOO.FileSys.DeleteFile(LocalFile);
				IL_EA:
				num2 = 15;
				OO_00oOO.FileSys.MoveFile(this.oo_OO_0._O0O.[Key + "_" + UploadFile], LocalFile, true);
				IL_110:
				goto IL_1A2;
				IL_115:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_163:
				goto IL_197;
				IL_165:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_175:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_165;
			}
			IL_197:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1A2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 字符型，返回收到的纯文本数据
		/// </summary>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x000AF358 File Offset: 0x000AD558
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x000AF360 File Offset: 0x000AD560
		[oO0oooo("A0108")]
		public string PlainText
		{
			get
			{
				return this.O.OOooO0o_O__o.;
			}
			internal set
			{
				this.O.OOooO0o_O__o. = value;
			}
		}

		/// <summary>
		/// 集合，包括客户端通过post方式提交的数据
		/// </summary>
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x000AF369 File Offset: 0x000AD569
		[oO0oooo("A0113")]
		public HttpDictionary PostValues
		{
			get
			{
				return this.O.OOooO0o_O__o.;
			}
		}

		/// <summary>
		/// 集合，包括客户端通过get方式提交的数据
		/// </summary>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000AF371 File Offset: 0x000AD571
		[oO0oooo("A0113")]
		public HttpDictionary GetValues
		{
			get
			{
				if (!this.O_0O00.o.)
				{
					this.O0_OO0oOO.O_0O.();
				}
				return this.o0__0oOoo_.o.;
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000AF388 File Offset: 0x000AD588
		[oO0oooo("A0010")]
		public void WriteString(string value, string ContentType)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.("");
				this.ResponseHeaders.Add("Development_Tool", "Foxtable 2022");
				this.oo0o.oo_oOoOo0. = true;
				if (value == null)
				{
					value = "";
				}
				oOo0_o0Oo_00 oOo0_o0Oo_ = new oOo0_o0Oo_00(value, this.Response, this.Oo._00O_0Oo.);
				if (Operators.CompareString(ContentType, "text/html", true) != 0)
				{
					oOo0_o0Oo_.oO0o0o._0.(ContentType);
				}
				ThreadPool.QueueUserWorkItem(new WaitCallback(oOo0_o0Oo_.Oo000.o00.), null);
			}
		}

		/// <summary>
		/// 向客户端发送文本内容
		/// </summary>
		/// <param name="value">字符型，要发送的内容</param>
		// Token: 0x060018FC RID: 6396 RVA: 0x000AF409 File Offset: 0x000AD609
		public void WriteString(string value)
		{
			this.WriteString(value, "text/html");
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000AF417 File Offset: 0x000AD617
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.("");
				this.oo0o.oo_oOoOo0. = true;
				if (A_0 == null)
				{
					A_0 = "";
				}
				new oOo0_o0Oo_00(A_0, this.Response, this.Oo._00O_0Oo.).Oo000.o00.(null);
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000AF455 File Offset: 0x000AD655
		private void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.("");
				this.oo0o.oo_oOoOo0. = true;
				new O_o0_0_o0(this, A_0, A_1, A_2).OO0.0_0O0O_0_0.(null);
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000AF480 File Offset: 0x000AD680
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				MemoryStream memoryStream = null;
				bool flag;
				try
				{
					OleDbConnection oleDbConnection = new OleDbConnection(OO_00oOO.Connections[A_1].ConnectionString);
					OleDbCommand oleDbCommand = new OleDbCommand(A_0, oleDbConnection);
					oleDbConnection.Open();
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						if (!oleDbDataReader.IsDBNull(0))
						{
							memoryStream = new MemoryStream((byte[])oleDbDataReader[0]);
						}
						else
						{
							flag = true;
						}
					}
					oleDbDataReader.Close();
					oleDbConnection.Close();
				}
				catch (Exception ex)
				{
					this.AppendCookie("Error", ex.Message);
					this.o_O.oO.("");
					return;
				}
				if (memoryStream == null)
				{
					if (flag)
					{
						this.AppendCookie("IsNull", "True");
					}
					else
					{
						this.AppendCookie("Error", "获取文件失败，错误未知");
					}
					this.o_O.oO.("");
					return;
				}
				memoryStream.Position = 0L;
				new oOO_O__(memoryStream, this.Response).oO0o0o._0.(null);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000AF58C File Offset: 0x000AD78C
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				OleDbConnection oleDbConnection = new OleDbConnection(OO_00oOO.Connections[A_1].ConnectionString);
				try
				{
					OleDbCommand oleDbCommand = new OleDbCommand(A_0, oleDbConnection);
					try
					{
						Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.oo_OO_0._O0O..Keys.GetEnumerator();
						if (enumerator.MoveNext())
						{
							string key = enumerator.Current;
							MemoryStream memoryStream = new MemoryStream();
							FileStream fileStream = File.Open(this.oo_OO_0._O0O.[key], FileMode.Open);
							byte[] array = new byte[51201];
							for (int i = fileStream.Read(array, 0, array.Length); i > 0; i = fileStream.Read(array, 0, array.Length))
							{
								memoryStream.Write(array, 0, i);
							}
							fileStream.Dispose();
							oleDbCommand.Parameters.Add("@File", OleDbType.Binary, (int)memoryStream.Length).Value = memoryStream.ToArray();
							OO_00oOO.FileSys.DeleteFile(this.oo_OO_0._O0O.[key]);
							memoryStream.Dispose();
						}
					}
					finally
					{
						Dictionary<string, string>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					oleDbConnection.Open();
					this.o_O.oO.(oleDbCommand.ExecuteNonQuery().ToString());
				}
				catch (Exception ex)
				{
					this.AppendCookie("Error", ex.Message);
					this.o_O.oO.("");
				}
				finally
				{
					oleDbConnection.Close();
				}
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000AF74C File Offset: 0x000AD94C
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(A_0, ".html", true) == 0 || Operators.CompareString(A_0, ".htm", true) == 0 || Operators.CompareString(A_0, ".css", true) == 0 || Operators.CompareString(A_0, ".js", true) == 0 || Operators.CompareString(A_0, ".txt", true) == 0)
			{
				this.Response.ContentEncoding = HttpFunctions.OO.0o.(this.Oo._00O_0Oo.);
				if (Operators.CompareString(A_0, ".html", true) == 0 || Operators.CompareString(A_0, ".htm", true) == 0)
				{
					this.Response.ContentType = "text/html; charset=" + this.Oo._00O_0Oo.;
					return;
				}
				if (Operators.CompareString(A_0, ".css", true) == 0)
				{
					this.Response.ContentType = "text/css; charset=" + this.Oo._00O_0Oo.;
					return;
				}
				if (Operators.CompareString(A_0, ".js", true) == 0)
				{
					this.Response.ContentType = "application/x-javascript; charset=" + this.Oo._00O_0Oo.;
					return;
				}
				if (Operators.CompareString(A_0, ".txt", true) == 0)
				{
					this.Response.ContentType = "text/plain; charset=" + this.Oo._00O_0Oo.;
					return;
				}
			}
			else
			{
				if (Operators.CompareString(A_0, ".xls", true) == 0 || Operators.CompareString(A_0, ".xlsx", true) == 0)
				{
					this.Response.ContentType = "application/vnd.ms-excel";
					return;
				}
				if (Operators.CompareString(A_0, ".doc", true) == 0 || Operators.CompareString(A_0, ".docx", true) == 0)
				{
					this.Response.ContentType = "application/msword";
					return;
				}
				if (Operators.CompareString(A_0, ".mdb", true) == 0)
				{
					this.Response.ContentType = "application/msaccess";
					return;
				}
				if (Operators.CompareString(A_0, ".pdf", true) == 0)
				{
					this.Response.ContentType = "application/pdf";
					return;
				}
				if (Operators.CompareString(A_0, ".zip", true) == 0 || Operators.CompareString(A_0, ".rar", true) == 0)
				{
					this.Response.ContentType = "application/x-zip-compressed";
					return;
				}
				if (Operators.CompareString(A_0, ".gif", true) == 0)
				{
					this.Response.ContentType = "image/gif";
					return;
				}
				if (Operators.CompareString(A_0, ".jpg", true) == 0 || Operators.CompareString(A_0, ".jpeg", true) == 0)
				{
					this.Response.ContentType = "image/jpeg";
					return;
				}
				if (Operators.CompareString(A_0, ".png", true) == 0)
				{
					this.Response.ContentType = "image/png";
					return;
				}
				this.Response.ContentType = "application/octet-stream";
			}
		}

		/// <summary>
		/// 将Excel工作簿以网页的形式发送给客户端
		/// </summary>
		/// <param name="workbook">工作簿</param>
		// Token: 0x06001902 RID: 6402 RVA: 0x000AF9B8 File Offset: 0x000ADBB8
		[oO0oooo("A0291")]
		public void WriteExcelAsHTML(Workbook workbook)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm";
			string text2 = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm";
			workbook.SaveAs(text, XlFileFormat.xlHtml, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Saved = true;
			workbook.Application.Quit();
			OO_00oOO.FileSys.CopyFile(text, text2);
			this.WriteFile(text2, "");
		}

		/// <summary>
		/// 将Excel工作簿以PDF的形式发送给客户端
		/// </summary>
		/// <param name="workbook">工作簿</param>
		// Token: 0x06001903 RID: 6403 RVA: 0x000AFA80 File Offset: 0x000ADC80
		[oO0oooo("A0291")]
		public void WriteExcelAsPDF(Workbook workbook)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".pdf";
			workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Saved = true;
			workbook.Application.Quit();
			this.WriteFile(text, "");
		}

		/// <summary>
		/// 将Word文件以网页的形式发送给客户端
		/// </summary>
		/// <param name="document">word文档</param>
		// Token: 0x06001904 RID: 6404 RVA: 0x000AFB10 File Offset: 0x000ADD10
		public void WriteWordAsHTML(Document document)
		{
			object obj = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm";
			object obj2 = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm";
			object obj3 = WdSaveFormat.wdFormatHTML;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object obj4 = false;
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			document.SaveAs2(ref obj, ref obj3, ref objectValue, ref objectValue2, ref obj4, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14);
			Microsoft.Office.Interop.Word._Application application = document.Application;
			objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			application.Quit(ref objectValue14, ref objectValue13, ref objectValue12);
			OO_00oOO.FileSys.CopyFile(obj.ToString(), obj2.ToString());
			this.WriteFile(obj2.ToString(), "");
		}

		/// <summary>
		/// 将Word文件以网页的形式发送给客户端
		/// </summary>
		/// <param name="document">word文档</param>
		// Token: 0x06001905 RID: 6405 RVA: 0x000AFC84 File Offset: 0x000ADE84
		public void WriteWordAsPDF(Document document)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".pdf";
			string outputFileName = text;
			WdExportFormat exportFormat = WdExportFormat.wdExportFormatPDF;
			bool openAfterExport = false;
			WdExportOptimizeFor optimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint;
			WdExportRange range = WdExportRange.wdExportAllDocument;
			int from = 1;
			int to = 1;
			WdExportItem item = WdExportItem.wdExportDocumentContent;
			bool includeDocProps = false;
			bool keepIRM = true;
			WdExportCreateBookmarks createBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks;
			bool docStructureTags = true;
			bool bitmapMissingFonts = true;
			bool useISO19005_ = false;
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			document.ExportAsFixedFormat(outputFileName, exportFormat, openAfterExport, optimizeFor, range, from, to, item, includeDocProps, keepIRM, createBookmarks, docStructureTags, bitmapMissingFonts, useISO19005_, ref objectValue);
			Microsoft.Office.Interop.Word._Application application = document.Application;
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			application.Quit(ref objectValue, ref objectValue2, ref objectValue3);
			this.WriteFile(text, "");
		}

		/// <summary>
		/// 向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		/// <param name="fileName">客户端浏览器下载此报表时使用的文件名</param>
		/// <param name="Inline">可选参数，逻辑型，是否直接在浏览器显示报表</param>
		// Token: 0x06001906 RID: 6406 RVA: 0x000AFD08 File Offset: 0x000ADF08
		[oO0oooo("A0148")]
		public void WriteBook(Book Book, string fileName, bool Inline = true)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				if (Operators.CompareString(this.Request.Headers["Range"], "", true) > 0 && Operators.CompareString(this.Request.Headers["range"].Substring(6).Split(new char[]
				{
					'-'
				})[0].Trim(), "0", true) != 0)
				{
					this.Response.ContentLength64 = 0L;
					this.Response.OutputStream.Close();
					this.Response.Close();
					this.Response.Abort();
					return;
				}
				if (Operators.CompareString(Path.GetExtension(fileName), ".xls", true) == 0)
				{
					Book.oO.o_0o__..CompatibilityMode = CompatibilityMode.Excel2003;
				}
				else if (Operators.CompareString(Path.GetExtension(fileName), ".xlsx", true) == 0)
				{
					Book.oO.o_0o__..CompatibilityMode = CompatibilityMode.Excel2007;
				}
				this.Response.ContentEncoding = HttpFunctions.OO.0o.(this.ResponseEncoding);
				ThreadPool.QueueUserWorkItem(new WaitCallback(new o_o_0OO(this.Response, Book, fileName, Inline).OO__o_OOoOo_.0.), null);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000AFE34 File Offset: 0x000AE034
		[oO0oooo("A6051")]
		public void WriteWordCreator(WordCreator Creator, string FileName, bool Inline = true)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				if (Operators.CompareString(this.Request.Headers["Range"], "", true) > 0 && Operators.CompareString(this.Request.Headers["range"].Substring(6).Split(new char[]
				{
					'-'
				})[0].Trim(), "0", true) != 0)
				{
					this.Response.ContentLength64 = 0L;
					this.Response.OutputStream.Close();
					this.Response.Close();
					this.Response.Abort();
					return;
				}
				this.Response.ContentEncoding = HttpFunctions.OO.0o.(this.ResponseEncoding);
				ThreadPool.QueueUserWorkItem(new WaitCallback(new o000OOOO(this.Response, Creator, FileName, Inline).Oo000.o00.), null);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000AFF20 File Offset: 0x000AE120
		public void WritePDFCreator(PDFCreator Creator, string FileName, bool Inline = true)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				if (Operators.CompareString(this.Request.Headers["Range"], "", true) > 0 && Operators.CompareString(this.Request.Headers["range"].Substring(6).Split(new char[]
				{
					'-'
				})[0].Trim(), "0", true) != 0)
				{
					this.Response.ContentLength64 = 0L;
					this.Response.OutputStream.Close();
					this.Response.Close();
					this.Response.Abort();
					return;
				}
				this.Response.ContentEncoding = HttpFunctions.OO.0o.(this.ResponseEncoding);
				ThreadPool.QueueUserWorkItem(new WaitCallback(new o_o_O00_(this.Response, Creator, FileName, Inline).ooO0O.0.), null);
			}
		}

		/// <summary>
		/// 以网页的形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		// Token: 0x06001909 RID: 6409 RVA: 0x000B000B File Offset: 0x000AE20B
		[oO0oooo("A0288")]
		public void WriteBookAsHTML(Book Book)
		{
			this.WriteBookAsHTML(Book, true);
		}

		/// <summary>
		/// 以网页的形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		/// <param name="Build">逻辑型，是否先生成细节区再发送，默认为True</param>
		// Token: 0x0600190A RID: 6410 RVA: 0x000B0018 File Offset: 0x000AE218
		[oO0oooo("A0288")]
		public void WriteBookAsHTML(Book Book, bool Build)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				this.oO_.0.(".htm");
				ThreadPool.QueueUserWorkItem(new WaitCallback(new OO_oO00o(this.Response, Book)
				{
					OO.oO00. = Build
				}.OO.oO00.), null);
			}
		}

		/// <summary>
		/// 以网页的形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		/// <param name="Indexes">整数型，指定无需生成细节区的工作表</param>
		// Token: 0x0600190B RID: 6411 RVA: 0x000B0064 File Offset: 0x000AE264
		[oO0oooo("A0288")]
		public void WriteBookAsHTML(Book Book, params int[] Indexes)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				this.oO_.0.(".htm");
				ThreadPool.QueueUserWorkItem(new WaitCallback(new OO_oO00o(this.Response, Book)
				{
					O_0._00_. = Indexes
				}.OO.oO00.), null);
			}
		}

		/// <summary>
		/// 以PDF形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的工作簿</param>
		// Token: 0x0600190C RID: 6412 RVA: 0x000B00B0 File Offset: 0x000AE2B0
		[oO0oooo("0288")]
		public void WriteBookAsPDF(Book Book)
		{
			this.WriteBookAsPDF(Book, true);
		}

		/// <summary>
		/// 以PDF的形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		/// <param name="Build">逻辑型，是否先生成细节区再发送，默认为True</param>
		// Token: 0x0600190D RID: 6413 RVA: 0x000B00BC File Offset: 0x000AE2BC
		[oO0oooo("A0288")]
		public void WriteBookAsPDF(Book Book, bool Build)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				this.oO_.0.(".pdf");
				ThreadPool.QueueUserWorkItem(new WaitCallback(new Oo0o0o_0_(this.Response, Book)
				{
					O_0._00_. = Build
				}.O_0._00_.), null);
			}
		}

		/// <summary>
		/// 以PDF的形式向客户端发送Excel报表
		/// </summary>
		/// <param name="Book">要发送的Excel报表</param>
		/// <param name="Indexes">整数型，指定无需生成细节区的工作表</param>
		// Token: 0x0600190E RID: 6414 RVA: 0x000B0108 File Offset: 0x000AE308
		[oO0oooo("A0288")]
		public void WriteBookAsPDF(Book Book, params int[] Indexes)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				this.oO_.0.(".pdf");
				ThreadPool.QueueUserWorkItem(new WaitCallback(new Oo0o0o_0_(this.Response, Book)
				{
					O_0._00_. = Indexes
				}.O_0._00_.), null);
			}
		}

		/// <summary>
		/// 以PDF的形式向客户端发送专业报表
		/// </summary>
		/// <param name="PrintDoc">要发送的专业报表</param>
		// Token: 0x0600190F RID: 6415 RVA: 0x000B0154 File Offset: 0x000AE354
		[oO0oooo("A0290")]
		public void WriteReportAsPDF(PrintDoc PrintDoc)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oo0o.oo_oOoOo0. = true;
				this.oO_.0.(".pdf");
				ThreadPool.QueueUserWorkItem(new WaitCallback(new ooo_0O0o00(PrintDoc, this.Response).oO0o0o._0.), null);
			}
		}

		/// <summary>
		/// 向客户端发送DataTable，需要和HttpClient配合使用
		/// </summary>
		/// <param name="dt">要发送的DataTable</param>
		// Token: 0x06001910 RID: 6416 RVA: 0x000B018E File Offset: 0x000AE38E
		[oO0oooo("A0162")]
		public void WriteDataTable(Foxtable.DataTable dt)
		{
			if (!this.oo0o.oo_oOoOo0. && dt != null)
			{
				this.oO.O_0_OO.("");
				this.oo0o.oo_oOoOo0. = true;
				ThreadPool.QueueUserWorkItem(new WaitCallback(new O_o0_0_o0(dt.BaseTable, this).O_0._00_.), null);
			}
		}

		/// <summary>
		/// 根据指定的数据源和Select语句，生成一个DataTable，然后发送给客户端，需要和HttpClient配合使用
		/// </summary>
		/// <param name="SelectString">Select语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x06001911 RID: 6417 RVA: 0x000B01CB File Offset: 0x000AE3CB
		public void WriteDataTable(string SelectString, string ConnectionName)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.("");
				this.oo0o.oo_oOoOo0. = true;
				ThreadPool.QueueUserWorkItem(new WaitCallback(new O_o0_0_o0(this, SelectString, ConnectionName, false).OO0.0_0O0O_0_0.), null);
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000B0202 File Offset: 0x000AE402
		private void <<EMPTY_NAME>>(System.Data.DataTable A_0)
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.("");
				this.oo0o.oo_oOoOo0. = true;
				new O_o0_0_o0(A_0, this).O_0._00_.(2);
			}
		}

		/// <summary>
		/// 向客户端发送文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ContentType">可选参数，指定文件类型，一般无需设置，</param>
		// Token: 0x06001913 RID: 6419 RVA: 0x000B0230 File Offset: 0x000AE430
		[oO0oooo("A0015")]
		public void WriteFile(string FileName, string ContentType = "")
		{
			if (!this.oo0o.oo_oOoOo0.)
			{
				this.oO.O_0_OO.(FileName);
				if (!FileName.StartsWith("//") && FileName.Length > 2 && Operators.CompareString(Conversions.ToString(FileName[1]), ":", true) != 0 && Operators.CompareString(this.O_OOo_.0oO_., "", true) > 0)
				{
					FileName = this.O_OOo_.0oO_..TrimEnd(new char[]
					{
						'/'
					}) + "/" + FileName;
				}
				if (OO_00oOO.FileSys.FileExists(FileName))
				{
					if (Operators.CompareString(ContentType, "", true) == 0)
					{
						string a_ = Path.GetExtension(FileName).ToLower();
						this.oO_.0.(a_);
					}
					else
					{
						this.Response.ContentType = ContentType;
					}
					this.oo0o.oo_oOoOo0. = true;
					if (Operators.CompareString(this.Request.Headers["Range"], "", true) > 0)
					{
						if (Operators.CompareString(this.Request.Headers["range"].Substring(6).Split(new char[]
						{
							'-'
						})[0].Trim(), "0", true) != 0)
						{
							this.Response.ContentLength64 = 0L;
							this.Response.OutputStream.Close();
							this.Response.Close();
							this.Response.Abort();
							return;
						}
						FileInfo fileInfo = new FileInfo(FileName);
						this.Response.Headers.Add("Content-Range", "bytes 0-" + Conversions.ToString(fileInfo.Length - 1L) + "/" + Conversions.ToString(fileInfo.Length));
					}
					ThreadPool.QueueUserWorkItem(new WaitCallback(new o_o0O_Ooo__O(FileName, this.Response).ooO0O.0.), null);
				}
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000B03F8 File Offset: 0x000AE5F8
		private void <<EMPTY_NAME>>()
		{
			this.O_0O00.o. = true;
			checked
			{
				if (Operators.CompareString(this.Request.Url.Query, "", true) > 0)
				{
					string[] array = this.Request.Url.Query.TrimStart(new char[]
					{
						'?'
					}).Split(new char[]
					{
						'&'
					});
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							'='
						});
						if (array2.Length == 2)
						{
							array2[0] = OO_00oOO.O_0.0O__O0.(array2[0]);
							array2[1] = OO_00oOO.O_0.0O__O0.(array2[1]);
							if (!this.o0__O0.o_0..ContainsKey(array2[0]))
							{
								this.o0__O0.o_0..Add(array2[0], array2[1]);
								this.o0__0oOoo_.o..Add(array2[0], array2[1]);
							}
						}
					}
				}
				try
				{
					foreach (object obj in this.Request.Cookies)
					{
						Cookie cookie = (Cookie)obj;
						this.Cookies.Add(OO_00oOO.O_0.0O__O0.(cookie.Name), OO_00oOO.O_0.0O__O0.(cookie.Value));
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
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000B0540 File Offset: 0x000AE740
		internal void <<EMPTY_NAME>>()
		{
			bool flag = false;
			try
			{
				bool flag2 = true;
				if (OO_00oOO.HttpServer.UserProcessHosts.Contains("*"))
				{
					flag2 = false;
				}
				else if (OO_00oOO.HttpServer.UserProcessHosts.Count > 0)
				{
					string host = this.Host;
					try
					{
						foreach (string right in OO_00oOO.HttpServer.UserProcessHosts)
						{
							if (Operators.CompareString(host, right, true) == 0)
							{
								flag2 = false;
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!this.Request.HasEntityBody)
				{
					string text = this.path;
					if (Operators.CompareString(this.O_OOo_.0oO_., "", true) > 0)
					{
						text = this.O_OOo_.0oO_..TrimEnd(new char[]
						{
							'\\'
						}) + "\\" + text.Trim(new char[]
						{
							'\\'
						});
						if (OO_00oOO.FileSys.FileExists(text))
						{
							string extension = Path.GetExtension(text);
							if (Operators.CompareString(extension, "", true) > 0 && this.oo_OO_0._O0O..Contains(extension.ToLower()))
							{
								this.Request.InputStream.Close();
								flag = true;
								this.WriteFile(text, "");
							}
						}
					}
				}
				else if (flag2)
				{
					string text2 = this.Request.ContentType.ToLower();
					if (text2.StartsWith("application/json") || text2.StartsWith("text/plain") || text2.StartsWith("text/xml") || text2.StartsWith("text/html"))
					{
						Encoding encoding = this.O0_OO0oOO.O_0O.();
						StreamReader streamReader = new StreamReader(this.Request.InputStream, encoding);
						this.O.OOooO0o_O__o. = streamReader.ReadToEnd();
					}
					else if (text2.StartsWith("application/x-www-form-urlencoded"))
					{
						Encoding encoding2 = this.O0_OO0oOO.O_0O.();
						string[] array = new StreamReader(this.Request.InputStream, encoding2).ReadToEnd().Split(new char[]
						{
							'&'
						});
						checked
						{
							for (int i = 0; i < array.Length; i++)
							{
								string[] array2 = array[i].Split(new char[]
								{
									'='
								});
								if (array2.Length >= 2)
								{
									string key = HttpUtility.UrlDecode(array2[0]);
									if (!this.o0__O0.o_0..ContainsKey(key))
									{
										this.o0__O0.o_0..Add(key, HttpUtility.UrlDecode(array2[1]));
										this.O.OOooO0o_O__o..Add(key, HttpUtility.UrlDecode(array2[1]));
									}
								}
							}
						}
					}
					else if (text2.StartsWith("multipart/form-data;"))
					{
						Encoding encoding3 = HttpFunctions.OO.0o.(this.o0__O0.o_0.);
						HttpFunctions.OO.0o.(this.Oo._00O_0Oo.);
						BufferedStream bufferedStream = new BufferedStream(this.Request.InputStream);
						string[] array3 = this.Request.ContentType.Split(new char[]
						{
							';'
						});
						string text3 = "";
						foreach (string text4 in array3)
						{
							text4 = text4.Trim();
							if (text4.ToLower().StartsWith("boundary="))
							{
								text3 = text4;
								break;
							}
						}
						text3 = text3.Replace("boundary=", "").Trim();
						byte[] bytes = encoding3.GetBytes("--" + text3 + "\r\n");
						byte[] bytes2 = encoding3.GetBytes("--" + text3 + "--\r\n");
						Stream stream = null;
						bool flag3 = false;
						bool flag4 = false;
						string text5 = "";
						string text6 = "";
						for (;;)
						{
							byte[] array5 = this.O0_OO0oOO.O_0O.(bufferedStream);
							if (array5.Length == 0)
							{
								goto IL_73A;
							}
							if (this.o.0OoO.(bytes, array5))
							{
								if (Operators.CompareString(text6, "", true) > 0 && stream != null && stream.Length > 0L)
								{
									this.O0_OO0oOO.O_0O.(stream);
									if (!flag4)
									{
										string text7 = encoding3.GetString(((MemoryStream)stream).ToArray());
										if (text7.StartsWith("%"))
										{
											text7 = HttpUtility.UrlDecode(text7);
										}
										if (!this.o0__O0.o_0..ContainsKey(text6))
										{
											this.o0__O0.o_0..Add(text6, text7);
											this.O.OOooO0o_O__o..Add(text6, text7);
										}
									}
									else
									{
										Operators.CompareString(text5, "", true);
									}
								}
								if (stream != null && stream.Length > 0L)
								{
									stream.Close();
									stream.Dispose();
								}
								text5 = "";
								flag4 = false;
								flag3 = true;
								stream = new MemoryStream();
								byte[] bytes3 = this.O0_OO0oOO.O_0O.(bufferedStream);
								byte[] bytes4 = this.O0_OO0oOO.O_0O.(bufferedStream);
								string @string = encoding3.GetString(bytes3);
								string string2 = encoding3.GetString(bytes4);
								text6 = @string.Substring("Content-Disposition: form-data; name=".Length).Replace("\r\n", "");
								if (text6.IndexOf(";") > 0)
								{
									text6 = text6.Substring(0, text6.IndexOf(";"));
								}
								if (text6.StartsWith("%"))
								{
									text6 = HttpUtility.UrlDecode(text6);
								}
								else
								{
									text6 = text6.Replace("\"", "");
								}
								if (string2.Contains("Content-Type"))
								{
									flag4 = true;
									int num = @string.IndexOf("filename=");
									text5 = Path.GetFileName(@string.Substring(num + 9).Replace("\"", "").Replace("\r\n", ""));
									if (Operators.CompareString(text5, "", true) > 0)
									{
										if (!this.oo_OO_0._O0O..ContainsKey(text6))
										{
											this.oo_OO_0._O0O..Add(text6, new List<string>());
										}
										text5 = this.O0_OO0oOO.O_0O.(text6, text5);
										string text8 = OO_00oOO.ProjectPath + "HttpTempFiles\\" + OoOo0O.OO_o.0o_O.(12);
										if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "HttpTempFiles\\"))
										{
											OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "HttpTempFiles\\");
										}
										stream = File.Create(text8);
										this.oo_OO_0._O0O.[text6].Add(text5);
										this.oo_OO_0._O0O..Add(text6 + "_" + text5, text8);
									}
								}
							}
							else
							{
								if (this.o.0OoO.(bytes2, array5))
								{
									break;
								}
								if (flag3)
								{
									string string3 = encoding3.GetString(array5);
									if (!string3.StartsWith("Content-Transfer-Encoding:", StringComparison.OrdinalIgnoreCase))
									{
										flag3 = false;
										if (Operators.CompareString(string3, "\r\n", true) != 0)
										{
											stream.Write(array5, 0, array5.Length);
										}
									}
								}
								else
								{
									stream.Write(array5, 0, array5.Length);
								}
							}
						}
						if (Operators.CompareString(text6, "", true) > 0 && stream != null && stream.Length > 0L)
						{
							this.O0_OO0oOO.O_0O.(stream);
							if (!flag4)
							{
								string text9 = encoding3.GetString(((MemoryStream)stream).ToArray());
								if (text9.StartsWith("%"))
								{
									text9 = HttpUtility.UrlDecode(text9);
								}
								if (!this.o0__O0.o_0..ContainsKey(text6))
								{
									this.o0__O0.o_0..Add(text6, text9);
									this.O.OOooO0o_O__o..Add(text6, text9);
								}
							}
						}
						if (stream != null && stream.Length > 0L)
						{
							stream.Close();
							stream.Dispose();
						}
						IL_73A:
						this.Request.InputStream.Close();
						bufferedStream.Close();
					}
				}
			}
			catch (Exception a_)
			{
				ooO.OO_oOO0O.O00.(a_);
			}
			finally
			{
				object o0oo.Oo. = OO_00oOO.HttpServer.o0oo.Oo.;
				lock (o0oo.Oo.)
				{
					OO_00oOO.HttpServer.o.oOOoOOO..Remove(this);
					if (!flag)
					{
						OO_00oOO.HttpServer.oo._o_oo_..Enqueue(this);
					}
				}
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000B0D68 File Offset: 0x000AEF68
		private Encoding <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.Request.ContentType, "", true) > 0)
			{
				foreach (string text in this.Request.ContentType.ToLower().Split(new char[]
				{
					';'
				}))
				{
					text = text.Trim().ToLower();
					if (text.StartsWith("charset"))
					{
						string[] array2 = text.Split(new char[]
						{
							'='
						});
						if (array2.Length == 2)
						{
							return HttpFunctions.OO.0o.(array2[1].Trim());
						}
					}
				}
			}
			try
			{
				foreach (O_O_O0_O o_O_O0_O in OO_00oOO.HttpServer.o.oOOoOOO.)
				{
					if (Operators.CompareString(o_O_O0_O.O0oO.o_OOoO_., "*", true) == 0 || Operators.CompareString(o_O_O0_O.O0oO.o_OOoO_., this.Host, true) == 0)
					{
						if (Operators.CompareString(o_O_O0_O.O.__0O., "*", true) == 0)
						{
							return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.);
						}
						if (Operators.CompareString(this.path, o_O_O0_O.O.__0O., true) == 0)
						{
							return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.);
						}
						if (this.path.IndexOf("/") > 0 && this.path.StartsWith(o_O_O0_O.O.__0O. + "/"))
						{
							return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.);
						}
					}
				}
			}
			finally
			{
				List<O_O_O0_O>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return Encoding.UTF8;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000B0F14 File Offset: 0x000AF114
		private void <<EMPTY_NAME>>(Stream A_0)
		{
			long length = A_0.Length;
			if (length > 2L)
			{
				A_0.Position = length - 2L;
				if (A_0.ReadByte() == 13 && A_0.ReadByte() == 10)
				{
					A_0.SetLength(length - 2L);
				}
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000B0F58 File Offset: 0x000AF158
		private string <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (A_1.StartsWith("image%3A", StringComparison.CurrentCultureIgnoreCase) && A_1.IndexOf(".") == -1)
			{
				A_1 = A_1.Replace("%", "") + ".jpg";
			}
			if (this.oo_OO_0._O0O..ContainsKey(A_0 + "_" + A_1))
			{
				int num = 1;
				int num2 = A_1.LastIndexOf(".");
				string text;
				for (;;)
				{
					text = string.Concat(new string[]
					{
						A_1.Substring(0, num2),
						"(",
						Conversions.ToString(num),
						").",
						A_1.Substring(num2 + 1)
					});
					if (!this.oo_OO_0._O0O..ContainsKey(A_0 + "_" + text))
					{
						break;
					}
					num++;
				}
				A_1 = text;
			}
			return A_1;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000B1028 File Offset: 0x000AF228
		private byte[] <<EMPTY_NAME>>(Stream A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			int num;
			do
			{
				num = A_0.ReadByte();
				if (num == -1)
				{
					break;
				}
				memoryStream.WriteByte((byte)num);
			}
			while (num != 10);
			return memoryStream.ToArray();
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000B105C File Offset: 0x000AF25C
		private bool <<EMPTY_NAME>>(byte[] A_0, byte[] A_1)
		{
			int num = A_0.Length;
			bool result;
			if (A_0.Length != A_1.Length)
			{
				result = false;
			}
			else
			{
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (A_0[i] != A_1[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 重定向访问目标
		/// </summary>
		/// <param name="url">目标地址</param>
		// Token: 0x0600191B RID: 6427 RVA: 0x000B1098 File Offset: 0x000AF298
		public void Redirect(string url)
		{
			this.o._oOOO00_o_0O. = true;
			this.Response.Redirect(url);
		}

		/// <summary>
		/// 将本地数据源转为WEB数据源，并开放给用户访问
		/// </summary>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x0600191C RID: 6428 RVA: 0x000B10B0 File Offset: 0x000AF2B0
		[oO0oooo("A283")]
		public void AsDataServer(string ConnectionName)
		{
			if (Operators.CompareString(ConnectionName, "", true) == 0)
			{
				this.AppendCookie("Error", "服务端不能使用内部数据源!");
				return;
			}
			if (O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName))
			{
				this.AppendCookie("Error", "服务端不能使用Web数据源!");
				return;
			}
			if (!O_O0OO.O._o_.().ContainsKey(ConnectionName))
			{
				this.AppendCookie("Error", "服务端指定的本地数据源不存在！");
				return;
			}
			if (Operators.CompareString(ConnectionName, "", true) > 0 && o_O_o_oOoo__.OO0O_0.0O0o0_o.(new OleDbConnection(OO_00oOO.Connections[ConnectionName].ConnectionString)))
			{
				this.AppendCookie("Error", "服务端不能使用Oracle数据源!");
				return;
			}
			if (this.PostValues.ContainsKey("Action"))
			{
				this.AsyncExecute = true;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.OO.oo.), ConnectionName);
			}
		}

		/// <summary>
		/// 指定向客户端发送Excel报表或专业报表时，产生的辅助文件的存放目录，使用相对路径。
		/// </summary>
		// Token: 0x0600191D RID: 6429 RVA: 0x000B1180 File Offset: 0x000AF380
		[oO0oooo("A0288")]
		public void AsReportServer(string path)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + this.path.Substring(path.Length);
			if (OO_00oOO.FileSys.FileExists(text))
			{
				this.WriteFile(text, "");
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000B11C4 File Offset: 0x000AF3C4
		private void <<EMPTY_NAME>>(object A_0)
		{
			try
			{
				if (this.PostValues.ContainsKey("Select"))
				{
					this.PostValues["Select"] = O00.oO_.0o_oo_0O_.(this.PostValues["Select"], "fox", "table");
				}
				this.o.0OoO.(RuntimeHelpers.GetObjectValue(A_0));
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.Handled = true;
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000B1260 File Offset: 0x000AF460
		private void <<EMPTY_NAME>>(object A_0)
		{
			string text = A_0.ToString();
			oO0o0O_OO oO0o0O_OO = (oO0o0O_OO)Conversions.ToInteger(this.PostValues["Action"]);
			string text2 = this.PostValues["Datatable"];
			switch (oO0o0O_OO)
			{
			case oO0o0O_OO.O.o__0.:
			case oO0o0O_OO.O0_0.0_.:
			{
				bool a_ = oO0o0O_OO == oO0o0O_OO.O.o__0.;
				string text3;
				if (this.PostValues.ContainsKey("Select"))
				{
					text3 = this.PostValues["Select"];
				}
				else
				{
					if (this.PostValues.ContainsKey("Distinct"))
					{
						text3 = "Select Distinct";
					}
					else
					{
						text3 = "Select";
					}
					if (this.PostValues.ContainsKey("Top"))
					{
						text3 = text3 + " Top " + this.PostValues["Top"];
					}
					if (this.PostValues.ContainsKey("Fields"))
					{
						text3 = string.Concat(new string[]
						{
							text3,
							" ",
							this.PostValues["Fields"],
							" From ",
							text2
						});
					}
					else
					{
						text3 = text3 + " * From " + text2;
					}
					if (this.PostValues.ContainsKey("Where"))
					{
						text3 = text3 + " Where " + this.PostValues["Where"];
					}
					if (this.PostValues.ContainsKey("OrderBy"))
					{
						text3 = text3 + " Order By" + this.PostValues["Where"];
					}
				}
				if (Operators.CompareString(text3, "", true) == 0)
				{
					this.AppendCookie("Error", "未指定表或未定义查询语句!");
					return;
				}
				this.oO.O_0_OO.(text3, text, a_);
				break;
			}
			case oO0o0O_OO.O0oOO0_O.oO.:
			case oO0o0O_OO.oOo.o_o0_o0o_.:
			case oO0o0O_OO.o_o0_.Oo_.:
				this.oO.O_0_OO.(text, text2);
				return;
			case oO0o0O_OO.OoOO.O0_00_o.:
			case oO0o0O_OO.o.oO0o00O_0.:
				if (this.PostValues.ContainsKey("Select"))
				{
					SQLCommand sqlcommand = new SQLCommand(this.PostValues["Select"], text);
					object obj;
					if (oO0o0O_OO == oO0o0O_OO.OoOO.O0_00_o.)
					{
						obj = RuntimeHelpers.GetObjectValue(sqlcommand.ExecuteScalar());
					}
					else
					{
						obj = sqlcommand.ExecuteNonQuery();
					}
					if (obj != null)
					{
						this.o_O.oO.(obj.ToString());
						return;
					}
					this.o_O.oO.("");
					return;
				}
				break;
			case oO0o0O_OO.OoOo0o.00OO.:
				break;
			case oO0o0O_OO.OO.0OO0.:
			{
				DataServerTypeEnum dataServerTypeEnum;
				if (Operators.CompareString(text, "", true) == 0)
				{
					dataServerTypeEnum = DataServerTypeEnum.Buildin;
				}
				else
				{
					try
					{
						OleDbConnection oleDbConnection = new OleDbConnection(OO_00oOO.Connections[text].ConnectionString);
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
						{
							dataServerTypeEnum = DataServerTypeEnum.Oracle;
						}
						else if (o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
						{
							dataServerTypeEnum = DataServerTypeEnum.SqlServer;
						}
						else
						{
							dataServerTypeEnum = DataServerTypeEnum.Access;
						}
						if (oO0o0O_OO == oO0o0O_OO.OO.0OO0.)
						{
							oleDbConnection.Open();
							oleDbConnection.Close();
						}
					}
					catch (Exception ex)
					{
						this.AppendCookie("Error", ex.Message);
					}
				}
				int num = (int)dataServerTypeEnum;
				this.o_O.oO.(num.ToString());
				return;
			}
			case oO0o0O_OO.oO_00O._.:
				this.o_O.oO.(string.Join("|", ((List<string>)OO_00oOO.Connections[text].GetTableNames()).ToArray()));
				return;
			case oO0o0O_OO.o.Oo0oooOoo0.:
				this.o_O.oO.(string.Join("|", ((List<string>)OO_00oOO.Connections[text].GetViewNames()).ToArray()));
				return;
			case oO0o0O_OO.O_O__0.0_ooO_.:
			{
				string selectCommandText = this.PostValues["Select"];
				OleDbConnection oleDbConnection2 = new OleDbConnection(OO_00oOO.Connections[text].ConnectionString);
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, oleDbConnection2);
				DataSet dataSet = new DataSet();
				System.Data.DataTable dataTable = new System.Data.DataTable();
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection2))
				{
					dataTable.TableName = "Oracle";
				}
				else if (o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2))
				{
					dataTable.TableName = "SQLServer";
				}
				else
				{
					dataTable.TableName = "Access";
				}
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				dataSet.Tables.Add(dataTable);
				MemoryStream memoryStream = new MemoryStream();
				dataSet.WriteXml(memoryStream, XmlWriteMode.WriteSchema);
				memoryStream.Position = 0L;
				new oOO_O__(memoryStream, this.Response).oO0o0o._0.(null);
				return;
			}
			case oO0o0O_OO.Oo_0._o.:
				if (this.PostValues.ContainsKey("Select"))
				{
					this.O0O_.o__0O.(this.PostValues["Select"], text);
					return;
				}
				break;
			case oO0o0O_OO.ooo__.O_oo.:
				this.o__.O00.(this.PostValues["Select"], text);
				return;
			case oO0o0O_OO.O00.Oo_00Oooo0.:
			case oO0o0O_OO.o0O.o0_0o_O0Oo.:
				if (this.PostValues.ContainsKey("Select"))
				{
					OleDbConnection oleDbConnection3 = new OleDbConnection(OO_00oOO.Connections[text].ConnectionString);
					OleDbCommand oleDbCommand = new OleDbCommand(this.PostValues["Select"], oleDbConnection3);
					if (this.PostValues.ContainsKey("StoredProcedure"))
					{
						oleDbCommand.CommandType = CommandType.StoredProcedure;
					}
					this.o.0OoO.(oleDbCommand);
					object obj2;
					try
					{
						oleDbConnection3.Open();
						if (oO0o0O_OO == oO0o0O_OO.O00.Oo_00Oooo0.)
						{
							obj2 = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
						}
						else
						{
							obj2 = oleDbCommand.ExecuteNonQuery();
						}
					}
					catch (Exception ex2)
					{
						this.AppendCookie("Error", ex2.Message);
						this.o_O.oO.("");
						break;
					}
					finally
					{
						oleDbConnection3.Close();
					}
					System.Data.DataTable dataTable2 = new System.Data.DataTable();
					dataTable2.TableName = "ReturnValue";
					DataRow dataRow = dataTable2.NewRow();
					dataTable2.Rows.Add(dataRow);
					if (obj2 == null || obj2 == DBNull.Value)
					{
						dataTable2.Columns.Add(OoOo0O.OO_o.0o_O.(4), typeof(string));
					}
					else
					{
						dataTable2.Columns.Add(OoOo0O.OO_o.0o_O.(4), obj2.GetType());
					}
					dataRow[0] = RuntimeHelpers.GetObjectValue(obj2);
					this.oO.O_0_OO.(oleDbCommand, dataTable2);
					this.oO.O_0_OO.(dataTable2);
					return;
				}
				break;
			case oO0o0O_OO.oo_.ooO.:
			case oO0o0O_OO.OOo.oOo0o_00__.:
				if (this.PostValues.ContainsKey("Select"))
				{
					OleDbConnection oleDbConnection4 = new OleDbConnection(OO_00oOO.Connections[text].ConnectionString);
					OleDbCommand oleDbCommand2 = new OleDbCommand(this.PostValues["Select"], oleDbConnection4);
					if (this.PostValues.ContainsKey("StoredProcedure"))
					{
						oleDbCommand2.CommandType = CommandType.StoredProcedure;
					}
					this.o.0OoO.(oleDbCommand2);
					DataSet dataSet2 = new DataSet();
					System.Data.DataTable dataTable3 = new System.Data.DataTable();
					dataTable3.TableName = "DataTable";
					try
					{
						if (oO0o0O_OO == oO0o0O_OO.oo_.ooO. && !this.PostValues.ContainsKey("IgnoreSchema"))
						{
							Oo00.oo_0__0.o.(oleDbCommand2.CommandText);
							new OleDbDataAdapter(oleDbCommand2.CommandText, oleDbConnection4).FillSchema(dataTable3, SchemaType.Source);
						}
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter(oleDbCommand2);
						dataTable3.BeginLoadData();
						dbDataAdapter.Fill(dataTable3);
						dataTable3.EndLoadData();
						dataSet2.Tables.Add(dataTable3);
						System.Data.DataTable dataTable4 = new System.Data.DataTable();
						dataTable4.TableName = "Params";
						dataTable4.Columns.Add("_Columns", typeof(string));
						DataRow dataRow2 = dataTable4.NewRow();
						dataTable4.Rows.Add(dataRow2);
						this.oO.O_0_OO.(oleDbCommand2, dataTable4);
						dataSet2.Tables.Add(dataTable4);
						if (oO0o0O_OO == oO0o0O_OO.oo_.ooO. && !this.PostValues.ContainsKey("IgnoreSchema") && dataTable3.PrimaryKey.Length > 0)
						{
							string str = Oo00.oo_0__0.o.(oleDbCommand2.CommandText);
							List<string> list = new List<string>();
							DbDataAdapter dbDataAdapter2 = new OleDbDataAdapter("Select * From " + str, oleDbConnection4);
							System.Data.DataTable dataTable5 = new System.Data.DataTable();
							dbDataAdapter2.FillSchema(dataTable5, SchemaType.Source);
							try
							{
								foreach (object obj3 in dataTable5.Columns)
								{
									DataColumn dataColumn = (DataColumn)obj3;
									list.Add(dataColumn.ColumnName.ToLower());
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
							dataRow2["_Columns"] = string.Join("|", list.ToArray());
						}
					}
					catch (Exception ex3)
					{
						this.AppendCookie("Error", ex3.Message);
						this.Response.OutputStream.Close();
						this.Response.Close();
						this.Response.Abort();
						break;
					}
					if (dataSet2.Tables.Count > 0)
					{
						dataSet2.AcceptChanges();
						MemoryStream memoryStream2 = new MemoryStream();
						dataSet2.WriteXml(memoryStream2, XmlWriteMode.WriteSchema);
						dataSet2.Dispose();
						memoryStream2.Position = 0L;
						new oOO_O__(memoryStream2, this.Response).oO0o0o._0.(null);
						return;
					}
					this.Response.OutputStream.Close();
					this.Response.Close();
					this.Response.Abort();
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000B1B60 File Offset: 0x000AFD60
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			string text = "\v\t";
			string text2 = "\t\v";
			string text3 = "";
			OleDbConnection oleDbConnection = new OleDbConnection(O_O0OO.O._o_.()[A_0].ConnectionString);
			OleDbCommand oleDbCommand = new OleDbCommand("", oleDbConnection);
			if (!A_1.StartsWith("[") && !A_1.EndsWith("]") && !A_1.StartsWith("("))
			{
				A_1 = "[" + A_1 + "]";
			}
			oleDbConnection.Open();
			try
			{
				foreach (string text4 in this.PostValues.Keys)
				{
					if (text4.StartsWith("[[Row") && text4.EndsWith("]]"))
					{
						string text5 = "";
						string text6 = "";
						string[] array = O00.oO_.0o_oo_0O_.(this.PostValues[text4], "fox", "table").Split(new string[]
						{
							text2
						}, StringSplitOptions.None);
						string[] array2 = array[0].Split(new string[]
						{
							text
						}, StringSplitOptions.None);
						string[] array3 = array[1].Split(new string[]
						{
							text
						}, StringSplitOptions.None);
						int num = array2.Length - 1;
						for (int i = 0; i <= num; i += 2)
						{
							text5 = string.Concat(new string[]
							{
								text5,
								Interaction.IIf(Operators.CompareString(text5, "", true) > 0, ",", "Set ").ToString(),
								"[",
								array2[i],
								"] = ?"
							});
							this.o.0OoO.(oleDbCommand, "@" + array2[i], array2[i + 1]);
						}
						int num2 = array3.Length - 1;
						for (int j = 0; j <= num2; j += 2)
						{
							text6 = string.Concat(new string[]
							{
								text6,
								Interaction.IIf(Operators.CompareString(text6, "", true) > 0, " And ", "").ToString(),
								"[",
								array3[j],
								"] =  ?"
							});
							this.o.0OoO.(oleDbCommand, "@@" + array3[j], array3[j + 1]);
						}
						oleDbCommand.CommandText = string.Concat(new string[]
						{
							"Update ",
							A_1,
							" ",
							text5,
							" Where ",
							text6
						});
						try
						{
							int value = oleDbCommand.ExecuteNonQuery();
							text3 = text3 + "|" + Conversions.ToString(value);
							oleDbCommand.Parameters.Clear();
						}
						catch (Exception ex)
						{
							text3 = text3 + "|" + ex.Message;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			oleDbConnection.Close();
			this.o_O.oO.(text3.Trim(new char[]
			{
				'|'
			}));
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000B1E8C File Offset: 0x000B008C
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			bool flag = this.PostValues.ContainsKey("AutoIncrement");
			string text = "\v\t";
			string text2 = "";
			OleDbConnection oleDbConnection = new OleDbConnection(O_O0OO.O._o_.()[A_0].ConnectionString);
			bool flag2 = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection);
			OleDbCommand oleDbCommand = new OleDbCommand("", oleDbConnection);
			if (!A_1.StartsWith("[") && !A_1.EndsWith("]") && !A_1.StartsWith("("))
			{
				A_1 = "[" + A_1 + "]";
			}
			oleDbConnection.Open();
			try
			{
				foreach (string text3 in this.PostValues.Keys)
				{
					if (text3.StartsWith("[[Row") && text3.EndsWith("]]"))
					{
						string text4 = null;
						string text5 = null;
						string[] array = O00.oO_.0o_oo_0O_.(this.PostValues[text3], "fox", "table").Split(new string[]
						{
							text
						}, StringSplitOptions.None);
						int num = array.Length - 1;
						for (int i = 0; i <= num; i += 2)
						{
							text4 = string.Concat(new string[]
							{
								text4,
								Interaction.IIf(Operators.CompareString(text4, "", true) > 0, ",", "").ToString(),
								"[",
								array[i],
								"]"
							});
							text5 = text5 + Interaction.IIf(Operators.CompareString(text5, "", true) > 0, ",", "").ToString() + "?";
							this.o.0OoO.(oleDbCommand, "@" + array[i], array[i + 1]);
						}
						string text6 = string.Concat(new string[]
						{
							"Insert into ",
							A_1,
							" (",
							text4,
							") Values (",
							text5,
							")"
						});
						if (flag && flag2)
						{
							text6 += ";Select @@IDENTITY";
						}
						oleDbCommand.CommandText = text6;
						try
						{
							int num2;
							if (flag)
							{
								if (flag2)
								{
									num2 = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
								}
								else
								{
									num2 = oleDbCommand.ExecuteNonQuery();
									if (num2 == 1)
									{
										oleDbCommand.CommandText = "Select @@IDENTITY";
										oleDbCommand.Parameters.Clear();
										num2 = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
									}
								}
							}
							else
							{
								num2 = oleDbCommand.ExecuteNonQuery();
							}
							oleDbCommand.Parameters.Clear();
							text2 = text2 + "|" + Conversions.ToString(num2);
						}
						catch (Exception ex)
						{
							text2 = text2 + "|" + ex.Message;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			oleDbConnection.Close();
			this.o_O.oO.(text2.Trim(new char[]
			{
				'|'
			}));
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000B21BC File Offset: 0x000B03BC
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			string text = "\v\t";
			string text2 = "";
			OleDbConnection oleDbConnection = new OleDbConnection(O_O0OO.O._o_.()[A_0].ConnectionString);
			o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection);
			OleDbCommand oleDbCommand = new OleDbCommand("", oleDbConnection);
			if (!A_1.StartsWith("[") && !A_1.EndsWith("]") && !A_1.StartsWith("("))
			{
				A_1 = "[" + A_1 + "]";
			}
			oleDbConnection.Open();
			try
			{
				foreach (string text3 in this.PostValues.Keys)
				{
					if (text3.StartsWith("[[Row") && text3.EndsWith("]]"))
					{
						string text4 = null;
						string[] array = O00.oO_.0o_oo_0O_.(this.PostValues[text3], "fox", "table").Split(new string[]
						{
							text
						}, StringSplitOptions.None);
						int num = array.Length - 1;
						for (int i = 0; i <= num; i += 2)
						{
							text4 = string.Concat(new string[]
							{
								text4,
								Interaction.IIf(Operators.CompareString(text4, "", true) > 0, " And ", "").ToString(),
								"[",
								array[i],
								"] =  ?"
							});
							this.o.0OoO.(oleDbCommand, "@@" + array[i], array[i + 1]);
						}
						oleDbCommand.CommandText = "Delete From " + A_1 + " Where " + text4;
						try
						{
							int num2 = oleDbCommand.ExecuteNonQuery();
							oleDbCommand.Parameters.Clear();
							text2 = text2 + "|" + Conversions.ToString(num2);
							if (num2 != 0 && num2 != 1)
							{
								break;
							}
						}
						catch (Exception ex)
						{
							text2 = text2 + "|" + ex.Message;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			oleDbConnection.Close();
			this.o_O.oO.(text2.Trim(new char[]
			{
				'|'
			}));
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000B2414 File Offset: 0x000B0614
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			oO0o0O_OO oO0o0O_OO = (oO0o0O_OO)Conversions.ToInteger(this.PostValues["Action"]);
			if (oO0o0O_OO == oO0o0O_OO.O0oOO0_O.oO.)
			{
				this.OO.O0o.(A_0, A_1);
				return;
			}
			if (oO0o0O_OO == oO0o0O_OO.oOo.o_o0_o0o_.)
			{
				this.o_0_0.OO0oOo.(A_0, A_1);
				return;
			}
			if (oO0o0O_OO == oO0o0O_OO.o_o0_.Oo_.)
			{
				this.Ooo_oO0.O0.(A_0, A_1);
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000B2460 File Offset: 0x000B0660
		private void <<EMPTY_NAME>>(OleDbCommand A_0, string A_1, string A_2)
		{
			string text = A_2.Substring(0, 2);
			A_2 = A_2.Substring(2);
			if (Operators.CompareString(A_2, "{{null}}", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, DBNull.Value);
				return;
			}
			string left = text;
			if (Operators.CompareString(left, "sr", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, A_2);
				return;
			}
			if (Operators.CompareString(left, "bl", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToBoolean(A_2));
				return;
			}
			if (Operators.CompareString(left, "dt", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, DateTime.FromBinary(Conversions.ToLong(A_2)));
				return;
			}
			if (Operators.CompareString(left, "bt", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToByte(A_2));
				return;
			}
			if (Operators.CompareString(left, "st", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToShort(A_2));
				return;
			}
			if (Operators.CompareString(left, "in", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToInteger(A_2));
				return;
			}
			if (Operators.CompareString(left, "lg", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToLong(A_2));
				return;
			}
			if (Operators.CompareString(left, "sg", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToSingle(A_2));
				return;
			}
			if (Operators.CompareString(left, "db", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToDouble(A_2));
				return;
			}
			if (Operators.CompareString(left, "dm", true) == 0)
			{
				A_0.Parameters.AddWithValue(A_1, Conversions.ToDecimal(A_2));
				return;
			}
			A_0.Parameters.AddWithValue(A_1, A_2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000B2634 File Offset: 0x000B0834
		private void <<EMPTY_NAME>>(OleDbCommand A_0)
		{
			try
			{
				foreach (string text in this.PostValues.Keys)
				{
					if (text.StartsWith("@{") && text.EndsWith("}"))
					{
						JObject jobject = JObject.Parse(this.PostValues[text]);
						OleDbParameter oleDbParameter = A_0.Parameters.AddWithValue(jobject["Name"].ToString(), RuntimeHelpers.GetObjectValue(oOO0oO000_0_0.o.oOoO___o__oO.(jobject)));
						if (jobject["Return"] != null)
						{
							oleDbParameter.Direction = ParameterDirection.ReturnValue;
							oleDbParameter.Size = Conversions.ToInteger(jobject["Return"].ToString());
						}
						else if (jobject["Output"] != null)
						{
							oleDbParameter.Direction = ParameterDirection.InputOutput;
							oleDbParameter.Size = Conversions.ToInteger(jobject["Output"].ToString());
						}
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000B2744 File Offset: 0x000B0944
		private void <<EMPTY_NAME>>(OleDbCommand A_0, System.Data.DataTable A_1)
		{
			DataRow dataRow = A_1.Rows[0];
			try
			{
				foreach (object obj in A_0.Parameters)
				{
					OleDbParameter oleDbParameter = (OleDbParameter)obj;
					if ((oleDbParameter.Direction == ParameterDirection.InputOutput | oleDbParameter.Direction == ParameterDirection.Output) || oleDbParameter.Direction == ParameterDirection.ReturnValue)
					{
						if (oleDbParameter.IsNullable)
						{
							A_1.Columns.Add(oleDbParameter.ParameterName, typeof(string));
						}
						else
						{
							A_1.Columns.Add(oleDbParameter.ParameterName, oleDbParameter.Value.GetType());
							dataRow[oleDbParameter.ParameterName] = RuntimeHelpers.GetObjectValue(oleDbParameter.Value);
						}
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

		// Token: 0x06001927 RID: 6439 RVA: 0x000B2824 File Offset: 0x000B0A24
		private void <<EMPTY_NAME>>(string A_0 = "")
		{
			string text = "";
			if (Operators.CompareString(A_0, "", true) > 0)
			{
				text = Path.GetExtension(A_0);
			}
			string left = text.ToLower();
			if (Operators.CompareString(left, ".zip", true) != 0 && Operators.CompareString(left, ".rar", true) != 0 && Operators.CompareString(left, ".png", true) != 0 && Operators.CompareString(left, ".jpg", true) != 0 && Operators.CompareString(left, ".gif", true) != 0 && Operators.CompareString(left, ".xlsx", true) != 0 && Operators.CompareString(left, ".docx", true) != 0 && this.o0__O0.o_0..Headers["Accept-Encoding"] != null)
			{
				if (this.o0__O0.o_0..Headers["Accept-Encoding"].Contains("gzip"))
				{
					this.o0__O0.o_0..AddHeader("Content-Encoding", "gzip");
					return;
				}
				if (this.o0__O0.o_0..Headers["Accept-Encoding"].Contains("deflate"))
				{
					this.o0__O0.o_0..AddHeader("Content-Encoding", "deflate");
				}
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000B2950 File Offset: 0x000B0B50
		public Task<WsConnectResult> GetWebSocketAsync()
		{
			RequestEventArgs.a a = default(RequestEventArgs.a);
			a.a = this;
			a.a = -1;
			a.a = AsyncTaskMethodBuilder<WsConnectResult>.Create();
			a.a.Start<RequestEventArgs.a>(ref a);
			return a.a.Task;
		}

		// Token: 0x04000A0F RID: 2575
		private HttpListenerContext <<EMPTY_NAME>>;

		// Token: 0x04000A10 RID: 2576
		private HttpListenerRequest <<EMPTY_NAME>>;

		// Token: 0x04000A11 RID: 2577
		private HttpListenerResponse <<EMPTY_NAME>>;

		// Token: 0x04000A12 RID: 2578
		internal Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000A13 RID: 2579
		internal Dictionary<string, List<string>> <<EMPTY_NAME>>;

		// Token: 0x04000A14 RID: 2580
		internal HttpDictionary <<EMPTY_NAME>>;

		// Token: 0x04000A15 RID: 2581
		private HttpDictionary <<EMPTY_NAME>>;

		// Token: 0x04000A16 RID: 2582
		private HttpDictionary <<EMPTY_NAME>>;

		// Token: 0x04000A17 RID: 2583
		private HttpDictionary <<EMPTY_NAME>>;

		// Token: 0x04000A18 RID: 2584
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A19 RID: 2585
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A1A RID: 2586
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A1B RID: 2587
		private object <<EMPTY_NAME>>;

		// Token: 0x04000A1C RID: 2588
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000A1D RID: 2589
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A1E RID: 2590
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A1F RID: 2591
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000A20 RID: 2592
		private int <<EMPTY_NAME>>;

		// Token: 0x04000A21 RID: 2593
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000A22 RID: 2594
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A23 RID: 2595
		private bool <<EMPTY_NAME>>;
	}
}
