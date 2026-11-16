using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000482 RID: 1154
	internal class RibbonItemContainer : RibbonBase
	{
		// Token: 0x06004EC0 RID: 20160 RVA: 0x0023833B File Offset: 0x0023653B
		public RibbonItemContainer(DataRow A_0) : base(A_0)
		{
			this.oo_00OOO_o.0O. = true;
			this.O_0o_O.o0_O. = true;
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x00238352 File Offset: 0x00236552
		// (set) Token: 0x06004EC2 RID: 20162 RVA: 0x0023835A File Offset: 0x0023655A
		[Category("属性")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("提示")]
		public string ToolTip
		{
			get
			{
				return this.oo_00OOO_o.0O.;
			}
			set
			{
				this.oo_00OOO_o.0O. = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x00238363 File Offset: 0x00236563
		// (set) Token: 0x06004EC4 RID: 20164 RVA: 0x0023836B File Offset: 0x0023656B
		[DisplayName("可用")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(3.0)]
		[Category("属性")]
		public bool Enabled
		{
			get
			{
				return this.oo_00OOO_o.0O.;
			}
			set
			{
				this.oo_00OOO_o.0O. = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x00238374 File Offset: 0x00236574
		// (set) Token: 0x06004EC6 RID: 20166 RVA: 0x0023837C File Offset: 0x0023657C
		[DisplayName("可见")]
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		[DefaultValue(true)]
		public bool Visible
		{
			get
			{
				return this.O_0o_O.o0_O.;
			}
			set
			{
				this.O_0o_O.o0_O. = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x00238385 File Offset: 0x00236585
		// (set) Token: 0x06004EC8 RID: 20168 RVA: 0x0023838C File Offset: 0x0023658C
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("项目")]
		[Category("属性")]
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

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06004EC9 RID: 20169 RVA: 0x0023838E File Offset: 0x0023658E
		// (set) Token: 0x06004ECA RID: 20170 RVA: 0x00238396 File Offset: 0x00236596
		[O_Oo00Oo000O0(1.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("鼠标进入的时候执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnter
		{
			get
			{
				return this.oo_00OOO_o.0O.;
			}
			set
			{
				this.oo_00OOO_o.0O. = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x0023839F File Offset: 0x0023659F
		// (set) Token: 0x06004ECC RID: 20172 RVA: 0x002383A7 File Offset: 0x002365A7
		[O_Oo00Oo000O0(2.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("鼠标离开的时候执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeave
		{
			get
			{
				return this.O_0o_O.o0_O.;
			}
			set
			{
				this.O_0o_O.o0_O. = value;
			}
		}

		// Token: 0x04002035 RID: 8245
		private string <<EMPTY_NAME>>;

		// Token: 0x04002036 RID: 8246
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002037 RID: 8247
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002038 RID: 8248
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002039 RID: 8249
		private EventString <<EMPTY_NAME>>;
	}
}
