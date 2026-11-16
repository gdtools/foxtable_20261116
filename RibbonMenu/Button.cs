using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 标准按钮
	/// </summary>
	// Token: 0x02000009 RID: 9
	[ComVisible(true)]
	public class Button : RibbonItem
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000026D6 File Offset: 0x000008D6
		internal Button(RibbonButton A_0) : base(A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000026E6 File Offset: 0x000008E6
		public Button(string A_0)
		{
			this.oOoOoOoO._o0. = new RibbonButton();
			this.oOo_.0o_O_O_0. = this.oOoOoOoO._o0.;
			this.oOoOoOoO._o0..ID = A_0;
		}

		/// <summary>
		/// 按钮标题
		/// </summary>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002711 File Offset: 0x00000911
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000271E File Offset: 0x0000091E
		public string Text
		{
			get
			{
				return this.oOoOoOoO._o0..Text;
			}
			set
			{
				this.oOoOoOoO._o0..Text = value;
			}
		}

		/// <summary>
		/// 按钮的快捷键
		/// </summary>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002739 File Offset: 0x00000939
		public Keys ShortcutKeys
		{
			get
			{
				return this.oOoOoOoO._o0..ShortcutKeys;
			}
			set
			{
				this.oOoOoOoO._o0..ShortcutKeys = value;
			}
		}

		/// <summary>
		/// 模拟单击该按钮
		/// </summary>
		// Token: 0x06000039 RID: 57 RVA: 0x00002748 File Offset: 0x00000948
		[oO0oooo("1103")]
		public void PerformClick()
		{
			Button button = new Button(this.oOoOoOoO._o0.);
			RibbonButtonEventArgs ribbonButtonEventArgs = new RibbonButtonEventArgs(button);
			string a_ = "Click_" + Conversions.ToString(button.oOoOoOoO._o0..Tag);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				ribbonButtonEventArgs
			}, false, "菜单," + button.Name, false);
		}

		// Token: 0x0400000F RID: 15
		internal RibbonButton <<EMPTY_NAME>>;
	}
}
