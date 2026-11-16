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
	// Token: 0x0200017A RID: 378
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("Strips")]
	public class StripCollection : IEnumerable<Strip>
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x00080178 File Offset: 0x0007E378
		public StripCollection(Dictionary<string, ToolStrip> A_0, Foxtable.WinForm.Form A_1)
		{
			this.o.__o_O. = A_0;
			this.o.__o_O. = A_1;
		}

		/// <summary>
		/// 菜单数量
		/// </summary>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0008018E File Offset: 0x0007E38E
		public int Count
		{
			get
			{
				return this.o.__o_O..Count;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0008019C File Offset: 0x0007E39C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Strip Item
		{
			get
			{
				List<string> list = new List<string>();
				list.AddRange(this.o.__o_O..Keys);
				return new Strip(this.o.__o_O.[list[index]], this.o.__o_O.);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000801DD File Offset: 0x0007E3DD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Strip Item
		{
			get
			{
				return new Strip(this.o.__o_O.[Name], this.o.__o_O.);
			}
		}

		// Token: 0x17000390 RID: 912
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Strip this[object A_0]
		{
			get
			{
				int index = -1;
				Strip result;
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
		/// 删除指定名称的菜单
		/// </summary>
		/// <param name="Name">菜单名</param>
		// Token: 0x06001215 RID: 4629 RVA: 0x00080230 File Offset: 0x0007E430
		public void Remove(string Name)
		{
			if (this.o.__o_O..ContainsKey(Name))
			{
				ToolStrip toolStrip = this.o.__o_O.[Name];
				this.o.__o_O..Remove(Name);
				if (toolStrip.Parent != null)
				{
					toolStrip.Parent.Controls.Remove(toolStrip);
				}
				toolStrip.Dispose();
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的菜单
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x06001216 RID: 4630 RVA: 0x00080284 File Offset: 0x0007E484
		public bool Contains(string Name)
		{
			return this.o.__o_O..O_0.O00o_00_O..ContainsKey(Name);
		}

		/// <summary>
		/// 删除所有菜单
		/// </summary>
		// Token: 0x06001217 RID: 4631 RVA: 0x00080298 File Offset: 0x0007E498
		public void Clear()
		{
			try
			{
				foreach (ToolStrip toolStrip in this.o.__o_O..Values)
				{
					if (toolStrip.Parent != null)
					{
						toolStrip.Parent.Controls.Remove(toolStrip);
					}
					toolStrip.Dispose();
				}
			}
			finally
			{
				Dictionary<string, ToolStrip>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.o.__o_O..Clear();
		}

		/// <summary>
		/// 增加菜单
		/// </summary>
		/// <param name="Name">菜单名</param>
		/// <param name="Type">菜单类型</param>
		/// <param name="Dock">停靠位置</param>
		// Token: 0x06001218 RID: 4632 RVA: 0x00080314 File Offset: 0x0007E514
		public Strip Add(string Name, StripTypeEnum Type, DockStyle Dock = DockStyle.None)
		{
			ToolStrip toolStrip;
			switch (Type)
			{
			case StripTypeEnum.MainMenu:
				toolStrip = new MenuStrip();
				toolStrip.Dock = DockStyle.Top;
				break;
			case StripTypeEnum.ToolBar:
				toolStrip = new ToolStrip();
				if (Dock != DockStyle.None && Dock != DockStyle.Fill)
				{
					toolStrip.Dock = Dock;
				}
				else
				{
					toolStrip.Dock = DockStyle.Top;
				}
				break;
			case StripTypeEnum.StatusBar:
				toolStrip = new StatusStrip();
				toolStrip.Dock = DockStyle.Bottom;
				toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
				((StatusStrip)toolStrip).SizingGrip = true;
				break;
			case StripTypeEnum.ContextMenu:
				toolStrip = new ContextMenuStrip();
				break;
			default:
				return null;
			}
			toolStrip.ItemClicked += this.o.__o_O..o_O._o_0_o.;
			if (Type != StripTypeEnum.ContextMenu)
			{
				this.o.__o_O..Pane.Controls.Add(toolStrip);
			}
			if (Operators.CompareString(this.o.__o_O..MenuTheme, "(none)", true) == 0)
			{
				toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
				toolStrip.Renderer = O_O0OO.o0_OO.000.();
			}
			else
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(this.o.__o_O..MenuTheme, new object[]
				{
					toolStrip
				});
			}
			this.o.__o_O..O_0.O00o_00_O..Add(Name, toolStrip);
			toolStrip.Name = Name;
			return this.o.__o_O..Strips[Name];
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00080442 File Offset: 0x0007E642
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Strip> GetEnumerator()
		{
			List<ToolStrip> list = new List<ToolStrip>();
			list.AddRange(this.o.__o_O..Values);
			return new OoO00OooO_(list, this.o.__o_O.);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00080465 File Offset: 0x0007E665
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			List<ToolStrip> list = new List<ToolStrip>();
			list.AddRange(this.o.__o_O..Values);
			return new OoO00OooO_(list, this.o.__o_O.);
		}

		// Token: 0x040006EC RID: 1772
		internal Dictionary<string, ToolStrip> <<EMPTY_NAME>>;

		// Token: 0x040006ED RID: 1773
		internal Foxtable.WinForm.Form <<EMPTY_NAME>>;
	}
}
