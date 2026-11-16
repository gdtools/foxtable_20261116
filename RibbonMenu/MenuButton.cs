using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 菜单按钮
	/// </summary>
	// Token: 0x02000015 RID: 21
	[ComVisible(true)]
	public class MenuButton : RibbonItem
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002EA7 File Offset: 0x000010A7
		internal MenuButton(RibbonMenu A_0) : base(A_0)
		{
			this.OOo.O_o. = A_0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002EB7 File Offset: 0x000010B7
		public MenuButton(string A_0)
		{
			this.OOo.O_o. = new RibbonMenu();
			this.oOo_.0o_O_O_0. = this.OOo.O_o.;
			this.OOo.O_o..ID = A_0;
		}

		/// <summary>
		/// 按钮标题
		/// </summary>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002EE2 File Offset: 0x000010E2
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002EEF File Offset: 0x000010EF
		public string Text
		{
			get
			{
				return this.OOo.O_o..Text;
			}
			set
			{
				this.OOo.O_o..Text = value;
			}
		}

		// Token: 0x17000041 RID: 65
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002F0B File Offset: 0x0000110B
		public RibbonItemCollection Items
		{
			get
			{
				if (this.OOo.O_o. == null)
				{
					this.OOo.O_o. = new RibbonItemCollection(this.OOo.O_o..Items);
				}
				return this.OOo.O_o.;
			}
		}

		/// <summary>
		/// 是否显示下拉箭头
		/// </summary>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002F31 File Offset: 0x00001131
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002F3E File Offset: 0x0000113E
		public bool ArrowVisible
		{
			get
			{
				return this.OOo.O_o..ArrowVisible;
			}
			set
			{
				this.OOo.O_o..ArrowVisible = value;
			}
		}

		// Token: 0x0400001B RID: 27
		internal RibbonMenu <<EMPTY_NAME>>;

		// Token: 0x0400001C RID: 28
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
