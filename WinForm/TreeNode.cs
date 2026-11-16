using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x020003D4 RID: 980
	[ComVisible(true)]
	public class TreeNode : CustomTreeNodeProperty
	{
		// Token: 0x06003FE8 RID: 16360 RVA: 0x001D1D00 File Offset: 0x001CFF00
		internal TreeNode(O_o__00Ooo A_0) : base(A_0)
		{
			this.oO_0o_.0__O. = A_0;
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x001D1D10 File Offset: 0x001CFF10
		public TreeNodes Nodes
		{
			get
			{
				if (this.oO_0o_.0__O. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.oO_0o_.0__O., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(this.oO_0o_.0__O., ref flag);
					if (this.oO_0o_.0__O..State == 0)
					{
						this.oO_0o_.0__O..State = 2;
						this.oO_0o_.0__O. = null;
					}
					else if (this.oO_0o_.0__O..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.oO_0o_.0__O..State = 1;
					if (flag)
					{
						Monitor.Exit(this.oO_0o_.0__O.);
					}
				}
				if (this.oO_0o_.0__O. == null)
				{
					this.oO_0o_.0__O. = new TreeNodes(this.o0Ooo_O0oo.O__..Nodes);
				}
				return this.oO_0o_.0__O.;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06003FEA RID: 16362 RVA: 0x001D1DD0 File Offset: 0x001CFFD0
		public TreeNode ParentNode
		{
			get
			{
				TreeNode result;
				if (this.oO_0o_.0__O..Parent != null)
				{
					result = new TreeNode((O_o__00Ooo)this.oO_0o_.0__O..Parent);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x001D1E05 File Offset: 0x001D0005
		public bool HasChdren
		{
			get
			{
				return this.o0Ooo_O0oo.O__..GetNodeCount(false) > 0;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x001D1E16 File Offset: 0x001D0016
		public string FullPath
		{
			get
			{
				return this.o0Ooo_O0oo.O__..FullPath;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x001D1E24 File Offset: 0x001D0024
		public string FullName
		{
			get
			{
				string text = this.oO_0o_.0__O..Name;
				for (TreeNode parent = this.oO_0o_.0__O..Parent; parent != null; parent = parent.Parent)
				{
					text = parent.Name + this.o0Ooo_O0oo.O__..TreeView.PathSeparator + text;
				}
				return text;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x001D1E73 File Offset: 0x001D0073
		public bool IsExpanded
		{
			get
			{
				return this.o0Ooo_O0oo.O__..IsExpanded;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x001D1E80 File Offset: 0x001D0080
		public bool IsSelected
		{
			get
			{
				return this.o0Ooo_O0oo.O__..IsSelected;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x001D1E8D File Offset: 0x001D008D
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x001D1E9A File Offset: 0x001D009A
		public string IconFile
		{
			get
			{
				return this.o0Ooo_O0oo.O__..ImageFile;
			}
			set
			{
				this.o0Ooo_O0oo.O__..ImageFile = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x001D1EA8 File Offset: 0x001D00A8
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x001D1EB5 File Offset: 0x001D00B5
		public string SelectedIconFile
		{
			get
			{
				return this.o0Ooo_O0oo.O__..o0Ooo_O0oo.O__.();
			}
			set
			{
				this.o0Ooo_O0oo.O__..O.OOO_.(value);
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x001D1EC3 File Offset: 0x001D00C3
		public int Level
		{
			get
			{
				return this.o0Ooo_O0oo.O__..Level;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x001D1ED0 File Offset: 0x001D00D0
		public TreeNode BaseNode
		{
			get
			{
				return this.oO_0o_.0__O.;
			}
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001D1ED8 File Offset: 0x001D00D8
		public void Expand()
		{
			this.o0Ooo_O0oo.O__..Expand();
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x001D1EE5 File Offset: 0x001D00E5
		public void ExpandAll()
		{
			this.o0Ooo_O0oo.O__..ExpandAll();
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x001D1EF2 File Offset: 0x001D00F2
		public void Collapse()
		{
			this.o0Ooo_O0oo.O__..Collapse(true);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x001D1F00 File Offset: 0x001D0100
		public void CollapseAll()
		{
			this.o0Ooo_O0oo.O__..Collapse(false);
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x001D1F0E File Offset: 0x001D010E
		public void Toggle()
		{
			this.o0Ooo_O0oo.O__..Toggle();
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x001D1F1B File Offset: 0x001D011B
		public void Remove()
		{
			this.o0Ooo_O0oo.O__..Remove();
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x001D1F28 File Offset: 0x001D0128
		public void EnsureVisible()
		{
			this.o0Ooo_O0oo.O__..EnsureVisible();
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x001D1F35 File Offset: 0x001D0135
		public int Index
		{
			get
			{
				return this.oO_0o_.0__O..Index;
			}
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x001D1F44 File Offset: 0x001D0144
		public void MoveUp()
		{
			if (this.o0Ooo_O0oo.O__..Index != 0)
			{
				int index = this.o0Ooo_O0oo.O__..Index;
				TreeNodeCollection nodes;
				if (this.o0Ooo_O0oo.O__..Parent == null)
				{
					nodes = this.o0Ooo_O0oo.O__..TreeView.Nodes;
				}
				else
				{
					nodes = this.o0Ooo_O0oo.O__..Parent.Nodes;
				}
				nodes.Remove(this.o0Ooo_O0oo.O__.);
				nodes.Insert(index - 1, this.o0Ooo_O0oo.O__.);
				this.o0Ooo_O0oo.O__..TreeView.SelectedNode = this.o0Ooo_O0oo.O__.;
			}
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x001D1FCC File Offset: 0x001D01CC
		public void MoveDown()
		{
			int index = this.o0Ooo_O0oo.O__..Index;
			TreeNodeCollection nodes;
			if (this.o0Ooo_O0oo.O__..Parent == null)
			{
				nodes = this.o0Ooo_O0oo.O__..TreeView.Nodes;
			}
			else
			{
				nodes = this.o0Ooo_O0oo.O__..Parent.Nodes;
			}
			if (index != nodes.Count - 1)
			{
				nodes.Remove(this.o0Ooo_O0oo.O__.);
				nodes.Insert(index + 1, this.o0Ooo_O0oo.O__.);
				this.o0Ooo_O0oo.O__..TreeView.SelectedNode = this.o0Ooo_O0oo.O__.;
			}
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x001D2054 File Offset: 0x001D0254
		public void MoveLeft()
		{
			TreeNode o0Ooo_O0oo.O__. = this.o0Ooo_O0oo.O__.;
			if (o0Ooo_O0oo.O__..Level != 0)
			{
				int index = o0Ooo_O0oo.O__..Parent.Index + 1;
				TreeNodeCollection nodes;
				if (o0Ooo_O0oo.O__..Parent.Level == 0)
				{
					nodes = o0Ooo_O0oo.O__..TreeView.Nodes;
				}
				else
				{
					nodes = o0Ooo_O0oo.O__..Parent.Parent.Nodes;
				}
				o0Ooo_O0oo.O__..Parent.Nodes.Remove(o0Ooo_O0oo.O__.);
				nodes.Insert(index, o0Ooo_O0oo.O__.);
				o0Ooo_O0oo.O__..TreeView.SelectedNode = o0Ooo_O0oo.O__.;
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x001D20D0 File Offset: 0x001D02D0
		public void MoveRight()
		{
			TreeNode o0Ooo_O0oo.O__. = this.o0Ooo_O0oo.O__.;
			if (o0Ooo_O0oo.O__..Index != 0)
			{
				TreeNodeCollection nodes = o0Ooo_O0oo.O__..PrevNode.Nodes;
				if (o0Ooo_O0oo.O__..Parent != null)
				{
					o0Ooo_O0oo.O__..Parent.Nodes.Remove(o0Ooo_O0oo.O__.);
				}
				else
				{
					o0Ooo_O0oo.O__..TreeView.Nodes.Remove(o0Ooo_O0oo.O__.);
				}
				nodes.Add(o0Ooo_O0oo.O__.);
				o0Ooo_O0oo.O__..TreeView.SelectedNode = o0Ooo_O0oo.O__.;
			}
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x001D2138 File Offset: 0x001D0338
		public void Delete()
		{
			TreeNodeCollection nodes;
			if (this.o0Ooo_O0oo.O__..Parent == null)
			{
				nodes = this.o0Ooo_O0oo.O__..TreeView.Nodes;
			}
			else
			{
				nodes = this.o0Ooo_O0oo.O__..Parent.Nodes;
			}
			nodes.Remove(this.o0Ooo_O0oo.O__.);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x001D2184 File Offset: 0x001D0384
		public void SetChildrenChecked(bool Checked, bool TopLevel = false)
		{
			try
			{
				foreach (TreeNode treeNode in this.Nodes)
				{
					if (treeNode.Checked != Checked)
					{
						treeNode.Checked = Checked;
					}
					if (!TopLevel)
					{
						treeNode.SetChildrenChecked(Checked, TopLevel);
					}
				}
			}
			finally
			{
				IEnumerator<TreeNode> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x001D21E8 File Offset: 0x001D03E8
		public List<TreeNode> AllNodes
		{
			get
			{
				List<TreeNode> list = new List<TreeNode>();
				ooO_0O.o_O0.O_.(this.oO_0o_.0__O..Nodes, list);
				return list;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x001D2210 File Offset: 0x001D0410
		public DataRow DataRow
		{
			get
			{
				DataRow result;
				if (this.o0Ooo_O0oo.O__..Tag != null && this.o0Ooo_O0oo.O__..Tag is DataRow)
				{
					result = new DataRow((DataRow)this.o0Ooo_O0oo.O__..Tag);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x040019F5 RID: 6645
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x040019F6 RID: 6646
		private TreeNodes <<EMPTY_NAME>>;

		// Token: 0x040019F7 RID: 6647
		private StaticLocalInitFlag <<EMPTY_NAME>>;
	}
}
