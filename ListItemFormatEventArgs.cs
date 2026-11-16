using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003F2 RID: 1010
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ListItemFormatEventArgs : ControlEventArgs
	{
		// Token: 0x06004177 RID: 16759 RVA: 0x001D89C7 File Offset: 0x001D6BC7
		public ListItemFormatEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, DataRowView A_2) : base(A_0, A_1)
		{
			this.oo.oO_. = A_2;
		}

		/// <summary>
		/// 列表项目准备显示的内容
		/// </summary>
		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x001D89D8 File Offset: 0x001D6BD8
		// (set) Token: 0x06004179 RID: 16761 RVA: 0x001D89E0 File Offset: 0x001D6BE0
		public string Value
		{
			get
			{
				return this.O0.ooOo0.;
			}
			set
			{
				this.O0.ooOo0. = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600417A RID: 16762 RVA: 0x001D89E9 File Offset: 0x001D6BE9
		// (set) Token: 0x0600417B RID: 16763 RVA: 0x001D89F1 File Offset: 0x001D6BF1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Text
		{
			get
			{
				return this.O0.ooOo0.;
			}
			set
			{
				this.O0.ooOo0. = value;
			}
		}

		/// <summary>
		/// 准备显示的行，DataRow类型
		/// </summary>
		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x001D89FA File Offset: 0x001D6BFA
		public DataRow ListItem
		{
			get
			{
				return new DataRow(this.oo.oO_..Row);
			}
		}

		// Token: 0x04001A68 RID: 6760
		private DataRowView <<EMPTY_NAME>>;

		// Token: 0x04001A69 RID: 6761
		private string <<EMPTY_NAME>>;
	}
}
