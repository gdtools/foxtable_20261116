using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x0200011E RID: 286
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MessageBoxForJs
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x000758AA File Offset: 0x00073AAA
		public MessageBoxForJs(WebViewer A_0)
		{
			this.Ooo_Oo_0O0o.0_. = null;
			this.Ooo_Oo_0O0o.0_. = A_0;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x000758C0 File Offset: 0x00073AC0
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x000758C8 File Offset: 0x00073AC8
		public string CallBack { get; set; }

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000758D1 File Offset: 0x00073AD1
		public void ShowDialog(params object[] args)
		{
			this.Show(args);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000758DC File Offset: 0x00073ADC
		public void Show(params object[] args)
		{
			MessageBoxForJs.O_O0o_0O0 o_O0o_0O = default(MessageBoxForJs.O_O0o_0O0);
			o_O0o_0O.oO.0OO_OoOoO0. = this;
			o_O0o_0O.o0_0._. = args;
			o_O0o_0O.o0_0._. = -1;
			o_O0o_0O.o0_0._. = AsyncVoidMethodBuilder.Create();
			o_O0o_0O.o0_0._..Start<MessageBoxForJs.O_O0o_0O0>(ref o_O0o_0O);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00075924 File Offset: 0x00073B24
		private DialogResult <<EMPTY_NAME>>(params object[] A_0)
		{
			DialogResult result;
			if (A_0.Length == 1)
			{
				result = MessageBox.Show(Conversions.ToString(A_0[0]));
			}
			else if (A_0.Length == 2)
			{
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]));
			}
			else if (A_0.Length == 3)
			{
				MessageBoxButtons buttons = (MessageBoxButtons)Conversions.ToInteger(A_0[2]);
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]), buttons);
			}
			else if (A_0.Length == 4)
			{
				MessageBoxButtons buttons2 = (MessageBoxButtons)Conversions.ToInteger(A_0[2]);
				MessageBoxIcon icon = (MessageBoxIcon)Conversions.ToInteger(A_0[3]);
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]), buttons2, icon);
			}
			return result;
		}

		// Token: 0x040005CD RID: 1485
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040005CE RID: 1486
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0200011F RID: 287
		[CompilerGenerated]
		internal sealed class OoO0o0o0_O
		{
			// Token: 0x06000ED4 RID: 3796 RVA: 0x000759C8 File Offset: 0x00073BC8
			internal void <<EMPTY_NAME>>()
			{
				if (OO_00oOO.BaseMainForm != null)
				{
					OO_00oOO.BaseMainForm.Invoke((this.o0_0._. == null) ? (this.o0_0._. = new $UNNAMED_TYPE$(this.OOoO_0oo.0_.)) : this.o0_0._.);
				}
			}

			// Token: 0x06000ED5 RID: 3797 RVA: 0x00075A0C File Offset: 0x00073C0C
			internal void <<EMPTY_NAME>>()
			{
				DialogResult dialogResult = this.o0_0._..Ooo_Oo_0O0o.0_.(this.o0_0._.);
				if (!string.IsNullOrEmpty(this.o0_0._..CallBack))
				{
					string script = string.Format("{0}({1})", this.o0_0._..CallBack, (int)dialogResult);
					this.o0_0._..Ooo_Oo_0O0o.0_..ExecuteScriptAsync(script);
				}
			}

			// Token: 0x040005CF RID: 1487
			public object[] <<EMPTY_NAME>>;

			// Token: 0x040005D0 RID: 1488
			public MessageBoxForJs <<EMPTY_NAME>>;

			// Token: 0x040005D1 RID: 1489
			public $UNNAMED_TYPE$ <<EMPTY_NAME>>;
		}
	}
}
