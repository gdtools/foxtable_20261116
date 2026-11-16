using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020000A0 RID: 160
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class mrpPlan
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		public mrpPlan()
		{
			this.O._O0O0_0. = new Dictionary<string, double>();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0002FEB3 File Offset: 0x0002E0B3
		public void Add(string key, double Value)
		{
			this.O._O0O0_0..Add(key, Value);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0002FEC2 File Offset: 0x0002E0C2
		public IEnumerable<string> Keys
		{
			get
			{
				return this.O._O0O0_0..Keys;
			}
		}

		// Token: 0x17000160 RID: 352
		public double this[string A_0]
		{
			get
			{
				return this.O._O0O0_0.[A_0];
			}
			set
			{
				this.O._O0O0_0.[A_0] = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		public int Count
		{
			get
			{
				return this.O._O0O0_0..Count;
			}
		}

		// Token: 0x040001AA RID: 426
		private Dictionary<string, double> <<EMPTY_NAME>>;
	}
}
