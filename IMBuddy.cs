using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001C8 RID: 456
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class IMBuddy
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x0009997C File Offset: 0x00097B7C
		internal IMBuddy(string A_0, IPEndPoint A_1, string A_2)
		{
			this.O.__0_0__0O0_o. = A_0;
			this.O.__0_0__0O0_o. = A_1;
			this.o.0__0o0OO_0oo. = A_2;
			if (this.O.__0_0__0O0_o..IndexOf(".") > 0)
			{
				this.Oo_O___oO.__0. = this.O.__0_0__0O0_o..Substring(0, this.O.__0_0__0O0_o..IndexOf("."));
				this.Oo__.0o. = this.O.__0_0__0O0_o..Substring(this.O.__0_0__0O0_o..IndexOf(".") + 1);
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000999FC File Offset: 0x00097BFC
		public IMBuddy(string A_0, string A_1)
		{
			this.Oo0__0O_00O.0o. = true;
			this.O.__0_0__0O0_o. = A_0;
			if (A_1.IndexOf(".") > 0)
			{
				this.Oo_O___oO.__0. = A_1.Substring(0, A_1.IndexOf("."));
				this.Oo__.0o. = A_1.Substring(A_1.IndexOf(".") + 1);
				return;
			}
			this.Oo_O___oO.__0. = "微信用户";
			this.Oo__.0o. = A_1;
		}

		/// <summary>
		/// 是否是微信用户
		/// </summary>
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00099A6F File Offset: 0x00097C6F
		public bool FromWeChat
		{
			get
			{
				return this.Oo0__0O_00O.0o.;
			}
		}

		/// <summary>
		/// 如果是微信用户，可通过此属性获得用户的微信ID
		/// </summary>
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00099A78 File Offset: 0x00097C78
		public string WeID
		{
			get
			{
				string result;
				if (this.FromWeChat)
				{
					result = this.o.0__0o0OO_0oo.;
				}
				else
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00099A9D File Offset: 0x00097C9D
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00099AA5 File Offset: 0x00097CA5
		internal IPEndPoint WanIP
		{
			get
			{
				return this.O.__0_0__0O0_o.;
			}
			set
			{
				this.O.__0_0__0O0_o. = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00099AAE File Offset: 0x00097CAE
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00099AB6 File Offset: 0x00097CB6
		internal IPEndPoint LanIP
		{
			get
			{
				return this.o.0__0o0OO_0oo.;
			}
			set
			{
				this.o.0__0o0OO_0oo. = value;
			}
		}

		/// <summary>
		/// 字符型,返回好友名称,含分组名
		/// </summary>
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00099ABF File Offset: 0x00097CBF
		public string Name
		{
			get
			{
				return this.O.__0_0__0O0_o.;
			}
		}

		/// <summary>
		/// 字符型,返回好友名称,不含分组名
		/// </summary>
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00099AC8 File Offset: 0x00097CC8
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x00099AF9 File Offset: 0x00097CF9
		public string SimpleName
		{
			get
			{
				string result;
				if (Operators.CompareString(this.Oo__.0o., "", true) == 0)
				{
					result = this.O.__0_0__0O0_o.;
				}
				else
				{
					result = this.Oo__.0o.;
				}
				return result;
			}
			internal set
			{
				this.Oo__.0o. = value;
			}
		}

		/// <summary>
		/// 字符型，返回好友分组
		/// </summary>
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00099B04 File Offset: 0x00097D04
		public string UserGroup
		{
			get
			{
				string result;
				if (Operators.CompareString(this.Oo_O___oO.__0., "", true) == 0)
				{
					result = "未分组";
				}
				else
				{
					result = this.Oo_O___oO.__0.;
				}
				return result;
			}
		}

		/// <summary>
		/// 逻辑型，用于判断好友是否在线
		/// </summary>
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00099B34 File Offset: 0x00097D34
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00099B46 File Offset: 0x00097D46
		public bool OnLine
		{
			get
			{
				return this.O.__0_0__0O0_o. != null && this.O.__0_0__0O0_o.;
			}
			internal set
			{
				if (!value)
				{
					this.O.__0_0__0O0_o. = false;
					this.O.__0_0__0O0_o. = null;
					this.o.0__0o0OO_0oo. = null;
					this.oOo.o0__0Oo0oO. = 0;
					this.O00OO.o_. = 0;
					this.oO0.OooOOO00. = 0;
					this.O00OO.o_. = false;
					this.oO0.OooOOO00. = false;
				}
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00099B83 File Offset: 0x00097D83
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00099B8B File Offset: 0x00097D8B
		internal DateTime LastReceiveHeartbeatTime
		{
			get
			{
				return this.O.__0_0__0O0_o.;
			}
			set
			{
				this.O.__0_0__0O0_o. = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00099B94 File Offset: 0x00097D94
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x00099B9C File Offset: 0x00097D9C
		internal string RandKey
		{
			get
			{
				return this.o.0__0o0OO_0oo.;
			}
			set
			{
				this.o.0__0o0OO_0oo. = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00099BA5 File Offset: 0x00097DA5
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x00099BAD File Offset: 0x00097DAD
		internal bool Ready
		{
			get
			{
				return this.O.__0_0__0O0_o.;
			}
			set
			{
				this.O.__0_0__0O0_o. = value;
			}
		}

		/// <summary>
		/// 好友广域网IP地址
		/// </summary>
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00099BB8 File Offset: 0x00097DB8
		public string WanIPAddress
		{
			get
			{
				string result;
				if (this.WanIP != null)
				{
					result = this.WanIP.ToString();
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		/// <summary>
		/// 好友局域网IP地址
		/// </summary>
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00099BE4 File Offset: 0x00097DE4
		public string LanIPAddress
		{
			get
			{
				string result;
				if (this.LanIP != null)
				{
					result = this.LanIP.ToString();
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		/// <summary>
		/// 返回或设置用户附加信息
		/// </summary>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00099C0E File Offset: 0x00097E0E
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00099C16 File Offset: 0x00097E16
		public object Tag
		{
			get
			{
				return this.O.__0_0__0O0_o.;
			}
			set
			{
				this.O.__0_0__0O0_o. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 逻辑型，用于判断是否已经穿透对方NAT
		/// </summary>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00099C24 File Offset: 0x00097E24
		public bool p2p
		{
			get
			{
				return this.oOo.o0__0Oo0oO. > 0 && this.O00OO.o_. > 0;
			}
		}

		// Token: 0x040008A5 RID: 2213
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040008A6 RID: 2214
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040008A7 RID: 2215
		private string <<EMPTY_NAME>>;

		// Token: 0x040008A8 RID: 2216
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040008A9 RID: 2217
		internal int <<EMPTY_NAME>>;

		// Token: 0x040008AA RID: 2218
		internal int <<EMPTY_NAME>>;

		// Token: 0x040008AB RID: 2219
		internal int <<EMPTY_NAME>>;

		// Token: 0x040008AC RID: 2220
		internal string <<EMPTY_NAME>>;

		// Token: 0x040008AD RID: 2221
		private bool <<EMPTY_NAME>>;

		// Token: 0x040008AE RID: 2222
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040008AF RID: 2223
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040008B0 RID: 2224
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040008B1 RID: 2225
		internal DateTime <<EMPTY_NAME>>;

		// Token: 0x040008B2 RID: 2226
		private object <<EMPTY_NAME>>;

		// Token: 0x040008B3 RID: 2227
		private string <<EMPTY_NAME>>;

		// Token: 0x040008B4 RID: 2228
		private string <<EMPTY_NAME>>;

		// Token: 0x040008B5 RID: 2229
		internal int <<EMPTY_NAME>>;

		// Token: 0x040008B6 RID: 2230
		internal DateTime <<EMPTY_NAME>>;

		// Token: 0x040008B7 RID: 2231
		private bool <<EMPTY_NAME>>;
	}
}
