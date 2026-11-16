using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200041C RID: 1052
	internal class PainterProperty : ControlPropertyBase
	{
		// Token: 0x060046B0 RID: 18096 RVA: 0x001F2ECB File Offset: 0x001F10CB
		public PainterProperty(ControlHolder A_0) : base(A_0)
		{
			this.O.00_0o_00. = (o0Oo0OO)A_0.ChildControl;
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x001F2EE5 File Offset: 0x001F10E5
		// (set) Token: 0x060046B2 RID: 18098 RVA: 0x001F2EF2 File Offset: 0x001F10F2
		[O_Oo00Oo000O0(3.2)]
		[DefaultValue(false)]
		[DisplayName("自动滚动")]
		[Category("基本")]
		[MergableProperty(true)]
		public bool AutoScroll
		{
			get
			{
				return this.O.00_0o_00..AutoScroll;
			}
			set
			{
				this.O.00_0o_00..AutoScroll = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x001F2F00 File Offset: 0x001F1100
		// (set) Token: 0x060046B4 RID: 18100 RVA: 0x001F2F0D File Offset: 0x001F110D
		[O_Oo00Oo000O0(3.3)]
		[DisplayName("扩展尺寸")]
		[Category("基本")]
		[MergableProperty(true)]
		public Size ExtendSize
		{
			get
			{
				return this.O.00_0o_00..AutoScrollMinSize;
			}
			set
			{
				this.O.00_0o_00..AutoScrollMinSize = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x001F2F1B File Offset: 0x001F111B
		// (set) Token: 0x060046B6 RID: 18102 RVA: 0x001F2F28 File Offset: 0x001F1128
		[O_Oo00Oo000O0(3.1)]
		[DisplayName("边框")]
		[Category("外观")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O.00_0o_00..BorderStyle;
			}
			set
			{
				this.O.00_0o_00..BorderStyle = value;
			}
		}

		// Token: 0x04001C93 RID: 7315
		private o0Oo0OO <<EMPTY_NAME>>;
	}
}
