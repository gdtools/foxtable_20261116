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
	// Token: 0x020001B2 RID: 434
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ListViewGroupCollections : IEnumerable<Foxtable.WinForm.ListViewGroup>
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x0009854A File Offset: 0x0009674A
		public ListViewGroupCollections(ListViewGroupCollection A_0)
		{
			this.oo.oO_. = A_0;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x00098559 File Offset: 0x00096759
		public int Count
		{
			get
			{
				return this.oo.oO_..Count;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00098568 File Offset: 0x00096768
		public bool Contains
		{
			get
			{
				try
				{
					IEnumerator enumerator = this.oo.oO_..GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(((System.Windows.Forms.ListViewGroup)enumerator.Current).Name, key, true) == 0)
						{
							return true;
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
				return false;
			}
		}

		// Token: 0x17000412 RID: 1042
		public Foxtable.WinForm.ListViewGroup this[int Index]
		{
			get
			{
				return new Foxtable.WinForm.ListViewGroup(this.oo.oO_.[Index]);
			}
		}

		// Token: 0x17000413 RID: 1043
		public Foxtable.WinForm.ListViewGroup this[string Key]
		{
			get
			{
				return new Foxtable.WinForm.ListViewGroup(this.oo.oO_.[Key]);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000985FA File Offset: 0x000967FA
		public void Clear()
		{
			this.oo.oO_..Clear();
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00098608 File Offset: 0x00096808
		public Foxtable.WinForm.ListViewGroup Add()
		{
			System.Windows.Forms.ListViewGroup listViewGroup = new System.Windows.Forms.ListViewGroup();
			this.oo.oO_..Add(listViewGroup);
			return new Foxtable.WinForm.ListViewGroup(listViewGroup);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00098630 File Offset: 0x00096830
		public Foxtable.WinForm.ListViewGroup Add(string Name)
		{
			System.Windows.Forms.ListViewGroup listViewGroup = new System.Windows.Forms.ListViewGroup();
			this.oo.oO_..Add(listViewGroup);
			listViewGroup.Name = Name;
			listViewGroup.Header = Name;
			return new Foxtable.WinForm.ListViewGroup(listViewGroup);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00098664 File Offset: 0x00096864
		public void Delete(int Index)
		{
			this.oo.oO_..RemoveAt(Index);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00098672 File Offset: 0x00096872
		public void Delete(string Key)
		{
			if (this.get_Contains(Key))
			{
				this.oo.oO_..Remove(this.oo.oO_.[Key]);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00098694 File Offset: 0x00096894
		public void Delete(Foxtable.WinForm.ListViewGroup item)
		{
			this.oo.oO_..Remove(item.BaseGroup);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000986A7 File Offset: 0x000968A7
		public IEnumerator<Foxtable.WinForm.ListViewGroup> GetEnumerator()
		{
			return new OO0_o_oOo0(this.oo.oO_.);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000986B4 File Offset: 0x000968B4
		public IEnumerator GetEnumerator1()
		{
			return new OO0_o_oOo0(this.oo.oO_.);
		}

		// Token: 0x04000856 RID: 2134
		private ListViewGroupCollection <<EMPTY_NAME>>;
	}
}
