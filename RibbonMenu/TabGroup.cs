using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 功能区组
	/// </summary>
	// Token: 0x02000034 RID: 52
	[oO0oooo("3088")]
	[ComVisible(true)]
	public class TabGroup
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public TabGroup(RibbonContextualTabGroup A_0)
		{
			this.o__Oo__.O__. = A_0;
			this.o__Oo__.O__. = new RibbonTabCollection(this.o__Oo__.O__..Tabs);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00004C1E File Offset: 0x00002E1E
		internal RibbonContextualTabGroup RibbonTabGroup
		{
			get
			{
				return this.o__Oo__.O__.;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00004C28 File Offset: 0x00002E28
		public TabGroup(string A_0)
		{
			this.o__Oo__.O__. = new RibbonContextualTabGroup();
			this.o__Oo__.O__..Name = A_0;
			this.o__Oo__.O__..Text = A_0;
			this.o__Oo__.O__. = new RibbonTabCollection(this.o__Oo__.O__..Tabs);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00004C74 File Offset: 0x00002E74
		public RibbonTabCollection RibbonTabs
		{
			get
			{
				return this.o__Oo__.O__.;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00004C7C File Offset: 0x00002E7C
		public string Name
		{
			get
			{
				return this.o__Oo__.O__..Name;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00004C89 File Offset: 0x00002E89
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00004C96 File Offset: 0x00002E96
		public string Text
		{
			get
			{
				return this.o__Oo__.O__..Text;
			}
			set
			{
				this.o__Oo__.O__..Text = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00004CA4 File Offset: 0x00002EA4
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public ContextualTabColor Color
		{
			get
			{
				return this.o__Oo__.O__..Color;
			}
			set
			{
				this.o__Oo__.O__..Color = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00004CBF File Offset: 0x00002EBF
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00004CCC File Offset: 0x00002ECC
		public Color ForeColor
		{
			get
			{
				return this.o__Oo__.O__..ForeColor;
			}
			set
			{
				this.o__Oo__.O__..ForeColor = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00004CDA File Offset: 0x00002EDA
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00004CE7 File Offset: 0x00002EE7
		public string ToolTip
		{
			get
			{
				return this.o__Oo__.O__..ToolTip;
			}
			set
			{
				this.o__Oo__.O__..ToolTip = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00004CF5 File Offset: 0x00002EF5
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00004D02 File Offset: 0x00002F02
		public bool Visible
		{
			get
			{
				return this.o__Oo__.O__..Visible;
			}
			set
			{
				this.o__Oo__.O__..Visible = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00004D10 File Offset: 0x00002F10
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00004D1D File Offset: 0x00002F1D
		public bool Clickable
		{
			get
			{
				return this.o__Oo__.O__..Clickable;
			}
			set
			{
				this.o__Oo__.O__..Clickable = value;
			}
		}

		// Token: 0x04000055 RID: 85
		private RibbonContextualTabGroup <<EMPTY_NAME>>;

		// Token: 0x04000056 RID: 86
		private RibbonTabCollection <<EMPTY_NAME>>;
	}
}
