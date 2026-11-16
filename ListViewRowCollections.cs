using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001B6 RID: 438
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ListViewRowCollections : IEnumerable<ListViewRow>
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x000989ED File Offset: 0x00096BED
		public ListViewRowCollections(System.Windows.Forms.ListView.ListViewItemCollection A_0)
		{
			this.O._OOOO0_. = A_0;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000989FC File Offset: 0x00096BFC
		public ListViewRowCollections(System.Windows.Forms.ListView A_0)
		{
			this.O._OOOO0_. = A_0.Items;
			this.O._OOOO0_. = A_0;
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00098A17 File Offset: 0x00096C17
		public int Count
		{
			get
			{
				return this.O._OOOO0_..Count;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x00098A24 File Offset: 0x00096C24
		public bool Contains
		{
			get
			{
				return this.O._OOOO0_..ContainsKey(key);
			}
		}

		// Token: 0x1700041F RID: 1055
		public ListViewRow this[int Index]
		{
			get
			{
				return new ListViewRow(this.O._OOOO0_.[Index]);
			}
		}

		// Token: 0x17000420 RID: 1056
		public ListViewRow this[string Key]
		{
			get
			{
				return new ListViewRow(this.O._OOOO0_.[Key]);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00098A58 File Offset: 0x00096C58
		public ListViewRow Add()
		{
			ListViewRow result;
			if (this.O._OOOO0_. == null)
			{
				result = null;
			}
			else if (this.O._OOOO0_..VirtualMode)
			{
				this.O._OOOO0_..VirtualListSize = this.O._OOOO0_..VirtualListSize + 1;
				result = new ListViewRow(this.O._OOOO0_..Items[this.O._OOOO0_..Items.Count - 1]);
			}
			else
			{
				ListViewItem listViewItem = new ListViewItem();
				this.O._OOOO0_..Add(listViewItem);
				if (this.O._OOOO0_..Columns.Count > 0)
				{
					listViewItem.SubItems[0].Name = this.O._OOOO0_..Columns[0].Name;
					int num = this.O._OOOO0_..Columns.Count - 1;
					for (int i = 1; i <= num; i++)
					{
						listViewItem.SubItems.Add("").Name = this.O._OOOO0_..Columns[i].Name;
					}
				}
				result = new ListViewRow(listViewItem);
			}
			return result;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00098B65 File Offset: 0x00096D65
		public void Clear()
		{
			this.O._OOOO0_..Clear();
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00098B72 File Offset: 0x00096D72
		public void Delete(int Index)
		{
			new ListViewRow(this.O._OOOO0_.[Index]).Delete();
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00098B8A File Offset: 0x00096D8A
		public void Delete(string Key)
		{
			new ListViewRow(this.O._OOOO0_.[Key]).Delete();
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00098BA2 File Offset: 0x00096DA2
		public void Delete(ListViewRow item)
		{
			item.Delete();
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00098BAA File Offset: 0x00096DAA
		public IEnumerator<ListViewRow> GetEnumerator()
		{
			return new O0_0oO__oo(this.O._OOOO0_.);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00098BB7 File Offset: 0x00096DB7
		public IEnumerator GetEnumerator1()
		{
			return new O0_0oO__oo(this.O._OOOO0_.);
		}

		// Token: 0x0400085E RID: 2142
		private System.Windows.Forms.ListView.ListViewItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400085F RID: 2143
		private System.Windows.Forms.ListView <<EMPTY_NAME>>;
	}
}
