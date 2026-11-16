using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002FA RID: 762
	[oO0oooo("1615")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BeforeOpenProjectEventArgs : CancelEventArgs
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x0012AC36 File Offset: 0x00128E36
		public BeforeOpenProjectEventArgs(string A_0)
		{
			this.O.O00. = A_0;
		}

		/// <summary>
		/// 正在打开的项目文件名称
		/// </summary>
		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x0012AC45 File Offset: 0x00128E45
		public string File
		{
			get
			{
				return this.O.O00.;
			}
		}

		/// <summary>
		/// 逻辑型，设为True，关闭Foxtable的启动封面
		/// </summary>
		// Token: 0x170008E2 RID: 2274
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x0012AC4D File Offset: 0x00128E4D
		public bool HideSplashForm
		{
			set
			{
				if (value)
				{
					OO_00oOO.CloseSplashForm();
				}
			}
		}

		// Token: 0x04001128 RID: 4392
		private string <<EMPTY_NAME>>;
	}
}
