using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000190 RID: 400
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OpenQQMenuEventArgs
	{
		// Token: 0x06001314 RID: 4884 RVA: 0x00083CF2 File Offset: 0x00081EF2
		public OpenQQMenuEventArgs(string A_0, string A_1, int A_2, string A_3, DateTime A_4)
		{
			this.OOoo.00O_0. = A_0;
			this.O._000. = A_1;
			this.o.O0o_Ooo_o. = A_2;
			this.oo_._O_. = A_3;
			this.o.O0o_Ooo_o. = A_4;
		}

		/// <summary>
		/// 字符型，返回内置聊天窗口当前选定用户名
		/// </summary>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00083D1F File Offset: 0x00081F1F
		public string BuddyName
		{
			get
			{
				return this.OOoo.00O_0.;
			}
		}

		/// <summary>
		/// 字符型，返回内置聊天窗口当前选定的消息内容
		/// </summary>
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00083D27 File Offset: 0x00081F27
		public string Content
		{
			get
			{
				return this.O._000.;
			}
		}

		/// <summary>
		/// 整数型，返回内置聊天窗口单签选定的消息类型
		/// </summary>
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00083D2F File Offset: 0x00081F2F
		public int ContentType
		{
			get
			{
				return this.o.O0o_Ooo_o.;
			}
		}

		/// <summary>
		/// 返回内置聊天窗口当前选定消息的发送者的名称
		/// </summary>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00083D37 File Offset: 0x00081F37
		public string Sender
		{
			get
			{
				return this.oo_._O_.;
			}
		}

		/// <summary>
		/// 日期时间型，返回内置聊天窗口当前选定消息的发送时间
		/// </summary>
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00083D3F File Offset: 0x00081F3F
		public DateTime Sendtime
		{
			get
			{
				return this.o.O0o_Ooo_o.;
			}
		}

		// Token: 0x04000765 RID: 1893
		private string <<EMPTY_NAME>>;

		// Token: 0x04000766 RID: 1894
		private string <<EMPTY_NAME>>;

		// Token: 0x04000767 RID: 1895
		private int <<EMPTY_NAME>>;

		// Token: 0x04000768 RID: 1896
		private string <<EMPTY_NAME>>;

		// Token: 0x04000769 RID: 1897
		private DateTime <<EMPTY_NAME>>;
	}
}
