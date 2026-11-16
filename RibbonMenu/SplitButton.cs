using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 组合按钮
	/// </summary>
	// Token: 0x02000014 RID: 20
	[ComVisible(true)]
	public class SplitButton : RibbonItem
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002DB9 File Offset: 0x00000FB9
		internal SplitButton(RibbonSplitButton A_0) : base(A_0)
		{
			this.OO0.0OOo__. = A_0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002DC9 File Offset: 0x00000FC9
		public SplitButton(string A_0)
		{
			this.OO0.0OOo__. = new RibbonSplitButton();
			this.oOo_.0o_O_O_0. = this.OO0.0OOo__.;
			this.OO0.0OOo__..ID = A_0;
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002DF4 File Offset: 0x00000FF4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002E01 File Offset: 0x00001001
		public string Text
		{
			get
			{
				return this.OO0.0OOo__..Text;
			}
			set
			{
				this.OO0.0OOo__..Text = value;
			}
		}

		// Token: 0x1700003E RID: 62
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 返回组合按钮的项目集合
		/// </summary>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002E1D File Offset: 0x0000101D
		public RibbonItemCollection Items
		{
			get
			{
				if (this.OO0.0OOo__. == null)
				{
					this.OO0.0OOo__. = new RibbonItemCollection(this.OO0.0OOo__..Items);
				}
				return this.OO0.0OOo__.;
			}
		}

		/// <summary>
		/// 模拟单击该按钮
		/// </summary>
		// Token: 0x06000096 RID: 150 RVA: 0x00002E44 File Offset: 0x00001044
		public void PerformClick()
		{
			SplitButton splitButton = new SplitButton(this.OO0.0OOo__.);
			RibbonSplitButtonEventArgs ribbonSplitButtonEventArgs = new RibbonSplitButtonEventArgs(splitButton);
			string a_ = "Click_" + Conversions.ToString(splitButton.OO0.0OOo__..Tag);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				ribbonSplitButtonEventArgs
			}, false, "菜单" + splitButton.Name, false);
		}

		// Token: 0x04000019 RID: 25
		internal RibbonSplitButton <<EMPTY_NAME>>;

		// Token: 0x0400001A RID: 26
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
