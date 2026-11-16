using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200017F RID: 383
	[oO0oooo("3221")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class StripItemCollection : IEnumerable<StripItem>
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x00080C3C File Offset: 0x0007EE3C
		public StripItemCollection(ToolStripItemCollection A_0, Foxtable.WinForm.Form A_1)
		{
			this.OOOOO.Oo_Oo. = A_0;
			this.OOOOO.Oo_Oo. = A_1;
		}

		/// <summary>
		/// 项目数量
		/// </summary>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00080C52 File Offset: 0x0007EE52
		public int Count
		{
			get
			{
				return this.OOOOO.Oo_Oo..Count;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00080C5F File Offset: 0x0007EE5F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StripItem Item
		{
			get
			{
				return new StripItem(this.OOOOO.Oo_Oo.[Index], this.OOOOO.Oo_Oo.);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00080C78 File Offset: 0x0007EE78
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StripItem Item
		{
			get
			{
				return new StripItem(this.OOOOO.Oo_Oo.[Name], this.OOOOO.Oo_Oo.);
			}
		}

		// Token: 0x1700039A RID: 922
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StripItem this[object A_0]
		{
			get
			{
				int index = -1;
				StripItem result;
				if (int.TryParse(A_0.ToString(), out index))
				{
					result = this.get_Item(index);
				}
				else
				{
					result = this.get_Item(A_0.ToString());
				}
				return result;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的菜单项目
		/// </summary>
		/// <param name="Name">项目名称</param>
		// Token: 0x06001238 RID: 4664 RVA: 0x00080CCA File Offset: 0x0007EECA
		public bool Contains(string Name)
		{
			return this.OOOOO.Oo_Oo..ContainsKey(Name);
		}

		/// <summary>
		/// 用于删除指定名称的菜单项目
		/// </summary>
		/// <param name="Name">项目名称</param>
		// Token: 0x06001239 RID: 4665 RVA: 0x00080CD8 File Offset: 0x0007EED8
		public void Remove(string Name)
		{
			try
			{
				foreach (object obj in this.OOOOO.Oo_Oo.)
				{
					ToolStripItem toolStripItem = (ToolStripItem)obj;
					if (Operators.CompareString(toolStripItem.Name, Name, true) == 0)
					{
						this.OOOOO.Oo_Oo..Remove(toolStripItem);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		/// <summary>
		/// 增加菜单项目
		/// </summary>
		/// <param name="Name">菜单项目名称</param>
		/// <param name="Text">菜单项目标题</param>
		/// <param name="ImageFile">图标文件</param>
		/// <param name="Type">菜单项目类型</param>
		/// <param name="Delimiter">是否在这个项目之前显示一个分割条</param>
		// Token: 0x0600123A RID: 4666 RVA: 0x00080D4C File Offset: 0x0007EF4C
		public StripItem Add(string Name, string Text, string ImageFile, StripItemTypeEnum Type, bool Delimiter = false)
		{
			ToolStripItem toolStripItem = this.OOOOO.Oo_Oo.(Name, Text, ImageFile, Type, Delimiter);
			this.OOOOO.Oo_Oo..Add(toolStripItem);
			return new StripItem(toolStripItem, this.OOOOO.Oo_Oo.);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00080D80 File Offset: 0x0007EF80
		public StripItem Insert(int Index, string Name, string Text, string ImageFile, StripItemTypeEnum Type, bool Delimiter = false)
		{
			ToolStripItem toolStripItem = this.OOOOO.Oo_Oo.(Name, Text, ImageFile, Type, Delimiter);
			this.OOOOO.Oo_Oo..Insert(Index, toolStripItem);
			return new StripItem(toolStripItem, this.OOOOO.Oo_Oo.);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00080DB8 File Offset: 0x0007EFB8
		private ToolStripItem <<EMPTY_NAME>>(string A_0, string A_1, string A_2, StripItemTypeEnum A_3, bool A_4 = false)
		{
			ToolStripItem toolStripItem = null;
			switch (A_3)
			{
			case StripItemTypeEnum.MenuItem:
				toolStripItem = new ToolStripMenuItem();
				break;
			case StripItemTypeEnum.Button:
				toolStripItem = new ToolStripButton();
				toolStripItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
				break;
			case StripItemTypeEnum.Label:
				toolStripItem = new ToolStripLabel();
				break;
			case StripItemTypeEnum.SplitButton:
				toolStripItem = new ToolStripSplitButton();
				toolStripItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
				break;
			case StripItemTypeEnum.TextBox:
				toolStripItem = new ToolStripTextBox();
				break;
			case StripItemTypeEnum.ComboBox:
				toolStripItem = new ToolStripComboBox();
				break;
			case StripItemTypeEnum.Separator:
				toolStripItem = new ToolStripSeparator();
				break;
			}
			toolStripItem.Name = A_0;
			toolStripItem.Text = A_1;
			toolStripItem.Image = OO_00oOO.GetImage(A_2);
			if (A_4)
			{
				this.OOOOO.Oo_Oo..Add(new ToolStripSeparator());
			}
			if (this.OOOOO.Oo_Oo. != null)
			{
				if (A_3 == StripItemTypeEnum.MenuItem)
				{
					((ToolStripDropDownMenu)((ToolStripMenuItem)toolStripItem).DropDown).ItemClicked += this.OOOOO.Oo_Oo..o_O._o_0_o.;
				}
				if (A_3 == StripItemTypeEnum.SplitButton)
				{
					((ToolStripDropDownMenu)((ToolStripSplitButton)toolStripItem).DropDown).ItemClicked += this.OOOOO.Oo_Oo..o_O._o_0_o.;
				}
				toolStripItem.MouseEnter += this.OOOOO.Oo_Oo..O0O_o.OOOO0o.;
				toolStripItem.MouseLeave += this.OOOOO.Oo_Oo..Oo_o.OO.;
				toolStripItem.MouseHover += this.OOOOO.Oo_Oo..o.0__0_0o.;
			}
			return toolStripItem;
		}

		/// <summary>
		/// 增加标准控件
		/// </summary>
		/// <param name="Name">项目名称</param>
		/// <param name="control">控件</param>
		// Token: 0x0600123D RID: 4669 RVA: 0x00080F08 File Offset: 0x0007F108
		public StripItem AddControl(string Name, Foxtable.WinForm.Control control)
		{
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(control.BaseControl, Name);
			toolStripControlHost.AutoSize = false;
			toolStripControlHost.Visible = true;
			this.OOOOO.Oo_Oo..Add(toolStripControlHost);
			return new StripItem(toolStripControlHost, this.OOOOO.Oo_Oo.);
		}

		/// <summary>
		/// 插入标准控件
		/// </summary>
		/// <param name="Name">项目名称</param>
		/// <param name="control">控件</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x0600123E RID: 4670 RVA: 0x00080F4C File Offset: 0x0007F14C
		public StripItem InsertControl(string Name, Foxtable.WinForm.Control control, int Index)
		{
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(control.BaseControl, Name);
			toolStripControlHost.AutoSize = false;
			toolStripControlHost.Visible = true;
			if (Index < 0)
			{
				this.OOOOO.Oo_Oo..Add(toolStripControlHost);
			}
			else
			{
				this.OOOOO.Oo_Oo..Insert(Index, toolStripControlHost);
			}
			return new StripItem(toolStripControlHost, this.OOOOO.Oo_Oo.);
		}

		/// <summary>
		/// 清除所有菜单项目
		/// </summary>
		// Token: 0x0600123F RID: 4671 RVA: 0x00080FA0 File Offset: 0x0007F1A0
		public void Clear()
		{
			this.OOOOO.Oo_Oo..Clear();
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00080FAD File Offset: 0x0007F1AD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<StripItem> GetEnumerator()
		{
			return new O00Oo00ooO0_(this.OOOOO.Oo_Oo., this.OOOOO.Oo_Oo.);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00080FC0 File Offset: 0x0007F1C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new O00Oo00ooO0_(this.OOOOO.Oo_Oo., this.OOOOO.Oo_Oo.);
		}

		// Token: 0x040006FC RID: 1788
		private ToolStripItemCollection <<EMPTY_NAME>>;

		// Token: 0x040006FD RID: 1789
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;
	}
}
