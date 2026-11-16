using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000416 RID: 1046
	internal class GroupBoxProperty : ControlPropertyBase
	{
		// Token: 0x06004632 RID: 17970 RVA: 0x001F253A File Offset: 0x001F073A
		public GroupBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o_0ooO.Oo. = (GroupBox)A_0.ChildControl;
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x001F2554 File Offset: 0x001F0754
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x001F2561 File Offset: 0x001F0761
		[Category("基本")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("标题")]
		[MergableProperty(true)]
		public virtual string Text
		{
			get
			{
				return this.o_0ooO.Oo..Text;
			}
			set
			{
				this.o_0ooO.Oo..Text = value;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x001F256F File Offset: 0x001F076F
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x001F2581 File Offset: 0x001F0781
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[TypeConverter(typeof(o00))]
		[DisplayName("样式")]
		[DefaultValue("(none)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.o_0ooO.Oo.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.o_0ooO.Oo.
				});
			}
		}

		// Token: 0x04001C78 RID: 7288
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001C79 RID: 7289
		private string <<EMPTY_NAME>>;
	}
}
