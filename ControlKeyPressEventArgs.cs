using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003EF RID: 1007
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControlKeyPressEventArgs : ControlEventArgs
	{
		// Token: 0x0600416B RID: 16747 RVA: 0x001D891F File Offset: 0x001D6B1F
		public ControlKeyPressEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, string A_2) : base(A_0, A_1)
		{
			this.OO00_O0_._OO0. = A_2;
		}

		/// <summary>
		/// 返回所按下的字符
		/// </summary>
		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x001D8930 File Offset: 0x001D6B30
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x001D8938 File Offset: 0x001D6B38
		public string KeyChar
		{
			get
			{
				return this.OO00_O0_._OO0.;
			}
			set
			{
				this.OO00_O0_._OO0. = value;
			}
		}

		// Token: 0x04001A64 RID: 6756
		private string <<EMPTY_NAME>>;
	}
}
