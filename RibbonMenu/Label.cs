using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 标签
	/// </summary>
	// Token: 0x02000011 RID: 17
	[ComVisible(true)]
	public class Label : RibbonItem
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002C93 File Offset: 0x00000E93
		internal Label(RibbonLabel A_0) : base(A_0)
		{
			this.OOo.O_o. = A_0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public Label(string A_0)
		{
			this.OOo.O_o. = new RibbonLabel();
			this.oOo_.0o_O_O_0. = this.OOo.O_o.;
			this.OOo.O_o..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置标签的文本内容
		/// </summary>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002CCE File Offset: 0x00000ECE
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002CDB File Offset: 0x00000EDB
		public string Text
		{
			get
			{
				return this.OOo.O_o..Text;
			}
			set
			{
				this.OOo.O_o..Text = value;
			}
		}

		// Token: 0x04000016 RID: 22
		internal RibbonLabel <<EMPTY_NAME>>;
	}
}
