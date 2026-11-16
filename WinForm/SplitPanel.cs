using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x02000537 RID: 1335
	[ComVisible(true)]
	[oO0oooo("1918")]
	public class SplitPanel : Control
	{
		// Token: 0x06005948 RID: 22856 RVA: 0x0025FEF2 File Offset: 0x0025E0F2
		public SplitPanel(SplitterPanel A_0) : base(A_0, ControlTypeEnum.Panel)
		{
			this.oO.ooo. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06005949 RID: 22857 RVA: 0x0025FF04 File Offset: 0x0025E104
		// (set) Token: 0x0600594A RID: 22858 RVA: 0x0025FF11 File Offset: 0x0025E111
		public BorderStyle BorderStyle
		{
			get
			{
				return this.oO.ooo..BorderStyle;
			}
			set
			{
				this.oO.ooo..BorderStyle = value;
			}
		}

		/// <summary>
		/// 是否自动出现滚动条
		/// </summary>
		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600594B RID: 22859 RVA: 0x0025FF1F File Offset: 0x0025E11F
		// (set) Token: 0x0600594C RID: 22860 RVA: 0x0025FF2C File Offset: 0x0025E12C
		public bool AutoScroll
		{
			get
			{
				return this.oO.ooo..AutoScroll;
			}
			set
			{
				this.oO.ooo..AutoScroll = value;
			}
		}

		/// <summary>
		/// 设置分区的扩展尺寸
		/// </summary>
		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x0025FF3A File Offset: 0x0025E13A
		// (set) Token: 0x0600594E RID: 22862 RVA: 0x0025FF47 File Offset: 0x0025E147
		public Size ExtendSize
		{
			get
			{
				return this.oO.ooo..AutoScrollMinSize;
			}
			set
			{
				this.oO.ooo..AutoScrollMinSize = value;
			}
		}

		/// <summary>
		/// 是否隐藏此分区
		/// </summary>
		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x0025FF58 File Offset: 0x0025E158
		// (set) Token: 0x06005950 RID: 22864 RVA: 0x0025FF98 File Offset: 0x0025E198
		public bool Collapsed
		{
			get
			{
				SplitContainer splitContainer = (SplitContainer)this.oO.ooo..Parent;
				bool result;
				if (this.oO.ooo. == splitContainer.Panel1)
				{
					result = splitContainer.Panel1Collapsed;
				}
				else
				{
					result = splitContainer.Panel2Collapsed;
				}
				return result;
			}
			set
			{
				SplitContainer splitContainer = (SplitContainer)this.oO.ooo..Parent;
				if (this.oO.ooo. == splitContainer.Panel1)
				{
					splitContainer.Panel1Collapsed = value;
					return;
				}
				splitContainer.Panel2Collapsed = value;
			}
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x06005951 RID: 22865 RVA: 0x0025FFD4 File Offset: 0x0025E1D4
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			this.oO.ooo..Controls.Add(Control.BaseControl);
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
		// Token: 0x06005952 RID: 22866 RVA: 0x00260038 File Offset: 0x0025E238
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in this.oO.ooo..Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(this.oO.ooo..Controls, control);
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
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.oO.ooo.);
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x06005953 RID: 22867 RVA: 0x002600C0 File Offset: 0x0025E2C0
		public void ClearControl()
		{
			for (int i = this.oO.ooo..Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = this.oO.ooo..Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(this.oO.ooo..Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.oO.ooo.);
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x00260118 File Offset: 0x0025E318
		internal new SplitterPanel BaseControl
		{
			get
			{
				return this.oO.ooo.;
			}
		}

		/// <summary>
		/// 返回一个集合，包括所有顶层子控件
		/// </summary>
		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x00260120 File Offset: 0x0025E320
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this.oO.ooo.);
			}
		}

		// Token: 0x04002329 RID: 9001
		private SplitterPanel <<EMPTY_NAME>>;
	}
}
