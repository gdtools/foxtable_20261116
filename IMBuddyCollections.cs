using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D7 RID: 471
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class IMBuddyCollections : IEnumerable<IMBuddy>
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x000A5D58 File Offset: 0x000A3F58
		public IMBuddyCollections()
		{
			this.OOO__.0. = new Dictionary<string, IMBuddy>();
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000A5D6B File Offset: 0x000A3F6B
		internal void <<EMPTY_NAME>>(IMBuddy A_0)
		{
			this.OOO__.0..Add(A_0.Name, A_0);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000A5D7F File Offset: 0x000A3F7F
		internal void <<EMPTY_NAME>>()
		{
			this.OOO__.0..Clear();
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000A5D8C File Offset: 0x000A3F8C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.OOO__.0..Remove(A_0);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000A5D9B File Offset: 0x000A3F9B
		internal void <<EMPTY_NAME>>(IMBuddy A_0)
		{
			this.OOO__.0..Remove(A_0.Name);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000A5DAF File Offset: 0x000A3FAF
		public bool Contains(string Name)
		{
			return this.OOO__.0..ContainsKey(Name);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000A5DBD File Offset: 0x000A3FBD
		internal bool <<EMPTY_NAME>>(IMBuddy A_0)
		{
			return this.OOO__.0..ContainsKey(A_0.Name);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000A5DD0 File Offset: 0x000A3FD0
		public int Count
		{
			get
			{
				return this.OOO__.0..Count;
			}
		}

		// Token: 0x17000496 RID: 1174
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMBuddy this[object A_0]
		{
			get
			{
				int a_ = -1;
				IMBuddy result;
				if (int.TryParse(A_0.ToString(), out a_))
				{
					result = this.OOO__.0.(a_);
				}
				else
				{
					result = this.get_Item(Conversions.ToString(A_0));
				}
				return result;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000A5E16 File Offset: 0x000A4016
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMBuddy Item
		{
			get
			{
				return this.OOO__.0.[Name];
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x000A5E24 File Offset: 0x000A4024
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMBuddy Item
		{
			get
			{
				int num = 0;
				try
				{
					foreach (string key in this.OOO__.0..Keys)
					{
						if (num == A_0)
						{
							return this.OOO__.0.[key];
						}
						num++;
					}
				}
				finally
				{
					Dictionary<string, IMBuddy>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return null;
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x000A5E94 File Offset: 0x000A4094
		public IEnumerator<IMBuddy> GetEnumerator()
		{
			return (IEnumerator<IMBuddy>)this.OOO__.0..Values.GetEnumerator();
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000A5EB0 File Offset: 0x000A40B0
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.OOO__.0..Values.GetEnumerator();
		}

		// Token: 0x04000942 RID: 2370
		private Dictionary<string, IMBuddy> <<EMPTY_NAME>>;
	}
}
