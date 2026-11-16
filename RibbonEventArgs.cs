using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004AD RID: 1197
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonEventArgs
	{
		// Token: 0x06005035 RID: 20533 RVA: 0x00239366 File Offset: 0x00237566
		public RibbonEventArgs(object A_0)
		{
			this.OO_._O0. = RuntimeHelpers.GetObjectValue(A_0);
		}

		/// <summary>
		/// 触发时间的对象
		/// </summary>
		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x0023937A File Offset: 0x0023757A
		public object Sender
		{
			get
			{
				return this.OO_._O0.;
			}
		}

		// Token: 0x040020FF RID: 8447
		private object <<EMPTY_NAME>>;
	}
}
