using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200041D RID: 1053
	internal class PanelProperty : ControlPropertyBase
	{
		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x001F2F36 File Offset: 0x001F1136
		// (set) Token: 0x060046B8 RID: 18104 RVA: 0x001F2F40 File Offset: 0x001F1140
		private virtual Panel ChildControl
		{
			[CompilerGenerated]
			get
			{
				return this.Oo0.o_Ooo000O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ScrollEventHandler value2 = new ScrollEventHandler(this.O.00_0o_00.);
				Panel oo0.o_Ooo000O. = this.Oo0.o_Ooo000O.;
				if (oo0.o_Ooo000O. != null)
				{
					oo0.o_Ooo000O..Scroll -= value2;
				}
				this.Oo0.o_Ooo000O. = value;
				oo0.o_Ooo000O. = this.Oo0.o_Ooo000O.;
				if (oo0.o_Ooo000O. != null)
				{
					oo0.o_Ooo000O..Scroll += value2;
				}
			}
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x001F2F83 File Offset: 0x001F1183
		public PanelProperty(ControlHolder A_0) : base(A_0)
		{
			this.ChildControl = (Panel)A_0.ChildControl;
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x001F2F9D File Offset: 0x001F119D
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x001F2FAA File Offset: 0x001F11AA
		[MergableProperty(true)]
		[DefaultValue(false)]
		[Category("基本")]
		[O_Oo00Oo000O0(3.2)]
		[DisplayName("自动滚动")]
		public bool AutoScroll
		{
			get
			{
				return this.ChildControl.AutoScroll;
			}
			set
			{
				this.ChildControl.AutoScroll = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x001F2FB8 File Offset: 0x001F11B8
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x001F2FC5 File Offset: 0x001F11C5
		[DisplayName("扩展尺寸")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.3)]
		[Category("基本")]
		public Size ExtendSize
		{
			get
			{
				return this.ChildControl.AutoScrollMinSize;
			}
			set
			{
				this.ChildControl.AutoScrollMinSize = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x001F2FD3 File Offset: 0x001F11D3
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x001F2FE0 File Offset: 0x001F11E0
		[DefaultValue(0)]
		[DisplayName("边框")]
		[Category("外观")]
		[O_Oo00Oo000O0(3.1)]
		[MergableProperty(true)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.ChildControl.BorderStyle;
			}
			set
			{
				this.ChildControl.BorderStyle = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x001F2FEE File Offset: 0x001F11EE
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x001F3000 File Offset: 0x001F1200
		[DisplayName("样式")]
		[Category("外观")]
		[TypeConverter(typeof(o00))]
		[DefaultValue("(none)")]
		[O_Oo00Oo000O0(0.0)]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.ChildControl);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.ChildControl
				});
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x001F301C File Offset: 0x001F121C
		// (set) Token: 0x060046C3 RID: 18115 RVA: 0x001F3024 File Offset: 0x001F1224
		[oO0oooo("2397")]
		[Description("滚动面板后执行")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString AfterScroll
		{
			get
			{
				return this.Oo0.o_Ooo000O.;
			}
			set
			{
				this.Oo0.o_Ooo000O. = value;
			}
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x001F302D File Offset: 0x001F122D
		private void <<EMPTY_NAME>>(object A_0, ScrollEventArgs A_1)
		{
			this.ChildControl.Refresh();
		}

		// Token: 0x04001C94 RID: 7316
		[AccessedThroughProperty("ChildControl")]
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x04001C95 RID: 7317
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C96 RID: 7318
		private string <<EMPTY_NAME>>;
	}
}
