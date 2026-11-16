using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	// Token: 0x020001B3 RID: 435
	[ComVisible(true)]
	public class ListViewGroup
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x000986C1 File Offset: 0x000968C1
		public ListViewGroup(ListViewGroup A_0)
		{
			this.O.oo_oO. = A_0;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x000986D0 File Offset: 0x000968D0
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x000986DD File Offset: 0x000968DD
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000986EB File Offset: 0x000968EB
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x000986F8 File Offset: 0x000968F8
		public string Text
		{
			get
			{
				return this.O.oo_oO..Header;
			}
			set
			{
				this.O.oo_oO..Header = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00098706 File Offset: 0x00096906
		internal ListViewGroup BaseGroup
		{
			get
			{
				return this.O.oo_oO.;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0009870E File Offset: 0x0009690E
		public ListViewRowCollections Rows
		{
			get
			{
				return new ListViewRowCollections(this.O.oo_oO..Items);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00098720 File Offset: 0x00096920
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0009872D File Offset: 0x0009692D
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

		// Token: 0x04000857 RID: 2135
		private ListViewGroup <<EMPTY_NAME>>;
	}
}
