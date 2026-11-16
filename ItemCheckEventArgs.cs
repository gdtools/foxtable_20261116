using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003F1 RID: 1009
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ItemCheckEventArgs : ControlEventArgs
	{
		// Token: 0x06004173 RID: 16755 RVA: 0x001D897B File Offset: 0x001D6B7B
		public ItemCheckEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ItemCheckEventArgs A_2) : base(A_0, A_1)
		{
			this.O_OO0.O. = A_2;
		}

		/// <summary>
		/// 返回项目位置
		/// </summary>
		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06004174 RID: 16756 RVA: 0x001D898C File Offset: 0x001D6B8C
		public int Index
		{
			get
			{
				return this.O_OO0.O..Index;
			}
		}

		/// <summary>
		/// 返回或设置项目新的选中状态
		/// </summary>
		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x001D8999 File Offset: 0x001D6B99
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x001D89A9 File Offset: 0x001D6BA9
		public bool Checked
		{
			get
			{
				return this.O_OO0.O..NewValue == CheckState.Checked;
			}
			set
			{
				if (value)
				{
					this.O_OO0.O..NewValue = CheckState.Checked;
					return;
				}
				this.O_OO0.O..NewValue = CheckState.Unchecked;
			}
		}

		// Token: 0x04001A67 RID: 6759
		private ItemCheckEventArgs <<EMPTY_NAME>>;
	}
}
