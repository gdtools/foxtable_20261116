using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200020D RID: 525
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wElement
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x000B7C8C File Offset: 0x000B5E8C
		internal wElement(string A_0, string A_1)
		{
			this.OoO0.oOo. = A_0.ToLower();
			this.Oo0_0.o. = A_1.ToLower();
		}

		/// <summary>
		/// 父容器ID
		/// </summary>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000B7CAC File Offset: 0x000B5EAC
		public string PID
		{
			get
			{
				return this.OoO0.oOo.;
			}
		}

		/// <summary>
		/// 组件ID
		/// </summary>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x000B7CB4 File Offset: 0x000B5EB4
		public string ID
		{
			get
			{
				return this.Oo0_0.o.;
			}
		}

		/// <summary>
		/// Class属性
		/// </summary>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x000B7CBC File Offset: 0x000B5EBC
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x000B7CC4 File Offset: 0x000B5EC4
		[oO0oooo("A0056")]
		public string Class
		{
			get
			{
				return this.o0_O0_o_o0O._o.;
			}
			set
			{
				this.o0_O0_o_o0O._o. = value;
			}
		}

		/// <summary>
		/// Attribute属性
		/// </summary>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x000B7CCD File Offset: 0x000B5ECD
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x000B7CD5 File Offset: 0x000B5ED5
		[oO0oooo("A0056")]
		public string Attribute
		{
			get
			{
				return this.oo__oo.O.;
			}
			set
			{
				this.oo__oo.O. = value;
			}
		}

		// Token: 0x04000AC5 RID: 2757
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AC6 RID: 2758
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AC7 RID: 2759
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AC8 RID: 2760
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AC9 RID: 2761
		internal bool <<EMPTY_NAME>>;
	}
}
