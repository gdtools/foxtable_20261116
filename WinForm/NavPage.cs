using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 导航栏页面
	/// </summary>
	// Token: 0x020003C8 RID: 968
	[ComVisible(true)]
	[oO0oooo("0877")]
	public class NavPage : C1NavBarPanel
	{
		/// <summary>
		/// 页面标题
		/// </summary>
		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x001D0D10 File Offset: 0x001CEF10
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x001D0D1D File Offset: 0x001CEF1D
		[oO0oooo("0880")]
		public string HeaderText
		{
			get
			{
				return base.Button.PanelHeader;
			}
			set
			{
				base.Button.PanelHeader = value;
			}
		}

		/// <summary>
		/// 按钮标题
		/// </summary>
		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x001D0D2B File Offset: 0x001CEF2B
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x001D0D38 File Offset: 0x001CEF38
		public string ButtonText
		{
			get
			{
				return base.Button.Text;
			}
			set
			{
				base.Button.Text = value;
			}
		}

		/// <summary>
		/// 页面的按钮图标文件
		/// </summary>
		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x001D0D46 File Offset: 0x001CEF46
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x001D0D4E File Offset: 0x001CEF4E
		[oO0oooo("0881")]
		public string ButtonImageFile
		{
			get
			{
				return this.o.oO_oo_O.;
			}
			set
			{
				this.o.oO_oo_O. = value;
				base.Button.Image = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 页面的按钮小图标文件
		/// </summary>
		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x001D0D68 File Offset: 0x001CEF68
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x001D0D70 File Offset: 0x001CEF70
		public string ButtonSmallImageFile
		{
			get
			{
				return this.o._o0o___O0ooO.;
			}
			set
			{
				this.o._o0o___O0ooO. = value;
				base.Button.SmallImage = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 页面是否可见
		/// </summary>
		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x001D0D8A File Offset: 0x001CEF8A
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x001D0D92 File Offset: 0x001CEF92
		public new bool Visible
		{
			get
			{
				return base.PanelVisible;
			}
			set
			{
				base.PanelVisible = value;
			}
		}

		/// <summary>
		/// 增加控件
		/// </summary>
		/// <param name="Control">要增加的控件</param>
		// Token: 0x06003F70 RID: 16240 RVA: 0x001D0D9C File Offset: 0x001CEF9C
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
		// Token: 0x06003F71 RID: 16241 RVA: 0x001D0DF8 File Offset: 0x001CEFF8
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
		// Token: 0x06003F72 RID: 16242 RVA: 0x001D0E70 File Offset: 0x001CF070
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
		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x001D0EB4 File Offset: 0x001CF0B4
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this);
			}
		}

		// Token: 0x040019DC RID: 6620
		private string <<EMPTY_NAME>>;

		// Token: 0x040019DD RID: 6621
		private string <<EMPTY_NAME>>;
	}
}
