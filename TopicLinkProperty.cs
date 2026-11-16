using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000427 RID: 1063
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TopicLinkProperty
	{
		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x001F45D6 File Offset: 0x001F27D6
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x001F45DE File Offset: 0x001F27DE
		[DisplayName("名称")]
		[O_Oo00Oo000O0(1.0)]
		[Category("属性")]
		public string Name
		{
			get
			{
				return this.O._oooo0__.;
			}
			set
			{
				this.O._oooo0__. = value;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x001F45E7 File Offset: 0x001F27E7
		// (set) Token: 0x06004870 RID: 18544 RVA: 0x001F45EF File Offset: 0x001F27EF
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("标题")]
		[Category("属性")]
		public string Text
		{
			get
			{
				return this.O_.o00000.;
			}
			set
			{
				this.O_.o00000. = value;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x001F45F8 File Offset: 0x001F27F8
		// (set) Token: 0x06004872 RID: 18546 RVA: 0x001F4600 File Offset: 0x001F2800
		[Category("属性")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("提示")]
		public string ToolTip
		{
			get
			{
				return this.OOoO0.0o00_0.;
			}
			set
			{
				this.OOoO0.0o00_0. = value;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x001F4609 File Offset: 0x001F2809
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x001F4611 File Offset: 0x001F2811
		[DisplayName("图标")]
		[Category("属性")]
		[O_Oo00Oo000O0(4.0)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string Image
		{
			get
			{
				return this.o0O0.0o00O.;
			}
			set
			{
				this.o0O0.0o00O. = value;
			}
		}

		// Token: 0x04001D37 RID: 7479
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D38 RID: 7480
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D39 RID: 7481
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D3A RID: 7482
		private string <<EMPTY_NAME>>;
	}
}
