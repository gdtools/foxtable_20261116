using System;
using System.ComponentModel;
using System.Drawing;

namespace Foxtable
{
	// Token: 0x02000418 RID: 1048
	internal class LineProperty : ControlPropertyBase
	{
		// Token: 0x06004648 RID: 17992 RVA: 0x001F26A8 File Offset: 0x001F08A8
		public LineProperty(ControlHolder A_0) : base(A_0)
		{
			this.o._Ooo0oOO. = (LineControl)A_0.ChildControl;
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x001F26C2 File Offset: 0x001F08C2
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x001F26CA File Offset: 0x001F08CA
		[Browsable(false)]
		[OooO0(true)]
		public new Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x0600464B RID: 17995 RVA: 0x001F26D3 File Offset: 0x001F08D3
		// (set) Token: 0x0600464C RID: 17996 RVA: 0x001F26DB File Offset: 0x001F08DB
		[OooO0(true)]
		[Browsable(false)]
		public new Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x001F26E4 File Offset: 0x001F08E4
		// (set) Token: 0x0600464E RID: 17998 RVA: 0x001F26F6 File Offset: 0x001F08F6
		[DefaultValue(-16777216)]
		[O_Oo00Oo000O0(2.0)]
		[Category("外观")]
		[MergableProperty(true)]
		[DisplayName("颜色")]
		public override Color ForeColor
		{
			get
			{
				return this.o_0_.Oo..ChildControl.ForeColor;
			}
			set
			{
				this.o_0_.Oo..ChildControl.ForeColor = value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x001F2709 File Offset: 0x001F0909
		// (set) Token: 0x06004650 RID: 18000 RVA: 0x001F2716 File Offset: 0x001F0916
		[DisplayName("方向")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[Category("外观")]
		[DefaultValue(0)]
		public LineDirectionEnum Ditection
		{
			get
			{
				return this.o._Ooo0oOO..Direction;
			}
			set
			{
				this.o._Ooo0oOO..Direction = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x001F2724 File Offset: 0x001F0924
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x001F2731 File Offset: 0x001F0931
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("线宽")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(1)]
		public int Thickness
		{
			get
			{
				return this.o._Ooo0oOO..Thickness;
			}
			set
			{
				this.o._Ooo0oOO..Thickness = value;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x001F273F File Offset: 0x001F093F
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x001F274C File Offset: 0x001F094C
		[Category("外观")]
		[DisplayName("线形")]
		[O_Oo00Oo000O0(2.2)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public DashStyleEnum DashStyle
		{
			get
			{
				return this.o._Ooo0oOO..DashStyle;
			}
			set
			{
				this.o._Ooo0oOO..DashStyle = value;
			}
		}

		// Token: 0x04001C7D RID: 7293
		private LineControl <<EMPTY_NAME>>;
	}
}
