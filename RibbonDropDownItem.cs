using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000480 RID: 1152
	internal class RibbonDropDownItem : RibbonItem
	{
		// Token: 0x06004EB7 RID: 20151 RVA: 0x002382E4 File Offset: 0x002364E4
		public RibbonDropDownItem(DataRow A_0) : base(A_0)
		{
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x002382ED File Offset: 0x002364ED
		// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x002382F4 File Offset: 0x002364F4
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(100.0)]
		[Category("属性")]
		[DisplayName("项目")]
		public Hashtable Items
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x002382F6 File Offset: 0x002364F6
		// (set) Token: 0x06004EBB RID: 20155 RVA: 0x002382FE File Offset: 0x002364FE
		[O_Oo00Oo000O0(3.0)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[Description("打开下拉列表或菜单的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString DropDown
		{
			get
			{
				return this.OO_._O0.;
			}
			set
			{
				this.OO_._O0. = value;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x00238307 File Offset: 0x00236507
		// (set) Token: 0x06004EBD RID: 20157 RVA: 0x0023830F File Offset: 0x0023650F
		[O0O0oOO00_0OO(true)]
		[Description("关闭下拉列表或菜单的时候执行。")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.0)]
		public EventString DropDownClosed
		{
			get
			{
				return this.o_0O.Ooo.;
			}
			set
			{
				this.o_0O.Ooo. = value;
			}
		}

		// Token: 0x04002033 RID: 8243
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002034 RID: 8244
		private EventString <<EMPTY_NAME>>;
	}
}
