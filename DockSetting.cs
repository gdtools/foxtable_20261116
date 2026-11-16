using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000336 RID: 822
	internal class DockSetting
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x0015121B File Offset: 0x0014F41B
		public DockSetting(DataTable A_0)
		{
			this.OO_.0o_0. = A_0;
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x0015122A File Offset: 0x0014F42A
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00151237 File Offset: 0x0014F437
		public string RightDockOrder
		{
			get
			{
				return this.OO_.0o_0..frd_RightDockOrder;
			}
			set
			{
				this.OO_.0o_0..frd_RightDockOrder = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x00151245 File Offset: 0x0014F445
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00151252 File Offset: 0x0014F452
		public string BottomDockOrder
		{
			get
			{
				return this.OO_.0o_0..frd_BottomDockOrder;
			}
			set
			{
				this.OO_.0o_0..frd_BottomDockOrder = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x00151260 File Offset: 0x0014F460
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x0015126D File Offset: 0x0014F46D
		[DefaultValue("")]
		public string LeftDockOrder
		{
			get
			{
				return this.OO_.0o_0..frd_LeftDockOrder;
			}
			set
			{
				this.OO_.0o_0..frd_LeftDockOrder = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x0015127B File Offset: 0x0014F47B
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x00151288 File Offset: 0x0014F488
		public string TopDockOrder
		{
			get
			{
				return this.OO_.0o_0..frd_TopDockOrder;
			}
			set
			{
				this.OO_.0o_0..frd_TopDockOrder = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00151296 File Offset: 0x0014F496
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x001512A3 File Offset: 0x0014F4A3
		[DefaultValue(0)]
		public int RightDockSize
		{
			get
			{
				return this.OO_.0o_0..frd_RightDockSize;
			}
			set
			{
				this.OO_.0o_0..frd_RightDockSize = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x001512B1 File Offset: 0x0014F4B1
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x001512BE File Offset: 0x0014F4BE
		[DefaultValue(0)]
		public int BottomDockSize
		{
			get
			{
				return this.OO_.0o_0..frd_BottomDockSize;
			}
			set
			{
				this.OO_.0o_0..frd_BottomDockSize = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x001512CC File Offset: 0x0014F4CC
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x001512D9 File Offset: 0x0014F4D9
		[DefaultValue(0)]
		public int TopDockSize
		{
			get
			{
				return this.OO_.0o_0..frd_TopDockSize;
			}
			set
			{
				this.OO_.0o_0..frd_TopDockSize = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x001512E7 File Offset: 0x0014F4E7
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x001512F4 File Offset: 0x0014F4F4
		[DefaultValue(200)]
		public int LeftDockSize
		{
			get
			{
				return this.OO_.0o_0..frd_LeftDockSize;
			}
			set
			{
				this.OO_.0o_0..frd_LeftDockSize = value;
			}
		}

		// Token: 0x040012CD RID: 4813
		private DataTable <<EMPTY_NAME>>;
	}
}
