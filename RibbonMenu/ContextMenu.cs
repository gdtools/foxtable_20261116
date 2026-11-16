using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 快捷菜单
	/// </summary>
	// Token: 0x02000027 RID: 39
	[ComVisible(true)]
	public class ContextMenu
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00003AB9 File Offset: 0x00001CB9
		public ContextMenu(C1ContextMenu A_0)
		{
			this.o_o_0oO_.o_o. = new C1ContextMenu();
			this.o_o_0oO_.o_o. = A_0;
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public string Name
		{
			get
			{
				return this.o_o_0oO_.o_o..Name;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00003AE0 File Offset: 0x00001CE0
		internal C1ContextMenu BaseMenu
		{
			get
			{
				return this.o_o_0oO_.o_o.;
			}
		}

		// Token: 0x17000091 RID: 145
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括快捷菜单的所有项目
		/// </summary>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00003AF6 File Offset: 0x00001CF6
		public ContextCommandCollection Items
		{
			get
			{
				if (this.o_o_0oO_.o_o. == null)
				{
					this.o_o_0oO_.o_o. = new ContextCommandCollection(this.o_o_0oO_.o_o..CommandLinks);
				}
				return this.o_o_0oO_.o_o.;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003B1C File Offset: 0x00001D1C
		internal void Show(System.Windows.Forms.Control control, Point Point)
		{
			this.o_o_0oO_.o_o..ShowContextMenu(control, Point);
		}

		/// <summary>
		/// 在指定的控件上显示快捷菜单
		/// </summary>
		/// <param name="control">控件</param>
		/// <param name="x">水平显示位置，从控件的左上角开始计算</param>
		/// <param name="y"> 垂直显示位置，从空间的左上角开始计算</param>
		// Token: 0x06000137 RID: 311 RVA: 0x00003B2B File Offset: 0x00001D2B
		public void Show(Foxtable.WinForm.Control control, int x, int y)
		{
			this.o_o_0oO_.o_o..ShowContextMenu(control.BaseControl, new Point(x, y));
		}

		// Token: 0x0400003F RID: 63
		private C1ContextMenu <<EMPTY_NAME>>;

		// Token: 0x04000040 RID: 64
		private ContextCommandCollection <<EMPTY_NAME>>;
	}
}
