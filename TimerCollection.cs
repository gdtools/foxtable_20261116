using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200032B RID: 811
	[oO0oooo("0658")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TimerCollection : IEnumerable<Timer>
	{
		// Token: 0x06002D48 RID: 11592 RVA: 0x0014D90C File Offset: 0x0014BB0C
		public TimerCollection()
		{
			this.O_o.Oo_o__. = new Dictionary<string, Timer>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0014D924 File Offset: 0x0014BB24
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0014D92C File Offset: 0x0014BB2C
		public bool Pause
		{
			get
			{
				return this.O_o.Oo_o__.;
			}
			set
			{
				this.O_o.Oo_o__. = value;
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x0014D938 File Offset: 0x0014BB38
		public void Clear()
		{
			try
			{
				foreach (Timer timer in this.O_o.Oo_o__..Values)
				{
					timer.Enabled = false;
					timer.Dispose();
				}
			}
			finally
			{
				Dictionary<string, Timer>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.O_o.Oo_o__..Clear();
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x0014D9A0 File Offset: 0x0014BBA0
		public void Add(string key, Timer timer)
		{
			this.O_o.Oo_o__..Add(key, timer);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x0014D9AF File Offset: 0x0014BBAF
		public void Remove(string key)
		{
			this.O_o.Oo_o__..Remove(key);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x0014D9BE File Offset: 0x0014BBBE
		public IEnumerator<Timer> GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x0014D9CB File Offset: 0x0014BBCB
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x17000A39 RID: 2617
		public Timer this[string A_0]
		{
			get
			{
				return this.O_o.Oo_o__.[A_0];
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x0014D9E6 File Offset: 0x0014BBE6
		public int Count
		{
			get
			{
				return this.O_o.Oo_o__..Count;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x0014D9F3 File Offset: 0x0014BBF3
		public IEnumerable<string> Keys
		{
			get
			{
				return this.O_o.Oo_o__..Keys;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x0014DA00 File Offset: 0x0014BC00
		public IEnumerable<Timer> Values
		{
			get
			{
				return this.O_o.Oo_o__..Values;
			}
		}

		// Token: 0x0400125B RID: 4699
		private Dictionary<string, Timer> <<EMPTY_NAME>>;

		// Token: 0x0400125C RID: 4700
		private bool <<EMPTY_NAME>>;
	}
}
