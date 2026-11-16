using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000182 RID: 386
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class StripItemEventArgs
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x0008142C File Offset: 0x0007F62C
		public StripItemEventArgs(ToolStrip A_0, ToolStripItem A_1, ToolStripItem A_2, Foxtable.WinForm.Form A_3)
		{
			this.Ooo0.o. = A_0;
			this.Ooo0.o. = A_1;
			this.o_O__.0O. = A_2;
			this.Ooo0.o. = A_3;
		}

		/// <summary>
		/// 触发事件的菜单
		/// </summary>
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00081451 File Offset: 0x0007F651
		public Strip Strip
		{
			get
			{
				return new Strip(this.Ooo0.o., this.Ooo0.o.);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00081464 File Offset: 0x0007F664
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StripItem ParentItem
		{
			get
			{
				StripItem result;
				if (this.o_O__.0O. == null)
				{
					result = null;
				}
				else
				{
					result = new StripItem(this.o_O__.0O., this.Ooo0.o.);
				}
				return result;
			}
		}

		/// <summary>
		/// 触发事件的菜单项目
		/// </summary>
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00081490 File Offset: 0x0007F690
		public StripItem StripItem
		{
			get
			{
				return new StripItem(this.Ooo0.o., this.Ooo0.o.);
			}
		}

		/// <summary>
		/// 触发事件的窗口
		/// </summary>
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000814A3 File Offset: 0x0007F6A3
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.Ooo0.o.;
			}
		}

		// Token: 0x04000704 RID: 1796
		private ToolStrip <<EMPTY_NAME>>;

		// Token: 0x04000705 RID: 1797
		private ToolStripItem <<EMPTY_NAME>>;

		// Token: 0x04000706 RID: 1798
		private ToolStripItem <<EMPTY_NAME>>;

		// Token: 0x04000707 RID: 1799
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;
	}
}
