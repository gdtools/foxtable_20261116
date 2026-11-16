using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// HTTP服务端
	/// </summary>
	// Token: 0x020001EC RID: 492
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0143")]
	public class HttpListenter
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x000ACB04 File Offset: 0x000AAD04
		public HttpListenter()
		{
			this.o0oo.Oo. = new Queue<RequestEventArgs>();
			this.oo._o_oo_. = new Queue<RequestEventArgs>();
			this.o.oOOoOOO. = new List<RequestEventArgs>();
			this.o.oOOoOOO. = new List<string>();
			this.oo._o_oo_. = new List<string>();
			this.o.oOOoOOO. = new HashSet<string>();
			this.o.oOOoOOO. = new List<O_O_O0_O>();
			this.o0oo.Oo. = new HttpListener();
			this.oo._o_oo_..AddRange(".jpg,.gif,.png,.bmp,.wmf,.js,.css,.html,.htm,.zip,.rar,.txt,.json,.svg,.ttf,.woff,.woff2,.eot,.ico,.map,.doc,.docx,.xls,.xlsx".Split(new char[]
			{
				','
			}));
		}

		/// <summary>
		/// 开启服务
		/// </summary>
		// Token: 0x06001865 RID: 6245 RVA: 0x000ACB90 File Offset: 0x000AAD90
		public void Start()
		{
			if (!this.o0oo.Oo..IsListening)
			{
				object obj = this.o0oo.Oo.;
				lock (obj)
				{
					this.o0oo.Oo..Clear();
				}
				this.o.oOOoOOO. = false;
				try
				{
					this.o0oo.Oo..Prefixes.Clear();
					try
					{
						foreach (string uriPrefix in this.Prefixes)
						{
							this.o0oo.Oo..Prefixes.Add(uriPrefix);
						}
					}
					finally
					{
						HashSet<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.o0oo.Oo..Start();
					this.o0oo.Oo..BeginGetContext(new AsyncCallback(this.o.oOOoOOO.), this.o0oo.Oo.);
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					this.o0oo.Oo. = new HttpListener();
				}
			}
		}

		/// <summary>
		/// 关闭服务
		/// </summary>
		// Token: 0x06001866 RID: 6246 RVA: 0x000ACCA8 File Offset: 0x000AAEA8
		public void Close()
		{
			object obj = this.o0oo.Oo.;
			lock (obj)
			{
				this.o0oo.Oo..Clear();
			}
			this.o.oOOoOOO..Clear();
			this.UserProcessHosts.Clear();
			this.o.oOOoOOO. = true;
			this.Prefixes.Clear();
			this.o0oo.Oo..Close();
			OO_00oOO.HttpServer = new HttpListenter();
		}

		/// <summary>
		/// 逻辑型，用于判断HppServer是否正在运
		/// </summary>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000ACD2C File Offset: 0x000AAF2C
		public bool IsRunning
		{
			get
			{
				return this.o0oo.Oo..IsListening;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000ACD39 File Offset: 0x000AAF39
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool IsSupported
		{
			get
			{
				return HttpListener.IsSupported;
			}
		}

		/// <summary>
		/// 集合，包括所有ttp服务
		/// </summary>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x000ACD40 File Offset: 0x000AAF40
		[oO0oooo("A0005")]
		public HashSet<string> Prefixes
		{
			get
			{
				return this.o.oOOoOOO.;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x000ACD48 File Offset: 0x000AAF48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> UserProcessHosts
		{
			get
			{
				return this.o.oOOoOOO.;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000ACD50 File Offset: 0x000AAF50
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetDefaultEncoding(string host, string path, string Encoding)
		{
			if (Operators.CompareString(path, "", true) == 0)
			{
				path = "*";
			}
			O_O_O0_O o_O_O0_O = new O_O_O0_O();
			o_O_O0_O.O0oO.o_OOoO_. = host;
			o_O_O0_O.O.__0O. = path;
			o_O_O0_O.oO._0O_. = Encoding;
			this.o.oOOoOOO..Add(o_O_O0_O);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000ACD99 File Offset: 0x000AAF99
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetDefaultEncoding(string host, string Encoding)
		{
			this.SetDefaultEncoding(host, "*", Encoding);
		}

		/// <summary>
		/// 设置WEB文件默认目录位置
		/// </summary>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000ACDA8 File Offset: 0x000AAFA8
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x000ACDB0 File Offset: 0x000AAFB0
		[oO0oooo("A0276")]
		public string WebPath
		{
			get
			{
				return this.o.oOOoOOO.;
			}
			set
			{
				this.o.oOOoOOO. = value;
			}
		}

		/// <summary>
		/// WEB文件后缀名集合
		/// </summary>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000ACDB9 File Offset: 0x000AAFB9
		[oO0oooo("A0276")]
		public List<string> Extensions
		{
			get
			{
				return this.oo._o_oo_.;
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000ACDC4 File Offset: 0x000AAFC4
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			if (!this.o.oOOoOOO. && this.Prefixes.Count != 0 && this.o0oo.Oo..IsListening && this.o0oo.Oo..IsListening)
			{
				this.o0oo.Oo..BeginGetContext(new AsyncCallback(this.o.oOOoOOO.), this.o0oo.Oo.);
				HttpListenerContext httpListenerContext = this.o0oo.Oo..EndGetContext(A_0);
				HttpListenerRequest request = httpListenerContext.Request;
				HttpListenerResponse response = httpListenerContext.Response;
				object obj = this.o0oo.Oo.;
				lock (obj)
				{
					if (Operators.CompareString(httpListenerContext.Request.RawUrl, "", true) <= 0 || Operators.CompareString(httpListenerContext.Request.RawUrl, "/favicon.ico", true) != 0)
					{
						this.o0oo.Oo..Enqueue(new RequestEventArgs(httpListenerContext, this.WebPath, this.Extensions));
					}
				}
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		private string <<EMPTY_NAME>>(HttpListenerRequest A_0)
		{
			return new StringBuilder().ToString();
		}

		// Token: 0x040009CD RID: 2509
		private HttpListener <<EMPTY_NAME>>;

		// Token: 0x040009CE RID: 2510
		internal Queue<RequestEventArgs> <<EMPTY_NAME>>;

		// Token: 0x040009CF RID: 2511
		internal Queue<RequestEventArgs> <<EMPTY_NAME>>;

		// Token: 0x040009D0 RID: 2512
		internal List<RequestEventArgs> <<EMPTY_NAME>>;

		// Token: 0x040009D1 RID: 2513
		private bool <<EMPTY_NAME>>;

		// Token: 0x040009D2 RID: 2514
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x040009D3 RID: 2515
		private string <<EMPTY_NAME>>;

		// Token: 0x040009D4 RID: 2516
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x040009D5 RID: 2517
		private HashSet<string> <<EMPTY_NAME>>;

		// Token: 0x040009D6 RID: 2518
		internal List<O_O_O0_O> <<EMPTY_NAME>>;
	}
}
