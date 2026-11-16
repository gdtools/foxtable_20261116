using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000437 RID: 1079
	internal class O___O_ : O_o_0o
	{
		// Token: 0x060048C9 RID: 18633 RVA: 0x001F5626 File Offset: 0x001F3826
		internal O___O_(string A_0)
		{
			this.Oo._o. = A_0;
			this.Oo._o. = new List<O___O_.O0O0>();
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x001F5640 File Offset: 0x001F3840
		internal void <<EMPTY_NAME>>(object A_0)
		{
			PropertyInfo property = A_0.GetType().GetProperty(this.Oo._o.);
			if (property != null)
			{
				this.Oo._o..Add(new O___O_.O0O0(RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue(property.GetValue(RuntimeHelpers.GetObjectValue(A_0), null))));
			}
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x001F568C File Offset: 0x001F388C
		internal virtual void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (O___O_.O0O0 o0O in this.Oo._o.)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(o0O.o_oO.O000_oOo.());
					objectValue.GetType().GetProperty(this.Oo._o.).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(o0O.Value), null);
					((PropertyBase)objectValue).Holder.Selected = true;
				}
			}
			finally
			{
				List<O___O_.O0O0>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001F5720 File Offset: 0x001F3920
		internal int <<EMPTY_NAME>>()
		{
			return this.Oo._o..Count;
		}

		// Token: 0x04001D71 RID: 7537
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D72 RID: 7538
		private List<O___O_.O0O0> <<EMPTY_NAME>>;

		// Token: 0x02000438 RID: 1080
		private class O0O0
		{
			// Token: 0x060048CD RID: 18637 RVA: 0x001F572D File Offset: 0x001F392D
			internal O0O0(object A_0, object A_1)
			{
				this.Oo._o. = RuntimeHelpers.GetObjectValue(A_0);
				this.o_oO.O000_oOo. = RuntimeHelpers.GetObjectValue(A_1);
			}

			// Token: 0x060048CE RID: 18638 RVA: 0x001F574D File Offset: 0x001F394D
			internal object <<EMPTY_NAME>>()
			{
				return this.Oo._o.;
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x060048CF RID: 18639 RVA: 0x001F5755 File Offset: 0x001F3955
			internal object Value
			{
				get
				{
					return this.o_oO.O000_oOo.;
				}
			}

			// Token: 0x04001D73 RID: 7539
			private object <<EMPTY_NAME>>;

			// Token: 0x04001D74 RID: 7540
			private object <<EMPTY_NAME>>;
		}
	}
}
