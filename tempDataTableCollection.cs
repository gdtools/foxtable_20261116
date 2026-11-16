using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000464 RID: 1124
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class tempDataTableCollection
	{
		// Token: 0x06004BA0 RID: 19360 RVA: 0x00223945 File Offset: 0x00221B45
		public tempDataTableCollection()
		{
			this._List = new Dictionary<string, DataTable>();
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x00223958 File Offset: 0x00221B58
		internal void add(string name, DataTable dt)
		{
			this._List.Add(name, dt);
		}

		// Token: 0x17001055 RID: 4181
		public DataTable this[string A_0]
		{
			get
			{
				try
				{
					foreach (string text in this._List.Keys)
					{
						if (Operators.CompareString(text, A_0, true) == 0)
						{
							return this._List[text];
						}
					}
				}
				finally
				{
					Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return null;
			}
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x002239D8 File Offset: 0x00221BD8
		public bool Contains(string name)
		{
			try
			{
				Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator = this._List.Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current, name, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x04001EBE RID: 7870
		internal Dictionary<string, DataTable> _List;
	}
}
