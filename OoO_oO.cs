using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004DB RID: 1243
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OoO_oO : Oo0__O__O_0__
	{
		// Token: 0x06005190 RID: 20880 RVA: 0x002454F8 File Offset: 0x002436F8
		public OoO_oO(Table A_0)
		{
			this.O_.o_. = new Dictionary<string, int>();
			this.O0._ooOO. = A_0;
			O_oOooO_O o_oOooO_O = this.O0._ooOO..foxGrid;
			int @fixed = o_oOooO_O.Cols.Fixed;
			int num = o_oOooO_O.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (!this.O_.o_..ContainsKey(o_oOooO_O.Cols[i].Name))
				{
					this.O_.o_..Add(o_oOooO_O.Cols[i].Name, o_oOooO_O.Cols[i].Width);
				}
			}
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x0024559A File Offset: 0x0024379A
		public void <<EMPTY_NAME>>()
		{
			this.O0._ooOO.();
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x002455A4 File Offset: 0x002437A4
		public void <<EMPTY_NAME>>()
		{
			O_oOooO_O o_oOooO_O = this.O0._ooOO..foxGrid;
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			int @fixed = o_oOooO_O.Cols.Fixed;
			int num = o_oOooO_O.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				dictionary.Add(o_oOooO_O.Cols[i].Name, o_oOooO_O.Cols[i].Width);
			}
			int fixed2 = o_oOooO_O.Cols.Fixed;
			int num2 = o_oOooO_O.Cols.Count - 1;
			for (int j = fixed2; j <= num2; j++)
			{
				if (this.O_.o_..ContainsKey(o_oOooO_O.Cols[j].Name))
				{
					o_oOooO_O.Cols[j].Width = this.O_.o_.[o_oOooO_O.Cols[j].Name];
				}
			}
			this.O_.o_..Clear();
			try
			{
				foreach (string key in dictionary.Keys)
				{
					this.O_.o_..Add(key, dictionary[key]);
				}
			}
			finally
			{
				Dictionary<string, int>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x04002189 RID: 8585
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400218A RID: 8586
		private Dictionary<string, int> <<EMPTY_NAME>>;
	}
}
