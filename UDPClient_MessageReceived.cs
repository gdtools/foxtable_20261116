using System;
using System.ComponentModel;
using System.Net;

namespace Foxtable
{
	// Token: 0x020001C5 RID: 453
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class UDPClient_MessageReceived
	{
		// Token: 0x060015DD RID: 5597 RVA: 0x00099764 File Offset: 0x00097964
		internal UDPClient_MessageReceived(UDPClient A_0, UDPClient.OO00_ A_1)
		{
			this.OO.000O. = A_0;
			this.OO.000O. = A_1;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0009977A File Offset: 0x0009797A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public UDPClient UDPclient
		{
			get
			{
				return this.OO.000O.;
			}
		}

		/// <summary>
		/// 字节数组，以字节数组形式返回收到的信息
		/// </summary>
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00099782 File Offset: 0x00097982
		public byte[] Bytes
		{
			get
			{
				return this.OO.000O..O00ooo._.();
			}
		}

		/// <summary>
		/// 字符型，以字符形式返回收到的信息，编码格式由EncodingName属性决定
		/// </summary>
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0009978F File Offset: 0x0009798F
		public string Message
		{
			get
			{
				return this.UDPclient.O00ooo._..GetString(this.Bytes);
			}
		}

		/// <summary>
		/// 字符型，指定要返回给发送者的字符信息
		/// </summary>
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000997A7 File Offset: 0x000979A7
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x000997AF File Offset: 0x000979AF
		public string ReturnValue
		{
			get
			{
				return this.OO.000O.;
			}
			set
			{
				this.OO.000O. = value;
			}
		}

		/// <summary>
		/// 字节数组，指定要返回给发送者的字节数组
		/// </summary>
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000997B8 File Offset: 0x000979B8
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x000997C0 File Offset: 0x000979C0
		public byte[] ReturnBytes
		{
			get
			{
				return this.OO.000O.;
			}
			set
			{
				this.OO.000O. = value;
			}
		}

		/// <summary>
		/// IPEndpoint型，返回对方的IPEndpoint
		/// </summary>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x000997C9 File Offset: 0x000979C9
		public IPEndPoint IPEndpoint
		{
			get
			{
				return this.OO.000O..O00ooo._.();
			}
		}

		/// <summary>
		/// 字符型，返回对方IP
		/// </summary>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000997D6 File Offset: 0x000979D6
		public string IP
		{
			get
			{
				return this.OO.000O..O00ooo._.().Address.ToString();
			}
		}

		/// <summary>
		/// 返回对方端口
		/// </summary>
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000997ED File Offset: 0x000979ED
		public int Port
		{
			get
			{
				return this.OO.000O..O00ooo._.().Port;
			}
		}

		// Token: 0x04000894 RID: 2196
		private UDPClient <<EMPTY_NAME>>;

		// Token: 0x04000895 RID: 2197
		private UDPClient.OO00_ <<EMPTY_NAME>>;

		// Token: 0x04000896 RID: 2198
		private string <<EMPTY_NAME>>;

		// Token: 0x04000897 RID: 2199
		private byte[] <<EMPTY_NAME>>;
	}
}
