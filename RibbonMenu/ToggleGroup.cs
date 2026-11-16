using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200001A RID: 26
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ToggleGroup : RibbonItem
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00003216 File Offset: 0x00001416
		internal ToggleGroup(RibbonToggleGroup A_0) : base(A_0)
		{
			this.o__Oo__.O__. = A_0;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003226 File Offset: 0x00001426
		public ToggleGroup(string A_0)
		{
			this.o__Oo__.O__. = new RibbonToggleGroup();
			this.oOo_.0o_O_O_0. = this.o__Oo__.O__.;
			this.o__Oo__.O__..ID = A_0;
		}

		// Token: 0x17000054 RID: 84
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000325F File Offset: 0x0000145F
		public RibbonItemCollection Items
		{
			get
			{
				if (this.o__Oo__.O__. == null)
				{
					this.o__Oo__.O__. = new RibbonItemCollection(this.o__Oo__.O__..Items);
				}
				return this.o__Oo__.O__.;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003285 File Offset: 0x00001485
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00003292 File Offset: 0x00001492
		public bool AllowAllButtonsUp
		{
			get
			{
				return this.o__Oo__.O__..AllowAllButtonsUp;
			}
			set
			{
				this.o__Oo__.O__..AllowAllButtonsUp = value;
			}
		}

		// Token: 0x04000024 RID: 36
		internal RibbonToggleGroup <<EMPTY_NAME>>;

		// Token: 0x04000025 RID: 37
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
