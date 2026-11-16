using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200032A RID: 810
	[oO0oooo("0658")]
	[ComVisible(true)]
	public class Timer
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x0014D790 File Offset: 0x0014B990
		public Timer()
		{
			this._timer = new Timer();
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x0014D7A3 File Offset: 0x0014B9A3
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x0014D7AC File Offset: 0x0014B9AC
		private virtual Timer _timer
		{
			[CompilerGenerated]
			get
			{
				return this.o.0O__o.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Mytimer_Tick);
				Timer timer = this.o.0O__o.;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.o.0O__o. = value;
				timer = this.o.0O__o.;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x0014D7EF File Offset: 0x0014B9EF
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x0014D7F7 File Offset: 0x0014B9F7
		public object Tag
		{
			[CompilerGenerated]
			get
			{
				return this.O_o.Oo_o__.;
			}
			[CompilerGenerated]
			set
			{
				this.O_o.Oo_o__. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x0014D805 File Offset: 0x0014BA05
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x0014D812 File Offset: 0x0014BA12
		public bool Enabled
		{
			get
			{
				return this._timer.Enabled;
			}
			set
			{
				this._timer.Enabled = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x0014D820 File Offset: 0x0014BA20
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x0014D82D File Offset: 0x0014BA2D
		public int Interval
		{
			get
			{
				return this._timer.Interval;
			}
			set
			{
				this._timer.Interval = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x0014D83B File Offset: 0x0014BA3B
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x0014D843 File Offset: 0x0014BA43
		internal bool CanPause
		{
			get
			{
				return this.o.0O__o.;
			}
			set
			{
				this.o.0O__o. = true;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x0014D84C File Offset: 0x0014BA4C
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x0014D854 File Offset: 0x0014BA54
		public string Name
		{
			get
			{
				return this.o.0O__o.;
			}
			internal set
			{
				this.o.0O__o. = value;
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x0014D85D File Offset: 0x0014BA5D
		public void Dispose()
		{
			this._timer.Dispose();
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x0014D86C File Offset: 0x0014BA6C
		private void Mytimer_Tick(object sender, EventArgs e)
		{
			if (!OO_00oOO.MyTimers.Pause)
			{
				Assembly oo0_o_.o. = O_O0OO.oo0_o_.o.;
				if (OO_00oOO.SystemReady && oo0_o_.o. != null)
				{
					MethodInfo method = oo0_o_.o..GetType("UserCode").GetMethod(this.Tag.ToString());
					try
					{
						if (method != null)
						{
							method.Invoke(null, null);
						}
					}
					catch (Exception innerException)
					{
						if (innerException.InnerException != null)
						{
							innerException = innerException.InnerException;
						}
						this.Enabled = false;
						ooO.oOo0Oo.o.(innerException, "计划" + this.Name);
					}
				}
			}
		}

		// Token: 0x04001257 RID: 4695
		[CompilerGenerated]
		[AccessedThroughProperty("_timer")]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04001258 RID: 4696
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001259 RID: 4697
		private string <<EMPTY_NAME>>;

		// Token: 0x0400125A RID: 4698
		[CompilerGenerated]
		private object <<EMPTY_NAME>>;
	}
}
