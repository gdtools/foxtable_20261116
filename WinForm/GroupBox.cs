using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 分组框
	/// </summary>
	// Token: 0x0200052A RID: 1322
	[ComVisible(true)]
	public class GroupBox : Control
	{
		// Token: 0x0600580E RID: 22542 RVA: 0x0025DE76 File Offset: 0x0025C076
		public GroupBox(GroupBox A_0) : base(A_0, ControlTypeEnum.GroupBox)
		{
			this.o0_0oO.OooO. = A_0;
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600580F RID: 22543 RVA: 0x0025DE88 File Offset: 0x0025C088
		// (set) Token: 0x06005810 RID: 22544 RVA: 0x0025DE95 File Offset: 0x0025C095
		public string Text
		{
			get
			{
				return this.o0_0oO.OooO..Text;
			}
			set
			{
				this.o0_0oO.OooO..Text = value;
			}
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x06005811 RID: 22545 RVA: 0x0025DEA4 File Offset: 0x0025C0A4
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			this.o0_0oO.OooO..Controls.Add(Control.BaseControl);
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
		// Token: 0x06005812 RID: 22546 RVA: 0x0025DF08 File Offset: 0x0025C108
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in this.o0_0oO.OooO..Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(this.o0_0oO.OooO..Controls, control);
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
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.o0_0oO.OooO.);
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x06005813 RID: 22547 RVA: 0x0025DF90 File Offset: 0x0025C190
		public void ClearControl()
		{
			for (int i = this.o0_0oO.OooO..Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = this.o0_0oO.OooO..Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(this.o0_0oO.OooO..Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this.o0_0oO.OooO.);
		}

		/// <summary>
		/// 返回一个集合，包括所有顶层子控件
		/// </summary>
		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x0025DFE8 File Offset: 0x0025C1E8
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this.o0_0oO.OooO.);
			}
		}

		// Token: 0x04002304 RID: 8964
		private GroupBox <<EMPTY_NAME>>;
	}
}
