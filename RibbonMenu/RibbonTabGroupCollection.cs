using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000035 RID: 53
	[oO0oooo("3088")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTabGroupCollection : IEnumerable
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00004D2B File Offset: 0x00002F2B
		public RibbonTabGroupCollection(RibbonTabGroupCollection A_0)
		{
			this.OO0.0OOo__. = A_0;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004D3A File Offset: 0x00002F3A
		public void Add(TabGroup tabGroup)
		{
			this.OO0.0OOo__..Add(tabGroup.RibbonTabGroup);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00004D4E File Offset: 0x00002F4E
		public void Insert(int Index, TabGroup tabGroup)
		{
			this.OO0.0OOo__..Insert(Index, tabGroup.RibbonTabGroup);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004D62 File Offset: 0x00002F62
		public void Remove(TabGroup tabGroup)
		{
			if (this.OO0.0OOo__..Contains(tabGroup.RibbonTabGroup))
			{
				this.OO0.0OOo__..Remove(tabGroup.RibbonTabGroup);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004D88 File Offset: 0x00002F88
		public void Remove(string tgpName)
		{
			if (this.OO0.0OOo__..Contains(tgpName))
			{
				this.OO0.0OOo__..Remove(this.OO0.0OOo__.[tgpName]);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004DAF File Offset: 0x00002FAF
		public void RemoveAt(int Index)
		{
			this.OO0.0OOo__..RemoveAt(Index);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00004DBD File Offset: 0x00002FBD
		public int Count
		{
			get
			{
				return this.OO0.0OOo__..Count;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00004DCA File Offset: 0x00002FCA
		public void Clear()
		{
			this.OO0.0OOo__..Clear();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public bool Contains(string Name)
		{
			return this.OO0.0OOo__..Contains(Name);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004DE5 File Offset: 0x00002FE5
		public bool Contains(TabGroup g)
		{
			return this.OO0.0OOo__..Contains(g.RibbonTabGroup);
		}

		// Token: 0x170000C5 RID: 197
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TabGroup this[object A_0]
		{
			get
			{
				TabGroup result;
				if (A_0 is string)
				{
					result = this[Conversions.ToString(A_0)];
				}
				else
				{
					result = this[Conversions.ToInteger(A_0)];
				}
				return result;
			}
		}

		// Token: 0x170000C6 RID: 198
		public TabGroup this[int A_0]
		{
			get
			{
				TabGroup result;
				if (A_0 >= 0 && A_0 <= this.OO0.0OOo__..Count - 1)
				{
					result = new TabGroup(this.OO0.0OOo__.[A_0]);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170000C7 RID: 199
		public TabGroup this[string A_0]
		{
			get
			{
				TabGroup result;
				if (this.OO0.0OOo__..Contains(A_0))
				{
					result = new TabGroup(this.OO0.0OOo__.[A_0]);
				}
				else
				{
					MessageBox.Show("菜单中不存在名为\"" + A_0 + "\"的TabGroup！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004EB4 File Offset: 0x000030B4
		public IEnumerator GetEnumerator()
		{
			return new RibbonTabGroupEnumerator(this);
		}

		// Token: 0x04000057 RID: 87
		private RibbonTabGroupCollection <<EMPTY_NAME>>;
	}
}
