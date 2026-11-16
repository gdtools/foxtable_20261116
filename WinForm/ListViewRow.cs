using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x020001B7 RID: 439
	[ComVisible(true)]
	public class ListViewRow
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x00098BC4 File Offset: 0x00096DC4
		public ListViewRow(ListViewItem A_0)
		{
			this.O.oo_oO. = A_0;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00098BD3 File Offset: 0x00096DD3
		internal ListViewItem BaseItem
		{
			get
			{
				return this.O.oo_oO.;
			}
		}

		// Token: 0x17000422 RID: 1058
		public string this[string Key]
		{
			get
			{
				o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)this.O.oo_oO..ListView;
				string text;
				if (Operators.CompareString(Key, o_OO_oOOO0o.O_O.0Oo_o.(), true) == 0)
				{
					text = this.O.oo_oO..SubItems[0].Text;
				}
				else
				{
					text = this.O.oo_oO..SubItems[Key].Text;
				}
				return text;
			}
			set
			{
				string right;
				if (this.O.oo_oO..ListView == null)
				{
					right = ((ooO0__O0_O)this.O.oo_oO.).o0.oooO.();
				}
				else
				{
					right = ((o_OO_oOOO0o)this.O.oo_oO..ListView).O_O.0Oo_o.();
				}
				if (Operators.CompareString(Key, right, true) == 0)
				{
					this.O.oo_oO..SubItems[0].Text = value;
					return;
				}
				this.O.oo_oO..SubItems[Key].Text = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00098CB8 File Offset: 0x00096EB8
		public ListViewCell Cells
		{
			get
			{
				return new ListViewCell(this.O.oo_oO..SubItems[Key]);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00098CD0 File Offset: 0x00096ED0
		public ListViewCell Cells
		{
			get
			{
				return new ListViewCell(this.O.oo_oO..SubItems[index]);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00098CE8 File Offset: 0x00096EE8
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00098CF5 File Offset: 0x00096EF5
		public bool CellUseRowStyle
		{
			get
			{
				return this.O.oo_oO..UseItemStyleForSubItems;
			}
			set
			{
				this.O.oo_oO..UseItemStyleForSubItems = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00098D03 File Offset: 0x00096F03
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x00098D10 File Offset: 0x00096F10
		public string Text
		{
			get
			{
				return this.O.oo_oO..Text;
			}
			set
			{
				this.O.oo_oO..Text = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00098D1E File Offset: 0x00096F1E
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00098D2B File Offset: 0x00096F2B
		public string Name
		{
			get
			{
				return this.O.oo_oO..Name;
			}
			set
			{
				this.O.oo_oO..Name = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00098D39 File Offset: 0x00096F39
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00098D46 File Offset: 0x00096F46
		public object Tag
		{
			get
			{
				return this.O.oo_oO..Tag;
			}
			set
			{
				this.O.oo_oO..Tag = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00098D59 File Offset: 0x00096F59
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00098D66 File Offset: 0x00096F66
		public string ToolTipText
		{
			get
			{
				return this.O.oo_oO..ToolTipText;
			}
			set
			{
				this.O.oo_oO..ToolTipText = value;
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00098D74 File Offset: 0x00096F74
		public void Delete()
		{
			if (this.O.oo_oO..ListView.VirtualMode)
			{
				int index = this.O.oo_oO..Index;
				o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)this.O.oo_oO..ListView;
				int[] array = new int[o_OO_oOOO0o.o0__o.O0..Count - 1 + 1];
				o_OO_oOOO0o.o0__o.O0..Keys.CopyTo(array, 0);
				Array.Sort<int>(array);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = array[i];
					if (num2 == index)
					{
						o_OO_oOOO0o.o0__o.O0..Remove(num2);
					}
					else if (num2 > index)
					{
						ListViewRow value = o_OO_oOOO0o.o0__o.O0.[num2];
						o_OO_oOOO0o.o0__o.O0..Remove(num2);
						o_OO_oOOO0o.o0__o.O0..Add(num2 - 1, value);
					}
				}
				o_OO_oOOO0o.VirtualListSize--;
				return;
			}
			this.O.oo_oO..Remove();
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00098E60 File Offset: 0x00097060
		public void Retrieve()
		{
			if (this.O.oo_oO..ListView.VirtualMode)
			{
				int index = this.O.oo_oO..Index;
				o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)this.O.oo_oO..ListView;
				if (o_OO_oOOO0o.o0__o.O0..ContainsKey(index))
				{
					o_OO_oOOO0o.o0__o.O0..Remove(index);
				}
			}
			this.O.oo_oO..ListView.Invalidate(this.O.oo_oO..Bounds);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00098ED2 File Offset: 0x000970D2
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x00098EDF File Offset: 0x000970DF
		public bool Selected
		{
			get
			{
				return this.O.oo_oO..Selected;
			}
			set
			{
				this.O.oo_oO..Selected = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00098EED File Offset: 0x000970ED
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x00098EFA File Offset: 0x000970FA
		public Color BackColor
		{
			get
			{
				return this.O.oo_oO..BackColor;
			}
			set
			{
				this.O.oo_oO..BackColor = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00098F08 File Offset: 0x00097108
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00098F15 File Offset: 0x00097115
		public Color ForeColor
		{
			get
			{
				return this.O.oo_oO..ForeColor;
			}
			set
			{
				this.O.oo_oO..ForeColor = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00098F23 File Offset: 0x00097123
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x00098F30 File Offset: 0x00097130
		public Font Font
		{
			get
			{
				return this.O.oo_oO..Font;
			}
			set
			{
				this.O.oo_oO..Font = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00098F3E File Offset: 0x0009713E
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00098F4C File Offset: 0x0009714C
		public bool Checked
		{
			get
			{
				return this.O.oo_oO..Checked;
			}
			set
			{
				this.O.oo_oO..Checked = value;
				if (this.O.oo_oO..ListView != null && this.O.oo_oO..ListView.VirtualMode)
				{
					this.O.oo_oO..ListView.Invalidate(this.O.oo_oO..SubItems[0].Bounds);
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00098FAC File Offset: 0x000971AC
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x00098FE0 File Offset: 0x000971E0
		public string Group
		{
			get
			{
				string result;
				if (this.O.oo_oO..Group != null)
				{
					result = this.O.oo_oO..Group.Name;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.O.oo_oO..Group = null;
					return;
				}
				this.O.oo_oO..Group = this.O.oo_oO..ListView.Groups[value];
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0009901E File Offset: 0x0009721E
		public int Index
		{
			get
			{
				return this.O.oo_oO..Index;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0009902B File Offset: 0x0009722B
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x00099038 File Offset: 0x00097238
		public string ImageKey
		{
			get
			{
				return this.O.oo_oO..ImageKey;
			}
			set
			{
				this.O.oo_oO..ImageKey = value;
				if (this.O.oo_oO..ListView != null && this.O.oo_oO..ListView.VirtualMode)
				{
					ListView listView = this.O.oo_oO..ListView;
					int num = listView.SmallImageList.Images.IndexOfKey(value);
					if (num >= 0)
					{
						this.O.oo_oO..ImageIndex = num;
						return;
					}
					num = listView.LargeImageList.Images.IndexOfKey(value);
					if (num >= 0)
					{
						this.O.oo_oO..ImageIndex = num;
					}
				}
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000990C1 File Offset: 0x000972C1
		public void EnsureVisible()
		{
			this.O.oo_oO..EnsureVisible();
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000990CE File Offset: 0x000972CE
		public void BeginEdit()
		{
			this.O.oo_oO..BeginEdit();
		}

		// Token: 0x04000860 RID: 2144
		private ListViewItem <<EMPTY_NAME>>;
	}
}
