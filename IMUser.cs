using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020002EF RID: 751
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class IMUser
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x0012A7E7 File Offset: 0x001289E7
		internal IMUser(string A_0, IPEndPoint A_1)
		{
			this.oO_0OO.0. = new List<string>();
			this.OO__o_.O0_0O_0. = OoOo0O.OO_o.0o_O.(4);
			this.o_.oOoo_0. = A_0;
			this.oO_0OO.0. = A_1;
			this.o_.oOoo_0. = DateTime.Now;
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x0012A81F File Offset: 0x00128A1F
		internal IPEndPoint WanIP
		{
			get
			{
				return this.oO_0OO.0.;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x0012A827 File Offset: 0x00128A27
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x0012A82F File Offset: 0x00128A2F
		internal IPEndPoint LanIP
		{
			get
			{
				return this.OO__o_.O0_0O_0.;
			}
			set
			{
				this.OO__o_.O0_0O_0. = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x0012A838 File Offset: 0x00128A38
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x0012A840 File Offset: 0x00128A40
		internal DateTime LastHeartbeatTime
		{
			get
			{
				return this.o_.oOoo_0.;
			}
			set
			{
				this.o_.oOoo_0. = value;
			}
		}

		/// <summary>
		/// 用户名
		/// </summary>
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x0012A849 File Offset: 0x00128A49
		public string Name
		{
			get
			{
				return this.o_.oOoo_0.;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0012A851 File Offset: 0x00128A51
		internal List<string> Buddies
		{
			get
			{
				return this.oO_0OO.0.;
			}
		}

		/// <summary>
		/// 用户的广域网IP
		/// </summary>
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x0012A859 File Offset: 0x00128A59
		public string WanIPAddress
		{
			get
			{
				return this.WanIP.ToString();
			}
		}

		/// <summary>
		/// 用户的局域网IP
		/// </summary>
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0012A868 File Offset: 0x00128A68
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
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x0012A892 File Offset: 0x00128A92
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x0012A89A File Offset: 0x00128A9A
		public object Tag
		{
			get
			{
				return this.o_.oOoo_0.;
			}
			set
			{
				this.o_.oOoo_0. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x0400110C RID: 4364
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x0400110D RID: 4365
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400110E RID: 4366
		private string <<EMPTY_NAME>>;

		// Token: 0x0400110F RID: 4367
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001110 RID: 4368
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x04001111 RID: 4369
		private object <<EMPTY_NAME>>;

		// Token: 0x04001112 RID: 4370
		internal string <<EMPTY_NAME>>;
	}
}
