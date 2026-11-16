using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003E7 RID: 999
	internal class o_O_O0O__ : ProgressBar
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x001D7954 File Offset: 0x001D5B54
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x001D7980 File Offset: 0x001D5B80
		public new object Value
		{
			get
			{
				object result;
				if (this.O00_o0_.O__oo. != null)
				{
					result = this.O00_o0_.O__oo.;
				}
				else
				{
					result = base.Value;
				}
				return result;
			}
			set
			{
				this.O00_o0_.O__oo. = RuntimeHelpers.GetObjectValue(value);
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

		// Token: 0x04001A4B RID: 6731
		private object <<EMPTY_NAME>>;
	}
}
