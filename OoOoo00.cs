using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000273 RID: 627
	internal class OoOoo00 : TrackBar
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x000D0DA8 File Offset: 0x000CEFA8
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x000D0DD4 File Offset: 0x000CEFD4
		internal new object Value
		{
			get
			{
				object result;
				if (this.o0Ooo_O0oo.O__. != null)
				{
					result = this.o0Ooo_O0oo.O__.;
				}
				else
				{
					result = base.Value;
				}
				return result;
			}
			set
			{
				this.o0Ooo_O0oo.O__. = RuntimeHelpers.GetObjectValue(value);
				if (value == DBNull.Value || value == null)
				{
					base.Value = 0;
					return;
				}
				int val;
				if (int.TryParse(value.ToString(), out val))
				{
					base.Value = Math.Min(base.Maximum, Math.Max(base.Minimum, val));
					return;
				}
				base.Value = 0;
			}
		}

		// Token: 0x04000CCC RID: 3276
		private object <<EMPTY_NAME>>;
	}
}
