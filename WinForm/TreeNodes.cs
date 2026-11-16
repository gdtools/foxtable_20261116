using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	// Token: 0x0200053C RID: 1340
	[ComVisible(true)]
	public class TreeNodes : IEnumerable<TreeNode>
	{
		// Token: 0x060059DA RID: 23002 RVA: 0x00260D60 File Offset: 0x0025EF60
		public TreeNodes(TreeNodeCollection A_0)
		{
			this.oO_0o_.0__O. = A_0;
		}

		// Token: 0x1700152E RID: 5422
		public TreeNode this[int Index]
		{
			get
			{
				return new TreeNode((O_o__00Ooo)this.oO_0o_.0__O.[Index]);
			}
		}

		// Token: 0x1700152F RID: 5423
		public TreeNode this[string Name]
		{
			get
			{
				TreeNode treeNode = this.oO_0o_.0__O.[Name];
				TreeNode result;
				if (treeNode == null)
				{
					result = null;
				}
				else
				{
					result = new TreeNode((O_o__00Ooo)treeNode);
				}
				return result;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x00260DB6 File Offset: 0x0025EFB6
		public int Count
		{
			get
			{
				return this.oO_0o_.0__O..Count;
			}
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00260DC3 File Offset: 0x0025EFC3
		public void Clear()
		{
			this.oO_0o_.0__O..Clear();
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00260DD0 File Offset: 0x0025EFD0
		public TreeNode Add(string Name)
		{
			return this.Add(Name, Name);
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x00260DDC File Offset: 0x0025EFDC
		public TreeNode Add(string Name, string Text)
		{
			O_o__00Ooo o_o__00Ooo = new O_o__00Ooo();
			o_o__00Ooo.Name = Name;
			o_o__00Ooo.Text = Text;
			this.oO_0o_.0__O..Add(o_o__00Ooo);
			return new TreeNode(o_o__00Ooo);
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x00260E10 File Offset: 0x0025F010
		public TreeNode Add(string Name, string Text, string ImageFile)
		{
			O_o__00Ooo o_o__00Ooo = new O_o__00Ooo();
			this.oO_0o_.0__O..Add(o_o__00Ooo);
			o_o__00Ooo.Name = Name;
			o_o__00Ooo.Text = Text;
			o_o__00Ooo.ImageFile = ImageFile;
			return new TreeNode(o_o__00Ooo);
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x00260E4B File Offset: 0x0025F04B
		public TreeNode Insert(string Name, int Index)
		{
			return this.Insert(Name, Name, Index);
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x00260E58 File Offset: 0x0025F058
		public TreeNode Insert(string Name, string Text, int Index)
		{
			O_o__00Ooo o_o__00Ooo = new O_o__00Ooo();
			o_o__00Ooo.Name = Name;
			o_o__00Ooo.Text = Text;
			this.oO_0o_.0__O..Insert(Index, o_o__00Ooo);
			return new TreeNode(o_o__00Ooo);
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x00260E8C File Offset: 0x0025F08C
		public TreeNode Insert(string Name, string Text, string ImageFile, int Index)
		{
			O_o__00Ooo o_o__00Ooo = new O_o__00Ooo();
			this.oO_0o_.0__O..Insert(Index, o_o__00Ooo);
			o_o__00Ooo.Name = Name;
			o_o__00Ooo.Text = Text;
			o_o__00Ooo.ImageFile = ImageFile;
			return new TreeNode(o_o__00Ooo);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00260EC8 File Offset: 0x0025F0C8
		public bool Contains(string Name)
		{
			return this.oO_0o_.0__O..ContainsKey(Name);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00260ED6 File Offset: 0x0025F0D6
		public void Remove(TreeNode Node)
		{
			this.oO_0o_.0__O..Remove(Node.BaseNode);
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00260EE9 File Offset: 0x0025F0E9
		public void RemoveAt(int Index)
		{
			this.oO_0o_.0__O..RemoveAt(Index);
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x00260EF7 File Offset: 0x0025F0F7
		public IEnumerator<TreeNode> GetEnumerator()
		{
			return new O_oO__o0(this.oO_0o_.0__O.);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00260F04 File Offset: 0x0025F104
		public IEnumerator GetEnumerator1()
		{
			return new O_oO__o0(this.oO_0o_.0__O.);
		}

		// Token: 0x04002333 RID: 9011
		private TreeNodeCollection <<EMPTY_NAME>>;
	}
}
