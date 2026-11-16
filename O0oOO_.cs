using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000432 RID: 1074
	internal class O0oOO_ : O_o_0o
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x001F53B0 File Offset: 0x001F35B0
		internal O0oOO_(string A_0, FormProperty A_1)
		{
			this.o.o0o. = A_1;
			this.o.o0o. = A_0;
			PropertyInfo property = A_1.GetType().GetProperty(A_0);
			this.o.o0o. = RuntimeHelpers.GetObjectValue(property.GetValue(A_1, null));
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x001F53F4 File Offset: 0x001F35F4
		internal void <<EMPTY_NAME>>()
		{
			this.o.o0o..GetType().GetProperty(this.o.o0o.).SetValue(this.o.o0o., RuntimeHelpers.GetObjectValue(this.o.o0o.), null);
			((o\u3000\u3002)this.o.o0o..Form.MdiParent).O0.0O00_O.().SelectedIndex = 0;
			((o\u3000\u3002)this.o.o0o..Form.MdiParent).O0.0O00_O.().Refresh();
		}

		// Token: 0x04001D64 RID: 7524
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D65 RID: 7525
		private FormProperty <<EMPTY_NAME>>;

		// Token: 0x04001D66 RID: 7526
		private object <<EMPTY_NAME>>;
	}
}
