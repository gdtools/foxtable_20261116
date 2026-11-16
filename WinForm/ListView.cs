using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x0200050D RID: 1293
	[ComVisible(true)]
	public class ListView : Control
	{
		// Token: 0x06005466 RID: 21606 RVA: 0x00257D26 File Offset: 0x00255F26
		internal ListView(o_OO_oOOO0o A_0) : base(A_0, ControlTypeEnum.ListView)
		{
			this.O.oo_oO. = A_0;
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x00257D38 File Offset: 0x00255F38
		public ListViewGroupCollections Groups
		{
			get
			{
				return new ListViewGroupCollections(this.O.oo_oO..Groups);
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x00257D4A File Offset: 0x00255F4A
		public ListViewColumnCollections Columns
		{
			get
			{
				return new ListViewColumnCollections(this.O.oo_oO., this.O.oo_oO..Columns);
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x00257D62 File Offset: 0x00255F62
		public ListViewRowCollections Rows
		{
			get
			{
				return new ListViewRowCollections(this.O.oo_oO.);
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x00257D70 File Offset: 0x00255F70
		public List<ListViewRow> SelectedRows
		{
			get
			{
				List<ListViewRow> list = new List<ListViewRow>();
				if (this.O.oo_oO..VirtualMode)
				{
					try
					{
						foreach (object value in this.O.oo_oO..SelectedIndices)
						{
							int key = Conversions.ToInteger(value);
							list.Add(this.O.oo_oO..o0__o.O0.[key]);
						}
						return list;
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
				try
				{
					foreach (object obj in this.O.oo_oO..SelectedItems)
					{
						ListViewItem a_ = (ListViewItem)obj;
						list.Add(new ListViewRow(a_));
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				return list;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x00257E50 File Offset: 0x00256050
		public List<ListViewRow> CheckedRows
		{
			get
			{
				List<ListViewRow> list = new List<ListViewRow>();
				if (this.O.oo_oO..VirtualMode)
				{
					try
					{
						foreach (ListViewRow listViewRow in this.O.oo_oO..o0__o.O0..Values)
						{
							if (listViewRow.Checked)
							{
								list.Add(listViewRow);
							}
						}
						return list;
					}
					finally
					{
						Dictionary<int, ListViewRow>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				try
				{
					foreach (object obj in this.O.oo_oO..CheckedItems)
					{
						ListViewItem a_ = (ListViewItem)obj;
						list.Add(new ListViewRow(a_));
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				return list;
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600546C RID: 21612 RVA: 0x00257F24 File Offset: 0x00256124
		public Dictionary<int, ListViewRow>.ValueCollection VirtualRows
		{
			get
			{
				return this.O.oo_oO..o0__o.O0..Values;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x00257F36 File Offset: 0x00256136
		public ListViewImageManger Images
		{
			get
			{
				return new ListViewImageManger(this.O.oo_oO.);
			}
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00257F44 File Offset: 0x00256144
		public void Reset()
		{
			this.O.oo_oO..BeginUpdate();
			this.O.oo_oO..Columns.Clear();
			this.O.oo_oO..Groups.Clear();
			this.O.oo_oO..Items.Clear();
			this.Images.Clear();
			this.O.oo_oO..EndUpdate();
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x00257FA2 File Offset: 0x002561A2
		// (set) Token: 0x06005470 RID: 21616 RVA: 0x00257FAF File Offset: 0x002561AF
		public View View
		{
			get
			{
				return this.O.oo_oO..View;
			}
			set
			{
				this.O.oo_oO..View = value;
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06005471 RID: 21617 RVA: 0x00257FBD File Offset: 0x002561BD
		// (set) Token: 0x06005472 RID: 21618 RVA: 0x00257FCA File Offset: 0x002561CA
		public bool GridLines
		{
			get
			{
				return this.O.oo_oO..GridLines;
			}
			set
			{
				this.O.oo_oO..GridLines = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x00257FD8 File Offset: 0x002561D8
		// (set) Token: 0x06005474 RID: 21620 RVA: 0x00257FE8 File Offset: 0x002561E8
		public bool ShowGroups
		{
			get
			{
				return this.O.oo_oO..ShowGroups;
			}
			set
			{
				this.O.oo_oO..SuspendLayout();
				this.O.oo_oO..ShowGroups = value;
				if (base.Parent != null)
				{
					this.O.oo_oO..Width = this.O.oo_oO..Width - 1;
					this.O.oo_oO..Width = this.O.oo_oO..Width + 1;
				}
				this.O.oo_oO..ResumeLayout();
			}
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0025804F File Offset: 0x0025624F
		public void StopRedraw()
		{
			this.O.oo_oO..BeginUpdate();
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x0025805C File Offset: 0x0025625C
		public void ResumeRedraw()
		{
			this.O.oo_oO..EndUpdate();
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00258069 File Offset: 0x00256269
		public void AutoResizeColumns(ColumnHeaderAutoResizeStyle mode = ColumnHeaderAutoResizeStyle.ColumnContent)
		{
			this.O.oo_oO..AutoResizeColumns(mode);
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x00258077 File Offset: 0x00256277
		// (set) Token: 0x06005479 RID: 21625 RVA: 0x00258084 File Offset: 0x00256284
		public Size TitleSize
		{
			get
			{
				return this.O.oo_oO..TileSize;
			}
			set
			{
				this.O.oo_oO..TileSize = value;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x00258092 File Offset: 0x00256292
		// (set) Token: 0x0600547B RID: 21627 RVA: 0x0025809F File Offset: 0x0025629F
		public bool MultiSelect
		{
			get
			{
				return this.O.oo_oO..MultiSelect;
			}
			set
			{
				this.O.oo_oO..MultiSelect = value;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x002580AD File Offset: 0x002562AD
		// (set) Token: 0x0600547D RID: 21629 RVA: 0x002580BC File Offset: 0x002562BC
		public bool CheckBoxes
		{
			get
			{
				return this.O.oo_oO..CheckBoxes;
			}
			set
			{
				int num;
				int num4;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					if (!this.O.oo_oO..VirtualMode)
					{
						goto IL_1F8;
					}
					IL_19:
					num2 = 3;
					if (this.O.oo_oO..Parent == null)
					{
						goto IL_35;
					}
					IL_28:
					num2 = 4;
					this.O.oo_oO..BeginUpdate();
					IL_35:
					num2 = 5;
					if (this.O.oo_oO..Columns.Count <= 0)
					{
						goto IL_63;
					}
					IL_4A:
					num2 = 6;
					int width = this.O.oo_oO..Columns[0].Width;
					IL_63:
					num2 = 7;
					this.O.oo_oO..BeginUpdate();
					IL_70:
					num2 = 8;
					if (!value)
					{
						goto IL_FF;
					}
					IL_78:
					num2 = 9;
					if (this.O.oo_oO..CheckBoxes)
					{
						goto IL_138;
					}
					IL_8B:
					num2 = 10;
					Dictionary<int, ListViewRow>.ValueCollection.Enumerator enumerator = this.O.oo_oO..o0__o.O0..Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewRow listViewRow = enumerator.Current;
						IL_B0:
						num2 = 11;
						if (!listViewRow.Checked)
						{
							IL_BC:
							num2 = 12;
							listViewRow.Checked = true;
							IL_C7:
							num2 = 13;
							listViewRow.Checked = false;
						}
						IL_D2:
						num2 = 14;
					}
					IL_DE:
					num2 = 15;
					((IDisposable)enumerator).Dispose();
					IL_EE:
					num2 = 16;
					this.O.oo_oO..CheckBoxes = true;
					goto IL_138;
					IL_FF:
					num2 = 18;
					if (value)
					{
						goto IL_138;
					}
					IL_105:
					num2 = 19;
					if (!this.O.oo_oO..CheckBoxes)
					{
						goto IL_138;
					}
					IL_115:
					num2 = 20;
					this.VirtualMode = false;
					IL_11F:
					num2 = 21;
					this.O.oo_oO..CheckBoxes = false;
					IL_12E:
					num2 = 22;
					this.VirtualMode = true;
					IL_138:
					num2 = 23;
					o_OO_oOOO0o o_OO_oOOO0o = this.O.oo_oO.;
					IL_143:
					num2 = 24;
					if (this.View != View.SmallIcon)
					{
						goto IL_177;
					}
					IL_14F:
					num2 = 25;
					if (o_OO_oOOO0o.Columns.Count <= 0)
					{
						goto IL_177;
					}
					IL_161:
					num2 = 26;
					o_OO_oOOO0o.Columns[0].Width = width;
					IL_177:
					num2 = 27;
					o_OO_oOOO0o.SetBounds(o_OO_oOOO0o.Left, o_OO_oOOO0o.Top, o_OO_oOOO0o.Width - 1, o_OO_oOOO0o.Height);
					IL_19F:
					num2 = 28;
					o_OO_oOOO0o.SetBounds(o_OO_oOOO0o.Left, o_OO_oOOO0o.Top, o_OO_oOOO0o.Width + 1, o_OO_oOOO0o.Height);
					IL_1C7:
					o_OO_oOOO0o = null;
					IL_1CA:
					num2 = 30;
					this.O.oo_oO..EndUpdate();
					IL_1D8:
					num2 = 31;
					if (this.O.oo_oO..Parent == null)
					{
						goto IL_207;
					}
					IL_1E8:
					num2 = 32;
					this.O.oo_oO..EndUpdate();
					goto IL_207;
					IL_1F8:
					num2 = 34;
					this.O.oo_oO..CheckBoxes = value;
					IL_207:
					goto IL_2E5;
					IL_20C:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_2A6:
					goto IL_2DA;
					IL_2A8:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_2B8:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_2A8;
				}
				IL_2DA:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_2E5:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x002583D4 File Offset: 0x002565D4
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x002583E4 File Offset: 0x002565E4
		public bool VirtualMode
		{
			get
			{
				return this.O.oo_oO..VirtualMode;
			}
			set
			{
				this.O.oo_oO..VirtualMode = value;
				if (value)
				{
					if (this.O.oo_oO..o0__o.O0. == null)
					{
						this.O.oo_oO..o0__o.O0. = new Dictionary<int, ListViewRow>();
						return;
					}
				}
				else if (this.O.oo_oO..o0__o.O0. != null)
				{
					this.O.oo_oO..o0__o.O0..Clear();
				}
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x0025843B File Offset: 0x0025663B
		// (set) Token: 0x06005481 RID: 21633 RVA: 0x00258448 File Offset: 0x00256648
		public int VirtualListSize
		{
			get
			{
				return this.O.oo_oO..VirtualListSize;
			}
			set
			{
				this.O.oo_oO..VirtualListSize = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x00258458 File Offset: 0x00256658
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x0025852F File Offset: 0x0025672F
		public ListViewRow Current
		{
			get
			{
				ListViewRow result;
				if (this.O.oo_oO..FocusedItem != null && this.O.oo_oO..FocusedItem.Selected)
				{
					result = new ListViewRow(this.O.oo_oO..FocusedItem);
				}
				else
				{
					if (this.VirtualMode)
					{
						if (this.O.oo_oO..SelectedIndices.Count > 0)
						{
							return new ListViewRow(this.O.oo_oO..SelectedItems[this.O.oo_oO..SelectedIndices[this.O.oo_oO..SelectedIndices.Count - 1]]);
						}
					}
					else if (this.O.oo_oO..SelectedItems.Count > 0)
					{
						return new ListViewRow(this.O.oo_oO..SelectedItems[this.O.oo_oO..SelectedItems.Count - 1]);
					}
					result = null;
				}
				return result;
			}
			set
			{
				this.O.oo_oO..FocusedItem = value.BaseItem;
				this.O.oo_oO..FocusedItem.EnsureVisible();
				this.O.oo_oO..FocusedItem.Selected = true;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x00258564 File Offset: 0x00256764
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x0025858B File Offset: 0x0025678B
		public int Position
		{
			get
			{
				int index;
				if (this.Current != null)
				{
					index = this.Current.BaseItem.Index;
				}
				return index;
			}
			set
			{
				if (value >= 0 && value <= this.O.oo_oO..Items.Count - 1)
				{
					this.Current = new ListViewRow(this.O.oo_oO..Items[value]);
				}
			}
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x002585C2 File Offset: 0x002567C2
		public void RetrieveAll()
		{
			if (this.VirtualMode)
			{
				this.O.oo_oO..o0__o.O0..Clear();
				this.O.oo_oO..Invalidate();
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x002585E7 File Offset: 0x002567E7
		// (set) Token: 0x06005488 RID: 21640 RVA: 0x002585F4 File Offset: 0x002567F4
		public bool AllowDrag
		{
			get
			{
				return this.O.oo_oO..O_O.0Oo_o.();
			}
			set
			{
				this.O.oo_oO..o0__o.O0.(value);
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x00258602 File Offset: 0x00256802
		// (set) Token: 0x0600548A RID: 21642 RVA: 0x0025860F File Offset: 0x0025680F
		public bool AllowDrop
		{
			get
			{
				return this.O.oo_oO..get_AllowDrop();
			}
			set
			{
				this.O.oo_oO..set_AllowDrop(value);
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0025861D File Offset: 0x0025681D
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x0025862A File Offset: 0x0025682A
		public bool AllowEdit
		{
			get
			{
				return this.O.oo_oO..LabelEdit;
			}
			set
			{
				this.O.oo_oO..LabelEdit = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x00258638 File Offset: 0x00256838
		// (set) Token: 0x0600548E RID: 21646 RVA: 0x00258645 File Offset: 0x00256845
		public bool OwnerDraw
		{
			get
			{
				return this.O.oo_oO..OwnerDraw;
			}
			set
			{
				this.O.oo_oO..OwnerDraw = value;
			}
		}

		// Token: 0x040022B5 RID: 8885
		private o_OO_oOOO0o <<EMPTY_NAME>>;
	}
}
