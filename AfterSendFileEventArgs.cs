using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200018F RID: 399
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class AfterSendFileEventArgs
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x00083CAC File Offset: 0x00081EAC
		public AfterSendFileEventArgs(string A_0, string A_1, bool A_2)
		{
			this.O.0___0__0. = A_0;
			this.O___o.O_0__OoO. = A_1;
			this.O.0___0__0. = A_2;
		}

		/// <summary>
		/// 如果是向服务器发送，可以通过此属性获取此文件在服务器对应的文件名
		/// </summary>
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00083CC9 File Offset: 0x00081EC9
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x00083CD1 File Offset: 0x00081ED1
		public string ServerFileName
		{
			get
			{
				return this.oOO00.0O_0__0.;
			}
			internal set
			{
				this.oOO00.0O_0__0. = value;
			}
		}

		/// <summary>
		/// 如果发送成功，返回True，否则返回False
		/// </summary>
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00083CDA File Offset: 0x00081EDA
		public bool Success
		{
			get
			{
				return this.O.0___0__0.;
			}
		}

		/// <summary>
		/// 返回接收方名称，如果是向服务器发送，则返回空
		/// </summary>
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00083CE2 File Offset: 0x00081EE2
		public string UserName
		{
			get
			{
				return this.O.0___0__0.;
			}
		}

		/// <summary>
		/// 返回发送的文件名，含路径
		/// </summary>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x00083CEA File Offset: 0x00081EEA
		public string FileName
		{
			get
			{
				return this.O___o.O_0__OoO.;
			}
		}

		// Token: 0x04000761 RID: 1889
		private string <<EMPTY_NAME>>;

		// Token: 0x04000762 RID: 1890
		private string <<EMPTY_NAME>>;

		// Token: 0x04000763 RID: 1891
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000764 RID: 1892
		private string <<EMPTY_NAME>>;
	}
}
