using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	// Token: 0x0200050E RID: 1294
	[ComVisible(true)]
	public class ListViewCell
	{
		// Token: 0x0600548F RID: 21647 RVA: 0x00258653 File Offset: 0x00256853
		public ListViewCell(ListViewItem.ListViewSubItem A_0)
		{
			this.O.oo_oO. = A_0;
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x00258662 File Offset: 0x00256862
		public string Name
		{
			get
			{
				return this.O.oo_oO..Name;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x0025866F File Offset: 0x0025686F
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x0025867C File Offset: 0x0025687C
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

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x0025868A File Offset: 0x0025688A
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x00258697 File Offset: 0x00256897
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

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x002586A5 File Offset: 0x002568A5
		// (set) Token: 0x06005496 RID: 21654 RVA: 0x002586B2 File Offset: 0x002568B2
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

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x002586C0 File Offset: 0x002568C0
		// (set) Token: 0x06005498 RID: 21656 RVA: 0x002586CD File Offset: 0x002568CD
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

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x002586DB File Offset: 0x002568DB
		// (set) Token: 0x0600549A RID: 21658 RVA: 0x002586E8 File Offset: 0x002568E8
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

		// Token: 0x0600549B RID: 21659 RVA: 0x002586FB File Offset: 0x002568FB
		public void ResetStyle()
		{
			this.O.oo_oO..ResetStyle();
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x00258708 File Offset: 0x00256908
		public Rectangle Bounds
		{
			get
			{
				return this.O.oo_oO..Bounds;
			}
		}

		// Token: 0x040022B6 RID: 8886
		private ListViewItem.ListViewSubItem <<EMPTY_NAME>>;
	}
}
