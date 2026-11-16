using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 分区面板
	/// </summary>
	// Token: 0x02000536 RID: 1334
	[ComVisible(true)]
	public class SplitContainer : Control
	{
		// Token: 0x06005929 RID: 22825 RVA: 0x0025FCE9 File Offset: 0x0025DEE9
		public SplitContainer(SplitContainer A_0) : base(A_0, ControlTypeEnum.SplitContainer)
		{
			this.Oooo.Oo_0O. = FixedPanel.Panel1;
			A_0.Panel1MinSize = 0;
			A_0.Panel2MinSize = 0;
			this.Oooo.Oo_0O. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600592A RID: 22826 RVA: 0x0025FD10 File Offset: 0x0025DF10
		// (set) Token: 0x0600592B RID: 22827 RVA: 0x0025FD1D File Offset: 0x0025DF1D
		public BorderStyle BorderStyle
		{
			get
			{
				return this.Oooo.Oo_0O..BorderStyle;
			}
			set
			{
				this.Oooo.Oo_0O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 返回或设置分区面板的排列方向
		/// </summary>
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600592C RID: 22828 RVA: 0x0025FD2B File Offset: 0x0025DF2B
		// (set) Token: 0x0600592D RID: 22829 RVA: 0x0025FD38 File Offset: 0x0025DF38
		public Orientation Orientation
		{
			get
			{
				return this.Oooo.Oo_0O..Orientation;
			}
			set
			{
				this.Oooo.Oo_0O..Orientation = value;
			}
		}

		/// <summary>
		/// 设置某个分区为固定分区，使得其大小不随分区面板大小的调整而调整
		/// </summary>
		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x0600592E RID: 22830 RVA: 0x0025FD46 File Offset: 0x0025DF46
		// (set) Token: 0x0600592F RID: 22831 RVA: 0x0025FD53 File Offset: 0x0025DF53
		[oO0oooo("0821")]
		public FixedPanel FixedPanel
		{
			get
			{
				return this.Oooo.Oo_0O..FixedPanel;
			}
			set
			{
				this.Oooo.Oo_0O..FixedPanel = value;
			}
		}

		/// <summary>
		/// 分割条宽度
		/// </summary>
		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06005930 RID: 22832 RVA: 0x0025FD61 File Offset: 0x0025DF61
		// (set) Token: 0x06005931 RID: 22833 RVA: 0x0025FD6E File Offset: 0x0025DF6E
		public int SplitterWidth
		{
			get
			{
				return this.Oooo.Oo_0O..SplitterWidth;
			}
			set
			{
				this.Oooo.Oo_0O..SplitterWidth = value;
			}
		}

		/// <summary>
		/// 是否禁止通过拖动分割条来调整两个分区的大小
		/// </summary>
		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06005932 RID: 22834 RVA: 0x0025FD7C File Offset: 0x0025DF7C
		// (set) Token: 0x06005933 RID: 22835 RVA: 0x0025FD89 File Offset: 0x0025DF89
		public bool IsSplitterFixed
		{
			get
			{
				return this.Oooo.Oo_0O..IsSplitterFixed;
			}
			set
			{
				this.Oooo.Oo_0O..IsSplitterFixed = value;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06005934 RID: 22836 RVA: 0x0025FD97 File Offset: 0x0025DF97
		// (set) Token: 0x06005935 RID: 22837 RVA: 0x0025FD9F File Offset: 0x0025DF9F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int SplitterDistance2
		{
			get
			{
				return this.Oooo.Oo_0O.;
			}
			set
			{
				this.Oooo.Oo_0O. = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06005936 RID: 22838 RVA: 0x0025FDA8 File Offset: 0x0025DFA8
		// (set) Token: 0x06005937 RID: 22839 RVA: 0x0025FDB0 File Offset: 0x0025DFB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FixedPanel FixedPanel2
		{
			get
			{
				return this.Oooo.Oo_0O.;
			}
			set
			{
				this.Oooo.Oo_0O. = value;
			}
		}

		/// <summary>
		/// 返回或设置分割条的位置，单位为像素
		/// </summary>
		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06005938 RID: 22840 RVA: 0x0025FDB9 File Offset: 0x0025DFB9
		// (set) Token: 0x06005939 RID: 22841 RVA: 0x0025FDC6 File Offset: 0x0025DFC6
		public int SplitterDistance
		{
			get
			{
				return this.Oooo.Oo_0O..SplitterDistance;
			}
			set
			{
				this.Oooo.Oo_0O..SplitterDistance = value;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600593A RID: 22842 RVA: 0x0025FDD4 File Offset: 0x0025DFD4
		// (set) Token: 0x0600593B RID: 22843 RVA: 0x0025FDE6 File Offset: 0x0025DFE6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color BackColorOfPanel1
		{
			get
			{
				return this.Oooo.Oo_0O..Panel1.BackColor;
			}
			set
			{
				if (this.Oooo.Oo_0O..Panel1.BackColor != value)
				{
					this.Oooo.Oo_0O..Panel1.BackColor = value;
				}
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600593C RID: 22844 RVA: 0x0025FE11 File Offset: 0x0025E011
		// (set) Token: 0x0600593D RID: 22845 RVA: 0x0025FE23 File Offset: 0x0025E023
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Panel1IsAutoScroll
		{
			get
			{
				return this.Oooo.Oo_0O..Panel1.AutoScroll;
			}
			set
			{
				this.Oooo.Oo_0O..Panel1.AutoScroll = value;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x0025FE36 File Offset: 0x0025E036
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x0025FE48 File Offset: 0x0025E048
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color BackColorOfPanel2
		{
			get
			{
				return this.Oooo.Oo_0O..Panel2.BackColor;
			}
			set
			{
				if (this.Oooo.Oo_0O..Panel2.BackColor != value)
				{
					this.Oooo.Oo_0O..Panel2.BackColor = value;
				}
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x0025FE73 File Offset: 0x0025E073
		// (set) Token: 0x06005941 RID: 22849 RVA: 0x0025FE85 File Offset: 0x0025E085
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Panel2IsAutoScroll
		{
			get
			{
				return this.Oooo.Oo_0O..Panel2.AutoScroll;
			}
			set
			{
				this.Oooo.Oo_0O..Panel2.AutoScroll = value;
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x0025FE98 File Offset: 0x0025E098
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x0025FEA5 File Offset: 0x0025E0A5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Panel1Collapsed
		{
			get
			{
				return this.Oooo.Oo_0O..Panel1Collapsed;
			}
			set
			{
				this.Oooo.Oo_0O..Panel1Collapsed = value;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x0025FEB3 File Offset: 0x0025E0B3
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x0025FEC0 File Offset: 0x0025E0C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Panel2Collapsed
		{
			get
			{
				return this.Oooo.Oo_0O..Panel2Collapsed;
			}
			set
			{
				this.Oooo.Oo_0O..Panel2Collapsed = value;
			}
		}

		/// <summary>
		/// 返回第一个分区
		/// </summary>
		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x0025FECE File Offset: 0x0025E0CE
		[oO0oooo("1918")]
		public SplitPanel Panel1
		{
			get
			{
				return new SplitPanel(this.Oooo.Oo_0O..Panel1);
			}
		}

		/// <summary>
		/// 返回第二个分区
		/// </summary>
		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06005947 RID: 22855 RVA: 0x0025FEE0 File Offset: 0x0025E0E0
		[oO0oooo("1918")]
		public SplitPanel Panel2
		{
			get
			{
				return new SplitPanel(this.Oooo.Oo_0O..Panel2);
			}
		}

		// Token: 0x04002326 RID: 8998
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04002327 RID: 8999
		private int <<EMPTY_NAME>>;

		// Token: 0x04002328 RID: 9000
		private FixedPanel <<EMPTY_NAME>>;
	}
}
