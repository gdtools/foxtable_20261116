using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x020003CB RID: 971
	[ComVisible(true)]
	public class TabPage : C1DockingTabPage
	{
		// Token: 0x06003F87 RID: 16263 RVA: 0x001D1164 File Offset: 0x001CF364
		public TabPage()
		{
			base.GotFocus += this.TabPage_GotFocus;
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x001D117E File Offset: 0x001CF37E
		// (set) Token: 0x06003F89 RID: 16265 RVA: 0x001D1186 File Offset: 0x001CF386
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ImageFile
		{
			get
			{
				return this.OooO.OO0O_.;
			}
			set
			{
				this.OooO.OO0O_. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					base.Image = OO_00oOO.GetImage(value);
					return;
				}
				base.Image = null;
			}
		}

		/// <summary>
		/// 是否显示页面
		/// </summary>
		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06003F8A RID: 16266 RVA: 0x001D11B2 File Offset: 0x001CF3B2
		// (set) Token: 0x06003F8B RID: 16267 RVA: 0x001D11BA File Offset: 0x001CF3BA
		public new bool Visible
		{
			get
			{
				return base.TabVisible;
			}
			set
			{
				base.TabVisible = value;
			}
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x001D11C3 File Offset: 0x001CF3C3
		private void TabPage_GotFocus(object sender, EventArgs e)
		{
			base.SelectNextControl(this, true, true, true, true);
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x06003F8D RID: 16269 RVA: 0x001D11D4 File Offset: 0x001CF3D4
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			base.Controls.Add(Control.BaseControl);
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
		// Token: 0x06003F8E RID: 16270 RVA: 0x001D1230 File Offset: 0x001CF430
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in base.Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, control);
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
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this);
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x06003F8F RID: 16271 RVA: 0x001D12A8 File Offset: 0x001CF4A8
		public void ClearControl()
		{
			for (int i = base.Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = base.Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(base.Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(this);
		}

		/// <summary>
		/// 返回一个集合，包括所有顶层子控件
		/// </summary>
		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x001D12EC File Offset: 0x001CF4EC
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this);
			}
		}

		// Token: 0x040019E2 RID: 6626
		private string <<EMPTY_NAME>>;
	}
}
