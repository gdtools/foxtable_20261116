using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001AD RID: 429
	internal class o_OO_oOOO0o : System.Windows.Forms.ListView
	{
		// Token: 0x060014F6 RID: 5366 RVA: 0x000975A4 File Offset: 0x000957A4
		internal o_OO_oOOO0o()
		{
			base.DragDrop += this.Oo__o0OOOO_.__.;
			base.DragEnter += this.o.0o0___.;
			base.DragLeave += this.O_O.0Oo_o.;
			base.DragOver += this.O_O.0Oo_o.;
			base.DrawItem += this.O_O.0Oo_o.;
			base.ItemDrag += this.O_O.0Oo_o.;
			base.KeyDown += this.O_O.0Oo_o.;
			base.MouseClick += this.O_O.0Oo_o.;
			this.DoubleBuffered = true;
			base.LargeImageList = new ImageList();
			base.SmallImageList = new ImageList();
			base.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
			base.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
			base.FullRowSelect = true;
			base.UseCompatibleStateImageBehavior = false;
			base.ShowItemToolTips = true;
			base.LargeImageList.ImageSize = new Size(48, 48);
			base.SmallImageList.ImageSize = new Size(16, 16);
			base.View = View.LargeIcon;
			base.HideSelection = false;
			base.InsertionMark.Color = Color.Green;
			this.set_AllowDrop(false);
			base.OwnerDraw = false;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000976E8 File Offset: 0x000958E8
		private void <<EMPTY_NAME>>(object A_0, DragEventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.get_AllowDrop())
				{
					goto IL_33E;
				}
				IL_14:
				num2 = 4;
				int num3 = base.InsertionMark.Index;
				IL_22:
				num2 = 5;
				ListViewItem listViewItem = (ListViewItem)A_1.Data.GetData(typeof(ListViewItem));
				IL_40:
				num2 = 6;
				if (listViewItem == null)
				{
					goto IL_33E;
				}
				IL_49:
				num2 = 8;
				if (listViewItem.ListView != this)
				{
					goto IL_97;
				}
				IL_55:
				num2 = 9;
				if (base.Items[base.Items.Count - 1] != listViewItem)
				{
					goto IL_8D;
				}
				IL_74:
				num2 = 10;
				if (num3 >= listViewItem.Index)
				{
					goto IL_33E;
				}
				if (num3 < 0)
				{
					goto IL_33E;
				}
				goto IL_97;
				IL_8D:
				num2 = 13;
				if (num3 < 0)
				{
					goto IL_33E;
				}
				IL_97:
				num2 = 15;
				if (num3 != -1 || base.Items.Count <= 0)
				{
					goto IL_FF;
				}
				IL_AC:
				num2 = 16;
				Point p = System.Windows.Forms.Control.MousePosition;
				IL_B6:
				num2 = 17;
				p = base.PointToClient(p);
				IL_C3:
				num2 = 18;
				ListViewItem itemAt = base.GetItemAt(p.X, p.Y);
				IL_DC:
				num2 = 19;
				if (itemAt == null)
				{
					goto IL_F0;
				}
				IL_E3:
				num2 = 20;
				num3 = itemAt.Index;
				goto IL_FF;
				IL_F0:
				num2 = 22;
				num3 = base.Items.Count;
				IL_FF:
				num2 = 23;
				if (num3 != -1 || base.Items.Count != 0)
				{
					goto IL_125;
				}
				IL_113:
				num2 = 24;
				if (listViewItem.ListView == this)
				{
					goto IL_125;
				}
				IL_120:
				num2 = 25;
				num3 = 0;
				IL_125:
				num2 = 26;
				if (num3 == -1)
				{
					goto IL_33E;
				}
				IL_12F:
				num2 = 28;
				if (!base.InsertionMark.AppearsAfterItem || base.Items.Count <= 0)
				{
					goto IL_154;
				}
				IL_14D:
				num2 = 29;
				num3++;
				IL_154:
				num2 = 30;
				if (listViewItem.Index >= num3)
				{
					goto IL_168;
				}
				IL_161:
				num2 = 31;
				num3--;
				IL_168:
				num2 = 32;
				bool flag = listViewItem.ListView == this;
				IL_177:
				num2 = 33;
				Foxtable.WinForm.Form form = this.o0__o.O0.();
				IL_182:
				num2 = 34;
				Foxtable.WinForm.ListView listView = new Foxtable.WinForm.ListView(this);
				IL_18D:
				num2 = 35;
				Foxtable.WinForm.ListView a_ = new Foxtable.WinForm.ListView((o_OO_oOOO0o)listViewItem.ListView);
				IL_1A3:
				num2 = 36;
				DropListViewRowEventArgs dropListViewRowEventArgs = new DropListViewRowEventArgs(this, form, listViewItem.Index, num3, a_);
				IL_1BA:
				num2 = 37;
				string a_2 = "BeforeDropRow_" + Conversions.ToString(base.Tag);
				IL_1D4:
				num2 = 38;
				O_O0OO.OoO_o.oO0o0O.(this.o0__o.O0.().O_0.O00o_00_O., a_2, new object[]
				{
					dropListViewRowEventArgs
				}, false, "窗口," + form.Name + "," + listView.Name, false);
				IL_214:
				num2 = 39;
				if (!dropListViewRowEventArgs.Cancel)
				{
					goto IL_234;
				}
				IL_220:
				num2 = 40;
				base.InsertionMark.Index = -1;
				goto IL_33E;
				IL_234:
				num2 = 42;
				ShareLibriay.LockWindowUpdate(base.Handle);
				IL_243:
				num2 = 43;
				if (!flag)
				{
					goto IL_26B;
				}
				IL_24A:
				num2 = 44;
				listViewItem.Remove();
				IL_254:
				num2 = 45;
				base.Items.Insert(num3, listViewItem);
				goto IL_2F7;
				IL_26B:
				num2 = 47;
				if (!dropListViewRowEventArgs.Delete)
				{
					goto IL_281;
				}
				IL_277:
				num2 = 48;
				listViewItem.Remove();
				IL_281:
				num2 = 49;
				if (!dropListViewRowEventArgs.Add)
				{
					goto IL_2F7;
				}
				IL_28D:
				num2 = 50;
				if (!dropListViewRowEventArgs.Delete)
				{
					goto IL_2A2;
				}
				IL_299:
				num2 = 51;
				ListViewItem listViewItem2 = listViewItem;
				goto IL_2DA;
				IL_2A2:
				num2 = 53;
				listViewItem2 = (ListViewItem)listViewItem.Clone();
				IL_2B3:
				num2 = 54;
				listViewItem2.Name = listViewItem.Name;
				IL_2C4:
				num2 = 55;
				listViewItem2.Tag = RuntimeHelpers.GetObjectValue(listViewItem.Tag);
				IL_2DA:
				num2 = 56;
				base.Items.Insert(num3, listViewItem2);
				IL_2EC:
				num2 = 57;
				listViewItem2.Selected = false;
				IL_2F7:
				num2 = 58;
				base.InsertionMark.Index = -1;
				IL_306:
				num2 = 59;
				base.Items[num3].Selected = true;
				IL_31B:
				num2 = 60;
				base.Items[num3].Focused = true;
				IL_330:
				num2 = 61;
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				IL_33E:
				goto IL_488;
				IL_343:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_449:
				goto IL_47D;
				IL_44B:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_45B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_44B;
			}
			IL_47D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_488:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00097BA4 File Offset: 0x00095DA4
		private void <<EMPTY_NAME>>(object A_0, DragEventArgs A_1)
		{
			if (this.get_AllowDrop())
			{
				if ((ListViewItem)A_1.Data.GetData(typeof(ListViewItem)) == null)
				{
					A_1.Effect = DragDropEffects.None;
					return;
				}
				A_1.Effect = A_1.AllowedEffect;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00097BDE File Offset: 0x00095DDE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.get_AllowDrop())
			{
				base.InsertionMark.Index = -1;
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00097BF4 File Offset: 0x00095DF4
		private void <<EMPTY_NAME>>(object A_0, DragEventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.get_AllowDrop())
				{
					goto IL_D2;
				}
				IL_14:
				num2 = 4;
				ListViewItem listViewItem = (ListViewItem)A_1.Data.GetData(typeof(ListViewItem));
				IL_31:
				num2 = 5;
				if (listViewItem == null)
				{
					goto IL_D2;
				}
				IL_39:
				num2 = 7;
				Point pt = base.PointToClient(new Point(A_1.X, A_1.Y));
				IL_54:
				num2 = 8;
				int num3 = base.InsertionMark.NearestIndex(pt);
				IL_65:
				num2 = 9;
				if (num3 <= -1)
				{
					goto IL_C2;
				}
				IL_6D:
				num2 = 10;
				Rectangle itemRect = base.GetItemRect(num3);
				IL_7A:
				num2 = 11;
				if ((double)pt.X <= (double)itemRect.Left + (double)itemRect.Width / 2.0)
				{
					goto IL_B3;
				}
				IL_A2:
				num2 = 12;
				base.InsertionMark.AppearsAfterItem = true;
				goto IL_C2;
				IL_B3:
				num2 = 14;
				base.InsertionMark.AppearsAfterItem = false;
				IL_C2:
				num2 = 15;
				base.InsertionMark.Index = num3;
				IL_D2:
				goto IL_164;
				IL_D7:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_125:
				goto IL_159;
				IL_127:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_137:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_127;
			}
			IL_159:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_164:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00097D8C File Offset: 0x00095F8C
		private void <<EMPTY_NAME>>(object A_0, DrawListViewItemEventArgs A_1)
		{
			if (A_1.Item.Focused)
			{
				A_1.DrawFocusRectangle();
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00097DA4 File Offset: 0x00095FA4
		private void <<EMPTY_NAME>>(object A_0, ItemDragEventArgs A_1)
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
				if (!this.O_O.0Oo_o.())
				{
					goto IL_C9;
				}
				IL_14:
				num2 = 4;
				Foxtable.WinForm.Form form = this.o0__o.O0.();
				IL_1D:
				num2 = 5;
				Foxtable.WinForm.ListView listView = new Foxtable.WinForm.ListView(this);
				IL_27:
				num2 = 6;
				ListViewItem listViewItem = (ListViewItem)A_1.Item;
				IL_36:
				num2 = 7;
				ListViewRowEventArgs listViewRowEventArgs = new ListViewRowEventArgs(this, form, new ListViewRow(listViewItem), listViewItem.Index);
				IL_4F:
				num2 = 8;
				string a_ = "BeforeDragRow_" + Conversions.ToString(base.Tag);
				IL_68:
				num2 = 9;
				O_O0OO.OoO_o.oO0o0O.(this.o0__o.O0.().O_0.O00o_00_O., a_, new object[]
				{
					listViewRowEventArgs
				}, false, "窗口," + form.Name + "," + listView.Name, false);
				IL_A7:
				num2 = 10;
				if (listViewRowEventArgs.Cancel)
				{
					goto IL_C9;
				}
				IL_B3:
				num2 = 11;
				base.DoDragDrop(RuntimeHelpers.GetObjectValue(A_1.Item), DragDropEffects.Move);
				IL_C9:
				goto IL_148;
				IL_CB:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_109:
				goto IL_13D;
				IL_10B:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_11B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10B;
			}
			IL_13D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_148:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00097F20 File Offset: 0x00096120
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (base.VirtualMode && base.CheckBoxes && base.SelectedIndices.Count > 0)
			{
				ListViewItem listViewItem = base.Items[base.SelectedIndices[0]];
				listViewItem.Checked = !listViewItem.Checked;
				base.Invalidate(listViewItem.SubItems[0].Bounds);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00097F8C File Offset: 0x0009618C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
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
				if (!base.VirtualMode || !base.CheckBoxes)
				{
					goto IL_7F;
				}
				IL_19:
				num2 = 3;
				ListViewItem itemAt = base.GetItemAt(A_1.X, A_1.Y);
				IL_2E:
				num2 = 4;
				if (itemAt == null)
				{
					goto IL_7F;
				}
				IL_33:
				num2 = 5;
				if (A_1.X >= itemAt.Bounds.Left + 16)
				{
					goto IL_7F;
				}
				IL_4F:
				num2 = 6;
				bool @checked = itemAt.Checked;
				IL_59:
				num2 = 7;
				itemAt.Checked = !@checked;
				IL_66:
				num2 = 8;
				base.Invalidate(itemAt.SubItems[0].Bounds);
				IL_7F:
				goto IL_F2;
				IL_81:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_B3:
				goto IL_E7;
				IL_B5:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_C5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B5;
			}
			IL_E7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000980A4 File Offset: 0x000962A4
		internal string <<EMPTY_NAME>>()
		{
			return this.o0__o.O0.;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000980AC File Offset: 0x000962AC
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o0__o.O0. = A_0;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000980B5 File Offset: 0x000962B5
		internal bool <<EMPTY_NAME>>()
		{
			return this.o0__o.O0.;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000980BD File Offset: 0x000962BD
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			this.o0__o.O0. = A_0;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000980C6 File Offset: 0x000962C6
		public override bool get_AllowDrop()
		{
			return base.AllowDrop;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000980CE File Offset: 0x000962CE
		public override void set_AllowDrop(bool value)
		{
			base.AllowDrop = value;
			if (value)
			{
				base.ListViewItemSorter = new o_OO_oOOO0o.oOoo0_0oO0O();
				return;
			}
			base.ListViewItemSorter = null;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000980F0 File Offset: 0x000962F0
		private Foxtable.WinForm.Form <<EMPTY_NAME>>()
		{
			System.Windows.Forms.Control parent = base.Parent;
			while (!(parent is FormPanel))
			{
				parent = parent.Parent;
				if (parent == null)
				{
					return null;
				}
			}
			return OO_00oOO.Forms[parent.Name];
		}

		// Token: 0x0400084D RID: 2125
		internal Dictionary<int, ListViewRow> <<EMPTY_NAME>>;

		// Token: 0x0400084E RID: 2126
		private string <<EMPTY_NAME>>;

		// Token: 0x0400084F RID: 2127
		private bool <<EMPTY_NAME>>;

		// Token: 0x020001AE RID: 430
		private class oOoo0_0oO0O : IComparer
		{
			// Token: 0x06001507 RID: 5383 RVA: 0x00098134 File Offset: 0x00096334
			public int <<EMPTY_NAME>>(object A_0, object A_1)
			{
				return ((ListViewItem)A_0).Index - ((ListViewItem)A_1).Index;
			}
		}
	}
}
