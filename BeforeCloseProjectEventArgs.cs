using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200024D RID: 589
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("0668")]
	public class BeforeCloseProjectEventArgs
	{
		/// <summary>
		/// 设为True，拒绝关闭项目
		/// </summary>
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000C4958 File Offset: 0x000C2B58
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x000C4960 File Offset: 0x000C2B60
		public bool Cancel
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
			set
			{
				this.oo00.0oOoO0o. = value;
			}
		}

		/// <summary>
		/// 设为True，将不保存项目，直接关闭
		/// </summary>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000C4969 File Offset: 0x000C2B69
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x000C4971 File Offset: 0x000C2B71
		public bool SkipSave
		{
			get
			{
				return this.oO.O0O00oo_.;
			}
			set
			{
				this.oO.O0O00oo_. = value;
			}
		}

		// Token: 0x04000BF1 RID: 3057
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BF2 RID: 3058
		private bool <<EMPTY_NAME>>;
	}
}
