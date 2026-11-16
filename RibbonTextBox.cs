using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200048A RID: 1162
	[oO0oooo("1112")]
	[OoO0___o("RibbonTextBox")]
	internal class RibbonTextBox : RibbonItem
	{
		// Token: 0x06004F0C RID: 20236 RVA: 0x0023864E File Offset: 0x0023684E
		public RibbonTextBox(DataRow A_0) : base(A_0)
		{
			this.O0oo0.o. = "标题:";
			this.O0oo0.o. = 60;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x00238672 File Offset: 0x00236872
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x0023868D File Offset: 0x0023688D
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		[DefaultValue("标题:")]
		public string Label
		{
			get
			{
				if (this.O0oo0.o. == null)
				{
					this.O0oo0.o. = "";
				}
				return this.O0oo0.o.;
			}
			set
			{
				this.O0oo0.o. = value;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x00238696 File Offset: 0x00236896
		// (set) Token: 0x06004F10 RID: 20240 RVA: 0x0023869E File Offset: 0x0023689E
		[DisplayName("内容")]
		[O_Oo00Oo000O0(1.2)]
		[Category("属性")]
		public string Text
		{
			get
			{
				return this.o00oo_OOO.00.;
			}
			set
			{
				this.o00oo_OOO.00. = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x002386A7 File Offset: 0x002368A7
		// (set) Token: 0x06004F12 RID: 20242 RVA: 0x002386AF File Offset: 0x002368AF
		[Category("属性")]
		[DisplayName("宽度")]
		[O_Oo00Oo000O0(1.3)]
		public int TextAreaWidth
		{
			get
			{
				return this.O0oo0.o.;
			}
			set
			{
				this.O0oo0.o. = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x002386B8 File Offset: 0x002368B8
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x002386C0 File Offset: 0x002368C0
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.4)]
		[Category("属性")]
		[DisplayName("最大长度")]
		[Description("允许输入内容的最大长度")]
		public int MaxLength
		{
			get
			{
				return this.o00oo_OOO.00.;
			}
			set
			{
				this.o00oo_OOO.00. = value;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x002386C9 File Offset: 0x002368C9
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x002386D1 File Offset: 0x002368D1
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[Description("取消修改后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCanceled
		{
			get
			{
				return this.O0oo0.o.;
			}
			set
			{
				this.O0oo0.o. = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x002386DA File Offset: 0x002368DA
		// (set) Token: 0x06004F18 RID: 20248 RVA: 0x002386E2 File Offset: 0x002368E2
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("提交修改后执行。")]
		[O_Oo00Oo000O0(0.2)]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCommitted
		{
			get
			{
				return this.o00oo_OOO.00.;
			}
			set
			{
				this.o00oo_OOO.00. = value;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06004F19 RID: 20249 RVA: 0x002386EB File Offset: 0x002368EB
		// (set) Token: 0x06004F1A RID: 20250 RVA: 0x002386F3 File Offset: 0x002368F3
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.3)]
		[Description("内容改变后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString TextChanged
		{
			get
			{
				return this.o0.0o_ooOO_o.;
			}
			set
			{
				this.o0.0o_ooOO_o. = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x002386FC File Offset: 0x002368FC
		// (set) Token: 0x06004F1C RID: 20252 RVA: 0x00238704 File Offset: 0x00236904
		[Description("获得输入焦点后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O_Oo00Oo000O0(0.4)]
		[O0O0oOO00_0OO(true)]
		public EventString GotFocus
		{
			get
			{
				return this.oO00.o_oOO0OO_.;
			}
			set
			{
				this.oO00.o_oOO0OO_. = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x0023870D File Offset: 0x0023690D
		// (set) Token: 0x06004F1E RID: 20254 RVA: 0x00238715 File Offset: 0x00236915
		[O_Oo00Oo000O0(0.5)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("失去输入焦点后执行。")]
		public EventString LostFocus
		{
			get
			{
				return this.oo00Oo.__o_0O0.;
			}
			set
			{
				this.oo00Oo.__o_0O0. = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0023871E File Offset: 0x0023691E
		// (set) Token: 0x06004F20 RID: 20256 RVA: 0x00238721 File Offset: 0x00236921
		[Browsable(false)]
		public new string LargeImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x04002053 RID: 8275
		private string <<EMPTY_NAME>>;

		// Token: 0x04002054 RID: 8276
		private string <<EMPTY_NAME>>;

		// Token: 0x04002055 RID: 8277
		private int <<EMPTY_NAME>>;

		// Token: 0x04002056 RID: 8278
		private int <<EMPTY_NAME>>;

		// Token: 0x04002057 RID: 8279
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002058 RID: 8280
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002059 RID: 8281
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400205A RID: 8282
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400205B RID: 8283
		private EventString <<EMPTY_NAME>>;
	}
}
