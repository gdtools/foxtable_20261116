using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020002F4 RID: 756
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class IMUserCollections : IEnumerable<IMUser>
	{
		// Token: 0x06002957 RID: 10583 RVA: 0x0012A8CE File Offset: 0x00128ACE
		public IMUserCollections()
		{
			this.oO._O_0oO__0. = new Dictionary<string, IMUser>();
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0012A8E1 File Offset: 0x00128AE1
		internal void <<EMPTY_NAME>>(IMUser A_0)
		{
			this.oO._O_0oO__0..Add(A_0.Name, A_0);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x0012A8F5 File Offset: 0x00128AF5
		internal void <<EMPTY_NAME>>()
		{
			this.oO._O_0oO__0..Clear();
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0012A904 File Offset: 0x00128B04
		internal void <<EMPTY_NAME>>(string A_0)
		{
			lock (this)
			{
				this.oO._O_0oO__0..Remove(A_0);
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0012A948 File Offset: 0x00128B48
		internal void <<EMPTY_NAME>>(IMUser A_0)
		{
			lock (this)
			{
				this.oO._O_0oO__0..Remove(A_0.Name);
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x0012A990 File Offset: 0x00128B90
		public bool Contains(string Name)
		{
			return this.oO._O_0oO__0..ContainsKey(Name);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0012A99E File Offset: 0x00128B9E
		internal bool <<EMPTY_NAME>>(IMUser A_0)
		{
			return this.oO._O_0oO__0..ContainsKey(A_0.Name);
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x0012A9B1 File Offset: 0x00128BB1
		public int Count
		{
			get
			{
				return this.oO._O_0oO__0..Count;
			}
		}

		// Token: 0x170008CA RID: 2250
		public IMUser this[string Name]
		{
			get
			{
				return this.oO._O_0oO__0.[Name];
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0012A9CC File Offset: 0x00128BCC
		public IEnumerator<IMUser> GetEnumerator()
		{
			return (IEnumerator<IMUser>)this.oO._O_0oO__0..Values.GetEnumerator();
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0012A9E8 File Offset: 0x00128BE8
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.oO._O_0oO__0..Values.GetEnumerator();
		}

		// Token: 0x04001115 RID: 4373
		private Dictionary<string, IMUser> <<EMPTY_NAME>>;
	}
}
