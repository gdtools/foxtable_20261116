using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020000BE RID: 190
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class NetworkAvailabilityEventArgs
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x00039C9C File Offset: 0x00037E9C
		public NetworkAvailabilityEventArgs(bool A_0)
		{
			this.Oo_oOO_._Oo_o. = A_0;
		}

		/// <summary>
		/// 网络是否可用
		/// </summary>
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00039CAB File Offset: 0x00037EAB
		public bool IsAvailable
		{
			get
			{
				return this.Oo_oOO_._Oo_o.;
			}
		}

		// Token: 0x0400026E RID: 622
		private bool <<EMPTY_NAME>>;
	}
}
