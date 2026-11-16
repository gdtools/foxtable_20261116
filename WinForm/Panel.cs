using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 面板
	/// </summary>
	// Token: 0x02000531 RID: 1329
	[ComVisible(true)]
	public class Panel : Control
	{
		// Token: 0x06005899 RID: 22681 RVA: 0x0025EFE6 File Offset: 0x0025D1E6
		public Panel(Panel A_0) : base(A_0, ControlTypeEnum.Panel)
		{
			this.o.oO_oo_O. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x0025EFF8 File Offset: 0x0025D1F8
		// (set) Token: 0x0600589B RID: 22683 RVA: 0x0025F005 File Offset: 0x0025D205
		[oO0oooo("1915")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.oO_oo_O..BorderStyle;
			}
			set
			{
				this.o.oO_oo_O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 当面板中的控件位置或大小超出面板范围时，是否自动出现滚动条
		/// </summary>
		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x0025F013 File Offset: 0x0025D213
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x0025F020 File Offset: 0x0025D220
		public bool AutoScroll
		{
			get
			{
				return this.o.oO_oo_O..AutoScroll;
			}
			set
			{
				this.o.oO_oo_O..AutoScroll = value;
			}
		}

		/// <summary>
		/// 返回或设置滚动条位置
		/// </summary>
		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0025F02E File Offset: 0x0025D22E
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x0025F03B File Offset: 0x0025D23B
		[oO0oooo("2398")]
		public Point ScrollPosition
		{
			get
			{
				return this.o.oO_oo_O..AutoScrollPosition;
			}
			set
			{
				this.o.oO_oo_O..AutoScrollPosition = value;
			}
		}

		/// <summary>
		/// 扩展尺寸
		/// </summary>
		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x0025F049 File Offset: 0x0025D249
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x0025F056 File Offset: 0x0025D256
		[oO0oooo("0811")]
		public Size ExtendSize
		{
			get
			{
				return this.o.oO_oo_O..AutoScrollMinSize;
			}
			set
			{
				this.o.oO_oo_O..AutoScrollMinSize = value;
			}
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x060058A2 RID: 22690 RVA: 0x0025F064 File Offset: 0x0025D264
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			this.o.oO_oo_O..Controls.Add(Control.BaseControl);
			if (Control.BaseControl is O_oOooO_O)
			{
				Table o.0O_O0o_. = ((O_oOooO_O)Control.BaseControl).o.0O_O0o_.;
				if (o.0O_O0o_..TableType != TableTypeEnum.Normal || o.0O_O0o_..IsCopy)
				{
					o.0O_O0o_..oO_o_0o._0oooo.(true);
				}
			}
			Control.TopMost = true;
		}

		/// <summary>
		/// 删除指定名称的控件
		/// </summary>
		/// <param name="Name">要被删除的控件的名称</param>
		// Token: 0x060058A3 RID: 22691 RVA: 0x0025F0C8 File Offset: 0x0025D2C8
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in this.o.oO_oo_O..Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(this.o.oO_oo_O..Controls, control);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.o.oO_oo_O.);
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x060058A4 RID: 22692 RVA: 0x0025F150 File Offset: 0x0025D350
		public void ClearControl()
		{
			for (int i = this.o.oO_oo_O..Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = this.o.oO_oo_O..Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(this.o.oO_oo_O..Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.o.oO_oo_O.);
		}

		/// <summary>
		/// 返回一个集合，包括所有顶层子控件
		/// </summary>
		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x0025F1A8 File Offset: 0x0025D3A8
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this.o.oO_oo_O.);
			}
		}

		// Token: 0x0400230D RID: 8973
		private Panel <<EMPTY_NAME>>;
	}
}
