using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200033D RID: 829
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	internal class TimerProperty
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x00157470 File Offset: 0x00155670
		public TimerProperty()
		{
			this.oo.0oOO. = 2000;
			this.oo.0oOO. = true;
			this.O___0O.oo. = true;
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x00157491 File Offset: 0x00155691
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x00157499 File Offset: 0x00155699
		[DisplayName("名称")]
		[OooO0(true)]
		[O_Oo00Oo000O0(1.0)]
		[Category("基本属性")]
		public string Name
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x001574A2 File Offset: 0x001556A2
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x001574AA File Offset: 0x001556AA
		[DisplayName("间隔")]
		[O_Oo00Oo000O0(2.0)]
		[Category("基本属性")]
		[Description("计划执行间隔，单位为1/1000秒。")]
		[DefaultValue(0)]
		public int Interval
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				if (value < 1)
				{
					value = 1;
				}
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x001574BA File Offset: 0x001556BA
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x001574C2 File Offset: 0x001556C2
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(true)]
		[Description("是否执行计划")]
		[DisplayName("执行")]
		[Category("基本属性")]
		public bool Enabled
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x001574CB File Offset: 0x001556CB
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x001574D3 File Offset: 0x001556D3
		[O_Oo00Oo000O0(4.0)]
		[Description("是否允许用户暂停计划的执行")]
		[DisplayName("允许暂停")]
		[Category("基本属性")]
		[DefaultValue(true)]
		public bool CanPause
		{
			get
			{
				return this.O___0O.oo.;
			}
			set
			{
				this.O___0O.oo. = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x001574DC File Offset: 0x001556DC
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x001574E4 File Offset: 0x001556E4
		[DisplayName("代码")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("基本属性")]
		[Description("定期执行的代码")]
		public EventString Tick
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x04001433 RID: 5171
		private string <<EMPTY_NAME>>;

		// Token: 0x04001434 RID: 5172
		private int <<EMPTY_NAME>>;

		// Token: 0x04001435 RID: 5173
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001436 RID: 5174
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001437 RID: 5175
		private EventString <<EMPTY_NAME>>;
	}
}
