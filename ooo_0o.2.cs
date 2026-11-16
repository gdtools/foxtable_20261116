using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200042E RID: 1070
	internal class ooo_0o : O_o_0o
	{
		// Token: 0x060048B5 RID: 18613 RVA: 0x001F4F69 File Offset: 0x001F3169
		public ooo_0o()
		{
			this.ooO_O.O_O. = null;
			this.ooO_O.O_O. = new List<ParentChildPair>();
			this.ooO_O.O_O. = new Dictionary<string, object>();
			this.O0_o.0. = new Dictionary<string, object>();
			this.ooO_O.O_O. = new Dictionary<string, PropertyBase>();
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x001F4FA4 File Offset: 0x001F31A4
		internal void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			this.ooO_O.O_O..Add(new ParentChildPair(A_0));
			if (this.ooO_O.O_O. == null)
			{
				this.ooO_O.O_O. = (o\u3002\u3002\u3000\u3000\u3002)A_0.FindForm();
			}
			this.ooO_O.O_O..Add(A_0.Key, this.ooO_O.O_O..O0o._0.[A_0.Key]);
			this.ooO_O.O_O..Add(A_0.Key, RuntimeHelpers.GetObjectValue(this.ooO_O.O_O..o_0O.OO0_0_.[A_0.Key]));
			this.O0_o.0..Add(A_0.Key, RuntimeHelpers.GetObjectValue(this.ooO_O.O_O..ooOOOO.0o.[A_0.Key]));
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x001F505C File Offset: 0x001F325C
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (ParentChildPair parentChildPair in this.ooO_O.O_O.)
				{
					parentChildPair.Parent.Controls.Add(parentChildPair.Holder);
					parentChildPair.Holder.DataRow["Delete"] = false;
					this.ooO_O.O_O..O0o._0..Add(parentChildPair.Holder);
					this.ooO_O.O_O..O0o._0..Add(parentChildPair.Holder.Key, this.ooO_O.O_O.[parentChildPair.Holder.Key]);
					this.ooO_O.O_O..o_0O.OO0_0_..Add(parentChildPair.Holder.Key, RuntimeHelpers.GetObjectValue(this.ooO_O.O_O.[parentChildPair.Holder.Key]));
					this.ooO_O.O_O..ooOOOO.0o..Add(parentChildPair.Holder.Key, RuntimeHelpers.GetObjectValue(this.O0_o.0.[parentChildPair.Holder.Key]));
				}
			}
			finally
			{
				List<ParentChildPair>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.ooO_O.O_O..OOOoO.Oo_O0o_0.();
			try
			{
				foreach (ParentChildPair parentChildPair in this.ooO_O.O_O.)
				{
					parentChildPair.Holder.Selected = true;
				}
			}
			finally
			{
				List<ParentChildPair>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x001F51FC File Offset: 0x001F33FC
		internal int <<EMPTY_NAME>>()
		{
			return this.ooO_O.O_O..Count;
		}

		// Token: 0x04001D52 RID: 7506
		internal o\u3002\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>;

		// Token: 0x04001D53 RID: 7507
		private List<ParentChildPair> <<EMPTY_NAME>>;

		// Token: 0x04001D54 RID: 7508
		private Dictionary<string, object> <<EMPTY_NAME>>;

		// Token: 0x04001D55 RID: 7509
		private Dictionary<string, object> <<EMPTY_NAME>>;

		// Token: 0x04001D56 RID: 7510
		internal Dictionary<string, PropertyBase> <<EMPTY_NAME>>;
	}
}
