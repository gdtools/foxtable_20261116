using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 组合框
	/// </summary>
	// Token: 0x02000016 RID: 22
	[ComVisible(true)]
	public class ComboBox : RibbonItem
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002F4C File Offset: 0x0000114C
		internal ComboBox(RibbonComboBox A_0) : base(A_0)
		{
			this.oo0OOOO_._. = A_0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002F5C File Offset: 0x0000115C
		public ComboBox(string A_0)
		{
			this.oo0OOOO_._. = new RibbonComboBox();
			this.oOo_.0o_O_O_0. = this.oo0OOOO_._.;
			this.oo0OOOO_._..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置组合框中的内容
		/// </summary>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002F87 File Offset: 0x00001187
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002F94 File Offset: 0x00001194
		public string Text
		{
			get
			{
				return this.oo0OOOO_._..Text;
			}
			set
			{
				this.oo0OOOO_._..Text = value;
			}
		}

		/// <summary>
		/// 返回或者设置组合框的标题
		/// </summary>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002FA2 File Offset: 0x000011A2
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002FAF File Offset: 0x000011AF
		public string Label
		{
			get
			{
				return this.oo0OOOO_._..Label;
			}
			set
			{
				this.oo0OOOO_._..Label = value;
			}
		}

		/// <summary>
		/// 返回或设置组合框的宽度
		/// </summary>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002FBD File Offset: 0x000011BD
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002FCA File Offset: 0x000011CA
		public int TextAreaWidth
		{
			get
			{
				return this.oo0OOOO_._..TextAreaWidth;
			}
			set
			{
				this.oo0OOOO_._..TextAreaWidth = value;
			}
		}

		// Token: 0x17000047 RID: 71
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 返回列表项目集合
		/// </summary>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002FE6 File Offset: 0x000011E6
		public RibbonItemCollection Items
		{
			get
			{
				if (this.oo0OOOO_._. == null)
				{
					this.oo0OOOO_._. = new RibbonItemCollection(this.oo0OOOO_._..Items);
				}
				return this.oo0OOOO_._.;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000300C File Offset: 0x0000120C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public RibbonItemCollection MenuItems
		{
			get
			{
				if (this.o0o.oO_. == null)
				{
					this.o0o.oO_. = new RibbonItemCollection(this.oo0OOOO_._..MenuItems);
				}
				return this.o0o.oO_.;
			}
		}

		// Token: 0x0400001D RID: 29
		internal RibbonComboBox <<EMPTY_NAME>>;

		// Token: 0x0400001E RID: 30
		private RibbonItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400001F RID: 31
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
