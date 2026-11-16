using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 复选框
	/// </summary>
	// Token: 0x02000013 RID: 19
	[ComVisible(true)]
	public class CheckBox : RibbonItem
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002D2D File Offset: 0x00000F2D
		internal CheckBox(RibbonCheckBox A_0) : base(A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002D3D File Offset: 0x00000F3D
		public CheckBox(string A_0)
		{
			this.oOoOoOoO._o0. = new RibbonCheckBox();
			this.oOo_.0o_O_O_0. = this.oOoOoOoO._o0.;
			this.oOoOoOoO._o0..ID = A_0;
		}

		/// <summary>
		/// 返回或设置检查框的勾选状态
		/// </summary>
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002D68 File Offset: 0x00000F68
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002D75 File Offset: 0x00000F75
		public bool Checked
		{
			get
			{
				return this.oOoOoOoO._o0..Checked;
			}
			set
			{
				this.oOoOoOoO._o0..Checked = value;
			}
		}

		/// <summary>
		/// 快捷键
		/// </summary>
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002D83 File Offset: 0x00000F83
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002D90 File Offset: 0x00000F90
		public Keys ShortcutKeys
		{
			get
			{
				return this.oOoOoOoO._o0..ShortcutKeys;
			}
			set
			{
				this.oOoOoOoO._o0..ShortcutKeys = value;
			}
		}

		/// <summary>
		/// 返回或设置检查框的标题
		/// </summary>
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002D9E File Offset: 0x00000F9E
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002DAB File Offset: 0x00000FAB
		public string Text
		{
			get
			{
				return this.oOoOoOoO._o0..Text;
			}
			set
			{
				this.oOoOoOoO._o0..Text = value;
			}
		}

		// Token: 0x04000018 RID: 24
		internal RibbonCheckBox <<EMPTY_NAME>>;
	}
}
