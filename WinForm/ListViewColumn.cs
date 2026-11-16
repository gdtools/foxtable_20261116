using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x020001B0 RID: 432
	[ComVisible(true)]
	public class ListViewColumn
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x00098322 File Offset: 0x00096522
		public ListViewColumn(ColumnHeader A_0)
		{
			this.O.oo_oO. = A_0;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00098331 File Offset: 0x00096531
		internal ColumnHeader BaseColumn
		{
			get
			{
				return this.O.oo_oO.;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0009833C File Offset: 0x0009653C
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0009838C File Offset: 0x0009658C
		public string Name
		{
			get
			{
				string result;
				if (this.O.oo_oO. == this.O.oo_oO..ListView.Columns[0])
				{
					result = ((o_OO_oOOO0o)this.O.oo_oO..ListView).O_O.0Oo_o.();
				}
				else
				{
					result = this.O.oo_oO..Name;
				}
				return result;
			}
			set
			{
				if (this.O.oo_oO. == this.O.oo_oO..ListView.Columns[0])
				{
					((o_OO_oOOO0o)this.O.oo_oO..ListView).o0__o.O0.(value);
				}
				else
				{
					this.O.oo_oO..Name = value;
				}
				if (Operators.CompareString(this.O.oo_oO..Text, "", true) == 0)
				{
					this.O.oo_oO..Text = value;
				}
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000983FF File Offset: 0x000965FF
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0009840C File Offset: 0x0009660C
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0009841A File Offset: 0x0009661A
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x00098427 File Offset: 0x00096627
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.O.oo_oO..TextAlign;
			}
			set
			{
				this.O.oo_oO..TextAlign = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00098435 File Offset: 0x00096635
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x00098442 File Offset: 0x00096642
		public int Width
		{
			get
			{
				return this.O.oo_oO..Width;
			}
			set
			{
				this.O.oo_oO..Width = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00098450 File Offset: 0x00096650
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0009845D File Offset: 0x0009665D
		public int Index
		{
			get
			{
				return this.O.oo_oO..DisplayIndex;
			}
			set
			{
				this.O.oo_oO..DisplayIndex = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0009846B File Offset: 0x0009666B
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x00098478 File Offset: 0x00096678
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

		// Token: 0x06001523 RID: 5411 RVA: 0x0009848B File Offset: 0x0009668B
		public void AutoResize(ColumnHeaderAutoResizeStyle mode = ColumnHeaderAutoResizeStyle.ColumnContent)
		{
			this.O.oo_oO..AutoResize(mode);
		}

		// Token: 0x04000852 RID: 2130
		private ColumnHeader <<EMPTY_NAME>>;
	}
}
